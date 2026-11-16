using System;
using System.ComponentModel;
using System.Windows.Forms;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x020001A9 RID: 425
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class DropListViewRowEventArgs : ControlEventArgs
	{
		// Token: 0x060014DB RID: 5339 RVA: 0x000973E2 File Offset: 0x000955E2
		public DropListViewRowEventArgs(System.Windows.Forms.Control A_0, Foxtable.WinForm.Form A_1, int A_2, int A_3, Foxtable.WinForm.ListView A_4) : base(A_0, A_1)
		{
			this.oO.0. = true;
			this.OO0__.O0oO0o_o. = true;
			this.oO.0. = A_3;
			this.OO0__.O0oO0o_o. = A_2;
			this.oO.0. = A_4;
		}

		/// <summary>
		/// 新位置，将在此处接收拖动过来的行
		/// </summary>
		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x00097411 File Offset: 0x00095611
		public int NewIndex
		{
			get
			{
				return this.oO.0.;
			}
		}

		/// <summary>
		/// 拖动过来的行的原位置
		/// </summary>
		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00097419 File Offset: 0x00095619
		public int OldIndex
		{
			get
			{
				return this.OO0__.O0oO0o_o.;
			}
		}

		/// <summary>
		/// 回拖动过来的行原来所属的ListView
		/// </summary>
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x00097421 File Offset: 0x00095621
		public Foxtable.WinForm.ListView Source
		{
			get
			{
				return this.oO.0.;
			}
		}

		/// <summary>
		/// 是否从原来的ListView删除拖动过来的行
		/// </summary>
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x00097429 File Offset: 0x00095629
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x00097431 File Offset: 0x00095631
		public bool Delete
		{
			get
			{
				return this.oO.0.;
			}
			set
			{
				this.oO.0. = value;
			}
		}

		/// <summary>
		/// 是否接收拖动过来的行
		/// </summary>
		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0009743A File Offset: 0x0009563A
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x00097442 File Offset: 0x00095642
		public bool Add
		{
			get
			{
				return this.OO0__.O0oO0o_o.;
			}
			set
			{
				this.OO0__.O0oO0o_o. = value;
			}
		}

		// Token: 0x04000841 RID: 2113
		private int <<EMPTY_NAME>>;

		// Token: 0x04000842 RID: 2114
		private int <<EMPTY_NAME>>;

		// Token: 0x04000843 RID: 2115
		private Foxtable.WinForm.ListView <<EMPTY_NAME>>;

		// Token: 0x04000844 RID: 2116
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000845 RID: 2117
		private bool <<EMPTY_NAME>>;
	}
}
