
namespace Seminar2_FirstEx
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.junior = new System.Windows.Forms.RadioButton();
            this.intermediate = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.spring = new System.Windows.Forms.CheckBox();
            this.jpa = new System.Windows.Forms.CheckBox();
            this.apachePoi = new System.Windows.Forms.CheckBox();
            this.senior = new System.Windows.Forms.RadioButton();
            this.lead = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ploteso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // junior
            // 
            this.junior.AutoSize = true;
            this.junior.Location = new System.Drawing.Point(106, 126);
            this.junior.Name = "junior";
            this.junior.Size = new System.Drawing.Size(68, 21);
            this.junior.TabIndex = 1;
            this.junior.TabStop = true;
            this.junior.Text = "Junior";
            this.junior.UseVisualStyleBackColor = true;
            this.junior.CheckedChanged += new System.EventHandler(this.junior_CheckedChanged);
            // 
            // intermediate
            // 
            this.intermediate.AutoSize = true;
            this.intermediate.Location = new System.Drawing.Point(106, 154);
            this.intermediate.Name = "intermediate";
            this.intermediate.Size = new System.Drawing.Size(107, 21);
            this.intermediate.TabIndex = 2;
            this.intermediate.TabStop = true;
            this.intermediate.Text = "Intermediate";
            this.intermediate.UseVisualStyleBackColor = true;
            this.intermediate.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(297, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(192, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Progresi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // spring
            // 
            this.spring.AutoSize = true;
            this.spring.Location = new System.Drawing.Point(457, 126);
            this.spring.Name = "spring";
            this.spring.Size = new System.Drawing.Size(71, 21);
            this.spring.TabIndex = 6;
            this.spring.Text = "Spring";
            this.spring.UseVisualStyleBackColor = true;
            this.spring.CheckedChanged += new System.EventHandler(this.spring_CheckedChanged);
            // 
            // jpa
            // 
            this.jpa.AutoSize = true;
            this.jpa.Location = new System.Drawing.Point(457, 154);
            this.jpa.Name = "jpa";
            this.jpa.Size = new System.Drawing.Size(121, 21);
            this.jpa.TabIndex = 7;
            this.jpa.Text = "JPA/Hibernate";
            this.jpa.UseVisualStyleBackColor = true;
            this.jpa.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // apachePoi
            // 
            this.apachePoi.AutoSize = true;
            this.apachePoi.Location = new System.Drawing.Point(457, 182);
            this.apachePoi.Name = "apachePoi";
            this.apachePoi.Size = new System.Drawing.Size(105, 21);
            this.apachePoi.TabIndex = 8;
            this.apachePoi.Text = "Apache POI";
            this.apachePoi.UseVisualStyleBackColor = true;
            this.apachePoi.CheckedChanged += new System.EventHandler(this.apachePoi_CheckedChanged);
            // 
            // senior
            // 
            this.senior.AutoSize = true;
            this.senior.Location = new System.Drawing.Point(106, 182);
            this.senior.Name = "senior";
            this.senior.Size = new System.Drawing.Size(70, 21);
            this.senior.TabIndex = 9;
            this.senior.TabStop = true;
            this.senior.Text = "Senior";
            this.senior.UseVisualStyleBackColor = true;
            this.senior.CheckedChanged += new System.EventHandler(this.senior_CheckedChanged);
            // 
            // lead
            // 
            this.lead.AutoSize = true;
            this.lead.Location = new System.Drawing.Point(106, 209);
            this.lead.Name = "lead";
            this.lead.Size = new System.Drawing.Size(61, 21);
            this.lead.TabIndex = 10;
            this.lead.TabStop = true;
            this.lead.Text = "Lead";
            this.lead.UseVisualStyleBackColor = true;
            this.lead.CheckedChanged += new System.EventHandler(this.lead_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vleresimi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lead);
            this.Controls.Add(this.senior);
            this.Controls.Add(this.apachePoi);
            this.Controls.Add(this.jpa);
            this.Controls.Add(this.spring);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.intermediate);
            this.Controls.Add(this.junior);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton junior;
        private System.Windows.Forms.RadioButton intermediate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox spring;
        private System.Windows.Forms.CheckBox jpa;
        private System.Windows.Forms.CheckBox apachePoi;
        private System.Windows.Forms.RadioButton senior;
        private System.Windows.Forms.RadioButton lead;
        private System.Windows.Forms.Label label2;
    }
}

