using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            howAreYouTextBox.Text = "I'm fine thanks :)";
            howAreYouTextBox.ForeColor = Color.Red;
            howAreYouTextBox.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nameTextBox.Text = "Joan";
            nameTextBox.ForeColor = Color.BlueViolet;
            nameTextBox.Font = new Font("Sans Serif", 12, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputForm form = new InputForm();     
            form.ShowDialog();

            if (form.getTextValue() != null)
            {
                subjectTextBox.Text = form.getTextValue();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog();

            if (inputForm.getTextValue() != null)
            {
                lessonTextBox.Text = inputForm.getTextValue();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-M7F6609;Initial Catalog=test;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from Test_table where id = 2"
                , sqlConnection); ;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
