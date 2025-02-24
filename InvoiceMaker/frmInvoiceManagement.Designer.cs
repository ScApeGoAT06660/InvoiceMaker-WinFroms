namespace InvoiceMaker
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCRUD = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInvoices)).BeginInit();
            this.pnlLeftPanel.SuspendLayout();
            this.gbCRUD.SuspendLayout();
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
            this.pnlLeftPanel.Controls.Add(this.groupBox2);
            this.pnlLeftPanel.Controls.Add(this.gbCRUD);
            this.pnlLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeftPanel.Name = "pnlLeftPanel";
            this.pnlLeftPanel.Size = new System.Drawing.Size(150, 546);
            this.pnlLeftPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(150, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbCRUD
            // 
            this.gbCRUD.Controls.Add(this.btnDelete);
            this.gbCRUD.Controls.Add(this.btnEdit);
            this.gbCRUD.Controls.Add(this.btnAdd);
            this.gbCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCRUD.Location = new System.Drawing.Point(0, 0);
            this.gbCRUD.Margin = new System.Windows.Forms.Padding(2);
            this.gbCRUD.Name = "gbCRUD";
            this.gbCRUD.Padding = new System.Windows.Forms.Padding(2);
            this.gbCRUD.Size = new System.Drawing.Size(150, 136);
            this.gbCRUD.TabIndex = 2;
            this.gbCRUD.TabStop = false;
            this.gbCRUD.Text = "Edytuj";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(20, 92);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Location = new System.Drawing.Point(20, 58);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(20, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            this.gbCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRightPanel;
        private System.Windows.Forms.DataGridView dgwInvoices;
        private System.Windows.Forms.Panel pnlLeftPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbCRUD;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}

