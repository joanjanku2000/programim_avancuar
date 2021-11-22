
namespace App
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
            this.doILikeHer = new System.Windows.Forms.Button();
            this.howAreYouTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.lessonTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // doILikeHer
            // 
            this.doILikeHer.Location = new System.Drawing.Point(81, 79);
            this.doILikeHer.Name = "doILikeHer";
            this.doILikeHer.Size = new System.Drawing.Size(180, 34);
            this.doILikeHer.TabIndex = 0;
            this.doILikeHer.Text = "Hi How are you ?";
            this.doILikeHer.UseVisualStyleBackColor = true;
            this.doILikeHer.Click += new System.EventHandler(this.button1_Click);
            // 
            // howAreYouTextBox
            // 
            this.howAreYouTextBox.Location = new System.Drawing.Point(95, 124);
            this.howAreYouTextBox.Name = "howAreYouTextBox";
            this.howAreYouTextBox.Size = new System.Drawing.Size(148, 22);
            this.howAreYouTextBox.TabIndex = 1;
            this.howAreYouTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "What\'s your name?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 166);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "What subject is this ?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Which lesson is this ?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(95, 221);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(381, 124);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(148, 22);
            this.subjectTextBox.TabIndex = 7;
            // 
            // lessonTextBox
            // 
            this.lessonTextBox.Location = new System.Drawing.Point(381, 221);
            this.lessonTextBox.Name = "lessonTextBox";
            this.lessonTextBox.Size = new System.Drawing.Size(148, 22);
            this.lessonTextBox.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Lidhu me databazen :)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 551);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lessonTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.howAreYouTextBox);
            this.Controls.Add(this.doILikeHer);
            this.Name = "Form1";
            this.Text = "Joan\'s Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doILikeHer;
        private System.Windows.Forms.TextBox howAreYouTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox lessonTextBox;
        private System.Windows.Forms.Button button4;
    }
}

