using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DockMenuPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> imageList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            imageList = new List<string>();

            //string[] files = Directory.GetFiles("E:\\Lib\\Demo\\Welcome\\DockMenuPro\\DockMenuPro\\Asset\\images");
            //foreach (var file in files)
            //{
            //    if(System.IO.Path.GetExtension(file).Equals(".png",StringComparison.OrdinalIgnoreCase))
            //    {
            //        imageList.Add(file);
            //    }
            //}
            
        }

        private void Popup_Opened(object sender, EventArgs e)
        {
            var popup = (Popup)sender;
            Dispatcher.BeginInvoke(new Action(() =>
            {
                double offset = (((Button)popup.Parent).ActualWidth - popup.Child.RenderSize.Width) / 2;
                popup.HorizontalOffset = offset;
            }), System.Windows.Threading.DispatcherPriority.Render);
        }

    }
}