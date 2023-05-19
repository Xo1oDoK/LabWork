using LabaratorWork.ViewModel;
using System.Windows;


namespace LabaratorWork.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static System.Windows.Controls.ListView AllProductsView;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllProductsView = ViewAllProducts;
        }
    }
}
