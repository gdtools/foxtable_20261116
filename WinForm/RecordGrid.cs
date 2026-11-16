using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using C1.Win.C1FlexGrid.Util.BaseControls;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 记录窗口
	/// </summary>
	// Token: 0x02000511 RID: 1297
	[oO0oooo("2453")]
	[ComVisible(true)]
	public class RecordGrid : Control
	{
		// Token: 0x060054FF RID: 21759 RVA: 0x00258EB1 File Offset: 0x002570B1
		internal RecordGrid(OooOo0___oO A_0) : base(A_0, ControlTypeEnum.RecordGrid)
		{
			this.Oooo.Oo_0O. = A_0;
			A_0.BorderStyle = BorderStyleEnum.Light3D;
		}

		/// <summary>
		/// 重新生成记录窗口
		/// </summary>
		// Token: 0x06005500 RID: 21760 RVA: 0x00258ECA File Offset: 0x002570CA
		public void Build()
		{
			this.Oooo.Oo_0O..Ooo_oO._0O.();
		}

		/// <summary>
		/// 返回或设置RecordGrid绑定的Table
		/// </summary>
		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x00258ED7 File Offset: 0x002570D7
		// (set) Token: 0x06005502 RID: 21762 RVA: 0x00258EE4 File Offset: 0x002570E4
		public Table Table
		{
			get
			{
				return this.Oooo.Oo_0O..O.OOoo_o0.;
			}
			set
			{
				this.Oooo.Oo_0O..OO_.O_O0O.(null);
				this.Oooo.Oo_0O..O.OOoo_o0. = value;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06005503 RID: 21763 RVA: 0x00258EFE File Offset: 0x002570FE
		// (set) Token: 0x06005504 RID: 21764 RVA: 0x00258F10 File Offset: 0x00257110
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string TableName
		{
			get
			{
				return this.Oooo.Oo_0O..O.OOoo_o0..Name;
			}
			set
			{
				this.Oooo.Oo_0O..OO_.O_O0O..Clear();
				this.Oooo.Oo_0O..OO_.O_O0O.(null);
				this.Oooo.Oo_0O..O.OOoo_o0. = OO_00oOO.Tables[value];
			}
		}

		/// <summary>
		/// 返回或设置RecordGrid显示的列
		/// </summary>
		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x00258F44 File Offset: 0x00257144
		// (set) Token: 0x06005506 RID: 21766 RVA: 0x00258F60 File Offset: 0x00257160
		public string Columns
		{
			get
			{
				return string.Join("|", this.Oooo.Oo_0O..OO_.O_O0O..ToArray());
			}
			set
			{
				this.Oooo.Oo_0O..OO_.O_O0O..Clear();
				this.Oooo.Oo_0O..OO_.O_O0O..AddRange(value.Split(new char[]
				{
					'|'
				}));
				this.Oooo.Oo_0O..O.OOoo_o0. = true;
			}
		}

		/// <summary>
		/// 打开下拉列表或者下拉窗口，只有正在编辑的列设置了列表项目或下拉窗口，此方法才有效
		/// </summary>
		// Token: 0x06005507 RID: 21767 RVA: 0x00258F9F File Offset: 0x0025719F
		public void OpenDropDown()
		{
			this.Oooo.Oo_0O..oo_0OoO._.();
		}

		/// <summary>
		/// 关闭下拉窗口
		/// </summary>
		// Token: 0x06005508 RID: 21768 RVA: 0x00258FAC File Offset: 0x002571AC
		public void CloseDropDown()
		{
			this.Oooo.Oo_0O..O.Ooo_o0.();
		}

		/// <summary>
		/// 下拉窗口是否已经打开
		/// </summary>
		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06005509 RID: 21769 RVA: 0x00258FB9 File Offset: 0x002571B9
		public bool DroppedDown
		{
			get
			{
				return this.Oooo.Oo_0O..oO000o.oO_oO.();
			}
		}

		/// <summary>
		/// 返回底层控件
		/// </summary>
		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x00258FC6 File Offset: 0x002571C6
		internal OooOo0___oO BaseGrid
		{
			get
			{
				return this.Oooo.Oo_0O.;
			}
		}

		/// <summary>
		/// 刷新
		/// </summary>
		// Token: 0x0600550B RID: 21771 RVA: 0x00258FCE File Offset: 0x002571CE
		public new void Refresh()
		{
			this.Oooo.Oo_0O..Oo0o__.OO0o__O.();
		}

		// Token: 0x040022BA RID: 8890
		private OooOo0___oO <<EMPTY_NAME>>;
	}
}
