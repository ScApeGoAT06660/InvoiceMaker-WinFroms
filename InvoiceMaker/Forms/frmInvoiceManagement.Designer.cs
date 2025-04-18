﻿namespace InvoiceMaker
{
    partial class frmInvoiceManagement
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRightPanel = new System.Windows.Forms.Panel();
            this.dgwInvoices = new System.Windows.Forms.DataGridView();
            this.pnlLeftPanel = new System.Windows.Forms.Panel();
            this.gbUserOptions = new System.Windows.Forms.GroupBox();
            this.btnSwitchUser = new System.Windows.Forms.Button();
            this.gbOtherOptions = new System.Windows.Forms.GroupBox();
            this.btnManageBuyers = new System.Windows.Forms.Button();
            this.gbManageCRUD = new System.Windows.Forms.GroupBox();
            this.btnManageDelete = new System.Windows.Forms.Button();
            this.btnManageEdit = new System.Windows.Forms.Button();
            this.btnManageAdd = new System.Windows.Forms.Button();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.cbSortOptions = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.pnlRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices)).BeginInit();
            this.pnlLeftPanel.SuspendLayout();
            this.gbUserOptions.SuspendLayout();
            this.gbOtherOptions.SuspendLayout();
            this.gbManageCRUD.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlRightPanel);
            this.pnlMain.Controls.Add(this.pnlLeftPanel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(907, 546);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlRightPanel
            // 
            this.pnlRightPanel.Controls.Add(this.dgwInvoices);
            this.pnlRightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightPanel.Location = new System.Drawing.Point(150, 0);
            this.pnlRightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRightPanel.Name = "pnlRightPanel";
            this.pnlRightPanel.Size = new System.Drawing.Size(757, 546);
            this.pnlRightPanel.TabIndex = 1;
            // 
            // dgwInvoices
            // 
            this.dgwInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwInvoices.Location = new System.Drawing.Point(0, 0);
            this.dgwInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.dgwInvoices.Name = "dgwInvoices";
            this.dgwInvoices.RowHeadersWidth = 51;
            this.dgwInvoices.RowTemplate.Height = 24;
            this.dgwInvoices.Size = new System.Drawing.Size(757, 546);
            this.dgwInvoices.TabIndex = 0;
            // 
            // pnlLeftPanel
            // 
            this.pnlLeftPanel.Controls.Add(this.gbSort);
            this.pnlLeftPanel.Controls.Add(this.gbUserOptions);
            this.pnlLeftPanel.Controls.Add(this.gbOtherOptions);
            this.pnlLeftPanel.Controls.Add(this.gbManageCRUD);
            this.pnlLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeftPanel.Name = "pnlLeftPanel";
            this.pnlLeftPanel.Size = new System.Drawing.Size(150, 546);
            this.pnlLeftPanel.TabIndex = 0;
            // 
            // gbUserOptions
            // 
            this.gbUserOptions.Controls.Add(this.btnSwitchUser);
            this.gbUserOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUserOptions.Location = new System.Drawing.Point(0, 206);
            this.gbUserOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbUserOptions.Name = "gbUserOptions";
            this.gbUserOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbUserOptions.Size = new System.Drawing.Size(150, 70);
            this.gbUserOptions.TabIndex = 4;
            this.gbUserOptions.TabStop = false;
            this.gbUserOptions.Text = "Użytkownik";
            // 
            // btnSwitchUser
            // 
            this.btnSwitchUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSwitchUser.Location = new System.Drawing.Point(20, 27);
            this.btnSwitchUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitchUser.Name = "btnSwitchUser";
            this.btnSwitchUser.Size = new System.Drawing.Size(110, 30);
            this.btnSwitchUser.TabIndex = 3;
            this.btnSwitchUser.Text = "Zmień użytkownika";
            this.btnSwitchUser.UseVisualStyleBackColor = true;
            this.btnSwitchUser.Click += new System.EventHandler(this.btnSwitchUser_Click);
            // 
            // gbOtherOptions
            // 
            this.gbOtherOptions.Controls.Add(this.btnManageBuyers);
            this.gbOtherOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOtherOptions.Location = new System.Drawing.Point(0, 136);
            this.gbOtherOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbOtherOptions.Name = "gbOtherOptions";
            this.gbOtherOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbOtherOptions.Size = new System.Drawing.Size(150, 70);
            this.gbOtherOptions.TabIndex = 3;
            this.gbOtherOptions.TabStop = false;
            this.gbOtherOptions.Text = "Inne opcje";
            // 
            // btnManageBuyers
            // 
            this.btnManageBuyers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageBuyers.Location = new System.Drawing.Point(20, 27);
            this.btnManageBuyers.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageBuyers.Name = "btnManageBuyers";
            this.btnManageBuyers.Size = new System.Drawing.Size(110, 30);
            this.btnManageBuyers.TabIndex = 3;
            this.btnManageBuyers.Text = "Kontrahenci";
            this.btnManageBuyers.UseVisualStyleBackColor = true;
            this.btnManageBuyers.Click += new System.EventHandler(this.btnManageBuyers_Click);
            // 
            // gbManageCRUD
            // 
            this.gbManageCRUD.Controls.Add(this.btnManageDelete);
            this.gbManageCRUD.Controls.Add(this.btnManageEdit);
            this.gbManageCRUD.Controls.Add(this.btnManageAdd);
            this.gbManageCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbManageCRUD.Location = new System.Drawing.Point(0, 0);
            this.gbManageCRUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.gbManageCRUD.Name = "gbManageCRUD";
            this.gbManageCRUD.Padding = new System.Windows.Forms.Padding(2);
            this.gbManageCRUD.Size = new System.Drawing.Size(150, 136);
            this.gbManageCRUD.TabIndex = 2;
            this.gbManageCRUD.TabStop = false;
            this.gbManageCRUD.Text = "Edytuj";
            // 
            // btnManageDelete
            // 
            this.btnManageDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageDelete.Location = new System.Drawing.Point(20, 92);
            this.btnManageDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageDelete.Name = "btnManageDelete";
            this.btnManageDelete.Size = new System.Drawing.Size(110, 30);
            this.btnManageDelete.TabIndex = 2;
            this.btnManageDelete.Text = "Usuń";
            this.btnManageDelete.UseVisualStyleBackColor = true;
            this.btnManageDelete.Click += new System.EventHandler(this.btnManageDelete_Click);
            // 
            // btnManageEdit
            // 
            this.btnManageEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageEdit.Location = new System.Drawing.Point(20, 58);
            this.btnManageEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageEdit.Name = "btnManageEdit";
            this.btnManageEdit.Size = new System.Drawing.Size(110, 30);
            this.btnManageEdit.TabIndex = 1;
            this.btnManageEdit.Text = "Edytuj";
            this.btnManageEdit.UseVisualStyleBackColor = true;
            this.btnManageEdit.Click += new System.EventHandler(this.btnManageEdit_Click);
            // 
            // btnManageAdd
            // 
            this.btnManageAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageAdd.Location = new System.Drawing.Point(20, 24);
            this.btnManageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAdd.Name = "btnManageAdd";
            this.btnManageAdd.Size = new System.Drawing.Size(110, 30);
            this.btnManageAdd.TabIndex = 0;
            this.btnManageAdd.Text = "Dodaj";
            this.btnManageAdd.UseVisualStyleBackColor = true;
            this.btnManageAdd.Click += new System.EventHandler(this.btnManageAdd_Click);
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.cbSortOptions);
            this.gbSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSort.Location = new System.Drawing.Point(0, 276);
            this.gbSort.Margin = new System.Windows.Forms.Padding(2);
            this.gbSort.Name = "gbSort";
            this.gbSort.Padding = new System.Windows.Forms.Padding(2);
            this.gbSort.Size = new System.Drawing.Size(150, 73);
            this.gbSort.TabIndex = 5;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Sortuj";
            // 
            // cbSortOptions
            // 
            this.cbSortOptions.FormattingEnabled = true;
            this.cbSortOptions.Items.AddRange(new object[] {
            "data wystawienia",
            "data sprzedaży",
            "kontrahent",
            "numer",
            "id"});
            this.cbSortOptions.Location = new System.Drawing.Point(12, 29);
            this.cbSortOptions.Name = "cbSortOptions";
            this.cbSortOptions.Size = new System.Drawing.Size(121, 21);
            this.cbSortOptions.TabIndex = 0;
            this.cbSortOptions.SelectedIndexChanged += new System.EventHandler(this.cbSortOptions_SelectedIndexChanged);
            // 
            // frmInvoiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 546);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoiceManagement";
            this.Text = "Zarządzaj fakturami";
            this.pnlMain.ResumeLayout(false);
            this.pnlRightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices)).EndInit();
            this.pnlLeftPanel.ResumeLayout(false);
            this.gbUserOptions.ResumeLayout(false);
            this.gbOtherOptions.ResumeLayout(false);
            this.gbManageCRUD.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRightPanel;
        private System.Windows.Forms.DataGridView dgwInvoices;
        private System.Windows.Forms.Panel pnlLeftPanel;
        private System.Windows.Forms.GroupBox gbOtherOptions;
        private System.Windows.Forms.GroupBox gbManageCRUD;
        private System.Windows.Forms.Button btnManageDelete;
        private System.Windows.Forms.Button btnManageEdit;
        private System.Windows.Forms.Button btnManageAdd;
        private System.Windows.Forms.GroupBox gbUserOptions;
        private System.Windows.Forms.Button btnSwitchUser;
        private System.Windows.Forms.Button btnManageBuyers;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.ComboBox cbSortOptions;
    }
}

