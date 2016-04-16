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
            this.cmdMyPhotos = new System.Windows.Forms.ComboBox();
            this.btnLastPhotoComments = new System.Windows.Forms.Button();
            this.btnCommentSelected = new System.Windows.Forms.Button();
            this.btnFavAll = new System.Windows.Forms.Button();
            this.btnPopulateDefComments = new System.Windows.Forms.Button();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.radioComments = new System.Windows.Forms.RadioButton();
            this.radioFavs = new System.Windows.Forms.RadioButton();
            this.cmdProcessActiveContacts = new System.Windows.Forms.Button();
            this.cmd10PhotoFavs = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdUpdateFavDB = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cmdFavsToDelete = new System.Windows.Forms.Button();
            this.dtDeleteMaxDate = new System.Windows.Forms.DateTimePicker();
            this.cmdDeleteFavs = new System.Windows.Forms.Button();
            this.cmdShowUserStas = new System.Windows.Forms.Button();
            this.cmbComments = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkUsersFromDB = new System.Windows.Forms.CheckBox();
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
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.61351F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.1576F));
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
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.83436F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.16564F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1066, 693);
            this.tblMain.TabIndex = 6;
            this.tblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMain_Paint);
            // 
            // grdFavs
            // 
            this.grdFavs.AllowUserToAddRows = false;
            this.grdFavs.AllowUserToDeleteRows = false;
            this.grdFavs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdFavs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdFavs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.grdFavs, 4);
            this.grdFavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFavs.Location = new System.Drawing.Point(3, 191);
            this.grdFavs.Name = "grdFavs";
            this.grdFavs.Size = new System.Drawing.Size(1060, 458);
            this.grdFavs.TabIndex = 0;
            this.grdFavs.Visible = false;
            this.grdFavs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFavs_CellContentClick);
            this.grdFavs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFavs_CellValueChanged);
            this.grdFavs.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdFavs_ColumnHeaderMouseClick);
            this.grdFavs.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdFavs_EditingControlShowing);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.Controls.Add(this.btnLastPhotofavs, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmdMyPhotos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLastPhotoComments, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCommentSelected, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnFavAll, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPopulateDefComments, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdProcessActiveContacts, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmd10PhotoFavs, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 182);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnLastPhotofavs
            // 
            this.btnLastPhotofavs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastPhotofavs.Location = new System.Drawing.Point(3, 95);
            this.btnLastPhotofavs.Name = "btnLastPhotofavs";
            this.btnLastPhotofavs.Size = new System.Drawing.Size(182, 32);
            this.btnLastPhotofavs.TabIndex = 2;
            this.btnLastPhotofavs.Text = "Selected Photo Favs";
            this.btnLastPhotofavs.UseVisualStyleBackColor = true;
            this.btnLastPhotofavs.Click += new System.EventHandler(this.btnLastPhotofavs_Click);
            // 
            // cmdMyPhotos
            // 
            this.cmdMyPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdMyPhotos.FormattingEnabled = true;
            this.cmdMyPhotos.Location = new System.Drawing.Point(3, 52);
            this.cmdMyPhotos.Name = "cmdMyPhotos";
            this.cmdMyPhotos.Size = new System.Drawing.Size(182, 21);
            this.cmdMyPhotos.TabIndex = 5;
            this.cmdMyPhotos.SelectedIndexChanged += new System.EventHandler(this.cmdMyPhotos_SelectedIndexChanged);
            // 
            // btnLastPhotoComments
            // 
            this.btnLastPhotoComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastPhotoComments.Location = new System.Drawing.Point(3, 133);
            this.btnLastPhotoComments.Name = "btnLastPhotoComments";
            this.btnLastPhotoComments.Size = new System.Drawing.Size(182, 20);
            this.btnLastPhotoComments.TabIndex = 4;
            this.btnLastPhotoComments.Text = "Selected Photo Comments";
            this.btnLastPhotoComments.UseVisualStyleBackColor = true;
            this.btnLastPhotoComments.Click += new System.EventHandler(this.btnLastPhotoComments_Click);
            // 
            // btnCommentSelected
            // 
            this.btnCommentSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCommentSelected.Location = new System.Drawing.Point(191, 133);
            this.btnCommentSelected.Name = "btnCommentSelected";
            this.btnCommentSelected.Size = new System.Drawing.Size(135, 20);
            this.btnCommentSelected.TabIndex = 3;
            this.btnCommentSelected.Text = "Comment Selected";
            this.btnCommentSelected.UseVisualStyleBackColor = true;
            this.btnCommentSelected.Click += new System.EventHandler(this.btnFavSelected_Click);
            // 
            // btnFavAll
            // 
            this.btnFavAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFavAll.Location = new System.Drawing.Point(191, 95);
            this.btnFavAll.Name = "btnFavAll";
            this.btnFavAll.Size = new System.Drawing.Size(135, 32);
            this.btnFavAll.TabIndex = 1;
            this.btnFavAll.Text = "Fav All";
            this.btnFavAll.UseVisualStyleBackColor = true;
            this.btnFavAll.Click += new System.EventHandler(this.btnFavAll_Click);
            // 
            // btnPopulateDefComments
            // 
            this.btnPopulateDefComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPopulateDefComments.Location = new System.Drawing.Point(191, 52);
            this.btnPopulateDefComments.Name = "btnPopulateDefComments";
            this.btnPopulateDefComments.Size = new System.Drawing.Size(135, 37);
            this.btnPopulateDefComments.TabIndex = 0;
            this.btnPopulateDefComments.Text = "Update User Stats DB";
            this.btnPopulateDefComments.UseVisualStyleBackColor = true;
            this.btnPopulateDefComments.Click += new System.EventHandler(this.btnPopulateDefComments_Click);
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.radioComments);
            this.gbox1.Controls.Add(this.radioFavs);
            this.gbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox1.Location = new System.Drawing.Point(191, 11);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(135, 35);
            this.gbox1.TabIndex = 6;
            this.gbox1.TabStop = false;
            // 
            // radioComments
            // 
            this.radioComments.AutoSize = true;
            this.radioComments.Location = new System.Drawing.Point(59, 7);
            this.radioComments.Name = "radioComments";
            this.radioComments.Size = new System.Drawing.Size(74, 17);
            this.radioComments.TabIndex = 1;
            this.radioComments.TabStop = true;
            this.radioComments.Text = "Comments";
            this.radioComments.UseVisualStyleBackColor = true;
            this.radioComments.CheckedChanged += new System.EventHandler(this.radioComments_CheckedChanged);
            // 
            // radioFavs
            // 
            this.radioFavs.AutoSize = true;
            this.radioFavs.Location = new System.Drawing.Point(7, 7);
            this.radioFavs.Name = "radioFavs";
            this.radioFavs.Size = new System.Drawing.Size(48, 17);
            this.radioFavs.TabIndex = 0;
            this.radioFavs.TabStop = true;
            this.radioFavs.Text = "Favs";
            this.radioFavs.UseVisualStyleBackColor = true;
            // 
            // cmdProcessActiveContacts
            // 
            this.cmdProcessActiveContacts.Location = new System.Drawing.Point(3, 159);
            this.cmdProcessActiveContacts.Name = "cmdProcessActiveContacts";
            this.cmdProcessActiveContacts.Size = new System.Drawing.Size(181, 20);
            this.cmdProcessActiveContacts.TabIndex = 7;
            this.cmdProcessActiveContacts.Text = "Process Active Contacts";
            this.cmdProcessActiveContacts.UseVisualStyleBackColor = true;
            this.cmdProcessActiveContacts.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd10PhotoFavs
            // 
            this.cmd10PhotoFavs.Location = new System.Drawing.Point(3, 11);
            this.cmd10PhotoFavs.Name = "cmd10PhotoFavs";
            this.cmd10PhotoFavs.Size = new System.Drawing.Size(181, 28);
            this.cmd10PhotoFavs.TabIndex = 2;
            this.cmd10PhotoFavs.Text = "20 photo favs";
            this.cmd10PhotoFavs.UseVisualStyleBackColor = true;
            this.cmd10PhotoFavs.Click += new System.EventHandler(this.cmdTestRCom_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.09091F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.90909F));
            this.tableLayoutPanel2.Controls.Add(this.cmdUpdateFavDB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmdSearch, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmdFavsToDelete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtDeleteMaxDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdDeleteFavs, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmdShowUserStas, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbComments, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbUsers, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(340, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.97902F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.58042F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 180);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cmdUpdateFavDB
            // 
            this.cmdUpdateFavDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdUpdateFavDB.Location = new System.Drawing.Point(3, 44);
            this.cmdUpdateFavDB.Name = "cmdUpdateFavDB";
            this.cmdUpdateFavDB.Size = new System.Drawing.Size(121, 37);
            this.cmdUpdateFavDB.TabIndex = 4;
            this.cmdUpdateFavDB.Text = "Update Fav DB";
            this.cmdUpdateFavDB.UseVisualStyleBackColor = true;
            this.cmdUpdateFavDB.Click += new System.EventHandler(this.cmdUpdateFavDB_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 145);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(387, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSearch.Location = new System.Drawing.Point(3, 145);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(121, 32);
            this.cmdSearch.TabIndex = 6;
            this.cmdSearch.Text = "Search Grid";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cmdFavsToDelete
            // 
            this.cmdFavsToDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdFavsToDelete.Location = new System.Drawing.Point(3, 3);
            this.cmdFavsToDelete.Name = "cmdFavsToDelete";
            this.cmdFavsToDelete.Size = new System.Drawing.Size(121, 35);
            this.cmdFavsToDelete.TabIndex = 7;
            this.cmdFavsToDelete.Text = "Load Favs To Delete";
            this.cmdFavsToDelete.UseVisualStyleBackColor = true;
            this.cmdFavsToDelete.Click += new System.EventHandler(this.cmdFavsToDelete_Click);
            // 
            // dtDeleteMaxDate
            // 
            this.dtDeleteMaxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDeleteMaxDate.Location = new System.Drawing.Point(130, 3);
            this.dtDeleteMaxDate.Name = "dtDeleteMaxDate";
            this.dtDeleteMaxDate.Size = new System.Drawing.Size(417, 20);
            this.dtDeleteMaxDate.TabIndex = 8;
            // 
            // cmdDeleteFavs
            // 
            this.cmdDeleteFavs.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdDeleteFavs.Location = new System.Drawing.Point(130, 44);
            this.cmdDeleteFavs.Name = "cmdDeleteFavs";
            this.cmdDeleteFavs.Size = new System.Drawing.Size(105, 37);
            this.cmdDeleteFavs.TabIndex = 9;
            this.cmdDeleteFavs.Text = "Delete Favs";
            this.cmdDeleteFavs.UseVisualStyleBackColor = true;
            this.cmdDeleteFavs.Click += new System.EventHandler(this.cmdDeleteFavs_Click);
            // 
            // cmdShowUserStas
            // 
            this.cmdShowUserStas.Location = new System.Drawing.Point(3, 87);
            this.cmdShowUserStas.Name = "cmdShowUserStas";
            this.cmdShowUserStas.Size = new System.Drawing.Size(121, 24);
            this.cmdShowUserStas.TabIndex = 8;
            this.cmdShowUserStas.Text = "Show User Stats";
            this.cmdShowUserStas.UseVisualStyleBackColor = true;
            this.cmdShowUserStas.Click += new System.EventHandler(this.cmdShowUserStas_Click);
            // 
            // cmbComments
            // 
            this.cmbComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComments.FormattingEnabled = true;
            this.cmbComments.Location = new System.Drawing.Point(130, 87);
            this.cmbComments.Name = "cmbComments";
            this.cmbComments.Size = new System.Drawing.Size(417, 21);
            this.cmbComments.TabIndex = 0;
            // 
            // cmbUsers
            // 
            this.cmbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(130, 117);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(417, 21);
            this.cmbUsers.TabIndex = 3;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkUsersFromDB);
            this.panel1.Controls.Add(this.chkUseLocalFavs);
            this.panel1.Controls.Add(this.cmdHideGavnoColumns);
            this.panel1.Controls.Add(this.cmdDeleteRows);
            this.panel1.Controls.Add(this.cmdHideColums);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnProceed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(896, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 182);
            this.panel1.TabIndex = 10;
            // 
            // chkUsersFromDB
            // 
            this.chkUsersFromDB.AutoSize = true;
            this.chkUsersFromDB.Location = new System.Drawing.Point(3, 148);
            this.chkUsersFromDB.Name = "chkUsersFromDB";
            this.chkUsersFromDB.Size = new System.Drawing.Size(131, 17);
            this.chkUsersFromDB.TabIndex = 14;
            this.chkUsersFromDB.Text = "Use Contacts from DB";
            this.chkUsersFromDB.UseVisualStyleBackColor = true;
            // 
            // chkUseLocalFavs
            // 
            this.chkUseLocalFavs.AutoSize = true;
            this.chkUseLocalFavs.Location = new System.Drawing.Point(3, 129);
            this.chkUseLocalFavs.Name = "chkUseLocalFavs";
            this.chkUseLocalFavs.Size = new System.Drawing.Size(141, 17);
            this.chkUseLocalFavs.TabIndex = 13;
            this.chkUseLocalFavs.Text = "Use Local Favs from DB";
            this.chkUseLocalFavs.UseVisualStyleBackColor = true;
            this.chkUseLocalFavs.CheckedChanged += new System.EventHandler(this.chkUseLocalFavs_CheckedChanged);
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
            this.lblCount.Location = new System.Drawing.Point(3, 652);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 11;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(896, 652);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(0, 13);
            this.lblAuthor.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.tblMain.SetColumnSpan(this.progressBar1, 4);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 675);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1060, 15);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // lblRandomComment
            // 
            this.lblRandomComment.AutoSize = true;
            this.lblRandomComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomComment.Location = new System.Drawing.Point(340, 652);
            this.lblRandomComment.Name = "lblRandomComment";
            this.lblRandomComment.Size = new System.Drawing.Size(550, 20);
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
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 693);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactList";
            this.Text = "ContactList";
            this.Load += new System.EventHandler(this.ContactList_Load);
            this.Shown += new System.EventHandler(this.ContactList_Shown);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
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
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnPopulateDefComments;
        private System.Windows.Forms.ComboBox cmbComments;
        private System.Windows.Forms.Button btnLastPhotofavs;
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
        private System.Windows.Forms.Button btnFavAll;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.RadioButton radioComments;
        private System.Windows.Forms.RadioButton radioFavs;
        public System.Windows.Forms.Label lblCount;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cmdProcessActiveContacts;
        private System.Windows.Forms.Button cmdShowUserStas;
        private System.Windows.Forms.CheckBox chkUsersFromDB;
        }
}