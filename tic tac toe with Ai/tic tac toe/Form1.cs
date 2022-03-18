using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        bool move = true;//turn true=x//turn false=y turn
        int movecount = 0;
        int player1=0;
        int player2 = 0;
        bool computer = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by wasif -tic tac toe");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonClick(object sender, EventArgs e)
        {

            if(movecount==1)
            {
                computer = true;
            }
            FirstPlayerScoreBox.Text=Convert.ToString(player1);
            SecondPlayerScoreBox.Text=Convert.ToString(player2);


            Button b =(Button)sender;//typecasting

            if(move)
            {
                b.Text ="X";
                computer = true;
            }
            else
            {
                b.Text="O";
            }
            move=!move;
            b.Enabled=false;
            movecount++;
            checkwinner();
            if((!move)&&(computer))
            {
                computer_make_move();
            }
        }
        
        private void checkwinner()
        {
            bool winner = false;
            if(a1.Text==a2.Text&&a2.Text==a3.Text&&(!a1.Enabled))
            {
                winner=true;
            }
            else if(b1.Text==b2.Text&&b2.Text==b3.Text&&(!b1.Enabled))
            {
                winner=true;
            }
            else if(c1.Text==c2.Text&&c2.Text==c3.Text&&(!c1.Enabled))
            {
                winner=!true;
            }
            else if(a1.Text==b1.Text&&b1.Text==c1.Text&&(!a1.Enabled))
            {
                winner=true;
            }
            else if (a2.Text==b2.Text&&b2.Text==c2.Text&&(!a2.Enabled))
            {
                winner=true;
            }
            else if (a3.Text==b3.Text&&b3.Text==c3.Text&&(!a3.Enabled))
            {
                winner=true;
            }
            else if(a1.Text==b2.Text&&b2.Text==c3.Text&&!a1.Enabled)
            {
                winner=true;
            }
            else if (a3.Text==b2.Text&&b2.Text==c1.Text&&!a3.Enabled)
            {
                winner=true;
            }
            if(winner==true)
            {
                if(move)
                {
                    player1++;
                    MessageBox.Show("2nd player is winner");
                }
                else
                {
                    player2++;
                    MessageBox.Show("1st player is winner");
                }
                disable_buttons();
                

            }
            else if(movecount==9)
            {
                MessageBox.Show("its a tie");
                disable_buttons();
            }
        }
        private void disable_buttons()
        {
            a1.Enabled=true;
            a2.Enabled=true;
            a3.Enabled=true;
            b1.Enabled=true;
            b2.Enabled=true;
            b3.Enabled=true;
            c1.Enabled=true;
            c2.Enabled=true;
            c3.Enabled=true;
            a1.Text="";
            a2.Text="";
            a3.Text="";
            b1.Text="";
            b2.Text="";
            b3.Text="";
            c1.Text="";
            c2.Text="";
            c3.Text="";
            movecount=0;
        }
        private void computer_make_move()
        {
            Button turn = null;
            turn=Look_for_win_or_block("O");
            
                if (turn==null)
                {
                    turn=Look_for_win_or_block("X");//
                   
                if (turn==null)
                    {

                    turn=Look_for_corner();
                    if(turn==null)
                    {
                        turn=Look_for_open_space();    

                    }
                    }
                    
                }
            turn.PerformClick();
           


        }
        private Button Look_for_win_or_block(string mark)
        {
            //HORIZONTAL TEST
            if((a1.Text==mark)&&(a2.Text==mark)&&(a3.Text==""))
                { return a3; }
            if ((a2.Text==mark)&&(a3.Text==mark)&&(a1.Text==""))
            { return a1; }
            if ((a3.Text==mark)&&(a2.Text==mark)&&(a2.Text==""))
            { return a2; }





            if ((b1.Text==mark)&&(b2.Text==mark)&&(b3.Text==""))
            { return b3; }
            if ((b2.Text==mark)&&(b2.Text==mark)&&(b1.Text==""))
            { return b1; }

            if ((b3.Text==mark)&&(b1.Text==mark)&&(b2.Text==""))
            { return b2; }


         
            if ((c1.Text==mark)&&(c2.Text==mark)&&(c3.Text==""))
            { return c3; }
            if ((c2.Text==mark)&&(c3.Text==mark)&&(c1.Text==""))
            { return c1; }
            if ((c3.Text==mark)&&(c1.Text==mark)&&(c2.Text==""))
            { return c2; }

            //VERTICAL TEST
            if((a1.Text==mark)&&(b1.Text==mark)&&(c1.Text==""))
            { return c1; }
            if ((b1.Text==mark)&&(b1.Text==mark)&&(a1.Text==""))
            { return a1; }
            if ((c1.Text==mark)&&(a1.Text==mark)&&(b1.Text==""))
            { return b1; }




            if ((a2.Text==mark)&&(b2.Text==mark)&&(c2.Text==""))
            { return c2; }
            if ((b2.Text==mark)&&(b2.Text==mark)&&(a2.Text==""))
            { return a2; }
            if ((c2.Text==mark)&&(a2.Text==mark)&&(b2.Text==""))
            { return b2; }





            if ((a3.Text==mark)&&(b3.Text==mark)&&(c3.Text==""))
            { return c3; }
            if ((b3.Text==mark)&&(c3.Text==mark)&&(a3.Text==""))
            { return a3; }
            if ((c3.Text==mark)&&(a3.Text==mark)&&(b3.Text==""))
            { return b3; }

            //DIOGNAL TEST
            if((a1.Text==mark)&&(b2.Text==mark)&&(c3.Text==""))
            { return c3; }
            if ((b2.Text==mark)&&(c3.Text==mark)&&(a1.Text==""))
            { return a1; }
            if ((a1.Text==mark)&&(c3.Text==mark)&&(b2.Text==""))
            { return b2; }


            if ((a3.Text==mark)&&(b2.Text==mark)&&(c1.Text==""))
            { return c1; }
            if ((b2.Text==mark)&&(c1.Text==mark)&&(a3.Text==""))
            { return a3; }
            if ((c1.Text==mark)&&(a3.Text==mark)&&(b2.Text==""))
            { return b2; }
            return null;


        }
        private Button Look_for_corner()
        {
            if(a1.Text=="O")
            {
                if(a3.Text=="")
                { return a3; }
                if(c3.Text=="")
                { return c3; }
                if(c1.Text=="")
                { return c1; }

            }
            if(a3.Text=="O")
            {
                if(a1.Text=="")
                { return a1; }
                if(c1.Text=="")
                { return c1; }
                if(c3.Text=="")
                { return c3; }
            }
            if(c1.Text=="O")
            {
                if (a1.Text=="")
                { return a1; }
                if (a3.Text=="")
                { return a3; }
                if (c3.Text=="")
                { return c3; }
            }
            return null;
        }
        private Button Look_for_open_space()
        {
            Button b=null;
            foreach(Control c in Controls)
            {
                b=c as Button;
                if(b!=null)
                {
                    if(b.Text=="")
                    {
                        return b;
                    }
                }
               
            }
            return null;
           
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
