using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppProject.Presenters;

namespace AppProject.Views
{
    public partial class MainForm : Form, IViewMain
    {
        public IPresenter presenter;
        public string chosenQuestionText { get; set; }
        public List<string> questionsText { get; set; }

        public event Action chosenQestionEvent;

        public MainForm()
        {
            InitializeComponent();
            questionsText = new List<string>();
            presenter = new TestingPresenter(this);
            foreach (var c in this.questionsText)
            {
                if (c.Length > 70)
                {
                    QuestionsListBox.Items.Add(c.Substring(0, 70) + "...");
                }
                else
                    QuestionsListBox.Items.Add(c);
            }
        }

        private void OkButton_Click_1(object sender, EventArgs e)
        {
            chosenQuestionText = (string)QuestionsListBox.SelectedItem;
            presenter.QuestionsText.Add(chosenQuestionText);
            chosenQestionEvent = presenter.Update;
            chosenQestionEvent?.Invoke();
            QuestionsListBox.Items.Clear();
            foreach (var c in this.questionsText)
            {
                if (c.Length > 70)
                {
                    QuestionsListBox.Items.Add(c.Substring(0, 70) + "...");
                }
                else
                    QuestionsListBox.Items.Add(c);
            }
        }
    }
}
