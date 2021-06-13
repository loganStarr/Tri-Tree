using System;
using System.Collections.Generic;
using System.Text;

namespace AutoConplet
{
    public class Nodes<T>
    {
        public List<Nodes<char>> list;
        public T val;
        public bool IsWord;
        public Nodes(T vas)
        {
            list = new List<Nodes<char>>();
            val = vas;
        }

    }
}
