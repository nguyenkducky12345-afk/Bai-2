using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // default selections
            rbThap.Checked = true;
            cbLoaiSuCo.SelectedIndex = -1;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                ofd.Title = "Chọn ảnh lỗi";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load into memory stream to avoid locking the file
                        using (var fs = File.OpenRead(ofd.FileName))
                        {
                            var img = Image.FromStream(fs);
                            // dispose previous image if any
                            if (picAnh.Image != null)
                            {
                                var old = picAnh.Image;
                                picAnh.Image = null;
                                old.Dispose();
                            }
                            picAnh.Image = new Bitmap(img);
                        }
                        picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string ma = txtMaPhieu.Text.Trim();
            string nguoi = txtNguoiYeuCau.Text.Trim();
            string ngay = dtpNgay.Value.ToString("dd/MM/yyyy");

            string mucDo = rbKhanCap.Checked ? "Khẩn cấp" : rbTrungBinh.Checked ? "Trung bình" : "Thấp";

            string loai = cbLoaiSuCo.SelectedItem != null ? cbLoaiSuCo.SelectedItem.ToString() : "(chưa chọn)";

            var thietBi = new[]
            {
                chkMayTinhBan.Checked ? "Máy tính bàn" : null,
                chkLaptop.Checked ? "Laptop" : null,
                chkMayIn.Checked ? "Máy in" : null,
                chkDienThoai.Checked ? "Điện thoại" : null
            }.Where(x => x != null).ToArray();

            string thietBiStr = thietBi.Length > 0 ? string.Join(", ", thietBi) : "(không có)";

            string summary =
                $"Mã phiếu: {ma}\n" +
                $"Người yêu cầu: {nguoi}\n" +
                $"Ngày ghi nhận: {ngay}\n" +
                $"Mức độ ưu tiên: {mucDo}\n" +
                $"Loại sự cố: {loai}\n" +
                $"Thiết bị ảnh hưởng: {thietBiStr}\n" +
                $"Ảnh lỗi: {(picAnh.Image != null ? "Đã tải" : "Chưa tải")}";

            MessageBox.Show(summary, "Tóm tắt yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgay.Value = DateTime.Now;
            rbThap.Checked = true;
            cbLoaiSuCo.SelectedIndex = -1;
            chkMayTinhBan.Checked = chkLaptop.Checked = chkMayIn.Checked = chkDienThoai.Checked = false;
            if (picAnh.Image != null)
            {
                var old = picAnh.Image;
                picAnh.Image = null;
                old.Dispose();
            }
        }
    }
}
