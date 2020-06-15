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
        

        //public string FindRepeatedWord(string inputString)
        //{
        //    string inputString;
        //    var dictionaryTracker = new Dictionary<string, bool>();
        //    StringBuilder outputString = new StringBuilder();
        //    string[] eachWord = inputString.Split(new char[] { ' ', ',', ';', '.' },
        //        StringSplitOptions.RemoveEmptyEntries);

        //    foreach (string current in eachWord)
        //    {
        //        string lowerCase = current.ToLower();

        //        if (dictionaryTracker.ContainsKey(lowerCase))
        //        {
        //            outputString.Append(current);
        //            dictionaryTracker.Add(lowerCase, true);
        //        }

        //    }

        //    return outputString.ToString();
        //}
    }
}
