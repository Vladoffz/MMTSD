using System;
using System.Collections.Generic;
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

        public ResultWindow(ApplicationViewModel vm):this()
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
