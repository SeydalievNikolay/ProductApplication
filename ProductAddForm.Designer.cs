using System;
using System.Windows.Forms;
partial class ProductAddForm : Form
{
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private TextBox nameTextBox;
    private TextBox sizeTextBox;
    private TextBox descriptionTextBox;
    private Button saveButton;
    private Button cancelButton;
    private Label nameLabel;
    private Label materialLabel;
    private Label sizeLabel;
    private Label descriptionLabel;
    private RadioButton clothingButton;
    private RadioButton toyButton;
    /// <summary>
    /// Очистка всех используемых ресурсов.
    /// </summary>
    /// <param name="disposing">Истинно, если управляемые ресурсы должны быть удалены; иначе — ложь.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором

        private void InitializeComponent()
    {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.clothingButton = new System.Windows.Forms.RadioButton();
            this.toyButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(226, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(120, 185);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(150, 26);
            this.sizeTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(120, 237);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(150, 26);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(239, 322);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 30);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(387, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 30);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(21, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(184, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Наименование товара:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(21, 191);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(69, 20);
            this.sizeLabel.TabIndex = 6;
            this.sizeLabel.Text = "Размер:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(21, 237);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(87, 20);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Описание:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(21, 138);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(148, 20);
            this.materialLabel.TabIndex = 8;
            this.materialLabel.Text = "Материал товара:";
            // 
            // clothingButton
            // 
            this.clothingButton.AutoSize = true;
            this.clothingButton.Location = new System.Drawing.Point(173, 136);
            this.clothingButton.Name = "clothingButton";
            this.clothingButton.Size = new System.Drawing.Size(97, 24);
            this.clothingButton.TabIndex = 9;
            this.clothingButton.TabStop = true;
            this.clothingButton.Text = "Одежда";
            this.clothingButton.UseVisualStyleBackColor = true;
            this.clothingButton.CheckedChanged += new System.EventHandler(this.clothingButton_CheckedChanged);
            // 
            // toyButton
            // 
            this.toyButton.AutoSize = true;
            this.toyButton.Location = new System.Drawing.Point(278, 138);
            this.toyButton.Name = "toyButton";
            this.toyButton.Size = new System.Drawing.Size(98, 24);
            this.toyButton.TabIndex = 10;
            this.toyButton.TabStop = true;
            this.toyButton.Text = "Игрушки";
            this.toyButton.UseVisualStyleBackColor = true;
            this.toyButton.CheckedChanged += new System.EventHandler(this.toyButton_CheckedChanged);
            
            // ProductAddForm
            // 
            this.ClientSize = new System.Drawing.Size(549, 391);
            this.Controls.Add(this.toyButton);
            this.Controls.Add(this.clothingButton);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ProductAddForm";
            this.Text = "Добавление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
}