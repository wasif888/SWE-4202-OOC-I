using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Enrollment_system_by_wasif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddParticipant_Click(object sender, EventArgs e)
        {
            
            
                string name=NameBox.Text;
                string id=Convert.ToString(Student.studentId)+"300";//mark with student with 300
                Student.studentId++;
                string email=EmailBox.Text;
                string contact = ContactBox.Text;
                string plevel;
                string type;
                if(P_LevelBeginnerRadio.Checked==true)
                {
                type="student";
                 }
                else if(PPofessionalRadio.Checked==true)
                {
                type="professional";
                }
                else
                {
                type="student";
                }
                if(P_LevelBeginnerRadio.Checked==true)
                {
                    plevel = P_LevelBeginnerRadio.Text;
                }
                else if(P_LevelIntermediateRadio.Checked==true)
                {
                     plevel = P_LevelIntermediateRadio.Text;
                }
                else if(P_LevelAdvancedRadio.Checked==true)
                {
                    plevel=P_LevelAdvancedRadio.Text;
                }
                else 
                {
                    plevel=P_LevelBeginnerRadio.Text;
                    
                }

               
            if(type=="student")
            {
                Student dummy=new Student(name,id,email,contact,plevel);
                EnrollmentSystem.students.Add(dummy);
                MessageBox.Show("student has been added\n ID no:"+dummy.id);
                ParticipantListCombo.Items.Add(name);
            }
            else if(type=="professional")
            {
                Professional dummypro = new Professional(name, id, email, contact,plevel);
                EnrollmentSystem.professionals.Add(dummypro);
                MessageBox.Show("Professional has been added.\n Id no:"+dummypro.id);
                ParticipantListCombo.Items.Add(name);
            }
                
            
            
               

            
        }

        private void Clear1_Click(object sender, EventArgs e)
        {
            NameBox.Text="";
            IdBox.Text="";
            EmailBox.Text="";
            ContactBox.Text="";
            P_LevelIntermediateRadio.Checked=false;
            P_LevelAdvancedRadio.Checked=false;
            P_LevelIntermediateRadio.Checked =false;
            PStudentRadio.Checked=false;
            PPofessionalRadio.Checked=false;


        }

        private void CourseADD_Click(object sender, EventArgs e)
        {
            String title=CourseTitleBox.Text;
            String clevel;
            double fee=Convert.ToDouble(CourseFeeBox.Text);
           

            if(ClevelBeginnerRadio.Checked==true)
            {
                clevel=ClevelBeginnerRadio.Text;
            }
            else if(CLevelIntermediateRadio.Checked==true)
            {
                clevel=CLevelIntermediateRadio.Text;
            }
            else if(ClevelAdvancedRadio.Checked==true)
            {
                clevel=ClevelAdvancedRadio.Text;
            }
            else
            {
                clevel = ClevelBeginnerRadio.Text;
            }
            Course dummy=new Course(title,fee,clevel);
            EnrollmentSystem.courses.Add(dummy);
            MessageBox.Show("course has been added");
            CourseListCombo.Items.Add(title);
          
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CourseTitleBox.Text="";
            CourseFeeBox.Text="";
            ClevelBeginnerRadio.Checked=false;
            CLevelIntermediateRadio.Checked=false;
            ClevelAdvancedRadio.Checked=false;
        }

        private void CourseEnroll_Click(object sender, EventArgs e)
        {
            string name = ParticipantListCombo.Text;
            string courstitle=CourseListCombo.Text;

            foreach(Student dummy in EnrollmentSystem.students)
            {
                if(name==dummy.name)
                {
                    foreach(Course dummycourse in EnrollmentSystem.courses)
                    {
                        if(courstitle==dummycourse.title)
                        {
                            dummycourse.courseFee=dummy.Getfee(Convert.ToDouble(CourseFeeBox.Text));
                            dummycourse.name=dummy.name;

                           SelectCombo.Items.Add(dummycourse.name+"  "+dummycourse.title);
                            MessageBox.Show("Course has been enrolled");
                            
                        }
                    }
                }
            }
            foreach(Professional dummy in EnrollmentSystem.professionals)
            {
                if (name==dummy.name)
                {
                    foreach (Course dummycourse in EnrollmentSystem.courses)
                    {
                        if (courstitle==dummycourse.title)
                        {
                            dummycourse.courseFee=dummy.Getfee(Convert.ToDouble(CourseFeeBox.Text));
                            dummycourse.name=dummy.name;

                            SelectCombo.Items.Add(dummycourse.name+"  "+dummycourse.title);
                            MessageBox.Show("Course has been enrolled");

                        }
                    }
                }
            }

        }

        private void ParticipantInformation_Click(object sender, EventArgs e)
        {
            string name=SelectCombo.Text;
            foreach(Course dummy in EnrollmentSystem.courses)
            {
                if(name==dummy.name+"  "+dummy.title)
                {
                    NameOutputBox.Text=dummy.name;
                    CourseOutputBox.Text=dummy.title;
                    CourseFeeOutputBox.Text=Convert.ToString(dummy.courseFee);

                }
            }
           
        }
    }
}
