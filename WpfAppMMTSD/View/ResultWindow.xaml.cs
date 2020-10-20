using System.ComponentModel;
using System.Windows;
using WpfAppMMTSD.ViewModel;

namespace WpfAppMMTSD.View
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public ApplicationViewModel vm;
        public ResultWindow()
        {
            InitializeComponent();
        }

        public ResultWindow(ApplicationViewModel vm) : this()
        {
            this.vm = vm;
            int result = 0;
            foreach (var i in vm.QuesAnsw.Values)
            {
                if (i.IsRight) result++;
            }

            ResultText.Text = $"{result}/{vm.QuesAnsw.Values.Count}";
        }
        private void ResultWindow_OnClosing(object sender, CancelEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
