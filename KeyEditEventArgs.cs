using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000305 RID: 773
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class KeyEditEventArgs : KeyEventArgs
	{
		// Token: 0x060029DA RID: 10714 RVA: 0x0012B4F8 File Offset: 0x001296F8
		public KeyEditEventArgs(Table A_0, Row A_1, Col A_2, Keys A_3, System.Windows.Forms.Control A_4, RecordGrid A_5) : base(A_3)
		{
			this.Oo0O0OO_0_.00. = A_0;
			this.Oo0O0OO_0_.00. = A_1;
			this.Oo0O0OO_0_.00. = A_2;
			if (A_4 != null)
			{
				this.Oo0O0OO_0_.00. = (System.Windows.Forms.TextBox)A_4;
			}
			this.Oo0O0OO_0_.00. = A_5;
		}

		/// <summary>
		/// 触发事件的Table
		/// </summary>
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x0012B536 File Offset: 0x00129736
		public Table Table
		{
			get
			{
				return this.Oo0O0OO_0_.00.;
			}
		}

		/// <summary>
		/// 触发事件的Row
		/// </summary>
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x0012B53E File Offset: 0x0012973E
		public Row Row
		{
			get
			{
				return this.Oo0O0OO_0_.00.;
			}
		}

		/// <summary>
		/// 触发事件的Col
		/// </summary>
		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x0012B546 File Offset: 0x00129746
		public Col Col
		{
			get
			{
				return this.Oo0O0OO_0_.00.;
			}
		}

		/// <summary>
		/// 设置为True，取消本次按键输入
		/// </summary>
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x0012B54E File Offset: 0x0012974E
		// (set) Token: 0x060029DF RID: 10719 RVA: 0x0012B556 File Offset: 0x00129756
		public bool Cancel
		{
			get
			{
				return base.Handled;
			}
			set
			{
				base.Handled = value;
				base.SuppressKeyPress = value;
			}
		}

		/// <summary>
		/// 返回或设置编辑框中选定的内容
		/// </summary>
		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x0012B568 File Offset: 0x00129768
		// (set) Token: 0x060029E1 RID: 10721 RVA: 0x0012B592 File Offset: 0x00129792
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
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x0012B5A8 File Offset: 0x001297A8
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x0012B5CA File Offset: 0x001297CA
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
		/// 返回或设置编辑框中选定内容的起始位置
		/// </summary>
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x0012B5E0 File Offset: 0x001297E0
		// (set) Token: 0x060029E5 RID: 10725 RVA: 0x0012B602 File Offset: 0x00129802
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
		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x0012B618 File Offset: 0x00129818
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x0012B642 File Offset: 0x00129842
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
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x0012B658 File Offset: 0x00129858
		public RecordGrid RecordGrid
		{
			get
			{
				return this.Oo0O0OO_0_.00.;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x0012B660 File Offset: 0x00129860
		public Foxtable.WinForm.Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001152 RID: 4434
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001153 RID: 4435
		private Row <<EMPTY_NAME>>;

		// Token: 0x04001154 RID: 4436
		private Col <<EMPTY_NAME>>;

		// Token: 0x04001155 RID: 4437
		private System.Windows.Forms.TextBox <<EMPTY_NAME>>;

		// Token: 0x04001156 RID: 4438
		private RecordGrid <<EMPTY_NAME>>;
	}
}
