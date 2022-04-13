
namespace HotelsUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataHotelOne = new System.Windows.Forms.DataGridView();
            this.roomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNUmber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomVacancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataHotelTwo = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDescription2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomVacancy2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking SNHU";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataHotelOne);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 526);
            this.panel1.TabIndex = 1;
            // 
            // dataHotelOne
            // 
            this.dataHotelOne.AllowUserToAddRows = false;
            this.dataHotelOne.AllowUserToDeleteRows = false;
            this.dataHotelOne.AllowUserToResizeColumns = false;
            this.dataHotelOne.AllowUserToResizeRows = false;
            this.dataHotelOne.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataHotelOne.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataHotelOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataHotelOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHotelOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomId,
            this.roomNUmber,
            this.roomDescription,
            this.roomVacancy,
            this.roomBook});
            this.dataHotelOne.GridColor = System.Drawing.SystemColors.Control;
            this.dataHotelOne.Location = new System.Drawing.Point(35, 252);
            this.dataHotelOne.Name = "dataHotelOne";
            this.dataHotelOne.RowHeadersWidth = 51;
            this.dataHotelOne.RowTemplate.Height = 29;
            this.dataHotelOne.Size = new System.Drawing.Size(831, 268);
            this.dataHotelOne.TabIndex = 0;
            this.dataHotelOne.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHotelOne_CellClick);
            // 
            // roomId
            // 
            this.roomId.DataPropertyName = "Id";
            this.roomId.HeaderText = "Id";
            this.roomId.MinimumWidth = 6;
            this.roomId.Name = "roomId";
            this.roomId.Visible = false;
            this.roomId.Width = 125;
            // 
            // roomNUmber
            // 
            this.roomNUmber.DataPropertyName = "RoomNumber";
            this.roomNUmber.HeaderText = "Room Number";
            this.roomNUmber.MinimumWidth = 6;
            this.roomNUmber.Name = "roomNUmber";
            this.roomNUmber.Width = 134;
            // 
            // roomDescription
            // 
            this.roomDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.roomDescription.DataPropertyName = "RoomDescription";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.roomDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.roomDescription.HeaderText = "Description";
            this.roomDescription.MinimumWidth = 6;
            this.roomDescription.Name = "roomDescription";
            this.roomDescription.Width = 390;
            // 
            // roomVacancy
            // 
            this.roomVacancy.DataPropertyName = "RoomVacancy";
            this.roomVacancy.HeaderText = "Vacancy";
            this.roomVacancy.MinimumWidth = 6;
            this.roomVacancy.Name = "roomVacancy";
            this.roomVacancy.Width = 125;
            // 
            // roomBook
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            this.roomBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomBook.HeaderText = "";
            this.roomBook.MinimumWidth = 6;
            this.roomBook.Name = "roomBook";
            this.roomBook.Text = "Book Room";
            this.roomBook.UseColumnTextForButtonValue = true;
            this.roomBook.Width = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(545, 140);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelsUI.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 226);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Page1\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataHotelTwo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(24, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 523);
            this.panel2.TabIndex = 4;
            // 
            // dataHotelTwo
            // 
            this.dataHotelTwo.AllowUserToAddRows = false;
            this.dataHotelTwo.AllowUserToDeleteRows = false;
            this.dataHotelTwo.AllowUserToResizeColumns = false;
            this.dataHotelTwo.AllowUserToResizeRows = false;
            this.dataHotelTwo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataHotelTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataHotelTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHotelTwo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.roomNumber2,
            this.roomDescription2,
            this.roomVacancy2,
            this.dataGridViewButtonColumn1});
            this.dataHotelTwo.GridColor = System.Drawing.SystemColors.Control;
            this.dataHotelTwo.Location = new System.Drawing.Point(32, 244);
            this.dataHotelTwo.Name = "dataHotelTwo";
            this.dataHotelTwo.RowHeadersWidth = 51;
            this.dataHotelTwo.RowTemplate.Height = 29;
            this.dataHotelTwo.Size = new System.Drawing.Size(831, 268);
            this.dataHotelTwo.TabIndex = 4;
            this.dataHotelTwo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHotelTwo_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 120);
            this.label4.TabIndex = 2;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelsUI.Properties.Resources.hotel2;
            this.pictureBox2.Location = new System.Drawing.Point(32, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 226);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Page2";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(289, 667);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(94, 29);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(477, 667);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(94, 29);
            this.buttonForward.TabIndex = 3;
            this.buttonForward.Text = "Forward";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // id2
            // 
            this.id2.DataPropertyName = "RoomId";
            this.id2.HeaderText = "RoomId";
            this.id2.MinimumWidth = 6;
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Visible = false;
            this.id2.Width = 125;
            // 
            // roomNumber2
            // 
            this.roomNumber2.DataPropertyName = "RoomNumber2";
            this.roomNumber2.HeaderText = "Room Number";
            this.roomNumber2.MinimumWidth = 6;
            this.roomNumber2.Name = "roomNumber2";
            this.roomNumber2.Width = 134;
            // 
            // roomDescription2
            // 
            this.roomDescription2.DataPropertyName = "RoomDescription2";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.roomDescription2.DefaultCellStyle = dataGridViewCellStyle3;
            this.roomDescription2.HeaderText = "Description";
            this.roomDescription2.MinimumWidth = 6;
            this.roomDescription2.Name = "roomDescription2";
            this.roomDescription2.Width = 390;
            // 
            // roomVacancy2
            // 
            this.roomVacancy2.DataPropertyName = "RoomVacancy2";
            this.roomVacancy2.HeaderText = "Vacancy";
            this.roomVacancy2.MinimumWidth = 6;
            this.roomVacancy2.Name = "roomVacancy2";
            this.roomVacancy2.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Blue;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Book Room";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 128;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 708);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking SNHU";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataHotelTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNUmber;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomVacancy;
        private System.Windows.Forms.DataGridViewButtonColumn roomBook;
        private System.Windows.Forms.DataGridView dataHotelOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDescription2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomVacancy2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}

