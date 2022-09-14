using EntityLayer.Entities;
using FacadeLayer.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BL
{
    public class BLBook
    {
        public static List<EntityBook> BLBookList()
        {
            return DALBook.BookList();
        }

        public static void BLAddBook(EntityBook entityBook)
        {
            if (entityBook.Writernamesurname != "" && entityBook.Bookname.Length >= 5)
            {
                DALBook.AddBook(entityBook);
            }
            else
            {
                //hata mesajları
            }
        }

        public static void BLDeleteBook(int id)
        {
            DALBook.DeleteBook(id);
        }

        public static void BLUpdate(EntityBook entityBook)
        {
            if (entityBook.Writernamesurname != "" && entityBook.Bookname.Length >= 5)
            {
                DALBook.UpdateBook(entityBook);
            }
            else
            {
                //hata mesajları
            }
        }
    }
}
