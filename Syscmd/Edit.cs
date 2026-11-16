using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.Syscmd
{
	/// <summary>
	/// 和编辑相关的系统命令
	/// </summary>
	// Token: 0x02000541 RID: 1345
	[StandardModule]
	public sealed class Edit
	{
		/// <summary>
		/// 系列填充
		/// </summary>
		// Token: 0x06005A48 RID: 23112 RVA: 0x00265460 File Offset: 0x00263660
		[oO0oooo("0140")]
		public static void SerialFill()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.O0O_OOoOoO.O.();
			}
		}

		/// <summary>
		/// 重复填充
		/// </summary>
		// Token: 0x06005A49 RID: 23113 RVA: 0x00265473 File Offset: 0x00263673
		[oO0oooo("0140")]
		public static void RepeatFill()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.oo.00O.();
			}
		}

		/// <summary>
		/// 查找
		/// </summary>
		// Token: 0x06005A4A RID: 23114 RVA: 0x00265488 File Offset: 0x00263688
		[oO0oooo("0138")]
		public static void Find()
		{
			if (Edit.oo0Oo0Oo.OO. == null || Edit.oo0Oo0Oo.OO..IsDisposed)
			{
				Edit.oo0Oo0Oo.OO. = new o0o\u3002();
			}
			Edit.oo0Oo0Oo.OO..Owner = Main.OO_O.o.;
			Edit.oo0Oo0Oo.OO..o.0___.(false);
			Edit.oo0Oo0Oo.OO..Show();
		}

		/// <summary>
		/// 替换
		/// </summary>
		// Token: 0x06005A4B RID: 23115 RVA: 0x002654D8 File Offset: 0x002636D8
		[oO0oooo("0139")]
		public static void Replace()
		{
			if (Edit.oo_0o_.___o0O. == null || Edit.oo_0o_.___o0O..IsDisposed)
			{
				Edit.oo_0o_.___o0O. = new o0o\u3002();
			}
			Edit.oo_0o_.___o0O..Owner = Main.OO_O.o.;
			Edit.oo_0o_.___o0O..o.0___.(true);
			Edit.oo_0o_.___o0O..Text = "替换";
			Edit.oo_0o_.___o0O..Show();
		}

		/// <summary>
		/// 撤销
		/// </summary>
		// Token: 0x06005A4C RID: 23116 RVA: 0x00265535 File Offset: 0x00263735
		public static void Undo()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Undo();
			}
		}

		/// <summary>
		/// 重做
		/// </summary>
		// Token: 0x06005A4D RID: 23117 RVA: 0x00265548 File Offset: 0x00263748
		public static void Redo()
		{
			if (OO_00oOO.CurrentTable != null)
			{
				OO_00oOO.CurrentTable.Redo();
			}
		}

		/// <summary>
		/// 复制
		/// </summary>
		// Token: 0x06005A4E RID: 23118 RVA: 0x0026555B File Offset: 0x0026375B
		public static void Copy()
		{
			SendKeys.Send("^C");
		}

		/// <summary>
		/// 粘贴
		/// </summary>
		// Token: 0x06005A4F RID: 23119 RVA: 0x00265567 File Offset: 0x00263767
		public static void Paste()
		{
			SendKeys.Send("^V");
		}

		/// <summary>
		/// 剪切
		/// </summary>
		// Token: 0x06005A50 RID: 23120 RVA: 0x00265573 File Offset: 0x00263773
		public static void Cut()
		{
			SendKeys.Send("^X");
		}

		/// <summary>
		/// 删除
		/// </summary>
		// Token: 0x06005A51 RID: 23121 RVA: 0x0026557F File Offset: 0x0026377F
		public static void Delete()
		{
			SendKeys.Send("{DELETE}");
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x0026558B File Offset: 0x0026378B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void InsertFile()
		{
			OO_00oOO.CurrentTable;
		}

		/// <summary>
		/// 插入符号
		/// </summary>
		// Token: 0x06005A53 RID: 23123 RVA: 0x00265593 File Offset: 0x00263793
		[oO0oooo("0142")]
		public static void Symbol()
		{
			if (Edit.oo0Oo0Oo.OO. == null || Edit.oo0Oo0Oo.OO..IsDisposed)
			{
				Edit.oo0Oo0Oo.OO. = new O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002();
			}
			Edit.oo0Oo0Oo.OO..Owner = Main.OO_O.o.;
			Edit.oo0Oo0Oo.OO..Show();
		}

		/// <summary>
		/// 还原数据
		/// </summary>
		// Token: 0x06005A54 RID: 23124 RVA: 0x002655CC File Offset: 0x002637CC
		[oO0oooo("1631")]
		public static void Reject()
		{
			List<DataRow> list = new List<DataRow>();
			if (OO_00oOO.CurrentTable != null)
			{
				CellRange cellRange = OO_00oOO.CurrentTable.foxGrid.Selection;
				if (cellRange.BottomRow != -1 && cellRange.TopRow != -1 && cellRange.LeftCol != -1 && cellRange.RightCol != -1)
				{
					if ((cellRange.RightCol - cellRange.LeftCol + 1) * (cellRange.BottomRow - cellRange.TopRow + 1) < 500)
					{
						OO_00oOO.CurrentTable.O_o0OOo_.o0..O__00.__0_O.(new oOOOo0oOOOO_(OO_00oOO.CurrentTable, OO_00oOO.CurrentTable.foxGrid.Selection));
					}
					else
					{
						if (MessageBox.Show("确定要还原选定区域吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						{
							return;
						}
						OO_00oOO.CurrentTable.ClearEditInfos();
					}
					cellRange = default(CellRange);
					Table table = OO_00oOO.CurrentTable;
					int num = table.TopPosition;
					int num2 = table.BottomPosition;
					for (int i = num; i <= num2; i++)
					{
						DataRow dataRow = table.Rows[i].BaseDataRow;
						if (dataRow.RowState == DataRowState.Modified)
						{
							int leftCol = table.foxGrid.Selection.LeftCol;
							int rightCol = table.foxGrid.Selection.RightCol;
							for (int j = leftCol; j <= rightCol; j++)
							{
								string name = table.foxGrid.Cols[j].Name;
								if (Operators.CompareString(dataRow[name].ToString(), dataRow[name, DataRowVersion.Original].ToString(), true) != 0)
								{
									dataRow[name] = RuntimeHelpers.GetObjectValue(dataRow[name, DataRowVersion.Original]);
								}
							}
						}
						list.Add(dataRow);
					}
					try
					{
						foreach (DataRow dataRow in list)
						{
							Oo00.o0_o._O_.(dataRow);
						}
					}
					finally
					{
						List<DataRow>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		/// <summary>
		/// 清零
		/// </summary>
		// Token: 0x06005A55 RID: 23125 RVA: 0x002657D8 File Offset: 0x002639D8
		[oO0oooo("1648")]
		public static void ClearZero()
		{
			Table table = OO_00oOO.CurrentTable;
			int leftCol = table.foxGrid.Selection.LeftCol;
			int rightCol = table.foxGrid.Selection.RightCol;
			for (int i = leftCol; i <= rightCol; i++)
			{
				string name = table.foxGrid.Cols[i].Name;
				if (table.DataTable.DataCols[name].IsNumeric)
				{
					int num = table.TopPosition;
					int num2 = table.BottomPosition;
					for (int j = num; j <= num2; j++)
					{
						DataRow dataRow = table.Rows[j].BaseDataRow;
						if (!dataRow.IsNull(name) && Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow[name])) == 0.0)
						{
							dataRow[name] = null;
						}
					}
				}
			}
		}

		// Token: 0x0400233A RID: 9018
		private static o0o\u3002 <<EMPTY_NAME>>;

		// Token: 0x0400233B RID: 9019
		private static o0o\u3002 <<EMPTY_NAME>>;

		// Token: 0x0400233C RID: 9020
		private static O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002 <<EMPTY_NAME>>;
	}
}
