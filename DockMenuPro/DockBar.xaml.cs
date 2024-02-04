using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// DockBar.xaml 的交互逻辑
    /// </summary>
    public partial class DockBar : UserControl
    {
        public DockBar()
        {
            InitializeComponent();
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
        public List<string> ImageList
        {
            get { return (List<string>)GetValue(ImageListProperty); }
            set { SetValue(ImageListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageListProperty =
            DependencyProperty.Register("ImageList", typeof(List<string>), typeof(DockBar), new PropertyMetadata(new List<string>(), new PropertyChangedCallback(OnImageListChanged)));

        private static void OnImageListChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DockBar dockBar)
            {
                for (int i = 0; i < dockBar.ImageList.Count; i++)
                {
                    ColumnDefinition columnDefinition = new ColumnDefinition()
                    {
                        Width = new GridLength(60)
                    };
                    dockBar.DockGrid.ColumnDefinitions.Add(columnDefinition);
                }

                for (int i = 0; i < dockBar.ImageList.Count; i++)
                {
                    Button button = new Button()
                    {
                        Style = dockBar.FindResource("DockBar.ButtonStyle") as Style,
                        Tag = dockBar.ImageList[i],
                        Background = new ImageBrush(new BitmapImage(new Uri(dockBar.ImageList[i], UriKind.Relative)))
                        {
                            Stretch = Stretch.Uniform
                        }
                    };

                    TextBlock textBlock = new TextBlock()
                    {
                        Style = dockBar.FindResource("DockBar.Button.Popup.TextBlockStyle") as Style
                    };

                    string[] strs= dockBar.ImageList[i].Split('\\');
                    textBlock.Text = strs[strs.Length - 1].Replace(".png","");

                    Border border = new Border()
                    {
                        Style = dockBar.FindResource("DockBar.Button.Popup.BorderStyle") as Style
                    };

                    border.Child = textBlock;

                    Path path = new Path()
                    {
                        Style = dockBar.FindResource("DockBar.Button.Popup.PathStyle") as Style
                    };

                    Grid grid = new Grid();
                    grid.Children.Add(border);
                    grid.Children.Add(path);

                    Popup popup = new Popup()
                    {
                        Style= dockBar.FindResource("DockBar.Button.PopupStyle") as Style,
                    };

                    popup.Child = grid;
                    popup.PlacementTarget = button;

                    BindingOperations.SetBinding(popup, Popup.IsOpenProperty, new Binding("IsMouseOver")
                    {
                        Source = button,
                        Mode = BindingMode.OneWay
                    });

                    Grid.SetColumn(button, i);
                    dockBar.DockGrid.Children.Add(button);
                }
            }
        }
    }
}
