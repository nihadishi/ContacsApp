
namespace ContactAgenda
{
    partial class LoginForm
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
            LblUsername = new System.Windows.Forms.Label();
            LblPassword = new System.Windows.Forms.Label();
            TxtBxUsername = new System.Windows.Forms.TextBox();
            TxtBxPassword = new System.Windows.Forms.TextBox();
            BtnRegister = new System.Windows.Forms.Button();
            BtnLogin = new System.Windows.Forms.Button();
            TlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // TlpMain
            // 
            TlpMain.ColumnCount = 4;
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.51206F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.2282F));
            TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            TlpMain.Controls.Add(LblUsername, 1, 1);
            TlpMain.Controls.Add(LblPassword, 1, 2);
            TlpMain.Controls.Add(TxtBxUsername, 2, 1);
            TlpMain.Controls.Add(TxtBxPassword, 2, 2);
            TlpMain.Controls.Add(BtnRegister, 1, 4);
            TlpMain.Controls.Add(BtnLogin, 1, 3);
            TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            TlpMain.Location = new System.Drawing.Point(0, 0);
            TlpMain.Name = "TlpMain";
            TlpMain.RowCount = 5;
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.54054F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.62162F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.02703F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7027F));
            TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.10811F));
            TlpMain.Size = new System.Drawing.Size(539, 367);
            TlpMain.TabIndex = 0;
            // 
            // LblUsername
            // 
            LblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblUsername.AutoSize = true;
            LblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblUsername.Location = new System.Drawing.Point(111, 112);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new System.Drawing.Size(83, 21);
            LblUsername.TabIndex = 0;
            LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            LblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LblPassword.AutoSize = true;
            LblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LblPassword.Location = new System.Drawing.Point(115, 154);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new System.Drawing.Size(79, 21);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password";
            // 
            // TxtBxUsername
            // 
            TxtBxUsername.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxUsername.Location = new System.Drawing.Point(200, 115);
            TxtBxUsername.Name = "TxtBxUsername";
            TxtBxUsername.Size = new System.Drawing.Size(227, 27);
            TxtBxUsername.TabIndex = 2;
            // 
            // TxtBxPassword
            // 
            TxtBxPassword.Dock = System.Windows.Forms.DockStyle.Top;
            TxtBxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            TxtBxPassword.Location = new System.Drawing.Point(200, 157);
            TxtBxPassword.Name = "TxtBxPassword";
            TxtBxPassword.PasswordChar = '*';
            TxtBxPassword.Size = new System.Drawing.Size(227, 27);
            TxtBxPassword.TabIndex = 3;
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = System.Drawing.Color.Fuchsia;
            TlpMain.SetColumnSpan(BtnRegister, 2);
            BtnRegister.Dock = System.Windows.Forms.DockStyle.Top;
            BtnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnRegister.Location = new System.Drawing.Point(111, 265);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new System.Drawing.Size(316, 35);
            BtnRegister.TabIndex = 4;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = System.Drawing.Color.Gold;
            TlpMain.SetColumnSpan(BtnLogin, 2);
            BtnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            BtnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            BtnLogin.Location = new System.Drawing.Point(111, 219);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new System.Drawing.Size(316, 35);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MediumAquamarine;
            ClientSize = new System.Drawing.Size(539, 367);
            Controls.Add(TlpMain);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            TlpMain.ResumeLayout(false);
            TlpMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnLogin;
    }
}

