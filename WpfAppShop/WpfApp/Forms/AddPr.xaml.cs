using BLL;
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
using System.Windows.Shapes;

namespace WpfApp.Forms
{
    /// <summary>
    /// Логика взаимодействия для AddPr.xaml
    /// </summary>
    public partial class AddPr : Window
    {
        AddProduct add = new AddProduct();
        public AddPr()
        {
            InitializeComponent();
        }

        private void AddProd_Click(object sender, RoutedEventArgs e)
        {
            add.AddPr(Name.Text, Description.Text, Convert.ToDecimal(Price.Text));

            Close();
        }
    }
}
