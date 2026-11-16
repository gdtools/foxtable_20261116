using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Foxtable
{
	// Token: 0x020002F7 RID: 759
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("0682")]
	public class BeforeConnectOuterDataSourceEventArgs
	{
		// Token: 0x06002967 RID: 10599 RVA: 0x0012AA42 File Offset: 0x00128C42
		public BeforeConnectOuterDataSourceEventArgs(string A_0, string A_1, string A_2, UserInfo A_3)
		{
			this.oO.O0O00oo_. = A_0;
			this.o0.OO0OOOO000_. = A_3;
			this.oo00.0oOoO0o. = A_1;
			this.O_0O_._o. = A_2;
		}

		/// <summary>
		/// 返回或设置连接字符串
		/// </summary>
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x0012AA67 File Offset: 0x00128C67
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0012AA6F File Offset: 0x00128C6F
		public string ConnectionString
		{
			get
			{
				return this.oo00.0oOoO0o.;
			}
			set
			{
				this.oo00.0oOoO0o. = value;
			}
		}

		/// <summary>
		/// 外部数据源名称
		/// </summary>
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x0012AA78 File Offset: 0x00128C78
		public string Name
		{
			get
			{
				return this.oO.O0O00oo_.;
			}
		}

		/// <summary>
		/// 登录用户
		/// </summary>
		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x0012AA80 File Offset: 0x00128C80
		public UserInfo User
		{
			get
			{
				return this.o0.OO0OOOO000_.;
			}
		}

		/// <summary>
		/// 项目文件名，含路径
		/// </summary>
		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x0012AA88 File Offset: 0x00128C88
		public string ProjectFile
		{
			get
			{
				return this.O_0O_._o.;
			}
		}

		/// <summary>
		/// 返回项目文件所在目录
		/// </summary>
		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x0012AA90 File Offset: 0x00128C90
		public string ProjectPath
		{
			get
			{
				return OO_00oOO.FileSys.GetParentPath(this.O_0O_._o.) + "\\";
			}
		}

		/// <summary>
		/// 逻辑型，设为True，关闭Foxtable的启动封面
		/// </summary>
		// Token: 0x170008D3 RID: 2259
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x0012AAAC File Offset: 0x00128CAC
		public bool HideSplashForm
		{
			set
			{
				if (value)
				{
					OO_00oOO.CloseSplashForm();
				}
			}
		}

		/// <summary>
		/// 打开数据源设置窗口
		/// </summary>
		// Token: 0x0600296F RID: 10607 RVA: 0x0012AAB8 File Offset: 0x00128CB8
		public void EditConnectionString()
		{
			bool visible = Main.ProcessForm.Visible;
			O\u3002\u3000\u3000 o_u3002_u3000_u = new O\u3002\u3000\u3000();
			o_u3002_u3000_u.OO._000_O0o_.().Text = this.ConnectionString;
			Main.ProcessForm.Hide();
			Main.OO_O.o. = SplashFormStateEnum.Hide;
			if (o_u3002_u3000_u.ShowDialog() == DialogResult.OK)
			{
				this.ConnectionString = o_u3002_u3000_u.OO._000_O0o_.().Text;
			}
			Main.ProcessForm.Show();
		}

		// Token: 0x04001119 RID: 4377
		private string <<EMPTY_NAME>>;

		// Token: 0x0400111A RID: 4378
		private string <<EMPTY_NAME>>;

		// Token: 0x0400111B RID: 4379
		private UserInfo <<EMPTY_NAME>>;

		// Token: 0x0400111C RID: 4380
		private string <<EMPTY_NAME>>;
	}
}
