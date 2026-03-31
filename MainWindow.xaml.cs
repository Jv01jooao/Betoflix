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
using Netflix.MVVM;

namespace Netflix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void moviserie_Loaded(object sender, RoutedEventArgs e)
        {
            // Lógica desejada ao carregar cada moviserie (sender é o UserControl moviserie)
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            Searchfundo.Visibility = Visibility.Visible;
        }

        private void Home_MouseEnter(object sender, MouseEventArgs e)
        {
            Homefundo.Visibility = Visibility.Visible;
        }

        private void TextBlock_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Showfundo.Visibility = Visibility.Visible;
        }

        private void TextBlock_MouseEnter_2(object sender, MouseEventArgs e)
        {
            Moviesfundo.Visibility = Visibility.Visible;
        }

        private void TextBlock_MouseEnter_3(object sender, MouseEventArgs e)
        {
            MyNetflixfundo.Visibility = Visibility.Visible;
        }

        private void Search_MouseLeave(object sender, MouseEventArgs e)
        {
            Searchfundo.Visibility = Visibility.Collapsed;
        }

        private void Home_MouseLeave(object sender, MouseEventArgs e)
        {
            Homefundo.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            Showfundo.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_MouseLeave_1(object sender, MouseEventArgs e)
        {
            Moviesfundo.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_MouseLeave_2(object sender, MouseEventArgs e)
        {
            MyNetflixfundo.Visibility = Visibility.Collapsed;
        }

        private void Home_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GridSearch.Visibility = Visibility.Collapsed;
        }

        private void Search_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GridSearch.Visibility = Visibility.Visible;
        }

        public void verifySearch()
        {
            if (SearchTextbox.Text != string.Empty)
            {
                quadradSearch.Visibility = Visibility.Visible;
            }else if(SearchTextbox.Text == String.Empty)
            {
                quadradSearch.Visibility = Visibility.Collapsed;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            verifySearch();
        }
    }
}