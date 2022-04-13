using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsUI
{
    public class HotelOne
    {
        public string RoomNumber { get; set; }
        public string RoomDescription { get; set; }
        public string RoomVacancy { get; set; }

        public HotelOne(string roomNumber, string roomDescription, string roomVacancy)
        {
            RoomNumber = roomNumber;
            RoomDescription = roomDescription;
            RoomVacancy = roomVacancy;
        }
    }
}
