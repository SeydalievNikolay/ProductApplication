using System;
using System.Windows.Forms;

namespace ProductApp
{
    // Класс Toy (Игрушка), наследует от Product
    [Serializable]
    class Toy :Product
    {
        // Публичный конструктор без параметров
        public Toy() : base("", "", "", "", "") { }

        public Toy(string name, string material, string size, string description, string imagePath)
            : base(name, material, size, description, imagePath) { }

        public override void DisplayDetails()
        {
            MessageBox.Show($"Игрушка: {Name}, {Material}, {Size}, {Description}, Image Path: {ImagePath}");
        }
    }
}
