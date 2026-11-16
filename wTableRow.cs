using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000232 RID: 562
	[oO0oooo("A0063")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class wTableRow
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x000BD8FD File Offset: 0x000BBAFD
		public wTableRow()
		{
			this.o0oO._0o0_O. = new List<string>();
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x000BD910 File Offset: 0x000BBB10
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x000BD918 File Offset: 0x000BBB18
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Class
		{
			get
			{
				return this.OOooOo.00OO_.;
			}
			set
			{
				this.OOooOo.00OO_. = value;
			}
		}

		/// <summary>
		/// 用于设置行的属性
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000BD921 File Offset: 0x000BBB21
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x000BD929 File Offset: 0x000BBB29
		public string Attribute
		{
			get
			{
				return this.O0oO.o_Oo0.;
			}
			set
			{
				this.O0oO.o_Oo0. = value;
			}
		}

		/// <summary>
		/// 用于手工设置行的主键值
		/// </summary>
		/// <returns></returns>
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x000BD932 File Offset: 0x000BBB32
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x000BD93A File Offset: 0x000BBB3A
		public string Primarykey
		{
			get
			{
				return this.OOooO_o0.o.;
			}
			set
			{
				this.OOooO_o0.o. = value;
			}
		}

		/// <summary>
		/// 增加多个单元格
		/// </summary>
		/// <param name="values">各单元格的值</param>
		// Token: 0x06001AD2 RID: 6866 RVA: 0x000BD943 File Offset: 0x000BBB43
		[oO0oooo("A0068")]
		public void AddCells(params string[] values)
		{
			this.o0oO._0o0_O..AddRange(values);
		}

		/// <summary>
		/// 增加多个单元
		/// </summary>
		/// <param name="values">一个包括各单元格值的集合或数组</param>
		// Token: 0x06001AD3 RID: 6867 RVA: 0x000BD951 File Offset: 0x000BBB51
		[oO0oooo("A0068")]
		public void AddCells(IEnumerable<string> values)
		{
			this.o0oO._0o0_O..AddRange(values);
		}

		/// <summary>
		/// 增加一个单元格
		/// </summary>
		/// <param name="value">单元格的值</param>
		/// <param name="Attribute">可选参数，用于设置单元格的属性</param>
		// Token: 0x06001AD4 RID: 6868 RVA: 0x000BD95F File Offset: 0x000BBB5F
		[oO0oooo("A0068")]
		public void AddCell(string value, string Attribute = "")
		{
			if (Operators.CompareString(Attribute, "", true) > 0)
			{
				this.o0oO._0o0_O..Add(value + "\v" + Attribute);
				return;
			}
			this.o0oO._0o0_O..Add(value);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000BD994 File Offset: 0x000BBB94
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void <<EMPTY_NAME>>(StringBuilder A_0, int A_1, wRowCollection A_2, int A_3, bool A_4, int A_5, string A_6 = "")
		{
			A_0.Append("<tr");
			if (Operators.CompareString(this.Attribute, "", true) > 0)
			{
				A_0.Append(" " + this.Attribute);
			}
			if (Operators.CompareString(this.OOooO_o0.o., "", true) > 0)
			{
				A_0.Append(" data-key='" + this.OOooO_o0.o. + "'");
			}
			if (A_4)
			{
				this.Class += " alt";
			}
			if (Operators.CompareString(this.Class, "", true) > 0)
			{
				A_0.Append(" class='" + this.Class + "'");
			}
			A_0.Append(">");
			string[] array = new string[0];
			if (Operators.CompareString(A_6, "", true) > 0)
			{
				array = A_6.Split(new char[]
				{
					','
				});
			}
			int num = this.o0oO._0o0_O..Count - 1;
			int i = 0;
			while (i <= num)
			{
				string text = this.o0oO._0o0_O.[i];
				int num2 = 1;
				int num3 = 1;
				if (this.o0oO._0o0_O.)
				{
					this.OOooOo.00OO_.(A_1, i, A_2, ref num2, ref num3);
					if (num2 != -1 && num3 != -1)
					{
						A_0.Append("<th data-idx='" + Conversions.ToString(i) + "'");
						if (num2 > 1)
						{
							A_0.Append(" rowspan='" + Conversions.ToString(num2) + "'");
						}
						if (num3 > 1)
						{
							A_0.Append(" colspan='" + Conversions.ToString(num3) + "'");
						}
						if ((A_1 == 0 || A_2[A_1 - 1].o0oO._0o0_O..Count > i) && array.Length > i && Operators.CompareString(array[i], "", true) > 0)
						{
							A_0.Append(" width='" + array[i] + "'");
							goto IL_241;
						}
						goto IL_241;
					}
				}
				else
				{
					if (A_3 > i)
					{
						num2 = this.OOooOo.00OO_.(A_1, i, A_2);
						if (num2 == -1)
						{
							goto IL_2B8;
						}
					}
					if (i < A_5)
					{
						A_0.Append("<th");
					}
					else
					{
						A_0.Append("<td");
					}
					if (num2 > 1)
					{
						A_0.Append(" rowspan='" + Conversions.ToString(num2) + "'");
						goto IL_241;
					}
					goto IL_241;
				}
				IL_2B8:
				i++;
				continue;
				IL_241:
				if (text.IndexOf('\v') >= 0)
				{
					string[] array2 = text.Split(new char[]
					{
						'\v'
					});
					A_0.Append(" " + array2[1] + ">" + array2[0]);
				}
				else
				{
					A_0.Append(">" + text);
				}
				if (this.o0oO._0o0_O. || i < A_5)
				{
					A_0.Append("</th>");
					goto IL_2B8;
				}
				A_0.Append("</td>");
				goto IL_2B8;
			}
			A_0.AppendLine("</tr>");
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000BDC70 File Offset: 0x000BBE70
		private int <<EMPTY_NAME>>(int A_0, int A_1, wRowCollection A_2)
		{
			int num = 1;
			int result;
			if (A_0 > 0 && A_2[A_0 - 1].o0oO._0o0_O..Count > A_1 && this.OOooOo.00OO_.(A_2[A_0 - 1].o0oO._0o0_O.[A_1], this.o0oO._0o0_O.[A_1]))
			{
				result = -1;
			}
			else
			{
				int num2 = A_0 + 1;
				int num3 = A_2.Count - 1;
				int num4 = num2;
				while (num4 <= num3 && A_2[num4].o0oO._0o0_O..Count > A_1 && this.OOooOo.00OO_.(A_2[num4].o0oO._0o0_O.[A_1], this.o0oO._0o0_O.[A_1]))
				{
					num++;
					num4++;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000BDD20 File Offset: 0x000BBF20
		private bool <<EMPTY_NAME>>(string A_0, string A_1)
		{
			string[] array = A_0.Split(new char[]
			{
				'\v'
			});
			string[] array2 = A_1.Split(new char[]
			{
				'\v'
			});
			return Operators.CompareString(array[0], array2[0], true) == 0;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000BDD60 File Offset: 0x000BBF60
		private void <<EMPTY_NAME>>(int A_0, int A_1, wRowCollection A_2, ref int A_3, ref int A_4)
		{
			if (A_0 > 0 && A_2[A_0 - 1].o0oO._0o0_O..Count > A_1 && this.OOooOo.00OO_.(A_2[A_0 - 1].o0oO._0o0_O.[A_1], this.o0oO._0o0_O.[A_1]))
			{
				A_3 = -1;
			}
			if (A_3 == 1 && A_1 > 0 && Operators.CompareString(this.o0oO._0o0_O.[A_1], this.o0oO._0o0_O.[A_1 - 1], true) == 0)
			{
				bool flag = true;
				int num = A_0 + 1;
				int num2 = A_2.Count - 1;
				int num3 = num;
				while (num3 <= num2 && A_2[num3].o0oO._0o0_O..Count > A_1)
				{
					if (this.OOooOo.00OO_.(A_2[num3].o0oO._0o0_O.[A_1 - 1], this.o0oO._0o0_O.[A_1]) ^ this.OOooOo.00OO_.(A_2[num3].o0oO._0o0_O.[A_1], this.o0oO._0o0_O.[A_1]))
					{
						flag = false;
						break;
					}
					if (!this.OOooOo.00OO_.(A_2[num3].o0oO._0o0_O.[A_1 - 1], this.o0oO._0o0_O.[A_1]))
					{
						break;
					}
					num3++;
				}
				if (flag)
				{
					A_4 = -1;
				}
			}
			if (A_3 == 1 && A_4 == 1)
			{
				int num4 = A_0 + 1;
				int num5 = A_2.Count - 1;
				int num6 = num4;
				while (num6 <= num5 && A_2[num6].o0oO._0o0_O..Count > A_1 && this.OOooOo.00OO_.(A_2[num6].o0oO._0o0_O.[A_1], this.o0oO._0o0_O.[A_1]))
				{
					A_3++;
					num6++;
				}
				int num7 = A_1 + 1;
				int num8 = this.o0oO._0o0_O..Count - 1;
				for (int i = num7; i <= num8; i++)
				{
					bool flag2 = true;
					int num9 = A_0 + A_3 - 1;
					for (int j = A_0; j <= num9; j++)
					{
						if (A_2[j].o0oO._0o0_O..Count <= i || !this.OOooOo.00OO_.(A_2[j].o0oO._0o0_O.[i], this.o0oO._0o0_O.[A_1]))
						{
							flag2 = false;
							break;
						}
					}
					if (!flag2)
					{
						break;
					}
					A_4++;
				}
			}
		}

		// Token: 0x04000B4E RID: 2894
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000B4F RID: 2895
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x04000B50 RID: 2896
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B51 RID: 2897
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B52 RID: 2898
		internal string <<EMPTY_NAME>>;
	}
}
