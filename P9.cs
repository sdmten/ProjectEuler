using System;

class P9
{
    static void Main()
    {
        double temp = 0;
        for(int i = 0; i <=1000; i++)
        {
            for(int j = 0; j <= 1000; j++)
            {
                if((i + j) > 1000)
                {
                    break;
                }
                temp = Math.Pow(Math.Pow(i,2)+Math.Pow(j,2),0.5);
                if((i + j + temp) == 1000)
                {
                    Console.WriteLine(i + " " + j + " " + temp);
                }
            }
        }
    }
}