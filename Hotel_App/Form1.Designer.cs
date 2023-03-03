using System;

namespace Hotel_App
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.LName = new System.Windows.Forms.Label();
            this.LDateIn = new System.Windows.Forms.Label();
            this.LDateOut = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.LRoom = new System.Windows.Forms.Label();
            this.RoomTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SFreeRBtn = new System.Windows.Forms.RadioButton();
            this.SOccupiedRBtn = new System.Windows.Forms.RadioButton();
            this.SReservedRBtn = new System.Windows.Forms.RadioButton();
            this.LStatus = new System.Windows.Forms.Label();
            this.DateNow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(177, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter2.Location = new System.Drawing.Point(177, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(275, 450);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter3.Location = new System.Drawing.Point(452, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(349, 450);
            this.splitter3.TabIndex = 2;
            this.splitter3.TabStop = false;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(476, 264);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(72, 28);
            this.LName.TabIndex = 3;
            this.LName.Text = "NAME";
            // 
            // LDateIn
            // 
            this.LDateIn.AutoSize = true;
            this.LDateIn.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDateIn.Location = new System.Drawing.Point(476, 308);
            this.LDateIn.Name = "LDateIn";
            this.LDateIn.Size = new System.Drawing.Size(92, 28);
            this.LDateIn.TabIndex = 4;
            this.LDateIn.Text = "DATE IN";
            // 
            // LDateOut
            // 
            this.LDateOut.AutoSize = true;
            this.LDateOut.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDateOut.Location = new System.Drawing.Point(476, 348);
            this.LDateOut.Name = "LDateOut";
            this.LDateOut.Size = new System.Drawing.Size(111, 28);
            this.LDateOut.TabIndex = 5;
            this.LDateOut.Text = "DATE OUT";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(614, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 28);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(614, 350);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(174, 28);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(614, 268);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(174, 28);
            this.NameTB.TabIndex = 8;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(576, 395);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 43);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // LRoom
            // 
            this.LRoom.AutoSize = true;
            this.LRoom.Font = new System.Drawing.Font("Ebrima", 16F, System.Drawing.FontStyle.Bold);
            this.LRoom.ForeColor = System.Drawing.Color.DarkBlue;
            this.LRoom.Location = new System.Drawing.Point(458, 29);
            this.LRoom.Name = "LRoom";
            this.LRoom.Size = new System.Drawing.Size(120, 45);
            this.LRoom.TabIndex = 10;
            this.LRoom.Text = "ROOM";
            // 
            // RoomTB
            // 
            this.RoomTB.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTB.Location = new System.Drawing.Point(466, 77);
            this.RoomTB.Name = "RoomTB";
            this.RoomTB.Size = new System.Drawing.Size(100, 33);
            this.RoomTB.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(620, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 162);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SFreeRBtn
            // 
            this.SFreeRBtn.AutoSize = true;
            this.SFreeRBtn.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFreeRBtn.Location = new System.Drawing.Point(24, 267);
            this.SFreeRBtn.Name = "SFreeRBtn";
            this.SFreeRBtn.Size = new System.Drawing.Size(67, 25);
            this.SFreeRBtn.TabIndex = 13;
            this.SFreeRBtn.TabStop = true;
            this.SFreeRBtn.Text = "Free";
            this.SFreeRBtn.UseVisualStyleBackColor = true;
            // 
            // SOccupiedRBtn
            // 
            this.SOccupiedRBtn.AutoSize = true;
            this.SOccupiedRBtn.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOccupiedRBtn.Location = new System.Drawing.Point(24, 308);
            this.SOccupiedRBtn.Name = "SOccupiedRBtn";
            this.SOccupiedRBtn.Size = new System.Drawing.Size(107, 25);
            this.SOccupiedRBtn.TabIndex = 14;
            this.SOccupiedRBtn.TabStop = true;
            this.SOccupiedRBtn.Text = "Occupied";
            this.SOccupiedRBtn.UseVisualStyleBackColor = true;
            // 
            // SReservedRBtn
            // 
            this.SReservedRBtn.AutoSize = true;
            this.SReservedRBtn.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SReservedRBtn.Location = new System.Drawing.Point(24, 350);
            this.SReservedRBtn.Name = "SReservedRBtn";
            this.SReservedRBtn.Size = new System.Drawing.Size(104, 25);
            this.SReservedRBtn.TabIndex = 15;
            this.SReservedRBtn.TabStop = true;
            this.SReservedRBtn.Text = "Reserved";
            this.SReservedRBtn.UseVisualStyleBackColor = true;
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold);
            this.LStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.LStatus.Location = new System.Drawing.Point(18, 211);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(112, 36);
            this.LStatus.TabIndex = 16;
            this.LStatus.Text = "STATUS";
            // 
            // DateNow
            // 
            this.DateNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateNow.Location = new System.Drawing.Point(12, 19);
            this.DateNow.Name = "DateNow";
            this.DateNow.Size = new System.Drawing.Size(100, 23);
            this.DateNow.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "STATUS";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(466, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 28);
            this.textBox1.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateNow);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.SReservedRBtn);
            this.Controls.Add(this.SOccupiedRBtn);
            this.Controls.Add(this.SFreeRBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RoomTB);
            this.Controls.Add(this.LRoom);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LDateOut);
            this.Controls.Add(this.LDateIn);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "Main";
            this.Text = "Hotel Back";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LDateIn;
        private System.Windows.Forms.Label LDateOut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label LRoom;
        private System.Windows.Forms.TextBox RoomTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton SFreeRBtn;
        private System.Windows.Forms.RadioButton SOccupiedRBtn;
        private System.Windows.Forms.RadioButton SReservedRBtn;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label DateNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

