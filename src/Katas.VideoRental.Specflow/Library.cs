using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.VideoRental.Specflow
{
    public class Library
    {
        public List<Title> Titles { get; private set; }

        public Library()
        {
            Titles = new List<Title>();
        }

        public void AddTitleToLibrary(Title title)
        {
            Titles.Add(title);
        }
    }
}
