using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics_Solution
{    
    class AttributeRow
    {
        public String name;
        public int num_forms;
        public int num_children;
        public int num_parents;
        public String comments;

        public AttributeRow(String name, int num_forms, int num_children, int num_parents, String comments){
            this.name = name;
            this.num_forms = num_forms;
            this.num_children = num_children;
            this.num_parents = num_parents;
            this.comments = comments;
        }
    }
}
