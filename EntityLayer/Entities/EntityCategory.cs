using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class EntityCategory
    {
        private int categoryid;
        private string categoryname;

        
        public int Categoryid { get => categoryid; set => categoryid = value; }

        public string Categoryname { get => categoryname; set => categoryname = value; }
    }
}
