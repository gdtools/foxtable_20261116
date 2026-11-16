using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200014B RID: 331
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class O00o : C1FontPicker, O000O
	{
		// Token: 0x0600104F RID: 4175 RVA: 0x0007D79C File Offset: 0x0007B99C
		public O00o()
		{
			base.DropDownClosed += this.O__00_Oo0.00__.;
			base.Enter += this.OO.0O00.;
			base.GotFocus += this.O__00_Oo0.00__.;
			this.OoO0O0.0O_oo. = BooleanEnum.Default;
			base.VisualStyle = VisualStyle.Custom;
			Main.OO_O.o..o.O000oo.(new object[]
			{
				this
			});
			base.EmptyAsNull = true;
			base.MaskInfo.EmptyAsNull = true;
			base.ErrorInfo.ShowErrorMessage = false;
			base.AutoSize = false;
			base.VerticalAlign = VerticalAlignEnum.Middle;
			base.Padding = new Padding(1, 2, 1, 1);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0007D843 File Offset: 0x0007BA43
		public BooleanEnum <<EMPTY_NAME>>()
		{
			return this.OoO0O0.0O_oo.;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0007D84B File Offset: 0x0007BA4B
		public void <<EMPTY_NAME>>(BooleanEnum A_0)
		{
			this.OoO0O0.0O_oo. = A_0;
			ooO_0O.o_O0.O_.(this, this.OoO0O0.0O_oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0007D86C File Offset: 0x0007BA6C
		public void <<EMPTY_NAME>>()
		{
			ooO_0O.o_O0.O_.(this, this.OoO0O0.0O_oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0007D888 File Offset: 0x0007BA88
		private void <<EMPTY_NAME>>(object A_0, DropDownClosedEventArgs A_1)
		{
			if (base.FindForm() != null && base.DataBindings.Count > 0 && base.DataBindings[0].BindingManagerBase.Count > 0)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(base.DataBindings[0].BindingManagerBase.Current);
				if (objectValue is DataRowView)
				{
					DataRow row = ((DataRowView)objectValue).Row;
					string bindingField = base.DataBindings[0].BindingMemberInfo.BindingField;
					if (Operators.CompareString(row[bindingField].ToString(), this.Text, true) != 0 && base.UpdateValueWithCurrentText())
					{
						base.DataBindings[0].WriteValue();
						((DataRowView)objectValue).Row.EndEdit();
					}
				}
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0007D958 File Offset: 0x0007BB58
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.OoO0O0.0O_oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0007D972 File Offset: 0x0007BB72
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ooO_0O.o_O0.O_.(this, this.OoO0O0.0O_oo.());
			base.ReadOnly = base.ReadOnly;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0007D98C File Offset: 0x0007BB8C
		public bool <<EMPTY_NAME>>()
		{
			return this.OoO0O0.0O_oo.;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0007D994 File Offset: 0x0007BB94
		public void <<EMPTY_NAME>>(bool A_0)
		{
			this.OoO0O0.0O_oo. = A_0;
		}

		// Token: 0x04000653 RID: 1619
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x04000654 RID: 1620
		private bool <<EMPTY_NAME>>;
	}
}
