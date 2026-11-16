using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 层级树
	/// </summary>
	// Token: 0x02000507 RID: 1287
	public class LayersTree : Control
	{
		// Token: 0x060053FA RID: 21498 RVA: 0x00256E09 File Offset: 0x00255009
		internal LayersTree(oO_oo0Oo A_0) : base(A_0, ControlTypeEnum.LayersTree)
		{
			this.o0_0oO.OooO. = A_0;
			A_0.oOOO_0o.0o. = true;
		}

		/// <summary>
		/// 生成层级BOM树
		/// </summary>
		/// <param name="Table">基于此Table生成层级BOM树</param>
		/// <param name="Setting">LayerTreeSetting类型，用于设置层级BOM树</param>
		// Token: 0x060053FB RID: 21499 RVA: 0x00256E22 File Offset: 0x00255022
		[oO0oooo("3373")]
		public void BuildBOMTree(Table Table, LayerTreeSetting Setting)
		{
			Setting.Unique = true;
			this.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.OOO.__O_oO_.);
		}

		/// <summary>
		/// 生成层级筛选树
		/// </summary>
		/// <param name="Table">基于此Table生成层级筛选树</param>
		/// <param name="Setting">LayerTreeSetting类型，用于设置层级筛选树</param>
		// Token: 0x060053FC RID: 21500 RVA: 0x00256E34 File Offset: 0x00255034
		[oO0oooo("3374")]
		public void BuildFilterTree(Table Table, LayerTreeSetting Setting)
		{
			this.o0_0oO.OooO.(Table, Setting, O0_0_0O0___O.oOO___o.0oO.);
		}

		// Token: 0x060053FD RID: 21501 RVA: 0x00256E40 File Offset: 0x00255040
		private void <<EMPTY_NAME>>(Table A_0, LayerTreeSetting A_1, O0_0_0O0___O A_2)
		{
			this.o0_0oO.OooO..OO_0._O_. = A_0;
			this.o0_0oO.OooO..OO_0._O_. = A_2;
			this.o0_0oO.OooO..oo.00__O0o. = A_1.PathCol;
			this.o0_0oO.OooO..OO0_0O._oO0O_o. = A_1.TextCol;
			this.o0_0oO.OooO..oo__._0. = A_1.ValueCol;
			this.o0_0oO.OooO..OO_0._O_. = A_1.Subtotal;
			this.o0_0oO.OooO..OO_0o0.O_o_. = A_1.IncludeSub;
			this.o0_0oO.OooO..oo.00__O0o. = A_1.Separator2;
			this.o0_0oO.OooO..oo.00__O0o. = A_1.Lengths2;
			this.o0_0oO.OooO..OOOOO0.0. = A_1.ExpandTo;
			this.o0_0oO.OooO..o0ooOo0.0o_Oo. = A_1.GridTree;
			this.o0_0oO.OooO..o_._O0___O. = A_1.SortCol;
			this.o0_0oO.OooO..oOo.O. = A_1.SortDesc;
			this.o0_0oO.OooO..o_._O0___O. = A_1.Unique;
			this.o0_0oO.OooO..OO0_0O._oO0O_o. = A_1.MergeTotal;
			if (Operators.CompareString(this.o0_0oO.OooO..oo.00__O0o., "", true) > 0)
			{
				this.o0_0oO.OooO..o.0o__.();
				this.o0_0oO.OooO..o_oo_O0O.oO_.();
			}
		}

		// Token: 0x040022AF RID: 8879
		private oO_oo0Oo <<EMPTY_NAME>>;
	}
}
