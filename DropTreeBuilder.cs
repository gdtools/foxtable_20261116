using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// 用于动态生成下拉目录树
	/// </summary>
	// Token: 0x0200024A RID: 586
	[ComVisible(true)]
	[oO0oooo("2031")]
	public class DropTreeBuilder
	{
		// Token: 0x06001BFF RID: 7167 RVA: 0x000C44B5 File Offset: 0x000C26B5
		public DropTreeBuilder()
		{
			this.o0._o00_0o_oo. = '\\';
			this.o_.___0O0. = '|';
		}

		/// <summary>
		/// 目录树文件
		/// </summary>
		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000C44CD File Offset: 0x000C26CD
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x000C44D5 File Offset: 0x000C26D5
		public string TreeFile
		{
			get
			{
				return this.o0._o00_0o_oo.;
			}
			set
			{
				this.o0._o00_0o_oo. = value;
			}
		}

		/// <summary>
		/// 用于生成目录树的字符串
		/// </summary>
		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000C44DE File Offset: 0x000C26DE
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x000C44E6 File Offset: 0x000C26E6
		public string TreeString
		{
			get
			{
				return this.o_oOOo_.oO.;
			}
			set
			{
				this.o_oOOo_.oO. = value;
			}
		}

		/// <summary>
		/// 数据接收列
		/// </summary>
		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000C44EF File Offset: 0x000C26EF
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x000C44F7 File Offset: 0x000C26F7
		public string ReceiveCols
		{
			get
			{
				return this.o._o0O_.;
			}
			set
			{
				this.o._o0O_. = value;
			}
		}

		/// <summary>
		/// 目录树表
		/// </summary>
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000C4500 File Offset: 0x000C2700
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x000C4508 File Offset: 0x000C2708
		public DataTable SourceTable
		{
			get
			{
				return this.O_o.o__.;
			}
			set
			{
				this.O_o.o__. = value;
			}
		}

		/// <summary>
		/// 目录树列
		/// </summary>
		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000C4511 File Offset: 0x000C2711
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x000C4519 File Offset: 0x000C2719
		public string TreeCols
		{
			get
			{
				return this.oO.0_O_O0O.;
			}
			set
			{
				this.oO.0_O_O0O. = value;
			}
		}

		/// <summary>
		/// 过滤条件
		/// </summary>
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000C4522 File Offset: 0x000C2722
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x000C452A File Offset: 0x000C272A
		public string TreeFilter
		{
			get
			{
				return this.O__oOo.oO_Oo0.;
			}
			set
			{
				this.O__oOo.oO_Oo0. = value;
			}
		}

		/// <summary>
		/// 排序列
		/// </summary>
		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000C4533 File Offset: 0x000C2733
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x000C453B File Offset: 0x000C273B
		public string TreeSort
		{
			get
			{
				return this.o0oO.0O_0Oo_oo.;
			}
			set
			{
				this.o0oO.0O_0Oo_oo. = value;
			}
		}

		/// <summary>
		/// 数据来源列
		/// </summary>
		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x000C4544 File Offset: 0x000C2744
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x000C454C File Offset: 0x000C274C
		public string SourceCols
		{
			get
			{
				return this.OoO._oo_0.;
			}
			set
			{
				this.OoO._oo_0. = value;
			}
		}

		/// <summary>
		/// 路径分割符号
		/// </summary>
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000C4555 File Offset: 0x000C2755
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x000C4562 File Offset: 0x000C2762
		public string PathSeparator
		{
			get
			{
				return Conversions.ToString(this.o0._o00_0o_oo.);
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					value = "\\";
				}
				this.o0._o00_0o_oo. = value[0];
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000C4586 File Offset: 0x000C2786
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x000C458E File Offset: 0x000C278E
		public char PathSeparator2
		{
			get
			{
				return this.o0._o00_0o_oo.;
			}
			set
			{
				if (Operators.CompareString(Conversions.ToString(value), "", true) == 0)
				{
					value = '\\';
				}
				this.o0._o00_0o_oo. = value;
			}
		}

		/// <summary>
		/// 内容分割符号
		/// </summary>
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000C45AE File Offset: 0x000C27AE
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x000C45BB File Offset: 0x000C27BB
		public string ContentSeparator
		{
			get
			{
				return Conversions.ToString(this.o_.___0O0.);
			}
			set
			{
				if (Operators.CompareString(value, "", true) == 0)
				{
					value = "|";
				}
				this.o_.___0O0. = value[0];
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000C45DF File Offset: 0x000C27DF
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x000C45E7 File Offset: 0x000C27E7
		public char ContentSeparator2
		{
			get
			{
				return this.o_.___0O0.;
			}
			set
			{
				if (Operators.CompareString(Conversions.ToString(value), "", true) == 0)
				{
					value = '|';
				}
				this.o_.___0O0. = value;
			}
		}

		/// <summary>
		/// 是否分割内容
		/// </summary>
		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x000C4607 File Offset: 0x000C2807
		// (set) Token: 0x06001C19 RID: 7193 RVA: 0x000C460F File Offset: 0x000C280F
		public bool SeparateContent
		{
			get
			{
				return this.o0._o00_0o_oo.;
			}
			set
			{
				this.o0._o00_0o_oo. = value;
			}
		}

		/// <summary>
		/// 生成下拉目录树
		/// </summary>
		// Token: 0x06001C1A RID: 7194 RVA: 0x000C4618 File Offset: 0x000C2818
		public BuildInDropTree Build()
		{
			BuildInDropTree buildInDropTree = null;
			if (Operators.CompareString(this.TreeFile, "", true) > 0 && Operators.CompareString(this.ReceiveCols, "", true) > 0)
			{
				buildInDropTree = new BuildInDropTree(ooO.OoO0o_o___.O.(this.TreeFile), this.ReceiveCols, true);
			}
			else if (Operators.CompareString(this.TreeString, "", true) > 0 && Operators.CompareString(this.ReceiveCols, "", true) > 0)
			{
				buildInDropTree = new BuildInDropTree(this.TreeString, this.ReceiveCols, false);
			}
			else if (this.SourceTable != null && Operators.CompareString(this.ReceiveCols, "", true) > 0 && Operators.CompareString(this.TreeCols, "", true) > 0)
			{
				buildInDropTree = new BuildInDropTree(this.SourceTable, this.TreeCols, this.SourceCols, this.ReceiveCols, this.PathSeparator2, this.TreeFilter, this.TreeSort);
			}
			if (buildInDropTree != null)
			{
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = this.PathSeparator2;
				buildInDropTree.Ooo._0oO..O0ooOO_o0.00. = this.ContentSeparator2;
				buildInDropTree.Ooo._0oO..OooOoOo_.o. = this.SeparateContent;
				if (this.TreeWidth > 0)
				{
					buildInDropTree.Ooo._0oO..Width = this.TreeWidth;
				}
				if (this.TreeHeight > 0)
				{
					buildInDropTree.Ooo._0oO..Height = this.TreeHeight;
				}
			}
			return buildInDropTree;
		}

		/// <summary>
		/// 目录树宽度
		/// </summary>
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x000C4774 File Offset: 0x000C2974
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x000C477C File Offset: 0x000C297C
		public int TreeWidth
		{
			get
			{
				return this.O_o.o__.;
			}
			set
			{
				this.O_o.o__. = value;
			}
		}

		/// <summary>
		/// 目录树高度
		/// </summary>
		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x000C4788 File Offset: 0x000C2988
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x000C4799 File Offset: 0x000C2999
		public int TreeHeight
		{
			get
			{
				int num = -num;
				return num;
			}
			set
			{
				this.o_.___0O0. = value;
			}
		}

		// Token: 0x04000BD7 RID: 3031
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BD8 RID: 3032
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BD9 RID: 3033
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BDA RID: 3034
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04000BDB RID: 3035
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BDC RID: 3036
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BDD RID: 3037
		private bool <<EMPTY_NAME>>;

		// Token: 0x04000BDE RID: 3038
		private char <<EMPTY_NAME>>;

		// Token: 0x04000BDF RID: 3039
		private char <<EMPTY_NAME>>;

		// Token: 0x04000BE0 RID: 3040
		private int <<EMPTY_NAME>>;

		// Token: 0x04000BE1 RID: 3041
		private int <<EMPTY_NAME>>;

		// Token: 0x04000BE2 RID: 3042
		private string <<EMPTY_NAME>>;

		// Token: 0x04000BE3 RID: 3043
		private string <<EMPTY_NAME>>;
	}
}
