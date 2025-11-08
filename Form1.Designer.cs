namespace Exam_Product_Management_Store
{
    partial class frmProductManagment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProduct = new Label();
            lblDescription = new Label();
            txtProduct = new TextBox();
            txtDescription = new TextBox();
            lblImage = new Label();
            btnOrder = new Button();
            cboImage = new ComboBox();
            lvProducts = new ListView();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(199, 28);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(71, 20);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product : ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(199, 79);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Description : ";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(330, 28);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(413, 27);
            txtProduct.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(330, 76);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(413, 27);
            txtDescription.TabIndex = 3;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(199, 143);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(51, 20);
            lblImage.TabIndex = 4;
            lblImage.Text = "Image";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = SystemColors.ActiveBorder;
            btnOrder.ForeColor = SystemColors.ActiveCaptionText;
            btnOrder.Location = new Point(201, 191);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 44);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // cboImage
            // 
            cboImage.FormattingEnabled = true;
            cboImage.Location = new Point(345, 200);
            cboImage.Name = "cboImage";
            cboImage.Size = new Size(157, 28);
            cboImage.TabIndex = 6;
            // 
            // lvProducts
            // 
            lvProducts.Dock = DockStyle.Bottom;
            lvProducts.Location = new Point(0, 300);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(970, 303);
            lvProducts.TabIndex = 7;
            lvProducts.UseCompatibleStateImageBehavior = false;
            // 
            // frmProductManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 603);
            Controls.Add(lvProducts);
            Controls.Add(cboImage);
            Controls.Add(btnOrder);
            Controls.Add(lblImage);
            Controls.Add(txtDescription);
            Controls.Add(txtProduct);
            Controls.Add(lblDescription);
            Controls.Add(lblProduct);
            Name = "frmProductManagment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += frmProductManagment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Label lblDescription;
        private TextBox txtProduct;
        private TextBox txtDescription;
        private Label lblImage;
        private Button btnOrder;
        private ComboBox cboImage;
        private ListView lvProducts;
    }
}
