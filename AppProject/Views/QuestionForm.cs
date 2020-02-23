using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppProject.Presenters;

namespace AppProject.Views
{
    public partial class QuestionForm : Form, IViewQuestion
    {
        public MainForm mainForm;
        private IPresenter presenter;
        public List<string> answerStrings { get; set; }
        public string questionString { get; set; }
        public string chosenAnswer { get; set; }
        public QuestionForm(List<string> answers, string question, MainForm mainForm)
        {
            InitializeComponent();
            this.answerStrings = answers;
            this.questionString = question;
            this.mainForm = mainForm;
            this.presenter = mainForm.presenter;
            QuestionBox.Text = question;
            mainForm.Hide();

            Random rng = new Random();
            int n = answers.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = answers[k];
                answers[k] = answers[n];
                answers[n] = value;
            }

            for (int i = 0; i < answers.Count; i++)
            {
                ((RadioButton)QuestionBox.Controls[i]).Text = answers[i];
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (var i in QuestionBox.Controls)
            {
                if (((RadioButton)i).Checked)
                {
                    chosenAnswer = ((RadioButton)i).Text;
                }
            }

            MessageBox.Show(presenter.CheckAnswer(questionString, chosenAnswer)?"Правильно":"Не правильно");
            this.Hide();
            
            presenter.Update();
        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Close();
        }
    }
}
