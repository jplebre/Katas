using System.Collections.Generic;

namespace Katas.VideoRental.Specflow.UnitTest
{
    public class RentalEngine
    {
        private Library _library;
        private IEmailServices _emailServices;
        private Registry _registry;

        private List<Rental> RentalList; 

        public RentalEngine():this(new Library(), new EmailServices(), new Registry())
        {
            
        }

        public RentalEngine(Library _library, IEmailServices _emailServices, Registry _registry)
        {
            RentalList = new List<Rental>();
        }

        public void UserRentsTitle(User user, Title title)
        {
            RentalList.Add(new Rental(user,title));
        }

        public List<Rental> GetRentals()
        {
            return RentalList;
        }

    }
}