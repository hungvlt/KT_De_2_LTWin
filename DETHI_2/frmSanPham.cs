using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using DETHI_2.Models;

namespace DETHI_2
{
  public partial class frmSanPham : Form
  {
    private SanPhamContextDB context = new SanPhamContextDB();
    private BindingList<SanPham> bindingList; // Danh sách sản phẩm liên kết với DataGridView
    private bool isDataChanged = false; // Biến theo dõi thay đổi dữ liệu

    public frmSanPham()
    {
      InitializeComponent();
    }

    private void frmSanPham_Load(object sender, EventArgs e)
    {
      LoadData();
      LoadLoaiSPToComboBox();
      DisableSaveButtons();
    }

    private void LoadData()
    {
      try
      {
        var data = context.SanPhams.Include(sp => sp.LoaiSanPham)
            .Select(sp => new
            {
              sp.MaSanPham,
              sp.TenSanPham,
              sp.NgayNhap,
              sp.MaLoai
            }).ToList();

        // Tạo danh sách SanPham từ dữ liệu đã truy vấn
        bindingList = new BindingList<SanPham>(data.Select(d => new SanPham
        {
          MaSanPham = d.MaSanPham,
          TenSanPham = d.TenSanPham,
          NgayNhap = d.NgayNhap,
          MaLoai = d.MaLoai
        }).ToList());

        dgvDanhMucSanPham.DataSource = bindingList;
        isDataChanged = false; // Đặt lại trạng thái thay đổi dữ liệu
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LoadLoaiSPToComboBox()
    {
      try
      {
        cmbLoaiSanPham.DataSource = context.LoaiSanPhams.ToList();
        cmbLoaiSanPham.DisplayMember = "TenLoai";
        cmbLoaiSanPham.ValueMember = "MaLoai";
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Lỗi khi tải danh sách loại sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void dgvDanhMucSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0 && dgvDanhMucSanPham.Rows[e.RowIndex].Cells["MaSanPham"].Value != null)
      {
        DataGridViewRow row = dgvDanhMucSanPham.Rows[e.RowIndex];
        txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
        txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
        dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
        cmbLoaiSanPham.SelectedValue = row.Cells["MaLoai"].Value.ToString();

        DisableSaveButtons();
      }
    }

    private bool ValidateForm()
    {
      if (string.IsNullOrWhiteSpace(txtMaSanPham.Text) || txtMaSanPham.Text.Length != 3)
      {
        MessageBox.Show("Mã sản phẩm phải chứa 3 ký tự.");
        return false;
      }

      if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) || txtTenSanPham.Text.Length > 30)
      {
        MessageBox.Show("Tên sản phẩm chứa tối đa 30 ký tự.");
        return false;
      }

      if (dtpNgayNhap.Value >= DateTime.Now)
      {
        MessageBox.Show("Ngày nhập phải nhỏ hơn ngày hiện tại.");
        return false;
      }

      return true;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      if (!ValidateForm()) return;

      var newSanPham = new SanPham
      {
        MaSanPham = txtMaSanPham.Text,
        TenSanPham = txtTenSanPham.Text,
        NgayNhap = dtpNgayNhap.Value,
        MaLoai = cmbLoaiSanPham.SelectedValue.ToString()
      };

      // Kiểm tra xem mã sản phẩm đã tồn tại
      var existingSanPham = bindingList.FirstOrDefault(sp => sp.MaSanPham == newSanPham.MaSanPham);
      if (existingSanPham != null)
      {
        MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Nếu không trùng lặp, thêm sản phẩm vào danh sách liên kết
      bindingList.Add(newSanPham);
      isDataChanged = true; // Đánh dấu dữ liệu đã thay đổi
      Clear();
      EnableSaveButtons();
      MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      if (dgvDanhMucSanPham.SelectedRows.Count > 0)
      {
        if (!ValidateForm()) return;

        var selectedRow = dgvDanhMucSanPham.SelectedRows[0];
        var maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();

        var sanPham = bindingList.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        if (sanPham == null)
        {
          MessageBox.Show("Không tìm thấy sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        // Kiểm tra trùng mã sản phẩm
        var existingSanPham = bindingList.FirstOrDefault(sp => sp.MaSanPham == txtMaSanPham.Text && sp.MaSanPham != maSanPham);
        if (existingSanPham != null)
        {
          MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          return;
        }

        sanPham.TenSanPham = txtTenSanPham.Text;
        sanPham.NgayNhap = dtpNgayNhap.Value;
        sanPham.MaLoai = cmbLoaiSanPham.SelectedValue.ToString();

        isDataChanged = true; // Đánh dấu dữ liệu đã thay đổi
        Clear();
        EnableSaveButtons();
        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
      }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      if (dgvDanhMucSanPham.SelectedRows.Count > 0)
      {
        var selectedRow = dgvDanhMucSanPham.SelectedRows[0];
        var maSanPham = selectedRow.Cells["MaSanPham"].Value.ToString();

        var sanPham = bindingList.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        if (sanPham == null)
        {
          MessageBox.Show("Không tìm thấy sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (dialogResult == DialogResult.Yes)
        {
          bindingList.Remove(sanPham);
          isDataChanged = true; // Đánh dấu dữ liệu đã thay đổi
          Clear();
          EnableSaveButtons();
          MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      else
      {
        MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
      }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
      try
      {
        // Lấy danh sách mã sản phẩm trong bindingList
        var maSanPhamList = bindingList.Select(sp => sp.MaSanPham).ToList();

        // Xóa các sản phẩm có trong cơ sở dữ liệu nhưng không còn trong bindingList
        var sanPhamsToDelete = context.SanPhams
            .Where(sp => !maSanPhamList.Contains(sp.MaSanPham)).ToList();

        foreach (var sanPham in sanPhamsToDelete)
        {
          context.SanPhams.Remove(sanPham);
        }

        // Thêm hoặc cập nhật sản phẩm từ bindingList
        foreach (var sanPham in bindingList)
        {
          var existingSanPham = context.SanPhams.FirstOrDefault(sp => sp.MaSanPham == sanPham.MaSanPham);
          if (existingSanPham == null)
          {
            context.SanPhams.Add(sanPham); // Thêm mới
          }
          else
          {
            // Cập nhật sản phẩm đã tồn tại
            existingSanPham.TenSanPham = sanPham.TenSanPham;
            existingSanPham.NgayNhap = sanPham.NgayNhap;
            existingSanPham.MaLoai = sanPham.MaLoai;
          }
        }

        context.SaveChanges();
        LoadData();
        MessageBox.Show("Đã lưu thay đổi vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        isDataChanged = false; // Đặt lại trạng thái thay đổi dữ liệu
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        DisableSaveButtons();
      }
    }

    private void btnKhongLuu_Click(object sender, EventArgs e)
    {
      LoadData();
      Clear();
      DisableSaveButtons();
      isDataChanged = false; // Đặt lại trạng thái thay đổi dữ liệu
    }

    private void Clear()
    {
      txtMaSanPham.Clear();
      txtTenSanPham.Clear();
      dtpNgayNhap.Value = DateTime.Now;
      cmbLoaiSanPham.SelectedIndex = -1;
      txtMaSanPham.Focus();
    }

    private void btnTimTheoTen_Click(object sender, EventArgs e)
    {
      string tenSanPham = txtTimTheoTen.Text.Trim();

      if (string.IsNullOrWhiteSpace(tenSanPham))
      {
        LoadData();
        return;
      }

      var filteredData = context.SanPhams.Include(sp => sp.LoaiSanPham)
          .Where(sp => sp.TenSanPham.Contains(tenSanPham))
          .Select(sp => new
          {
            sp.MaSanPham,
            sp.TenSanPham,
            sp.NgayNhap,
            sp.MaLoai
          }).ToList();

      if (filteredData.Count == 0)
      {
        MessageBox.Show("Không tìm thấy sản phẩm nào với tên đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        // Chuyển đổi danh sách ẩn danh thành danh sách SanPham
        bindingList = new BindingList<SanPham>(filteredData.Select(d => new SanPham
        {
          MaSanPham = d.MaSanPham,
          TenSanPham = d.TenSanPham,
          NgayNhap = d.NgayNhap,
          MaLoai = d.MaLoai
        }).ToList());

        dgvDanhMucSanPham.DataSource = bindingList;
      }
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
      Clear();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
      // Cảnh báo khi đóng form
      if (isDataChanged)
      {
        DialogResult result = MessageBox.Show("Bạn có muốn lưu các thay đổi trước khi thoát?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
          btnLuu.PerformClick();
        }
        else if (result == DialogResult.Cancel)
        {
          return;
        }
        Application.Exit();
      }
      else
      {
        DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
          Application.Exit();
        }
      }
    }

    private void EnableSaveButtons()
    {
      btnLuu.Enabled = true;
      btnKhongLuu.Enabled = true;
    }

    private void DisableSaveButtons()
    {
      btnLuu.Enabled = false;
      btnKhongLuu.Enabled = false;
    }
  }
}