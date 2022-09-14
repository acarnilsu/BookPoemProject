using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FacadeLayer.Connection;
using System.Data;
using EntityLayer.Entities;

namespace FacadeLayer.Dal
{
    public class DALBook
    {
        public static List<EntityBook> BookList()
        {
            List<EntityBook> books = new List<EntityBook>();
            SqlCommand command = new SqlCommand("Select * from TblBooks", DbConnection.sqlConnection);
            if(command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                EntityBook entityBook = new EntityBook();
                entityBook.Bookid=int.Parse(dataReader["BookID"].ToString());
                entityBook.Bookname=dataReader["BookName"].ToString();
                entityBook.Writernamesurname=dataReader["WriterNameSurname"].ToString();
                entityBook.Categoryid = int.Parse(dataReader["CategoryID"].ToString());
                books.Add(entityBook);
            }
            return books;
        }

        public static void AddBook(EntityBook entityBook)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblBooks (BookName, WriterNameSurname, CategoryID) values (@p1,@p2,@p3)", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", entityBook.Bookname);
            command.Parameters.AddWithValue("@p2", entityBook.Writernamesurname);
            command.Parameters.AddWithValue("@p3", entityBook.Categoryid);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

        public static void DeleteBook(int id)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete from TblBooks where BookID=@p1", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

        public static void UpdateBook(EntityBook entityBook)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblBooks set BookName=@p1, WriterNameSurname=@p2, CategoryID=@p3 where BookID=@p4", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", entityBook.Bookname);
            command.Parameters.AddWithValue("@p2", entityBook.Writernamesurname);
            command.Parameters.AddWithValue("@p3", entityBook.Categoryid);
            command.Parameters.AddWithValue("@p4", entityBook.Bookid);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }


    }
}
