using System.Collections.ObjectModel;
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

namespace IComparer_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<FileData> _files;
        public ObservableCollection<FileData> Files
        {
            get { return _files; }
            set => _files = value;
        }

        public MainWindow()
        {
            InitializeComponent();

            
        }

        //Sort by alphabetical
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var temp = Files.OrderBy(x => x.Size);
            FileTree.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Header", System.ComponentModel.ListSortDirection.Ascending));
            FileTree.Items.Refresh();
        }
    }


    public class FileData : IComparable<FileData>
    {
        public FileData()
        {
            Size = 0;
            Header = "N/A";
        }

        public int Size;
        public string Header;

        public int CompareTo(FileData? other)
        {
            return other.CompareTo(this);
        }
    }
}