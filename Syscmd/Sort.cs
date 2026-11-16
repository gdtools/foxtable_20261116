using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 和排序相关的系统命令
	/// </summary>
	// Token: 0x02000545 RID: 1349
	[StandardModule]
	[oO0oooo("0116")]
	public sealed class Sort
	{
		/// <summary>
		/// 升序排序
		/// </summary>
		// Token: 0x06005AE6 RID: 23270 RVA: 0x0026D098 File Offset: 0x0026B298
		public static void Ascending()
		{
			Sort.OO.OO_0o.(false);
		}

		/// <summary>
		/// 降序排序
		/// </summary>
		// Token: 0x06005AE7 RID: 23271 RVA: 0x0026D0A0 File Offset: 0x0026B2A0
		public static void Descending()
		{
			Sort.OO.OO_0o.(true);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x0026D0A8 File Offset: 0x0026B2A8
		private static void <<EMPTY_NAME>>(bool A_0)
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				table.ClearEditInfos();
				string text = "";
				string text2 = "";
				int leftCol = table.foxGrid.Selection.LeftCol;
				int rightCol = table.foxGrid.Selection.RightCol;
				for (int i = leftCol; i <= rightCol; i++)
				{
					if (Operators.CompareString(text2, "", true) > 0)
					{
						text2 += ",";
					}
					string text3 = table.foxGrid.Cols[i].Name.ToLower();
					text2 += text3;
					if (A_0)
					{
						text2 += " DESC";
					}
					if (table.O_O__.ooOo..ContainsKey(text3.ToLower()))
					{
						table.O_O__.ooOo..Remove(text3);
					}
				}
				try
				{
					foreach (string text4 in table.O_O__.ooOo..Keys)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += ",";
						}
						if (table.O_O__.ooOo.[text4] == ListSortDirection.Descending)
						{
							text = text + text4 + " DESC";
						}
						else
						{
							text += text4;
						}
					}
				}
				finally
				{
					Dictionary<string, ListSortDirection>.KeyCollection.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (Operators.CompareString(text2, "", true) > 0)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						table.Sort = text2 + "," + text;
						return;
					}
					table.Sort = text2;
				}
			}
		}

		/// <summary>
		/// 取消排序
		/// </summary>
		// Token: 0x06005AE9 RID: 23273 RVA: 0x0026D240 File Offset: 0x0026B440
		public static void UnSort()
		{
			Table table = OO_00oOO.CurrentTable;
			if (table != null)
			{
				table.ClearEditInfos();
				table.View.o_O_.00o.("");
				table.Sort = "";
			}
		}
	}
}
