﻿namespace AppProject.Views
{
    partial class QuestionForm
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
            this.QuestionBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.QuestionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionBox
            // 
            this.QuestionBox.Controls.Add(this.radioButton4);
            this.QuestionBox.Controls.Add(this.radioButton3);
            this.QuestionBox.Controls.Add(this.radioButton2);
            this.QuestionBox.Controls.Add(this.radioButton1);
            this.QuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionBox.Location = new System.Drawing.Point(57, 31);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(491, 245);
            this.QuestionBox.TabIndex = 4;
            this.QuestionBox.TabStop = false;
            this.QuestionBox.Text = "groupBox1";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.Location = new System.Drawing.Point(25, 168);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Location = new System.Drawing.Point(25, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(25, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(25, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.Lavender;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Font = new System.Drawing.Font("MingLiU-ExtB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(591, 98);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(157, 111);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.OkButton);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestionForm_FormClosed);
            this.QuestionBox.ResumeLayout(false);
            this.QuestionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox QuestionBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button OkButton;
    }
}