namespace InvoiceMaker
{
    partial class frmLogIn
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
            this.lblLogInUsers = new System.Windows.Forms.Label();
            this.btnLogInAdd = new System.Windows.Forms.Button();
            this.btnLogInEdit = new System.Windows.Forms.Button();
            this.btnLogInDelete = new System.Windows.Forms.Button();
            this.btnLogInChoose = new System.Windows.Forms.Button();
            this.dgwLogInUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLogInUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogInUsers
            // 
            this.lblLogInUsers.AutoSize = true;
            this.lblLogInUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogInUsers.Location = new System.Drawing.Point(8, 9);
            this.lblLogInUsers.Name = "lblLogInUsers";
            this.lblLogInUsers.Size = new System.Drawing.Size(190, 20);
            this.lblLogInUsers.TabIndex = 1;
            this.lblLogInUsers.Text = "Wybierz użytkownika:";
            // 
            // btnLogInAdd
            // 
            this.btnLogInAdd.Location = new System.Drawing.Point(338, 30);
            this.btnLogInAdd.Name = "btnLogInAdd";
            this.btnLogInAdd.Size = new System.Drawing.Size(75, 23);
            this.btnLogInAdd.TabIndex = 2;
            this.btnLogInAdd.Text = "Dodaj";
            this.btnLogInAdd.UseVisualStyleBackColor = true;
            this.btnLogInAdd.Click += new System.EventHandler(this.btnLogInAdd_Click);
            // 
            // btnLogInEdit
            // 
            this.btnLogInEdit.Location = new System.Drawing.Point(338, 60);
            this.btnLogInEdit.Name = "btnLogInEdit";
            this.btnLogInEdit.Size = new System.Drawing.Size(75, 23);
            this.btnLogInEdit.TabIndex = 3;
            this.btnLogInEdit.Text = "Edytuj";
            this.btnLogInEdit.UseVisualStyleBackColor = true;
            this.btnLogInEdit.Click += new System.EventHandler(this.btnLogInEdit_Click);
            // 
            // btnLogInDelete
            // 
            this.btnLogInDelete.Location = new System.Drawing.Point(338, 90);
            this.btnLogInDelete.Name = "btnLogInDelete";
            this.btnLogInDelete.Size = new System.Drawing.Size(75, 23);
            this.btnLogInDelete.TabIndex = 4;
            this.btnLogInDelete.Text = "Usuń";
            this.btnLogInDelete.UseVisualStyleBackColor = true;
            this.btnLogInDelete.Click += new System.EventHandler(this.btnLogInDelete_Click);
            // 
            // btnLogInChoose
            // 
            this.btnLogInChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogInChoose.Location = new System.Drawing.Point(12, 256);
            this.btnLogInChoose.Name = "btnLogInChoose";
            this.btnLogInChoose.Size = new System.Drawing.Size(91, 30);
            this.btnLogInChoose.TabIndex = 5;
            this.btnLogInChoose.Text = "Wybierz";
            this.btnLogInChoose.UseVisualStyleBackColor = true;
            this.btnLogInChoose.Click += new System.EventHandler(this.btnLogInChoose_Click);
            // 
            // dgwLogInUsers
            // 
            this.dgwLogInUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLogInUsers.Location = new System.Drawing.Point(12, 32);
            this.dgwLogInUsers.Name = "dgwLogInUsers";
            this.dgwLogInUsers.RowHeadersWidth = 45;
            this.dgwLogInUsers.Size = new System.Drawing.Size(320, 214);
            this.dgwLogInUsers.TabIndex = 6;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 294);
            this.Controls.Add(this.dgwLogInUsers);
            this.Controls.Add(this.btnLogInChoose);
            this.Controls.Add(this.btnLogInDelete);
            this.Controls.Add(this.btnLogInEdit);
            this.Controls.Add(this.btnLogInAdd);
            this.Controls.Add(this.lblLogInUsers);
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLogInUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogInUsers;
        private System.Windows.Forms.Button btnLogInAdd;
        private System.Windows.Forms.Button btnLogInEdit;
        private System.Windows.Forms.Button btnLogInDelete;
        private System.Windows.Forms.Button btnLogInChoose;
        private System.Windows.Forms.DataGridView dgwLogInUsers;
    }
}