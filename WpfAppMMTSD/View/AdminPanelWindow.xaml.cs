using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppMMTSD.Model;
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
            foreach (var i in ((AdministrationViewModel) (DataContext)).difficulties)
            {
                Difficulties.Items.Add(i);
            }
        }

        private void SerializationButton_OnClick(object sender, RoutedEventArgs e)
        {
            QuestionCategory category = (QuestionCategory)Difficulties.SelectedItem;
            Answer[] answers = new Answer[]
            {
                new Answer(Answer1TextBox.Text, (bool)Answer1RadioButton.IsChecked),
                new Answer(Answer2TextBox.Text, (bool)Answer2RadioButton.IsChecked),
                new Answer(Answer3TextBox.Text, (bool)Answer3RadioButton.IsChecked),
                new Answer(Answer4TextBox.Text, (bool)Answer4RadioButton.IsChecked)
            };

            Question question = new Question(category, answers, QuestionTextBox.Text);
            ((AdministrationViewModel) (DataContext)).AddQuestion(question);
        }
    }
}
