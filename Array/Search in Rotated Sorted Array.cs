using System;

public class Class1
{
	public Class1()
	{
		static int Sort(int[] num,int target)
		{
			int min = 0;
			int max = num.Length - 1;
			while(max >= min)
			{
				int mid = min + (max - min) / 2;
				if (num[mid] == target)
				{
					return mid;
				}
				if (num[mid] >= num[min])
				{
					if(target >= num[min] &&  target <= num[mid])
					{
						max = mid - 1;
					}
					else
					{
						min = mid + 1;
					}
				}
				else
				{
					if(target > num[mid] && target =< num[max] )
					{
						min = mid + 1;
					}
					else
					{
						max = mid - 1;
					}
				}
			}
			return -1;
		}
		static void Main()
		{
			int[] num = { 4, 5, 6, 7, 0, 1, 2 };
			int tagrget = 0;
			int result = Sort(num, target);
			Console.Write("Output is" + result);
	}
}
