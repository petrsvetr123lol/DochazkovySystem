using System.Collections.Generic;
using System.Data.SqlClient;

namespace DochazkovySystem
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DochazkovySystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private List<Person> TempPeople()
        {
            List<Person> people = new List<Person>();
            Person person1 = new Person()
            {
                Id = 1,
                ChipId = "123456",
                Firstname = "John",
                Lastname ="Doe",
                PersonalNumber = "1"
            };
            Person person2 = new Person()
            {
                Id = 2,
                ChipId = "123456",
                Firstname = "Petr",
                Lastname = "Lanik",
                PersonalNumber = "2"
            };
            people.Add(person1);
            people.Add(person2);

            return people;
        }
        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            //správný způsob použití
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
            }


              return people;
        }
        
    }
}
