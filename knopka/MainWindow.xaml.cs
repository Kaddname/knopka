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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace knopka
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = new Button();
            button.Content = "Новая кнопка";
            button.Width = 100;
            button.Height = 30;
            Canvas.SetLeft(button, e.GetPosition(this).X);
            Canvas.SetTop(button, e.GetPosition(this).Y);

            canvas.Children.Add(button);

        }
    }
}
