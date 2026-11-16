using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000079 RID: 121
	internal class o0_o_o_0 : C1DropDownControl
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0001ECFA File Offset: 0x0001CEFA
		[CompilerGenerated]
		private virtual CustomCheckedListBox <<EMPTY_NAME>>()
		{
			return this.o_.O_.;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001ED02 File Offset: 0x0001CF02
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(CustomCheckedListBox A_0)
		{
			this.o_.O_. = A_0;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001ED0B File Offset: 0x0001CF0B
		[CompilerGenerated]
		private virtual O\u3002\u3000 <<EMPTY_NAME>>()
		{
			return this.o_o.O_0OOO.;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001ED14 File Offset: 0x0001CF14
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(O\u3002\u3000 A_0)
		{
			EventHandler value = new EventHandler(this.o._0__00_oo.);
			O\u3002\u3000 o_u3002_u = this.o_o.O_0OOO.;
			if (o_u3002_u != null)
			{
				o_u3002_u.Disposed -= value;
			}
			this.o_o.O_0OOO. = A_0;
			o_u3002_u = this.o_o.O_0OOO.;
			if (o_u3002_u != null)
			{
				o_u3002_u.Disposed += value;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001ED58 File Offset: 0x0001CF58
		public o0_o_o_0()
		{
			base.DropDownOpened += this.O0oo0o.o_o_.;
			base.FontChanged += this.O._0.;
			base.GotFocus += this.o_O.0O.;
			base.KeyDown += this.o._0__00_oo.;
			base.KeyPress += this.o._0__00_oo.;
			this.o_o.O_0OOO. = ",";
			this.o_.O_. = true;
			this.ShowUpDownButtons = false;
			this.DataType = typeof(string);
			this.o_.O_.(new O\u3002\u3000());
			this.O.0o0O.(this.o.O0.().O__0o.o0_.());
			this.DropDownForm = this.o.O0.();
			base.VisualStyle = C1.Win.C1Input.VisualStyle.System;
			this.o.O0.().O__0o.o0_.().Font = this.Font;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001EE33 File Offset: 0x0001D033
		protected virtual void <<EMPTY_NAME>>(ref Message A_0)
		{
			if (A_0.Msg != 770 || this.o._0__00_oo.())
			{
				base.WndProc(ref A_0);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001EE51 File Offset: 0x0001D051
		public string <<EMPTY_NAME>>()
		{
			return this.o_o.O_0OOO.;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001EE59 File Offset: 0x0001D059
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.o_o.O_0OOO. = A_0;
			this.o.O0.().O__0o.o0_.().Separator = A_0;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001EE73 File Offset: 0x0001D073
		public bool <<EMPTY_NAME>>()
		{
			return this.o_.O_.;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001EE7B File Offset: 0x0001D07B
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o_.O_. = A_0;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001EE84 File Offset: 0x0001D084
		public CheckedListBox.ObjectCollection <<EMPTY_NAME>>()
		{
			return this.o.O0.().Items;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001EE91 File Offset: 0x0001D091
		public string <<EMPTY_NAME>>()
		{
			return this.o.O0.().DisplayMember;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001EE9E File Offset: 0x0001D09E
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.o.O0.().DisplayMember = A_0;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		public string <<EMPTY_NAME>>()
		{
			return this.o.O0.().ValueMember;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001EEB9 File Offset: 0x0001D0B9
		public void <<EMPTY_NAME>>(string A_0)
		{
			this.o.O0.().ValueMember = A_0;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001EEC7 File Offset: 0x0001D0C7
		public object <<EMPTY_NAME>>()
		{
			return this.o.O0.().DataSource;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001EED4 File Offset: 0x0001D0D4
		public void <<EMPTY_NAME>>(object A_0)
		{
			string a_ = this.oOo_o_o000.o.();
			this.o.O0.().DataSource = RuntimeHelpers.GetObjectValue(A_0);
			this.OoO00_0_._0.(a_);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001EF00 File Offset: 0x0001D100
		public bool <<EMPTY_NAME>>()
		{
			return this.o.O0.().MultiColumn;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001EF0D File Offset: 0x0001D10D
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.o.O0.().MultiColumn = A_0;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001EF1B File Offset: 0x0001D11B
		public int <<EMPTY_NAME>>()
		{
			return this.o.O0.().ColumnWidth;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001EF28 File Offset: 0x0001D128
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.o.O0.().ColumnWidth = A_0;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001EF36 File Offset: 0x0001D136
		public int <<EMPTY_NAME>>()
		{
			return this.o_o.O_0OOO.;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001EF3E File Offset: 0x0001D13E
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.o_o.O_0OOO. = A_0;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001EF47 File Offset: 0x0001D147
		public int <<EMPTY_NAME>>()
		{
			return this.O0.0oOO00O.;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001EF4F File Offset: 0x0001D14F
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O0.0oOO00O. = A_0;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001EF58 File Offset: 0x0001D158
		public int <<EMPTY_NAME>>()
		{
			return this.O.o_.;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001EF60 File Offset: 0x0001D160
		public void <<EMPTY_NAME>>(int A_0)
		{
			this.O.o_. = A_0;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001EF6C File Offset: 0x0001D16C
		internal void <<EMPTY_NAME>>()
		{
			if (this.O_o.Ooo.() == 0)
			{
				this.o.O0.().Width = Math.Max(168, base.Width);
			}
			else
			{
				this.o.O0.().Width = Math.Max(131, this.O_o.Ooo.());
			}
			if (!this.oOo_o_o000.o.())
			{
				int num = Math.Min(this.oOo_o_o000.o.(), Math.Max(1, this.o.O0.().Items.Count));
				this.o.O0.().O__0o.o0_.().Height = this.o.O0.().O__0o.o0_.().ItemHeight * num + 4;
				this.o.O0.().Height = this.o.O0.().O__0o.o0_.().Height + 32;
				return;
			}
			if (this.o.O0.() > 0)
			{
				int num2 = (int)Convert.ToInt16(Math.Floor((double)(this.o.O0.() - 36) / (double)this.o.O0.().O__0o.o0_.().ItemHeight));
				num2 = Math.Max(1, num2);
				this.o.O0.().O__0o.o0_.().Height = this.o.O0.().O__0o.o0_.().ItemHeight * num2 + 4;
				this.o.O0.().Height = this.o.O0.().O__0o.o0_.().Height + 32;
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001F0A0 File Offset: 0x0001D2A0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_.O_.();
			if (this.Value == null)
			{
				this.o.O0.().Value = "";
			}
			else
			{
				this.o.O0.().Value = this.Value.ToString();
			}
			this.o.O0.().Owner = null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001F0EF File Offset: 0x0001D2EF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o.O0.().O__0o.o0_.().Font = this.Font;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001F107 File Offset: 0x0001D307
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_.O_.();
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001F110 File Offset: 0x0001D310
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (!this.o._0__00_oo.() && A_1.KeyCode == Keys.Delete)
			{
				A_1.Handled = true;
				A_1.SuppressKeyPress = true;
			}
			if (A_1.KeyCode == Keys.Down)
			{
				if (base.Parent is O_oOooO_O && ((O_oOooO_O)base.Parent).FinishEditing())
				{
					SendKeys.Send("{DOWN}");
					return;
				}
			}
			else if (A_1.KeyCode == Keys.Up && base.Parent is O_oOooO_O && ((O_oOooO_O)base.Parent).FinishEditing())
			{
				SendKeys.Send("{UP}");
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (!this.o._0__00_oo.())
			{
				A_1.Handled = true;
				A_1.KeyChar = '\0';
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0001F1BC File Offset: 0x0001D3BC
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0001F1E2 File Offset: 0x0001D3E2
		public new object Value
		{
			get
			{
				object result;
				if (base.Value == DBNull.Value)
				{
					result = null;
				}
				else
				{
					result = base.Value;
				}
				return result;
			}
			set
			{
				base.Value = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!Main.OO_O.o..Disposing && !Main.OO_O.o..IsDisposed && !Main.OO_O.o..o_O.o__.)
			{
				string right = "";
				bool flag;
				try
				{
					foreach (Table table in OO_00oOO.Tables)
					{
						if (Operators.CompareString(table.Name, table.DataTable.Name, true) == 0)
						{
							try
							{
								foreach (object obj in ((IEnumerable)table.Grid.Cols))
								{
									Column column = (Column)obj;
									if (column.Editor == this && table.DataTable.DataCols[column.Name].oO0._00o_0. == this)
									{
										flag = true;
										right = table.DataTable.Name;
										table.DataTable.DataCols[column.Name].oO0._00o_0. = null;
										break;
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (flag)
				{
					try
					{
						foreach (Table table2 in OO_00oOO.Tables)
						{
							if (Operators.CompareString(table2.DataTable.Name, right, true) == 0)
							{
								try
								{
									foreach (object obj2 in ((IEnumerable)table2.Grid.Cols))
									{
										Column column2 = (Column)obj2;
										if (column2.Editor == this)
										{
											column2.Editor = null;
											table2.Cols[column2.Name].o0.O.();
										}
									}
								}
								finally
								{
									IEnumerator enumerator4;
									if (enumerator4 is IDisposable)
									{
										(enumerator4 as IDisposable).Dispose();
									}
								}
							}
						}
						return;
					}
					finally
					{
						IEnumerator<Table> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				try
				{
					foreach (Table table3 in OO_00oOO.Tables)
					{
						try
						{
							foreach (object obj3 in ((IEnumerable)table3.Grid.Cols))
							{
								Column column3 = (Column)obj3;
								if (column3.Editor == this)
								{
									column3.Editor = null;
									Col col = table3.Cols[column3.Name];
									if (Operators.CompareString(col.o_0.oo., "", true) > 0)
									{
										col.ComboList = col.o_0.oo.;
									}
									else if (Operators.CompareString(col.DataSource, "", true) > 0)
									{
										col.DataSource = col.DataSource;
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator6;
							if (enumerator6 is IDisposable)
							{
								(enumerator6 as IDisposable).Dispose();
							}
						}
					}
				}
				finally
				{
					IEnumerator<Table> enumerator5;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
				}
			}
		}

		// Token: 0x04000131 RID: 305
		private string <<EMPTY_NAME>>;

		// Token: 0x04000132 RID: 306
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000133 RID: 307
		private int <<EMPTY_NAME>>;

		// Token: 0x04000134 RID: 308
		private int <<EMPTY_NAME>>;

		// Token: 0x04000135 RID: 309
		private int <<EMPTY_NAME>>;

		// Token: 0x04000136 RID: 310
		[CompilerGenerated]
		private CustomCheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04000137 RID: 311
		[CompilerGenerated]
		private O\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x04000138 RID: 312
		private const int <<EMPTY_NAME>> = 770;
	}
}
