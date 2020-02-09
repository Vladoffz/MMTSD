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
    public partial class MainForm : Form
    {
        Testing testing = new Testing();
        private Question easyQuestion;
        private Question basicQuestion;
        private Question complicatedQuestion;
        private int count = 0;
        public MainForm()
        {
            InitializeComponent();
            foreach (var question in testing.Questions)
            {
                if (question.Category == QuestionCategory.Easy)
                {
                    QuestionsListBox.Items.Add(question.QuestionText);
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                foreach (var question in testing.Questions)
                {
                    if (QuestionsListBox.SelectedItem == question.QuestionText)
                    {
                        this.easyQuestion = question;
                    }
                }
                QuestionsListBox.Items.Clear();
                foreach (var question in testing.Questions)
                {
                    if (question.Category == QuestionCategory.Basic)
                    {
                        QuestionsListBox.Items.Add(question.QuestionText);

                    }
                }
                count++;
            }
            else if (count == 1)
            {
                foreach (var question in testing.Questions)
                {
                    if (QuestionsListBox.SelectedItem == question.QuestionText)
                    {
                        this.basicQuestion = question;
                    }
                }
                QuestionsListBox.Items.Clear();
                foreach (var question in testing.Questions)
                {
                    if (question.Category == QuestionCategory.Complicated)
                    {
                        QuestionsListBox.Items.Add(question.QuestionText);
                        complicatedQuestion = question;
                    }
                }
                foreach (var question in testing.Questions)
                {
                    if (QuestionsListBox.SelectedItem == question.QuestionText)
                    {
                        this.complicatedQuestion = question;
                    }
                }
                count++;
            }
            else if (count > 1)
            {
                QuestionForm form = new QuestionForm(this.easyQuestion, this);
                form.Show();
                this.Hide();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void QuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
