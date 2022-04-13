using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelsUI
{
    public partial class BookFormOne : Form
    {
        /// <summary>
        /// This form will hadle the update book window 
        /// </summary>

        private readonly Dashboard _parent;
        public string id, roomNumber, roomDescription, roomVacancy;
                
        public BookFormOne(Dashboard parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateHotelOneInfo()
        {
            okbutton.Text = "OK";
            roomIdBox.Text = id;
            roomNumBox.Text = roomNumber;
            roomDescBox.Text = roomDescription;
            roomVacBox.Text = roomVacancy;            
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            if(roomDescBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("Not sure if you want to book");
                return;
            }
            if(okbutton.Text == "OK")
            {
                HotelOne std = new HotelOne(roomNumBox.Text.Trim(),roomDescBox.Text.Trim(), roomVacBox.Text.Trim());
                DbHotels.UpdateHotelOne(std, id);
            }            
            _parent.Display();            
        }
    }
}
