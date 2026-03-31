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

namespace Netflix.View.moviserie
{
    /// <summary>
    /// Interação lógica para moviserie.xam
    /// </summary>
    public partial class moviserie : UserControl
    {
        public moviserie()
        {
            InitializeComponent();
        }

        private void quadrado_MouseLeave(object sender, MouseEventArgs e)
        {
            quadrado.Width = 100;
            quadrado.Margin = new Thickness(0, 0, 0, 0);
        }

        private void quadrado_MouseEnter(object sender, MouseEventArgs e)
        {
            quadrado.Width = 250;
            
        }
    }
}
