using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMTSD_Business_Layer;

namespace MMTSD
{
    public partial class MainForm : Form
    {
        Testing testing = new Testing();
        Queue<string> questionList = new Queue<string>();
        private int count = 1;

        public MainForm()
        {
            InitializeComponent();

            foreach (var c in testing.GetQuestions()[0])
            {
                if (c.Length > 70)
                {
                    QuestionsListBox.Items.Add(c.Substring(0, 70) + "...");
                }
                else
                    QuestionsListBox.Items.Add(c);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            questionList.Enqueue((string)QuestionsListBox.SelectedItem);
            if (count < testing.GetQuestions().Count)
            {

                QuestionsListBox.Items.Clear();

                foreach (var c in testing.GetQuestions()[count])
                {
                    if (c.Length > 70)
                    {
                        QuestionsListBox.Items.Add(c.Substring(0, 70) + "...");
                    }
                    else
                        QuestionsListBox.Items.Add(c);
                }

                count++;
            }
            else
            {
                QuestionForm form = new QuestionForm(questionList, this);
                form.Show();
                this.Hide();
            }

        }

    }
}

