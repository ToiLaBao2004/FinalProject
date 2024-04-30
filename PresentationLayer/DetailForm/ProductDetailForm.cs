using BusinessLogicLayer.LoadDataFunc;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.DetailForm
{
    public partial class ProductDetailForm : Form
    {
        int Check;
        string Product_ID;
        public ProductDetailForm(int check, string Product_ID)
        {
            this.Check = check;
            this.Product_ID = Product_ID;
            InitializeComponent();

            if (Check == 1)
            {
                this.Text = "Chi tiết sản phẩm";
                textBoxMaSanPham.ReadOnly = true;
                textBoxTenSanPham.ReadOnly = true;
                textBoxGiaBan.ReadOnly = true;
                buttonHinhAnh.Visible = true;
                buttonHinhAnh.Enabled = false;
                buttonSave.Visible = false;
            }
            else if (Check == 2)
            {
                this.Text = "Sửa sản phẩm";
                textBoxMaSanPham.ReadOnly = true;
                textBoxTenSanPham.ReadOnly = false;
                textBoxGiaBan.ReadOnly = false;
                buttonSave.Enabled = true;
                textBoxGiaBan.ReadOnly = false;
                buttonHinhAnh.Visible = true;
                buttonHinhAnh.Enabled = false;
            } 
            else if (Check == 3)
            {
                this.Text = "Thêm sản phẩm";
                textBoxMaSanPham.ReadOnly = false;
                textBoxMaSanPham.Text = string.Empty;
                textBoxTenSanPham.ReadOnly = false;
                textBoxTenSanPham.Text = string.Empty;
                textBoxGiaBan.ReadOnly = false;
                buttonSave.Enabled = true;
                textBoxGiaBan.ReadOnly = false;
                buttonHinhAnh.Visible = true;
            }
        }

        private Image GetImageByName(string imageName)
        {
            string imgFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\HCMUTE\\FinalProject\\PresentationLayer\\Image");
            try
            {
                // Đường dẫn đến tệp tin ảnh bằng tên hình ảnh
                string imgFilePath = Path.Combine(imgFolderPath, imageName);
                // Kiểm tra xem tệp tin ảnh có tồn tại không
                if (File.Exists(imgFilePath))
                {
                    // Tạo một đối tượng Image từ tệp tin ảnh
                    Image image = Image.FromFile(imgFilePath);
                    return image;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình ảnh có tên: " + imageName);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }

        void FormAddProduct()
        {
            // Tải danh sách thương hiệu và chọn thương hiệu tương ứng của sản phẩm
            DataThuongHieu dataThuongHieu = new DataThuongHieu();
            comboBoxThuongHieu.DisplayMember = "BrandName";
            comboBoxThuongHieu.ValueMember = "Brand_ID";
            comboBoxThuongHieu.DataSource = dataThuongHieu.LoadThuongHieu();

            // Tải danh sách loại sản phẩm và chọn loại sản phẩm tương ứng của sản phẩm
            DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
            comboBoxLoaiSanPham.DisplayMember = "CategoryName";
            comboBoxLoaiSanPham.ValueMember = "Category_ID";
            comboBoxLoaiSanPham.DataSource = dataPhanLoaiSP.LoadLoaiSanPham();
        }

        void LoadData()
        {
            try
            {
                // Khởi tạo đối tượng DataSanPham để tải thông tin sản phẩm
                DataSanPham dataSanPham = new DataSanPham();

                // Tải thông tin sản phẩm từ mã sản phẩm (Product_ID)
                Product product = dataSanPham.LaySanPhamTuMaSanPham(Product_ID);

                // Hiển thị thông tin sản phẩm trên các TextBox
                if (product != null)
                {
                    textBoxMaSanPham.Text = product.Product_ID;
                    textBoxTenSanPham.Text = product.ProductName;
                    textBoxGiaBan.Text = product.UnitPrice.ToString();

                    // Tải danh sách thương hiệu và chọn thương hiệu tương ứng của sản phẩm
                    DataThuongHieu dataThuongHieu = new DataThuongHieu();
                    comboBoxThuongHieu.DisplayMember = "BrandName";
                    comboBoxThuongHieu.ValueMember = "Brand_ID";
                    comboBoxThuongHieu.DataSource = dataThuongHieu.LoadThuongHieu();

                    var brandInfo = dataThuongHieu.TimThuongHieuDuaTrenMaSanPham(Product_ID);
                    if (brandInfo != null)
                    {
                        comboBoxThuongHieu.SelectedValue = brandInfo.Brand_ID;

                        // Tải danh sách loại sản phẩm và chọn loại sản phẩm tương ứng của sản phẩm
                        DataPhanLoaiSP dataPhanLoaiSP = new DataPhanLoaiSP();
                        comboBoxLoaiSanPham.DisplayMember = "CategoryName";
                        comboBoxLoaiSanPham.ValueMember = "Category_ID";
                        comboBoxLoaiSanPham.DataSource = dataPhanLoaiSP.LoadLoaiSanPham();

                        var categoryInfo = dataPhanLoaiSP.TimLoaiSPDuaTrenMaSanPham(Product_ID);
                        if (categoryInfo != null)
                        {
                            comboBoxLoaiSanPham.SelectedValue = categoryInfo.Category_ID;

                            // Tải hình ảnh sản phẩm và hiển thị trên PictureBox nếu có
                            DataHinhAnhSP dataHinhAnhSP = new DataHinhAnhSP();
                            PictureProduct pictureProduct = dataHinhAnhSP.TimHinhAnhDuaTrenMaSanPham(Product_ID);

                            if (pictureProduct != null)
                            {
                                pictureBoxSanPham.Image = GetImageByName(pictureProduct.PictureName);
                            }
                            else
                            {
                                pictureBoxSanPham.Image = null;
                                MessageBox.Show("Không tìm thấy hình ảnh cho sản phẩm này.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin loại sản phẩm cho sản phẩm này.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin thương hiệu cho sản phẩm này.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và hiển thị thông báo lỗi
                pictureBoxSanPham.Image = null;
                MessageBox.Show("Đã xảy ra lỗi khi tải thông tin sản phẩm: " + ex.Message);
            }
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            if (Check == 1 || Check == 2)
            {
                LoadData();
            }
            else
            {
                FormAddProduct();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataSanPham dataSanPham = new DataSanPham();
                string ProductID = textBoxMaSanPham.Text;
                string ProductName = textBoxTenSanPham.Text;
                int UnitPrice = int.Parse(textBoxGiaBan.Text);
                string BrandID = comboBoxThuongHieu.SelectedValue.ToString(); // Sử dụng SelectedValue thay vì ValueMember
                string CategoryID = comboBoxLoaiSanPham.SelectedValue.ToString(); // Sử dụng SelectedValue thay vì ValueMember

                if (Check == 2)
                {
                    // Cập nhật sản phẩm
                    if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dataSanPham.AddOrUpdateSanPham(ProductID, ProductName, UnitPrice, BrandID, CategoryID);
                        MessageBox.Show("Đã cập nhật sản phẩm thành công");
                    }
                }
                else if (Check == 3)
                {
                    // Thêm mới sản phẩm
                    if (MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dataSanPham.AddOrUpdateSanPham(ProductID, ProductName, UnitPrice, BrandID, CategoryID);
                        MessageBox.Show("Đã thêm sản phẩm thành công");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá bán không hợp lệ. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu thông tin sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
