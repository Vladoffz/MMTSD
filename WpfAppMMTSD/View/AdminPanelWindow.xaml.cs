using MMTSD.Entities;
using MMTSD.Models;
using System.Windows;
using WpfAppMMTSD.ViewModel;

namespace WpfAppMMTSD.View
{
    /// <summary>
    /// Interaction logic for AdminPanelWindow.xaml
    /// </summary>
    public partial class AdminPanelWindow : Window
    {
        public AdminPanelWindow()
        {
            InitializeComponent();
            DataContext = new AdministrationViewModel();
            foreach (var i in ((AdministrationViewModel)(DataContext)).difficulties)
            {
                Difficulties.Items.Add(i);
            }
        }

        private void SerializationButton_OnClick(object sender, RoutedEventArgs e)
        {
            QuestionCategory category = (QuestionCategory)Difficulties.SelectedItem;
            AnswerDTO[] answers = new AnswerDTO[]
            {
                new AnswerDTO{ Text = Answer1TextBox.Text, IsRight = (bool)Answer1RadioButton.IsChecked},
                new AnswerDTO{ Text = Answer2TextBox.Text, IsRight= (bool)Answer2RadioButton.IsChecked},
                new AnswerDTO{ Text = Answer3TextBox.Text, IsRight= (bool)Answer3RadioButton.IsChecked},
                new AnswerDTO{ Text = Answer4TextBox.Text, IsRight= (bool)Answer4RadioButton.IsChecked }
            };

            QuestionDTO question = new QuestionDTO { Category = category, Answers = answers, QuestionText = QuestionTextBox.Text };
            ((AdministrationViewModel)(DataContext)).AddQuestion(question);
        }
    }
}
