using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsUI
{
    public class HotelTwo
    {
        public string RoomNumber2 { get; set; }
        public string RoomDescription2 { get; set; }
        public string RoomVacancy2 { get; set; }

        public HotelTwo(string roomNumber2, string roomDescription2, string roomVacancy2)
        {
            RoomNumber2 = roomNumber2;
            RoomDescription2 = roomDescription2;
            RoomVacancy2 = roomVacancy2;
        }
    }
}
