
namespace ContactAgenda
{
    partial class AddContactForm
    {
        private System.ComponentModel.IContainer components = null;

       protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            TlpMain = new System.Windows.Forms.TableLayoutPanel();
            LblName = new System.Windows.Forms.Label();
            LblLastName = new System.Windows.Forms.Label();
            LblAddress = new System.Windows.Forms.Label();
            LblPhoneNumber = new System.Windows.Forms.Label();
            LblWorkNumber = new System.Windows.Forms.Label();
            BtnSave = new System.Windows.Forms.Button();
            BtnCancel = new System.Windows.Forms.Button();
            TxtBxName = new System.Windows.Forms.TextBox();
            TxtBxLastName = new System.Windows.Forms.TextBox();
            TxtBxAddress = new System.Windows.Forms.TextBox();
            TxtBxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            TxtBxWorkNumber = new System.Windows.Forms.MaskedTextBox();
            TlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // TlpMain
            // 
            TlpMain.BackColor = System.Drawing.Color.MediumAquamarine;
            TlpMain.ColumnCount = 4;
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.40394068F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.4088669F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.3645325F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6584568F));
            TlpMain.Controls.Add(LblWorkNumber, 1, 5);
            TlpMain.Controls.Add(BtnSave, 1, 6);
            TlpMain.Controls.Add(BtnCancel, 2, 6);
            TlpMain.Controls.Add(TxtBxName, 2, 1);
            TlpMain.Controls.Add(TxtBxLastName, 2, 2);
            TlpMain.Controls.Add(TxtBxAddress, 2, 3);
            TlpMain.Controls.Add(TxtBxPhoneNumber, 2, 4);
            TlpMain.Controls.Add(TxtBxWorkNumber, 2, 5);
            TlpMain.Controls.Add(LblPhoneNumber, 1, 4);
            TlpMain.Controls.Add(LblAddress, 1, 3);
            TlpMain.Controls.Add(LblLastName, 1, 2);
            TlpMain.Controls.Add(LblName, 1, 1);
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
            TlpMain.Size = new System.Drawing.Size(609, 450);
            TlpMain.TabIndex = 0;
            TlpMain.Paint += TlpMain_Paint;
            // 
            // LblName
            // 
            LblName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblName.AutoSize = true;
            LblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblName.Location = new System.Drawing.Point(223, 56);
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
            LblLastName.Location = new System.Drawing.Point(193, 112);
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
            LblAddress.Location = new System.Drawing.Point(206, 168);
            LblAddress.Name = "LblAddress";
            LblAddress.Size = new System.Drawing.Size(70, 21);
            LblAddress.TabIndex = 2;
            LblAddress.Text = "Address";
            // 
            // LblPhoneNumber
            // 
            LblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblPhoneNumber.AutoSize = true;
            LblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblPhoneNumber.Location = new System.Drawing.Point(159, 224);
            LblPhoneNumber.Name = "LblPhoneNumber";
            LblPhoneNumber.Size = new System.Drawing.Size(117, 21);
            LblPhoneNumber.TabIndex = 3;
            LblPhoneNumber.Text = "Phone number";
            // 
            // LblWorkNumber
            // 
            LblWorkNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblWorkNumber.AutoSize = true;
            LblWorkNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblWorkNumber.Location = new System.Drawing.Point(166, 280);
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
            BtnSave.Location = new System.Drawing.Point(42, 339);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new System.Drawing.Size(234, 33);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = System.Drawing.Color.IndianRed;
            BtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnCancel.Location = new System.Drawing.Point(282, 339);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new System.Drawing.Size(252, 33);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // TxtBxName
            // 
            TxtBxName.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxName.Location = new System.Drawing.Point(282, 59);
            TxtBxName.Name = "TxtBxName";
            TxtBxName.Size = new System.Drawing.Size(252, 29);
            TxtBxName.TabIndex = 7;
            TxtBxName.TextChanged += TxtBxName_TextChanged;
            // 
            // TxtBxLastName
            // 
            TxtBxLastName.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxLastName.Location = new System.Drawing.Point(282, 115);
            TxtBxLastName.Name = "TxtBxLastName";
            TxtBxLastName.Size = new System.Drawing.Size(252, 29);
            TxtBxLastName.TabIndex = 8;
            // 
            // TxtBxAddress
            // 
            TxtBxAddress.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxAddress.Location = new System.Drawing.Point(282, 171);
            TxtBxAddress.Name = "TxtBxAddress";
            TxtBxAddress.Size = new System.Drawing.Size(252, 29);
            TxtBxAddress.TabIndex = 9;
            // 
            // TxtBxPhoneNumber
            // 
            TxtBxPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxPhoneNumber.Location = new System.Drawing.Point(282, 227);
            TxtBxPhoneNumber.Mask = "(999) 000-0000";
            TxtBxPhoneNumber.Name = "TxtBxPhoneNumber";
            TxtBxPhoneNumber.Size = new System.Drawing.Size(252, 29);
            TxtBxPhoneNumber.TabIndex = 10;
            // 
            // TxtBxWorkNumber
            // 
            TxtBxWorkNumber.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxWorkNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxWorkNumber.Location = new System.Drawing.Point(282, 283);
            TxtBxWorkNumber.Mask = "(999) 000-0000";
            TxtBxWorkNumber.Name = "TxtBxWorkNumber";
            TxtBxWorkNumber.Size = new System.Drawing.Size(252, 29);
            TxtBxWorkNumber.TabIndex = 11;
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(609, 450);
            Controls.Add(TlpMain);
            Name = "AddContactForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add New Contact";
            FormClosed += AddContactForm_FormClosed;
            Load += AddContactForm_Load;
            TlpMain.ResumeLayout(false);
            TlpMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label LblWorkNumber;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.TextBox TxtBxLastName;
        private System.Windows.Forms.TextBox TxtBxAddress;
        private System.Windows.Forms.MaskedTextBox TxtBxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox TxtBxWorkNumber;
    }
}