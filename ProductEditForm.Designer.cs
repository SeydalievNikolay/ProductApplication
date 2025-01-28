using System;
using System.Windows.Forms;

 partial class ProductEditForm : Form
    {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.TextBox sizeTextBox;
    private System.Windows.Forms.TextBox descriptionTextBox;
    private System.Windows.Forms.TextBox imagePathTextBox;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button loadImageButton;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.Label sizeLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private System.Windows.Forms.Label materialLabel;
    private System.Windows.Forms.Label imagePathLabel;
    private System.Windows.Forms.RadioButton clothingButton;
    private System.Windows.Forms.RadioButton toyButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    private void InitializeComponent()
    {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.clothingButton = new System.Windows.Forms.RadioButton();
            this.toyButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();

        // Реализация nameTextBox
        this.nameTextBox.Location = new System.Drawing.Point(153, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(178, 26);
            this.nameTextBox.TabIndex = 0;

        // Реализация sizeTextBox
        this.sizeTextBox.Location = new System.Drawing.Point(153, 40);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(178, 26);
            this.sizeTextBox.TabIndex = 1;

        // Реализация descriptionTextBox
        this.descriptionTextBox.Location = new System.Drawing.Point(153, 68);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(178, 26);
            this.descriptionTextBox.TabIndex = 2;

        // Реализация imagePathTextBox
        this.imagePathTextBox.Location = new System.Drawing.Point(189, 130);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.ReadOnly = true;
            this.imagePathTextBox.Size = new System.Drawing.Size(142, 26);
            this.imagePathTextBox.TabIndex = 3;

        // Реализация saveButton
        this.saveButton.Location = new System.Drawing.Point(120, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 43);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

        // Реализация cancelButton
        this.cancelButton.Location = new System.Drawing.Point(229, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 43);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

        // Реализация loadImageButton
        this.loadImageButton.Location = new System.Drawing.Point(153, 162);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(150, 36);
            this.loadImageButton.TabIndex = 6;
            this.loadImageButton.Text = "Загрузить изображение";
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
        // Реализация nameLabel
        this.nameLabel.Location = new System.Drawing.Point(12, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(135, 25);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Наименование:";
        // Реализация sizeLabel 
        this.sizeLabel.Location = new System.Drawing.Point(12, 40);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(100, 23);
            this.sizeLabel.TabIndex = 8;
            this.sizeLabel.Text = "Размер:";

        // Реализация descriptionLabel
        this.descriptionLabel.Location = new System.Drawing.Point(12, 68);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 23);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Описание:";

        // Реализация materialLabel
        this.materialLabel.Location = new System.Drawing.Point(12, 100);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(100, 23);
            this.materialLabel.TabIndex = 10;
            this.materialLabel.Text = "Материал:";

        // Реализация imagePathLabel
        this.imagePathLabel.Location = new System.Drawing.Point(12, 130);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(171, 26);
            this.imagePathLabel.TabIndex = 11;
            this.imagePathLabel.Text = "Путь к изображению:";

        // Реализация clothingButton
        this.clothingButton.Location = new System.Drawing.Point(120, 100);
            this.clothingButton.Name = "clothingButton";
            this.clothingButton.Size = new System.Drawing.Size(104, 24);
            this.clothingButton.TabIndex = 12;
            this.clothingButton.Text = "Одежда";
            this.clothingButton.CheckedChanged += new System.EventHandler(this.clothingButton_CheckedChanged);

        // Реализация toyButton
        this.toyButton.Location = new System.Drawing.Point(227, 100);
            this.toyButton.Name = "toyButton";
            this.toyButton.Size = new System.Drawing.Size(104, 24);
            this.toyButton.TabIndex = 13;
            this.toyButton.Text = "Игрушка";
            this.toyButton.CheckedChanged += new System.EventHandler(this.toyButton_CheckedChanged);

            // Реализация ProductEditForm
            this.ClientSize = new System.Drawing.Size(343, 281);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.imagePathLabel);
            this.Controls.Add(this.clothingButton);
            this.Controls.Add(this.toyButton);
            this.Name = "ProductEditForm";
            this.Text = "Редактирование товара";
            this.Load += new System.EventHandler(this.ProductEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
    }
}
