using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public enum SeatStatus { 
        Empty, 
        Full
    };

    public class Seat
    {
        public SeatStatus seatStatus = SeatStatus.Empty;

        private int row;
        private char column;

        public Seat(int row, char column)
        {
            this.row = row;
            this.column = column;
        }  

        public override String ToString()
        {
            return this.row + "" + this.column;
        }

    }  
}
