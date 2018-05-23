using System;

class P5
{
	static void Main()
	{
		bool p = false;
		int a = 1;
		while(true)
		{
			for(int i = 1;i<=20;i++)
			{
				if(a%i!=0)
				{
					p = false;
					break;
				}
				p = true;
			}
			if(p==true)
			{
				break;
			}
			a++;
		}
		Console.WriteLine(a);
	}
}