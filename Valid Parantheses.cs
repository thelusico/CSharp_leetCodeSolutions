using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCodeTests
{
	public class Parantheses
	{
		static void Main(string[] args)
		{


			Console.WriteLine(IsValid("([]{})"));

			Console.ReadLine();

		}

		public static bool IsValid(string s)
		{
			/*Create a Stack to store opening parantheses*/
			Stack myStack = new Stack();

			/*Loop every char in the string*/
			foreach (char c in s)
			{
				/*If it is a 'Open bracket' - add to the stack*/
				if (c == '(' || c == '{' || c == '[')
				{
					myStack.Push(c);
				}

				/*If there are no 'open brackets' - return false*/
				if (myStack.Count == 0)
                {
					return false;
                }
				else if(c == ')' || c == '}' || c == ']')
                {
					/*Search for the corresponding bracket at the top of the stack, if they dont match it means they are out of order - return false
					 * else (Matched open and close brackets) remove from the stack ()*/
					if (c == ')' && myStack.Peek().ToString() != "(") {
						return false;
                    }
					else if (c == '}' && myStack.Peek().ToString() != "{") { 
						return false;
					}
					else if (c == ']' && myStack.Peek().ToString() != "[") { 
						return false;
					}
					else myStack.Pop();
				}							
			}

			/*If the stack has CHRS, it means that the brackets are out of order - return false*/
			if (myStack.Count != 0)
			{
				return false;
			}

			/*if we could remove all of them - it means they are in order (open and close) - return true*/
			return true;

		}
	}
}
