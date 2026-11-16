using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	// Token: 0x0200053E RID: 1342
	[ComVisible(true)]
	[oO0oooo("1480")]
	public class WebBrowser : Control
	{
		// Token: 0x06005A15 RID: 23061 RVA: 0x00261EE4 File Offset: 0x002600E4
		public WebBrowser(OOO0_ A_0) : base(A_0, ControlTypeEnum.WebBrowser)
		{
			this.oO._o_00_O. = A_0;
		}

		/// <summary>
		/// 后退一页
		/// </summary>
		// Token: 0x06005A16 RID: 23062 RVA: 0x00261EF6 File Offset: 0x002600F6
		public void GoBack()
		{
			this.oO._o_00_O..GoBack();
		}

		/// <summary>
		/// 前进一页
		/// </summary>
		// Token: 0x06005A17 RID: 23063 RVA: 0x00261F04 File Offset: 0x00260104
		public void GoForward()
		{
			this.oO._o_00_O..GoForward();
		}

		/// <summary>
		/// 回到首页，首页地址由计算机的Internet选项决定
		/// </summary>
		// Token: 0x06005A18 RID: 23064 RVA: 0x00261F12 File Offset: 0x00260112
		public void GoHome()
		{
			this.oO._o_00_O..GoHome();
		}

		/// <summary>
		/// 网页地址
		/// </summary>
		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06005A19 RID: 23065 RVA: 0x00261F20 File Offset: 0x00260120
		// (set) Token: 0x06005A1A RID: 23066 RVA: 0x00261F54 File Offset: 0x00260154
		public string Address
		{
			get
			{
				string result;
				if (this.oO._o_00_O..Url != null)
				{
					result = this.oO._o_00_O..Url.AbsoluteUri;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0)
				{
					try
					{
						this.oO._o_00_O..Url = new Uri(value);
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						return;
					}
				}
				this.oO._o_00_O..Url = null;
			}
		}

		/// <summary>
		/// 打印
		/// </summary>
		// Token: 0x06005A1B RID: 23067 RVA: 0x00261FBC File Offset: 0x002601BC
		public void Print()
		{
			this.oO._o_00_O..ShowPrintDialog();
		}

		/// <summary>
		/// 打印预览
		/// </summary>
		// Token: 0x06005A1C RID: 23068 RVA: 0x00261FC9 File Offset: 0x002601C9
		public void Preview()
		{
			this.oO._o_00_O..ShowPrintPreviewDialog();
		}

		/// <summary>
		/// 显示另存为对话框
		/// </summary>
		// Token: 0x06005A1D RID: 23069 RVA: 0x00261FD6 File Offset: 0x002601D6
		public void ShowSaveAsDialog()
		{
			this.oO._o_00_O..ShowSaveAsDialog();
		}

		/// <summary>
		/// 逻辑型，如果设置为True，打开Word或Excel文件后，会显示菜单和工具栏。
		/// </summary>
		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x00261FE3 File Offset: 0x002601E3
		// (set) Token: 0x06005A1F RID: 23071 RVA: 0x00261FF0 File Offset: 0x002601F0
		public bool OfficeToolBar
		{
			get
			{
				return this.oO._o_00_O..Ooo__.ooO_0.();
			}
			set
			{
				this.oO._o_00_O..OOOo_._oO0_O.(value);
			}
		}

		/// <summary>
		/// 保存浏览器中的office文件
		/// </summary>
		// Token: 0x06005A20 RID: 23072 RVA: 0x00261FFE File Offset: 0x002601FE
		public void SaveOffice()
		{
			this.oO._o_00_O..Ooo0.oO0_o.();
		}

		/// <summary>
		/// 打印浏览器中的office文件
		/// </summary>
		// Token: 0x06005A21 RID: 23073 RVA: 0x0026200B File Offset: 0x0026020B
		public void PrintOffice()
		{
			this.oO._o_00_O..OOoo.OOo0000_.();
		}

		// Token: 0x04002339 RID: 9017
		private OOO0_ <<EMPTY_NAME>>;
	}
}
