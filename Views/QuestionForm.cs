using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class QuestionForm : Form
    {
        public string question;
        public MainForm mainForm;
        private Queue<string> questions;
        //Testing testing = new Testing();

        public QuestionForm(Queue<string> questions, MainForm mainForm)
        {
            InitializeComponent();

            this.question = questions.Peek();
            this.mainForm = mainForm;
            this.questions = questions;

            QuestionBox.Text = question;

            //var list = testing.getAnswers(question);

            //Random rng = new Random();
            //int n = list.Count;
            //while (n > 1)
            //{
            //    n--;
            //    int k = rng.Next(n + 1);
            //    string value = list[k];
            //    list[k] = list[n];
            //    list[n] = value;
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    ((RadioButton)QuestionBox.Controls[i]).Text = list[i];
            //}

        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //foreach (var i in QuestionBox.Controls)
            //{
            //    if (((RadioButton)i).Checked)
            //    {
            //        MessageBox.Show(testing.checkAnswer(this.question, ((RadioButton)i).Text) ? "Правильно" : "Не правильно");
            //    }
            //}

            //if (this.questions.Count > 1)
            //{
            //    questions.Dequeue();
            //    var form = new QuestionForm(this.questions, this.mainForm);
            //    form.Show();
            //    this.Hide();
            //}
        }
    }
}
