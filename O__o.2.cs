using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000277 RID: 631
	internal class O__o : O0O_O0
	{
		// Token: 0x06001EBB RID: 7867 RVA: 0x000D335C File Offset: 0x000D155C
		[CompilerGenerated]
		private virtual Binding <<EMPTY_NAME>>()
		{
			return this.o__0_o0.OOO_.;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000D3364 File Offset: 0x000D1564
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(Binding A_0)
		{
			ConvertEventHandler value = new ConvertEventHandler(this.o__0_o0.OOO_.);
			Binding binding = this.o__0_o0.OOO_.;
			if (binding != null)
			{
				binding.Parse -= value;
			}
			this.o__0_o0.OOO_. = A_0;
			binding = this.o__0_o0.OOO_.;
			if (binding != null)
			{
				binding.Parse += value;
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x000D33A7 File Offset: 0x000D15A7
		public O__o()
		{
			this.o__0_o0.OOO_. = true;
			base.VerticalAlign = VerticalAlignEnum.Top;
			this.Multiline = true;
			base.ScrollBars = ScrollBars.Vertical;
			base.InitialSelection = InitialSelectionEnum.CaretAtStart;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x000D33D2 File Offset: 0x000D15D2
		internal void <<EMPTY_NAME>>(Table A_0, string A_1)
		{
			base.DataBindings.Add("Value", A_0.View, A_1);
			this.o__0_o0.OOO_. = A_0;
			this.o__0_o0.OOO_.(base.DataBindings[0]);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x000D3408 File Offset: 0x000D1608
		private void <<EMPTY_NAME>>(object A_0, ConvertEventArgs A_1)
		{
			DataRowView dataRowView = (DataRowView)this.o__0_o0.OOO_.().BindingManagerBase.Current;
			string bindingField = this.o__0_o0.OOO_.().BindingMemberInfo.BindingField;
			if (Operators.CompareString(A_1.Value.ToString(), dataRowView[bindingField].ToString(), true) != 0)
			{
				this.o__0_o0.OOO_..O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this.o__0_o0.OOO_., dataRowView.Row, bindingField));
			}
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x000D3480 File Offset: 0x000D1680
		internal DataCol <<EMPTY_NAME>>()
		{
			DataTable dataTable = ((O_0)this.o__0_o0.OOO_.().DataSource).o_o.O0ooOo.();
			return OO_00oOO.DataTables[dataTable.TableName].DataCols[this.o__0_o0.OOO_.().BindingMemberInfo.BindingField];
		}

		// Token: 0x04000CF1 RID: 3313
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000CF2 RID: 3314
		[CompilerGenerated]
		private Binding <<EMPTY_NAME>>;

		// Token: 0x04000CF3 RID: 3315
		private Table <<EMPTY_NAME>>;
	}
}
