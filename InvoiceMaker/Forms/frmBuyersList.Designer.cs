namespace InvoiceMaker.Forms
{
    partial class frmBuyersList
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
            this.dgwBuyersList = new System.Windows.Forms.DataGridView();
            this.btnBuyersSelect = new System.Windows.Forms.Button();
            this.btnBuyersEdit = new System.Windows.Forms.Button();
            this.btnBuyersDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBuyersList
            // 
            this.dgwBuyersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBuyersList.Location = new System.Drawing.Point(93, 12);
            this.dgwBuyersList.Name = "dgwBuyersList";
            this.dgwBuyersList.RowHeadersWidth = 45;
            this.dgwBuyersList.Size = new System.Drawing.Size(896, 605);
            this.dgwBuyersList.TabIndex = 0;
            this.dgwBuyersList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBuyersList_CellDoubleClick);
            // 
            // btnBuyersSelect
            // 
            this.btnBuyersSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuyersSelect.Location = new System.Drawing.Point(12, 12);
            this.btnBuyersSelect.Name = "btnBuyersSelect";
            this.btnBuyersSelect.Size = new System.Drawing.Size(75, 23);
            this.btnBuyersSelect.TabIndex = 16;
            this.btnBuyersSelect.Text = "Wybierz";
            this.btnBuyersSelect.UseVisualStyleBackColor = true;
            this.btnBuyersSelect.Click += new System.EventHandler(this.btnBuyersSelect_Click);
            // 
            // btnBuyersEdit
            // 
            this.btnBuyersEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuyersEdit.Location = new System.Drawing.Point(12, 41);
            this.btnBuyersEdit.Name = "btnBuyersEdit";
            this.btnBuyersEdit.Size = new System.Drawing.Size(75, 23);
            this.btnBuyersEdit.TabIndex = 17;
            this.btnBuyersEdit.Text = "Edytuj";
            this.btnBuyersEdit.UseVisualStyleBackColor = true;
            this.btnBuyersEdit.Click += new System.EventHandler(this.btnBuyersEdit_Click);
            // 
            // btnBuyersDelete
            // 
            this.btnBuyersDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuyersDelete.Location = new System.Drawing.Point(12, 70);
            this.btnBuyersDelete.Name = "btnBuyersDelete";
            this.btnBuyersDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBuyersDelete.TabIndex = 18;
            this.btnBuyersDelete.Text = "Usuń";
            this.btnBuyersDelete.UseVisualStyleBackColor = true;
            this.btnBuyersDelete.Click += new System.EventHandler(this.btnBuyersDelete_Click);
            // 
            // frmBuyersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 629);
            this.Controls.Add(this.btnBuyersDelete);
            this.Controls.Add(this.btnBuyersEdit);
            this.Controls.Add(this.btnBuyersSelect);
            this.Controls.Add(this.dgwBuyersList);
            this.Name = "frmBuyersList";
            this.Text = "frmBuyersList";
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBuyersList;
        private System.Windows.Forms.Button btnBuyersSelect;
        private System.Windows.Forms.Button btnBuyersEdit;
        private System.Windows.Forms.Button btnBuyersDelete;
    }
}