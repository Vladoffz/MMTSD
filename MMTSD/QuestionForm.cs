using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMTSD
{
    public partial class QuestionForm : Form
    {
        public Question question;
        public MainForm mainForm;

        public QuestionForm(Question question, MainForm mainForm)
        {
            InitializeComponent();
            this.question = question;
            this.mainForm = mainForm;
            QuestionBox.Text = question.QuestionText;
            Answer[] arr = new Answer[question.Answers.Length];
            question.Answers.CopyTo(arr, 0);
            Random rng = new Random();
            int n = arr.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Answer value = arr[k];
                arr[k] = arr[n];
                arr[n] = value;
            }
            radioButton1.Text = arr[0].Text;
            radioButton2.Text = arr[1].Text;
            radioButton3.Text = arr[2].Text;
            radioButton4.Text = arr[3].Text;

        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (var i in QuestionBox.Controls)
            {
                if (((RadioButton)i).Checked)
                {
                    foreach (var j in question.Answers)
                    {
                        if (((RadioButton) i).Text == j.Text)
                        {
                            if (j.IsRight) MessageBox.Show("ok");
                            else MessageBox.Show("NOT ok");
                        }
                    }
                }
            }
        }
    }
}
