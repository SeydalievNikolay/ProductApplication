using System;

namespace ProductApp
{
    // Абстрактный класс Product (Товар)
    [Serializable]
    public abstract class Product
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        // Публичный конструктор без параметров
        protected Product() { }

        public Product(string name, string material, string size, string description, string imagePath)
        {
            Name = name;
            Material = material;
            Size = size;
            Description = description;
            ImagePath = imagePath;
        }

        public abstract void DisplayDetails();
    }
}
