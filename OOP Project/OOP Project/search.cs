using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OOP_Project
{
    public partial class search : Form
    {
        private GymDatabaseManager _gymDatabaseManager;
        public search()
        {
            InitializeComponent();
            _gymDatabaseManager = new GymDatabaseManager("mongodb+srv://karimeissa:Qwerty123@cluster0.h1x6qzi.mongodb.net/?retryWrites=true&w=majority", "gym");
            button6.Click += new EventHandler(button6_Click);
        }
        private BindingSource bindingSource = new BindingSource();
        private void button6_Click(object sender, EventArgs e)
        {
            string searchName = textBox1.Text;

            // Check if the search name is not empty
            if (!string.IsNullOrEmpty(searchName))
            {
                // Check which radio button is checked
                if (radioButton1.Checked)
                {
                    // Perform the search for members
                    SearchMembersByName(searchName);
                }
                else if (radioButton2.Checked)
                {
                    // Perform the search for staff
                    SearchStaffByName(searchName);
                }
                else if (radioButton3.Checked)
                {
                    // Perform the search for coaches
                    SearchCoachByName(searchName);
                }
                else
                {
                    MessageBox.Show("Please select a search type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchMembersByName(string searchName)
        {
            var collection = _gymDatabaseManager.GetMemberCollection();
            var typeFilter = Builders<Member>.Filter.Eq("Type", GetSelectedType());
            var nameFilter = Builders<Member>.Filter.Regex("Name", new BsonRegularExpression(searchName, "i"));
            var combinedFilter = Builders<Member>.Filter.And(typeFilter, nameFilter);
            var result = collection.Find(combinedFilter).ToList();

            // Clear existing rows in the DataGridView
            dataGridView1.Rows.Clear();
            bindingSource.DataSource = result;

            // Add the search results to the DataGridView
            foreach (var member in result)
            {
                dataGridView1.Rows.Add(member.Name, member.Age, member.Gender, member.StartDate, member.Months, "-", "-", "-", member.Type);
            }
        }

        private void SearchStaffByName(string searchName)
        {
            var collection = _gymDatabaseManager.GetStaffCollection();
            var typeFilter = Builders<Staff>.Filter.Eq("Type", GetSelectedType());
            var nameFilter = Builders<Staff>.Filter.Regex("Name", new BsonRegularExpression(searchName, "i"));
            var combinedFilter = Builders<Staff>.Filter.And(typeFilter, nameFilter);
            var result = collection.Find(combinedFilter).ToList();

            // Clear existing rows in the DataGridView
            dataGridView1.Rows.Clear();
            bindingSource.DataSource = result;

            // Add the search results to the DataGridView
            foreach (var staff in result)
            {
                dataGridView1.Rows.Add(staff.Name, staff.Age, staff.Gender, staff.StartDate, "-", staff.Position, staff.Salary, "-", staff.Type);
            }
        }

        private void SearchCoachByName(string searchName)
        {
            var collection = _gymDatabaseManager.GetCoachCollection();
            var typeFilter = Builders<Coach>.Filter.Eq("Type", GetSelectedType());
            var nameFilter = Builders<Coach>.Filter.Regex("Name", new BsonRegularExpression(searchName, "i"));
            var combinedFilter = Builders<Coach>.Filter.And(typeFilter, nameFilter);
            var result = collection.Find(combinedFilter).ToList();

            // Clear existing rows in the DataGridView
            dataGridView1.Rows.Clear();
            bindingSource.DataSource = result;

            // Add the search results to the DataGridView
            foreach (var coach in result)
            {
                dataGridView1.Rows.Add(coach.Name, coach.Age, coach.Gender, coach.StartDate, "-", "-", "-", coach.FeesPerMonth, coach.Type);
            }
        }

        private string GetSelectedType()
        {
            if (radioButton1.Checked)
            {
                return "member";
            }
            else if (radioButton2.Checked)
            {
                return "staff";
            }
            else if (radioButton3.Checked)
            {
                return "coach";
            }

            return string.Empty; // Handle the case when no radio button is checked
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
