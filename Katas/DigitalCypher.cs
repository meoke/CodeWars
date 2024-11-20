using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

namespace Katas;

// Digital Cypher assigns to each letter of the alphabet unique number. For example:

//  a  b  c  d  e  f  g  h  i  j  k  l  m
//  1  2  3  4  5  6  7  8  9 10 11 12 13
//  n  o  p  q  r  s  t  u  v  w  x  y  z
// 14 15 16 17 18 19 20 21 22 23 24 25 26
// Instead of letters in encrypted word we write the corresponding number, eg. The word scout:

//  s  c  o  u  t
// 19  3 15 21 20
// Then we add to each obtained digit consecutive digits from the key. For example. In case of key equal to 1939 :

//    s  c  o  u  t
//   19  3 15 21 20
//  + 1  9  3  9  1
//  ---------------
//   20 12 18 30 21
  
//    m  a  s  t  e  r  p  i  e  c  e
//   13  1 19 20  5 18 16  9  5  3  5
// +  1  9  3  9  1  9  3  9  1  9  3
//   --------------------------------
//   14 10 22 29  6 27 19 18  6  12 8
// Task
// Write a function that accepts str string and key number and returns an array of integers representing encoded str.

// Input / Output
// The str input string consists of lowercase characters only.
// The key input number is a positive integer.

// Example
// Encode("scout",1939);  ==>  [ 20, 12, 18, 30, 21]
// Encode("masterpiece",1939);  ==>  [ 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8]

public class DigitalCypher
{
	private static Dictionary<char,int> _encodingTable = new()
    {
			{'a', 1}, 
			{'b', 2},
			{'c', 3},
			{'d', 4},
			{'e', 5},
			{'f', 6},
			{'g', 7},
			{'h', 8},
			{'i', 9},
			{'j', 10},
			{'k', 11},
			{'l', 12},
			{'m', 13},
			{'n', 14},
			{'o', 15},
			{'p', 16},
			{'q', 17},
			{'r', 18},
			{'s', 19},
			{'t', 20},
			{'u', 21},
			{'v', 22},
			{'w', 23},
			{'x', 24},
			{'y', 25},
			{'z', 26}
			};
	public static int[] Encode(string str, int key)
	{
		
		var str_numbers = ConvertToNumbers(str);
		var key_digits = GetDigits(key);
		var result = str_numbers.Select((x,i) => x + key_digits[i % key_digits.Count]);

	   return result.ToArray();
	}

    public static IEnumerable<int> ConvertToNumbers(string str)
    {
		return str.Select(letter => _encodingTable[letter]);
    }

    public static IList<int> GetDigits(int number)
    {
		if(number == 0)
			return [0];

		var digits = new List<int>();
		while(number > 0)
		{
			digits.Add(number % 10);
			number /= 10;
		}
		digits.Reverse();
        return digits;
    }

}
