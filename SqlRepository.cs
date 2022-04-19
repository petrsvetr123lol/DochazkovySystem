using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DochazkovySystem
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\filip.petr\Desktop\dochazkovy-system\DochazkovySystem\DochazkovySystem.mdf;Integrated Security=True";
     
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            //správný způsob použití
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Person", sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            people.Add(new Person()
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                Firstname = dataReader["FirstName"].ToString(),
                                Lastname = dataReader["LastName"].ToString(),
                                PersonalNumber = dataReader["PersonalNumber"].ToString(),
                                ChipId = dataReader["ChipID"].ToString(),
                            }); 
                        }
                    }
                } 
                sqlConnection.Close();
            }
            return people;
        }
        public List<Person> GetRecords()
        {
            List<Record> records = new List<Record>();

            //správný způsob použití
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Records", sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            records.Add(new Record()
                            {
                                Id = Convert.ToInt32(dataReader["Id"]),
                                Firstname = dataReader["FirstName"].ToString(),
                                Lastname = dataReader["LastName"].ToString(),
                                PersonalNumber = dataReader["PersonalNumber"].ToString(),
                                ChipId = dataReader["ChipID"].ToString(),
                            });
                        }
                    }
                }
                sqlConnection.Close();
            }
            return records;
        }

    }
}
