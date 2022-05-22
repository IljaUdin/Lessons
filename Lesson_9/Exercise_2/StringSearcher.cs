using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise_2
{
    
    class StringSearcher
    {
        public delegate void DelegateString(string stringsearch);
        
        public event DelegateString EventString;
        public string ResultSearch { get; private set; }
        public void Search(List<string> list, string whatWeSearch)
        {
            Regex regex = new Regex(whatWeSearch);
            for (int i = 0; i < list.Count; i++)
            {
                MatchCollection matches = regex.Matches(list[i]);
                if (matches.Count > 0)
                {
                    ResultSearch = list[i];
                    EventString?.Invoke($"Найдено совпадение : {ResultSearch}");
                    Console.WriteLine("Желаете продолжить поиск? (Y/N) : ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "n")
                    {
                        break;
                    }
                }
            }
        }
    }
}
