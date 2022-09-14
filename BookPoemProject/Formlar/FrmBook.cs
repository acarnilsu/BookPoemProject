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
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityBook> entityBook = BLBook.BLBookList();
            dataGridView1.DataSource = entityBook;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityBook entityBook = new EntityBook();
            entityBook.Bookname = txtBookName.Text;
            entityBook.Writernamesurname = txtWriterNameSurname.Text;
            entityBook.Categoryid = int.Parse(txtCategoryID.Text);
            BLBook.BLAddBook(entityBook);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtBookID.Text);
            BLBook.BLDeleteBook(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityBook entityBook=new EntityBook();
            entityBook.Bookid=int.Parse(txtBookID.Text);
            entityBook.Bookname=txtBookName.Text;
            entityBook.Writernamesurname=txtWriterNameSurname.Text;
            entityBook.Categoryid = int.Parse(txtCategoryID.Text);
        }
    }
}
