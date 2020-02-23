namespace Views
{
    partial class MainForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.QuestionsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.Lavender;
            this.OkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkButton.Font = new System.Drawing.Font("SimSun-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(764, 66);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(169, 140);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "ok";
            this.OkButton.UseVisualStyleBackColor = false;
            // 
            // QuestionsListBox
            // 
            this.QuestionsListBox.BackColor = System.Drawing.Color.Snow;
            this.QuestionsListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QuestionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionsListBox.FormattingEnabled = true;
            this.QuestionsListBox.ItemHeight = 18;
            this.QuestionsListBox.Location = new System.Drawing.Point(21, 39);
            this.QuestionsListBox.Name = "QuestionsListBox";
            this.QuestionsListBox.Size = new System.Drawing.Size(715, 202);
            this.QuestionsListBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(976, 312);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.QuestionsListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ListBox QuestionsListBox;
    }
}