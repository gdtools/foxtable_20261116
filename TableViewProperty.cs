using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200033C RID: 828
	internal class TableViewProperty
	{
		// Token: 0x0600324A RID: 12874 RVA: 0x001569FC File Offset: 0x00154BFC
		public TableViewProperty(Table A_0)
		{
			this.O._o0O_0. = "";
			this.o_o_.oo_0O. = "";
			this.o._O0o_00. = "";
			this.O_.Oo_o0OOOOO. = "";
			this.Oo0.___ooOo_o. = "";
			this.oo.O_oO_O. = "";
			this.o.00_o_oOoOOoO. = "";
			this.Ooo_O0.0. = "";
			this.Oo_._O0oOOOo. = A_0;
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x00156A6E File Offset: 0x00154C6E
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x00156A76 File Offset: 0x00154C76
		public TableViewSettingEnum ViewSetting
		{
			get
			{
				return this.Oo_._O0oOOOo.;
			}
			set
			{
				this.Oo_._O0oOOOo. = value;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x00156A80 File Offset: 0x00154C80
		// (set) Token: 0x0600324E RID: 12878 RVA: 0x00156AB2 File Offset: 0x00154CB2
		public string Sort
		{
			get
			{
				string result;
				if ((this.ViewSetting & TableViewSettingEnum.Sort) == TableViewSettingEnum.Sort)
				{
					result = this.Oo_._O0oOOOo..View.oO_O.o_OOO.();
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.o.00_o_oOoOOoO. = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x00156ABC File Offset: 0x00154CBC
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x00156AEE File Offset: 0x00154CEE
		public string Filter
		{
			get
			{
				string result;
				if ((this.ViewSetting & TableViewSettingEnum.Filter) == TableViewSettingEnum.Filter)
				{
					result = this.Oo_._O0oOOOo..View.get_Filter();
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.Ooo_O0.0. = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x00156AF8 File Offset: 0x00154CF8
		// (set) Token: 0x06003252 RID: 12882 RVA: 0x00156B91 File Offset: 0x00154D91
		public string RowHeight
		{
			get
			{
				string result;
				if ((this.ViewSetting & TableViewSettingEnum.RowHeight) == TableViewSettingEnum.RowHeight)
				{
					string text = this.Oo_._O0oOOOo..foxGrid.Rows.DefaultSize.ToString();
					int num = this.Oo_._O0oOOOo..foxGrid.Rows.Fixed - 1;
					for (int i = 0; i <= num; i++)
					{
						text = text + "\t" + Conversions.ToString(this.Oo_._O0oOOOo..foxGrid.Rows[i].Height);
					}
					result = text;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.O_.Oo_o0OOOOO. = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x00156B9C File Offset: 0x00154D9C
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x00156C25 File Offset: 0x00154E25
		public string ColumnString
		{
			get
			{
				string text = "";
				int @fixed = this.Oo_._O0oOOOo..foxGrid.Cols.Fixed;
				int num = this.Oo_._O0oOOOo..foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\t";
					}
					text += this.Oo_._O0oOOOo..foxGrid.Cols[i].Name;
				}
				return text;
			}
			set
			{
				this.O._o0O_0. = value;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x00156C30 File Offset: 0x00154E30
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x00156CBE File Offset: 0x00154EBE
		public string ColumnWidth
		{
			get
			{
				string text = "";
				int @fixed = this.Oo_._O0oOOOo..foxGrid.Cols.Fixed;
				int num = this.Oo_._O0oOOOo..foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\t";
					}
					text += Conversions.ToString(this.Oo_._O0oOOOo..foxGrid.Cols[i].Width);
				}
				return text;
			}
			set
			{
				this.o_o_.oo_0O. = value;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x00156CC8 File Offset: 0x00154EC8
		// (set) Token: 0x06003258 RID: 12888 RVA: 0x00156D68 File Offset: 0x00154F68
		public string ColumnVisible
		{
			get
			{
				string text = "";
				int @fixed = this.Oo_._O0oOOOo..foxGrid.Cols.Fixed;
				int num = this.Oo_._O0oOOOo..foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\t";
					}
					if (this.Oo_._O0oOOOo..foxGrid.Cols[i].Visible)
					{
						text += Conversions.ToString(1);
					}
					else
					{
						text += Conversions.ToString(0);
					}
				}
				return text;
			}
			set
			{
				this.o._O0o_00. = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x00156D74 File Offset: 0x00154F74
		// (set) Token: 0x0600325A RID: 12890 RVA: 0x00156E08 File Offset: 0x00155008
		public string Groups
		{
			get
			{
				string result;
				if ((this.ViewSetting & TableViewSettingEnum.Subtotal) == TableViewSettingEnum.Subtotal)
				{
					string text = "";
					try
					{
						foreach (SubtotalGroup a_ in this.Oo_._O0oOOOo..SubtotalGroups)
						{
							if (Operators.CompareString(text, "", true) > 0)
							{
								text += "\r";
							}
							text += o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\n', false);
						}
					}
					finally
					{
						IEnumerator<SubtotalGroup> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result = text;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.Oo0.___ooOo_o. = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x00156E11 File Offset: 0x00155011
		// (set) Token: 0x0600325C RID: 12892 RVA: 0x00156E1E File Offset: 0x0015501E
		public bool GroupAboveData
		{
			get
			{
				return this.Oo_._O0oOOOo..GroupAboveData;
			}
			set
			{
				this.o0._0o_. = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x00156E27 File Offset: 0x00155027
		// (set) Token: 0x0600325E RID: 12894 RVA: 0x00156E34 File Offset: 0x00155034
		public bool TreeVisible
		{
			get
			{
				return this.Oo_._O0oOOOo..TreeVisible;
			}
			set
			{
				this.o_o0o._O. = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x00156E3D File Offset: 0x0015503D
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x00156E4A File Offset: 0x0015504A
		public bool Subtotal
		{
			get
			{
				return this.Oo_._O0oOOOo..IsSubtotal;
			}
			set
			{
				this.o0o_oo00_0_0.O. = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x00156E54 File Offset: 0x00155054
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x00156EE4 File Offset: 0x001550E4
		public string MergeCols
		{
			get
			{
				string result;
				if ((this.ViewSetting & TableViewSettingEnum.Merge) == TableViewSettingEnum.Merge)
				{
					string text = "";
					try
					{
						foreach (string str in this.Oo_._O0oOOOo..MergeCols)
						{
							if (Operators.CompareString(text, "", true) > 0)
							{
								text += ",";
							}
							text += str;
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = text;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.O00o_.__O. = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x00156EF0 File Offset: 0x001550F0
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x00156F1D File Offset: 0x0015511D
		public string MergeSort
		{
			get
			{
				string result;
				if ((this.ViewSetting & TableViewSettingEnum.Merge) == TableViewSettingEnum.Merge)
				{
					result = this.Oo_._O0oOOOo..MergeSort;
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.o_.0o0oOo_. = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x00156F26 File Offset: 0x00155126
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x00156F33 File Offset: 0x00155133
		public MergeModeEnum MergeMode
		{
			get
			{
				return this.Oo_._O0oOOOo..MergeMode;
			}
			set
			{
				this.o0._0o_. = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x00156F3C File Offset: 0x0015513C
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x00156F49 File Offset: 0x00155149
		public bool AllowMerge
		{
			get
			{
				return this.Oo_._O0oOOOo..AllowMerge;
			}
			set
			{
				this.oOO.o00OOO_o. = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x00156F54 File Offset: 0x00155154
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x00156FC8 File Offset: 0x001551C8
		public string PrintInfo
		{
			get
			{
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						return "";
					}
				}
				catch (Exception ex)
				{
					return "";
				}
				string result;
				if ((this.ViewSetting & TableViewSettingEnum.PrintInfo) == TableViewSettingEnum.PrintInfo)
				{
					result = o_O_o_oOoo__.OOOO_OO._oo.(this.Oo_._O0oOOOo..PrintInfo, false, '\n', false);
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				this.oo.O_oO_O. = value;
			}
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00156FD4 File Offset: 0x001551D4
		internal void Restore()
		{
			if (Operators.CompareString(this.O._o0O_0., "", true) > 0 && Operators.CompareString(this.o_o_.oo_0O., "", true) > 0 && Operators.CompareString(this.o._O0o_00., "", true) > 0)
			{
				string[] array = this.O._o0O_0..Split(new char[]
				{
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				string[] array2 = this.o_o_.oo_0O..Split(new char[]
				{
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				string[] array3 = this.o._O0o_00..Split(new char[]
				{
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				int num = this.Oo_._O0oOOOo..foxGrid.Cols.Fixed;
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (this.Oo_._O0oOOOo..foxGrid.Cols.Contains(array[i]))
					{
						if ((this.ViewSetting & TableViewSettingEnum.ColWidth) == TableViewSettingEnum.ColWidth)
						{
							this.Oo_._O0oOOOo..foxGrid.Cols[array[i]].Width = Convert.ToInt32(array2[i]);
						}
						if ((this.ViewSetting & TableViewSettingEnum.ColPosition) == TableViewSettingEnum.ColPosition)
						{
							this.Oo_._O0oOOOo..foxGrid.Cols[array[i]].Move(num);
						}
						if ((this.ViewSetting & TableViewSettingEnum.ColVisible) == TableViewSettingEnum.ColVisible)
						{
							if (Convert.ToInt32(array3[i]) == 1)
							{
								this.Oo_._O0oOOOo..foxGrid.Cols[array[i]].Visible = true;
							}
							else
							{
								this.Oo_._O0oOOOo..foxGrid.Cols[array[i]].Visible = false;
							}
						}
						num++;
					}
				}
			}
			if ((this.ViewSetting & TableViewSettingEnum.RowHeight) == TableViewSettingEnum.RowHeight && Operators.CompareString(this.O_.Oo_o0OOOOO., "", true) > 0)
			{
				string[] array4 = this.O_.Oo_o0OOOOO..Split(new char[]
				{
					'\t'
				});
				this.Oo_._O0oOOOo..foxGrid.Rows.DefaultSize = Convert.ToInt32(array4[0]);
				int num3 = Math.Min(array4.Length - 1, this.Oo_._O0oOOOo..foxGrid.Rows.Fixed);
				for (int j = 1; j <= num3; j++)
				{
					this.Oo_._O0oOOOo..foxGrid.Rows[j - 1].Height = Convert.ToInt32(array4[j]);
				}
			}
			if ((this.ViewSetting & TableViewSettingEnum.Sort) == TableViewSettingEnum.Sort)
			{
				this.Oo_._O0oOOOo..Sort = this.o.00_o_oOoOOoO.;
			}
			if ((this.ViewSetting & TableViewSettingEnum.Filter) == TableViewSettingEnum.Filter)
			{
				this.Oo_._O0oOOOo..Filter = this.Ooo_O0.0.;
			}
			if ((this.ViewSetting & TableViewSettingEnum.Merge) == TableViewSettingEnum.Merge && Operators.CompareString(this.O00o_.__O., "", true) > 0)
			{
				string[] array5 = this.O00o_.__O..Split(new char[]
				{
					','
				}, StringSplitOptions.RemoveEmptyEntries);
				this.Oo_._O0oOOOo..MergeCols.Clear();
				foreach (string item in array5)
				{
					this.Oo_._O0oOOOo..MergeCols.Add(item);
				}
				this.Oo_._O0oOOOo..MergeMode = this.o0._0o_.;
				this.Oo_._O0oOOOo..MergeSort = this.o_.0o0oOo_.;
				this.Oo_._O0oOOOo..AllowMerge = this.oOO.o00OOO_o.;
			}
			if ((this.ViewSetting & TableViewSettingEnum.Subtotal) == TableViewSettingEnum.Subtotal)
			{
				string[] array7 = this.Oo0.___ooOo_o..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				this.Oo_._O0oOOOo..SubtotalGroups.Clear();
				this.Oo_._O0oOOOo..GroupAboveData = this.o0._0o_.;
				this.Oo_._O0oOOOo..TreeVisible = this.o_o0o._O.;
				foreach (string a_ in array7)
				{
					SubtotalGroup subtotalGroup = new SubtotalGroup();
					o_O_o_oOoo__.OOOO_OO._oo.(subtotalGroup, a_, '\n');
					this.Oo_._O0oOOOo..SubtotalGroups.Add(subtotalGroup);
				}
				if (this.Oo_._O0oOOOo..SubtotalGroups.Count > 0 | this.o0o_oo00_0_0.O.)
				{
					this.Oo_._O0oOOOo..Subtotal(false);
				}
				else if (this.Oo_._O0oOOOo..IsSubtotal)
				{
					this.Oo_._O0oOOOo..ClearSubtotal();
				}
			}
			if ((this.ViewSetting & TableViewSettingEnum.PrintInfo) == TableViewSettingEnum.PrintInfo && Operators.CompareString(this.oo.O_oO_O., "", true) > 0)
			{
				this.Oo_._O0oOOOo..PrintInfo = new PrintInfo(this.Oo_._O0oOOOo.);
				o_O_o_oOoo__.OOOO_OO._oo.(this.Oo_._O0oOOOo..PrintInfo, this.oo.O_oO_O., '\n');
				if (OO_00oOO.CurrentTable == this.Oo_._O0oOOOo.)
				{
					OO_00oOO.Vars["SysUpdatePrintInfo"] = true;
				}
			}
		}

		// Token: 0x04001422 RID: 5154
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001423 RID: 5155
		private TableViewSettingEnum <<EMPTY_NAME>>;

		// Token: 0x04001424 RID: 5156
		private string <<EMPTY_NAME>>;

		// Token: 0x04001425 RID: 5157
		private string <<EMPTY_NAME>>;

		// Token: 0x04001426 RID: 5158
		private string <<EMPTY_NAME>>;

		// Token: 0x04001427 RID: 5159
		private string <<EMPTY_NAME>>;

		// Token: 0x04001428 RID: 5160
		private string <<EMPTY_NAME>>;

		// Token: 0x04001429 RID: 5161
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400142A RID: 5162
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400142B RID: 5163
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400142C RID: 5164
		private string <<EMPTY_NAME>>;

		// Token: 0x0400142D RID: 5165
		private string <<EMPTY_NAME>>;

		// Token: 0x0400142E RID: 5166
		private MergeModeEnum <<EMPTY_NAME>>;

		// Token: 0x0400142F RID: 5167
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001430 RID: 5168
		private string <<EMPTY_NAME>>;

		// Token: 0x04001431 RID: 5169
		private string <<EMPTY_NAME>>;

		// Token: 0x04001432 RID: 5170
		private string <<EMPTY_NAME>>;
	}
}
