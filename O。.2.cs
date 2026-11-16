using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020003ED RID: 1005
	[DesignerGenerated]
	internal partial class O\u3002\u3000 : DropDownForm
	{
		// Token: 0x06004153 RID: 16723 RVA: 0x001D82F0 File Offset: 0x001D64F0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O__o0Oo_o.0. != null)
				{
					this.O__o0Oo_o.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06004154 RID: 16724 RVA: 0x001D8330 File Offset: 0x001D6530
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O__0o.o0_.(new C1Button());
			this.oo00Oo.O0OO0_.(new C1Button());
			this.O__o0Oo_o.0.(new CustomCheckedListBox());
			this.Oooo_._O0.(new C1Button());
			((ISupportInitialize)this.O__0o.o0_.()).BeginInit();
			((ISupportInitialize)this.O0.O0_.()).BeginInit();
			((ISupportInitialize)this.oo00Oo.O0OO0_.()).BeginInit();
			base.SuspendLayout();
			this.O__0o.o0_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O__0o.o0_.().Location = new Point(90, 202);
			this.O__0o.o0_.().Name = "btnOK";
			this.O__0o.o0_.().Size = new Size(46, 21);
			this.O__0o.o0_.().TabIndex = 1;
			this.O__0o.o0_.().Text = "确定";
			this.O__0o.o0_.().UseVisualStyleBackColor = true;
			this.O0.O0_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O0.O0_.().DialogResult = DialogResult.Cancel;
			this.O0.O0_.().Location = new Point(140, 202);
			this.O0.O0_.().Name = "btnCancel";
			this.O0.O0_.().Size = new Size(46, 21);
			this.O0.O0_.().TabIndex = 2;
			this.O0.O0_.().Text = "取消";
			this.O0.O0_.().UseVisualStyleBackColor = true;
			this.O__0o.o0_.().Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.O__0o.o0_.().CheckOnClick = true;
			this.O__0o.o0_.().FormattingEnabled = true;
			this.O__0o.o0_.().Location = new Point(2, 3);
			this.O__0o.o0_.().Name = "CheckedListBox";
			this.O__0o.o0_.().SelectedValue2 = null;
			this.O__0o.o0_.().Separator = ",";
			this.O__0o.o0_.().Size = new Size(185, 164);
			this.O__0o.o0_.().TabIndex = 0;
			this.O__0o.o0_.().Value = "";
			this.oo00Oo.O0OO0_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.oo00Oo.O0OO0_.().Location = new Point(2, 202);
			this.oo00Oo.O0OO0_.().Name = "btnSelectAll";
			this.oo00Oo.O0OO0_.().Size = new Size(46, 21);
			this.oo00Oo.O0OO0_.().TabIndex = 3;
			this.oo00Oo.O0OO0_.().Text = "全选";
			this.oo00Oo.O0OO0_.().UseVisualStyleBackColor = true;
			base.AcceptButton = this.O__0o.o0_.();
			base.AutoScaleMode = AutoScaleMode.None;
			base.CancelButton = this.O0.O0_.();
			base.ClientSize = new Size(187, 224);
			base.Controls.Add(this.oo00Oo.O0OO0_.());
			base.Controls.Add(this.O__0o.o0_.());
			base.Controls.Add(this.O0.O0_.());
			base.Controls.Add(this.O__0o.o0_.());
			base.Name = "frmMultiValueEditor";
			this.Text = "frmMultiValue";
			((ISupportInitialize)this.O__0o.o0_.()).EndInit();
			((ISupportInitialize)this.O0.O0_.()).EndInit();
			((ISupportInitialize)this.oo00Oo.O0OO0_.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x001D863C File Offset: 0x001D683C
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O__o0Oo_o.0.;
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x001D8644 File Offset: 0x001D6844
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O00o.0o_Oo0.);
			C1Button o__o0Oo_o.0. = this.O__o0Oo_o.0.;
			if (o__o0Oo_o.0. != null)
			{
				o__o0Oo_o.0..Click -= value;
			}
			this.O__o0Oo_o.0. = A_0;
			o__o0Oo_o.0. = this.O__o0Oo_o.0.;
			if (o__o0Oo_o.0. != null)
			{
				o__o0Oo_o.0..Click += value;
			}
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x001D8687 File Offset: 0x001D6887
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_O0.0o_O.;
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x001D8690 File Offset: 0x001D6890
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OO__.00000_o.);
			C1Button ooo_O0.0o_O. = this.Ooo_O0.0o_O.;
			if (ooo_O0.0o_O. != null)
			{
				ooo_O0.0o_O..Click -= value;
			}
			this.Ooo_O0.0o_O. = A_0;
			ooo_O0.0o_O. = this.Ooo_O0.0o_O.;
			if (ooo_O0.0o_O. != null)
			{
				ooo_O0.0o_O..Click += value;
			}
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x001D86D3 File Offset: 0x001D68D3
		[CompilerGenerated]
		internal virtual CustomCheckedListBox <<EMPTY_NAME>>()
		{
			return this.O__o0Oo_o.0.;
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x001D86DB File Offset: 0x001D68DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(CustomCheckedListBox A_0)
		{
			this.O__o0Oo_o.0. = A_0;
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x001D86E4 File Offset: 0x001D68E4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oooo_._O0.;
		}

		// Token: 0x0600415C RID: 16732 RVA: 0x001D86EC File Offset: 0x001D68EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__0o.o0_.);
			C1Button oooo_._O0. = this.Oooo_._O0.;
			if (oooo_._O0. != null)
			{
				oooo_._O0..Click -= value;
			}
			this.Oooo_._O0. = A_0;
			oooo_._O0. = this.Oooo_._O0.;
			if (oooo_._O0. != null)
			{
				oooo_._O0..Click += value;
			}
		}

		// Token: 0x0600415D RID: 16733 RVA: 0x001D872F File Offset: 0x001D692F
		public O\u3002\u3000()
		{
			base.PostChanges += this.Oo_0_._O0_0_o.;
			this.O__0o.o0_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x001D8764 File Offset: 0x001D6964
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				base.OwnerControl.Value = this.O__0o.o0_.().Value;
				if (base.OwnerControl.DataBindings.Count > 0)
				{
					base.OwnerControl.DataBindings[0].WriteValue();
				}
			}
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x001D87B9 File Offset: 0x001D69B9
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.OK;
			base.OwnerControl.CloseDropDown();
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x001D87CD File Offset: 0x001D69CD
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.DialogResult = DialogResult.Cancel;
			base.OwnerControl.CloseDropDown();
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x001D87E4 File Offset: 0x001D69E4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.OwnerControl.Select();
			int num = 0;
			int num2 = this.O__0o.o0_.().Items.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (this.O__0o.o0_.().GetItemChecked(i))
				{
					num++;
				}
			}
			bool value = num != this.O__0o.o0_.().Items.Count;
			int num3 = this.O__0o.o0_.().Items.Count - 1;
			for (int j = 0; j <= num3; j++)
			{
				this.O__0o.o0_.().SetItemChecked(j, value);
			}
		}

		// Token: 0x04001A5C RID: 6748
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001A5D RID: 6749
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001A5E RID: 6750
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001A5F RID: 6751
		[CompilerGenerated]
		private CustomCheckedListBox <<EMPTY_NAME>>;

		// Token: 0x04001A60 RID: 6752
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;
	}
}
