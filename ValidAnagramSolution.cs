using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.LeetCodeProblems
{
    public class ValidAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            else
            {
                int[] counter = new int[26];
                for (int i=0; i < s.Length; i++)
                {
                    counter[s[i] - 'a']++;
                    counter[t[i] - 'a']--;
                }

                foreach(int i in counter)
                {
                    if(i != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
