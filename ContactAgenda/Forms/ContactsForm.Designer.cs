
namespace ContactAgenda
{
    partial class ContactsForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TlpMain = new System.Windows.Forms.TableLayoutPanel();
            DgvContacts = new System.Windows.Forms.DataGridView();
            BtnEditContact = new System.Windows.Forms.Button();
            BtnDeleteContact = new System.Windows.Forms.Button();
            BtnAddContact = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            MsMain = new System.Windows.Forms.ToolStripMenuItem();
            MsItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            TlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvContacts).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TlpMain
            // 
            TlpMain.ColumnCount = 4;
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            TlpMain.Controls.Add(DgvContacts, 1, 1);
            TlpMain.Controls.Add(BtnEditContact, 1, 3);
            TlpMain.Controls.Add(BtnDeleteContact, 2, 3);
            TlpMain.Controls.Add(BtnAddContact, 1, 0);
            TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            TlpMain.Location = new System.Drawing.Point(0, 0);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 5;
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            TlpMain.Size = new System.Drawing.Size(715, 450);
            TlpMain.TabIndex = 0;
            // 
            // DgvContacts
            // 
            DgvContacts.AllowUserToAddRows = false;
            DgvContacts.AllowUserToDeleteRows = false;
            DgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TlpMain.SetColumnSpan(DgvContacts, 2);
            DgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            DgvContacts.Location = new System.Drawing.Point(110, 110);
            DgvContacts.MultiSelect = false;
            DgvContacts.Name = "DgvContacts";
            DgvContacts.ReadOnly = true;
            TlpMain.SetRowSpan(DgvContacts, 2);
            DgvContacts.RowTemplate.Height = 25;
            DgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvContacts.Size = new System.Drawing.Size(494, 208);
            DgvContacts.TabIndex = 0;
            DgvContacts.CellClick += DgvContacts_CellClick;
            DgvContacts.DoubleClick += DgvContacts_DoubleClick;
            // 
            // BtnEditContact
            // 
            BtnEditContact.BackColor = System.Drawing.Color.SandyBrown;
            BtnEditContact.Dock = System.Windows.Forms.DockStyle.Top;
            BtnEditContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnEditContact.Location = new System.Drawing.Point(110, 324);
            BtnEditContact.Name = "BtnEditContact";
            BtnEditContact.Size = new System.Drawing.Size(244, 33);
            BtnEditContact.TabIndex = 1;
            BtnEditContact.Text = "Edit";
            BtnEditContact.UseVisualStyleBackColor = false;
            BtnEditContact.Click += BtnEditContact_Click;
            // 
            // BtnDeleteContact
            // 
            BtnDeleteContact.BackColor = System.Drawing.Color.IndianRed;
            BtnDeleteContact.Dock = System.Windows.Forms.DockStyle.Top;
            BtnDeleteContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnDeleteContact.Location = new System.Drawing.Point(360, 324);
            BtnDeleteContact.Name = "BtnDeleteContact";
            BtnDeleteContact.Size = new System.Drawing.Size(244, 33);
            BtnDeleteContact.TabIndex = 2;
            BtnDeleteContact.Text = "Delete";
            BtnDeleteContact.UseVisualStyleBackColor = false;
            BtnDeleteContact.Click += BtnDeleteContact_Click;
            // 
            // BtnAddContact
            // 
            BtnAddContact.BackColor = System.Drawing.Color.LightGreen;
            TlpMain.SetColumnSpan(BtnAddContact, 2);
            BtnAddContact.Dock = System.Windows.Forms.DockStyle.Bottom;
            BtnAddContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnAddContact.Location = new System.Drawing.Point(110, 71);
            BtnAddContact.Name = "BtnAddContact";
            BtnAddContact.Size = new System.Drawing.Size(494, 33);
            BtnAddContact.TabIndex = 3;
            BtnAddContact.Text = "Add new contact";
            BtnAddContact.UseVisualStyleBackColor = false;
            BtnAddContact.Click += BtnAddContact_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MsMain });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(715, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MsMain
            // 
            MsMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MsItemLogout });
            MsMain.Name = "MsMain";
            MsMain.Size = new System.Drawing.Size(50, 20);
            MsMain.Text = "Menu";
            // 
            // MsItemLogout
            // 
            MsItemLogout.Name = "MsItemLogout";
            MsItemLogout.Size = new System.Drawing.Size(112, 22);
            MsItemLogout.Text = "Logout";
            MsItemLogout.Click += MsItemLogout_Click;
            // 
            // ContactsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AliceBlue;
            ClientSize = new System.Drawing.Size(715, 450);
            Controls.Add(menuStrip1);
            Controls.Add(TlpMain);
            Name = "ContactsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Contacts";
            FormClosed += ContactsForm_FormClosed;
            Load += ContactsForm_Load;
            VisibleChanged += ContactsForm_VisibleChanged;
            TlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvContacts).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.DataGridView DgvContacts;
        private System.Windows.Forms.Button BtnEditContact;
        private System.Windows.Forms.Button BtnDeleteContact;
        private System.Windows.Forms.Button BtnAddContact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsMain;
        private System.Windows.Forms.ToolStripMenuItem MsItemLogout;
    }
}