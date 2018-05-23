using System;

class P4
{
	static void Main()
	{
		int p = 0;
		bool b;
		for (int i = 0; i<=999; i++)
		{
			for(int j = 0; j<=999; j++)
			{
				b = check(j*i);
				
				if(b)
				{
					//Console.Write((j*i) + " ");
					if((j*i)>p)
					{
					p = j*i;
					}
					//Console.WriteLine(i + " " + j);
				}
			}
		}	
		Console.WriteLine(p);
	}
	static bool check(int a)
	{
		string c = a.ToString();
		for(int v = 0; v< c.Length/2;v++)
		{
			if(c[v]!=c[c.Length-1-v])
			{
			return false;
			}
		}
		return true;
	}
}
