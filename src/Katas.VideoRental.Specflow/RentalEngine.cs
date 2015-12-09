using System.Collections.Generic;
using Katas.VideoRental.Specflow.Models;

namespace Katas.VideoRental.Specflow.UnitTest
{
    public class RentalEngine
    {
        private ILibrary _library;
        private IEmailServices _emailServices;
        private Registry _registry;
        private CMSEntries _cmsEntries;

        private List<Rental> RentalList;

        public RentalEngine():this(new Library(), new EmailServices(), new Registry(), new CMSEntries())
        {
            
        }

        public RentalEngine(ILibrary library, IEmailServices emailServices, Registry registry, CMSEntries cmsEntries)
        {
            RentalList = new List<Rental>();
            _library = library;
            _emailServices = emailServices;
            _registry = registry;
            _cmsEntries = cmsEntries;
        }

        public void UserRentsTitle(User user, Title title)
        {
            RentalList.Add(new Rental(user,title));
        }

        public List<Rental> GetRentals()
        {
            return RentalList;
        }

        public void UserDonatesTitle(User user, Title title)
        {
            _library.AddTitleToLibrary(title);
            _registry.AddLoyaltyPointsToUser(user, _cmsEntries.PriorityPointsForSingleRental);
        }
        
    }
}