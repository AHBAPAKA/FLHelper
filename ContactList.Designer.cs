namespace SvetanFlickrApp
{
    partial class ContactList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactList));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdFavs = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLastPhotofavs = new System.Windows.Forms.Button();
            this.btnPopulateDefComments = new System.Windows.Forms.Button();
            this.cmd10PhotoFavs = new System.Windows.Forms.Button();
            this.cmdMyPhotos = new System.Windows.Forms.ComboBox();
            this.btnLastPhotoComments = new System.Windows.Forms.Button();
            this.btnCommentSelected = new System.Windows.Forms.Button();
            this.btnFavAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.cmbComments = new System.Windows.Forms.ComboBox();
            this.cmdUpdateFavDB = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkUseLocalFavs = new System.Windows.Forms.CheckBox();
            this.cmdHideGavnoColumns = new System.Windows.Forms.Button();
            this.cmdDeleteRows = new System.Windows.Forms.Button();
            this.cmdHideColums = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblRandomComment = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdFavsToDelete = new System.Windows.Forms.Button();
            this.dtDeleteMaxDate = new System.Windows.Forms.DateTimePicker();
            this.cmdDeleteFavs = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5197F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.13508F));
            this.tblMain.Controls.Add(this.grdFavs, 0, 1);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblMain.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tblMain.Controls.Add(this.panel1, 2, 0);
            this.tblMain.Controls.Add(this.lblCount, 0, 2);
            this.tblMain.Controls.Add(this.lblAuthor, 2, 2);
            this.tblMain.Controls.Add(this.progressBar1, 0, 3);
            this.tblMain.Controls.Add(this.lblRandomComment, 1, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.10961F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.8904F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1066, 780);
            this.tblMain.TabIndex = 6;
            this.tblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMain_Paint);
            // 
            // grdFavs
            // 
            this.grdFavs.AllowUserToOrderColumns = true;
            this.grdFavs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdFavs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdFavs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.grdFavs, 4);
            this.grdFavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFavs.Location = new System.Drawing.Point(3, 159);
            this.grdFavs.Name = "grdFavs";
            this.grdFavs.Size = new System.Drawing.Size(1060, 577);
            this.grdFavs.TabIndex = 0;
            this.grdFavs.Visible = false;
            this.grdFavs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFavs_CellContentClick);
            this.grdFavs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFavs_CellValueChanged);
            this.grdFavs.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdFavs_EditingControlShowing);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.Controls.Add(this.btnLastPhotofavs, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPopulateDefComments, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmd10PhotoFavs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdMyPhotos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLastPhotoComments, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCommentSelected, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFavAll, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 150);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnLastPhotofavs
            // 
            this.btnLastPhotofavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastPhotofavs.Location = new System.Drawing.Point(3, 84);
            this.btnLastPhotofavs.Name = "btnLastPhotofavs";
            this.btnLastPhotofavs.Size = new System.Drawing.Size(182, 31);
            this.btnLastPhotofavs.TabIndex = 2;
            this.btnLastPhotofavs.Text = "Selected Photo Favs";
            this.btnLastPhotofavs.UseVisualStyleBackColor = true;
            this.btnLastPhotofavs.Click += new System.EventHandler(this.btnLastPhotofavs_Click);
            // 
            // btnPopulateDefComments
            // 
            this.btnPopulateDefComments.Location = new System.Drawing.Point(191, 11);
            this.btnPopulateDefComments.Name = "btnPopulateDefComments";
            this.btnPopulateDefComments.Size = new System.Drawing.Size(135, 30);
            this.btnPopulateDefComments.TabIndex = 0;
            this.btnPopulateDefComments.Text = "Populate Default Comments";
            this.btnPopulateDefComments.UseVisualStyleBackColor = true;
            this.btnPopulateDefComments.Click += new System.EventHandler(this.btnPopulateDefComments_Click);
            // 
            // cmd10PhotoFavs
            // 
            this.cmd10PhotoFavs.Location = new System.Drawing.Point(3, 11);
            this.cmd10PhotoFavs.Name = "cmd10PhotoFavs";
            this.cmd10PhotoFavs.Size = new System.Drawing.Size(181, 30);
            this.cmd10PhotoFavs.TabIndex = 2;
            this.cmd10PhotoFavs.Text = "10 photo favs";
            this.cmd10PhotoFavs.UseVisualStyleBackColor = true;
            this.cmd10PhotoFavs.Click += new System.EventHandler(this.cmdTestRCom_Click);
            // 
            // cmdMyPhotos
            // 
            this.cmdMyPhotos.FormattingEnabled = true;
            this.cmdMyPhotos.Location = new System.Drawing.Point(3, 47);
            this.cmdMyPhotos.Name = "cmdMyPhotos";
            this.cmdMyPhotos.Size = new System.Drawing.Size(181, 21);
            this.cmdMyPhotos.TabIndex = 5;
            this.cmdMyPhotos.SelectedIndexChanged += new System.EventHandler(this.cmdMyPhotos_SelectedIndexChanged);
            // 
            // btnLastPhotoComments
            // 
            this.btnLastPhotoComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastPhotoComments.Location = new System.Drawing.Point(3, 121);
            this.btnLastPhotoComments.Name = "btnLastPhotoComments";
            this.btnLastPhotoComments.Size = new System.Drawing.Size(182, 26);
            this.btnLastPhotoComments.TabIndex = 4;
            this.btnLastPhotoComments.Text = "Selected Photo Comments";
            this.btnLastPhotoComments.UseVisualStyleBackColor = true;
            this.btnLastPhotoComments.Click += new System.EventHandler(this.btnLastPhotoComments_Click);
            // 
            // btnCommentSelected
            // 
            this.btnCommentSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCommentSelected.Location = new System.Drawing.Point(191, 121);
            this.btnCommentSelected.Name = "btnCommentSelected";
            this.btnCommentSelected.Size = new System.Drawing.Size(135, 26);
            this.btnCommentSelected.TabIndex = 3;
            this.btnCommentSelected.Text = "Comment Selected";
            this.btnCommentSelected.UseVisualStyleBackColor = true;
            this.btnCommentSelected.Click += new System.EventHandler(this.btnFavSelected_Click);
            // 
            // btnFavAll
            // 
            this.btnFavAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFavAll.Location = new System.Drawing.Point(191, 47);
            this.btnFavAll.Name = "btnFavAll";
            this.btnFavAll.Size = new System.Drawing.Size(135, 31);
            this.btnFavAll.TabIndex = 1;
            this.btnFavAll.Text = "Fav All";
            this.btnFavAll.UseVisualStyleBackColor = true;
            this.btnFavAll.Click += new System.EventHandler(this.btnFavAll_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.18116F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.81884F));
            this.tableLayoutPanel2.Controls.Add(this.cmbUsers, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbComments, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmdUpdateFavDB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmdSearch, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmdFavsToDelete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtDeleteMaxDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdDeleteFavs, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(338, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(552, 150);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cmbUsers
            // 
            this.cmbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(3, 70);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(133, 21);
            this.cmbUsers.TabIndex = 3;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // cmbComments
            // 
            this.cmbComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComments.FormattingEnabled = true;
            this.cmbComments.Location = new System.Drawing.Point(142, 70);
            this.cmbComments.Name = "cmbComments";
            this.cmbComments.Size = new System.Drawing.Size(407, 21);
            this.cmbComments.TabIndex = 0;
            // 
            // cmdUpdateFavDB
            // 
            this.cmdUpdateFavDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdUpdateFavDB.Location = new System.Drawing.Point(3, 36);
            this.cmdUpdateFavDB.Name = "cmdUpdateFavDB";
            this.cmdUpdateFavDB.Size = new System.Drawing.Size(133, 28);
            this.cmdUpdateFavDB.TabIndex = 4;
            this.cmdUpdateFavDB.Text = "Update Fav DB";
            this.cmdUpdateFavDB.UseVisualStyleBackColor = true;
            this.cmdUpdateFavDB.Click += new System.EventHandler(this.cmdUpdateFavDB_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(142, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(387, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSearch.Location = new System.Drawing.Point(3, 114);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(133, 33);
            this.cmdSearch.TabIndex = 6;
            this.cmdSearch.Text = "Search Grid";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkUseLocalFavs);
            this.panel1.Controls.Add(this.cmdHideGavnoColumns);
            this.panel1.Controls.Add(this.cmdDeleteRows);
            this.panel1.Controls.Add(this.cmdHideColums);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnProceed);
            this.panel1.Location = new System.Drawing.Point(896, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 150);
            this.panel1.TabIndex = 10;
            // 
            // chkUseLocalFavs
            // 
            this.chkUseLocalFavs.AutoSize = true;
            this.chkUseLocalFavs.Location = new System.Drawing.Point(0, 129);
            this.chkUseLocalFavs.Name = "chkUseLocalFavs";
            this.chkUseLocalFavs.Size = new System.Drawing.Size(141, 17);
            this.chkUseLocalFavs.TabIndex = 13;
            this.chkUseLocalFavs.Text = "Use Local Favs from DB";
            this.chkUseLocalFavs.UseVisualStyleBackColor = true;
            // 
            // cmdHideGavnoColumns
            // 
            this.cmdHideGavnoColumns.Location = new System.Drawing.Point(0, 98);
            this.cmdHideGavnoColumns.Name = "cmdHideGavnoColumns";
            this.cmdHideGavnoColumns.Size = new System.Drawing.Size(155, 23);
            this.cmdHideGavnoColumns.TabIndex = 12;
            this.cmdHideGavnoColumns.Text = "Display Key Columns";
            this.cmdHideGavnoColumns.UseVisualStyleBackColor = true;
            this.cmdHideGavnoColumns.Click += new System.EventHandler(this.cmdHideGavnoColumns_Click);
            // 
            // cmdDeleteRows
            // 
            this.cmdDeleteRows.Location = new System.Drawing.Point(0, 75);
            this.cmdDeleteRows.Name = "cmdDeleteRows";
            this.cmdDeleteRows.Size = new System.Drawing.Size(155, 23);
            this.cmdDeleteRows.TabIndex = 11;
            this.cmdDeleteRows.Text = "Delete Row(s)";
            this.cmdDeleteRows.UseVisualStyleBackColor = true;
            this.cmdDeleteRows.Click += new System.EventHandler(this.cmdDeleteRows_Click);
            // 
            // cmdHideColums
            // 
            this.cmdHideColums.Location = new System.Drawing.Point(0, 51);
            this.cmdHideColums.Name = "cmdHideColums";
            this.cmdHideColums.Size = new System.Drawing.Size(155, 23);
            this.cmdHideColums.TabIndex = 10;
            this.cmdHideColums.Text = "Hide Empty Columns";
            this.cmdHideColums.UseVisualStyleBackColor = true;
            this.cmdHideColums.Click += new System.EventHandler(this.cmdHideColums_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1. Get Contact Photos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(0, 27);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(155, 23);
            this.btnProceed.TabIndex = 9;
            this.btnProceed.Text = "2. Comment/Favorite";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 739);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 11;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(896, 739);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(0, 13);
            this.lblAuthor.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.tblMain.SetColumnSpan(this.progressBar1, 4);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 762);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1060, 15);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // lblRandomComment
            // 
            this.lblRandomComment.AutoSize = true;
            this.lblRandomComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomComment.Location = new System.Drawing.Point(338, 739);
            this.lblRandomComment.Name = "lblRandomComment";
            this.lblRandomComment.Size = new System.Drawing.Size(552, 20);
            this.lblRandomComment.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // itemDelete
            // 
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(133, 22);
            this.itemDelete.Text = "Delete Row";
            // 
            // cmdFavsToDelete
            // 
            this.cmdFavsToDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdFavsToDelete.Location = new System.Drawing.Point(3, 3);
            this.cmdFavsToDelete.Name = "cmdFavsToDelete";
            this.cmdFavsToDelete.Size = new System.Drawing.Size(133, 27);
            this.cmdFavsToDelete.TabIndex = 7;
            this.cmdFavsToDelete.Text = "Load Favs To Delete";
            this.cmdFavsToDelete.UseVisualStyleBackColor = true;
            this.cmdFavsToDelete.Click += new System.EventHandler(this.cmdFavsToDelete_Click);
            // 
            // dtDeleteMaxDate
            // 
            this.dtDeleteMaxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDeleteMaxDate.Location = new System.Drawing.Point(142, 3);
            this.dtDeleteMaxDate.Name = "dtDeleteMaxDate";
            this.dtDeleteMaxDate.Size = new System.Drawing.Size(407, 20);
            this.dtDeleteMaxDate.TabIndex = 8;
            // 
            // cmdDeleteFavs
            // 
            this.cmdDeleteFavs.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdDeleteFavs.Location = new System.Drawing.Point(142, 36);
            this.cmdDeleteFavs.Name = "cmdDeleteFavs";
            this.cmdDeleteFavs.Size = new System.Drawing.Size(105, 28);
            this.cmdDeleteFavs.TabIndex = 9;
            this.cmdDeleteFavs.Text = "Delete Favs";
            this.cmdDeleteFavs.UseVisualStyleBackColor = true;
            this.cmdDeleteFavs.Click += new System.EventHandler(this.cmdDeleteFavs_Click);
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 780);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactList";
            this.Text = "ContactList";
            this.Load += new System.EventHandler(this.ContactList_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.DataGridView grdFavs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnPopulateDefComments;
        private System.Windows.Forms.Button btnFavAll;
        private System.Windows.Forms.ComboBox cmbComments;
        private System.Windows.Forms.Button btnLastPhotofavs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button cmd10PhotoFavs;
        private System.Windows.Forms.Label lblRandomComment;
        private System.Windows.Forms.Button cmdHideColums;
        private System.Windows.Forms.Button btnLastPhotoComments;
        private System.Windows.Forms.Button btnCommentSelected;
        private System.Windows.Forms.Button cmdDeleteRows;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.Button cmdUpdateFavDB;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Button cmdHideGavnoColumns;
        private System.Windows.Forms.ComboBox cmdMyPhotos;
        private System.Windows.Forms.CheckBox chkUseLocalFavs;
        private System.Windows.Forms.Button cmdFavsToDelete;
        private System.Windows.Forms.DateTimePicker dtDeleteMaxDate;
        private System.Windows.Forms.Button cmdDeleteFavs;


    }
}