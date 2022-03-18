namespace tic_tac_toe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstPlayerScoreBox = new System.Windows.Forms.TextBox();
            this.SecondPlayerScoreBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.existToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.fileToolStripMenuItem.Text = "File ";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.existToolStripMenuItem.Text = "Exist";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(216, 79);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(297, 79);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = false;
            this.a2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(378, 79);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 3;
            this.a3.UseVisualStyleBackColor = false;
            this.a3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(216, 160);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 4;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(297, 160);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(378, 160);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(216, 241);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 7;
            this.c1.UseVisualStyleBackColor = false;
            this.c1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(297, 241);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 8;
            this.c2.UseVisualStyleBackColor = false;
            this.c2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(378, 241);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 9;
            this.c3.UseVisualStyleBackColor = false;
            this.c3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Computer:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player";
            // 
            // FirstPlayerScoreBox
            // 
            this.FirstPlayerScoreBox.Location = new System.Drawing.Point(141, 361);
            this.FirstPlayerScoreBox.Name = "FirstPlayerScoreBox";
            this.FirstPlayerScoreBox.Size = new System.Drawing.Size(115, 22);
            this.FirstPlayerScoreBox.TabIndex = 12;
            // 
            // SecondPlayerScoreBox
            // 
            this.SecondPlayerScoreBox.Location = new System.Drawing.Point(141, 387);
            this.SecondPlayerScoreBox.Name = "SecondPlayerScoreBox";
            this.SecondPlayerScoreBox.Size = new System.Drawing.Size(115, 22);
            this.SecondPlayerScoreBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecondPlayerScoreBox);
            this.Controls.Add(this.FirstPlayerScoreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstPlayerScoreBox;
        private System.Windows.Forms.TextBox SecondPlayerScoreBox;
    }
}

