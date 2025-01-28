using ProductApp;
using System;
using System.Windows.Forms;

    public partial class ProductEditForm : Form
    {
    private Product productToEdit;

    // Конструктор, принимающий объект продукта для редактирования
    public ProductEditForm(Product product)
    {
        InitializeComponent();
        productToEdit = product; // Сохраняем продукт для редактирования

        // Отображаем текущие данные в полях
        nameTextBox.Text = productToEdit.Name;
        sizeTextBox.Text = productToEdit.Size;
        descriptionTextBox.Text = productToEdit.Description;

        // Устанавливаем радиокнопки в зависимости от материала
        if (productToEdit.Material == "Одежда")
        {
            clothingButton.Checked = true;
        }
        else if (productToEdit.Material == "Игрушка")
        {
            toyButton.Checked = true;
        }

        // Путь к изображению отображается в текстовом поле
        imagePathTextBox.Text = productToEdit.ImagePath;
    }

    // Обработчик кнопки "Сохранить"
    private void saveButton_Click(object sender, EventArgs e)
    {
        // Проверка на заполнение обязательных полей
        if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(sizeTextBox.Text) || string.IsNullOrEmpty(descriptionTextBox.Text))
        {
            MessageBox.Show("Все поля должны быть заполнены.");
            return;
        }

        // Присваиваем новые значения продукту
        productToEdit.Name = nameTextBox.Text;
        productToEdit.Size = sizeTextBox.Text;
        productToEdit.Description = descriptionTextBox.Text;
        productToEdit.ImagePath = imagePathTextBox.Text;

        // Присваиваем материал в зависимости от выбранной радиокнопки
        if (clothingButton.Checked)
            productToEdit.Material = "Одежда";
        else if (toyButton.Checked)
            productToEdit.Material = "Игрушка";

        // Подтверждение сохранения данных
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    // Обработчик кнопки "Отменить"
    private void cancelButton_Click(object sender, EventArgs e)
    {
        // Закрытие формы без сохранения изменений
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    // Обработчик загрузки изображения
    private void loadImageButton_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePathTextBox.Text = openFileDialog.FileName; // Путь к изображению выводится в поле
            }
        }
    }

    // Обработчик выбора радиокнопки "Одежда"
    private void clothingButton_CheckedChanged(object sender, EventArgs e)
    {
        if (clothingButton.Checked)
        {
            productToEdit.Material = "Одежда"; // Устанавливаем материал как "Одежда"
        }
    }

    // Обработчик выбора радиокнопки "Игрушка"
    private void toyButton_CheckedChanged(object sender, EventArgs e)
    {
        if (toyButton.Checked)
        {
            productToEdit.Material = "Игрушка"; // Устанавливаем материал как "Игрушка"
        }
    }

    private void ProductEditForm_Load(object sender, EventArgs e)
    {

    }
}
