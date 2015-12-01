namespace Katas.VideoRental.Specflow
{
    public class Title
    {
        public string TitleName { get; private set; }
        public string Director { get; private set; }
        public int YearOfRelease { get; private set; }
        public int NumberOfCopies { get; private set; }

        public Title(string titleName, string director, int yearOfRelease, int numberOfCopies)
        {
            TitleName = titleName;
            Director = director;
            YearOfRelease = yearOfRelease;
            NumberOfCopies = numberOfCopies;
        }
    }
}