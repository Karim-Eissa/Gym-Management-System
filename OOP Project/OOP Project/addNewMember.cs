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
    public partial class addNewMember : Form
    {
        private GymDatabaseManager _gymDatabaseManager;
        public addNewMember()
        {
            InitializeComponent();
            _gymDatabaseManager = new GymDatabaseManager("mongodb+srv://karimeissa:Qwerty123@cluster0.h1x6qzi.mongodb.net/?retryWrites=true&w=majority", "gym");
            button1.Click += new EventHandler(button1_Click);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) || comboBox2.SelectedItem == null || (radioButton1.Checked == false && radioButton2.Checked == false) ||
            comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all fields before adding a member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string name = textBox6.Text;
                int age = Convert.ToInt32(comboBox2.SelectedItem);
                string gender = radioButton1.Checked ? "Male" : "Female";
                int planType = Convert.ToInt32(comboBox1.SelectedItem);

                Member newMember = new Member(name, age, gender, "member", DateTime.Now, planType);
                BsonDocument documentToAdd = new BsonDocument
                {
                    { "Name", newMember.Name },
                    { "Age", newMember.Age },
                    { "Gender", newMember.Gender },
                    { "Type", newMember.Type },
                    { "StartDate", newMember.StartDate },
                    { "Months", newMember.Months }
                };
                _gymDatabaseManager.InsertDocument(documentToAdd);
                MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
