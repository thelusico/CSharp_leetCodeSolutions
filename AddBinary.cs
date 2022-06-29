using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.LeetCodeProblems
{

    /*
     Given two binary strings a and b, return their sum as a binary string.

     Example:
     Input: a = "11", b = "1"
     Output: "100"
     
     */

    public class AddBinary
    {

        public string AddBinarySolution(string a, string b)
        {
            string result = "";
            int i = a.Length - 1;
            int j = b.Length - 1;
            int sum, carry = 0; 

            while(i >= 0 || j >= 0)
            {
                sum = carry;
                if(i >= 0) sum += a[i] - '0';
                if(j >= 0) sum += b[j] - '0';
                result += (sum % 2).ToString();
                carry = sum / 2;
                i--;
                j--;
            }
            if (carry != 0) result += '1';
            return new string(result.Reverse().ToArray());

        }


    }
}
