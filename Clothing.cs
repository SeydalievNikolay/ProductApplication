using System;
using System.Windows.Forms;

namespace ProductApp
{
    // Класс Clothing (Одежда), наследует от Product
    [Serializable]
    class Clothing:Product
    {

        // Публичный конструктор без параметров
        public Clothing() : base("", "", "", "", "") { }

        public Clothing(string name, string material, string size, string description, string imagePath)
            : base(name, material, size, description, imagePath) { }

        public override void DisplayDetails()
        {
            MessageBox.Show($"Одежда: {Name}, {Material}, {Size}, {Description}, Image Path: {ImagePath}");
        }
    }
}
