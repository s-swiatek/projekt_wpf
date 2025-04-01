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

namespace projekt_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //class MyItem
        //{
        //    public string Imie { get; set; }
        //    public string Nazw { get; set; }
        //    public string PESEL { get; set; }

        //}
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            //MyItem item = new MyItem();
            //item.Imie = ;
            //item.Nazw = "Świątek";
            //item.PESEL = "123456789011";
            //ListView.Items.Add(item);
            var rnd = new Random();
            ListView.Items.Add(new { m_nID = rnd.Next(), m_strImie = "Sebastian"});
        }
    }
}