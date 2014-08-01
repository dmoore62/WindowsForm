using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Analytics_Solution
{
    class Attribute
    {

        
        private List<int> attr_id;
        private List<string> attr_name;
        private List<string> attr_descr;
        private List<int> attr_pid;
        private List<DateTime> attr_time;
         


        public Attribute(int attr_id, string attr_name, string attr_descr, int attr_pid)
        {
            DateTime time = DateTime.Now;


            this.attr_id.Add(attr_id);
            this.attr_name.Add(attr_name);
            this.attr_descr.Add(attr_descr);
            this.attr_pid.Add(attr_pid);
            attr_time.Add(time);

        }



    }
}
