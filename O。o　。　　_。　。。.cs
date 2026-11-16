using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000346 RID: 838
	[DesignerGenerated]
	internal partial class O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002 : Form
	{
		// Token: 0x0600332F RID: 13103 RVA: 0x0015DE34 File Offset: 0x0015C034
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.OoO_.O. != null)
				{
					this.OoO_.O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x0015DE74 File Offset: 0x0015C074
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.Oo_0.oooo__.(new C1Button());
			this.Oo0.o0.(new C1Button());
			this.OO.o0o0.(new C1FlexGrid());
			this.OO.o0o0.(new C1TextBox());
			this.OO__.o___oO.(new RadioButton());
			this.Oo_0.oooo__.(new RadioButton());
			this.o_0O.0.(new RadioButton());
			this.OO.o0o0.(new OpenFileDialog());
			this.O.0Ooo_.(new RadioButton());
			this.OO.o0o0.(new RadioButton());
			this.Oo_OO_o0oO.oo.(new RadioButton());
			((ISupportInitialize)this.OoOO.000_o_O.()).BeginInit();
			base.SuspendLayout();
			this.OoOO.000_o_O.().DialogResult = DialogResult.OK;
			this.OoOO.000_o_O.().Location = new Point(327, 395);
			this.OoOO.000_o_O.().Name = "Button2";
			this.OoOO.000_o_O.().Size = new Size(75, 23);
			this.OoOO.000_o_O.().TabIndex = 9;
			this.OoOO.000_o_O.().Text = "取消";
			this.OoOO.000_o_O.().UseVisualStyleBackColor = true;
			this.O.__0OO0O0.().Location = new Point(236, 395);
			this.O.__0OO0O0.().Name = "Button1";
			this.O.__0OO0O0.().Size = new Size(75, 23);
			this.O.__0OO0O0.().TabIndex = 8;
			this.O.__0OO0O0.().Text = "确定";
			this.O.__0OO0O0.().UseVisualStyleBackColor = true;
			this.OoOO.000_o_O.().AllowEditing = false;
			this.OoOO.000_o_O.().ColumnInfo = "10,1,0,25,0,0,Columns:";
			this.OoOO.000_o_O.().Location = new Point(12, 12);
			this.OoOO.000_o_O.().Name = "Grid";
			this.OoOO.000_o_O.().Rows.DefaultSize = 20;
			this.OoOO.000_o_O.().SelectionMode = SelectionModeEnum.Column;
			this.OoOO.000_o_O.().Size = new Size(597, 287);
			this.OoOO.000_o_O.().TabIndex = 0;
			this.Oo0.o0.().AcceptsReturn = true;
			this.Oo0.o0.().Location = new Point(125, 344);
			this.Oo0.o0.().Name = "txtSeparator";
			this.Oo0.o0.().ReadOnly = true;
			this.Oo0.o0.().Size = new Size(100, 21);
			this.Oo0.o0.().TabIndex = 4;
			this.Oo0.o0.().Value = ",";
			this.O_.00_.().AutoSize = true;
			this.O_.00_.().Location = new Point(12, 346);
			this.O_.00_.().Name = "Custom";
			this.O_.00_.().Size = new Size(107, 16);
			this.O_.00_.().TabIndex = 3;
			this.O_.00_.().TabStop = true;
			this.O_.00_.().Text = "自定义列分隔符";
			this.O_.00_.().UseVisualStyleBackColor = true;
			this.OoOO.000_o_O.().AutoSize = true;
			this.OoOO.000_o_O.().Location = new Point(131, 314);
			this.OoOO.000_o_O.().Name = "Comma";
			this.OoOO.000_o_O.().Size = new Size(95, 16);
			this.OoOO.000_o_O.().TabIndex = 2;
			this.OoOO.000_o_O.().Text = "用逗号分割列";
			this.OoOO.000_o_O.().UseVisualStyleBackColor = true;
			this.O_.O0o_O.().AutoSize = true;
			this.O_.O0o_O.().Checked = true;
			this.O_.O0o_O.().Location = new Point(12, 315);
			this.O_.O0o_O.().Name = "Tab";
			this.O_.O0o_O.().Size = new Size(101, 16);
			this.O_.O0o_O.().TabIndex = 1;
			this.O_.O0o_O.().TabStop = true;
			this.O_.O0o_O.().Text = "用Tab符分隔列";
			this.O_.O0o_O.().UseVisualStyleBackColor = true;
			this.OoOO.000_o_O.().Filter = "Text文件(*.txt)|*.txt";
			this.O0O00._OOoO.().AutoSize = true;
			this.O0O00._OOoO.().Location = new Point(406, 358);
			this.O0O00._OOoO.().Name = "IgnorePrimaryKey";
			this.O0O00._OOoO.().Size = new Size(203, 16);
			this.O0O00._OOoO.().TabIndex = 7;
			this.O0O00._OOoO.().Text = "合并过程不比较主键(无条件合并)";
			this.O0O00._OOoO.().UseVisualStyleBackColor = true;
			this.Oo_0.oooo__.().AutoSize = true;
			this.Oo_0.oooo__.().Checked = true;
			this.Oo_0.oooo__.().Location = new Point(406, 336);
			this.Oo_0.oooo__.().Name = "SkipExistRow";
			this.Oo_0.oooo__.().Size = new Size(107, 16);
			this.Oo_0.oooo__.().TabIndex = 6;
			this.Oo_0.oooo__.().TabStop = true;
			this.Oo_0.oooo__.().Text = "跳过同主键记录";
			this.Oo_0.oooo__.().UseVisualStyleBackColor = true;
			this.Oo0O.__0Oo_.().AutoSize = true;
			this.Oo0O.__0Oo_.().Location = new Point(406, 314);
			this.Oo0O.__0Oo_.().Name = "UpdateExistRow";
			this.Oo0O.__0Oo_.().Size = new Size(107, 16);
			this.Oo0O.__0Oo_.().TabIndex = 5;
			this.Oo0O.__0Oo_.().Text = "更新同主键记录";
			this.Oo0O.__0Oo_.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(628, 430);
			base.Controls.Add(this.O0O00._OOoO.());
			base.Controls.Add(this.Oo_0.oooo__.());
			base.Controls.Add(this.Oo0O.__0Oo_.());
			base.Controls.Add(this.OoOO.000_o_O.());
			base.Controls.Add(this.O.__0OO0O0.());
			base.Controls.Add(this.OoOO.000_o_O.());
			base.Controls.Add(this.Oo0.o0.());
			base.Controls.Add(this.O_.00_.());
			base.Controls.Add(this.OoOO.000_o_O.());
			base.Controls.Add(this.O_.O0o_O.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oO..o..O";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "合并";
			((ISupportInitialize)this.OoOO.000_o_O.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x0015E4F8 File Offset: 0x0015C6F8
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0oOOoo_0OOo.0.;
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0015E500 File Offset: 0x0015C700
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o0oOOoo_0OOo.0. = A_0;
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x0015E509 File Offset: 0x0015C709
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0O._o_oOo.;
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x0015E514 File Offset: 0x0015C714
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OoOO.000_o_O.);
			C1Button c1Button = this.o0O._o_oOo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0O._o_oOo. = A_0;
			c1Button = this.o0O._o_oOo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x0015E557 File Offset: 0x0015C757
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.o0oOOoo_0OOo.0.;
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x0015E55F File Offset: 0x0015C75F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.o0oOOoo_0OOo.0. = A_0;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x0015E568 File Offset: 0x0015C768
		[CompilerGenerated]
		internal virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.o0oOOoo_0OOo.0.;
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0015E570 File Offset: 0x0015C770
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			EventHandler value = new EventHandler(this.O0oooO00Oo.00.);
			C1TextBox c1TextBox = this.o0oOOoo_0OOo.0.;
			if (c1TextBox != null)
			{
				c1TextBox.TextChanged -= value;
			}
			this.o0oOOoo_0OOo.0. = A_0;
			c1TextBox = this.o0oOOoo_0OOo.0.;
			if (c1TextBox != null)
			{
				c1TextBox.TextChanged += value;
			}
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x0015E5B3 File Offset: 0x0015C7B3
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o0oOOoo_0OOo.0.;
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0015E5BC File Offset: 0x0015C7BC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.O.0Ooo_.);
			RadioButton radioButton = this.o0oOOoo_0OOo.0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.o0oOOoo_0OOo.0. = A_0;
			radioButton = this.o0oOOoo_0OOo.0.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0015E5FF File Offset: 0x0015C7FF
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.o0O._o_oOo.;
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x0015E608 File Offset: 0x0015C808
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.O.0Ooo_.);
			RadioButton radioButton = this.o0O._o_oOo.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged -= value;
			}
			this.o0O._o_oOo. = A_0;
			radioButton = this.o0O._o_oOo.;
			if (radioButton != null)
			{
				radioButton.CheckedChanged += value;
			}
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0015E64B File Offset: 0x0015C84B
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.O_o._Oo0oo_0.;
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x0015E654 File Offset: 0x0015C854
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			EventHandler value = new EventHandler(this.O.0Ooo_.);
			RadioButton o_o._Oo0oo_0. = this.O_o._Oo0oo_0.;
			if (o_o._Oo0oo_0. != null)
			{
				o_o._Oo0oo_0..CheckedChanged -= value;
			}
			this.O_o._Oo0oo_0. = A_0;
			o_o._Oo0oo_0. = this.O_o._Oo0oo_0.;
			if (o_o._Oo0oo_0. != null)
			{
				o_o._Oo0oo_0..CheckedChanged += value;
			}
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x0015E697 File Offset: 0x0015C897
		[CompilerGenerated]
		internal virtual OpenFileDialog <<EMPTY_NAME>>()
		{
			return this.o0oOOoo_0OOo.0.;
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x0015E69F File Offset: 0x0015C89F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(OpenFileDialog A_0)
		{
			this.o0oOOoo_0OOo.0. = A_0;
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x0015E6A8 File Offset: 0x0015C8A8
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.oo.o_Oo_OO.;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x0015E6B0 File Offset: 0x0015C8B0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.oo.o_Oo_OO. = A_0;
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x0015E6B9 File Offset: 0x0015C8B9
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.oOO.00O.;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x0015E6C1 File Offset: 0x0015C8C1
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.oOO.00O. = A_0;
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x0015E6CA File Offset: 0x0015C8CA
		[CompilerGenerated]
		internal virtual RadioButton <<EMPTY_NAME>>()
		{
			return this.oOo_o_OO.O.;
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x0015E6D2 File Offset: 0x0015C8D2
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RadioButton A_0)
		{
			this.oOo_o_OO.O. = A_0;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x0015E6DB File Offset: 0x0015C8DB
		public O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002()
		{
			base.FormClosed += this.OoOO.000_o_O.;
			this.Oo0.o0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x0015E710 File Offset: 0x0015C910
		internal void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.OoO_.O., "", true) != 0)
			{
				this.OoOO.000_o_O.().AutoResize = true;
				this.OoOO.000_o_O.().Rows.Count = 1;
				this.OoOO.000_o_O.().Cols.Count = 1;
				this.OoOO.000_o_O.().Clear(ClearFlags.All);
				if (this.O_.O0o_O.().Checked)
				{
					this.OoOO.000_o_O.().LoadGrid(this.OoO_.O., FileFormatEnum.TextTab, FileFlags.IncludeFixedCells, Encoding.Default);
					this.OoOO.000_o_O.().Cols.Insert(0);
				}
				else if (this.OoOO.000_o_O.().Checked)
				{
					this.OoOO.000_o_O.().LoadGrid(this.OoO_.O., FileFormatEnum.TextComma, FileFlags.IncludeFixedCells, Encoding.Default);
					this.OoOO.000_o_O.().Cols.Insert(0);
				}
				else if (Operators.CompareString(this.Oo0.o0.().Text, "", true) > 0)
				{
					this.OoOO.000_o_O.().ClipSeparators = Conversions.ToString(this.Oo0.o0.().Text.ToCharArray()[0]) + "\r";
					this.OoOO.000_o_O.().LoadGrid(this.OoO_.O., FileFormatEnum.TextCustom, FileFlags.IncludeFixedCells, Encoding.Default);
					this.OoOO.000_o_O.().Cols.Insert(0);
				}
				for (int i = this.OoOO.000_o_O.().Cols.Count - 1; i >= 1; i += -1)
				{
					string text = "";
					if (this.OoOO.000_o_O.()[0, i] != null)
					{
						text = this.OoOO.000_o_O.()[0, i].ToString();
					}
					if (o_O_o_oOoo__.oO.O_..Contains(text))
					{
						this.OoOO.000_o_O.().Cols.Remove(i);
					}
					else
					{
						if (Operators.CompareString(text, "", true) == 0 || !o_O_o_oOoo__.O_o_._o0.(text, true))
						{
							int num = 1;
							while (this.OoOO.000_o_O.("第" + Conversions.ToString(num) + "列", i))
							{
								num++;
							}
							this.OoOO.000_o_O.()[0, i] = "第" + Conversions.ToString(num) + "列";
							text = "第" + Conversions.ToString(num) + "列";
						}
						this.OoOO.000_o_O.().Cols[i].Name = text;
					}
				}
				this.OoOO.000_o_O.().AutoSizeCols();
				this.OoOO.000_o_O.().Cols[0].Width = 23;
			}
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x0015E974 File Offset: 0x0015CB74
		private bool <<EMPTY_NAME>>(string A_0, int A_1)
		{
			int num = this.OoOO.000_o_O.().Cols.Count - 1;
			for (int i = 1; i <= num; i++)
			{
				if (i != A_1 && this.OoOO.000_o_O.()[0, i] != null && Operators.CompareString(this.OoOO.000_o_O.()[0, i].ToString(), A_0, true) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0015E9D5 File Offset: 0x0015CBD5
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Oo_0.oooo__.();
			this.Oo0.o0.().ReadOnly = !this.O_.00_.().Checked;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x0015E9F6 File Offset: 0x0015CBF6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.Oo0.o0.().Text.Length > 0)
			{
				this.Oo_0.oooo__.();
			}
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x0015EA14 File Offset: 0x0015CC14
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			try
			{
				TableMergeTypeEnum a_;
				if (this.Oo0O.__0Oo_.().Checked)
				{
					a_ = TableMergeTypeEnum.UpdateExistRow;
				}
				else if (this.O0O00._OOoO.().Checked)
				{
					a_ = TableMergeTypeEnum.IgnorePrimaryKey;
				}
				else
				{
					a_ = TableMergeTypeEnum.UpdateExistRow;
				}
				this.Cursor = Cursors.WaitCursor;
				if (Oo00.o00O0O_.O.(this.OoOO.000_o_O.(), Path.GetFileNameWithoutExtension(this.OoO_.O.), a_))
				{
					base.DialogResult = DialogResult.OK;
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x0015EAB4 File Offset: 0x0015CCB4
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001486 RID: 5254
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001487 RID: 5255
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001488 RID: 5256
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001489 RID: 5257
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x0400148A RID: 5258
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400148B RID: 5259
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400148C RID: 5260
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400148D RID: 5261
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x0400148E RID: 5262
		[CompilerGenerated]
		private OpenFileDialog <<EMPTY_NAME>>;

		// Token: 0x0400148F RID: 5263
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001490 RID: 5264
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001491 RID: 5265
		[CompilerGenerated]
		private RadioButton <<EMPTY_NAME>>;

		// Token: 0x04001492 RID: 5266
		internal string <<EMPTY_NAME>>;
	}
}
