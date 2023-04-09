using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    internal class NewsSite : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        private string latestNews;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(latestNews);
            }
        }

        public void PublishNews(string news)
        {
            Console.WriteLine("News Published: " + news);
            latestNews = news;
            NotifyObservers();
        }
    }
}
