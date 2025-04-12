using System.Drawing;

namespace E_Shop.Classes
{
    public class Product
    {
        private int _id;
        private string _title;
        private string _description;
        private float _price;
        private Image _image;
        public Product(int Id, string title, string description, float price, Image image)
        {
            _id = Id;
            _title = title;
            _description = description;
            _price = price;
            _image = image;
        }

        public int ID { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public float Price { get => _price; set => _price = value; }
        public Image Image { get => _image; set => _image = value; }
    }
}
