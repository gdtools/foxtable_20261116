using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200037C RID: 892
	[DesignerGenerated]
	internal partial class O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000 : Form
	{
		// Token: 0x06003950 RID: 14672 RVA: 0x00199E04 File Offset: 0x00198004
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_0Oo.0o00_O. != null)
				{
					this.o_0Oo.0o00_O..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x00199E44 File Offset: 0x00198044
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OO__00OOoo0.0_.(new ListBox());
			this.o00_0.o00o.(new PropertyGrid());
			this.OO__00OOoo0.0_.(new C1Button());
			this.OO_ooO_OO.O_oO.(new C1Button());
			this.o00_0.o00o.(new RichTextBox());
			this.oOoOO_000O.0__.(new C1Button());
			this.o_0O.0__ooo0O_.(new C1Button());
			this.o00._0OO.(new C1Button());
			base.SuspendLayout();
			this.o00.Oo.().FormattingEnabled = true;
			this.o00.Oo.().ItemHeight = 12;
			this.o00.Oo.().Location = new Point(12, 12);
			this.o00.Oo.().Name = "ListBox1";
			this.o00.Oo.().Size = new Size(201, 364);
			this.o00.Oo.().TabIndex = 0;
			this.o00.Oo.().Location = new Point(230, 12);
			this.o00.Oo.().Name = "PropertyGrid1";
			this.o00.Oo.().Size = new Size(384, 202);
			this.o00.Oo.().TabIndex = 1;
			this.o00.Oo.().ToolbarVisible = false;
			this.o00.Oo.().Location = new Point(455, 390);
			this.o00.Oo.().Name = "btnOK";
			this.o00.Oo.().Size = new Size(75, 23);
			this.o00.Oo.().TabIndex = 2;
			this.o00.Oo.().Text = "确定";
			this.o00.Oo.().UseVisualStyleBackColor = true;
			this.o._o_.().Location = new Point(536, 390);
			this.o._o_.().Name = "btnCancel";
			this.o._o_.().Size = new Size(75, 23);
			this.o._o_.().TabIndex = 3;
			this.o._o_.().Text = "取消";
			this.o._o_.().UseVisualStyleBackColor = true;
			this.OO__00OOoo0.0_.().Location = new Point(230, 220);
			this.OO__00OOoo0.0_.().Name = "RichTextBox1";
			this.OO__00OOoo0.0_.().ReadOnly = true;
			this.OO__00OOoo0.0_.().Size = new Size(384, 156);
			this.OO__00OOoo0.0_.().TabIndex = 4;
			this.OO__00OOoo0.0_.().Text = "";
			this.Oo0.0.().Location = new Point(12, 390);
			this.Oo0.0.().Name = "btnAdd";
			this.Oo0.0.().Size = new Size(75, 23);
			this.Oo0.0.().TabIndex = 5;
			this.Oo0.0.().Text = "增加";
			this.Oo0.0.().UseVisualStyleBackColor = true;
			this.oOO0.OO.().Location = new Point(93, 390);
			this.oOO0.OO.().Name = "btnDel";
			this.oOO0.OO.().Size = new Size(75, 23);
			this.oOO0.OO.().TabIndex = 6;
			this.oOO0.OO.().Text = "删除";
			this.oOO0.OO.().UseVisualStyleBackColor = true;
			this.O0o.0OOO_.().Location = new Point(174, 390);
			this.O0o.0OOO_.().Name = "Button1";
			this.O0o.0OOO_.().Size = new Size(75, 23);
			this.O0o.0OOO_.().TabIndex = 7;
			this.O0o.0OOO_.().Text = "输出代码";
			this.O0o.0OOO_.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(626, 421);
			base.Controls.Add(this.O0o.0OOO_.());
			base.Controls.Add(this.oOO0.OO.());
			base.Controls.Add(this.Oo0.0.());
			base.Controls.Add(this.OO__00OOoo0.0_.());
			base.Controls.Add(this.o._o_.());
			base.Controls.Add(this.o00.Oo.());
			base.Controls.Add(this.o00.Oo.());
			base.Controls.Add(this.o00.Oo.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.o.....";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "计划管理";
			base.ResumeLayout(false);
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0019A2CF File Offset: 0x001984CF
		[CompilerGenerated]
		internal virtual ListBox <<EMPTY_NAME>>()
		{
			return this.o00_0.o00o.;
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x0019A2D7 File Offset: 0x001984D7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ListBox A_0)
		{
			this.o00_0.o00o. = A_0;
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0019A2E0 File Offset: 0x001984E0
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.o00_0.o00o.;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x0019A2E8 File Offset: 0x001984E8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.OO__00OOoo0.0_.);
			PropertyGrid propertyGrid = this.o00_0.o00o.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged -= value;
			}
			this.o00_0.o00o. = A_0;
			propertyGrid = this.o00_0.o00o.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged += value;
			}
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x0019A32B File Offset: 0x0019852B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o00_0.o00o.;
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x0019A334 File Offset: 0x00198534
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O__o_Oo.OOoo00.);
			C1Button c1Button = this.o00_0.o00o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o00_0.o00o. = A_0;
			c1Button = this.o00_0.o00o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0019A377 File Offset: 0x00198577
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_.o.;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x0019A380 File Offset: 0x00198580
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oo0_o0__O.0.);
			C1Button ooo_.o. = this.Ooo_.o.;
			if (ooo_.o. != null)
			{
				ooo_.o..Click -= value;
			}
			this.Ooo_.o. = A_0;
			ooo_.o. = this.Ooo_.o.;
			if (ooo_.o. != null)
			{
				ooo_.o..Click += value;
			}
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x0019A3C3 File Offset: 0x001985C3
		[CompilerGenerated]
		internal virtual RichTextBox <<EMPTY_NAME>>()
		{
			return this.o_0Oo.0o00_O.;
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x0019A3CB File Offset: 0x001985CB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RichTextBox A_0)
		{
			this.o_0Oo.0o00_O. = A_0;
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x0019A3D4 File Offset: 0x001985D4
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_O_OoOoO_o.O0.;
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x0019A3DC File Offset: 0x001985DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.Oo.OoO_O_Oo_o_.);
			C1Button o_O_OoOoO_o.O0. = this.O_O_OoOoO_o.O0.;
			if (o_O_OoOoO_o.O0. != null)
			{
				o_O_OoOoO_o.O0..Click -= value;
			}
			this.O_O_OoOoO_o.O0. = A_0;
			o_O_OoOoO_o.O0. = this.O_O_OoOoO_o.O0.;
			if (o_O_OoOoO_o.O0. != null)
			{
				o_O_OoOoO_o.O0..Click += value;
			}
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x0019A41F File Offset: 0x0019861F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O___000O_.O.;
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x0019A428 File Offset: 0x00198628
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o0.OOO.);
			C1Button o___000O_.O. = this.O___000O_.O.;
			if (o___000O_.O. != null)
			{
				o___000O_.O..Click -= value;
			}
			this.O___000O_.O. = A_0;
			o___000O_.O. = this.O___000O_.O.;
			if (o___000O_.O. != null)
			{
				o___000O_.O..Click += value;
			}
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x0019A46B File Offset: 0x0019866B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_O0_Oo_.0.;
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x0019A474 File Offset: 0x00198674
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_o.ooO0oo.);
			C1Button c1Button = this.o_O0_Oo_.0.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_O0_Oo_.0. = A_0;
			c1Button = this.o_O0_Oo_.0.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x0019A4B7 File Offset: 0x001986B7
		[CompilerGenerated]
		private virtual CurrencyManager <<EMPTY_NAME>>()
		{
			return this.o00_0.o00o.;
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x0019A4C0 File Offset: 0x001986C0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(CurrencyManager A_0)
		{
			EventHandler value = new EventHandler(this.oo__0O0.O.);
			CurrencyManager currencyManager = this.o00_0.o00o.;
			if (currencyManager != null)
			{
				currencyManager.CurrentChanged -= value;
			}
			this.o00_0.o00o. = A_0;
			currencyManager = this.o00_0.o00o.;
			if (currencyManager != null)
			{
				currencyManager.CurrentChanged += value;
			}
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x0019A504 File Offset: 0x00198704
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o_0Oo.0o00_O. = new DataView(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], "[Type] = " + Conversions.ToString(3), "", DataViewRowState.CurrentRows);
			this.o00.Oo.().DisplayMember = "Name";
			this.o00.Oo.().DataSource = this.o_0Oo.0o00_O.;
			this.OO__00OOoo0.0_.((CurrencyManager)this.BindingContext[this.o_0Oo.0o00_O.]);
			this.oo__0O0.O.(this.o00.Oo.(), null);
			this.o_0Oo.0o00_O. = false;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x0019A598 File Offset: 0x00198798
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataRow dataRow = this.o_0Oo.0o00_O..Table.NewRow();
			string value = o_O_o_oOoo__.OO_O0oO0.oooO_.(this.o_0Oo.0o00_O..Table, this.o_0Oo.0o00_O..Table.Columns["Name"], "计划");
			dataRow["Name"] = value;
			dataRow["Type"] = o0_O.OoOoOO00._00o0.;
			dataRow["Config"] = "";
			this.o_0Oo.0o00_O..Table.Rows.Add(dataRow);
			this.o00.Oo.().Position = this.o00.Oo.().Count - 1;
			this.o_0Oo.0o00_O. = true;
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0019A648 File Offset: 0x00198848
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o00.Oo.().Position > -1)
			{
				((DataRowView)this.o00.Oo.().Current).Delete();
				this.o_0Oo.0o00_O. = true;
			}
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x0019A674 File Offset: 0x00198874
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
				this.o00.Oo.().SelectedObject = null;
				IL_15:
				num2 = 3;
				if (this.o00.Oo.().Position <= -1)
				{
					goto IL_F6;
				}
				IL_28:
				num2 = 4;
				DataRow row = ((DataRowView)this.o00.Oo.().Current).Row;
				IL_40:
				num2 = 5;
				TimerProperty timerProperty = new TimerProperty();
				IL_49:
				num2 = 6;
				if (row.IsNull("Config"))
				{
					goto IL_82;
				}
				IL_58:
				num2 = 7;
				o_O_o_oOoo__.OOOO_OO._oo.(timerProperty, O00.oO_.0o_oo_0O_.(Conversions.ToString(row["Config"]), "Timer", O_O0OO.O_O._Oo.()), '\v');
				IL_82:
				num2 = 8;
				timerProperty.Name = row["Name"].ToString();
				IL_9B:
				num2 = 9;
				this.o00.Oo.().SelectedObject = timerProperty;
				IL_AB:
				num2 = 10;
				if (timerProperty.Tick == null || timerProperty.Tick.Count <= 0)
				{
					goto IL_E3;
				}
				IL_C6:
				num2 = 11;
				this.OO__00OOoo0.0_.().Text = timerProperty.Tick[0];
				goto IL_F6;
				IL_E3:
				num2 = 13;
				this.OO__00OOoo0.0_.().Text = "";
				IL_F6:
				goto IL_180;
				IL_FB:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_141:
				goto IL_175;
				IL_143:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_153:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_143;
			}
			IL_175:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_180:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x0019A828 File Offset: 0x00198A28
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
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
				DataRow row = ((DataRowView)this.o00.Oo.().Current).Row;
				IL_1F:
				num2 = 3;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "Name", true) != 0)
				{
					goto IL_19C;
				}
				IL_41:
				num2 = 4;
				if (Operators.CompareString(A_1.OldValue.ToString(), A_1.ChangedItem.Value.ToString(), true) == 0)
				{
					goto IL_17C;
				}
				IL_69:
				num2 = 5;
				DataColumn[] a_ = new DataColumn[]
				{
					this.o_0Oo.0o00_O..Table.Columns["Name"],
					this.o_0Oo.0o00_O..Table.Columns["Type"]
				};
				IL_AD:
				num2 = 6;
				string[] a_2 = new string[]
				{
					A_1.ChangedItem.Value.ToString(),
					row["Type"].ToString()
				};
				IL_DD:
				num2 = 7;
				if (!o_O_o_oOoo__.oo.O0o0o.(this.o_0Oo.0o00_O..Table, a_, a_2))
				{
					goto IL_132;
				}
				IL_F5:
				num2 = 8;
				MessageBox.Show("相同名称的计划已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				IL_10A:
				num2 = 9;
				((TimerProperty)this.o00.Oo.().SelectedObject).Name = A_1.OldValue.ToString();
				goto IL_289;
				IL_132:
				num2 = 11;
				if (o_O_o_oOoo__.O_o_._o0.(A_1.ChangedItem.Value.ToString(), "计划名称", 32, false))
				{
					goto IL_17C;
				}
				IL_154:
				num2 = 12;
				((TimerProperty)this.o00.Oo.().SelectedObject).Name = A_1.OldValue.ToString();
				goto IL_289;
				IL_17C:
				num2 = 14;
				row["Name"] = RuntimeHelpers.GetObjectValue(A_1.ChangedItem.Value);
				goto IL_1FC;
				IL_19C:
				num2 = 16;
				string a_3 = o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(this.o00.Oo.().SelectedObject), false, '\v', false) + "\v" + o_O_o_oOoo__.OOOO_OO._oo.(RuntimeHelpers.GetObjectValue(this.o00.Oo.().SelectedObject), true, '\v', false);
				IL_1DD:
				num2 = 17;
				row["Config"] = O00.ooo000o_0.00o0.(a_3, "Timer", O_O0OO.O_O._Oo.());
				IL_1FC:
				num2 = 18;
				if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "Tick", true) != 0)
				{
					goto IL_27F;
				}
				IL_21C:
				num2 = 19;
				TimerProperty timerProperty = (TimerProperty)this.o00.Oo.().SelectedObject;
				IL_231:
				num2 = 20;
				if (timerProperty.Tick == null || timerProperty.Tick.Count <= 0)
				{
					goto IL_269;
				}
				IL_24C:
				num2 = 21;
				this.OO__00OOoo0.0_.().Text = timerProperty.Tick[0];
				goto IL_27C;
				IL_269:
				num2 = 23;
				this.OO__00OOoo0.0_.().Text = "";
				IL_27C:
				timerProperty = null;
				IL_27F:
				num2 = 25;
				this.o_0Oo.0o00_O. = true;
				IL_289:
				goto IL_343;
				IL_28E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_304:
				goto IL_338;
				IL_306:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_316:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_306;
			}
			IL_338:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_343:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x0019AB9C File Offset: 0x00198D9C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string text = OO_00oOO.ProjectPath + "Bin\\" + o0OoOOoOOo0.oo00o.0OoO.("") + ".Project.dll";
			if (this.o_0Oo.0o00_O.)
			{
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
				O_O0OO.oo0_o_.o. = o0_.Oo_0.OOo0oO0.(O_O0OO.O0_00o.o0__o., O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], O_O0OO.O_O._Oo.(), text, O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()]);
				O_O0OO.O0_00o.o0__o..O_o0__O.o.();
				OO_00oOO.FileSys.FileExists(text);
				O_O0OO.O0_00o.o0__o..O_O_.o.(true, true);
			}
			else
			{
				if (OO_00oOO.FileSys.FileExists(text))
				{
					O_O0OO.oo0_o_.o. = Assembly.Load(File.ReadAllBytes(text));
					O_O0OO.O0_00o.o0__o..O_o0__O.o.();
				}
				OO_00oOO.MyTimers.Clear();
				foreach (DataRow dataRow in O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Select("[Type] = " + Conversions.ToString(3)))
				{
					TimerProperty timerProperty = new TimerProperty();
					Timer timer = new Timer();
					if (!dataRow.IsNull("Config"))
					{
						o_O_o_oOoo__.OOOO_OO._oo.(timerProperty, O00.oO_.0o_oo_0O_.(Conversions.ToString(dataRow["Config"]), "Timer", O_O0OO.O_O._Oo.()), '\v');
					}
					timer.Name = Conversions.ToString(dataRow["Name"]);
					string a_ = "Timer_" + timer.Name;
					timer.Tag = a_;
					timer.Interval = timerProperty.Interval;
					timer.Enabled = timerProperty.Enabled;
					timer.CanPause = timerProperty.CanPause;
					OO_00oOO.MyTimers.Add(Conversions.ToString(dataRow["Name"]), timer);
				}
			}
			base.Close();
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x0019AD83 File Offset: 0x00198F83
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.o_0Oo.0o00_O. || MessageBox.Show("确定要取消修改吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				this.o_0Oo.0o00_O..Table.RejectChanges();
				base.Close();
			}
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x0019ADB8 File Offset: 0x00198FB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.oo0oOO.o.(OO_00oOO.OoOO.O_0Ooo0o._., "");
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0019ADC8 File Offset: 0x00198FC8
		public O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000()
		{
			base.Load += this.oo._0O_.;
			base.FormClosed += this.o00.Oo.;
			this.OO__00OOoo0.0_.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				"ProjectCode",
				o0_O.O_o000_O.0.
			});
			if (dataRow != null)
			{
				string text = Conversions.ToString(dataRow["Config"]);
				text = O_O0OO.OoO_00._.(text, null);
				o_O_o_oOoo__.OOOO_OO._oo.(O_O0OO.O0_00o.o0__o., text, '\v');
			}
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x0019AE79 File Offset: 0x00199079
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001779 RID: 6009
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400177A RID: 6010
		[CompilerGenerated]
		private ListBox <<EMPTY_NAME>>;

		// Token: 0x0400177B RID: 6011
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x0400177C RID: 6012
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400177D RID: 6013
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400177E RID: 6014
		[CompilerGenerated]
		private RichTextBox <<EMPTY_NAME>>;

		// Token: 0x0400177F RID: 6015
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001780 RID: 6016
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001781 RID: 6017
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001782 RID: 6018
		private DataView <<EMPTY_NAME>>;

		// Token: 0x04001783 RID: 6019
		[CompilerGenerated]
		private CurrencyManager <<EMPTY_NAME>>;

		// Token: 0x04001784 RID: 6020
		internal bool <<EMPTY_NAME>>;
	}
}
