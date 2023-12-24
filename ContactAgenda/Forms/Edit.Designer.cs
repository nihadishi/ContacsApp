namespace ContactAgenda
{
    partial class Edit
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
            LblPhoneNumber = new System.Windows.Forms.Label();
            BtnCancel = new System.Windows.Forms.Button();
            TxtBxWorkNumber = new System.Windows.Forms.MaskedTextBox();
            TlpMain = new System.Windows.Forms.TableLayoutPanel();
            LblName = new System.Windows.Forms.Label();
            LblLastName = new System.Windows.Forms.Label();
            LblAddress = new System.Windows.Forms.Label();
            LblWorkNumber = new System.Windows.Forms.Label();
            BtnSave = new System.Windows.Forms.Button();
            TxtBxName = new System.Windows.Forms.TextBox();
            TxtBxLastName = new System.Windows.Forms.TextBox();
            TxtBxAddress = new System.Windows.Forms.TextBox();
            TxtBxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            TlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // LblPhoneNumber
            // 
            LblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblPhoneNumber.AutoSize = true;
            LblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblPhoneNumber.Location = new System.Drawing.Point(280, 224);
            LblPhoneNumber.Name = "LblPhoneNumber";
            LblPhoneNumber.Size = new System.Drawing.Size(117, 21);
            LblPhoneNumber.TabIndex = 3;
            LblPhoneNumber.Text = "Phone number";
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCancel.Location = new System.Drawing.Point(403, 339);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new System.Drawing.Size(274, 33);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TxtBxWorkNumber
            // 
            TxtBxWorkNumber.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxWorkNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxWorkNumber.Location = new System.Drawing.Point(403, 283);
            TxtBxWorkNumber.Mask = "(999) 000-0000";
            TxtBxWorkNumber.Name = "TxtBxWorkNumber";
            TxtBxWorkNumber.Size = new System.Drawing.Size(274, 29);
            TxtBxWorkNumber.TabIndex = 11;
            // 
            // TlpMain
            // 
            TlpMain.ColumnCount = 4;
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpMain.Controls.Add(LblName, 1, 1);
            TlpMain.Controls.Add(LblLastName, 1, 2);
            TlpMain.Controls.Add(LblAddress, 1, 3);
            TlpMain.Controls.Add(LblPhoneNumber, 1, 4);
            TlpMain.Controls.Add(LblWorkNumber, 1, 5);
            TlpMain.Controls.Add(BtnSave, 1, 6);
            TlpMain.Controls.Add(BtnCancel, 2, 6);
            TlpMain.Controls.Add(TxtBxName, 2, 1);
            TlpMain.Controls.Add(TxtBxLastName, 2, 2);
            TlpMain.Controls.Add(TxtBxAddress, 2, 3);
            TlpMain.Controls.Add(TxtBxPhoneNumber, 2, 4);
            TlpMain.Controls.Add(TxtBxWorkNumber, 2, 5);
            TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            TlpMain.Location = new System.Drawing.Point(0, 0);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 8;
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            TlpMain.Size = new System.Drawing.Size(800, 450);
            TlpMain.TabIndex = 1;
            // 
            // LblName
            // 
            LblName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblName.AutoSize = true;
            LblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblName.Location = new System.Drawing.Point(344, 56);
            LblName.Name = "LblName";
            LblName.Size = new System.Drawing.Size(53, 21);
            LblName.TabIndex = 0;
            LblName.Text = "Name";
            // 
            // LblLastName
            // 
            LblLastName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblLastName.AutoSize = true;
            LblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblLastName.Location = new System.Drawing.Point(314, 112);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new System.Drawing.Size(83, 21);
            LblLastName.TabIndex = 1;
            LblLastName.Text = "Last name";
            // 
            // LblAddress
            // 
            LblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblAddress.AutoSize = true;
            LblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblAddress.Location = new System.Drawing.Point(327, 168);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new System.Drawing.Size(70, 21);
            LblAddress.TabIndex = 2;
            LblAddress.Text = "Address";
            // 
            // LblWorkNumber
            // 
            LblWorkNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblWorkNumber.AutoSize = true;
            LblWorkNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblWorkNumber.Location = new System.Drawing.Point(287, 280);
            LblWorkNumber.Name = "LblWorkNumber";
            LblWorkNumber.Size = new System.Drawing.Size(110, 21);
            LblWorkNumber.TabIndex = 4;
            LblWorkNumber.Text = "Work number";
            // 
            // BtnSave
            // 
            BtnSave.BackColor = System.Drawing.Color.LightGreen;
            BtnSave.Dock = System.Windows.Forms.DockStyle.Top;
            BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnSave.Location = new System.Drawing.Point(123, 339);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new System.Drawing.Size(274, 33);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtBxName
            // 
            TxtBxName.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxName.Location = new System.Drawing.Point(403, 59);
            TxtBxName.Name = "TxtBxName";
            TxtBxName.Size = new System.Drawing.Size(274, 29);
            TxtBxName.TabIndex = 7;
            // 
            // TxtBxLastName
            // 
            TxtBxLastName.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxLastName.Location = new System.Drawing.Point(403, 115);
            TxtBxLastName.Name = "TxtBxLastName";
            TxtBxLastName.Size = new System.Drawing.Size(274, 29);
            TxtBxLastName.TabIndex = 8;
            // 
            // TxtBxAddress
            // 
            TxtBxAddress.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxAddress.Location = new System.Drawing.Point(403, 171);
            TxtBxAddress.Name = "TxtBxAddress";
            TxtBxAddress.Size = new System.Drawing.Size(274, 29);
            TxtBxAddress.TabIndex = 9;
            // 
            // TxtBxPhoneNumber
            // 
            TxtBxPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxPhoneNumber.Location = new System.Drawing.Point(403, 227);
            TxtBxPhoneNumber.Mask = "(999) 000-0000";
            TxtBxPhoneNumber.Name = "TxtBxPhoneNumber";
            TxtBxPhoneNumber.Size = new System.Drawing.Size(274, 29);
            TxtBxPhoneNumber.TabIndex = 10;
            // 
            // Edit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(TlpMain);
            Name = "Edit";
            Text = "Edit";
            Load += Edit_Load;
            TlpMain.ResumeLayout(false);
            TlpMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.MaskedTextBox TxtBxWorkNumber;
        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblWorkNumber;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxLastName;
        private System.Windows.Forms.TextBox TxtBxAddress;
        private System.Windows.Forms.MaskedTextBox TxtBxPhoneNumber;
    }
}