using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class EntityPoem
    {
        private int poemid;
        private string poemname;
        private string poetnamesurname;
        private int categoryid;

        public int Poemid { get => poemid; set => poemid = value; }
        public string Poemname { get => poemname; set => poemname = value; }
        public string Poetnamesurname { get => poetnamesurname; set => poetnamesurname = value; }
        public int Categoryid { get => categoryid; set => categoryid = value; }
    }
}
