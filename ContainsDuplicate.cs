using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.LeetCodeProblems
{
    public class ContainsDuplicateSolution
    {

        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> uniqueNum = new HashSet<int>();

            for(int i=0; i < nums.Length; i++)
            {
                if (uniqueNum.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    uniqueNum.Add(nums[i]);
                }
                
            }
            return false;
        }

    }
}
