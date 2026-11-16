using System;
using System.ComponentModel;
using Foxtable.WinForm;

namespace Foxtable
{
	// Token: 0x02000309 RID: 777
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class MoveRowEventArgs
	{
		// Token: 0x06002A06 RID: 10758 RVA: 0x0012B870 File Offset: 0x00129A70
		public MoveRowEventArgs(Table A_0, int A_1, int A_2)
		{
			this.o0o.OooOOo0__. = A_0;
			this.o0o.OooOOo0__. = A_1;
			this.o0_ooOo0__0.0_. = A_2;
		}

		/// <summary>
		/// 触发事件的表
		/// </summary>
		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0012B88D File Offset: 0x00129A8D
		public Table Table
		{
			get
			{
				return this.o0o.OooOOo0__.;
			}
		}

		/// <summary>
		/// 移动前的位置
		/// </summary>
		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x0012B895 File Offset: 0x00129A95
		public int OldIndex
		{
			get
			{
				return this.o0o.OooOOo0__.;
			}
		}

		/// <summary>
		/// 移动后的位置
		/// </summary>
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x0012B89D File Offset: 0x00129A9D
		public int NewIndex
		{
			get
			{
				return this.o0_ooOo0__0.0_.;
			}
		}

		/// <summary>
		/// 设置为True，将取消移动行
		/// </summary>
		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x0012B8A5 File Offset: 0x00129AA5
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x0012B8AD File Offset: 0x00129AAD
		public bool Cancel
		{
			get
			{
				return this.o0o.OooOOo0__.;
			}
			set
			{
				this.o0o.OooOOo0__. = value;
			}
		}

		/// <summary>
		/// 如果Table位于用户窗口中，可通过此属性获取Form对象
		/// </summary>
		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x0012B8B6 File Offset: 0x00129AB6
		public Form Form
		{
			get
			{
				return this.Table.Form;
			}
		}

		// Token: 0x04001162 RID: 4450
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001163 RID: 4451
		private int <<EMPTY_NAME>>;

		// Token: 0x04001164 RID: 4452
		private int <<EMPTY_NAME>>;

		// Token: 0x04001165 RID: 4453
		private bool <<EMPTY_NAME>>;
	}
}
