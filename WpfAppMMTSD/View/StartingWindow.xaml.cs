using System.Windows;
using System.Windows.Input;

namespace WpfAppMMTSD.View
{
    /// <summary>
    /// Interaction logic for StartingWindow.xaml
    /// </summary>
    public partial class StartingWindow : Window
    {
        public StartingWindow()
        {
            //DbInitializer initializer = new DbInitializer();
            //initializer.Initialize();
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
            AdminPanelWindow window = new AdminPanelWindow();
            window.Show();
        }
    }
}
