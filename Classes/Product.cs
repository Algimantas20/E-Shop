using System.Drawing;

namespace E_Shop.Classes
{
    public class Product
    {
        private string _title;
        private string _description;
        private float _price;
        private Image _image;
        public Product(string title, string description, float price, Image image)
        {
            _title = title;
            _description = description;
            _price = price;
            _image = image;
        }

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public float Price { get => _price; set => _price = value; }
        public Image Image { get => _image; set => _image = value; }
    }
}
