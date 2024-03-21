using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllArrayProblem
{
    class FindDigits
    {
        public static bool IsDigitExist(int[] nums, string digit)
        {
            return nums.Select(n => $"{n}").Any(a => a.Contains(digit));           
            
        }
    }
}
