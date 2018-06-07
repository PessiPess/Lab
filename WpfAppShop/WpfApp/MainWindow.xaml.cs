//using DAL.EF;
using BLL;
using DAL.Domain;
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
using WpfApp.Forms;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        ShowShopItem showShopItem = new ShowShopItem();
        ShowShop showShop = new ShowShop();
        ShowProducts showProducts = new ShowProducts();
        AddShopItem addShopItem = new AddShopItem();
        AddProduct addProduct = new AddProduct();
        DeleteProduct delProduct = new DeleteProduct();

        public MainWindow()
        {
            InitializeComponent();
            productGrid.ItemsSource = showProducts.Show().ToList();

            shopGrid.ItemsSource = showShop.Show().ToList();

            comboShop.ItemsSource = showShop.Show().ToList();
            productShopGrid.ItemsSource = showProducts.Show().ToList();
            comboShop.DisplayMemberPath = "Name";
        }

        private void updateButtonProduct_Click(object sender, RoutedEventArgs e)
        {
            AddPr pr = new AddPr();
            pr.ShowDialog();

            productGrid.ItemsSource = showProducts.Show().ToList();
        }

        private void deleteButtonProduct_Click(object sender, RoutedEventArgs e)
        {
            if (productGrid.SelectedItems[0] is Product product )
            {
                delProduct.Delete(product.Id);
                productGrid.ItemsSource = showProducts.Show().ToList();
                productShopGrid.ItemsSource = showProducts.Show().ToList();
            }
        }

        private void updateButtonShop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteButtonShop_Click(object sender, RoutedEventArgs e)
        {

        }

        private void plusProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(prodCount.Text);
                if (productShopGrid.SelectedItems[0] is Product product && comboShop.SelectedItem is Shop shop)
                {
                    addShopItem.AddShpItem(product.Id, shop.Id, c);
                    productItemsGrid.ItemsSource = showShopItem.Show(shop);
                }               


            }
            catch (Exception)
            {
                MessageBox.Show("Введено некоректное число", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void minusProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(prodCount.Text);
                if (productShopGrid.SelectedItems[0] is Product product && comboShop.SelectedItem is Shop shop)
                {
                    addShopItem.AddShpItem(product.Id, shop.Id, c*-1);
                    productItemsGrid.ItemsSource = showShopItem.Show(shop);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Введено некоректное число", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void comboShop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboShop.SelectedItem is Shop shop)
            {
                productItemsGrid.ItemsSource = showShopItem.Show(shop);
                
            }
           
        }
    }
}
