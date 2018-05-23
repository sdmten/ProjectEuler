using System;
using System.Collections.Generic;

class P10
{
    static void Main()
    {
        List<int> primes = new List<int>();
        primes.Add(2);
        //float sum = 2;
        System.IO.StreamReader input = new System.IO.StreamReader("C:\\Users\\Sergei Ten\\Desktop\\primes2.txt");
        string line = "";
        bool prime = true;
        while((line = input.ReadLine()) != null)
        {
            primes.Add(int.Parse(line));
        }
        System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Sergei Ten\\Desktop\\primes3.txt");
        for(int i = primes[primes.Count-1]; i < 2000000; i+=2)
        {
            foreach(int a in primes)
            {
                if(a <= Math.Pow(i,0.5))
                {
                    if(i%a == 0)
                    {
                        prime = false;
                    }
                }
            }
            if(prime)
            {
                file.WriteLine(i);
                primes.Add(i);
                //sum+=i;
            }
            prime = true;
        }
        //Console.WriteLine(sum);
        file.Close();
    }
}