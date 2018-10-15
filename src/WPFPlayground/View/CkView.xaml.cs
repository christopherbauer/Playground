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
using WPFPlayground.ViewModel;

namespace WPFPlayground.View
{
    /// <summary>
    /// Interaction logic for CkView.xaml
    /// </summary>
    public partial class CkView : Window
    {
        public CkView()
        {
            InitializeComponent();
            DataContext = new CkViewModel();
        }
    }
}
