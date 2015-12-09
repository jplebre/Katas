using System;

namespace Katas.VideoRental.Specflow.UnitTest
{
    public class Rental
    {
        public DateTime CheckOutTime { get; private set; }
        public Title CheckedOutTitle { get; private set; }
        public User UserCheckingOut { get; private set; }
        public DateTime DueByDate { get; private set; }

        public Rental(User user, Title title)
        {
            SetRentalDate();
            UserCheckingOut = user;
            CheckedOutTitle = title;
        }

        private void SetRentalDate()
        {
            CheckOutTime = DateTime.Today;
            DueByDate = CheckOutTime.AddDays(15);
        }
    }
}