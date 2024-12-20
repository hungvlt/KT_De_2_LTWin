namespace DETHI_2
{
  partial class frmSanPham
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dgvDanhMucSanPham = new System.Windows.Forms.DataGridView();
      this.lblDanhMucSanPham = new System.Windows.Forms.Label();
      this.lblMaSanPham = new System.Windows.Forms.Label();
      this.lblTenSanPham = new System.Windows.Forms.Label();
      this.lblNgayNhap = new System.Windows.Forms.Label();
      this.lblLoaiSanPham = new System.Windows.Forms.Label();
      this.txtMaSanPham = new System.Windows.Forms.TextBox();
      this.txtTenSanPham = new System.Windows.Forms.TextBox();
      this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
      this.cmbLoaiSanPham = new System.Windows.Forms.ComboBox();
      this.txtTimTheoTen = new System.Windows.Forms.TextBox();
      this.btnTimTheoTen = new System.Windows.Forms.Button();
      this.btnThem = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.btnKhongLuu = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSanPham)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvDanhMucSanPham
      // 
      this.dgvDanhMucSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDanhMucSanPham.Location = new System.Drawing.Point(11, 144);
      this.dgvDanhMucSanPham.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.dgvDanhMucSanPham.Name = "dgvDanhMucSanPham";
      this.dgvDanhMucSanPham.RowHeadersWidth = 72;
      this.dgvDanhMucSanPham.RowTemplate.Height = 31;
      this.dgvDanhMucSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDanhMucSanPham.Size = new System.Drawing.Size(870, 552);
      this.dgvDanhMucSanPham.TabIndex = 0;
      this.dgvDanhMucSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucSanPham_CellClick);
      // 
      // lblDanhMucSanPham
      // 
      this.lblDanhMucSanPham.AutoSize = true;
      this.lblDanhMucSanPham.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDanhMucSanPham.Location = new System.Drawing.Point(431, 20);
      this.lblDanhMucSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDanhMucSanPham.Name = "lblDanhMucSanPham";
      this.lblDanhMucSanPham.Size = new System.Drawing.Size(497, 57);
      this.lblDanhMucSanPham.TabIndex = 1;
      this.lblDanhMucSanPham.Text = "DANH MỤC SẢN PHẨM";
      // 
      // lblMaSanPham
      // 
      this.lblMaSanPham.AutoSize = true;
      this.lblMaSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMaSanPham.Location = new System.Drawing.Point(905, 162);
      this.lblMaSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblMaSanPham.Name = "lblMaSanPham";
      this.lblMaSanPham.Size = new System.Drawing.Size(168, 32);
      this.lblMaSanPham.TabIndex = 1;
      this.lblMaSanPham.Text = "Mã sản phẩm:";
      // 
      // lblTenSanPham
      // 
      this.lblTenSanPham.AutoSize = true;
      this.lblTenSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTenSanPham.Location = new System.Drawing.Point(905, 249);
      this.lblTenSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblTenSanPham.Name = "lblTenSanPham";
      this.lblTenSanPham.Size = new System.Drawing.Size(171, 32);
      this.lblTenSanPham.TabIndex = 1;
      this.lblTenSanPham.Text = "Tên sản phẩm:";
      // 
      // lblNgayNhap
      // 
      this.lblNgayNhap.AutoSize = true;
      this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNgayNhap.Location = new System.Drawing.Point(905, 332);
      this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblNgayNhap.Name = "lblNgayNhap";
      this.lblNgayNhap.Size = new System.Drawing.Size(139, 32);
      this.lblNgayNhap.TabIndex = 1;
      this.lblNgayNhap.Text = "Ngày nhập:";
      // 
      // lblLoaiSanPham
      // 
      this.lblLoaiSanPham.AutoSize = true;
      this.lblLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLoaiSanPham.Location = new System.Drawing.Point(905, 414);
      this.lblLoaiSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblLoaiSanPham.Name = "lblLoaiSanPham";
      this.lblLoaiSanPham.Size = new System.Drawing.Size(178, 32);
      this.lblLoaiSanPham.TabIndex = 1;
      this.lblLoaiSanPham.Text = "Loại sản phẩm:";
      // 
      // txtMaSanPham
      // 
      this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMaSanPham.Location = new System.Drawing.Point(1089, 161);
      this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtMaSanPham.Name = "txtMaSanPham";
      this.txtMaSanPham.Size = new System.Drawing.Size(120, 38);
      this.txtMaSanPham.TabIndex = 2;
      // 
      // txtTenSanPham
      // 
      this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTenSanPham.Location = new System.Drawing.Point(1089, 247);
      this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtTenSanPham.Name = "txtTenSanPham";
      this.txtTenSanPham.Size = new System.Drawing.Size(227, 38);
      this.txtTenSanPham.TabIndex = 2;
      // 
      // dtpNgayNhap
      // 
      this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgayNhap.Location = new System.Drawing.Point(1089, 328);
      this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dtpNgayNhap.Name = "dtpNgayNhap";
      this.dtpNgayNhap.Size = new System.Drawing.Size(170, 38);
      this.dtpNgayNhap.TabIndex = 3;
      // 
      // cmbLoaiSanPham
      // 
      this.cmbLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbLoaiSanPham.FormattingEnabled = true;
      this.cmbLoaiSanPham.Location = new System.Drawing.Point(1089, 411);
      this.cmbLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cmbLoaiSanPham.Name = "cmbLoaiSanPham";
      this.cmbLoaiSanPham.Size = new System.Drawing.Size(120, 39);
      this.cmbLoaiSanPham.TabIndex = 4;
      // 
      // txtTimTheoTen
      // 
      this.txtTimTheoTen.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTimTheoTen.Location = new System.Drawing.Point(12, 84);
      this.txtTimTheoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtTimTheoTen.Name = "txtTimTheoTen";
      this.txtTimTheoTen.Size = new System.Drawing.Size(206, 38);
      this.txtTimTheoTen.TabIndex = 5;
      // 
      // btnTimTheoTen
      // 
      this.btnTimTheoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTimTheoTen.Location = new System.Drawing.Point(224, 81);
      this.btnTimTheoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnTimTheoTen.Name = "btnTimTheoTen";
      this.btnTimTheoTen.Size = new System.Drawing.Size(134, 43);
      this.btnTimTheoTen.TabIndex = 6;
      this.btnTimTheoTen.Text = "Tìm kiếm";
      this.btnTimTheoTen.UseVisualStyleBackColor = true;
      this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
      // 
      // btnThem
      // 
      this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnThem.Location = new System.Drawing.Point(113, 732);
      this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(145, 43);
      this.btnThem.TabIndex = 6;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = true;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // btnSua
      // 
      this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSua.Location = new System.Drawing.Point(307, 732);
      this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(145, 43);
      this.btnSua.TabIndex = 6;
      this.btnSua.Text = "Sửa";
      this.btnSua.UseVisualStyleBackColor = true;
      this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
      // 
      // btnXoa
      // 
      this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnXoa.Location = new System.Drawing.Point(503, 732);
      this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(145, 43);
      this.btnXoa.TabIndex = 6;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = true;
      this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
      // 
      // btnLuu
      // 
      this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLuu.Location = new System.Drawing.Point(698, 732);
      this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnLuu.Name = "btnLuu";
      this.btnLuu.Size = new System.Drawing.Size(145, 43);
      this.btnLuu.TabIndex = 6;
      this.btnLuu.Text = "Lưu";
      this.btnLuu.UseVisualStyleBackColor = true;
      this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
      // 
      // btnKhongLuu
      // 
      this.btnKhongLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnKhongLuu.Location = new System.Drawing.Point(894, 732);
      this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnKhongLuu.Name = "btnKhongLuu";
      this.btnKhongLuu.Size = new System.Drawing.Size(145, 43);
      this.btnKhongLuu.TabIndex = 6;
      this.btnKhongLuu.Text = "Không lưu";
      this.btnKhongLuu.UseVisualStyleBackColor = true;
      this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
      // 
      // btnThoat
      // 
      this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnThoat.Location = new System.Drawing.Point(1089, 732);
      this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnThoat.Name = "btnThoat";
      this.btnThoat.Size = new System.Drawing.Size(145, 43);
      this.btnThoat.TabIndex = 6;
      this.btnThoat.Text = "Thoát";
      this.btnThoat.UseVisualStyleBackColor = true;
      this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLamMoi.Location = new System.Drawing.Point(1171, 491);
      this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(145, 43);
      this.btnLamMoi.TabIndex = 6;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.UseVisualStyleBackColor = true;
      this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
      // 
      // frmSanPham
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1343, 800);
      this.Controls.Add(this.btnLamMoi);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnKhongLuu);
      this.Controls.Add(this.btnLuu);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.btnSua);
      this.Controls.Add(this.btnThem);
      this.Controls.Add(this.btnTimTheoTen);
      this.Controls.Add(this.txtTimTheoTen);
      this.Controls.Add(this.cmbLoaiSanPham);
      this.Controls.Add(this.dtpNgayNhap);
      this.Controls.Add(this.txtTenSanPham);
      this.Controls.Add(this.txtMaSanPham);
      this.Controls.Add(this.lblLoaiSanPham);
      this.Controls.Add(this.lblNgayNhap);
      this.Controls.Add(this.lblTenSanPham);
      this.Controls.Add(this.lblMaSanPham);
      this.Controls.Add(this.lblDanhMucSanPham);
      this.Controls.Add(this.dgvDanhMucSanPham);
      this.Font = new System.Drawing.Font("Segoe UI", 8F);
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "frmSanPham";
      this.Text = "QUẢN LÝ SẢN PHẨM";
      this.Load += new System.EventHandler(this.frmSanPham_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSanPham)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvDanhMucSanPham;
    private System.Windows.Forms.Label lblDanhMucSanPham;
    private System.Windows.Forms.Label lblMaSanPham;
    private System.Windows.Forms.Label lblTenSanPham;
    private System.Windows.Forms.Label lblNgayNhap;
    private System.Windows.Forms.Label lblLoaiSanPham;
    private System.Windows.Forms.TextBox txtMaSanPham;
    private System.Windows.Forms.TextBox txtTenSanPham;
    private System.Windows.Forms.DateTimePicker dtpNgayNhap;
    private System.Windows.Forms.ComboBox cmbLoaiSanPham;
    private System.Windows.Forms.TextBox txtTimTheoTen;
    private System.Windows.Forms.Button btnTimTheoTen;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnKhongLuu;
    private System.Windows.Forms.Button btnThoat;
    private System.Windows.Forms.Button btnLamMoi;
  }
}