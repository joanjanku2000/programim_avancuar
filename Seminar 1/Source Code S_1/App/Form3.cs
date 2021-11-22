using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class InputForm : Form
    {
        private string textBoxValue;


        public InputForm()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string input;
            try
            {
                 input = Input.Text;
                
            } catch (Exception ex)
            {
                input = ex.Message;
            }
            if (input.Length == 0)
            {
                label1.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                label1.Text = "Field is required";
                label1.ForeColor = Color.Red;
             
                return;
            }
            this.textBoxValue = input;
            this.Close();
        }

        public string getTextValue()
        {
            return textBoxValue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
