using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelsUI
{
    public partial class BookFormTwo : Form
    {
        private readonly Dashboard _parent;
        public string id2, roomNumber2, roomDescription2, roomVacancy2;

        public BookFormTwo(Dashboard parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateHotelTwoInfo()
        {
            okbutton2.Text = "OK";
            roomBoxId2.Text = id2;
            roomNumBox2.Text = roomNumber2;
            roomDescBox2.Text = roomDescription2;
            roomVacBox2.Text = roomVacancy2;
        }
        private void okbutton2_Click(object sender, EventArgs e)
        {
            if (roomDescBox2.Text.Trim().Length < 3)
            {
                MessageBox.Show("Not sure if you want to book");
                return;
            }
            if (okbutton2.Text == "OK")
            {
                HotelTwo std = new HotelTwo(roomNumBox2.Text.Trim(), roomDescBox2.Text.Trim(), roomVacBox2.Text.Trim());
                DbHotels.UpdateHotelTwo(std, id2);
            }
            _parent.Display();
        }
    }
}
