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

namespace GitTaak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void pxlImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Black);
        }

        private void pxlImage_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void roodImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void roodImage_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void geelImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void geelImage_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void groenImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);
        }

        private void groenImage_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void blauwImage_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private void blauwImage_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void roodImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            colorTextBox.Text = "#FF0000";
            informatieTextBox.Text = "Rood is de kleur van warmte";
        }

        private void geelImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            colorTextBox.Text = "#FFFF00";
            informatieTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void groenImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            colorTextBox.Text = "#008000";
            informatieTextBox.Text = "Groen is de kleur van genezing";
        }

        private void blauwImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            colorTextBox.Text = "#0000FF";
            informatieTextBox.Text = "Blauw is de kleur van intelligentie";
        }

        private void pxlImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            colorTextBox.Text = "#000000";
            informatieTextBox.Text = "Zwart is de kleur van easter eggs";
        }
    }
}