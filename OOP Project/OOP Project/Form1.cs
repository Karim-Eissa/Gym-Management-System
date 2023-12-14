using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            addNewMember mem = new addNewMember();
            mem.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            addNewCoach coach = new addNewCoach();
            coach.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNewStaff staff = new addNewStaff();
            staff.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            information info = new information();
            info.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            search search = new search();
            search.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            search search = new search();
            search.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            addNewMember mem = new addNewMember();
            mem.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            addNewStaff staff = new addNewStaff();
            staff.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            addNewCoach coach = new addNewCoach();
            coach.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            information info = new information();
            info.Show();
        }
    }
}
