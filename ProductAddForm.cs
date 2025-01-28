using ProductApp;
using System;
using System.IO;
using System.Windows.Forms;

public partial class ProductAddForm : Form
{
    public string ProductName { get; private set; }
    public string ProductMaterial { get; private set; }
    public string ProductSize { get; private set; }
    public string ProductDescription { get; private set; }
    public string ProductImagePath { get; private set; }

    private Product _productToEdit;
    public Department SelectedProductType { get; private set; }

    // Конструктор формы для добавления или редактирования товара
    public ProductAddForm(Product productToEdit = null)
    {
        InitializeComponent();
        InitializeAdditionalComponents();
        SelectedProductType = Department.Clothing;
        SelectedProductType = Department.Toy;

        if (productToEdit != null)
        {
            _productToEdit = productToEdit;
            nameTextBox.Text = _productToEdit.Name;
            sizeTextBox.Text = _productToEdit.Size;
            descriptionTextBox.Text = _productToEdit.Description;
            ProductImagePath = _productToEdit.ImagePath;

            if (_productToEdit.Material == "Одежда")
                clothingButton.Checked = true;
            else if (_productToEdit.Material == "Игрушка")
                toyButton.Checked = true;
        }
    }
    // Реализация кнопки для загрузки изображения
    private void InitializeAdditionalComponents()
    {
        Button loadImageButton = new Button
        {
            Text = "Загрузить изображение",
            Location = new System.Drawing.Point(120, 150),
            Width = 200
        };
        loadImageButton.Click += LoadImageButton_Click;

        this.Controls.Add(loadImageButton); }



    // Обработчик нажатия на кнопку загрузки изображения
    private void LoadImageButton_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                string destinationDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                string destinationFilePath = Path.Combine(destinationDirectory, Path.GetFileName(sourceFilePath));

                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                File.Copy(sourceFilePath, destinationFilePath, true);
                MessageBox.Show("Изображение загружено успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ProductImagePath = destinationFilePath;
            }
        }
    }

    // Обработчик нажатия на кнопку "Сохранить"
    private void saveButton_Click(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(sizeTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text))
        {
            MessageBox.Show("Все поля должны быть заполнены.");
            return;
        }

        if (!clothingButton.Checked && !toyButton.Checked)
        {
            MessageBox.Show("Необходимо выбрать материал.");
            return;
        }

        ProductName = nameTextBox.Text;
        ProductSize = sizeTextBox.Text;
        ProductDescription = descriptionTextBox.Text;

        ProductMaterial = clothingButton.Checked ? "Одежда" : "Игрушка";

        var result = MessageBox.Show("Вы уверены, что хотите сохранить этот товар?",
                                      "Подтверждение сохранения",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            if (_productToEdit != null)
            {
                _productToEdit.Name = ProductName;
                _productToEdit.Size = ProductSize;
                _productToEdit.Description = ProductDescription;
                _productToEdit.Material = ProductMaterial;
                _productToEdit.ImagePath = ProductImagePath;
            }
            else
            {
                _productToEdit = new Clothing(ProductName, ProductMaterial, ProductSize, ProductDescription, ProductImagePath);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    // Обработчик нажатия на кнопку "Отменить"
    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    // Обработчик для изменения состояния радиокнопки "Одежда"
    private void clothingButton_CheckedChanged(object sender, EventArgs e)
    {
        if (clothingButton.Checked)
            ProductMaterial = "Одежда";
    }

    // Обработчик для изменения состояния радиокнопки "Игрушка"
    private void toyButton_CheckedChanged(object sender, EventArgs e)
    {
        if (toyButton.Checked)
            ProductMaterial = "Игрушки";
    }
}

