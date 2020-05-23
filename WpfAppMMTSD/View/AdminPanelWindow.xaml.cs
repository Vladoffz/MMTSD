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
using MMTSD.Entities;
using MMTSD.BLL.Abstract;
using MMTSD.BLL.Impl;
using MMTSD.Models;
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
            AnswerDTO[] answers = new AnswerDTO[]
            {
                new AnswerDTO{ Text = Answer1TextBox.Text, IsRight = (bool)Answer1RadioButton.IsChecked},
                new AnswerDTO{ Text = Answer2TextBox.Text, IsRight= (bool)Answer2RadioButton.IsChecked},
                new AnswerDTO{ Text = Answer3TextBox.Text, IsRight= (bool)Answer3RadioButton.IsChecked},
                new AnswerDTO{ Text = Answer4TextBox.Text, IsRight= (bool)Answer4RadioButton.IsChecked }
            };

            QuestionDTO question = new QuestionDTO{Category = category, Answers = answers, QuestionText = QuestionTextBox.Text};
            ((AdministrationViewModel) (DataContext)).AddQuestion(question);
        }
    }
}
