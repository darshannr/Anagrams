using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace DomainLayer
{
    public class Anagrams : IAnagrams
    {

        public List<string> GetAnagrams(string inputword)
        {
            List<String> resultList = new List<string>();
            if (inputword != string.Empty && inputword != null)
            {

                List<string> wordsFromFileList = System.IO.File.ReadLines("/Users/darshanraviprakash/Projects/anagram/Wordlist.txt").ToList();
                wordsFromFileList.Sort();
                foreach (var word in wordsFromFileList)
                {
                    if (Helper.GetHashCode(Helper.Alphabetize(inputword.ToLower().Trim())) == Helper.GetHashCode(Helper.Alphabetize(word.ToLower().Trim())))
                    {
                        resultList.Add(word);
                    }
                }
            }
            return resultList;


        }

        public void PrintResult(List<string> anagramList)
        {
            Helper.PrintResultAnagrams(anagramList);
        }
    }
}
