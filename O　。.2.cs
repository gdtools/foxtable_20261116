using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000D5 RID: 213
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerGenerated]
	internal partial class O\u3000\u3002\u3000 : Form
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x00050BE0 File Offset: 0x0004EDE0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.Oo._O__OO_0O. != null)
				{
					this.Oo._O__OO_0O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00050C20 File Offset: 0x0004EE20
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o000.O0.(new C1Button());
			this.OoOo_0O._O00.(new C1Button());
			this.OoOo_0O._O00.(new Label());
			this.o000.O0.(new Label());
			this.OoOo_0O._O00.(new C1ComboBox());
			this.o000.O0.(new C1ComboBox());
			((ISupportInitialize)this.O0oOOo_o_O.O_O.()).BeginInit();
			((ISupportInitialize)this.O.00OO00_oo.()).BeginInit();
			((ISupportInitialize)this.O.00OO00_oo.()).BeginInit();
			((ISupportInitialize)this.O0oOOo_o_O.O_O.()).BeginInit();
			base.SuspendLayout();
			this.O0oOOo_o_O.O_O.().DialogResult = DialogResult.Cancel;
			this.O0oOOo_o_O.O_O.().ImageAlign = ContentAlignment.MiddleLeft;
			this.O0oOOo_o_O.O_O.().Location = new Point(178, 110);
			this.O0oOOo_o_O.O_O.().Name = "btnCancel";
			this.O0oOOo_o_O.O_O.().Size = new Size(75, 23);
			this.O0oOOo_o_O.O_O.().TabIndex = 31;
			this.O0oOOo_o_O.O_O.().Text = "取消";
			this.O0oOOo_o_O.O_O.().UseVisualStyleBackColor = true;
			this.O.00OO00_oo.().ImageAlign = ContentAlignment.MiddleLeft;
			this.O.00OO00_oo.().Location = new Point(82, 110);
			this.O.00OO00_oo.().Name = "btnOK";
			this.O.00OO00_oo.().Size = new Size(75, 23);
			this.O.00OO00_oo.().TabIndex = 28;
			this.O.00OO00_oo.().Text = "筛选";
			this.O.00OO00_oo.().UseVisualStyleBackColor = true;
			this.o000.O0.().AutoSize = true;
			this.o000.O0.().Location = new Point(32, 61);
			this.o000.O0.().Margin = new Padding(2, 0, 2, 0);
			this.o000.O0.().Name = "Label2";
			this.o000.O0.().Size = new Size(35, 12);
			this.o000.O0.().TabIndex = 29;
			this.o000.O0.().Text = "下级:";
			this.OoOo_0O._O00.().AutoSize = true;
			this.OoOo_0O._O00.().Location = new Point(32, 24);
			this.OoOo_0O._O00.().Margin = new Padding(2, 0, 2, 0);
			this.OoOo_0O._O00.().Name = "Label1";
			this.OoOo_0O._O00.().Size = new Size(35, 12);
			this.OoOo_0O._O00.().TabIndex = 27;
			this.OoOo_0O._O00.().Text = "上级:";
			this.O.00OO00_oo.().AllowSpinLoop = false;
			this.O.00OO00_oo.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.O.00OO00_oo.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.O.00OO00_oo.().Cursor = Cursors.Arrow;
			this.O.00OO00_oo.().DropDownStyle = DropDownStyle.DropDownList;
			this.O.00OO00_oo.().GapHeight = 0;
			this.O.00OO00_oo.().ImagePadding = new Padding(0);
			this.O.00OO00_oo.().ItemsDisplayMember = "";
			this.O.00OO00_oo.().ItemsValueMember = "";
			this.O.00OO00_oo.().Location = new Point(72, 58);
			this.O.00OO00_oo.().Name = "cmbChildCol";
			this.O.00OO00_oo.().Size = new Size(241, 19);
			this.O.00OO00_oo.().TabIndex = 24;
			this.O.00OO00_oo.().Tag = null;
			this.O0oOOo_o_O.O_O.().AllowSpinLoop = false;
			this.O0oOOo_o_O.O_O.().AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.O0oOOo_o_O.O_O.().AutoCompleteSource = AutoCompleteSource.ListItems;
			this.O0oOOo_o_O.O_O.().Cursor = Cursors.Arrow;
			this.O0oOOo_o_O.O_O.().DropDownStyle = DropDownStyle.DropDownList;
			this.O0oOOo_o_O.O_O.().GapHeight = 0;
			this.O0oOOo_o_O.O_O.().ImagePadding = new Padding(0);
			this.O0oOOo_o_O.O_O.().ItemsDisplayMember = "";
			this.O0oOOo_o_O.O_O.().ItemsValueMember = "";
			this.O0oOOo_o_O.O_O.().Location = new Point(72, 21);
			this.O0oOOo_o_O.O_O.().Name = "cmbParentCol";
			this.O0oOOo_o_O.O_O.().Size = new Size(241, 19);
			this.O0oOOo_o_O.O_O.().TabIndex = 23;
			this.O0oOOo_o_O.O_O.().Tag = null;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(334, 155);
			base.Controls.Add(this.O0oOOo_o_O.O_O.());
			base.Controls.Add(this.O.00OO00_oo.());
			base.Controls.Add(this.o000.O0.());
			base.Controls.Add(this.OoOo_0O._O00.());
			base.Controls.Add(this.O.00OO00_oo.());
			base.Controls.Add(this.O0oOOo_o_O.O_O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o0.00...o";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "循环引用筛选";
			((ISupportInitialize)this.O0oOOo_o_O.O_O.()).EndInit();
			((ISupportInitialize)this.O.00OO00_oo.()).EndInit();
			((ISupportInitialize)this.O.00OO00_oo.()).EndInit();
			((ISupportInitialize)this.O0oOOo_o_O.O_O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00051122 File Offset: 0x0004F322
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo._O__OO_0O.;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0005112A File Offset: 0x0004F32A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.Oo._O__OO_0O. = A_0;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00051133 File Offset: 0x0004F333
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_Oo0._oOoo0.;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0005113C File Offset: 0x0004F33C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.00OO00_oo.);
			C1Button c1Button = this.o_Oo0._oOoo0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_Oo0._oOoo0. = A_0;
			c1Button = this.o_Oo0._oOoo0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0005117F File Offset: 0x0004F37F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.Oo._O__OO_0O.;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00051187 File Offset: 0x0004F387
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.Oo._O__OO_0O. = A_0;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00051190 File Offset: 0x0004F390
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o_Oo0._oOoo0.;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00051198 File Offset: 0x0004F398
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o_Oo0._oOoo0. = A_0;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000511A1 File Offset: 0x0004F3A1
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.Oo._O__OO_0O.;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000511A9 File Offset: 0x0004F3A9
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.Oo._O__OO_0O. = A_0;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000511B2 File Offset: 0x0004F3B2
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_Oo0._oOoo0.;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000511BA File Offset: 0x0004F3BA
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o_Oo0._oOoo0. = A_0;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000511C4 File Offset: 0x0004F3C4
		public O\u3000\u3002\u3000(Table A_0)
		{
			base.Load += this.O0oOOo_o_O.O_O.;
			base.FormClosed += this.O.00OO00_oo.;
			this.Oo._O__OO_0O. = new Dictionary<string, string>();
			this.OoOo_0O._O00.();
			this.Oo._O__OO_0O. = A_0;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00051214 File Offset: 0x0004F414
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			C1ComboBox[] array = new C1ComboBox[]
			{
				this.O0oOOo_o_O.O_O.(),
				this.O.00OO00_oo.()
			};
			try
			{
				foreach (DataCol dataCol in this.Oo._O__OO_0O..DataTable.DataCols)
				{
					string text = dataCol.Name;
					if (Operators.CompareString(dataCol.Caption, "", true) > 0 && !this.Oo._O__OO_0O..ContainsKey(dataCol.Caption))
					{
						this.Oo._O__OO_0O..Add(dataCol.Caption, dataCol.Name);
						text = dataCol.Caption;
					}
					C1ComboBox[] array2 = array;
					checked
					{
						for (int i = 0; i < array2.Length; i++)
						{
							array2[i].Items.Add(text);
						}
					}
					if (Operators.CompareString(text, this.Oo._O__OO_0O..O0.00__., true) == 0)
					{
						this.O0oOOo_o_O.O_O.().SelectedIndex = this.O0oOOo_o_O.O_O.().Items.Count - 1;
					}
					if (Operators.CompareString(text, this.Oo._O__OO_0O..o.o0o_0., true) == 0)
					{
						this.O.00OO00_oo.().SelectedIndex = this.O.00OO00_oo.().Items.Count - 1;
					}
				}
			}
			finally
			{
				IEnumerator<DataCol> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0005137C File Offset: 0x0004F57C
		private string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (this.Oo._O__OO_0O..ContainsKey(A_0))
			{
				result = this.Oo._O__OO_0O.[A_0];
			}
			else
			{
				result = A_0;
			}
			return result;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000513AC File Offset: 0x0004F5AC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.O0oOOo_o_O.O_O.().SelectedItem != null && this.O.00OO00_oo.().SelectedItem != null)
			{
				this.Oo._O__OO_0O..O0.00__. = this.O0oOOo_o_O.O_O.().SelectedItem.ToString();
				this.Oo._O__OO_0O..o.o0o_0. = this.O.00OO00_oo.().SelectedItem.ToString();
				this.Oo._O__OO_0O..NeedSaveSetting = true;
				this.Oo._O__OO_0O..LoopFilter(this.O0oOOo_o_O.O_O.().SelectedItem.ToString(), this.O.00OO00_oo.().SelectedItem.ToString());
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0005144A File Offset: 0x0004F64A
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400038D RID: 909
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400038E RID: 910
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400038F RID: 911
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04000390 RID: 912
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000391 RID: 913
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000393 RID: 915
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04000394 RID: 916
		private Table <<EMPTY_NAME>>;

		// Token: 0x04000395 RID: 917
		private Dictionary<string, string> <<EMPTY_NAME>>;
	}
}
