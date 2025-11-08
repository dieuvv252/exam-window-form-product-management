namespace Exam_Product_Management_Store.Models {

    public class Product {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Image Image { get; set; }
    }
}