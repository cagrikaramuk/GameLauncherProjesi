﻿namespace GameLauncherProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(200, 175);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.Text = "Profil 1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(200, 241);
            button4.Name = "button4";
            button4.Size = new Size(60, 23);
            button4.TabIndex = 3;
            button4.Text = "Duzenle";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(400, 175);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 6;
            button2.Text = "Profil 2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Location = new Point(600, 175);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 7;
            button3.Text = "Profil 3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Location = new Point(400, 241);
            button5.Name = "button5";
            button5.Size = new Size(60, 23);
            button5.TabIndex = 8;
            button5.Text = "Duzenle";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(600, 241);
            button6.Name = "button6";
            button6.Size = new Size(60, 23);
            button6.TabIndex = 9;
            button6.Text = "Duzenle";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(884, 486);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}
