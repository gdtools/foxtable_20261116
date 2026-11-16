using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 和折叠模式相关的系统命令
	/// </summary>
	// Token: 0x0200053F RID: 1343
	[oO0oooo("3720")]
	[StandardModule]
	public sealed class GridTree
	{
		/// <summary>
		/// 增加子行
		/// </summary>
		// Token: 0x06005A22 RID: 23074 RVA: 0x00262018 File Offset: 0x00260218
		public static void AddChild()
		{
			if (Row.OO.OO_0o.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					table.O_.OOoO_Oo.();
				}
			}
		}

		/// <summary>
		/// 增加行
		/// </summary>
		// Token: 0x06005A23 RID: 23075 RVA: 0x0026203C File Offset: 0x0026023C
		public static void AddSlibing()
		{
			if (Row.OO.OO_0o.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					if (table.foxGrid.OO.o_o00o.())
					{
						table.O_.o__ooo.(false);
						return;
					}
					table.O____o.0.();
				}
			}
		}

		/// <summary>
		/// 插入行
		/// </summary>
		// Token: 0x06005A24 RID: 23076 RVA: 0x00262078 File Offset: 0x00260278
		public static void InsertSlibing()
		{
			if (Row.OO.OO_0o.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					if (table.foxGrid.OO.o_o00o.())
					{
						table.O_.o__ooo.(true);
						return;
					}
					table.Oo0_0o.0.();
				}
			}
		}

		/// <summary>
		/// 克隆行
		/// </summary>
		// Token: 0x06005A25 RID: 23077 RVA: 0x002620B4 File Offset: 0x002602B4
		public static void Clone()
		{
			if (Row.OO.OO_0o.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					if (table.foxGrid.OO.o_o00o.())
					{
						table.O0o._o00.();
						return;
					}
					table.oo_Oo.oO_0oO.();
				}
			}
		}

		/// <summary>
		/// 上移行
		/// </summary>
		// Token: 0x06005A26 RID: 23078 RVA: 0x002620EC File Offset: 0x002602EC
		public static void MoveUp()
		{
			if (GridTree.O0O0o.Oo0OO_oO.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					if (table.GridTreeVisible)
					{
						table.oo._O_.();
						return;
					}
					if (table.foxGrid.OO.o_o00o.())
					{
						table.ooo_oo__O_o.O.();
					}
				}
			}
		}

		/// <summary>
		/// 下移行
		/// </summary>
		// Token: 0x06005A27 RID: 23079 RVA: 0x0026212C File Offset: 0x0026032C
		public static void MoveDown()
		{
			if (GridTree.O0O0o.Oo0OO_oO.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					if (table.GridTreeVisible)
					{
						table.O0_0o_o.O0.();
						return;
					}
					if (table.foxGrid.OO.o_o00o.())
					{
						table.o00_0oO0_._.();
					}
				}
			}
		}

		/// <summary>
		/// 左移行
		/// </summary>
		// Token: 0x06005A28 RID: 23080 RVA: 0x0026216C File Offset: 0x0026036C
		public static void MoveLeft()
		{
			if (GridTree.O0O0o.Oo0OO_oO.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					table.o_Ooo.O00o_.();
				}
			}
		}

		/// <summary>
		/// 右移行
		/// </summary>
		// Token: 0x06005A29 RID: 23081 RVA: 0x00262190 File Offset: 0x00260390
		public static void MoveRight()
		{
			if (GridTree.O0O0o.Oo0OO_oO.())
			{
				Table table = OO_00oOO.CurrentTable;
				if (table != null)
				{
					table.oOoo_Oo.o00.();
				}
			}
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x002621B4 File Offset: 0x002603B4
		internal static bool <<EMPTY_NAME>>()
		{
			return OO_00oOO.CurrentTable.AllowEdit;
		}
	}
}
