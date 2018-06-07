using System;
using BLL;
using DAL.Domain;
using DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddPrTest_input_name_descr_price_output_true()
        {

            // Arrange
            string name = "Гиря(18кг)";
            string description = "Гиря...";
            decimal price = 300;
            var products = new AddProduct();
            var repo = new Mock<ProductRepository>();
            repo.Setup(arg => arg.Create(It.IsAny<Product>()));
            repo.Setup(arg => arg.Save());
            products.product = repo.Object;

            // Act
            var result = products.AddPr(name, description, price);

            // Assert
            Assert.IsTrue(result);
            repo.Verify(arg => arg.Create(It.IsAny<Product>()), Times.Once());
            repo.Verify(arg => arg.Save(), Times.Once());

        }


        [TestMethod]
        public void AddShopTest_input_name_address_output_true()
        {

            // Arrange
            string name = "Шоп 1";
            string address = "м.Тернопіль";
            var shops = new AddShop();
            var repo = new Mock<ShopRepository>();
            repo.Setup(arg => arg.Create(It.IsAny<Shop>()));
            repo.Setup(arg => arg.Save());
            shops.shop = repo.Object;

            // Act
            var result = shops.AddShp(name, address);

            // Assert
            Assert.IsTrue(result);
            repo.Verify(arg => arg.Create(It.IsAny<Shop>()), Times.Once());
            repo.Verify(arg => arg.Save(), Times.Once());

        }


        [TestMethod]
        public void AddShopItemTest_input_productId_shopId_count_output_true()
        {

            // Arrange
            int productId = 1;
            int shopId = 2;
            int count = 5;
            var shopItems = new AddShopItem();
            var repo = new Mock<ShopItemRepository>();
            repo.Setup(arg => arg.Create(It.IsAny<ShopItem>()));
            repo.Setup(arg => arg.Save());
            shopItems.db = repo.Object;

            // Act
            var result = shopItems.AddShpItem(productId, shopId, count);

            // Assert
            Assert.IsTrue(result);
            repo.Verify(arg => arg.Create(It.IsAny<ShopItem>()), Times.Once());
            repo.Verify(arg => arg.Save(), Times.Once());

        }
    }
}
