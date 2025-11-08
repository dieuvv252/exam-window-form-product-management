using Exam_Product_Management_Store.Models;

namespace Exam_Product_Management_Store {

    public partial class frmProductManagment : Form {
        private List<Product> productList = new List<Product>();
        private ImageList imageListLarge = new ImageList();

        public frmProductManagment()
        {
            InitializeComponent();
            EnsureAssetCopied();
            LoadImagesToComboBox();
            SetupGridView();
        }

        private void frmProductManagment_Load(object sender, EventArgs e)
        {
        }

        private void LoadImagesToComboBox()
        {
            string folderPath = Path.Combine(Application.StartupPath, "Asset");

            if (Directory.Exists(folderPath))
            {
                cboImage.Items.Clear();
                foreach (var file in Directory.GetFiles(folderPath))
                {
                    cboImage.Items.Add(Path.GetFileName(file));
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thư mục Asset tại: " + folderPath);
            }
        }

        private void EnsureAssetCopied()
        {
            string sourceFolder = Path.Combine(Application.StartupPath, @"..\..\..\Asset");
            string destFolder = Path.Combine(Application.StartupPath, "Asset");

            if (!Directory.Exists(destFolder))
            {
                Directory.CreateDirectory(destFolder);
                foreach (string file in Directory.GetFiles(sourceFolder))
                {
                    string fileName = Path.GetFileName(file);
                    File.Copy(file, Path.Combine(destFolder, fileName), true);
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduct.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cboImage.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }

            string folderPath = Path.Combine(Application.StartupPath, "Asset");
            string imagePath = Path.Combine(folderPath, cboImage.SelectedItem.ToString());

            Product product = new Product
            {
                ProductName = txtProduct.Text,
                Description = txtDescription.Text,
                ImagePath = imagePath,
                Image = Image.FromFile(imagePath)
            };

            productList.Add(product);
            AddProductToGrid(product);
            ClearInputs();
        }

        private void AddProductToGrid(Product product)
        {
            // tạo key duy nhất cho ảnh
            string key = Guid.NewGuid().ToString();
            imageListLarge.Images.Add(key, product.Image);

            // hiển thị text: tên + xuống dòng + mô tả
            ListViewItem item = new ListViewItem($"{product.ProductName}\n{product.Description}", key);
            lvProducts.Items.Add(item);
        }

        private void SetupGridView()
        {
            lvProducts.View = View.LargeIcon;
            lvProducts.LargeImageList = imageListLarge;
            lvProducts.MultiSelect = false;
            lvProducts.BackColor = Color.White;
            lvProducts.ForeColor = Color.Black;
            lvProducts.Font = new Font("Segoe UI", 9);

            imageListLarge.ImageSize = new Size(100, 100);
            lvProducts.ItemSelectionChanged += (s, e) => e.Item.Selected = false;
            lvProducts.HideSelection = true;
        }

        private void ClearInputs()
        {
            txtProduct.Clear();
            txtDescription.Clear();
            cboImage.SelectedIndex = -1;
        }
    }
}