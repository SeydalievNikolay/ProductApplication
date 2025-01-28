using System.Windows.Forms;

namespace ProductApp
{
    // Интерфейс для операций с продуктами
    interface ProductOperations
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        Product FindProductByName(string name);
        void EditProduct(Product oldProduct, Product newProduct);
        void SaveToFile(string fileName);
        void LoadFromFile(string fileName);
        void DisplayAllProducts();
    }
}
