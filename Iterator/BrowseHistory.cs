using System.Collections.Generic;

namespace IteratorPattern
{
    // dotnet implementation of Iterator pattern
    public class BrowseHistory : IEnumerable<string>
    {
        private string[] urls = new string[10];
        private int count;
        public void Push(string url)
        {
            urls[count++] = url;
        }

        public string Pop()
        {
            return urls[--count];
        }

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return urls[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    // TODO Custom implementation of Iterator pattern


    public interface Iterator<T>
    {
        T Current();
        bool HasNext();
        void Next();
    }

    public class Demo : IDemo
    {
        public void Run()
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            foreach (var url in history)
            {
                System.Console.WriteLine(url);
            }
        }
    }
}