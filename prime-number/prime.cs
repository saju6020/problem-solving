using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int totalTestCase = Convert.ToInt32(Console.ReadLine());
        
        for(int readIndex = 0; readIndex < totalTestCase; readIndex++)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());            
            int inputNumberSqrt = Convert.ToInt32(Math.Sqrt(inputNumber));
            bool isPrime = true;
            
            for(int devider = 2; devider <= inputNumberSqrt; devider++)
            {
                if(inputNumber % devider == 0)
                {
                    isPrime = false;                    
                }
            }
            
            if(isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}