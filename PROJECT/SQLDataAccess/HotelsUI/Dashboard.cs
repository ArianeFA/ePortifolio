using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HotelsUI
{
    /* <summary>
        Hotel booking aplication:
        
        Display a list of hotels with room description of each
        and allows user to select a hotel and book a room
        Room information is stored in SLQ Server database
        <summary>
    */

    public partial class Dashboard : Form
    {
        /*Code for the main dasboard that handles 
          UI behaviour and database connection */

        BookFormOne formOne;
        BookFormTwo formTwo;
               
        //List to hold panel controls
        List<Panel> listPanel = new List<Panel>();
        int pageIndex;

        public Dashboard()
        {
            InitializeComponent();
            formOne = new BookFormOne(this);
            formTwo = new BookFormTwo(this);
        }

        public void Display()
        {
            DbHotels.DisplayAndSearch("SELECT * FROM TableOne", dataHotelOne);
            DbHotels.DisplayAndSearch("SELECT * FROM TableTWo", dataHotelTwo);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if(pageIndex > 0)
            {
                listPanel[--pageIndex].BringToFront();
            }
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if(pageIndex < listPanel.Count - 1)
            {
                listPanel[++pageIndex].BringToFront();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Display();
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[pageIndex].BringToFront();
        }

        private void dataHotelOne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                formOne.id = dataHotelOne.Rows[e.RowIndex].Cells[1].Value.ToString();
                formOne.roomNumber = dataHotelOne.Rows[e.RowIndex].Cells[2].Value.ToString();
                formOne.roomDescription = dataHotelOne.Rows[e.RowIndex].Cells[3].Value.ToString();
                formOne.roomVacancy = dataHotelOne.Rows[e.RowIndex].Cells[4].Value.ToString();
                formOne.UpdateHotelOneInfo();
                formOne.ShowDialog();
            }
        }

        private void dataHotelTwo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                formTwo.id2 = dataHotelTwo.Rows[e.RowIndex].Cells[1].Value.ToString();
                formTwo.roomNumber2 = dataHotelTwo.Rows[e.RowIndex].Cells[2].Value.ToString();
                formTwo.roomDescription2 = dataHotelTwo.Rows[e.RowIndex].Cells[3].Value.ToString();
                formTwo.roomVacancy2 = dataHotelTwo.Rows[e.RowIndex].Cells[4].Value.ToString();
                formTwo.UpdateHotelTwoInfo();
                formTwo.ShowDialog();
            }
        }
    }
}
