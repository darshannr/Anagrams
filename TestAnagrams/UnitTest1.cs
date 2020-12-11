using System.Collections.Generic;
using DomainLayer;
using NUnit.Framework;

namespace TestAnagrams
{
    public class Tests
    {
        private Anagrams _anagramsService;
        [SetUp]
        public void Setup()
        {
            _anagramsService = new Anagrams();
        }

        [Test]
        public void TestBlank()
        {
            List<string> resultList = _anagramsService.GetAnagrams("");
            Assert.IsTrue(resultList.Count == 0, "Blank Test");
        }
        [Test]
        public void TestNull()
        {
            List<string> resultList = _anagramsService.GetAnagrams(null);
            Assert.IsTrue(resultList.Count == 0, "NUll Test");
        }
        [Test]
        public void Test1()
        {
            List<string> resultList = _anagramsService.GetAnagrams("cat");
            Assert.IsTrue(resultList.Contains("act"), "Word Cat Test");
        }
        [Test]
        public void Test2()
        {
            List<string> resultList = _anagramsService.GetAnagrams("cat");
            Assert.IsFalse(resultList.Contains("dad"), "Pass");
        }
        [Test]
        public void Test3()
        {
            List<string> resultList = _anagramsService.GetAnagrams("are");
            Assert.IsFalse(resultList.Count > 0, "Fail");
        }
        [Test]
        public void Test4()
        {
            List<string> resultList = _anagramsService.GetAnagrams("are");
            Assert.IsTrue(resultList.Count > 0, "Pass");
        }
    }
}