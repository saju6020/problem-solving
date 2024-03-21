using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    internal class KillAllMonster
    {
        public void KillAll()
        {

            int numOfInput = Convert.ToInt16(Console.ReadLine());
            List<List<int>> inputs = new List<List<int>>();

            List<List<int>> outputs = new List<List<int>>();

            while (numOfInput > 0)
            {
                Console.ReadLine();
                inputs.Add(Console.ReadLine().Split(" ").Select(int.Parse).ToList());
                numOfInput--;
            }

            int outputIndex = 0;
            foreach (var item in inputs)
            {

                List<int> outputRow = new List<int>();
                List<int> currentMonsterList = new List<int>();
                currentMonsterList.Add(item[0]);
                outputRow.Add(currentMonsterList.Count());

                for (int i = 1; i < item.Count(); i++)
                {

                    currentMonsterList.RemoveAll(c => c <= item[i]);
                    currentMonsterList.Add(item[i]);
                    outputRow.Add(currentMonsterList.Count());
                }

                outputs.Add(outputRow);
                outputIndex++;
            }


            foreach (var item in outputs)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
