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
            RefreshGui();
           
        }

        private void RefreshGui()
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
                listboxAll.Items.Add($"{record.DateTime.ToString("dd.MM hh:mm")} - {record.Person.Lastname} - {record.Reason}");
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
            
            int index = listboxPerson.SelectedIndex;
            if (index >= 0)
            {
                Record newRecord = new Record()
                {
                    DateTime = DateTime.Now,
                    Person = people[index],
                    Reason = RecordReason.StartShift
                };
                records.Add(newRecord);
                people[index].Records.Add(newRecord);
                RefreshGui();
            }
        }

        private void btnShiftEnd_Click(object sender, EventArgs e)
        {
            int index = listboxPerson.SelectedIndex;
            if (index >= 0)
            {
                Record newRecord = new Record()
                {
                    DateTime = DateTime.Now,
                    Person = people[index],
                    Reason = RecordReason.EndShift
                };
                records.Add(newRecord);
                people[index].Records.Add(newRecord);
                RefreshGui();
            }
        }

        private void btnPauseStart_Click(object sender, EventArgs e)
        {
            int index = listboxPerson.SelectedIndex;
            if (index >= 0)
            {
                Record newRecord = new Record()
                {
                    DateTime = DateTime.Now,
                    Person = people[index],
                    Reason = RecordReason.StartPause
                };
                records.Add(newRecord);
                people[index].Records.Add(newRecord);
                RefreshGui();
            }
        }

        private void btnPauseEnd_Click(object sender, EventArgs e)
        {
            int index = listboxPerson.SelectedIndex;
            if (index >= 0)
            {
                Record newRecord = new Record()
                {
                    DateTime = DateTime.Now,
                    Person = people[index],
                    Reason = RecordReason.EndPause
                };
                records.Add(newRecord);
                people[index].Records.Add(newRecord);
                RefreshGui();
            }
        }

        private void btnDoctorStart_Click(object sender, EventArgs e)
        {
            int index = listboxPerson.SelectedIndex;
            if (index >= 0)
            {
                Record newRecord = new Record()
                {
                    DateTime = DateTime.Now,
                    Person = people[index],
                    Reason = RecordReason.StartDoctor
                };
                records.Add(newRecord);
                people[index].Records.Add(newRecord);
                RefreshGui();
            }
        }

        private void btnDoctorEnd_Click(object sender, EventArgs e)
        {
            int index = listboxPerson.SelectedIndex;
            if (index >= 0)
            {
                Record newRecord = new Record()
                {
                    DateTime = DateTime.Now,
                    Person = people[index],
                    Reason = RecordReason.EndDoctor
                };
                records.Add(newRecord);
                people[index].Records.Add(newRecord);
                RefreshGui();
            }
        }
    }
}
