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
        private Queue<Question> questions = new Queue<Question>();
        private Queue<QuestionCategory> categories;

        public MainForm()
        {
            InitializeComponent();
            categories = new Queue<QuestionCategory>();
            foreach (var i in Enum.GetValues(typeof(QuestionCategory)))
            {
                categories.Enqueue((QuestionCategory) i);
            }

            var category = categories.Dequeue();
            foreach (var c in testing.Questions)
            {
                if (c.Category == category) QuestionsListBox.Items.Add(c.QuestionText);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (var question in testing.Questions)
            {
                if (QuestionsListBox.SelectedItem == question.QuestionText)
                {
                    questions.Enqueue(question);
                }
            }

            if (categories.Count > 0)
            {
                QuestionsListBox.Items.Clear();
                var category = categories.Dequeue();
                foreach (var c in testing.Questions)
                {
                    if (c.Category == category) QuestionsListBox.Items.Add(c.QuestionText);
                }
            }
            else
            {
                QuestionForm form = new QuestionForm(questions, this);
                form.Show();
                this.Hide();
            }
        }
    }
}
