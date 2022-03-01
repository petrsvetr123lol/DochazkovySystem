using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DochazkovySystem
{
    public partial class Form1 : Form
    {
        List<Person> people;
        List<Record> records;
        SqlRepository SqlRepository = new SqlRepository();
        public Form1()
        {
            InitializeComponent();
            SetButtons(false);
            people = SqlRepository.GetPeople();
            records = new List<Record>();
            foreach (Person person in people)
            {
                records.AddRange(person.Records);
            }
            RefrshGUI();
           
        }

        private void RefrshGUI()
        {
            listboxAll.Items.Clear();
            listboxPerson.Items.Clear();
            listboxRecord.Items.Clear();
            foreach(Person person in people)
            {
                listboxPerson.Items.Add($"{person.PersonalNumber} - {person.Lastname} - {person.Firstname}");
            }
            //psano  v Linqu
            foreach (Record record in records.OrderByDescending(p=> p.DateTime)) 
            {
                listboxAll.Items.Add($"{record.DateTime} - {record.Person.Lastname} - {record.Reason}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void listboxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listboxPerson.SelectedIndex;
            listboxRecord.Items.Clear();
            if (index >= 0)
            {
                SetButtons(true);
                listboxRecord.Items.Clear();
                foreach (Record record in people[index].Records.OrderByDescending(p => p.DateTime)) 
                {
                    listboxRecord.Items.Add($"{record.DateTime} - {record.Reason}");
                }
            }
            else
            {
                SetButtons(false);
            }
            
        }

        private void SetButtons(bool enabled)
        {
            btnDoctorEnd.Enabled = enabled;
            btnDoctorStart.Enabled = enabled;
            btnShiftStart.Enabled = enabled;
            btnShiftEnd.Enabled = enabled;
            btnPauseStart.Enabled = enabled;
            btnPauseEnd.Enabled = enabled;
        }

        private void btnShiftStart_Click(object sender, EventArgs e)
        {

        }

        private void btnShiftEnd_Click(object sender, EventArgs e)
        {

        }

        private void btnPauseStart_Click(object sender, EventArgs e)
        {

        }

        private void btnPauseEnd_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorStart_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
