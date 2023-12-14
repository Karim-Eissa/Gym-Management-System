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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Project
{
    public partial class addNewCoach : Form
    {
        private GymDatabaseManager _gymDatabaseManager;
        public addNewCoach()
        {
            InitializeComponent();
            _gymDatabaseManager = new GymDatabaseManager("mongodb+srv://karimeissa:Qwerty123@cluster0.h1x6qzi.mongodb.net/?retryWrites=true&w=majority", "gym");
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text) || comboBox2.SelectedItem == null || (radioButton1.Checked == false && radioButton2.Checked == false) ||
           string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill out all fields before adding a coach.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string name = textBox6.Text;
                int age = Convert.ToInt32(comboBox2.SelectedItem);
                string gender = radioButton1.Checked ? "Male" : "Female";
                string fees = textBox2.Text;

                Coach newCoach = new Coach(name, age, gender, "coach", DateTime.Now, fees);
                BsonDocument documentToAdd = new BsonDocument
                {
                    { "Name", newCoach.Name },
                    { "Age", newCoach.Age },
                    { "Gender", newCoach.Gender },
                    { "Type", newCoach.Type },
                    { "StartDate", newCoach.StartDate },
                    { "FeesPerMonth", newCoach.FeesPerMonth }
                };

                _gymDatabaseManager.InsertDocument(documentToAdd);
                MessageBox.Show("Coach added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding coach: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewCoach_Load(object sender, EventArgs e)
        {

        }
    }
}
