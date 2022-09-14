using BusinessLogicLayer.BL;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookPoemProject.Formlar
{
    public partial class FrmPoem : Form
    {
        public FrmPoem()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityPoem> entityPoem = BLPoem.BLPoemList();
            dataGridView1.DataSource = entityPoem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityPoem entityPoem = new EntityPoem();
            entityPoem.Poemname = txtPoemName.Text;
            entityPoem.Poetnamesurname = txtPoetNameSurname.Text;
            entityPoem.Categoryid = int.Parse(txtCategoryID.Text);
            BLPoem.BLAddPoem(entityPoem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtPoemID.Text);
            BLPoem.BLDeletePoem(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityPoem ent=new EntityPoem();
            ent.Poemid = int.Parse(txtPoemID.Text);
            ent.Poemname= txtPoemName.Text;
            ent.Poetnamesurname= txtPoetNameSurname.Text;
            ent.Categoryid= int.Parse(txtCategoryID.Text);
        }
    }
}
