
namespace Seminar2
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
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.movableLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveRight
            // 
            this.moveRight.BackColor = System.Drawing.Color.Honeydew;
            this.moveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveRight.Location = new System.Drawing.Point(513, 342);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(46, 35);
            this.moveRight.TabIndex = 4;
            this.moveRight.Text = "+";
            this.moveRight.UseVisualStyleBackColor = false;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.BackColor = System.Drawing.Color.Honeydew;
            this.moveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveLeft.Location = new System.Drawing.Point(461, 342);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(46, 35);
            this.moveLeft.TabIndex = 5;
            this.moveLeft.Text = "-";
            this.moveLeft.UseVisualStyleBackColor = false;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveUp
            // 
            this.moveUp.BackColor = System.Drawing.Color.Honeydew;
            this.moveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUp.Location = new System.Drawing.Point(149, 92);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(46, 35);
            this.moveUp.TabIndex = 6;
            this.moveUp.Text = "+";
            this.moveUp.UseVisualStyleBackColor = false;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.BackColor = System.Drawing.Color.Honeydew;
            this.moveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDown.Location = new System.Drawing.Point(149, 133);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(46, 35);
            this.moveDown.TabIndex = 7;
            this.moveDown.Text = "-";
            this.moveDown.UseVisualStyleBackColor = false;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // movableLabel
            // 
            this.movableLabel.AutoSize = true;
            this.movableLabel.BackColor = System.Drawing.Color.GhostWhite;
            this.movableLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movableLabel.Location = new System.Drawing.Point(3, 207);
            this.movableLabel.Name = "movableLabel";
            this.movableLabel.Size = new System.Drawing.Size(150, 27);
            this.movableLabel.TabIndex = 0;
            this.movableLabel.Text = "Moving Label";
            this.movableLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.movableLabel);
            this.panel1.Location = new System.Drawing.Point(201, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 244);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moveDown);
            this.Controls.Add(this.moveUp);
            this.Controls.Add(this.moveLeft);
            this.Controls.Add(this.moveRight);
            this.Name = "Form1";
            this.Text = "io";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Label movableLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

