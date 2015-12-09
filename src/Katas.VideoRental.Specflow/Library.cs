using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class Library : ILibrary
    {
        public Dictionary<Title, int> Titles { get; private set; }

        public Library()
        {
            Titles = new Dictionary<Title, int>();
        }

        public void AddTitleToLibrary(Title title)
        {
            if (Titles.ContainsKey(title))
            {
                Titles[title]++;
            }
            else
            {
                Titles.Add(title, 1);
            }
        }

        public Dictionary<Title,int> GetLibrary()
        {
            return Titles;
        }
    }
}
