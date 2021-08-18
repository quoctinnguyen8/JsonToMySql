
namespace JsonToMySql
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkDelete = new System.Windows.Forms.CheckBox();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDbName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtJsonPath = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnStart.Location = new System.Drawing.Point(196, 390);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(200, 57);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Bắt đầu";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkDelete);
			this.groupBox1.Controls.Add(this.txtTableName);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtDbName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtPwd);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtUsername);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtServerName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(565, 281);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin MySQL";
			// 
			// chkDelete
			// 
			this.chkDelete.AutoSize = true;
			this.chkDelete.Location = new System.Drawing.Point(294, 236);
			this.chkDelete.Name = "chkDelete";
			this.chkDelete.Size = new System.Drawing.Size(256, 24);
			this.chkDelete.TabIndex = 12;
			this.chkDelete.Text = "Xóa dữ liệu trong bảng được chọn";
			this.chkDelete.UseVisualStyleBackColor = true;
			// 
			// txtTableName
			// 
			this.txtTableName.Location = new System.Drawing.Point(294, 195);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(241, 26);
			this.txtTableName.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(294, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(261, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Table name (tên của bảng cần import)";
			// 
			// txtDbName
			// 
			this.txtDbName.Location = new System.Drawing.Point(22, 195);
			this.txtDbName.Name = "txtDbName";
			this.txtDbName.Size = new System.Drawing.Size(241, 26);
			this.txtDbName.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Database name";
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(294, 128);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(241, 26);
			this.txtPwd.TabIndex = 5;
			this.txtPwd.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(294, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(294, 60);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(241, 26);
			this.txtUsername.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(294, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Username";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(22, 128);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(241, 26);
			this.txtPort.TabIndex = 2;
			this.txtPort.Text = "3306";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port";
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(22, 60);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(241, 26);
			this.txtServerName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server name";
			// 
			// fileDialog
			// 
			this.fileDialog.Filter = "JSON files |*.json; *.txt|All files (*.*)|*.*";
			this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(487, 332);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(90, 28);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Chọn file";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtJsonPath
			// 
			this.txtJsonPath.Location = new System.Drawing.Point(12, 333);
			this.txtJsonPath.Name = "txtJsonPath";
			this.txtJsonPath.ReadOnly = true;
			this.txtJsonPath.Size = new System.Drawing.Size(469, 26);
			this.txtJsonPath.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 310);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "Chọn file json";
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInfo.Location = new System.Drawing.Point(12, 427);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(97, 17);
			this.lblInfo.TabIndex = 14;
			this.lblInfo.Text = "Trạng thái xử lý";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(591, 458);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtJsonPath);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(609, 503);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(609, 503);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chuyển đổi dữ liệu từ JSON vào MySQL";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkDelete;
		private System.Windows.Forms.TextBox txtTableName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDbName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtJsonPath;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblInfo;
	}
}

