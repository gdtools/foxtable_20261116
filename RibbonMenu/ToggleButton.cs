using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	/// <summary>
	/// 状态按钮
	/// </summary>
	// Token: 0x02000017 RID: 23
	[ComVisible(true)]
	public class ToggleButton : RibbonItem
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00003032 File Offset: 0x00001232
		internal ToggleButton(RibbonToggleButton A_0) : base(A_0)
		{
			this.o__Oo__.O__. = A_0;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003042 File Offset: 0x00001242
		public ToggleButton(string A_0)
		{
			this.o__Oo__.O__. = new RibbonToggleButton();
			this.oOo_.0o_O_O_0. = this.o__Oo__.O__.;
			this.o__Oo__.O__..ID = A_0;
		}

		/// <summary>
		/// 返回或者设置状态按钮的标题
		/// </summary>
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000306D File Offset: 0x0000126D
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000307A File Offset: 0x0000127A
		public string Text
		{
			get
			{
				return this.o__Oo__.O__..Text;
			}
			set
			{
				this.o__Oo__.O__..Text = value;
			}
		}

		/// <summary>
		/// 返回或者设置状态按钮是否处于按下状态
		/// </summary>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003088 File Offset: 0x00001288
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00003095 File Offset: 0x00001295
		public bool Pressed
		{
			get
			{
				return this.o__Oo__.O__..Pressed;
			}
			set
			{
				this.o__Oo__.O__..Pressed = value;
			}
		}

		/// <summary>
		/// 快捷键
		/// </summary>
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000030A3 File Offset: 0x000012A3
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000030B0 File Offset: 0x000012B0
		public Keys ShortcutKeys
		{
			get
			{
				return this.o__Oo__.O__..ShortcutKeys;
			}
			set
			{
				this.o__Oo__.O__..ShortcutKeys = value;
			}
		}

		/// <summary>
		/// 用于设置状态按钮的分组名
		/// </summary>
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000030BE File Offset: 0x000012BE
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000030CB File Offset: 0x000012CB
		public string GroupName
		{
			get
			{
				return this.o__Oo__.O__..ToggleGroupName;
			}
			set
			{
				this.o__Oo__.O__..ToggleGroupName = value;
				this.o__Oo__.O__..CanDepress = (Operators.CompareString(value, "", true) == 0);
			}
		}

		// Token: 0x04000020 RID: 32
		internal RibbonToggleButton <<EMPTY_NAME>>;
	}
}
