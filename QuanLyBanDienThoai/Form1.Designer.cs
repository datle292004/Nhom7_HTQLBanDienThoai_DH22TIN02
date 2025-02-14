namespace QuanLyBanDienThoai
{
    partial class frmTrangChu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dagMatHang = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpXuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dagMatHang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(261, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý bán Điện Thoại";
            // 
            // dagMatHang
            // 
            this.dagMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dagMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dagMatHang.Location = new System.Drawing.Point(-3, 175);
            this.dagMatHang.Name = "dagMatHang";
            this.dagMatHang.ReadOnly = true;
            this.dagMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dagMatHang.Size = new System.Drawing.Size(945, 251);
            this.dagMatHang.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.nhậpXuấtKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCungCấpToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.hàngHóaToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnXuấtToolStripMenuItem,
            this.hóaĐơnNhậpToolStripMenuItem});
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản lý hóa đơn";
            // 
            // hóaĐơnXuấtToolStripMenuItem
            // 
            this.hóaĐơnXuấtToolStripMenuItem.Name = "hóaĐơnXuấtToolStripMenuItem";
            this.hóaĐơnXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hóaĐơnXuấtToolStripMenuItem.Text = "Hóa đơn xuất";
            this.hóaĐơnXuấtToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnXuấtToolStripMenuItem_Click);
            // 
            // hóaĐơnNhậpToolStripMenuItem
            // 
            this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
            this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hóaĐơnNhậpToolStripMenuItem.Text = "Hóa đơn nhập";
            this.hóaĐơnNhậpToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnNhậpToolStripMenuItem_Click);
            // 
            // nhậpXuấtKhoToolStripMenuItem
            // 
            this.nhậpXuấtKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngNhậpToolStripMenuItem,
            this.hàngXuấtToolStripMenuItem});
            this.nhậpXuấtKhoToolStripMenuItem.Name = "nhậpXuấtKhoToolStripMenuItem";
            this.nhậpXuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.nhậpXuấtKhoToolStripMenuItem.Text = "Nhập xuất kho";
            // 
            // hàngNhậpToolStripMenuItem
            // 
            this.hàngNhậpToolStripMenuItem.Name = "hàngNhậpToolStripMenuItem";
            this.hàngNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hàngNhậpToolStripMenuItem.Text = "Hàng nhập";
            this.hàngNhậpToolStripMenuItem.Click += new System.EventHandler(this.hàngNhậpToolStripMenuItem_Click);
            // 
            // hàngXuấtToolStripMenuItem
            // 
            this.hàngXuấtToolStripMenuItem.Name = "hàngXuấtToolStripMenuItem";
            this.hàngXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hàngXuấtToolStripMenuItem.Text = "Hàng xuất";
            this.hàngXuấtToolStripMenuItem.Click += new System.EventHandler(this.hàngXuấtToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHang";
            this.Column1.HeaderText = "Mã Hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHang";
            this.Column2.HeaderText = "Tên Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonVi";
            this.Column3.HeaderText = "Đơn vị";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SLTon";
            this.Column4.HeaderText = "Số lượng tồn";
            this.Column4.Name = "Column4";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 427);
            this.Controls.Add(this.dagMatHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.Text = "Quản lý bán Điện Thoại";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dagMatHang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dagMatHang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpXuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

