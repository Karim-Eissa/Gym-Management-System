using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class addNewStaff : Form
    {
        private GymDatabaseManager _gymDatabaseManager;
        public addNewStaff()
        {
            InitializeComponent();
            _gymDatabaseManager = new GymDatabaseManager("mongodb+srv://karimeissa:Qwerty123@cluster0.h1x6qzi.mongodb.net/?retryWrites=true&w=majority", "gym");
            button1.Click += new EventHandler(button1_Click);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) || comboBox2.SelectedItem == null || (radioButton1.Checked == false && radioButton2.Checked == false) ||
            string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill out all fields before adding a staff member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string name = textBox6.Text;
                int age = Convert.ToInt32(comboBox2.SelectedItem);
                string gender = radioButton1.Checked ? "Male" : "Female";
                string salary = textBox2.Text;
                string position = textBox1.Text;

                Staff newStaff = new Staff(name, age, gender, "staff", DateTime.Now, salary, position);
                BsonDocument documentToAdd = new BsonDocument
                {
                    { "Name", newStaff.Name },
                    { "Age", newStaff.Age },
                    { "Gender", newStaff.Gender },
                    { "Type", newStaff.Type },
                    { "StartDate", newStaff.StartDate },
                    { "Salary", newStaff.Salary },
                    { "Position", newStaff.Position }
                };

                _gymDatabaseManager.InsertDocument(documentToAdd);
                MessageBox.Show("Staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addNewStaff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
