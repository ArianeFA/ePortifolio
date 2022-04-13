
namespace HotelsUI
{
    partial class BookFormTwo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomBoxId2 = new System.Windows.Forms.TextBox();
            this.roomNumBox2 = new System.Windows.Forms.TextBox();
            this.roomDescBox2 = new System.Windows.Forms.TextBox();
            this.roomVacBox2 = new System.Windows.Forms.TextBox();
            this.okbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "RoomId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(234, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Description                                                                 " +
    "            ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(782, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "        Vacancy         ";
            // 
            // roomBoxId2
            // 
            this.roomBoxId2.Location = new System.Drawing.Point(12, 59);
            this.roomBoxId2.Name = "roomBoxId2";
            this.roomBoxId2.ReadOnly = true;
            this.roomBoxId2.Size = new System.Drawing.Size(78, 27);
            this.roomBoxId2.TabIndex = 4;
            // 
            // roomNumBox2
            // 
            this.roomNumBox2.Location = new System.Drawing.Point(96, 59);
            this.roomNumBox2.Name = "roomNumBox2";
            this.roomNumBox2.ReadOnly = true;
            this.roomNumBox2.Size = new System.Drawing.Size(132, 27);
            this.roomNumBox2.TabIndex = 5;
            // 
            // roomDescBox2
            // 
            this.roomDescBox2.Location = new System.Drawing.Point(234, 59);
            this.roomDescBox2.Name = "roomDescBox2";
            this.roomDescBox2.ReadOnly = true;
            this.roomDescBox2.Size = new System.Drawing.Size(542, 27);
            this.roomDescBox2.TabIndex = 6;
            // 
            // roomVacBox2
            // 
            this.roomVacBox2.Location = new System.Drawing.Point(782, 59);
            this.roomVacBox2.Name = "roomVacBox2";
            this.roomVacBox2.Size = new System.Drawing.Size(162, 27);
            this.roomVacBox2.TabIndex = 7;
            // 
            // okbutton2
            // 
            this.okbutton2.Location = new System.Drawing.Point(950, 59);
            this.okbutton2.Name = "okbutton2";
            this.okbutton2.Size = new System.Drawing.Size(44, 26);
            this.okbutton2.TabIndex = 8;
            this.okbutton2.Text = "OK";
            this.okbutton2.UseVisualStyleBackColor = true;
            this.okbutton2.Click += new System.EventHandler(this.okbutton2_Click);
            // 
            // BookFormTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 101);
            this.Controls.Add(this.okbutton2);
            this.Controls.Add(this.roomVacBox2);
            this.Controls.Add(this.roomDescBox2);
            this.Controls.Add(this.roomNumBox2);
            this.Controls.Add(this.roomBoxId2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookFormTwo";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomBoxId2;
        private System.Windows.Forms.TextBox roomNumBox2;
        private System.Windows.Forms.TextBox roomDescBox2;
        private System.Windows.Forms.TextBox roomVacBox2;
        private System.Windows.Forms.Button okbutton2;
    }
}