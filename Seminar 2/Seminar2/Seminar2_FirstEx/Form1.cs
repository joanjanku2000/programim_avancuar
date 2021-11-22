using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar2_FirstEx
{
    public partial class Form1 : Form
    {
        private double juniorCoefficient = 0.8;
        private double intermediateCoefficient = 1.0;
        private double seniorCoefficient = 1.2;
        private double techLeadCoefficient = 2.0;
        private double technologyCoefficient = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int) calculateProgress();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalProgress = calculateProgress();
            Console.WriteLine("TOtal progress is " + totalProgress);
            progressBar1.Value = (int) Math.Round(totalProgress);
        }

        private double getSelectedCoefficient()
        {
            if (junior.Checked) return juniorCoefficient;
            else if (intermediate.Checked) return intermediateCoefficient;
            else if (senior.Checked) return seniorCoefficient;
            else return techLeadCoefficient;

        }
        private double techSpecificCoefficient()
        {
            int count = 0;
            if (spring.Checked) count++;
            if (jpa.Checked) count++;
            if (apachePoi.Checked) count++;

            return count * technologyCoefficient;
        }
        private double getHoursValue()
        {
            try
            {
                double value = Double.Parse(textBox1.Text);
                if (value > 2) return 2.0;
                if (value < 0) return 0.0;
                return value;

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0.0;
            }
        }

        private double calculateProgress()
        {
            return (getHoursValue() + getSelectedCoefficient() + techSpecificCoefficient() ) * 10 ;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)calculateProgress();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void junior_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)calculateProgress();
        }

        private void senior_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)calculateProgress();
        }

        private void lead_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)calculateProgress();
        }

        private void spring_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)calculateProgress();
        }

        private void apachePoi_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)calculateProgress();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int) calculateProgress();
        }
    }
}
