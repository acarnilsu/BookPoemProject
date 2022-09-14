using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class EntityBook
    {
        private int bookid;
        private string bookname;
        private string writernamesurname;
        private int categoryid;

        public int Bookid { get => bookid; set => bookid = value; }
        public string Bookname { get => bookname; set => bookname = value; }
        public string Writernamesurname { get => writernamesurname; set => writernamesurname = value; }
        public int Categoryid { get => categoryid; set => categoryid = value; }
    }
}
