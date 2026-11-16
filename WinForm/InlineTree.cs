using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 内联树
	/// </summary>
	// Token: 0x02000506 RID: 1286
	public class InlineTree : Control
	{
		// Token: 0x060053F6 RID: 21494 RVA: 0x00256C71 File Offset: 0x00254E71
		internal InlineTree(oo__ A_0) : base(A_0, ControlTypeEnum.InlineTree)
		{
			this.o0_0oO.OooO. = A_0;
			A_0.oO0.00ooO. = true;
		}

		/// <summary>
		/// 生成内联BOM树
		/// </summary>
		/// <param name="Table">基于此Table生成内联BOM树</param>
		/// <param name="Setting">InlineTreeSetting类型，用于设置BOM树</param>
		// Token: 0x060053F7 RID: 21495 RVA: 0x00256C8A File Offset: 0x00254E8A
		[oO0oooo("3371")]
		public void BuildBOMTree(Table Table, InlineTreeSetting Setting)
		{
			Setting.Unique = true;
			this.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.OOO.__O_oO_.);
		}

		/// <summary>
		/// 生成内联筛选树
		/// </summary>
		/// <param name="Table">基于此Table生成内联筛选树</param>
		/// <param name="Setting">InlineTreeSetting类型，用于设置筛选树</param>
		// Token: 0x060053F8 RID: 21496 RVA: 0x00256C9C File Offset: 0x00254E9C
		[oO0oooo("3372")]
		public void BuildFilterTree(Table Table, InlineTreeSetting Setting)
		{
			this.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.oOO___o.0oO.);
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x00256CA8 File Offset: 0x00254EA8
		private void <<EMPTY_NAME>>(Table A_0, InlineTreeSetting A_1, O0_0_0O0___O A_2)
		{
			this.o0_0oO.OooO..O_OOo0o0__0.0_. = A_0;
			this.o0_0oO.OooO..O_OOo0o0__0.0_. = A_2;
			this.o0_0oO.OooO..oO0.o_O. = A_1.ParentCol;
			this.o0_0oO.OooO..O_o_o.oo0_. = A_1.ChildCol;
			this.o0_0oO.OooO..Ooo_00_OO.0Oo_. = A_1.ValueCol;
			if (Operators.CompareString(A_1.TextCol, "", true) > 0)
			{
				this.o0_0oO.OooO..o0O_Oo0_O._. = A_1.TextCol;
			}
			else
			{
				this.o0_0oO.OooO..o0O_Oo0_O._. = A_1.ChildCol;
			}
			this.o0_0oO.OooO..o.ooO_. = A_1.IncludeSub;
			this.o0_0oO.OooO..O_00.0___0. = A_1.Subtotal;
			this.o0_0oO.OooO..o__oO0.OOo_O. = A_1.GridTree;
			this.o0_0oO.OooO..o_.0Oo_oo0_. = A_1.ExpandTo;
			this.o0_0oO.OooO..oO0__0_oO0.O_0. = A_1.SortCol;
			this.o0_0oO.OooO..oO0.o_O. = A_1.SortDesc;
			this.o0_0oO.OooO..Ooo_00_OO.0Oo_. = A_1.Unique;
			this.o0_0oO.OooO..O0.OOo0O. = A_1.MergeTotal;
			if (Operators.CompareString(this.o0_0oO.OooO..oO0.o_O., "", true) > 0 && Operators.CompareString(this.o0_0oO.OooO..O_o_o.oo0_., "", true) > 0)
			{
				this.o0_0oO.OooO..Oo0___O.0.();
				this.o0_0oO.OooO..oOo0Ooo.O_Oo0.();
			}
		}

		// Token: 0x040022AE RID: 8878
		private oo__ <<EMPTY_NAME>>;
	}
}
