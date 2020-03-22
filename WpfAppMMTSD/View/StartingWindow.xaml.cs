using System;
using System.Collections.Generic;
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

namespace WpfAppMMTSD.View
{
    /// <summary>
    /// Interaction logic for StartingWindow.xaml
    /// </summary>
    public partial class StartingWindow : Window
    {
        public StartingWindow()
        {
            InitializeComponent();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            QuestionWindow window = new QuestionWindow();
            window.Owner = this;
            window.Height = this.ActualHeight;
            window.Width = this.ActualWidth;
            window.Show();
            this.Hide();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("not ready");
        }
    }
}
