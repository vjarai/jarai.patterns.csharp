using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for AdressView.xaml
    /// </summary>
    public partial class AdressView : Window
    {
        public AdressView()
        {
            InitializeComponent();
        }

        public AdressViewModel ViewModel
        {
            get { return (AdressViewModel)DataContext; }
        }

    }
}