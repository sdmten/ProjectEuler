using System;
using System.Collections.Generic;

class P10
{
    static void Main()
    {
        int limit = 2000000000;
        bool[] sieve = new bool[limit];
        int rootlimit = (int)Math.Ceiling(Math.Pow(sieve.Length,0.5));
        System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Sergei Ten\\Desktop\\test.txt");
        for(int j = 4; j < limit; j+=2)
        {
            sieve[j] = true;
        }
        for(int i = 3; i < rootlimit; i+=2)
        {
            if(!sieve[i])
            {
                for(int k = (int)Math.Pow(i,2); k < limit; k+=(2*i))
                {
                    sieve[k] = true;
                }
            }
        }
        for(int l = 2; l < limit; l++)
        {
            if(!sieve[l])
            {
                file.WriteLine(l);
            }
        }
        file.Close();
    }
}