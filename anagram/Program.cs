using System;
using System.Collections.Generic;
using DomainLayer;


namespace anagram
{
    class Program
    {


        static void Main(string[] args)
        {
            string inputWord = string.Empty;
            List<string> anagramList = new List<string>();

            // Read Input from User and store it in inputword
            Console.WriteLine("Enter a word to find its Anagrams from the file: ");
            inputWord = Console.ReadLine();

            // Obtain Anagrams for the input from user against the file
            Anagrams _anagramsService = new Anagrams();
            anagramList = _anagramsService.GetAnagrams(inputWord);

            //Print the resulted Anagrams
            Console.WriteLine("The List of Anagrams from the file are as below:");
            _anagramsService.PrintResult(anagramList);

        }


    }



}
