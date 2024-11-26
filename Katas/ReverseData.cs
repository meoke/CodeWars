using System;

namespace Katas;

public class ReverseData
{
	public static int[] DataReverse(int[] data)
	{
		var bytesCount = data.Length / 8;
		var reversedData = new int[data.Length];
		for(var i = 0; i<bytesCount ; i++)
		{
			for(var j = 0; j<8 ; j++)
			{
				reversedData[(bytesCount-i-1)*8+j] = data[i*8 + j];
			}
		}
		return reversedData;

	}

}
