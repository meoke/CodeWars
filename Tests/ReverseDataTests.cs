using Katas;
using System;
using NUnit.Framework;

namespace Tests;

[TestFixture]
public class ReverseDataTests {

    [Test, Order(1)]
    public static void test1() {
        int[] data1= new int [32] {1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0};
        int[] data2= new int [32] {1,0,1,0,1,0,1,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1};
        Assert.That(ReverseData.DataReverse(data1), Is.EqualTo(data2));
    }

    [Test, Order(2)]
    public static void test2() {
        int[] data1= new int [16] {0,0,1,1,0,1,1,0,0,0,1,0,1,0,0,1};
        int[] data2= new int [16] {0,0,1,0,1,0,0,1,0,0,1,1,0,1,1,0};
        Assert.That(ReverseData.DataReverse(data1), Is.EqualTo(data2));
    }
    
}