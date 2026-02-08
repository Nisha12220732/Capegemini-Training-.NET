using System;
using System.Collections.Generic;
using System.Text;

namespace ConcurrentTicketBooking
{
    public class SeatUtility
    {
       public static List<Seat> seatList = new List<Seat>()
        {
            new Seat(){SeatNo = 101 , isBooked = true},
            new Seat(){SeatNo = 102 , isBooked = false},
            new Seat(){SeatNo = 103 , isBooked = true},
            new Seat(){SeatNo = 104 , isBooked = true},
            new Seat(){SeatNo = 105 , isBooked = false},
            new Seat(){SeatNo = 106 , isBooked = true},
            new Seat(){SeatNo = 107 , isBooked = false},
            new Seat(){SeatNo = 108 , isBooked = true},
            new Seat(){SeatNo = 109 , isBooked = true},
            new Seat(){SeatNo = 110 , isBooked = true},
            new Seat(){SeatNo = 111 , isBooked = false},
            new Seat(){SeatNo = 112 , isBooked = false},
            new Seat(){SeatNo = 113 , isBooked = true},
            new Seat(){SeatNo = 114 , isBooked = false},
            new Seat(){SeatNo = 115 , isBooked = false},
            new Seat(){SeatNo = 116 , isBooked = false},
            new Seat(){SeatNo = 117 , isBooked = false},
            new Seat(){SeatNo = 118 , isBooked = true},
            new Seat(){SeatNo = 119 , isBooked = true},
            new Seat(){SeatNo = 120 , isBooked = true},
            new Seat(){SeatNo = 121 , isBooked = false},
            new Seat(){SeatNo = 122 , isBooked = false},
            new Seat(){SeatNo = 123 , isBooked = true},
            new Seat(){SeatNo = 124 , isBooked = false},
            new Seat(){SeatNo = 125 , isBooked = false},
            new Seat(){SeatNo = 126 , isBooked = false},
            new Seat(){SeatNo = 127 , isBooked = false},
            new Seat(){SeatNo = 128, isBooked = false},
            new Seat(){SeatNo = 129 , isBooked = false},
            new Seat(){SeatNo = 130 , isBooked = true}
        };

        public bool BookSeat(int inputSeatNo,string userID)
        {
            var data = from i in seatList
                       where i.SeatNo == inputSeatNo
                       select i;

            foreach(var item in data)
            {
                if (item.isBooked)
                {
                    Console.WriteLine("Seat is Already Booked!!");
                    return false;
                }
                else
                {
                    item.isBooked = true;
                    Console.WriteLine($"{inputSeatNo} is booked for {userID}");
                    return true;
                }
                
            }
            return false;
        }
        public void ShowEmptySeats()
        {
            var data = from i in seatList
                       where i.isBooked == false
                       select i;
            Console.WriteLine("Empty Seats are: ");
            foreach (var item in data)
            {
                Console.WriteLine($"{item.SeatNo}");
            }
        }


    }
}
