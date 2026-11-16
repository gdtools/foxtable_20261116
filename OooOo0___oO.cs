using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000244 RID: 580
	internal class OooOo0___oO : C1FlexGrid
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x000C0EA9 File Offset: 0x000BF0A9
		[CompilerGenerated]
		internal virtual DataTable <<EMPTY_NAME>>()
		{
			return this.OO_.O_O0O.;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000C0EB4 File Offset: 0x000BF0B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(DataTable A_0)
		{
			DataColumnChangeEventHandler value = new DataColumnChangeEventHandler(this.O_._0o00_.);
			DataRowChangeEventHandler value2 = new DataRowChangeEventHandler(this.O_._0o00_.);
			DataTable oo_.O_O0O. = this.OO_.O_O0O.;
			if (oo_.O_O0O. != null)
			{
				oo_.O_O0O..ColumnChanged -= value;
				oo_.O_O0O..RowChanged -= value2;
			}
			this.OO_.O_O0O. = A_0;
			oo_.O_O0O. = this.OO_.O_O0O.;
			if (oo_.O_O0O. != null)
			{
				oo_.O_O0O..ColumnChanged += value;
				oo_.O_O0O..RowChanged += value2;
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000C0F12 File Offset: 0x000BF112
		[CompilerGenerated]
		internal virtual O_0 <<EMPTY_NAME>>()
		{
			return this.OO_.O_O0O.;
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000C0F1C File Offset: 0x000BF11C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(O_0 A_0)
		{
			EventHandler value = new EventHandler(this.O_0._o0_.);
			O_0 oo_.O_O0O. = this.OO_.O_O0O.;
			if (oo_.O_O0O. != null)
			{
				oo_.O_O0O..CurrentChanged -= value;
			}
			this.OO_.O_O0O. = A_0;
			oo_.O_O0O. = this.OO_.O_O0O.;
			if (oo_.O_O0O. != null)
			{
				oo_.O_O0O..CurrentChanged += value;
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000C0F60 File Offset: 0x000BF160
		public OooOo0___oO()
		{
			base.AfterEdit += this.o__00__0._OO00.;
			base.BeforeEdit += this.oo_0OoO._.;
			base.CellButtonClick += this.o_0O.OO__0.;
			base.ChangeEdit += this.OOo_._0.;
			base.KeyDown += this.OOo_._0.;
			base.KeyDownEdit += this.O_0o.0OOo.;
			base.KeyPressEdit += this.OOo_._0.;
			base.KeyUpEdit += this.OOo_._0.;
			base.OwnerDrawCell += this.OOo_._0.;
			base.SetupEditor += this.O_0o.0OOo.;
			base.StartEdit += this.OOo_._0.;
			base.ValidateEdit += this.OO_.O_O0O.;
			base.PreviewKeyDown += this.OOo_._0.;
			this.OO_.O_O0O. = new List<string>();
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000C1068 File Offset: 0x000BF268
		public OooOo0___oO(Table A_0, string A_1, bool A_2, bool A_3 = false)
		{
			base.AfterEdit += this.o__00__0._OO00.;
			base.BeforeEdit += this.oo_0OoO._.;
			base.CellButtonClick += this.o_0O.OO__0.;
			base.ChangeEdit += this.OOo_._0.;
			base.KeyDown += this.OOo_._0.;
			base.KeyDownEdit += this.O_0o.0OOo.;
			base.KeyPressEdit += this.OOo_._0.;
			base.KeyUpEdit += this.OOo_._0.;
			base.OwnerDrawCell += this.OOo_._0.;
			base.SetupEditor += this.O_0o.0OOo.;
			base.StartEdit += this.OOo_._0.;
			base.ValidateEdit += this.OO_.O_O0O.;
			base.PreviewKeyDown += this.OOo_._0.;
			this.OO_.O_O0O. = new List<string>();
			this.O.OOoo_o0. = A_0;
			if (Operators.CompareString(A_1, "", true) > 0)
			{
				this.OO_.O_O0O..AddRange(A_1.Split(new char[]
				{
					','
				}));
			}
			this.O.OOoo_o0. = A_2;
			this.oOo.__00o. = A_3;
			this.Ooo_oO._0O.();
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000C11B8 File Offset: 0x000BF3B8
		internal void <<EMPTY_NAME>>()
		{
			if (this.O.OOoo_o0. == null)
			{
				base.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
				Main.OO_O.o..o.O000oo.(new object[]
				{
					this
				});
				base.Enabled = false;
				this.OO_.O_O0O.(null);
				this.OO_.O_O0O.(null);
				return;
			}
			base.Enabled = true;
			this.OO_.O_O0O.(this.O.OOoo_o0..View);
			this.OO_.O_O0O.(this.O.OOoo_o0..DataTable.BaseTable);
			base.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom;
			Main.OO_O.o..Oo.oOo_o0Oo0.(Main.OO_O.o..o0_o_o_0.0O.(this.O.OOoo_o0..Grid), new object[]
			{
				this
			});
			if (this.oOo.__00o.)
			{
				this.Font = this.O.OOoo_o0..Grid.Font;
			}
			base.Styles.Alternate.Clear();
			if (this.oOo.__00o.)
			{
				this.Font = this.O.OOoo_o0..Grid.Font;
			}
			base.Cols.Count = 2;
			base.Cols.Fixed = 1;
			base.Rows.Fixed = 0;
			base.Rows.Count = 0;
			base.ExtendLastCol = true;
			List<string> list = new List<string>();
			if (this.OO_.O_O0O..Count > 0)
			{
				list.AddRange(this.OO_.O_O0O.);
			}
			else
			{
				try
				{
					foreach (Col col in this.O.OOoo_o0..Cols)
					{
						list.Add(col.Name);
					}
				}
				finally
				{
					IEnumerator<Col> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			try
			{
				foreach (string a_ in list)
				{
					Col col2 = this.O.OOoo_o0..Cols[a_];
					if (this.OO_.O_O0O..Count == 0 || (this.OO_.O_O0O..Contains(col2.Name) && this.O.OOoo_o0.) || (!this.OO_.O_O0O..Contains(col2.Name) && !this.O.OOoo_o0.))
					{
						base.AddItem(col2.ShortCaption);
						base.Rows[base.Rows.Count - 1].UserData = col2.Name;
						if (this.OO_.O_O0O..Count == 0)
						{
							base.Rows[base.Rows.Count - 1].Visible = col2.ShowInRecordGrid;
						}
						base.Rows[base.Rows.Count - 1].Height = base.Rows.DefaultSize * col2.RecordRowHeight;
						CellStyle styleNew = base.GetCellRange(base.Rows.Count - 1, 1).StyleNew;
						styleNew.DataType = this.O.OOoo_o0..DataTable.BaseTable.Columns[col2.Name].DataType;
						Column column = this.O.OOoo_o0..foxGrid.Cols[col2.Name];
						styleNew.DataMap = column.DataMap;
						styleNew.EditMask = column.EditMask;
						styleNew.Editor = column.Editor;
						styleNew.Format = column.Format;
						styleNew.ImageMap = column.ImageMap;
						if (styleNew.DataType == typeof(string))
						{
							styleNew.WordWrap = true;
						}
						base.Rows[base.Rows.Count - 1].ImageAndText = column.ImageAndText;
					}
				}
			}
			finally
			{
				List<string>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			base.SelectionMode = SelectionModeEnum.Cell;
			base.FocusRect = FocusRectEnum.Solid;
			base.AllowResizing = AllowResizingEnum.BothUniform;
			base.Cols[1].TextAlign = TextAlignEnum.LeftCenter;
			base.AutoClipboard = true;
			this.AutoSizeCol(0, 10);
			base.KeyActionEnter = KeyActionEnum.MoveDown;
			base.KeyActionTab = KeyActionEnum.MoveDown;
			this.CellButtonImage = a.O0__0.Oo0oo_.().ToBitmap();
			base.DrawMode = DrawModeEnum.OwnerDraw;
			base.Cols[0].Style = base.Styles.Fixed;
			this.Oo0o__.OO0o__O.();
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000C1604 File Offset: 0x000BF804
		internal void <<EMPTY_NAME>>()
		{
			int num = base.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string a_ = base.Rows[i].UserData.ToString();
				base.Rows[i].Visible = this.O.OOoo_o0..Cols[a_].ShowInRecordGrid;
				base.Rows[1].Height = base.Rows.DefaultSize * this.O.OOoo_o0..Cols[a_].RecordRowHeight;
				base[i, 0] = this.O.OOoo_o0..Cols[a_].ShortCaption;
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000C16C0 File Offset: 0x000BF8C0
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				this.O.OOoo_o0..Current[base.Rows[A_1.Row].UserData.ToString()] = RuntimeHelpers.GetObjectValue(this.GetData(A_1.Row, A_1.Col));
				this.O.OOoo_o0..foxGrid.O.O0_0.(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index, new RecordGrid(this));
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x000C1778 File Offset: 0x000BF978
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null && A_1.Col > 0)
			{
				if (this.O.OOoo_o0..Current == null || this.O.OOoo_o0..Position < 0 || Operators.CompareString(this.O.OOoo_o0..Cols[base.Rows[A_1.Row].UserData.ToString()].DataCol.BaseColumn.Expression, "", true) > 0)
				{
					A_1.Cancel = true;
					return;
				}
				CellRange cellRange = base.GetCellRange(A_1.Row, A_1.Col);
				RowColEventArgs rowColEventArgs = new RowColEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index);
				this.O.OOoo_o0..foxGrid.O.O0_0.(this, rowColEventArgs, new RecordGrid(this));
				A_1.Cancel = rowColEventArgs.Cancel;
				this.O.OOoo_o0..foxGrid.o_O.Oo. = !A_1.Cancel;
				Column column = this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()];
				cellRange.StyleNew.Editor = column.Editor;
				cellRange.StyleNew.ComboList = column.ComboList;
				cellRange.StyleNew.DataMap = column.DataMap;
				cellRange.StyleNew.ImageMap = column.ImageMap;
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000C191D File Offset: 0x000BFB1D
		internal void <<EMPTY_NAME>>()
		{
			this.OO_.O_O0O.(null);
			this.OO_.O_O0O.(null);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000C192D File Offset: 0x000BFB2D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Oo0o__.OO0o__O.();
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000C1938 File Offset: 0x000BFB38
		internal void <<EMPTY_NAME>>()
		{
			DataRowView dataRowView = this.O.OOoo_o0..View.o_o.O0ooOo.();
			if (dataRowView == null)
			{
				int num = base.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					this.SetData(i, 1, null, false);
				}
			}
			else
			{
				int num2 = base.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					this.SetData(j, 1, RuntimeHelpers.GetObjectValue(dataRowView[base.Rows[j].UserData.ToString()]), false);
				}
			}
			base.Invalidate();
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000C19D4 File Offset: 0x000BFBD4
		private void <<EMPTY_NAME>>(object A_0, DataColumnChangeEventArgs A_1)
		{
			if (this.O.OOoo_o0..Current != null && A_1.Row == this.O.OOoo_o0..Current.DataRow.BaseRow)
			{
				int num = base.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = base.Rows[i].UserData.ToString();
					if (Operators.CompareString(text, A_1.Column.ColumnName, true) == 0)
					{
						if (A_1.ProposedValue == DBNull.Value)
						{
							this.SetData(i, 1, null);
						}
						else
						{
							this.SetData(i, 1, RuntimeHelpers.GetObjectValue(A_1.ProposedValue));
						}
					}
					else if (Operators.CompareString(text, "", true) > 0 && Operators.CompareString(this.oO000o.oO_oO.().Columns[text].Expression, "", true) > 0)
					{
						this.SetData(i, 1, RuntimeHelpers.GetObjectValue(A_1.Row[text]));
					}
				}
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000C1AD8 File Offset: 0x000BFCD8
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				this.O.OOoo_o0..Cols[base.Rows[A_1.Row].UserData.ToString()];
				this.O.OOoo_o0..foxGrid.o_.OO.(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index, new RecordGrid(this));
				A_1.Cancel = true;
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x000C1B80 File Offset: 0x000BFD80
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Col col = this.O.OOoo_o0..Cols[base.Rows[base.Row].UserData.ToString()];
			DataCol dataCol = this.O.OOoo_o0..DataTable.DataCols[col.Name];
			DataRow dataRow = this.O.OOoo_o0..Current.DataRow;
			if (base[base.Row, base.Col] != null && base[base.Row, base.Col] != DBNull.Value)
			{
				string a_ = base[base.Row, base.Col].ToString();
				Oo00.o00O0O_.O.(dataRow, dataCol, dataCol.FTPClient, a_, dataCol.AutoUpdate);
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000C1C44 File Offset: 0x000BFE44
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Col col = this.O.OOoo_o0..Cols[base.Rows[base.Row].UserData.ToString()];
			DataCol dataCol = this.O.OOoo_o0..DataTable.DataCols[col.Name];
			DataRow dataRow = this.O.OOoo_o0..Current.DataRow;
			if (base[base.Row, base.Col] != null && base[base.Row, base.Col] != DBNull.Value)
			{
				string text = base[base.Row, base.Col].ToString();
				if (!text.StartsWith("[") || !text.EndsWith("]"))
				{
					Oo00.o0_o._O_.(dataRow, dataCol, dataCol.FTPClient, text, dataCol.AutoUpdate);
				}
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000C1D20 File Offset: 0x000BFF20
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Col col = this.O.OOoo_o0..Cols[base.Rows[base.Row].UserData.ToString()];
			DataCol dataCol = this.O.OOoo_o0..DataTable.DataCols[col.Name];
			DataRow dataRow = this.O.OOoo_o0..Current.DataRow;
			List<string> list = new List<string>();
			list = Oo00.O____0O._0.(dataRow, dataCol, dataCol.FTPClient, "");
			if (list != null && list.Count > 0)
			{
				string text = list[0];
				int maxLength = dataCol.MaxLength;
				if (maxLength < text.Length && maxLength > 0)
				{
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行\"更改列\"命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				this.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.O.OOoo_o0., this.O.OOoo_o0..View.o_o.O0ooOo.().Row, dataCol.Name));
				base[base.Row, base.Col] = text;
				this.o__00__0._OO00.(this, new RowColEventArgs(base.Row, base.Col));
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000C1E44 File Offset: 0x000C0044
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Col col = this.O.OOoo_o0..Cols[base.Rows[base.Row].UserData.ToString()];
			DataCol dataCol = this.O.OOoo_o0..DataTable.DataCols[col.Name];
			string text = Oo00.O____0O._0.(this.O.OOoo_o0..Current.DataRow, dataCol, dataCol.FTPClient, "");
			if (Operators.CompareString(text, "", true) > 0)
			{
				int maxLength = dataCol.MaxLength;
				if (maxLength < text.Length && maxLength > 0)
				{
					MessageBox.Show("文件路径长度超过当前列允许输入的最大长度；请在菜单中，执行\"更改列\"命令，调整列的长度属性，或将列类型改为备注型。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				this.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.O.OOoo_o0., this.O.OOoo_o0..View.o_o.O0ooOo.().Row, dataCol.Name));
				base[base.Row, base.Col] = text;
				this.o__00__0._OO00.(this, new RowColEventArgs(base.Row, base.Col));
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000C1F58 File Offset: 0x000C0158
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Col col = this.O.OOoo_o0..Cols[base.Rows[base.Row].UserData.ToString()];
			this.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.O.OOoo_o0., this.O.OOoo_o0..Current.DataRow.BaseRow, col.Name));
			string dataDisplay = this.GetDataDisplay(base.Row, base.Col);
			if (Operators.CompareString(dataDisplay, "", true) > 0)
			{
				DataCol a_ = this.O.OOoo_o0..DataTable.DataCols[col.Name];
				if (!Oo00.OO.0O0o.(this.O.OOoo_o0..Current.DataRow, a_, dataDisplay))
				{
					return;
				}
			}
			base[base.Row, base.Col] = DBNull.Value;
			this.o__00__0._OO00.(this, new RowColEventArgs(base.Row, base.Col));
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x000C2050 File Offset: 0x000C0250
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				this.O.OOoo_o0..foxGrid.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), base.Rows[base.Row].UserData.ToString(), new RecordGrid(this));
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000C209C File Offset: 0x000C029C
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null && base.Col == 1 && base.Row >= 0 && this.O.OOoo_o0..Current != null)
			{
				DataRow a_ = this.O.OOoo_o0..Current.BaseDataRow;
				string a_2 = base.Rows[base.Row].UserData.ToString();
				if ((A_1.Control && A_1.KeyCode == Keys.X) || (A_1.Shift && A_1.KeyCode == Keys.Delete) || A_1.KeyCode == Keys.Delete)
				{
					this.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.O.OOoo_o0., a_, a_2));
					return;
				}
				if ((A_1.Control && A_1.KeyCode == Keys.V) || (A_1.Shift && A_1.KeyCode == Keys.Insert))
				{
					this.O.OOoo_o0..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.O.OOoo_o0., a_, a_2));
				}
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000C2198 File Offset: 0x000C0398
		private void <<EMPTY_NAME>>(object A_0, KeyEditEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				KeyEditEventArgs a_ = new KeyEditEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index, new KeyEventArgs(A_1.KeyData));
				this.O.OOoo_o0..foxGrid.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), a_, base.Rows[A_1.Row].UserData.ToString(), base.Editor, new RecordGrid(this), false);
				A_1.Handled = A_1.Handled;
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000C2254 File Offset: 0x000C0454
		private void <<EMPTY_NAME>>(object A_0, KeyPressEditEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				KeyPressEditEventArgs keyPressEditEventArgs = new KeyPressEditEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index, A_1.KeyChar);
				this.O.OOoo_o0..foxGrid.o_.OO.(RuntimeHelpers.GetObjectValue(A_0), keyPressEditEventArgs, base.Editor, new RecordGrid(this));
				A_1.Handled = keyPressEditEventArgs.Handled;
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000C22EC File Offset: 0x000C04EC
		private void <<EMPTY_NAME>>(object A_0, KeyEditEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				KeyEditEventArgs a_ = new KeyEditEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index, new KeyEventArgs(A_1.KeyData));
				this.O.OOoo_o0..foxGrid.O._o0O0o0o0.(RuntimeHelpers.GetObjectValue(A_0), a_, base.Rows[A_1.Row].UserData.ToString(), base.Editor, new RecordGrid(this));
				A_1.Handled = A_1.Handled;
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000C23A4 File Offset: 0x000C05A4
		private void <<EMPTY_NAME>>(object A_0, OwnerDrawCellEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null && A_1.Col == 1)
			{
				string a_ = base.Rows[A_1.Row].UserData.ToString();
				if (this.O.OOoo_o0..Cols[a_].DataCol.ExtendColumnType == ExtendColumnTypeEnum.色彩)
				{
					Rectangle bounds = A_1.Bounds;
					if (this.Selection.Contains(A_1.Row, A_1.Col))
					{
						bounds = new Rectangle(bounds.X + 1, bounds.Y + 1, bounds.Width - 4, bounds.Height - 4);
						A_1.Graphics.DrawRectangle(Pens.Gray, bounds);
						bounds = new Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 3, bounds.Height - 3);
					}
					else
					{
						bounds = new Rectangle(bounds.X + 2, bounds.Y + 2, bounds.Width - 5, bounds.Height - 5);
					}
					if (base[A_1.Row, A_1.Col] != null && base[A_1.Row, A_1.Col] != DBNull.Value)
					{
						A_1.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(Conversions.ToInteger(base[A_1.Row, A_1.Col]))), bounds);
					}
					A_1.DrawCell(DrawCellFlags.Border);
					A_1.Handled = true;
				}
				else if (this.O.OOoo_o0..Cols[a_].DataCol.ExtendColumnType == ExtendColumnTypeEnum.时段 && base[A_1.Row, A_1.Col] != null && base[A_1.Row, A_1.Col] != DBNull.Value)
				{
					double a_2 = Conversions.ToDouble(base[A_1.Row, A_1.Col]);
					string text = "";
					if (O_O0OO.o.00O_O.(a_2, ref text))
					{
						A_1.Text = text;
					}
				}
				if (!A_1.Handled)
				{
					MethodInfo methodInfo = this.O.OOoo_o0..DataTable.OO00.oO_.;
					if (methodInfo == null && this.O.OOoo_o0..DataTable.GlobalHandler.DrawCell && O_O0OO.O0_00o.o0__o..oO0o_.__O0. != null)
					{
						methodInfo = O_O0OO.O0_00o.o0__o..oO0o_.__O0.;
					}
					if (methodInfo != null && this.O.OOoo_o0..Current != null)
					{
						Col a_3 = this.O.OOoo_o0..Cols[base.Rows[A_1.Row].UserData.ToString()];
						DrawCellEventArgs drawCellEventArgs = new DrawCellEventArgs(this.O.OOoo_o0., this.O.OOoo_o0..Current, a_3, A_1, this, false);
						try
						{
							methodInfo.Invoke(null, new object[]
							{
								drawCellEventArgs
							});
							if (!A_1.Handled && Operators.CompareString(drawCellEventArgs.Style, "", true) > 0)
							{
								string name = "User" + drawCellEventArgs.Style;
								if (this.O.OOoo_o0..Grid.Styles.Contains(name) && !base.Styles.Contains(name))
								{
									base.Styles.Add(name, this.O.OOoo_o0..Grid.Styles[name]);
								}
								if (base.Styles.Contains(name))
								{
									A_1.Style = base.Styles[name];
								}
							}
						}
						catch (Exception a_4)
						{
							if (methodInfo == O_O0OO.O0_00o.o0__o..oO0o_.__O0.)
							{
								O_O0OO.O0_00o.o0__o..oO0o_.__O0. = null;
								ooO.oOo0Oo.o.(a_4, "全局表事件,DrawCell");
							}
							else
							{
								this.O.OOoo_o0..DataTable.OO00.oO_. = null;
								ooO.oOo0Oo.o.(a_4, "表，" + this.O.OOoo_o0..DataTable.Name + "，DrawCell");
							}
							MessageBox.Show("DrawCell事件执行错误，在您修正代码之前，将暂停执行该事件代码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000C27A0 File Offset: 0x000C09A0
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				RowColEventArgs a_ = new RowColEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index);
				this.O.OOoo_o0..foxGrid.OO0o_o_OO.O_O.(this, a_, new RecordGrid(this));
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000C2818 File Offset: 0x000C0A18
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				if (this.O.OOoo_o0..foxGrid.O_._. == BooleanEnum.Default)
				{
					RowColEventArgs rowColEventArgs = new RowColEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index);
					this.O.OOoo_o0..foxGrid.OOOo_oO_O.O.(this, rowColEventArgs, new RecordGrid(this));
					A_1.Cancel = rowColEventArgs.Cancel;
					return;
				}
				if (this.O.OOoo_o0..foxGrid.O_._. == BooleanEnum.False)
				{
					A_1.Cancel = true;
				}
				this.O.OOoo_o0..foxGrid.O_._. = BooleanEnum.Default;
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000C28E0 File Offset: 0x000C0AE0
		private void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1)
		{
			if (this.oO000o.oO_oO.() != null)
			{
				ValidateEditEventArgs validateEditEventArgs = new ValidateEditEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[A_1.Row].UserData.ToString()].Index, A_1.Checkbox);
				this.O.OOoo_o0..foxGrid.O_._.(this, validateEditEventArgs, new RecordGrid(this));
				A_1.Cancel = validateEditEventArgs.Cancel;
				if (!A_1.Cancel)
				{
					this.O.Ooo_o0.();
				}
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000C297C File Offset: 0x000C0B7C
		internal void <<EMPTY_NAME>>()
		{
			System.Windows.Forms.Control editor = base.GetCellRange(base.Row, base.Col).StyleNew.Editor;
			if (base.Editor != null && base.Editor is C1DropDownControl && base.Editor == base.Editor)
			{
				((C1DropDownControl)base.Editor).OpenDropDown();
			}
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000C29DC File Offset: 0x000C0BDC
		internal void <<EMPTY_NAME>>()
		{
			System.Windows.Forms.Control editor = base.GetCellRange(base.Row, base.Col).StyleNew.Editor;
			if (base.Editor != null && base.Editor is C1DropDownControl && base.Editor == base.Editor)
			{
				((C1DropDownControl)base.Editor).CloseDropDown();
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000C2A3C File Offset: 0x000C0C3C
		public bool <<EMPTY_NAME>>()
		{
			System.Windows.Forms.Control editor = base.GetCellRange(base.Row, base.Col).StyleNew.Editor;
			bool droppedDown;
			if (base.Editor != null && base.Editor is C1DropDownControl && base.Editor == base.Editor)
			{
				droppedDown = ((C1DropDownControl)base.Editor).DroppedDown;
			}
			return droppedDown;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000C2A9E File Offset: 0x000C0C9E
		private void <<EMPTY_NAME>>(object A_0, DataRowChangeEventArgs A_1)
		{
			if (A_1.Action == DataRowAction.Rollback)
			{
				this.Oo0o__.OO0o__O.();
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x000C2AB0 File Offset: 0x000C0CB0
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if (((this.O.OOoo_o0..foxGrid.o_O.Oo. && OO_00oOO.OSVersion() == 10 && base.Row >= base.Rows.Fixed) & base.Col >= base.Cols.Fixed) && base.Editor == null && A_1.KeyCode == Keys.ProcessKey && base.GetCellRange(base.Row, 1).StyleNew.DataType == typeof(string))
			{
				RowColEventArgs rowColEventArgs = new RowColEventArgs(this.O.OOoo_o0..foxGrid.Row, this.O.OOoo_o0..foxGrid.Cols[base.Rows[base.Row].UserData.ToString()].Index);
				this.O.OOoo_o0..foxGrid.OOOo_oO_O.O.(this, rowColEventArgs, new RecordGrid(this));
				if (rowColEventArgs.Cancel)
				{
					this.O.OOoo_o0..foxGrid.O_._. = BooleanEnum.False;
				}
				else
				{
					this.O.OOoo_o0..foxGrid.O_._. = BooleanEnum.True;
				}
				if (!rowColEventArgs.Cancel)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.GetData(base.Row, base.Col));
					string text = "";
					if (objectValue != null)
					{
						text = objectValue.ToString();
					}
					base.StartEditing();
					Application.DoEvents();
					if (Operators.CompareString(base.Editor.Text, text, true) != 0)
					{
						text = base.Editor.Text;
						base.Editor.Text = "";
						SendKeys.Send(text);
					}
				}
			}
		}

		// Token: 0x04000BA8 RID: 2984
		internal Table <<EMPTY_NAME>>;

		// Token: 0x04000BA9 RID: 2985
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x04000BAA RID: 2986
		[CompilerGenerated]
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000BAB RID: 2987
		[CompilerGenerated]
		private O_0 <<EMPTY_NAME>>;

		// Token: 0x04000BAC RID: 2988
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000BAD RID: 2989
		internal bool <<EMPTY_NAME>>;
	}
}
