namespace Pharmacy_Management_System
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MedNameBox = new System.Windows.Forms.TextBox();
            this.MedIdBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.MedPriceBox = new System.Windows.Forms.TextBox();
            this.UserIdBox = new System.Windows.Forms.TextBox();
            this.BalanceBox = new System.Windows.Forms.TextBox();
            this.MedIdInfoBox = new System.Windows.Forms.TextBox();
            this.SellMedIdBox = new System.Windows.Forms.TextBox();
            this.SellUserIdBox = new System.Windows.Forms.TextBox();
            this.SellQuantityBox = new System.Windows.Forms.TextBox();
            this.CheckUserIdBox = new System.Windows.Forms.TextBox();
            this.AddMedicine = new System.Windows.Forms.Button();
            this.ClearMedicine = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.ClearUser = new System.Windows.Forms.Button();
            this.SearchInfo = new System.Windows.Forms.Button();
            this.SellMed = new System.Windows.Forms.Button();
            this.ClearSell = new System.Windows.Forms.Button();
            this.SeeBalance = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CheckUserBalance = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearMedicine);
            this.groupBox1.Controls.Add(this.AddMedicine);
            this.groupBox1.Controls.Add(this.MedPriceBox);
            this.groupBox1.Controls.Add(this.QuantityBox);
            this.groupBox1.Controls.Add(this.MedIdBox);
            this.groupBox1.Controls.Add(this.MedNameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Medicine";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearUser);
            this.groupBox2.Controls.Add(this.AddUser);
            this.groupBox2.Controls.Add(this.BalanceBox);
            this.groupBox2.Controls.Add(this.UserIdBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(479, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add User";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.SearchInfo);
            this.groupBox3.Controls.Add(this.MedIdInfoBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(851, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medicine Info";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClearSell);
            this.groupBox4.Controls.Add(this.SellMed);
            this.groupBox4.Controls.Add(this.SellQuantityBox);
            this.groupBox4.Controls.Add(this.SellUserIdBox);
            this.groupBox4.Controls.Add(this.SellMedIdBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(45, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 193);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sell Medicine";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CheckUserBalance);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.SeeBalance);
            this.groupBox5.Controls.Add(this.CheckUserIdBox);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(479, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(715, 173);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Check Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "User ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Medicine Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Medicine ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "User ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "User ID";
            // 
            // MedNameBox
            // 
            this.MedNameBox.Location = new System.Drawing.Point(78, 35);
            this.MedNameBox.Name = "MedNameBox";
            this.MedNameBox.Size = new System.Drawing.Size(224, 22);
            this.MedNameBox.TabIndex = 4;
            // 
            // MedIdBox
            // 
            this.MedIdBox.Location = new System.Drawing.Point(78, 68);
            this.MedIdBox.Name = "MedIdBox";
            this.MedIdBox.Size = new System.Drawing.Size(224, 22);
            this.MedIdBox.TabIndex = 5;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(78, 99);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(224, 22);
            this.QuantityBox.TabIndex = 6;
            // 
            // MedPriceBox
            // 
            this.MedPriceBox.Location = new System.Drawing.Point(78, 130);
            this.MedPriceBox.Name = "MedPriceBox";
            this.MedPriceBox.Size = new System.Drawing.Size(224, 22);
            this.MedPriceBox.TabIndex = 7;
            // 
            // UserIdBox
            // 
            this.UserIdBox.Location = new System.Drawing.Point(94, 36);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(147, 22);
            this.UserIdBox.TabIndex = 2;
            // 
            // BalanceBox
            // 
            this.BalanceBox.Location = new System.Drawing.Point(94, 78);
            this.BalanceBox.Name = "BalanceBox";
            this.BalanceBox.Size = new System.Drawing.Size(147, 22);
            this.BalanceBox.TabIndex = 3;
            // 
            // MedIdInfoBox
            // 
            this.MedIdInfoBox.Location = new System.Drawing.Point(97, 39);
            this.MedIdInfoBox.Name = "MedIdInfoBox";
            this.MedIdInfoBox.Size = new System.Drawing.Size(129, 22);
            this.MedIdInfoBox.TabIndex = 1;
            // 
            // SellMedIdBox
            // 
            this.SellMedIdBox.Location = new System.Drawing.Point(101, 49);
            this.SellMedIdBox.Name = "SellMedIdBox";
            this.SellMedIdBox.Size = new System.Drawing.Size(161, 22);
            this.SellMedIdBox.TabIndex = 3;
            // 
            // SellUserIdBox
            // 
            this.SellUserIdBox.Location = new System.Drawing.Point(101, 90);
            this.SellUserIdBox.Name = "SellUserIdBox";
            this.SellUserIdBox.Size = new System.Drawing.Size(161, 22);
            this.SellUserIdBox.TabIndex = 4;
            // 
            // SellQuantityBox
            // 
            this.SellQuantityBox.Location = new System.Drawing.Point(101, 129);
            this.SellQuantityBox.Name = "SellQuantityBox";
            this.SellQuantityBox.Size = new System.Drawing.Size(161, 22);
            this.SellQuantityBox.TabIndex = 5;
            // 
            // CheckUserIdBox
            // 
            this.CheckUserIdBox.Location = new System.Drawing.Point(94, 35);
            this.CheckUserIdBox.Name = "CheckUserIdBox";
            this.CheckUserIdBox.Size = new System.Drawing.Size(267, 22);
            this.CheckUserIdBox.TabIndex = 1;
            this.CheckUserIdBox.TextChanged += new System.EventHandler(this.CheckUserIdBox_TextChanged);
            // 
            // AddMedicine
            // 
            this.AddMedicine.Location = new System.Drawing.Point(26, 181);
            this.AddMedicine.Name = "AddMedicine";
            this.AddMedicine.Size = new System.Drawing.Size(127, 23);
            this.AddMedicine.TabIndex = 8;
            this.AddMedicine.Text = "Add Medicine";
            this.AddMedicine.UseVisualStyleBackColor = true;
            this.AddMedicine.Click += new System.EventHandler(this.AddMedicine_Click);
            // 
            // ClearMedicine
            // 
            this.ClearMedicine.Location = new System.Drawing.Point(186, 180);
            this.ClearMedicine.Name = "ClearMedicine";
            this.ClearMedicine.Size = new System.Drawing.Size(130, 23);
            this.ClearMedicine.TabIndex = 9;
            this.ClearMedicine.Text = "Clear";
            this.ClearMedicine.UseVisualStyleBackColor = true;
            this.ClearMedicine.Click += new System.EventHandler(this.ClearMedicine_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(6, 180);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(116, 23);
            this.AddUser.TabIndex = 4;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // ClearUser
            // 
            this.ClearUser.Location = new System.Drawing.Point(174, 180);
            this.ClearUser.Name = "ClearUser";
            this.ClearUser.Size = new System.Drawing.Size(109, 23);
            this.ClearUser.TabIndex = 5;
            this.ClearUser.Text = "Clear";
            this.ClearUser.UseVisualStyleBackColor = true;
            // 
            // SearchInfo
            // 
            this.SearchInfo.Location = new System.Drawing.Point(243, 40);
            this.SearchInfo.Name = "SearchInfo";
            this.SearchInfo.Size = new System.Drawing.Size(168, 23);
            this.SearchInfo.TabIndex = 2;
            this.SearchInfo.Text = "Search Info";
            this.SearchInfo.UseVisualStyleBackColor = true;
            this.SearchInfo.Click += new System.EventHandler(this.SearchInfo_Click);
            // 
            // SellMed
            // 
            this.SellMed.Location = new System.Drawing.Point(26, 164);
            this.SellMed.Name = "SellMed";
            this.SellMed.Size = new System.Drawing.Size(127, 23);
            this.SellMed.TabIndex = 6;
            this.SellMed.Text = "Sell Medicine";
            this.SellMed.UseVisualStyleBackColor = true;
            this.SellMed.Click += new System.EventHandler(this.SellMed_Click);
            // 
            // ClearSell
            // 
            this.ClearSell.Location = new System.Drawing.Point(186, 164);
            this.ClearSell.Name = "ClearSell";
            this.ClearSell.Size = new System.Drawing.Size(130, 23);
            this.ClearSell.TabIndex = 7;
            this.ClearSell.Text = "Clear";
            this.ClearSell.UseVisualStyleBackColor = true;
            this.ClearSell.Click += new System.EventHandler(this.ClearSell_Click);
            // 
            // SeeBalance
            // 
            this.SeeBalance.Location = new System.Drawing.Point(27, 76);
            this.SeeBalance.Name = "SeeBalance";
            this.SeeBalance.Size = new System.Drawing.Size(668, 23);
            this.SeeBalance.TabIndex = 2;
            this.SeeBalance.Text = "See Balance";
            this.SeeBalance.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Balance";
            // 
            // CheckUserBalance
            // 
            this.CheckUserBalance.Location = new System.Drawing.Point(119, 135);
            this.CheckUserBalance.Name = "CheckUserBalance";
            this.CheckUserBalance.Size = new System.Drawing.Size(233, 22);
            this.CheckUserBalance.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 116);
            this.listBox1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(372, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(574, 42);
            this.label14.TabIndex = 6;
            this.label14.Text = "Pharmacy Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 535);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearMedicine;
        private System.Windows.Forms.Button AddMedicine;
        private System.Windows.Forms.TextBox MedPriceBox;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TextBox MedIdBox;
        private System.Windows.Forms.TextBox MedNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.TextBox BalanceBox;
        private System.Windows.Forms.TextBox UserIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SearchInfo;
        private System.Windows.Forms.TextBox MedIdInfoBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ClearSell;
        private System.Windows.Forms.Button SellMed;
        private System.Windows.Forms.TextBox SellQuantityBox;
        private System.Windows.Forms.TextBox SellUserIdBox;
        private System.Windows.Forms.TextBox SellMedIdBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox CheckUserBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SeeBalance;
        private System.Windows.Forms.TextBox CheckUserIdBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

