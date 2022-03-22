using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Result_Processing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SerchId_Click(object sender, EventArgs e)
        {

            string id=IdBox.Text;

            var student = from Student in studentlist
                          where Student.id == id
                          select Student;


            foreach(var i in student)
            {
                AttendanceBox.Text=Convert.ToString(i.attendance);
                quiz1box.Text=Convert.ToString(i.quiz1);
                quiz2box.Text=Convert.ToString(i.quiz2);
                quiz3box.Text=Convert.ToString(i.quiz3);
                quiz4box.Text=Convert.ToString(i.quiz4);
                midbox.Text=Convert.ToString(i.mid);
                semfinalbox.Text=Convert.ToString(i.final);
                gradebox.Text=Convert.ToString(i.grade);
                textBox1.Text=i.name;
                Vivabox.Text=Convert.ToString(i.viva);



            }

            
            
        }
        List<Student>studentlist = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"D:\my stuff\hide'\downloads\wasiflabfinal.csv"))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Student dummy = new Student();
                    try
                    {
                        dummy.id= values[0];
                        dummy.name=values[1];
                        dummy.attendance=Convert.ToInt32(values[2]);
                        dummy.quiz1 = Convert.ToDouble(values[3]);
                        dummy.quiz2 = Convert.ToDouble(values[4]);
                        dummy.quiz3 = Convert.ToDouble(values[5]);
                        dummy.quiz4 = Convert.ToDouble(values[6]);
                        dummy.mid = Convert.ToDouble(values[7]);
                        dummy.final=Convert.ToDouble(values[8]);
                        dummy.viva=Convert.ToDouble(values[9]);
                        
                        double[] quiz = { dummy.quiz1, dummy.quiz2, dummy.quiz3, dummy.quiz4 };
                        Array.Sort(quiz);
                        double quiztotal = quiz[1]+quiz[2]+quiz[3];
                       
                        double percent = quiztotal+dummy.mid+dummy.final+dummy.viva+dummy.attendance;
                        dummy.percentage = (percent/300)*100;
                        if (dummy.percentage >=80)
                        {
                            dummy.grade="A+";
                        }
                        else if (dummy.percentage>=70&&dummy.percentage<80)
                        {
                            dummy.grade="A";
                        }
                        else if (dummy.percentage>=60&&dummy.percentage<70)
                        {
                            dummy.grade ="B";
                        }
                        else if (dummy.percentage>=50&&dummy.percentage<60)
                        {
                            dummy.grade="C";
                        }
                        else if (dummy.percentage>=40&dummy.percentage<50)
                        {
                            dummy.grade="D";
                        }
                        else if (dummy.percentage<40)
                        {
                            dummy.grade="F";
                        }
                        studentlist.Add(dummy);
                    }
                    
                    catch (Exception ex)
                    {

                    }
                    }
                listBox1.Items.Clear();
                foreach(Student dummy in studentlist)
                {
                    listBox1.Items.Add(dummy.id+"\t"+dummy.name+"\t"+dummy.percentage+
                        "\t"+dummy.grade);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
