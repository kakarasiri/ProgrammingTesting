using System;

namespace DuplicatedNumber
{
    class Program
    {




        static void Main(string[] args)
        {
            int[] array = { 2, 4, 88, 2, 78, 88, 34 };
            for(int i=0; i<array.Length; i++)
            {
                for(int j=i+1; j<array.Length; j++)
                {
                    if(array[i] == array[j])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
        }
    }
}
