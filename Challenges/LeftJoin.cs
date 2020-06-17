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

            //foreach (KeyValuePair<string, string> pair in Synonyms)
            //{
            //    outputString += pair.Key + ": " + pair.Value;
            //}

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


            //var joinResult = from sElements in Synonyms
            //                 join aElements in Antonyms
            //                 on sElements.Key equals aElements.Key into outputResult
            //                 from result in outputResult.DefaultIfEmpty()
            //                 select (sElements.Key, result.Value);

            return outputString;
        }
    }

    public class Combined
    {
        public string Antonym { get; set; }
        public string Synonym { get; set; }

        public Combined(string synonym) { Synonym = synonym; }
    }
}
