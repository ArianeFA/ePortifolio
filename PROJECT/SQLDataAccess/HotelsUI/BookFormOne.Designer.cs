
namespace HotelsUI
{
    partial class BookFormOne
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roomIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okbutton = new System.Windows.Forms.Button();
            this.roomVacBox = new System.Windows.Forms.TextBox();
            this.roomDescBox = new System.Windows.Forms.TextBox();
            this.roomNumBox = new System.Windows.Forms.TextBox();
            this.roomVacLabel2 = new System.Windows.Forms.Label();
            this.roomDesLabel2 = new System.Windows.Forms.Label();
            this.roomNumLabel2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roomIdBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.okbutton);
            this.panel1.Controls.Add(this.roomVacBox);
            this.panel1.Controls.Add(this.roomDescBox);
            this.panel1.Controls.Add(this.roomNumBox);
            this.panel1.Controls.Add(this.roomVacLabel2);
            this.panel1.Controls.Add(this.roomDesLabel2);
            this.panel1.Controls.Add(this.roomNumLabel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 88);
            this.panel1.TabIndex = 0;
            // 
            // roomIdBox2
            // 
            this.roomIdBox.Location = new System.Drawing.Point(3, 45);
            this.roomIdBox.Name = "roomIdBox2";
            this.roomIdBox.ReadOnly = true;
            this.roomIdBox.Size = new System.Drawing.Size(77, 27);
            this.roomIdBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "RoomId";
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(940, 45);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(47, 27);
            this.okbutton.TabIndex = 6;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // roomVacBox2
            // 
            this.roomVacBox.Location = new System.Drawing.Point(772, 45);
            this.roomVacBox.Name = "roomVacBox2";
            this.roomVacBox.Size = new System.Drawing.Size(162, 27);
            this.roomVacBox.TabIndex = 5;
            // 
            // roomDescBox2
            // 
            this.roomDescBox.Location = new System.Drawing.Point(224, 45);
            this.roomDescBox.Name = "roomDescBox2";
            this.roomDescBox.ReadOnly = true;
            this.roomDescBox.Size = new System.Drawing.Size(542, 27);
            this.roomDescBox.TabIndex = 4;
            // 
            // roomNumBox2
            // 
            this.roomNumBox.Location = new System.Drawing.Point(86, 45);
            this.roomNumBox.Name = "roomNumBox2";
            this.roomNumBox.ReadOnly = true;
            this.roomNumBox.Size = new System.Drawing.Size(132, 27);
            this.roomNumBox.TabIndex = 3;
            // 
            // roomVacLabel2
            // 
            this.roomVacLabel2.AutoSize = true;
            this.roomVacLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.roomVacLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomVacLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomVacLabel2.Location = new System.Drawing.Point(772, 15);
            this.roomVacLabel2.Name = "roomVacLabel2";
            this.roomVacLabel2.Size = new System.Drawing.Size(162, 27);
            this.roomVacLabel2.TabIndex = 2;
            this.roomVacLabel2.Text = "        Vacancy         ";
            this.roomVacLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomDesLabel2
            // 
            this.roomDesLabel2.AutoSize = true;
            this.roomDesLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.roomDesLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomDesLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomDesLabel2.Location = new System.Drawing.Point(224, 15);
            this.roomDesLabel2.Name = "roomDesLabel2";
            this.roomDesLabel2.Size = new System.Drawing.Size(542, 27);
            this.roomDesLabel2.TabIndex = 1;
            this.roomDesLabel2.Text = "Room Description                                                                 " +
    "            ";
            // 
            // roomNumLabel2
            // 
            this.roomNumLabel2.AutoSize = true;
            this.roomNumLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.roomNumLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNumLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomNumLabel2.Location = new System.Drawing.Point(86, 15);
            this.roomNumLabel2.Name = "roomNumLabel2";
            this.roomNumLabel2.Size = new System.Drawing.Size(132, 27);
            this.roomNumLabel2.TabIndex = 0;
            this.roomNumLabel2.Text = "Room Number";
            // 
            // BookFormTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 109);
            this.Controls.Add(this.panel1);
            this.Name = "BookFormTwo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label roomVacLabel2;
        private System.Windows.Forms.Label roomDesLabel2;
        private System.Windows.Forms.Label roomNumLabel2;
        private System.Windows.Forms.Button okbutton;
        public System.Windows.Forms.TextBox roomNumBox;
        public System.Windows.Forms.TextBox roomDescBox;
        public System.Windows.Forms.TextBox roomVacBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox roomIdBox;
    }
}