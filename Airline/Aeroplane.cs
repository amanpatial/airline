using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Aeroplane
    {
        public List<Seat> seats { get;  private set; }   

        public Aeroplane()
        {
            seats = new List<Seat>();
            for (int i = 1; i <= 3; ++i)
                for (char j = 'A'; j <= 'H'; ++j)
                    seats.Add(new Seat(i, j));
        }

        public List<Seat> reserveSeat(int passengerCount)
        {
            var availableSeat = seats.Where(s => s.seatStatus == SeatStatus.Empty).Take(passengerCount).ToList();
            availableSeat.ForEach(s => s.seatStatus = SeatStatus.Full);

            return availableSeat;
        }

        public bool CheckSeatAvailablity(int passengerCount)
        {
            bool seatAvailablityStatus = true;

            var remaingingAvailableSeatCount = seats.Where(s => s.seatStatus == SeatStatus.Empty).Count();
            if (remaingingAvailableSeatCount < passengerCount) seatAvailablityStatus = false;

            return seatAvailablityStatus;
        }
    }

}
