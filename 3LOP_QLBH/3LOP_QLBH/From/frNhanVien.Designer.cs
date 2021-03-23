namespace _3LOP_QLBH
{
    partial class frNhanVien
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
            this.data = new System.Windows.Forms.DataGridView();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butthoat = new System.Windows.Forms.Button();
            this.Buttimkiem = new System.Windows.Forms.Button();
            this.butNew = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.butshow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(439, 163);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 62;
            this.data.RowTemplate.Height = 28;
            this.data.Size = new System.Drawing.Size(386, 390);
            this.data.TabIndex = 38;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(214, 282);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(177, 26);
            this.txttennv.TabIndex = 37;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(214, 186);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(177, 26);
            this.txtmanv.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(174, 511);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(86, 42);
            this.butthoat.TabIndex = 54;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // Buttimkiem
            // 
            this.Buttimkiem.Location = new System.Drawing.Point(285, 433);
            this.Buttimkiem.Name = "Buttimkiem";
            this.Buttimkiem.Size = new System.Drawing.Size(93, 37);
            this.Buttimkiem.TabIndex = 53;
            this.Buttimkiem.Text = "Tìm Kiếm";
            this.Buttimkiem.UseVisualStyleBackColor = true;
            this.Buttimkiem.Click += new System.EventHandler(this.Buttimkiem_Click);
            // 
            // butNew
            // 
            this.butNew.Location = new System.Drawing.Point(174, 358);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(86, 37);
            this.butNew.TabIndex = 52;
            this.butNew.Text = "Tạo Mới";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(174, 433);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(86, 37);
            this.butxoa.TabIndex = 51;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(63, 433);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(84, 37);
            this.butsua.TabIndex = 50;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(285, 358);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(93, 37);
            this.butthem.TabIndex = 49;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butshow
            // 
            this.butshow.Location = new System.Drawing.Point(63, 358);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(84, 37);
            this.butshow.TabIndex = 48;
            this.butshow.Text = "Hiển Thị";
            this.butshow.UseVisualStyleBackColor = true;
            this.butshow.Click += new System.EventHandler(this.butshow_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(441, 46);
            this.label5.TabIndex = 101;
            this.label5.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 568);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.Buttimkiem);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.butshow);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frNhanVien";
            this.Text = "frSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button Buttimkiem;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butshow;
        private System.Windows.Forms.Label label5;
    }
}