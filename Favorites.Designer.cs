namespace SvetanFlickrApp
{
    partial class Favorites
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
            this.grdFavs = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.dtMax = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMin = new System.Windows.Forms.DateTimePicker();
            this.chkExcludeFriends = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPageNumber = new System.Windows.Forms.NumericUpDown();
            this.txtPerPage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAuto = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pbar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdFavs
            // 
            this.grdFavs.AllowUserToDeleteRows = false;
            this.grdFavs.AllowUserToOrderColumns = true;
            this.grdFavs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.grdFavs, 2);
            this.grdFavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFavs.Location = new System.Drawing.Point(3, 76);
            this.grdFavs.Name = "grdFavs";
            this.grdFavs.Size = new System.Drawing.Size(586, 359);
            this.grdFavs.TabIndex = 0;
            this.grdFavs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFavs_CellClick);
            this.grdFavs.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdFavs_ColumnHeaderMouseDoubleClick);
            this.grdFavs.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdFavs_RowsAdded);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picPhoto
            // 
            this.picPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPhoto.Location = new System.Drawing.Point(595, 76);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(418, 359);
            this.picPhoto.TabIndex = 4;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.52713F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.90158F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.63386F));
            this.tblMain.Controls.Add(this.grdFavs, 0, 1);
            this.tblMain.Controls.Add(this.picPhoto, 2, 1);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblMain.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tblMain.Controls.Add(this.panel1, 2, 0);
            this.tblMain.Controls.Add(this.lblCount, 0, 2);
            this.tblMain.Controls.Add(this.lblAuthor, 2, 2);
            this.tblMain.Controls.Add(this.pbar, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1016, 479);
            this.tblMain.TabIndex = 5;
            this.tblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMain_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5509F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.4491F));
            this.tableLayoutPanel1.Controls.Add(this.chkAll, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtMax, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtMin, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkExcludeFriends, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 67);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(3, 47);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(71, 17);
            this.chkAll.TabIndex = 8;
            this.chkAll.Text = "Check All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // dtMax
            // 
            this.dtMax.CustomFormat = "\"MM/DD/YYYY\";";
            this.dtMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMax.Location = new System.Drawing.Point(85, 25);
            this.dtMax.Name = "dtMax";
            this.dtMax.Size = new System.Drawing.Size(246, 20);
            this.dtMax.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min Date";
            // 
            // dtMin
            // 
            this.dtMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMin.Location = new System.Drawing.Point(85, 3);
            this.dtMin.Name = "dtMin";
            this.dtMin.Size = new System.Drawing.Size(246, 20);
            this.dtMin.TabIndex = 4;
            this.dtMin.Value = new System.DateTime(2010, 12, 12, 0, 0, 0, 0);
            // 
            // chkExcludeFriends
            // 
            this.chkExcludeFriends.AutoSize = true;
            this.chkExcludeFriends.Checked = true;
            this.chkExcludeFriends.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcludeFriends.Location = new System.Drawing.Point(85, 47);
            this.chkExcludeFriends.Name = "chkExcludeFriends";
            this.chkExcludeFriends.Size = new System.Drawing.Size(101, 17);
            this.chkExcludeFriends.TabIndex = 7;
            this.chkExcludeFriends.Text = "Exclude Friends";
            this.chkExcludeFriends.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82927F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.17073F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.numPageNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPerPage, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(343, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 67);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Per Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Page #";
            // 
            // numPageNumber
            // 
            this.numPageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPageNumber.Location = new System.Drawing.Point(69, 3);
            this.numPageNumber.Name = "numPageNumber";
            this.numPageNumber.Size = new System.Drawing.Size(174, 20);
            this.numPageNumber.TabIndex = 6;
            this.numPageNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPerPage
            // 
            this.txtPerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPerPage.Location = new System.Drawing.Point(69, 36);
            this.txtPerPage.Name = "txtPerPage";
            this.txtPerPage.Size = new System.Drawing.Size(174, 20);
            this.txtPerPage.TabIndex = 7;
            this.txtPerPage.Text = "500";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdAuto);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(595, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 51);
            this.panel1.TabIndex = 10;
            // 
            // cmdAuto
            // 
            this.cmdAuto.Location = new System.Drawing.Point(110, 4);
            this.cmdAuto.Name = "cmdAuto";
            this.cmdAuto.Size = new System.Drawing.Size(109, 23);
            this.cmdAuto.TabIndex = 10;
            this.cmdAuto.Text = "Auto";
            this.cmdAuto.UseVisualStyleBackColor = true;
            this.cmdAuto.Click += new System.EventHandler(this.cmdAuto_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 438);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 11;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(595, 438);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(0, 13);
            this.lblAuthor.TabIndex = 12;
            // 
            // pbar
            // 
            this.tblMain.SetColumnSpan(this.pbar, 2);
            this.pbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbar.Location = new System.Drawing.Point(3, 461);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(586, 15);
            this.pbar.TabIndex = 13;
            this.pbar.Visible = false;
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 479);
            this.Controls.Add(this.tblMain);
            this.Name = "Favorites";
            this.Text = "Favorites";
            this.Load += new System.EventHandler(this.Favorites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPageNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFavs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPageNumber;
        private System.Windows.Forms.TextBox txtPerPage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ProgressBar pbar;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkExcludeFriends;
        private System.Windows.Forms.Button cmdAuto;
    }
}