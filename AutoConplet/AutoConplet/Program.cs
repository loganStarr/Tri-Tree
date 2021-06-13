using System;
using System.Collections.Generic;

namespace AutoConplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Tries tries = new Tries();
            tries.Add("hello");
            tries.Add("hi");
            tries.Add("how");
            tries.Add("are");
            tries.Add("art");
            tries.Add("he");
            tries.Add("word");
            List<string> WordsFromPrfix = new List<string>();
            WordsFromPrfix = tries.Complete("ar");
            ;
            ;
        }
    }
}
