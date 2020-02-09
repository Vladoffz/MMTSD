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
        private Queue<Question> questions;

        public QuestionForm(Queue<Question> questions, MainForm mainForm)
        {
            InitializeComponent();

            this.question = questions.Peek();
            this.mainForm = mainForm;
            this.questions = questions;

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

            for (int i = 0; i < arr.Length; i++)
            {
                ((RadioButton)QuestionBox.Controls[i]).Text = arr[i].Text;
            }

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
                            MessageBox.Show(j.IsRight ? "ok" : "NOT ok");
                        }
                    }
                }
            }

            if (this.questions.Count > 1)
            {
                questions.Dequeue();
                var form = new QuestionForm(this.questions, this.mainForm);
                form.Show();
                this.Hide();
            }
        }
    }
}
