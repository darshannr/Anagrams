using System.Collections.Generic;

namespace DomainLayer
{
    public interface IAnagrams
    {
        List<string> GetAnagrams(string inputword);
        void PrintResult(List<string> anagramList);
    }
}