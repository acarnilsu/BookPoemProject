using EntityLayer.Entities;
using FacadeLayer.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BL
{
    public class BLPoem
    {
        public static List<EntityPoem> BLPoemList()
        {
            return DALPoem.PoemList();
        }

        public static void BLAddPoem(EntityPoem entityPoem)
        {
            if (entityPoem.Poetnamesurname!="" && entityPoem.Poemname.Length >= 5)
            {
                DALPoem.AddPoem(entityPoem);
            }
            else
            {
                //hata mesajları
            }
        }

        public static void BLDeletePoem(int id)
        {
            DALPoem.DeletePoem(id);
        }

        public static void BLUpdate(EntityPoem entityPoem)
        {
            if (entityPoem.Poetnamesurname != "" && entityPoem.Poemname.Length >= 5)
            {
                DALPoem.UpdatePoem(entityPoem);
            }
            else
            {
                //hata mesajları
            }
        }
    }
}
