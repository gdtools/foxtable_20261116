using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.RibbonMenu
{
	// Token: 0x02000033 RID: 51
	[oO0oooo("2483")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(true)]
	public class RibbonTabCollection : IEnumerable
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00004932 File Offset: 0x00002B32
		public RibbonTabCollection(RibbonTabCollection A_0)
		{
			this.O_00Oo_.0. = A_0;
		}

		/// <summary>
		/// 增加功能区
		/// </summary>
		/// <param name="Tab">要增加的功能区</param>
		// Token: 0x06000196 RID: 406 RVA: 0x00004941 File Offset: 0x00002B41
		public void Add(Tab Tab)
		{
			this.O_00Oo_.0..Add(Tab.OO0.0OOo__.);
		}

		/// <summary>
		/// 插入功能区
		/// </summary>
		/// <param name="Index">插入位置</param>
		/// <param name="Tab">要插入的功能区</param>
		// Token: 0x06000197 RID: 407 RVA: 0x00004955 File Offset: 0x00002B55
		public void Insert(int Index, Tab Tab)
		{
			this.O_00Oo_.0..Insert(Index, Tab.OO0.0OOo__.);
		}

		/// <summary>
		/// 删除功能区
		/// </summary>
		/// <param name="Tab">要删除的功能区</param>
		// Token: 0x06000198 RID: 408 RVA: 0x00004969 File Offset: 0x00002B69
		public void Remove(Tab Tab)
		{
			if (Tab.OO0.0OOo__..OwnerCollection == this.O_00Oo_.0.)
			{
				this.O_00Oo_.0..Remove(Tab.OO0.0OOo__.);
			}
		}

		/// <summary>
		/// 删除指定名称的功能区
		/// </summary>
		/// <param name="TabName">要删除的功能区名称</param>
		// Token: 0x06000199 RID: 409 RVA: 0x0000498F File Offset: 0x00002B8F
		public void Remove(string TabName)
		{
			if (this.O_00Oo_.0..Contains(TabName))
			{
				this.O_00Oo_.0..Remove(this.O_00Oo_.0.[TabName]);
			}
		}

		/// <summary>
		/// 删除指定位置的功能区
		/// </summary>
		/// <param name="Index">要删除的功能区位置</param>
		// Token: 0x0600019A RID: 410 RVA: 0x000049B6 File Offset: 0x00002BB6
		public void RemoveAt(int Index)
		{
			this.O_00Oo_.0..RemoveAt(Index);
		}

		// Token: 0x170000B3 RID: 179
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tab this[object A_0]
		{
			get
			{
				Tab result;
				if (A_0 is string)
				{
					result = this[Conversions.ToString(A_0)];
				}
				else
				{
					result = this[Conversions.ToInteger(A_0)];
				}
				return result;
			}
		}

		// Token: 0x170000B4 RID: 180
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tab this[int A_0]
		{
			get
			{
				Tab result;
				if (A_0 < 0 | A_0 > this.O_00Oo_.0..Count - 1)
				{
					result = null;
				}
				else
				{
					result = new Tab(this.O_00Oo_.0.[A_0]);
				}
				return result;
			}
		}

		// Token: 0x170000B5 RID: 181
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tab this[string A_0]
		{
			get
			{
				Tab result;
				if (this.O_00Oo_.0..Contains(A_0))
				{
					result = this[this.O_00Oo_.0..IndexOf(this.O_00Oo_.0.[A_0])];
				}
				else
				{
					if (this.O_00Oo_.0. == Main.OO_O.o..O.OOO0_OOo.().Tabs)
					{
						try
						{
							foreach (object obj in Main.OO_O.o..O.OOO0_OOo.().ContextualTabGroups)
							{
								RibbonContextualTabGroup ribbonContextualTabGroup = (RibbonContextualTabGroup)obj;
								if (ribbonContextualTabGroup.Tabs.Contains(A_0))
								{
									return new Tab(ribbonContextualTabGroup.Tabs[A_0]);
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
					MessageBox.Show("菜单中不存在名为\"" + A_0 + "\"的功能区！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 删除所有功能区
		/// </summary>
		// Token: 0x0600019E RID: 414 RVA: 0x00004B20 File Offset: 0x00002D20
		public void Clear()
		{
			this.O_00Oo_.0..Clear();
		}

		/// <summary>
		/// 功能区总数
		/// </summary>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00004B2D File Offset: 0x00002D2D
		public int Count
		{
			get
			{
				return this.O_00Oo_.0..Count;
			}
		}

		/// <summary>
		/// 是否包括指定名称的功能区
		/// </summary>
		/// <param name="Name">功能区名称</param>
		// Token: 0x060001A0 RID: 416 RVA: 0x00004B3A File Offset: 0x00002D3A
		public bool Contains(string Name)
		{
			return this.O_00Oo_.0..Contains(Name);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00004B48 File Offset: 0x00002D48
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Contains(Tab g)
		{
			return this.O_00Oo_.0..Contains(g.OO0.0OOo__.);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00004B5B File Offset: 0x00002D5B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator()
		{
			return new RibbonTabEnumerator(this);
		}

		/// <summary>
		/// 返回或设置选定的功能区
		/// </summary>
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00004B63 File Offset: 0x00002D63
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00004B79 File Offset: 0x00002D79
		public Tab SelectedTab
		{
			get
			{
				return new Tab(Main.OO_O.o..O.OOO0_OOo.().SelectedTab);
			}
			set
			{
				Main.OO_O.o..O.OOO0_OOo.().SelectedTab = value.OO0.0OOo__.;
			}
		}

		/// <summary>
		/// 是否允许双击菜单标题后最小化菜单
		/// </summary>
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00004B90 File Offset: 0x00002D90
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00004BA1 File Offset: 0x00002DA1
		public bool AllowMinimize
		{
			get
			{
				return Main.OO_O.o..O.OOO0_OOo.().AllowMinimize;
			}
			set
			{
				Main.OO_O.o..O.OOO0_OOo.().AllowMinimize = value;
			}
		}

		/// <summary>
		/// 是否最小化菜单，只有AllowMinimize属性为True的时候，才属性才有效
		/// </summary>
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00004BB3 File Offset: 0x00002DB3
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00004BC4 File Offset: 0x00002DC4
		public bool Minimized
		{
			get
			{
				return Main.OO_O.o..O.OOO0_OOo.().Minimized;
			}
			set
			{
				Main.OO_O.o..O.OOO0_OOo.().Minimized = value;
			}
		}

		/// <summary>
		/// 是否隐藏功能区标题
		/// </summary>
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00004BD6 File Offset: 0x00002DD6
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00004BE7 File Offset: 0x00002DE7
		public bool HideTabHeaderRow
		{
			get
			{
				return Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow;
			}
			set
			{
				Main.OO_O.o..O.OOO0_OOo.().HideTabHeaderRow = value;
			}
		}

		// Token: 0x04000054 RID: 84
		private RibbonTabCollection <<EMPTY_NAME>>;
	}
}
