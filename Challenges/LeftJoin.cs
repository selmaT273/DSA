using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    public class LeftJoin
    {
        public static string PerformLeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            
            string outputString = "";

            Dictionary<string, Combined> combined = new Dictionary<string, Combined>();

            foreach (KeyValuePair<string, string> pair in synonyms)
            {
                combined.Add(pair.Key, new Combined(pair.Value));
            }

            foreach (KeyValuePair<string, string> pair in antonyms)
            {
                if (combined.ContainsKey(pair.Key) == true)
                {
                    combined[pair.Key].Antonym = pair.Value;
                }
            }

            foreach (KeyValuePair<string, Combined> pair in combined)
            {
                outputString += "[" + pair.Key + ", " + pair.Value.Synonym + ", " + pair.Value.Antonym + "], \n";
            }


            

            return outputString.Substring(0, outputString.Length - 3);
        }
    }

    public class Combined
    {
        public string Antonym { get; set; }
        public string Synonym { get; set; }

        public Combined(string synonym) {
            Synonym = synonym;
            Antonym = "NULL";
        }
    }
}
