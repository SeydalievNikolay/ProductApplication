using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace ProductApp
    {
    public partial class MainForm : Form
    {
     
        private ProductCollection productsCollection = new ProductCollection(); 
        private BindingSource bindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик события загрузки формы
        // Загружает все продукты из коллекции и устанавливает их в DataGridView
        private void MainForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = productsCollection.GetAllProducts();
            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns["Name"].HeaderText = "Наименование";
            dataGridView1.Columns["Material"].HeaderText = "Материал";
            dataGridView1.Columns["Size"].HeaderText = "Размер";
            dataGridView1.Columns["Description"].HeaderText = "Описание";
            dataGridView1.Columns["ImagePath"].HeaderText = "Путь к изображению";
        }

        // Открывает форму для добавления нового продукта и добавляет его в коллекцию
        private void AddProduct()
        {
            ProductAddForm addForm = new ProductAddForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Product newProduct = null;

                if (addForm.SelectedProductType == Department.Clothing)
                {
                    newProduct = new Clothing(
                        addForm.ProductName,
                        addForm.ProductMaterial,
                        addForm.ProductSize,
                        addForm.ProductDescription,
                        addForm.ProductImagePath);
                }
                else if (addForm.SelectedProductType == Department.Toy)
                {
                    newProduct = new Toy(
                        addForm.ProductName,
                        addForm.ProductMaterial,
                        addForm.ProductSize,
                        addForm.ProductDescription,
                        addForm.ProductImagePath);
                }

                if (newProduct != null)
                {
                    productsCollection.AddProduct(newProduct);
                    bindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Не выбран корректный тип продукта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Открывает форму для редактирования выбранного продукта
        private void EditProduct()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукт для редактирования.");
                return;
            }

            var selectedProduct = (Product)bindingSource.Current;

            if (selectedProduct == null)
            {
                MessageBox.Show("Не удалось получить выбранный продукт.");
                return;
            }

            using (ProductEditForm editForm = new ProductEditForm(selectedProduct))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    bindingSource.ResetBindings(false);
                }
            }
        }

        // Удаляет выбранный продукт из коллекции
        private void DeleteProduct()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукт для удаления.");
                return;
            }

            var selectedProduct = (Product)bindingSource.Current;

            if (selectedProduct != null)
            {
                var result = MessageBox.Show($"Вы уверены, что хотите удалить {selectedProduct.Name}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    productsCollection.RemoveProduct(selectedProduct); // Удаляем продукт из коллекции
                    bindingSource.ResetBindings(false);
                }
            }
        }

        // Сериализует коллекцию продуктов в файл JSON
        private void SerializeProducts()
        {
            try
            {
                using (FileStream fs = new FileStream("products.json", FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, productsCollection.GetAllProducts());
                }

                MessageBox.Show("Сериализация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сериализации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Десериализует коллекцию продуктов из файла JSON
        private void DeserializeProducts()
        {
            try
            {
                using (FileStream fs = new FileStream("products.json", FileMode.Open))
                {
                    var products = JsonSerializer.Deserialize<List<Product>>(fs);
                    productsCollection = new ProductCollection();
                    foreach (var product in products)
                    {
                        productsCollection.AddProduct(product); // Восстанавливаем коллекцию
                    }
                    bindingSource.DataSource = productsCollection.GetAllProducts();
                    bindingSource.ResetBindings(false);
                }

                MessageBox.Show("Десериализация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при десериализации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Закрывает приложение
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Открывает форму для добавления нового продукта
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        // Открывает форму для редактирования выбранного продукта
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        // Удаляет выбранный продукт
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        // Сериализует продукты в файл
        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializeProducts();
        }

        // Десериализует продукты из файла
        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeserializeProducts();
        }

        // Отображает подробную информацию о выбранном продукте
        private void viewToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукт для просмотра.");
                return;
            }

            var selectedProduct = (Product)bindingSource.Current;

            if (selectedProduct != null)
            {
                selectedProduct.DisplayDetails();
            }
        }

        // Показать справку о программе
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа учета товара в магазине.\n\n" +
                            "Позволяет:\n\n" +
                            " - Добавлять\n" +
                            " - Просматривать\n" +
                            " - Удалять\n" +
                            " - Редактировать\n" +
                            " - Сериализовывать\n" +
                            " - Десериализовывать", "Справка");
        }
    }

}

