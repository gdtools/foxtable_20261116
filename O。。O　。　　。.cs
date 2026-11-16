using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000361 RID: 865
	[DesignerGenerated]
	internal partial class O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002 : Form
	{
		// Token: 0x06003622 RID: 13858 RVA: 0x00177EF0 File Offset: 0x001760F0
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oo000.ooOOO___. != null)
				{
					this.oo000.ooOOO___..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00177F30 File Offset: 0x00176130
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oO0_oo0oo0oO.O.(new C1Button());
			this.oOoOO0.OO0oO.(new C1Button());
			this.oOoOO0.OO0oO.(new Label());
			this.oOoOO0.OO0oO.(new C1NumericEdit());
			this.oOoOO0.OO0oO.(new C1ComboBox());
			((ISupportInitialize)this.o0.o_.()).BeginInit();
			base.SuspendLayout();
			this.o0.o_.().DialogResult = DialogResult.Cancel;
			this.o0.o_.().Location = new Point(210, 121);
			this.o0.o_.().Margin = new Padding(4, 5, 4, 5);
			this.o0.o_.().Name = "Button2";
			this.o0.o_.().Size = new Size(112, 35);
			this.o0.o_.().TabIndex = 2;
			this.o0.o_.().Text = "取消";
			this.o0.o_.().UseVisualStyleBackColor = true;
			this.O.o0o.().Location = new Point(73, 121);
			this.O.o0o.().Margin = new Padding(4, 5, 4, 5);
			this.O.o0o.().Name = "Button1";
			this.O.o0o.().Size = new Size(112, 35);
			this.O.o0o.().TabIndex = 1;
			this.O.o0o.().Text = "确定";
			this.O.o0o.().UseVisualStyleBackColor = true;
			this.oOoOO0.OO0oO.().AutoSize = true;
			this.oOoOO0.OO0oO.().Location = new Point(19, 18);
			this.oOoOO0.OO0oO.().Margin = new Padding(4, 0, 4, 0);
			this.oOoOO0.OO0oO.().Name = "Label1";
			this.oOoOO0.OO0oO.().Size = new Size(62, 18);
			this.oOoOO0.OO0oO.().TabIndex = 4;
			this.oOoOO0.OO0oO.().Text = "Label1";
			this.o0.o_.().BorderStyle = BorderStyle.FixedSingle;
			this.o0.o_.().Calculator.BackColor = Color.FromArgb(240, 241, 242);
			this.o0.o_.().Calculator.VisualStyle = VisualStyle.Office2007Silver;
			this.o0.o_.().Calculator.VisualStyleBaseStyle = VisualStyle.Office2007Silver;
			this.o0.o_.().Font = new Font("宋体", 10f, FontStyle.Regular, GraphicsUnit.Point, 134);
			this.o0.o_.().ImagePadding = new Padding(0);
			this.o0.o_.().Location = new Point(165, 60);
			this.o0.o_.().Margin = new Padding(4, 5, 4, 5);
			this.o0.o_.().Name = "C1NumericEdit1";
			this.o0.o_.().Size = new Size(212, 28);
			this.o0.o_.().TabIndex = 0;
			this.o0.o_.().Tag = null;
			this.o0.o_.().VisibleButtons = DropDownControlButtonFlags.DropDown;
			this.o0.o_.().VisualStyle = VisualStyle.Office2007Silver;
			this.o0.o_.().VisualStyleBaseStyle = VisualStyle.Office2007Silver;
			this.oOoOO0.OO0oO.().DropDownStyle = DropDownStyle.DropDownList;
			this.oOoOO0.OO0oO.().Location = new Point(22, 61);
			this.oOoOO0.OO0oO.().Margin = new Padding(3, 4, 3, 4);
			this.oOoOO0.OO0oO.().Name = "ComboBox1";
			this.oOoOO0.OO0oO.().Size = new Size(134, 26);
			this.oOoOO0.OO0oO.().TabIndex = 5;
			base.AcceptButton = this.O.o0o.();
			base.AutoScaleDimensions = new SizeF(9f, 18f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.o0.o_.();
			base.ClientSize = new Size(397, 175);
			base.Controls.Add(this.oOoOO0.OO0oO.());
			base.Controls.Add(this.o0.o_.());
			base.Controls.Add(this.o0.o_.());
			base.Controls.Add(this.O.o0o.());
			base.Controls.Add(this.oOoOO0.OO0oO.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.Margin = new Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.1.o1O_.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "数值筛选";
			((ISupportInitialize)this.o0.o_.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x0017836E File Offset: 0x0017656E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOoOO0.OO0oO.;
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x00178376 File Offset: 0x00176576
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oOoOO0.OO0oO. = A_0;
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0017837F File Offset: 0x0017657F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0_oo0oo0oO.O.;
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00178388 File Offset: 0x00176588
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.o0o.);
			C1Button c1Button = this.oO0_oo0oo0oO.O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0_oo0oo0oO.O. = A_0;
			c1Button = this.oO0_oo0oo0oO.O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x001783CB File Offset: 0x001765CB
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo000.ooOOO___.;
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x001783D3 File Offset: 0x001765D3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo000.ooOOO___. = A_0;
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x001783DC File Offset: 0x001765DC
		[CompilerGenerated]
		internal virtual C1NumericEdit <<EMPTY_NAME>>()
		{
			return this.oo000.ooOOO___.;
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x001783E4 File Offset: 0x001765E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1NumericEdit A_0)
		{
			this.oo000.ooOOO___. = A_0;
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x001783ED File Offset: 0x001765ED
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oo000.ooOOO___.;
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x001783F8 File Offset: 0x001765F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o0.o_.);
			C1ComboBox c1ComboBox = this.oo000.ooOOO___.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.oo000.ooOOO___. = A_0;
			c1ComboBox = this.oo000.ooOOO___.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0017843C File Offset: 0x0017663C
		public O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002(Table A_0, Col A_1, O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum A_2)
		{
			base.FormClosed += this.o0.o_.;
			this.oOoOO0.OO0oO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.oo000.ooOOO___. = A_0;
			this.oo000.ooOOO___. = A_1;
			this.oo000.ooOOO___. = A_2;
			this.oOoOO0.OO0oO.().Text = A_1.Name + ":";
			this.o0.o_.().DataType = A_0.foxGrid.Cols[A_1.Name].DataType;
			this.oOoOO0.OO0oO.().Items.AddRange(Enum.GetNames(typeof(O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum)));
			this.oOoOO0.OO0oO.().MaxDropDownItems = this.oOoOO0.OO0oO.().Items.Count;
			this.oOoOO0.OO0oO.().SelectedIndex = (int)this.oo000.ooOOO___.;
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00178520 File Offset: 0x00176720
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
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
				bool flag = Oo00.O____0O._0.(this.oo000.ooOOO___.);
				IL_15:
				num2 = 3;
				if (!flag)
				{
					goto IL_36;
				}
				IL_1A:
				num2 = 4;
				string text = Oo00.OoOo_oo_.o_o.(this.oo000.ooOOO___..Name, this.oo000.ooOOO___.);
				goto IL_54;
				IL_36:
				num2 = 6;
				text = "[" + this.oo000.ooOOO___..Name + "]";
				IL_54:
				num2 = 7;
				if (this.o0.o_.().Value != DBNull.Value)
				{
					goto IL_AC;
				}
				IL_68:
				num2 = 8;
				O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum filterModeEnum = this.oo000.ooOOO___.;
				if (filterModeEnum != O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.等于)
				{
					if (filterModeEnum != O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不等于)
					{
						goto IL_1F0;
					}
					IL_96:
					num2 = 12;
					text += " Is Not Null";
					goto IL_1D5;
				}
				IL_80:
				num2 = 10;
				text += " Is Null";
				goto IL_1D5;
				IL_AC:
				num2 = 17;
				switch (this.oo000.ooOOO___.)
				{
				case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.等于:
					IL_DB:
					num2 = 19;
					text = text + " = " + this.o0.o_.().Value.ToString();
					break;
				case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.大于:
					IL_14B:
					num2 = 23;
					text = text + " > " + this.o0.o_.().Value.ToString();
					break;
				case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.小于:
					IL_191:
					num2 = 27;
					text = text + " < " + this.o0.o_.().Value.ToString();
					break;
				case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不等于:
					IL_101:
					num2 = 21;
					text = string.Concat(new string[]
					{
						text,
						" <> ",
						this.o0.o_.().Value.ToString(),
						" Or ",
						text,
						" Is Null"
					});
					break;
				case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不大于:
					IL_16E:
					num2 = 25;
					text = text + " <= " + this.o0.o_.().Value.ToString();
					break;
				case O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum.不小于:
					IL_1B4:
					num2 = 29;
					text = text + " >= " + this.o0.o_.().Value.ToString();
					break;
				}
				IL_1D5:
				num2 = 31;
				Filter.O0O0o.Oo0OO_oO.(this.oo000.ooOOO___., text, true);
				IL_1E6:
				num2 = 32;
				base.DialogResult = DialogResult.OK;
				IL_1F0:
				goto IL_2C6;
				IL_1F5:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_287:
				goto IL_2BB;
				IL_289:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_299:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_289;
			}
			IL_2BB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2C6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00178818 File Offset: 0x00176A18
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oo000.ooOOO___. = (O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum)this.oOoOO0.OO0oO.().SelectedIndex;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x0017882B File Offset: 0x00176A2B
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040015E2 RID: 5602
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040015E3 RID: 5603
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015E4 RID: 5604
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040015E5 RID: 5605
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040015E6 RID: 5606
		[CompilerGenerated]
		private C1NumericEdit <<EMPTY_NAME>>;

		// Token: 0x040015E7 RID: 5607
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x040015E8 RID: 5608
		private Table <<EMPTY_NAME>>;

		// Token: 0x040015E9 RID: 5609
		private Col <<EMPTY_NAME>>;

		// Token: 0x040015EA RID: 5610
		private O\u3002\u3002O\u3000\u3002\u3000\u3000\u3002.FilterModeEnum <<EMPTY_NAME>>;

		// Token: 0x02000362 RID: 866
		internal enum FilterModeEnum
		{
			// Token: 0x040015EC RID: 5612
			等于,
			// Token: 0x040015ED RID: 5613
			大于,
			// Token: 0x040015EE RID: 5614
			小于,
			// Token: 0x040015EF RID: 5615
			不等于,
			// Token: 0x040015F0 RID: 5616
			不大于,
			// Token: 0x040015F1 RID: 5617
			不小于
		}
	}
}
