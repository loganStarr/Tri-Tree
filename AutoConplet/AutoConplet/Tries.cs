using System;
using System.Collections.Generic;
using System.Text;

namespace AutoConplet
{
    public class Tries
    {
        public Nodes<char> Head;
        public Tries()
        {
            Head = new Nodes<char>('d');
        }
        public Nodes<char> FindSomeStuff(string Finder, Nodes<char> Current)
        {
            int d = 0;
            bool dnd = false;
            while (Finder.Length > d)
            {
                for (int i = 0; i < Current.list.Count; i++)
                { 
                    if(Finder[d] == Current.list[i].val)
                    {
                        Current = Current.list[i];
                        d++;
                        dnd = true;
                        break;
                    }
                }
                if (dnd != true)
                {
                    return null;
                }
                dnd = false;
            }
            return Current;
        } 
        public void Add(string val)
        {


            Nodes<char> d = Head;
            bool dd = true;
            while (dd && val != "")
            {
                dd = false;
                for (int i = 0; i < d.list.Count; i++)
                {
                    if (d.list[i].val == val[0])
                    {
                        d = d.list[i];
                        dd = true;
                        string s = "";
                        for (int e = 1; e < val.Length; e++)
                        {
                            s += val[e];
                        }
                        val = s;
                        break;
                    }
                }
            }
            while (val != "")
            {
                d.list.Add(new Nodes<char>(val[0]));
                d = d.list[d.list.Count - 1];
                string s = "";
                for (int e = 1; e < val.Length; e++)
                {
                    s += val[e];
                }
                val = s;
            }
            d.IsWord = true;
        }
        public void Remove(string Prefix)
        {
            Nodes<char> d = Head;
            bool dthi = false;
            while (Prefix != "")
            {
                for (int i = 0; i < d.list.Count; i++)
                {
                    if (d.list[i].val == Prefix[0])
                    {
                        string s = "";
                        for (int e = 1; e < Prefix.Length - 1; e++)
                        {
                            s += Prefix[e];
                        }
                        Prefix = s;
                        dthi = true;
                    }
                }
                if (dthi == false)
                {
                    return;
                }
                dthi = false;
            }
            d.IsWord = false;
        }
        public void Clear()
        {
            Head.list.Clear();
        }
        public bool Contances(string word)
        {
            if (FindSomeStuff(word,Head) == null)
            {
                return false;
            }
            return false;
        }

        private void DFS(Nodes<char> current, string currentPrfix, List<string> words)
        {
            //Continue calling DFS until current is a word 
            //Once it is add it to the words list
            if (current.IsWord)
            {
                currentPrfix += current.val;
                words.Add(currentPrfix);
            }
            for (int i = 0; i < current.list.Count; i++)
            {
                if (current.list[i].IsWord == true)
                { 
                    DFS(current.list[i], currentPrfix, words);
                }
            }
        }

        public List<string> Complete(string prefix)
        {
            //Loop until you find the last letter of the prefix in the tree (if its not there throw an exception)
            Nodes<char> StartingNode = FindSomeStuff(prefix, Head);
            List<string> Words = new List<string>();
            DFS(StartingNode,prefix,Words);
            return Words;
        }
        #region Don't open
        #region No
        /* public List<string> CompetPrefixStuff(string Prefix)
         { 
             Queue<Nodes<char>> Stuff = new Queue<Nodes<char>>();
             for (int i = 0; i < Head.list.Count; i++)
             {
                 if (Head.list[i].val == Prefix[0])
                 {
                     Stuff.Enqueue(Head.list[i]);
                 }
             }
             List<Nodes<char>> words = new List<Nodes<char>>();
             int iss = 1;
             while (Stuff.Count > 0)
             {
                 Nodes<char> s = Stuff.Dequeue();
                 if (s.IsWord == true)
                 {
                     words.Add(s);
                 }
                 for (int i = 0; i < s.list.Count; i++)
                 {
                     if (s.list[i].val == Prefix[iss])
                     {
                         Stuff.Enqueue(s.list[i]);
                     }
                 }
             }
             return words;
         }*/
        #endregion
        #endregion
    }
}
