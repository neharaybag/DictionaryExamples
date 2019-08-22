using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Dictionary<string, int> values = new Dictionary<string,int>();

            List<String> words = new List<String> { "is", "there", "anyone","Cake","is","tasty","is","there","icecream","eat","Cake" };

            // Store number of occurances of words in dictionary
            foreach(var word in words)
            {
                if(values.ContainsKey(word))
                {
                    int val = 0;
                    values.TryGetValue(word,out val);
                    values[word] = val + 1;
                }
                else
                {
                    values.Add(word, 1);
                }
            }


            // Print all key and values in dictionary
            foreach (KeyValuePair<string, int> pair in values)
            {
                
                Console.WriteLine("Key = {0}, Value = {1}", pair.Key, pair.Value);
            }



            // Hashtable examples
            Console.WriteLine("HashTable print");

            Hashtable hashtable = new Hashtable();
            hashtable.Add("test", 2);
            hashtable.Add(11, 4);
            hashtable.Add("Pune", "PNQ");

            foreach (DictionaryEntry pair in hashtable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1} ",
                                   pair.Key, pair.Value);
            }

            Console.ReadLine();

        }
    }
}
