using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Enrollment_system_by_wasif
{
    internal class Course:CourseInfo
    {
        
        public Course(string title,double coursefee,string Clevel)
        {
            
            this.Clevel = Clevel;
            this.title = title;
            this.courseFee = coursefee;
        }
    }
}
