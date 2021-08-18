using JsonToMySql.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonToMySql
{
	public partial class frmMain : Form
	{
		HashSet<JSONInputClass> data;
		public frmMain()
		{
			InitializeComponent();
			txtServerName.Focus();
		}

		private async void btnStart_Click(object sender, EventArgs e)
		{
			if (data == null || data.Count == 0)
			{
				MessageBox.Show("Chưa chọn file JSON hoặc file đã chọn không có dữ liệu", "Lỗi",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (DataIsValid())
			{
				await InsertData();
			}
			else
			{
				MessageBox.Show("Dữ liệu chưa đầy đủ");
			}
		}

		async Task InsertData()
		{
			try
			{
				DatabaseMySql db = new DatabaseMySql(txtServerName.Text
														, txtDbName.Text
														, txtUsername.Text
														, txtPwd.Text
														, txtPort.Text);
				if (db.OpenConnection())
				{
					if (db.TableExists(txtTableName.Text))
					{
						if (chkDelete.Checked)
						{
							var result = MessageBox.Show($"Phát hiện database đã có bảng '{txtTableName.Text}'. Thao tác này sẽ xóa toàn bộ dữ liệu của bảng '{txtTableName.Text}', xác nhận xóa?",
														"Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
							if (result == DialogResult.Yes)
							{
								await db.DeleteAllAsync(txtTableName.Text);
							}
							else
							{
								return;
							}
						}
					}
					else
					{
						await db.CreateTableAsync(typeof(JSONInputClass), txtTableName.Text);
					}
					lblInfo.Text = "Thêm dữ liệu vào MySQL...";
					await db.BulkInsertAsync(data, txtTableName.Text);
					db.CloseConnection();
					MessageBox.Show("Hoàn thành, hãy kiểm tra database trước khi thực hiện thao tác khác");
					lblInfo.Text = "Hoàn thành";
					txtJsonPath.Clear();
					data.Clear();
				}
				else
				{
					MessageBox.Show("Không thể kết nối đến database, hãy kiểm tra lại thông tin database", "Lỗi",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				lblInfo.Text = "Lỗi";
			}
		}

		bool DataIsValid()
		{
			return (!String.IsNullOrWhiteSpace(txtServerName.Text))
				&& (!String.IsNullOrWhiteSpace(txtPort.Text))
				&& (!String.IsNullOrWhiteSpace(txtDbName.Text))
				&& (!String.IsNullOrWhiteSpace(txtUsername.Text))
				&& (!String.IsNullOrWhiteSpace(txtTableName.Text));
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			fileDialog.ShowDialog();
		}

		private async void fileDialog_FileOk(object sender, CancelEventArgs e)
		{
			txtJsonPath.Text = fileDialog.FileName;
			lblInfo.Text = "Đang đọc dữ liệu...";
			var fileContent = await File.ReadAllTextAsync(fileDialog.FileName);
			StringBuilder contentBuilder = new StringBuilder(fileContent);
			contentBuilder.Replace("}\n", "},");
			if (contentBuilder[0] != '[')
			{
				contentBuilder.Insert(0, "[");
			}
			if (contentBuilder[contentBuilder.Length - 1] != ']')
			{
				contentBuilder.Append(']');
			}
			fileContent = contentBuilder.ToString();
			data = JsonConvert.DeserializeObject<HashSet<JSONInputClass>>(fileContent);
			lblInfo.Text = "Sẵn sàng để chuyển đổi";
		}
	}
}
