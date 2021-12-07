using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraray_manager_2._0
{
    internal class ResearchArticle:Book
    {
        public string doi;
        public string publicData;
        public string journal;

       public string getInfo()
        {
            String info = Convert.ToString(id) + "\t" + title + "\t" + author + "\t" + doi + "\t" + Convert.ToString(quantity) + "\t" + journal;
            return info;
        }
    }
}
