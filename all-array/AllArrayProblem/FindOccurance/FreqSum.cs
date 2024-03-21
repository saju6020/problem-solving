using System.Collections.Generic;
using System;
using System.Linq;

internal class FreqSumMethods
{
    public static void FindFreqSum()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] inputArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int[] freqArray = new int[10000001];
        int[] sumArray = new int[10000001];
        int maxValue = 0;
        List<int> outputs = new List<int>();

        for (int i = 0; i < arraySize; i++)
        {
            freqArray[inputArray[i]] = freqArray[inputArray[i]] + 1;            
        }

        for (int i = 0; i <arraySize; i++)
        {
            sumArray[freqArray[inputArray[i]]] = sumArray[freqArray[inputArray[i]]] + inputArray[i];
        }

        for(int i= 2; i<= 1000000; i++)
        {
            sumArray[i] = sumArray[i] + sumArray[i - 1];
        }

        int freqRangeInputCount = int.Parse(Console.ReadLine());
        int ans = 0;
        for (int index = 0; index < freqRangeInputCount; index++)
        {
            string[] inputRange = Console.ReadLine().Split(" ");

            int sum = 0;
            int freqIndexStart = int.Parse(inputRange[0]);
            int freqIndexEnd = int.Parse(inputRange[1]);
            
            ans = sumArray[freqIndexEnd];

            if(freqIndexStart > 0)
            {
                ans = ans - sumArray[freqIndexStart - 1];
            }
           
            outputs.Add(ans);
        }

        foreach (var item in outputs)
        {
            Console.WriteLine(item);
        }
    }
}