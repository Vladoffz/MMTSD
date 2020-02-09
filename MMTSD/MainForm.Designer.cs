namespace MMTSD
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
            this.QuestionsListBox = new System.Windows.Forms.ListBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionsListBox
            // 
            this.QuestionsListBox.FormattingEnabled = true;
            this.QuestionsListBox.ItemHeight = 16;
            this.QuestionsListBox.Location = new System.Drawing.Point(21, 39);
            this.QuestionsListBox.Name = "QuestionsListBox";
            this.QuestionsListBox.Size = new System.Drawing.Size(540, 212);
            this.QuestionsListBox.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(599, 68);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(169, 140);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.QuestionsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox QuestionsListBox;
        private System.Windows.Forms.Button OkButton;
    }
}

