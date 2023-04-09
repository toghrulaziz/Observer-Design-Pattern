using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    internal class NewsReader : IObserver
    {
        private string name;
        private IObservable subject;

        public NewsReader(string name, IObservable subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void Update(string news)
        {
            Console.WriteLine(name + " reader named, new news: " + news);
        }
    }
}
