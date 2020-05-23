using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlClient;
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
    /// Interaction logic for QuestionWindow.xaml
    /// </summary>
    public partial class QuestionWindow : Window
    {
        public QuestionWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
        }
        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            this.Owner.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var obsColl1 = ((ApplicationViewModel) DataContext).SelectedQuestionsInApplication as List<QuestionDTO>;
                var obsColl2 = ((ApplicationViewModel) DataContext).SelectedQuestionsCollection as ObservableCollection<QuestionDTO>;
                ((ApplicationViewModel) (DataContext)).CheckAllAnswers(AnswerListBox.SelectedItem.ToString());
                if (obsColl1.Count == obsColl2.Count)
                {
                    ResultWindow window = new ResultWindow((ApplicationViewModel) this.DataContext);
                    window.Owner = this;
                    window.Height = this.ActualHeight;
                    window.Width = this.ActualWidth;
                    window.Show();
                    this.Hide();
                    string str = "";
                    foreach (var i in ((ApplicationViewModel) (DataContext)).QuesAnsw.Values)
                    {
                        str += i.Text;
                    }
                }
                else
                {
                    ((ApplicationViewModel) (DataContext)).MoveNext();
                }
            }
            catch
            {
                MessageBox.Show("You haven't chosen the answer!");
            }
        }

        private void QuestionListBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((ApplicationViewModel)(DataContext)).GetAnswers(QuestionListBox.SelectedItem.ToString());
        }
    }
}
