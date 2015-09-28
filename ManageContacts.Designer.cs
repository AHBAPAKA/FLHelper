namespace SvetanFlickrApp
{

    partial class ManageContacts
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdFavs = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPopulateDefComments = new System.Windows.Forms.Button();
            this.btnFavAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdTestRCom = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnLastPhotofavs = new System.Windows.Forms.Button();
            this.cmbComments = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdHideColums = new System.Windows.Forms.Button();
            this.btnPolulateContactList = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblRandomComment = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.53147F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.46853F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(1066, 613);
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
            this.grdFavs.Location = new System.Drawing.Point(3, 109);
            this.grdFavs.Name = "grdFavs";
            this.grdFavs.Size = new System.Drawing.Size(1060, 460);
            this.grdFavs.TabIndex = 0;
            this.grdFavs.Visible = false;
            this.grdFavs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFavs_CellContentClick);
            this.grdFavs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFavs_CellValueChanged);
            this.grdFavs.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdFavs_ColumnHeaderMouseClick);
            this.grdFavs.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdFavs_ColumnHeaderMouseDoubleClick);
            this.grdFavs.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdFavs_EditingControlShowing);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05988F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.94012F));
            this.tableLayoutPanel1.Controls.Add(this.btnPopulateDefComments, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFavAll, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmdTestRCom, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnPopulateDefComments
            // 
            this.btnPopulateDefComments.Location = new System.Drawing.Point(68, 11);
            this.btnPopulateDefComments.Name = "btnPopulateDefComments";
            this.btnPopulateDefComments.Size = new System.Drawing.Size(172, 23);
            this.btnPopulateDefComments.TabIndex = 0;
            this.btnPopulateDefComments.Text = "Populate Default Comments";
            this.btnPopulateDefComments.UseVisualStyleBackColor = true;
            this.btnPopulateDefComments.Click += new System.EventHandler(this.btnPopulateDefComments_Click);
            // 
            // btnFavAll
            // 
            this.btnFavAll.Location = new System.Drawing.Point(68, 43);
            this.btnFavAll.Name = "btnFavAll";
            this.btnFavAll.Size = new System.Drawing.Size(172, 23);
            this.btnFavAll.TabIndex = 1;
            this.btnFavAll.Text = "Fav All";
            this.btnFavAll.UseVisualStyleBackColor = true;
            this.btnFavAll.Click += new System.EventHandler(this.btnFavAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(68, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // cmdTestRCom
            // 
            this.cmdTestRCom.Location = new System.Drawing.Point(3, 76);
            this.cmdTestRCom.Name = "cmdTestRCom";
            this.cmdTestRCom.Size = new System.Drawing.Size(59, 21);
            this.cmdTestRCom.TabIndex = 2;
            this.cmdTestRCom.Text = "Search";
            this.cmdTestRCom.UseVisualStyleBackColor = true;
            this.cmdTestRCom.Click += new System.EventHandler(this.cmdTestRCom_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.82927F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.17073F));
            this.tableLayoutPanel2.Controls.Add(this.cmbUsers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLastPhotofavs, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbComments, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUser, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(338, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(552, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // cmbUsers
            // 
            this.cmbUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(3, 53);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(142, 21);
            this.cmbUsers.TabIndex = 3;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // btnLastPhotofavs
            // 
            this.btnLastPhotofavs.Location = new System.Drawing.Point(151, 3);
            this.btnLastPhotofavs.Name = "btnLastPhotofavs";
            this.btnLastPhotofavs.Size = new System.Drawing.Size(172, 23);
            this.btnLastPhotofavs.TabIndex = 2;
            this.btnLastPhotofavs.Text = "Last Photo Favs";
            this.btnLastPhotofavs.UseVisualStyleBackColor = true;
            this.btnLastPhotofavs.Click += new System.EventHandler(this.btnLastPhotofavs_Click);
            // 
            // cmbComments
            // 
            this.cmbComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComments.FormattingEnabled = true;
            this.cmbComments.Location = new System.Drawing.Point(151, 53);
            this.cmbComments.Name = "cmbComments";
            this.cmbComments.Size = new System.Drawing.Size(398, 21);
            this.cmbComments.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 50);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Selected User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdHideColums);
            this.panel1.Controls.Add(this.btnPolulateContactList);
            this.panel1.Controls.Add(this.btnProceed);
            this.panel1.Location = new System.Drawing.Point(896, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 80);
            this.panel1.TabIndex = 10;
            // 
            // cmdHideColums
            // 
            this.cmdHideColums.Location = new System.Drawing.Point(3, 54);
            this.cmdHideColums.Name = "cmdHideColums";
            this.cmdHideColums.Size = new System.Drawing.Size(152, 23);
            this.cmdHideColums.TabIndex = 10;
            this.cmdHideColums.Text = "Hide Empty Columns";
            this.cmdHideColums.UseVisualStyleBackColor = true;
            this.cmdHideColums.Click += new System.EventHandler(this.cmdHideColums_Click);
            // 
            // btnPolulateContactList
            // 
            this.btnPolulateContactList.Location = new System.Drawing.Point(0, 3);
            this.btnPolulateContactList.Name = "btnPolulateContactList";
            this.btnPolulateContactList.Size = new System.Drawing.Size(155, 23);
            this.btnPolulateContactList.TabIndex = 1;
            this.btnPolulateContactList.Text = "Populate Contact List";
            this.btnPolulateContactList.UseVisualStyleBackColor = true;
            this.btnPolulateContactList.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(0, 26);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(155, 23);
            this.btnProceed.TabIndex = 9;
            this.btnProceed.Text = "Com/Fav";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(3, 572);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 11;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(896, 572);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(0, 13);
            this.lblAuthor.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.tblMain.SetColumnSpan(this.progressBar1, 4);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 595);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1060, 15);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // lblRandomComment
            // 
            this.lblRandomComment.AutoSize = true;
            this.lblRandomComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandomComment.Location = new System.Drawing.Point(338, 572);
            this.lblRandomComment.Name = "lblRandomComment";
            this.lblRandomComment.Size = new System.Drawing.Size(552, 20);
            this.lblRandomComment.TabIndex = 14;
            this.lblRandomComment.Text = "label1";
            // 
            // ManageContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 613);
            this.Controls.Add(this.tblMain);
            this.Name = "ManageContacts";
            this.Text = "ContactList";
            this.Load += new System.EventHandler(this.ContactList_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFavs)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.DataGridView grdFavs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPolulateContactList;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnPopulateDefComments;
        private System.Windows.Forms.Button btnFavAll;
        private System.Windows.Forms.ComboBox cmbComments;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLastPhotofavs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button cmdTestRCom;
        private System.Windows.Forms.Label lblRandomComment;
        private System.Windows.Forms.Button cmdHideColums;
        private System.Windows.Forms.TextBox txtSearch;


    }
}