using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FacadeLayer.Connection;
using System.Data;

namespace FacadeLayer.Dal
{
    public class DALPoem
    {
        public static List<EntityPoem> PoemList()
        {
            List<EntityPoem> values = new List<EntityPoem>();
            SqlCommand command = new SqlCommand("Select * from TblPoems", DbConnection.sqlConnection);
            if(command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open(); 
            }
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityPoem entityPoem = new EntityPoem();
                entityPoem.Poemid=int.Parse(dataReader["PoemID"].ToString());
                entityPoem.Poemname=dataReader["PoemName"].ToString();
                entityPoem.Poetnamesurname = dataReader["PoetNameSurname"].ToString();
                entityPoem.Categoryid = int.Parse(dataReader["CategoryID"].ToString());
                values.Add(entityPoem);
            }
            return values;
        }

        public static void AddPoem(EntityPoem entityPoem)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblPoems (PoemName, PoetNameSurname, CategoryID) values (@p1,@p2,@p3)", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", entityPoem.Poemname);
            command.Parameters.AddWithValue("@p2", entityPoem.Poetnamesurname);
            command.Parameters.AddWithValue("@p3", entityPoem.Categoryid);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

        public static void DeletePoem(int id)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete from TblPoems where PoemID=@p1", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1",id);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }

        public static void UpdatePoem(EntityPoem entityPoem)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblPoems set PoemName=@p1, PoetNameSurname=@p2, CategoryID=@p3 where PoemID=@p4", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", entityPoem.Poemname);
            command.Parameters.AddWithValue("@p2", entityPoem.Poetnamesurname);
            command.Parameters.AddWithValue("@p3", entityPoem.Categoryid);
            command.Parameters.AddWithValue("@p4", entityPoem.Poemid);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }
    }
}
