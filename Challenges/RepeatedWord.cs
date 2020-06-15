using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class RepeatedWord
    {
        public static string FirstRepeating(string inputStr)
        {
            string[] words = inputStr.Split(' ');

            Dictionary<string, int> d = new Dictionary<string, int>();

            for (int i = 0; i <= words.Length - 1; i++)
            {
                string s = words[i];

                if (d.ContainsKey(s))
                {
                    return s;
                }
                else
                {
                    d.Add(s, 1);
                }
            }

            return null; 
        }
    }
}
