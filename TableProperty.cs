using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200033B RID: 827
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class TableProperty
	{
		// Token: 0x060031A4 RID: 12708 RVA: 0x00154A48 File Offset: 0x00152C48
		public TableProperty(Table A_0)
		{
			this.OO0._O_Oo0__. = "";
			this.o__O.o_oOO00. = "";
			this.O_oooo.oo0. = "";
			this.OOoO0.ooooOOO0. = "";
			this.O.ooo_00O. = 20;
			this.O.O0Oo_0O. = "";
			this.Oo.oO_Oo. = "";
			this.O._o0O_0. = A_0;
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x00154AAC File Offset: 0x00152CAC
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x00154AB9 File Offset: 0x00152CB9
		[DefaultValue("宋体,9")]
		public Font Font
		{
			get
			{
				return this.O._o0O_0..Font;
			}
			set
			{
				this.O.ooo_00O. = value;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x00154AC2 File Offset: 0x00152CC2
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x00154ACF File Offset: 0x00152CCF
		public bool Listmode
		{
			get
			{
				return this.O._o0O_0..ListMode;
			}
			set
			{
				this.O._o0O_0. = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x00154AD8 File Offset: 0x00152CD8
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x00154B61 File Offset: 0x00152D61
		public string ColumnString
		{
			get
			{
				string text = "";
				int @fixed = this.O._o0O_0..foxGrid.Cols.Fixed;
				int num = this.O._o0O_0..foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\t";
					}
					text += this.O._o0O_0..foxGrid.Cols[i].Name;
				}
				return text;
			}
			set
			{
				this.OO0._O_Oo0__. = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x00154B6A File Offset: 0x00152D6A
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x00154B77 File Offset: 0x00152D77
		public string GrandTotalCols
		{
			get
			{
				return this.O._o0O_0..ooo_O0oOo.0O.;
			}
			set
			{
				this.O._o0O_0..ooo_O0oOo.0O. = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x00154B88 File Offset: 0x00152D88
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x00154C16 File Offset: 0x00152E16
		public string ColumnWidth
		{
			get
			{
				string text = "";
				int @fixed = this.O._o0O_0..foxGrid.Cols.Fixed;
				int num = this.O._o0O_0..foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\t";
					}
					text += Conversions.ToString(this.O._o0O_0..foxGrid.Cols[i].Width);
				}
				return text;
			}
			set
			{
				this.o__O.o_oOO00. = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x00154C20 File Offset: 0x00152E20
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x00154CC0 File Offset: 0x00152EC0
		public string ColumnVisible
		{
			get
			{
				string text = "";
				int @fixed = this.O._o0O_0..foxGrid.Cols.Fixed;
				int num = this.O._o0O_0..foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\t";
					}
					if (this.O._o0O_0..foxGrid.Cols[i].Visible)
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
				this.O_oooo.oo0. = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x00154CCC File Offset: 0x00152ECC
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x00154D46 File Offset: 0x00152F46
		public string FixedRowHeight
		{
			get
			{
				string text = "";
				int num = this.O._o0O_0..foxGrid.Rows.Fixed - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(text, "", true) > 0)
					{
						text += "\t";
					}
					text += Conversions.ToString(this.O._o0O_0..foxGrid.Rows[i].HeightDisplay);
				}
				return text;
			}
			set
			{
				this.OOoO0.ooooOOO0. = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x00154D4F File Offset: 0x00152F4F
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x00154D66 File Offset: 0x00152F66
		[DefaultValue(0)]
		public int FrozenCols
		{
			get
			{
				return this.O._o0O_0..foxGrid.Cols.Frozen;
			}
			set
			{
				this.O._o0O_0..foxGrid.Cols.Frozen = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x00154D7E File Offset: 0x00152F7E
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x00154D95 File Offset: 0x00152F95
		public int DefaultRowHeight
		{
			get
			{
				return this.O._o0O_0..foxGrid.Rows.DefaultSize;
			}
			set
			{
				this.O.ooo_00O. = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x00154DA0 File Offset: 0x00152FA0
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x00154DD4 File Offset: 0x00152FD4
		[DefaultValue("")]
		public string CrossTableName
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					result = this.O._o0O_0..O_0._O_0OO000O..TableName;
				}
				return result;
			}
			set
			{
				this.o0OoO_0_.0. = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x00154DE0 File Offset: 0x00152FE0
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x00154E14 File Offset: 0x00153014
		[DefaultValue("")]
		public string CrossTableCaption
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					result = this.O._o0O_0..O_0._O_0OO000O..Caption;
				}
				return result;
			}
			set
			{
				this.OO_o0o0.0_0. = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x00154E20 File Offset: 0x00153020
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x00154EBC File Offset: 0x001530BC
		[DefaultValue("")]
		public string CrossTableHGroups
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					string text = "";
					try
					{
						foreach (GroupOn a_ in this.O._o0O_0..O_0._O_0OO000O..HGroups)
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
						IEnumerator<GroupOn> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result = text;
				}
				return result;
			}
			set
			{
				this.OoO0o.O. = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x00154EC8 File Offset: 0x001530C8
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x00154F64 File Offset: 0x00153164
		[DefaultValue("")]
		public string CrossTableVGroups
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					string text = "";
					try
					{
						foreach (CrossGroupOn a_ in this.O._o0O_0..O_0._O_0OO000O..VGroups)
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
						IEnumerator<CrossGroupOn> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result = text;
				}
				return result;
			}
			set
			{
				this.oOo___0.0_. = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x00154F70 File Offset: 0x00153170
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x0015500C File Offset: 0x0015320C
		[DefaultValue("")]
		public string CrossTableTotals
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					string text = "";
					try
					{
						foreach (CrossTotalOn a_ in this.O._o0O_0..O_0._O_0OO000O..Totals)
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
						IEnumerator<CrossTotalOn> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result = text;
				}
				return result;
			}
			set
			{
				this.o0O0_o0_.OO. = value;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x00155018 File Offset: 0x00153218
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x0015504C File Offset: 0x0015324C
		[DefaultValue("")]
		public string GroupTableName
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					result = this.O._o0O_0..O_0._O_0OO000O..TableName;
				}
				return result;
			}
			set
			{
				this.oo__.0o0_0_. = value;
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x00155058 File Offset: 0x00153258
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x0015508C File Offset: 0x0015328C
		[DefaultValue("")]
		public string GroupTableCaption
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					result = this.O._o0O_0..O_0._O_0OO000O..Caption;
				}
				return result;
			}
			set
			{
				this.oOo__oOo.OOO__. = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x00155098 File Offset: 0x00153298
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x00155134 File Offset: 0x00153334
		[DefaultValue("")]
		public string GroupTableGroups
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					string text = "";
					try
					{
						foreach (GroupOn a_ in this.O._o0O_0..O_0._O_0OO000O..Groups)
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
						IEnumerator<GroupOn> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result = text;
				}
				return result;
			}
			set
			{
				this.oo__0_.o. = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060031C7 RID: 12743 RVA: 0x00155140 File Offset: 0x00153340
		// (set) Token: 0x060031C8 RID: 12744 RVA: 0x001551DC File Offset: 0x001533DC
		[DefaultValue("")]
		public string GroupTableTotals
		{
			get
			{
				string result;
				if (this.O._o0O_0..O_0._O_0OO000O. == null)
				{
					result = "";
				}
				else
				{
					string text = "";
					try
					{
						foreach (TotalOn a_ in this.O._o0O_0..O_0._O_0OO000O..Totals)
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
						IEnumerator<TotalOn> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					result = text;
				}
				return result;
			}
			set
			{
				this.O_.0__o00oO. = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x001551E8 File Offset: 0x001533E8
		// (set) Token: 0x060031CA RID: 12746 RVA: 0x00155268 File Offset: 0x00153468
		[DefaultValue("")]
		public string SubtotalGroups
		{
			get
			{
				string text = "";
				try
				{
					foreach (SubtotalGroup a_ in this.O._o0O_0..SubtotalGroups)
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
				return text;
			}
			set
			{
				this.O.O0Oo_0O. = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060031CB RID: 12747 RVA: 0x00155271 File Offset: 0x00153471
		// (set) Token: 0x060031CC RID: 12748 RVA: 0x0015527E File Offset: 0x0015347E
		[DefaultValue(false)]
		public bool GroupAboveData
		{
			get
			{
				return this.O._o0O_0..GroupAboveData;
			}
			set
			{
				this.O._o0O_0..GroupAboveData = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060031CD RID: 12749 RVA: 0x0015528C File Offset: 0x0015348C
		// (set) Token: 0x060031CE RID: 12750 RVA: 0x00155299 File Offset: 0x00153499
		[DefaultValue(false)]
		public bool TreeVisible
		{
			get
			{
				return this.O._o0O_0..TreeVisible;
			}
			set
			{
				this.O._o0O_0..TreeVisible = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060031CF RID: 12751 RVA: 0x001552A7 File Offset: 0x001534A7
		// (set) Token: 0x060031D0 RID: 12752 RVA: 0x001552B4 File Offset: 0x001534B4
		[DefaultValue(true)]
		public bool SpillNode
		{
			get
			{
				return this.O._o0O_0..SpillNode;
			}
			set
			{
				this.O._o0O_0..SpillNode = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060031D1 RID: 12753 RVA: 0x001552C4 File Offset: 0x001534C4
		// (set) Token: 0x060031D2 RID: 12754 RVA: 0x00155340 File Offset: 0x00153540
		[DefaultValue("")]
		public string MergeCols
		{
			get
			{
				string text = "";
				try
				{
					foreach (string str in this.O._o0O_0..MergeCols)
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
				return text;
			}
			set
			{
				if (!string.IsNullOrEmpty(value) && Operators.CompareString(value, "", true) != 0)
				{
					string[] array = value.Split(new char[]
					{
						','
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array.Length != 0)
					{
						this.O._o0O_0..MergeCols.Clear();
						foreach (string item in array)
						{
							this.O._o0O_0..MergeCols.Add(item);
						}
					}
				}
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060031D3 RID: 12755 RVA: 0x001553B0 File Offset: 0x001535B0
		// (set) Token: 0x060031D4 RID: 12756 RVA: 0x001553BD File Offset: 0x001535BD
		[DefaultValue("")]
		public string MergeSort
		{
			get
			{
				return this.O._o0O_0..MergeSort;
			}
			set
			{
				this.O._o0O_0..MergeSort = value;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060031D5 RID: 12757 RVA: 0x001553CB File Offset: 0x001535CB
		// (set) Token: 0x060031D6 RID: 12758 RVA: 0x001553D8 File Offset: 0x001535D8
		[DefaultValue(0)]
		public MergeModeEnum MergeMode
		{
			get
			{
				return this.O._o0O_0..MergeMode;
			}
			set
			{
				this.O._o0O_0..MergeMode = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060031D7 RID: 12759 RVA: 0x001553E8 File Offset: 0x001535E8
		// (set) Token: 0x060031D8 RID: 12760 RVA: 0x00155448 File Offset: 0x00153648
		[DefaultValue("")]
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
				return o_O_o_oOoo__.OOOO_OO._oo.(this.O._o0O_0..PrintInfo, false, '\n', false);
			}
			set
			{
				this.Oo.oO_Oo. = value;
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x00155454 File Offset: 0x00153654
		internal void Restore()
		{
			int num;
			int num9;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(this.OO0._O_Oo0__., "", true) <= 0 || Operators.CompareString(this.o__O.o_oOO00., "", true) <= 0)
				{
					goto IL_535;
				}
				IL_37:
				num2 = 3;
				string[] array = this.OO0._O_Oo0__..Split(new char[]
				{
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_51:
				num2 = 4;
				string[] array2 = this.o__O.o_oOO00..Split(new char[]
				{
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_6C:
				num2 = 5;
				string[] array3 = this.O_oooo.oo0..Split(new char[]
				{
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_87:
				num2 = 6;
				string[] array4 = this.O.O0Oo_0O..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_A2:
				num2 = 7;
				int num3 = this.O._o0O_0..foxGrid.Cols.Fixed;
				IL_BB:
				num2 = 8;
				int num4 = array.Length - 1;
				for (int i = 0; i <= num4; i++)
				{
					IL_CC:
					num2 = 9;
					if (this.O._o0O_0..foxGrid.Cols.Contains(array[i]))
					{
						IL_ED:
						num2 = 10;
						this.O._o0O_0..foxGrid.Cols[array[i]].Width = Convert.ToInt32(array2[i]);
						IL_118:
						num2 = 11;
						this.O._o0O_0..foxGrid.Cols[array[i]].Move(num3);
						IL_13B:
						num2 = 12;
						if (Convert.ToInt32(array3[i]) == 1)
						{
							IL_14B:
							num2 = 13;
							this.O._o0O_0..foxGrid.Cols[array[i]].Visible = true;
						}
						else
						{
							IL_16F:
							num2 = 15;
							this.O._o0O_0..foxGrid.Cols[array[i]].Visible = false;
						}
						IL_191:
						num2 = 16;
						num3++;
					}
					IL_19A:
					num2 = 17;
				}
				IL_1AC:
				num2 = 18;
				this.O._o0O_0..SubtotalGroups.Clear();
				IL_1BF:
				num2 = 19;
				foreach (string a_ in array4)
				{
					IL_1D2:
					num2 = 20;
					SubtotalGroup subtotalGroup = new SubtotalGroup();
					IL_1DC:
					num2 = 21;
					o_O_o_oOoo__.OOOO_OO._oo.(subtotalGroup, a_, '\n');
					IL_1EA:
					num2 = 22;
					this.O._o0O_0..SubtotalGroups.Add(subtotalGroup);
					IL_1FF:
					num2 = 23;
				}
				IL_210:
				num2 = 24;
				if (Operators.CompareString(this.oo__0_.o., "", true) <= 0 || Operators.CompareString(this.O_.0__o00oO., "", true) <= 0)
				{
					goto IL_362;
				}
				IL_241:
				num2 = 25;
				GroupTableBuilder groupTableBuilder = new GroupTableBuilder();
				IL_24B:
				num2 = 26;
				groupTableBuilder.TableName = this.oo__.0o0_0_.;
				IL_25B:
				num2 = 27;
				groupTableBuilder.Caption = this.oOo__oOo.OOO__.;
				IL_26B:
				num2 = 28;
				groupTableBuilder.SourceDataTable = this.O._o0O_0..DataTable;
				IL_280:
				num2 = 29;
				string[] array6 = this.oo__0_.o..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_29C:
				num2 = 30;
				string[] array7 = this.O_.0__o00oO..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_2B8:
				num2 = 31;
				foreach (string a_2 in array6)
				{
					IL_2CB:
					num2 = 32;
					GroupOn groupOn = new GroupOn();
					IL_2D5:
					num2 = 33;
					o_O_o_oOoo__.OOOO_OO._oo.(groupOn, a_2, '\n');
					IL_2E3:
					num2 = 34;
					groupTableBuilder.Groups.Add(groupOn);
					IL_2F4:
					num2 = 35;
				}
				IL_305:
				num2 = 36;
				foreach (string a_3 in array7)
				{
					IL_318:
					num2 = 37;
					TotalOn totalOn = new TotalOn();
					IL_322:
					num2 = 38;
					o_O_o_oOoo__.OOOO_OO._oo.(totalOn, a_3, '\n');
					IL_330:
					num2 = 39;
					groupTableBuilder.Totals.Add(totalOn);
					IL_341:
					num2 = 40;
				}
				IL_352:
				num2 = 41;
				this.O._o0O_0..O_0._O_0OO000O. = groupTableBuilder;
				IL_362:
				num2 = 42;
				if (Operators.CompareString(this.OoO0o.O., "", true) <= 0 || Operators.CompareString(this.oOo___0.0_., "", true) <= 0 || Operators.CompareString(this.o0O0_o0_.OO., "", true) <= 0)
				{
					goto IL_535;
				}
				IL_3AA:
				num2 = 43;
				CrossTableBuilder crossTableBuilder = new CrossTableBuilder();
				IL_3B4:
				num2 = 44;
				crossTableBuilder.TableName = this.o0OoO_0_.0.;
				IL_3C4:
				num2 = 45;
				crossTableBuilder.Caption = this.OO_o0o0.0_0.;
				IL_3D4:
				num2 = 46;
				crossTableBuilder.SourceDataTable = this.O._o0O_0..DataTable;
				IL_3E9:
				num2 = 47;
				string[] array10 = this.OoO0o.O..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_405:
				num2 = 48;
				string[] array11 = this.oOo___0.0_..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_421:
				num2 = 49;
				string[] array12 = this.o0O0_o0_.OO..Split(new char[]
				{
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_43D:
				num2 = 50;
				foreach (string a_4 in array10)
				{
					IL_450:
					num2 = 51;
					GroupOn groupOn2 = new GroupOn();
					IL_45A:
					num2 = 52;
					o_O_o_oOoo__.OOOO_OO._oo.(groupOn2, a_4, '\n');
					IL_468:
					num2 = 53;
					crossTableBuilder.HGroups.Add(groupOn2);
					IL_479:
					num2 = 54;
				}
				IL_48A:
				num2 = 55;
				foreach (string a_5 in array11)
				{
					IL_49D:
					num2 = 56;
					CrossGroupOn crossGroupOn = new CrossGroupOn();
					IL_4A7:
					num2 = 57;
					o_O_o_oOoo__.OOOO_OO._oo.(crossGroupOn, a_5, '\n');
					IL_4B5:
					num2 = 58;
					crossTableBuilder.VGroups.Add(crossGroupOn);
					IL_4C6:
					num2 = 59;
				}
				IL_4D7:
				num2 = 60;
				foreach (string a_6 in array12)
				{
					IL_4EA:
					num2 = 61;
					CrossTotalOn crossTotalOn = new CrossTotalOn(false);
					IL_4F5:
					num2 = 62;
					o_O_o_oOoo__.OOOO_OO._oo.(crossTotalOn, a_6, '\n');
					IL_503:
					num2 = 63;
					crossTableBuilder.Totals.Add(crossTotalOn);
					IL_514:
					num2 = 64;
				}
				IL_525:
				num2 = 65;
				this.O._o0O_0..O_0._O_0OO000O. = crossTableBuilder;
				IL_535:
				num2 = 66;
				this.O._o0O_0..o.OOoo_o. = this.Oo.oO_Oo.;
				IL_549:
				num2 = 67;
				if (this.O.ooo_00O. == null)
				{
					goto IL_56D;
				}
				IL_554:
				num2 = 68;
				this.O._o0O_0..foxGrid.Font = this.O.ooo_00O.;
				IL_56D:
				num2 = 69;
				this.O._o0O_0..ListMode = this.O._o0O_0.;
				IL_581:
				num2 = 70;
				this.O._o0O_0..foxGrid.Rows.DefaultSize = this.O.ooo_00O.;
				IL_59F:
				num2 = 71;
				if (Operators.CompareString(this.OO0._O_Oo0__., "", true) <= 0 || Operators.CompareString(this.o__O.o_oOO00., "", true) <= 0)
				{
					goto IL_657;
				}
				IL_5D0:
				num2 = 72;
				string[] array16 = this.OOoO0.ooooOOO0..Split(new char[]
				{
					'\t'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_5EC:
				num2 = 73;
				int num6 = Math.Min(array16.Length - 1, this.O._o0O_0..foxGrid.Rows.Fixed - 1);
				for (int num7 = 0; num7 <= num6; num7++)
				{
					IL_618:
					num2 = 74;
					int height = int.Parse(array16[num7]);
					IL_627:
					num2 = 75;
					this.O._o0O_0..foxGrid.Rows[num7].Height = height;
					IL_648:
					num2 = 76;
				}
				IL_657:
				goto IL_7DD;
				IL_65C:
				int num8 = num9 + 1;
				num9 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8);
				IL_79E:
				goto IL_7D2;
				IL_7A0:
				num9 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7B0:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num9 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_7A0;
			}
			IL_7D2:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7DD:
			if (num9 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x00155C64 File Offset: 0x00153E64
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x00155C71 File Offset: 0x00153E71
		[DefaultValue(1)]
		public DockAreaEnum DockArea
		{
			get
			{
				return this.O._o0O_0.._frdDockArea;
			}
			set
			{
				this.O._o0O_0.._frdDockArea = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x00155C7F File Offset: 0x00153E7F
		// (set) Token: 0x060031DD RID: 12765 RVA: 0x00155C8C File Offset: 0x00153E8C
		[DefaultValue(false)]
		public bool DockTitle
		{
			get
			{
				return this.O._o0O_0.._frdDockTitle;
			}
			set
			{
				this.O._o0O_0.._frdDockTitle = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x00155C9A File Offset: 0x00153E9A
		// (set) Token: 0x060031DF RID: 12767 RVA: 0x00155CA7 File Offset: 0x00153EA7
		[DefaultValue(true)]
		public bool AutoOpen
		{
			get
			{
				return this.O._o0O_0.._frdAutoOpen;
			}
			set
			{
				this.O._o0O_0.._frdAutoOpen = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060031E0 RID: 12768 RVA: 0x00155CB5 File Offset: 0x00153EB5
		// (set) Token: 0x060031E1 RID: 12769 RVA: 0x00155CC2 File Offset: 0x00153EC2
		[DefaultValue(false)]
		public bool AutoHide
		{
			get
			{
				return this.O._o0O_0.._frdAutoHide;
			}
			set
			{
				this.O._o0O_0.._frdAutoHide = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060031E2 RID: 12770 RVA: 0x00155CD0 File Offset: 0x00153ED0
		// (set) Token: 0x060031E3 RID: 12771 RVA: 0x00155CDD File Offset: 0x00153EDD
		[DefaultValue(true)]
		public bool AllowClose
		{
			get
			{
				return this.O._o0O_0.._frdAllowClose;
			}
			set
			{
				this.O._o0O_0.._frdAllowClose = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060031E4 RID: 12772 RVA: 0x00155CEB File Offset: 0x00153EEB
		// (set) Token: 0x060031E5 RID: 12773 RVA: 0x00155CF8 File Offset: 0x00153EF8
		[DefaultValue(true)]
		public bool ShowCaption
		{
			get
			{
				return this.O._o0O_0.._frdShowCaption;
			}
			set
			{
				this.O._o0O_0.._frdShowCaption = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060031E6 RID: 12774 RVA: 0x00155D06 File Offset: 0x00153F06
		// (set) Token: 0x060031E7 RID: 12775 RVA: 0x00155D13 File Offset: 0x00153F13
		[DefaultValue("")]
		public string FilterTreeColumns
		{
			get
			{
				return this.O._o0O_0..O00.o_0OO__.;
			}
			set
			{
				this.O._o0O_0..O00.o_0OO__. = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x00155D21 File Offset: 0x00153F21
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x00155D2E File Offset: 0x00153F2E
		[DefaultValue(0)]
		public O0_0_0O0___O InlineTreeType
		{
			get
			{
				return this.O._o0O_0..o00oOO00_.ooOo.;
			}
			set
			{
				this.O._o0O_0..o00oOO00_.ooOo. = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x00155D3C File Offset: 0x00153F3C
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x00155D49 File Offset: 0x00153F49
		[DefaultValue("")]
		public string FilterParentCol
		{
			get
			{
				return this.O._o0O_0..oo.0___0O00.;
			}
			set
			{
				this.O._o0O_0..oo.0___0O00. = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x00155D57 File Offset: 0x00153F57
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x00155D64 File Offset: 0x00153F64
		[DefaultValue(0)]
		public int AutoFold
		{
			get
			{
				return this.O._o0O_0..o.0o00ooo_.;
			}
			set
			{
				this.O._o0O_0..o.0o00ooo_. = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060031EE RID: 12782 RVA: 0x00155D72 File Offset: 0x00153F72
		// (set) Token: 0x060031EF RID: 12783 RVA: 0x00155D7F File Offset: 0x00153F7F
		[DefaultValue(false)]
		public bool ShowGridTree
		{
			get
			{
				return this.O._o0O_0..O0oO0_._0.;
			}
			set
			{
				this.O._o0O_0..O0oO0_._0. = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x00155D8D File Offset: 0x00153F8D
		// (set) Token: 0x060031F1 RID: 12785 RVA: 0x00155D9A File Offset: 0x00153F9A
		[DefaultValue("")]
		public string FilterValueCol
		{
			get
			{
				return this.O._o0O_0..Oo_0o_O0._.;
			}
			set
			{
				this.O._o0O_0..Oo_0o_O0._. = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x00155DA8 File Offset: 0x00153FA8
		// (set) Token: 0x060031F3 RID: 12787 RVA: 0x00155DB5 File Offset: 0x00153FB5
		[DefaultValue("")]
		public string FilterSortCol
		{
			get
			{
				return this.O._o0O_0..ooo._Ooo.;
			}
			set
			{
				this.O._o0O_0..ooo._Ooo. = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x00155DC3 File Offset: 0x00153FC3
		// (set) Token: 0x060031F5 RID: 12789 RVA: 0x00155DD0 File Offset: 0x00153FD0
		[DefaultValue("")]
		public string FilterChildCol
		{
			get
			{
				return this.O._o0O_0..oOo0.____.;
			}
			set
			{
				this.O._o0O_0..oOo0.____. = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060031F6 RID: 12790 RVA: 0x00155DDE File Offset: 0x00153FDE
		// (set) Token: 0x060031F7 RID: 12791 RVA: 0x00155DEB File Offset: 0x00153FEB
		[DefaultValue("")]
		public string FilterCaptionCol
		{
			get
			{
				return this.O._o0O_0..ooO0o.o_O.;
			}
			set
			{
				this.O._o0O_0..ooO0o.o_O. = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x00155DF9 File Offset: 0x00153FF9
		// (set) Token: 0x060031F9 RID: 12793 RVA: 0x00155E06 File Offset: 0x00154006
		[DefaultValue(false)]
		public bool FilterTreeSortDesc
		{
			get
			{
				return this.O._o0O_0..O0_.__o00_.;
			}
			set
			{
				this.O._o0O_0..O0_.__o00_. = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x00155E14 File Offset: 0x00154014
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x00155E21 File Offset: 0x00154021
		[DefaultValue(false)]
		public bool IncludeSubProduct
		{
			get
			{
				return this.O._o0O_0..oo_o_.oOO.;
			}
			set
			{
				this.O._o0O_0..oo_o_.oOO. = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x00155E2F File Offset: 0x0015402F
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x00155E3C File Offset: 0x0015403C
		[DefaultValue(false)]
		public bool InlineTreeAutoSum
		{
			get
			{
				return this.O._o0O_0..O.O000.;
			}
			set
			{
				this.O._o0O_0..O.O000. = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x00155E4A File Offset: 0x0015404A
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x00155E57 File Offset: 0x00154057
		[DefaultValue(false)]
		public bool InlineTreeMergeSubtotal
		{
			get
			{
				return this.O._o0O_0..ooo_Ooo0.__.;
			}
			set
			{
				this.O._o0O_0..ooo_Ooo0.__. = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x00155E65 File Offset: 0x00154065
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x00155E72 File Offset: 0x00154072
		[DefaultValue("")]
		public string FilterTreePathCol
		{
			get
			{
				return this.O._o0O_0..o_O_0._O_.;
			}
			set
			{
				this.O._o0O_0..o_O_0._O_. = value;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x00155E80 File Offset: 0x00154080
		// (set) Token: 0x06003203 RID: 12803 RVA: 0x00155E92 File Offset: 0x00154092
		[DefaultValue("")]
		public string FilterTreeSeparator
		{
			get
			{
				return Conversions.ToString(this.O._o0O_0..o00oOO00_.ooOo.);
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0)
				{
					this.O._o0O_0..o00oOO00_.ooOo. = value[0];
					return;
				}
				this.O._o0O_0..o00oOO00_.ooOo. = '\0';
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x00155EC2 File Offset: 0x001540C2
		// (set) Token: 0x06003205 RID: 12805 RVA: 0x00155ECF File Offset: 0x001540CF
		[DefaultValue("")]
		public string FilterTreeLengths
		{
			get
			{
				return this.O._o0O_0..oo.o0o0O_o_.;
			}
			set
			{
				this.O._o0O_0..oo.o0o0O_o_. = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x00155EDD File Offset: 0x001540DD
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x00155EEA File Offset: 0x001540EA
		[DefaultValue("")]
		public string loadTreeColumns
		{
			get
			{
				return this.O._o0O_0..o.Ooo__.;
			}
			set
			{
				this.O._o0O_0..o.Ooo__. = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x00155EF8 File Offset: 0x001540F8
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x00155F05 File Offset: 0x00154105
		[DefaultValue(10000)]
		public int LoadTreePageRows
		{
			get
			{
				return this.O._o0O_0..o.0__o0.;
			}
			set
			{
				this.O._o0O_0..o.0__o0. = value;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x00155F13 File Offset: 0x00154113
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x00155F20 File Offset: 0x00154120
		[DefaultValue("")]
		public string LoadTreePageOver
		{
			get
			{
				return this.O._o0O_0..O0__O_.O.;
			}
			set
			{
				this.O._o0O_0..O0__O_.O. = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x00155F2E File Offset: 0x0015412E
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00155F3B File Offset: 0x0015413B
		[DefaultValue(false)]
		public bool AutoOpenLoadTree
		{
			get
			{
				return this.O._o0O_0..oo.o_ooO.;
			}
			set
			{
				this.O._o0O_0..oo.o_ooO. = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x00155F49 File Offset: 0x00154149
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x00155F56 File Offset: 0x00154156
		[DefaultValue(true)]
		public bool TreeUnique
		{
			get
			{
				return this.O._o0O_0..OOoOO.OO0.;
			}
			set
			{
				this.O._o0O_0..OOoOO.OO0. = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x00155F64 File Offset: 0x00154164
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x00155F71 File Offset: 0x00154171
		[DefaultValue(false)]
		public bool AutoOpenFilterTree
		{
			get
			{
				return this.O._o0O_0..o0o0oOOo0__.o.;
			}
			set
			{
				this.O._o0O_0..o0o0oOOo0__.o. = value;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x00155F7F File Offset: 0x0015417F
		// (set) Token: 0x06003213 RID: 12819 RVA: 0x00155F8C File Offset: 0x0015418C
		[DefaultValue(false)]
		public bool LoadReverse
		{
			get
			{
				return this.O._o0O_0..o00Oo.O0O.;
			}
			set
			{
				this.O._o0O_0..o00Oo.O0O. = value;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x00155F9A File Offset: 0x0015419A
		// (set) Token: 0x06003215 RID: 12821 RVA: 0x00155FA7 File Offset: 0x001541A7
		[DefaultValue(false)]
		public bool AutoGrandTotal
		{
			get
			{
				return this.O._o0O_0..Oo.Oo0OoOOoo_.;
			}
			set
			{
				this.O._o0O_0..Oo.Oo0OoOOoo_. = value;
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06003216 RID: 12822 RVA: 0x00155FB5 File Offset: 0x001541B5
		// (set) Token: 0x06003217 RID: 12823 RVA: 0x00155FC2 File Offset: 0x001541C2
		[DefaultValue("")]
		public string GridTreeParentCol
		{
			get
			{
				return this.O._o0O_0..oooo00O.o__0O.;
			}
			set
			{
				this.O._o0O_0..oooo00O.o__0O. = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x00155FD0 File Offset: 0x001541D0
		// (set) Token: 0x06003219 RID: 12825 RVA: 0x00155FDD File Offset: 0x001541DD
		[DefaultValue("")]
		public string GridTreeChildCol
		{
			get
			{
				return this.O._o0O_0..O___o0.Oo.;
			}
			set
			{
				this.O._o0O_0..O___o0.Oo. = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x00155FEB File Offset: 0x001541EB
		// (set) Token: 0x0600321B RID: 12827 RVA: 0x00155FF8 File Offset: 0x001541F8
		[DefaultValue("")]
		public string GridTreeSortCol
		{
			get
			{
				return this.O._o0O_0..O0_O.0oOO0Oo0.;
			}
			set
			{
				this.O._o0O_0..O0_O.0oOO0Oo0. = value;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x00156006 File Offset: 0x00154206
		// (set) Token: 0x0600321D RID: 12829 RVA: 0x00156013 File Offset: 0x00154213
		[DefaultValue(false)]
		public bool GridTreeSortDesc
		{
			get
			{
				return this.O._o0O_0..oO_.ooo0o.;
			}
			set
			{
				this.O._o0O_0..oO_.ooo0o. = value;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x00156021 File Offset: 0x00154221
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x0015602E File Offset: 0x0015422E
		[DefaultValue(false)]
		public bool GridTreeUseStyle
		{
			get
			{
				return this.O._o0O_0..oO._o.;
			}
			set
			{
				this.O._o0O_0..oO._o. = value;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x0015603C File Offset: 0x0015423C
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x00156049 File Offset: 0x00154249
		[DefaultValue("")]
		public string GridTreePathCol
		{
			get
			{
				return this.O._o0O_0..O_.oOoOO0o.;
			}
			set
			{
				this.O._o0O_0..O_.oOoOO0o. = value;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x00156057 File Offset: 0x00154257
		// (set) Token: 0x06003223 RID: 12835 RVA: 0x00156064 File Offset: 0x00154264
		[DefaultValue("")]
		public string GridTreeCaptionCol
		{
			get
			{
				return this.O._o0O_0..O000__.o_ooo_O.;
			}
			set
			{
				this.O._o0O_0..O000__.o_ooo_O. = value;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06003224 RID: 12836 RVA: 0x00156072 File Offset: 0x00154272
		// (set) Token: 0x06003225 RID: 12837 RVA: 0x0015607F File Offset: 0x0015427F
		[DefaultValue("")]
		public string GridTreeSeprtor
		{
			get
			{
				return this.O._o0O_0..oO0.00.;
			}
			set
			{
				this.O._o0O_0..oO0.00. = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x0015608D File Offset: 0x0015428D
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x0015609A File Offset: 0x0015429A
		[DefaultValue("")]
		public string GridTreeLengths
		{
			get
			{
				return this.O._o0O_0..O_OO.oO0_.;
			}
			set
			{
				this.O._o0O_0..O_OO.oO0_. = value;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06003228 RID: 12840 RVA: 0x001560A8 File Offset: 0x001542A8
		// (set) Token: 0x06003229 RID: 12841 RVA: 0x001560B5 File Offset: 0x001542B5
		[DefaultValue("")]
		public string GridTreeGroups
		{
			get
			{
				return this.O._o0O_0..o_oO__O.0_.;
			}
			set
			{
				this.O._o0O_0..o_oO__O.0_. = value;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x0600322A RID: 12842 RVA: 0x001560C3 File Offset: 0x001542C3
		// (set) Token: 0x0600322B RID: 12843 RVA: 0x001560D0 File Offset: 0x001542D0
		[DefaultValue("")]
		public string GridValueGroups
		{
			get
			{
				return this.O._o0O_0..oOoo____oo.O0.;
			}
			set
			{
				this.O._o0O_0..oOoo____oo.O0. = value;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x0600322C RID: 12844 RVA: 0x001560DE File Offset: 0x001542DE
		// (set) Token: 0x0600322D RID: 12845 RVA: 0x001560EB File Offset: 0x001542EB
		[DefaultValue(0)]
		public int GridTreeExpandLevel
		{
			get
			{
				return this.O._o0O_0..o__.O0o.;
			}
			set
			{
				this.O._o0O_0..o__.O0o. = value;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x001560F9 File Offset: 0x001542F9
		// (set) Token: 0x0600322F RID: 12847 RVA: 0x0015610B File Offset: 0x0015430B
		[DefaultValue(false)]
		public bool InlineIncludeParentKey
		{
			get
			{
				return this.O._o0O_0..O_O0._..IncludeParentCol;
			}
			set
			{
				this.O._o0O_0..O_O0._..IncludeParentCol = value;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x00156120 File Offset: 0x00154320
		// (set) Token: 0x06003231 RID: 12849 RVA: 0x00156170 File Offset: 0x00154370
		[DefaultValue(false)]
		public bool InlineShowGridTree
		{
			get
			{
				bool result;
				if (Operators.CompareString(this.O._o0O_0..O_O0._..TableName, "", true) > 0)
				{
					result = this.O._o0O_0..O_O0._..GridTree;
				}
				else
				{
					result = this.O._o0O_0..O_O0._..GridTree;
				}
				return result;
			}
			set
			{
				this.O._o0O_0..O_O0._..GridTree = value;
				this.O._o0O_0..O_O0._..GridTree = value;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x00156194 File Offset: 0x00154394
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x001561E4 File Offset: 0x001543E4
		[DefaultValue(false)]
		public bool InlineOnlyGroupRows
		{
			get
			{
				bool result;
				if (Operators.CompareString(this.O._o0O_0..O_O0._..TableName, "", true) > 0)
				{
					result = this.O._o0O_0..O_O0._..OnlyGroupRows;
				}
				else
				{
					result = this.O._o0O_0..O_O0._..OnlyGroupRows;
				}
				return result;
			}
			set
			{
				this.O._o0O_0..O_O0._..OnlyGroupRows = value;
				this.O._o0O_0..O_O0._..OnlyGroupRows = value;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x00156208 File Offset: 0x00154408
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x00156258 File Offset: 0x00154458
		[DefaultValue(false)]
		public bool ShowTreeInParentCol
		{
			get
			{
				bool result;
				if (Operators.CompareString(this.O._o0O_0..O_O0._..TableName, "", true) > 0)
				{
					result = this.O._o0O_0..O_O0._..ShowTreeInParentCol;
				}
				else
				{
					result = this.O._o0O_0..O_O0._..ShowTreeInPathCol;
				}
				return result;
			}
			set
			{
				this.O._o0O_0..O_O0._..ShowTreeInParentCol = value;
				this.O._o0O_0..O_O0._..ShowTreeInPathCol = value;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x0015627C File Offset: 0x0015447C
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x00156328 File Offset: 0x00154528
		[DefaultValue("")]
		public string InlineGroupAdditions
		{
			get
			{
				string text = "";
				try
				{
					foreach (o00_0__O o00_0__O in this.O._o0O_0..O_O0._..Additions)
					{
						text = string.Join(",", new string[]
						{
							o00_0__O.oo__.0O00.().Name,
							o00_0__O.oooO00__.o0.(),
							o00_0__O.oooO00.o00O.(),
							o00_0__O.o.oOo_Oo0O.()
						}) + "\t";
					}
				}
				finally
				{
					IEnumerator<o00_0__O> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return text.Trim(new char[]
				{
					'\t'
				});
			}
			set
			{
				this.O._o0O_0..O_O0._..Additions.Clear();
				checked
				{
					if (Operators.CompareString(value, "", true) > 0)
					{
						string[] array = value.Split(new char[]
						{
							'\t'
						});
						for (int i = 0; i < array.Length; i++)
						{
							string[] array2 = array[i].Split(new char[]
							{
								','
							});
							if (array2.Length == 4 && OO_00oOO.DataTables.Contains(array2[0]))
							{
								DataTable dataTable = OO_00oOO.DataTables[array2[0]];
								if (dataTable.BaseTable.Columns.Contains(array2[1]) && dataTable.BaseTable.Columns.Contains(array2[2]))
								{
									this.O._o0O_0..O_O0._..Additions.Add(dataTable, array2[1], array2[2], array2[3]);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x00156404 File Offset: 0x00154604
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x001564B0 File Offset: 0x001546B0
		[DefaultValue("")]
		public string LayersGroupAdditions
		{
			get
			{
				string text = "";
				try
				{
					foreach (o00_0__O o00_0__O in this.O._o0O_0..O_O0._..Additions)
					{
						text = string.Join(",", new string[]
						{
							o00_0__O.oo__.0O00.().Name,
							o00_0__O.oooO00__.o0.(),
							o00_0__O.oooO00.o00O.(),
							o00_0__O.o.oOo_Oo0O.()
						}) + "\t";
					}
				}
				finally
				{
					IEnumerator<o00_0__O> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return text.Trim(new char[]
				{
					'\t'
				});
			}
			set
			{
				this.O._o0O_0..O_O0._..Additions.Clear();
				checked
				{
					if (Operators.CompareString(value, "", true) > 0)
					{
						string[] array = value.Split(new char[]
						{
							'\t'
						});
						for (int i = 0; i < array.Length; i++)
						{
							string[] array2 = array[i].Split(new char[]
							{
								','
							});
							if (array2.Length == 4 && OO_00oOO.DataTables.Contains(array2[0]))
							{
								DataTable dataTable = OO_00oOO.DataTables[array2[0]];
								if (dataTable.BaseTable.Columns.Contains(array2[1]) && dataTable.BaseTable.Columns.Contains(array2[2]))
								{
									this.O._o0O_0..O_O0._..Additions.Add(dataTable, array2[1], array2[2], array2[3]);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x0015658C File Offset: 0x0015478C
		// (set) Token: 0x0600323B RID: 12859 RVA: 0x001565DC File Offset: 0x001547DC
		[DefaultValue(0)]
		public int InlineExpandLevel
		{
			get
			{
				int result;
				if (Operators.CompareString(this.O._o0O_0..O_O0._..TableName, "", true) > 0)
				{
					result = this.O._o0O_0..O_O0._..ExpandTo;
				}
				else
				{
					result = this.O._o0O_0..O_O0._..ExpandTo;
				}
				return result;
			}
			set
			{
				this.O._o0O_0..O_O0._..ExpandTo = value;
				this.O._o0O_0..O_O0._..ExpandTo = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x00156600 File Offset: 0x00154800
		// (set) Token: 0x0600323D RID: 12861 RVA: 0x00156650 File Offset: 0x00154850
		[DefaultValue(0)]
		public int InlinePreserveTolevel
		{
			get
			{
				int result;
				if (Operators.CompareString(this.O._o0O_0..O_O0._..TableName, "", true) > 0)
				{
					result = this.O._o0O_0..O_O0._..PreserveTo;
				}
				else
				{
					result = this.O._o0O_0..O_O0._..PreserveTo;
				}
				return result;
			}
			set
			{
				this.O._o0O_0..O_O0._..PreserveTo = value;
				this.O._o0O_0..O_O0._..PreserveTo = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x00156674 File Offset: 0x00154874
		// (set) Token: 0x0600323F RID: 12863 RVA: 0x00156686 File Offset: 0x00154886
		[DefaultValue("")]
		public string InlineTableName
		{
			get
			{
				return this.O._o0O_0..O_O0._..TableName;
			}
			set
			{
				this.O._o0O_0..O_O0._..TableName = value;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x00156699 File Offset: 0x00154899
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x001566AB File Offset: 0x001548AB
		[DefaultValue("")]
		public string LayersTableName
		{
			get
			{
				return this.O._o0O_0..O_O0._..TableName;
			}
			set
			{
				this.O._o0O_0..O_O0._..TableName = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x001566C0 File Offset: 0x001548C0
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x001567C4 File Offset: 0x001549C4
		[DefaultValue("")]
		public string InlieGroupTotals
		{
			get
			{
				List<o0o_> list;
				if (Operators.CompareString(this.O._o0O_0..O_O0._..TableName, "", true) > 0)
				{
					list = this.O._o0O_0..O_O0._..Totals;
				}
				else
				{
					list = this.O._o0O_0..O_O0._..Totals;
				}
				string text = "";
				try
				{
					foreach (o0o_ o0o_ in list)
					{
						if (Operators.CompareString(text, "", true) > 0)
						{
							text += "\r";
						}
						text = string.Concat(new string[]
						{
							text,
							o0o_.o0oO._o_.(),
							"\t",
							o0o_.Oo0oO0oOO_.0_o.(),
							"\t",
							Conversions.ToString((int)o0o_.O0OO_0.O.()),
							"\t",
							Conversions.ToString((int)o0o_.o0oO._o_.())
						});
					}
				}
				finally
				{
					List<o0o_>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return text;
			}
			set
			{
				int num;
				int num4;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					string[] array = value.Split(new char[]
					{
						'\r'
					});
					IL_1B:
					num2 = 3;
					foreach (string text in array)
					{
						IL_2F:
						num2 = 4;
						string[] array3 = text.Split(new char[]
						{
							'\t'
						});
						IL_45:
						num2 = 5;
						if (Operators.CompareString(this.O._o0O_0..O_O0._..TableName, "", true) > 0)
						{
							IL_65:
							num2 = 6;
							this.O._o0O_0..O_O0._..AddTotal(array3[0], array3[1], (AggregateRange)Conversions.ToInteger(array3[2]), (AggregateType)Conversions.ToInteger(array3[3]));
						}
						else
						{
							IL_93:
							num2 = 8;
							this.O._o0O_0..O_O0._..AddTotal(array3[0], array3[1], (AggregateRange)Conversions.ToInteger(array3[2]), (AggregateType)Conversions.ToInteger(array3[3]));
						}
						IL_BF:
						num2 = 9;
					}
					IL_D3:
					goto IL_14A;
					IL_D5:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_10B:
					goto IL_13F;
					IL_10D:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_11D:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_10D;
				}
				IL_13F:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_14A:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x00156940 File Offset: 0x00154B40
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x0015694D File Offset: 0x00154B4D
		[DefaultValue("")]
		public string LoopParentCol
		{
			get
			{
				return this.O._o0O_0..O0.00__.;
			}
			set
			{
				this.O._o0O_0..O0.00__. = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x0015695B File Offset: 0x00154B5B
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x00156968 File Offset: 0x00154B68
		[DefaultValue("")]
		public string LoopChildCol
		{
			get
			{
				return this.O._o0O_0..o.o0o_0.;
			}
			set
			{
				this.O._o0O_0..o.o0o_0. = value;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x00156978 File Offset: 0x00154B78
		// (set) Token: 0x06003249 RID: 12873 RVA: 0x001569B4 File Offset: 0x00154BB4
		[DefaultValue("")]
		public string DuplicateColNames
		{
			get
			{
				string result;
				if (this.O._o0O_0..o.OO0O0O. != null)
				{
					result = string.Join(",", this.O._o0O_0..o.OO0O0O.);
				}
				else
				{
					result = "";
				}
				return result;
			}
			set
			{
				if (Operators.CompareString(value, "", true) > 0)
				{
					List<string> list = new List<string>();
					list.AddRange(value.Split(new char[]
					{
						','
					}));
					this.O._o0O_0..o.OO0O0O. = list;
				}
			}
		}

		// Token: 0x0400140F RID: 5135
		private Table <<EMPTY_NAME>>;

		// Token: 0x04001410 RID: 5136
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001411 RID: 5137
		private string <<EMPTY_NAME>>;

		// Token: 0x04001412 RID: 5138
		private string <<EMPTY_NAME>>;

		// Token: 0x04001413 RID: 5139
		private string <<EMPTY_NAME>>;

		// Token: 0x04001414 RID: 5140
		private string <<EMPTY_NAME>>;

		// Token: 0x04001415 RID: 5141
		private int <<EMPTY_NAME>>;

		// Token: 0x04001416 RID: 5142
		private string <<EMPTY_NAME>>;

		// Token: 0x04001417 RID: 5143
		private string <<EMPTY_NAME>>;

		// Token: 0x04001418 RID: 5144
		private Font <<EMPTY_NAME>>;

		// Token: 0x04001419 RID: 5145
		private string <<EMPTY_NAME>>;

		// Token: 0x0400141A RID: 5146
		private string <<EMPTY_NAME>>;

		// Token: 0x0400141B RID: 5147
		private string <<EMPTY_NAME>>;

		// Token: 0x0400141C RID: 5148
		private string <<EMPTY_NAME>>;

		// Token: 0x0400141D RID: 5149
		private string <<EMPTY_NAME>>;

		// Token: 0x0400141E RID: 5150
		private string <<EMPTY_NAME>>;

		// Token: 0x0400141F RID: 5151
		private string <<EMPTY_NAME>>;

		// Token: 0x04001420 RID: 5152
		private string <<EMPTY_NAME>>;

		// Token: 0x04001421 RID: 5153
		private string <<EMPTY_NAME>>;
	}
}
