using System.Collections.Generic;

namespace Katas.VideoRental.Specflow
{
    public interface ILibrary
    {
        Dictionary<Title, int> Titles { get; }

        void AddTitleToLibrary(Title title);
        Dictionary<Title, int> GetLibrary();
    }
}