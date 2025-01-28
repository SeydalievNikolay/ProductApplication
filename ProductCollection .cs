using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;



namespace ProductApp
{
    class ProductCollection : ProductOperations
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if (!_products.Remove(product))
            {
                throw new InvalidOperationException("Товар не найден в коллекции.");
            }
        }

        public Product FindProductByName(string name)
        {
            var product = _products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (product == null)
            {
                Console.WriteLine("Продукт не найден.");
            }
            return product;
        }

        public void EditProduct(Product oldProduct, Product newProduct)
        {
            int index = _products.IndexOf(oldProduct);
            if (index != -1)
            {
                _products[index] = newProduct;
                Console.WriteLine("Товар отредактирован.");
            }
            else
            {
                Console.WriteLine("Товар не найден для редактирования.");
            }
        }

        public void DisplayAllProducts()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("Коллекция товаров пуста.");
                return;
            }

            foreach (var product in _products)
            {
                product.DisplayDetails();
            }
        }

        // Сохранение всех продуктов в файл
        public void SaveToFile(string fileName)
        {
            try
            {
                // Сериализация с использованием JSON вместо BinaryFormatter
                string jsonString = JsonSerializer.Serialize(_products);
                File.WriteAllText(fileName, jsonString);
                Console.WriteLine("Сериализация завершена.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сериализации: {ex.Message}");
            }
        }

        // Загрузка всех продуктов из файла
        public void LoadFromFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    _products = JsonSerializer.Deserialize<List<Product>>(jsonString);
                    Console.WriteLine("Десериализация завершена.");
                }
                else
                {
                    Console.WriteLine("Файл не найден.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при десериализации: {ex.Message}");
            }
        }

        // Получить все продукты
        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
