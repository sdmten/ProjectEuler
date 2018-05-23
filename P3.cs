using System;

class P3
{
	static void Main()
	{
		bool p = false;
		long h = 0;
		for(long i = 3; i < Math.Ceiling(Math.Pow(600851475143, 0.5)); i+=2)
		{
			if (600851475143 % i==0)
			{
				p = prime(i);
				if(p == true)
				{
					h = i;
					p = false;
				}
			}
		}
		Console.WriteLine(h);
	}
	static bool prime(long a)
	{
		for(long b = 3; b< Math.Ceiling(Math.Pow(a,0.5)); b+=2)
		{
			if ( a%b == 0)
			{
				return false;
			}
		}
		return true;
	}
}