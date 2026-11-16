using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000307 RID: 775
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class KeyPressEditEventArgs
	{
		// Token: 0x060029EF RID: 10735 RVA: 0x0012B6AC File Offset: 0x001298AC
		public KeyPressEditEventArgs(Table A_0, Row A_1, Col A_2, char A_3, System.Windows.Forms.Control A_4, RecordGrid A_5)
		{
			this.O0Ooo0o.0O. = A_0;
			this.O0Ooo0o.0O. = A_1;
			this.Oo0O0OO_0_.00. = A_2;
			this.O0Ooo0o.0O. = Conversions.ToString(A_3);
			this.O0Ooo0o.0O. = A_5;
			if (A_4 != null)
			{
				this.Oo0O0OO_0_.00. = (System.Windows.Forms.TextBox)A_4;
			}
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x0012B6FA File Offset: 0x001298FA
		public Table Table
		{
			get
			{
				return this.O0Ooo0o.0O.;
			}
		}

		/// <summary>
		/// 触发事件的Row
		/// </summary>
		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x0012B702 File Offset: 0x00129902
		public Row Row
		{
			get
			{
				return this.O0Ooo0o.0O.;
			}
		}

		/// <summary>
		/// 触发事件的Col
		/// </summary>
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x0012B70A File Offset: 0x0012990A
		public Col Col
		{
			get
			{
				return this.Oo0O0OO_0_.00.;
			}
		}

		/// <summary>
		/// 所输入的字符
		/// </summary>
		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x0012B712 File Offset: 0x00129912
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x0012B71A File Offset: 0x0012991A
		public string KeyChar
		{
			get
			{
				return this.O0Ooo0o.0O.;
			}
			set
			{
				this.O0Ooo0o.0O. = value;
			}
		}

		/// <summary>
		/// 设为True，取消本次字符输入
		/// </summary>
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x0012B723 File Offset: 0x00129923
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x0012B72B File Offset: 0x0012992B
		public bool Cancel
		{
			get
			{
				return this.Oo0O0OO_0_.00.;
			}
			set
			{
				this.Oo0O0OO_0_.00. = value;
			}
		}

		/// <summary>
		/// 返回或设置编辑框中选定的内容
		/// </summary>
		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0012B734 File Offset: 0x00129934
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x0012B75E File Offset: 0x0012995E
		public string SelectedText
		{
			get
			{
				string result;
				if (this.Oo0O0OO_0_.00. != null)
				{
					result = this.Oo0O0OO_0_.00..SelectedText;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				if (this.Oo0O0OO_0_.00. != null)
				{
					this.Oo0O0OO_0_.00..SelectedText = value;
				}
			}
		}

		/// <summary>
		/// 返回或设置编辑框中选定内容的长度
		/// </summary>
		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x0012B774 File Offset: 0x00129974
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x0012B796 File Offset: 0x00129996
		public int SelectionLength
		{
			get
			{
				int selectionLength;
				if (this.Oo0O0OO_0_.00. != null)
				{
					selectionLength = this.Oo0O0OO_0_.00..SelectionLength;
				}
				return selectionLength;
			}
			set
			{
				if (this.Oo0O0OO_0_.00. != null)
				{
					this.Oo0O0OO_0_.00..SelectionLength = value;
				}
			}
		}

		/// <summary>
		/// 返回或设置编辑框中选定内容的起始位置(光标位置)
		/// </summary>
		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x0012B7AC File Offset: 0x001299AC
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x0012B7CE File Offset: 0x001299CE
		public int SelectionStart
		{
			get
			{
				int selectionStart;
				if (this.Oo0O0OO_0_.00. != null)
				{
					selectionStart = this.Oo0O0OO_0_.00..SelectionStart;
				}
				return selectionStart;
			}
			set
			{
				if (this.Oo0O0OO_0_.00. != null)
				{
					this.Oo0O0OO_0_.00..SelectionStart = value;
				}
			}
		}

		/// <summary>
		/// 返回或设置编辑框中的内容
		/// </summary>
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x0012B7E4 File Offset: 0x001299E4
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x0012B80E File Offset: 0x00129A0E
		public string Text
		{
			get
			{
				string result;
				if (this.Oo0O0OO_0_.00. != null)
				{
					result = this.Oo0O0OO_0_.00..Text;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				if (this.Oo0O0OO_0_.00. != null)
				{
					this.Oo0O0OO_0_.00..Text = value;
				}
			}
		}

		/// <summary>
		/// 如果是在记录窗口编辑，则返回RecordGrid对象
		/// </summary>
		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x0012B824 File Offset: 0x00129A24
		public RecordGrid RecordGrid
		{
			get
			{
				return this.O0Ooo0o.0O.;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x0012B82C File Offset: 0x00129A2C
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001158 RID: 4440
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001159 RID: 4441
		private Row <<EMPTY_NAME>>;

		// Token: 0x0400115A RID: 4442
		private Col <<EMPTY_NAME>>;

		// Token: 0x0400115B RID: 4443
		private string <<EMPTY_NAME>>;

		// Token: 0x0400115C RID: 4444
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400115D RID: 4445
		private System.Windows.Forms.TextBox <<EMPTY_NAME>>;

		// Token: 0x0400115E RID: 4446
		private RecordGrid <<EMPTY_NAME>>;
	}
}
