using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Command;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000356 RID: 854
	[DesignerGenerated]
	internal partial class o\u3002\u3000\u3000\u30000 : Form
	{
		// Token: 0x06003524 RID: 13604 RVA: 0x0016F79C File Offset: 0x0016D99C
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oooOo_0oOo0o.0. != null)
				{
					this.oooOo_0oOo0o.0..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x0016F7DC File Offset: 0x0016D9DC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo_ooo.oOOO.(new C1Button());
			this.O0_oo0.oo.(new C1DockingTab());
			this.oo_ooo.oOOO.(new C1DockingTabPage());
			this.O0_o_.O.(new PropertyGrid());
			this.O0_o_.O.(new C1DockingTabPage());
			this.O0_o_.O.(new SplitContainer());
			this.Oo_.Oo__00.(new PropertyGrid());
			this.O0_o_.O.(new RichTextBox());
			this.O0_oo0.oo.(new C1Button());
			this.O_0__o0_oO0.o0.(new C1Button());
			((ISupportInitialize)this.o._oOO0Oo0oOoo.()).BeginInit();
			((ISupportInitialize)this.O_0__.O_OO0_O_.()).BeginInit();
			this.O_0__.O_OO0_O_.().SuspendLayout();
			this.o._oOO0Oo0oOoo.().SuspendLayout();
			this.O_0__.O_OO0_O_.().SuspendLayout();
			((ISupportInitialize)this.O_0__.O_OO0_O_.()).BeginInit();
			this.O_0__.O_OO0_O_.().Panel1.SuspendLayout();
			this.O_0__.O_OO0_O_.().Panel2.SuspendLayout();
			this.O_0__.O_OO0_O_.().SuspendLayout();
			((ISupportInitialize)this.O_0__.O_OO0_O_.()).BeginInit();
			((ISupportInitialize)this.Oo_0o0.O.()).BeginInit();
			base.SuspendLayout();
			this.o._oOO0Oo0oOoo.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.o._oOO0Oo0oOoo.().Location = new Point(388, 526);
			this.o._oOO0Oo0oOoo.().Name = "btnCancel";
			this.o._oOO0Oo0oOoo.().Size = new Size(75, 23);
			this.o._oOO0Oo0oOoo.().TabIndex = 2;
			this.o._oOO0Oo0oOoo.().Text = "取消";
			this.o._oOO0Oo0oOoo.().UseVisualStyleBackColor = true;
			this.O_0__.O_OO0_O_.().Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.O_0__.O_OO0_O_.().BorderStyle = BorderStyle.None;
			this.O_0__.O_OO0_O_.().Controls.Add(this.o._oOO0Oo0oOoo.());
			this.O_0__.O_OO0_O_.().Controls.Add(this.O_0__.O_OO0_O_.());
			this.O_0__.O_OO0_O_.().Location = new Point(12, 12);
			this.O_0__.O_OO0_O_.().Name = "C1DockingTab1";
			this.O_0__.O_OO0_O_.().Size = new Size(451, 497);
			this.O_0__.O_OO0_O_.().TabIndex = 0;
			this.O_0__.O_OO0_O_.().TabsSpacing = 0;
			this.O_0__.O_OO0_O_.().TabStyle = TabStyleEnum.WindowsXP;
			this.O_0__.O_OO0_O_.().VisualStyle = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.O_0__.O_OO0_O_.().VisualStyleBase = C1.Win.C1Command.VisualStyle.WindowsXP;
			this.o._oOO0Oo0oOoo.().Controls.Add(this.O_0__.O_OO0_O_.());
			this.o._oOO0Oo0oOoo.().Location = new Point(0, 25);
			this.o._oOO0Oo0oOoo.().Name = "C1DockingTabPage1";
			this.o._oOO0Oo0oOoo.().Size = new Size(451, 472);
			this.o._oOO0Oo0oOoo.().TabIndex = 0;
			this.o._oOO0Oo0oOoo.().Text = "属性";
			this.O_0__.O_OO0_O_.().Dock = DockStyle.Fill;
			this.O_0__.O_OO0_O_.().Location = new Point(0, 0);
			this.O_0__.O_OO0_O_.().Name = "PropertyGrid1";
			this.O_0__.O_OO0_O_.().Size = new Size(451, 472);
			this.O_0__.O_OO0_O_.().TabIndex = 0;
			this.O_0__.O_OO0_O_.().ToolbarVisible = false;
			this.O_0__.O_OO0_O_.().Controls.Add(this.O_0__.O_OO0_O_.());
			this.O_0__.O_OO0_O_.().Location = new Point(0, 25);
			this.O_0__.O_OO0_O_.().Name = "C1DockingTabPage2";
			this.O_0__.O_OO0_O_.().Size = new Size(451, 472);
			this.O_0__.O_OO0_O_.().TabIndex = 1;
			this.O_0__.O_OO0_O_.().Text = "事件";
			this.O_0__.O_OO0_O_.().Dock = DockStyle.Fill;
			this.O_0__.O_OO0_O_.().Location = new Point(0, 0);
			this.O_0__.O_OO0_O_.().Name = "SplitContainer1";
			this.O_0__.O_OO0_O_.().Orientation = Orientation.Horizontal;
			this.O_0__.O_OO0_O_.().Panel1.Controls.Add(this.o._oOO0Oo0oOoo.());
			this.O_0__.O_OO0_O_.().Panel2.Controls.Add(this.O_0__.O_OO0_O_.());
			this.O_0__.O_OO0_O_.().Size = new Size(451, 472);
			this.O_0__.O_OO0_O_.().SplitterDistance = 384;
			this.O_0__.O_OO0_O_.().TabIndex = 0;
			this.o._oOO0Oo0oOoo.().Dock = DockStyle.Fill;
			this.o._oOO0Oo0oOoo.().Location = new Point(0, 0);
			this.o._oOO0Oo0oOoo.().Name = "PropertyGrid2";
			this.o._oOO0Oo0oOoo.().Size = new Size(451, 384);
			this.o._oOO0Oo0oOoo.().TabIndex = 0;
			this.o._oOO0Oo0oOoo.().ToolbarVisible = false;
			this.O_0__.O_OO0_O_.().BorderStyle = BorderStyle.FixedSingle;
			this.O_0__.O_OO0_O_.().Dock = DockStyle.Fill;
			this.O_0__.O_OO0_O_.().Location = new Point(0, 0);
			this.O_0__.O_OO0_O_.().Name = "txtCode";
			this.O_0__.O_OO0_O_.().ReadOnly = true;
			this.O_0__.O_OO0_O_.().Size = new Size(451, 84);
			this.O_0__.O_OO0_O_.().TabIndex = 0;
			this.O_0__.O_OO0_O_.().Text = "";
			this.O_0__.O_OO0_O_.().WordWrap = false;
			this.O_0__.O_OO0_O_.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.O_0__.O_OO0_O_.().DialogResult = DialogResult.OK;
			this.O_0__.O_OO0_O_.().Location = new Point(297, 526);
			this.O_0__.O_OO0_O_.().Name = "btnOK";
			this.O_0__.O_OO0_O_.().Size = new Size(75, 23);
			this.O_0__.O_OO0_O_.().TabIndex = 1;
			this.O_0__.O_OO0_O_.().Text = "确定";
			this.O_0__.O_OO0_O_.().UseVisualStyleBackColor = true;
			this.Oo_0o0.O.().Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Oo_0o0.O.().Location = new Point(13, 526);
			this.Oo_0o0.O.().Name = "Button1";
			this.Oo_0o0.O.().Size = new Size(84, 23);
			this.Oo_0o0.O.().TabIndex = 3;
			this.Oo_0o0.O.().Text = "输出代码";
			this.Oo_0o0.O.().UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(475, 561);
			base.Controls.Add(this.Oo_0o0.O.());
			base.Controls.Add(this.O_0__.O_OO0_O_.());
			base.Controls.Add(this.O_0__.O_OO0_O_.());
			base.Controls.Add(this.o._oOO0Oo0oOoo.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.0._._.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "表属性";
			((ISupportInitialize)this.o._oOO0Oo0oOoo.()).EndInit();
			((ISupportInitialize)this.O_0__.O_OO0_O_.()).EndInit();
			this.O_0__.O_OO0_O_.().ResumeLayout(false);
			this.o._oOO0Oo0oOoo.().ResumeLayout(false);
			this.O_0__.O_OO0_O_.().ResumeLayout(false);
			this.O_0__.O_OO0_O_.().Panel1.ResumeLayout(false);
			this.O_0__.O_OO0_O_.().Panel2.ResumeLayout(false);
			((ISupportInitialize)this.O_0__.O_OO0_O_.()).EndInit();
			this.O_0__.O_OO0_O_.().ResumeLayout(false);
			((ISupportInitialize)this.O_0__.O_OO0_O_.()).EndInit();
			((ISupportInitialize)this.Oo_0o0.O.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0016FF09 File Offset: 0x0016E109
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_o_.O.;
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x0016FF14 File Offset: 0x0016E114
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.OOOo._O__.);
			C1Button o0_o_.O. = this.O0_o_.O.;
			if (o0_o_.O. != null)
			{
				o0_o_.O..Click -= value;
			}
			this.O0_o_.O. = A_0;
			o0_o_.O. = this.O0_o_.O.;
			if (o0_o_.O. != null)
			{
				o0_o_.O..Click += value;
			}
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x0016FF57 File Offset: 0x0016E157
		[CompilerGenerated]
		internal virtual C1DockingTab <<EMPTY_NAME>>()
		{
			return this.O0_o_.O.;
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x0016FF5F File Offset: 0x0016E15F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTab A_0)
		{
			this.O0_o_.O. = A_0;
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x0016FF68 File Offset: 0x0016E168
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.O0_o_.O.;
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x0016FF70 File Offset: 0x0016E170
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.O0_o_.O. = A_0;
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0016FF79 File Offset: 0x0016E179
		[CompilerGenerated]
		internal virtual C1DockingTabPage <<EMPTY_NAME>>()
		{
			return this.oOoo.oO.;
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0016FF81 File Offset: 0x0016E181
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1DockingTabPage A_0)
		{
			this.oOoo.oO. = A_0;
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x0016FF8A File Offset: 0x0016E18A
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.oooOo_0oOo0o.0.;
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0016FF94 File Offset: 0x0016E194
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.O0_oo0.oo.);
			PropertyGrid propertyGrid = this.oooOo_0oOo0o.0.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged -= value;
			}
			this.oooOo_0oOo0o.0. = A_0;
			propertyGrid = this.oooOo_0oOo0o.0.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged += value;
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x0016FFD7 File Offset: 0x0016E1D7
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.oooOo_0oOo0o.0.;
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x0016FFDF File Offset: 0x0016E1DF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.oooOo_0oOo0o.0. = A_0;
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0016FFE8 File Offset: 0x0016E1E8
		[CompilerGenerated]
		internal virtual PropertyGrid <<EMPTY_NAME>>()
		{
			return this.oOoo.oO.;
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x0016FFF0 File Offset: 0x0016E1F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(PropertyGrid A_0)
		{
			PropertyValueChangedEventHandler value = new PropertyValueChangedEventHandler(this.oo_ooo.oOOO.);
			SelectedGridItemChangedEventHandler value2 = new SelectedGridItemChangedEventHandler(this.O0_oo0.oo.);
			PropertyGrid propertyGrid = this.oOoo.oO.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged -= value;
				propertyGrid.SelectedGridItemChanged -= value2;
			}
			this.oOoo.oO. = A_0;
			propertyGrid = this.oOoo.oO.;
			if (propertyGrid != null)
			{
				propertyGrid.PropertyValueChanged += value;
				propertyGrid.SelectedGridItemChanged += value2;
			}
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0017004E File Offset: 0x0016E24E
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo_.Oo__00.;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00170058 File Offset: 0x0016E258
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oO_._.);
			C1Button oo_.Oo__00. = this.Oo_.Oo__00.;
			if (oo_.Oo__00. != null)
			{
				oo_.Oo__00..Click -= value;
			}
			this.Oo_.Oo__00. = A_0;
			oo_.Oo__00. = this.Oo_.Oo__00.;
			if (oo_.Oo__00. != null)
			{
				oo_.Oo__00..Click += value;
			}
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0017009B File Offset: 0x0016E29B
		[CompilerGenerated]
		internal virtual RichTextBox <<EMPTY_NAME>>()
		{
			return this.oooOo_0oOo0o.0.;
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x001700A3 File Offset: 0x0016E2A3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(RichTextBox A_0)
		{
			this.oooOo_0oOo0o.0. = A_0;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x001700AC File Offset: 0x0016E2AC
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0_Ooo_O.o.;
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x001700B4 File Offset: 0x0016E2B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0__.O_ooo00O.);
			C1Button c1Button = this.o0_Ooo_O.o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0_Ooo_O.o. = A_0;
			c1Button = this.o0_Ooo_O.o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x001700F8 File Offset: 0x0016E2F8
		internal o\u3002\u3000\u3000\u30000(DataTable A_0)
		{
			base.Activated += this.O_o._oO_O0oO.;
			base.FormClosed += this.O_0__.O_ooo00O.;
			base.FormClosing += this.O_0__.O_ooo00O.;
			this.oooOo_0oOo0o.0. = new List<string>();
			int num2;
			int num4;
			object obj;
			try
			{
				IL_47:
				int num = 1;
				this.O_0__o0_oO0.o0.();
				IL_4F:
				num = 2;
				Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
				IL_66:
				num = 3;
				Main.OO_O.o..Oo.oOo_o0Oo0.("Office2016Green", new object[]
				{
					this.O_0__.O_OO0_O_.()
				});
				IL_86:
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_8D:
				num = 5;
				this.oooOo_0oOo0o.0. = A_0;
				IL_96:
				num = 6;
				this.o_0._00O_0__O_. = A_0.frd_Setting;
				IL_A4:
				num = 7;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					A_0.BaseTable.TableName,
					""
				});
				IL_E1:
				num = 8;
				if (dataRow != null)
				{
					goto IL_1C6;
				}
				IL_E9:
				num = 9;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(string.Concat(new string[]
				{
					"Select * From [",
					ooO0__OO.O0O.0o0.(),
					"]  Where [Table] = '",
					A_0.BaseTable.TableName,
					"' And [Column] = ''"
				}), O_O0OO.OoO.0OO__0ooo.());
				IL_131:
				num = 10;
				DataTable dataTable = new DataTable();
				IL_13B:
				num = 11;
				oleDbDataAdapter.Fill(dataTable);
				IL_148:
				num = 12;
				if (dataTable.Rows.Count <= 0)
				{
					goto IL_183;
				}
				IL_15A:
				num = 13;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].ImportRow(dataTable.Rows[0]);
				IL_183:
				num = 14;
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					A_0.BaseTable.TableName,
					""
				});
				goto IL_24B;
				IL_1C6:
				num = 16;
				OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
				{
					"Select [Code] From [",
					ooO0__OO.O0O.0o0.(),
					"]  Where [Table] = '",
					A_0.BaseTable.TableName,
					"' And [Column] = ''"
				}), O_O0OO.OoO.0OO__0ooo.());
				IL_20E:
				num = 17;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_21B:
				num = 18;
				dataRow["Code"] = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				IL_235:
				num = 19;
				dataRow.AcceptChanges();
				IL_23E:
				num = 20;
				O_O0OO.OoO.0OO__0ooo.().Close();
				IL_24B:
				num = 21;
				if (dataRow == null)
				{
					goto IL_302;
				}
				IL_254:
				num = 22;
				PropertyInfo[] properties = this.o_0._00O_0__O_..GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
				IL_26B:
				num = 23;
				foreach (PropertyInfo propertyInfo in properties)
				{
					IL_27E:
					num = 24;
					if (propertyInfo.GetSetMethod() != null && !O00OOOo_O0_O.O.0o_0_o.(propertyInfo))
					{
						IL_293:
						num = 25;
						if (O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) && !this.oooOo_0oOo0o.0..Contains(propertyInfo.Name))
						{
							IL_2B3:
							num = 26;
							propertyInfo.SetValue(A_0.frd_Setting, null, null);
						}
					}
					IL_2C5:
					num = 27;
				}
				IL_2D6:
				num = 28;
				string a_ = DataTable.o.o00O.(Conversions.ToString(dataRow["Code"]));
				IL_2F0:
				num = 29;
				o_O_o_oOoo__.OOOO_OO._oo.(this.o_0._00O_0__O_., a_, '\v');
				IL_302:
				num = 30;
				this.o_0._00O_0__O_. = o_O_o_oOoo__.OOOO_OO._oo.(this.o_0._00O_0__O_., false, '\v', true);
				IL_31A:
				num = 31;
				this.O0_00O.0_. = o_O_o_oOoo__.OOOO_OO._oo.(this.o_0._00O_0__O_., true, '\v', true);
				IL_332:
				num = 32;
				this.O_0__.O_OO0_O_.().SelectedObject = new o_0oooo_OO(this.o_0._00O_0__O_., new string[0], true, false);
				IL_353:
				num = 33;
				this.o._oOO0Oo0oOoo.().SelectedObject = new o_0oooo_OO(this.o_0._00O_0__O_., new string[0], false, true);
				IL_374:
				num = 34;
				this.Text = this.Text + " - " + A_0.Name;
				IL_393:
				num = 35;
				this.o_0._00O_0__O_. = A_0.MultiRowHeader;
				IL_3A2:
				goto IL_484;
				IL_3A7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_445:
				goto IL_479;
				IL_447:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_457:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_447;
			}
			IL_479:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_484:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x001705B0 File Offset: 0x0016E7B0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oo_ooo.oOOO.();
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x001705B8 File Offset: 0x0016E7B8
		private void <<EMPTY_NAME>>()
		{
			int num;
			int num4;
			object obj3;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table = enumerator.Current;
					IL_20:
					num2 = 3;
					table.O__0.0.(table.View.Oo._Oo0OO.());
					IL_35:
					num2 = 4;
				}
				IL_40:
				num2 = 5;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_4D:
				num2 = 6;
				OleDbCommand oleDbCommand = new OleDbCommand(string.Concat(new string[]
				{
					"Select [Code] From [",
					ooO0__OO.O0O.0o0.(),
					"]  Where [Table] = '",
					this.oooOo_0oOo0o.0..BaseTable.TableName,
					"' And [Column] = ''"
				}), O_O0OO.OoO.0OO__0ooo.());
				IL_99:
				num2 = 7;
				O_O0OO.OoO.0OO__0ooo.().Open();
				IL_A5:
				num2 = 8;
				object obj = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
				IL_B4:
				num2 = 9;
				if (obj == null)
				{
					goto IL_179;
				}
				IL_BD:
				num2 = 10;
				DataTableProperty dataTableProperty = new DataTableProperty();
				IL_C7:
				num2 = 11;
				obj = DataTable.o.o00O.(obj.ToString());
				IL_D6:
				num2 = 12;
				o_O_o_oOoo__.OOOO_OO._oo.(dataTableProperty, obj.ToString(), '\v');
				IL_E8:
				num2 = 13;
				PropertyInfo[] properties = dataTableProperty.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
				IL_FB:
				num2 = 14;
				foreach (PropertyInfo propertyInfo in properties)
				{
					IL_10E:
					num2 = 15;
					if (propertyInfo.GetSetMethod() != null && !O00OOOo_O0_O.O.0o_0_o.(propertyInfo))
					{
						IL_123:
						num2 = 16;
						if (O00OOOo_O0_O.oO00o0._OoO00o.(propertyInfo) && !this.oooOo_0oOo0o.0..Contains(propertyInfo.Name))
						{
							IL_143:
							num2 = 17;
							propertyInfo.SetValue(this.oooOo_0oOo0o.0..frd_Setting, RuntimeHelpers.GetObjectValue(propertyInfo.GetValue(dataTableProperty, null)), null);
						}
					}
					IL_168:
					num2 = 18;
				}
				IL_179:
				num2 = 19;
				O_O0OO.OoO.0OO__0ooo.().Close();
				IL_186:
				num2 = 20;
				this.oooOo_0oOo0o.0..OO00_o.ooOO.(true);
				IL_195:
				num2 = 21;
				this.oooOo_0oOo0o.0..o0.0_0OO0o_0o.(true);
				IL_1A4:
				num2 = 22;
				IEnumerator<DataTable> enumerator2 = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataTable dataTable = enumerator2.Current;
					IL_1BE:
					num2 = 23;
					dataTable.o0.0o_0.();
					IL_1C9:
					num2 = 24;
				}
				IL_1D5:
				num2 = 25;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
				IL_1E3:
				num2 = 26;
				IEnumerator<Table> enumerator3 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					Table table2 = enumerator3.Current;
					IL_1FD:
					num2 = 27;
					if (table2.View.o_o.O0ooOo.().TableName == this.oooOo_0oOo0o.0..Name)
					{
						IL_21E:
						num2 = 28;
						table2.foxGrid.Invalidate();
					}
					IL_22D:
					num2 = 29;
				}
				IL_239:
				num2 = 30;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
				IL_247:
				num2 = 31;
				IEnumerator<Table> enumerator4 = OO_00oOO.Tables.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					Table table3 = enumerator4.Current;
					IL_264:
					num2 = 32;
					if (table3.DataTable == this.oooOo_0oOo0o.0.)
					{
						IL_276:
						num2 = 33;
						table3.AllowBackEndFilter = this.oooOo_0oOo0o.0..AllowBackEndFilter;
						IL_28B:
						num2 = 34;
						if (this.o_0._00O_0__O_. != this.o_0._00O_0__O_..MultiRowHeader)
						{
							IL_2A1:
							num2 = 35;
							table3.BuildHeader();
						}
						IL_2AB:
						num2 = 36;
						TableEventArgs tableEventArgs = new TableEventArgs(table3);
						IL_2B7:
						num2 = 37;
						O_O0OO.OoO_o.oO0o0O.(this.oooOo_0oOo0o.0..o_0_00_.oo0O0., "AfterLoadTableSetting", new object[]
						{
							tableEventArgs
						}, true, table3.DataTable.Name, false);
					}
					IL_2E9:
					num2 = 38;
				}
				IL_2F8:
				num2 = 39;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
				IL_306:
				num2 = 40;
				if (!O_O0OO.O0_00o.o0__o..ShowTableIcon)
				{
					goto IL_378;
				}
				IL_315:
				num2 = 41;
				IEnumerator enumerator5 = Main.OO_O.o..OO_O_0Oo.___o.().TabPages.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					object obj2 = enumerator5.Current;
					Oo0__Oo oo0__Oo = (Oo0__Oo)obj2;
					IL_33E:
					num2 = 42;
					oo0__Oo.Image = oo0__Oo.O_000__.o.()._frdIcon;
					IL_354:
					num2 = 43;
				}
				IL_360:
				num2 = 44;
				if (enumerator5 is IDisposable)
				{
					(enumerator5 as IDisposable).Dispose();
				}
				IL_378:
				num2 = 45;
				this.oOoo.oO. = false;
				IL_382:
				num2 = 46;
				this.o0_0O._o. = false;
				IL_38C:
				goto IL_49A;
				IL_391:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_45B:
				goto IL_48F;
				IL_45D:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_46D:;
			}
			catch when (endfilter(obj3 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj4;
				goto IL_45D;
			}
			IL_48F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_49A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00170A84 File Offset: 0x0016EC84
		private void <<EMPTY_NAME>>()
		{
			o_O_o_oOoo__.OOOO_OO._oo.(this.o_0._00O_0__O_., this.o_0._00O_0__O_., '\v');
			o_O_o_oOoo__.OOOO_OO._oo.(this.o_0._00O_0__O_., this.O0_00O.0_., '\v');
			this.oOoo.oO. = false;
			this.o0_0O._o. = false;
			this.oooOo_0oOo0o.0..o0.0_0OO0o_0o.(false);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00170AD4 File Offset: 0x0016ECD4
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			this.O0_oo0.oo.(RuntimeHelpers.GetObjectValue(A_0), new SelectedGridItemChangedEventArgs(null, this.o._oOO0Oo0oOoo.().SelectedGridItem));
			this.o0_0O._o. = true;
			if (!this.oooOo_0oOo0o.0..Contains(A_1.ChangedItem.PropertyDescriptor.Name))
			{
				this.oooOo_0oOo0o.0..Add(A_1.ChangedItem.PropertyDescriptor.Name);
			}
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x00170B40 File Offset: 0x0016ED40
		private void <<EMPTY_NAME>>(object A_0, SelectedGridItemChangedEventArgs A_1)
		{
			if (A_1.NewSelection == null || A_1.NewSelection.Value == null)
			{
				this.O_0__.O_OO0_O_.().Text = "";
				return;
			}
			EventString eventString = (EventString)A_1.NewSelection.Value;
			if (eventString.Count > 0)
			{
				this.O_0__.O_OO0_O_.().Text = eventString[0];
				return;
			}
			this.O_0__.O_OO0_O_.().Text = "";
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x00170BB0 File Offset: 0x0016EDB0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.Refresh();
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00170BB8 File Offset: 0x0016EDB8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.o0_0O._o. || MessageBox.Show("确定要取消修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				this.O_0__.O_ooo00O.();
				base.DialogResult = DialogResult.Cancel;
			}
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x00170BE4 File Offset: 0x0016EDE4
		private void <<EMPTY_NAME>>(object A_0, PropertyValueChangedEventArgs A_1)
		{
			if (Operators.CompareString(A_1.ChangedItem.PropertyDescriptor.Name, "Developer", true) == 0 && OO_00oOO.User.Type != UserTypeEnum.Developer)
			{
				if (A_1.OldValue == null)
				{
					((DataTableProperty)((o_0oooo_OO)this.O_0__.O_OO0_O_.().SelectedObject).Oo._o.()).Developer = "";
				}
				else
				{
					((DataTableProperty)((o_0oooo_OO)this.O_0__.O_OO0_O_.().SelectedObject).Oo._o.()).Developer = A_1.OldValue.ToString();
				}
				MessageBox.Show("非开发者不能更改设计者属性!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.oOoo.oO. = true;
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x00170C90 File Offset: 0x0016EE90
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				"AssemblyVertion",
				o0_O.O_.O_O__.
			});
			if (dataRow == null)
			{
				DataTable dataTable = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()];
				dataRow = dataTable.NewRow();
				dataRow["Name"] = "AssemblyVertion";
				dataRow["Type"] = o0_O.O_.O_O__.;
				dataRow["Config"] = 0;
				dataTable.Rows.Add(dataRow);
			}
			int num;
			int.TryParse(dataRow["Config"].ToString(), out num);
			num++;
			dataRow["Config"] = num;
			Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], true);
			if (num >= 40 && num % 5 == 0)
			{
				SQLCommand sqlcommand = new SQLCommand();
				if (!ShareLibriay.PropertyIsReady())
				{
					sqlcommand.CommandText = string.Concat(new string[]
					{
						"Insert Into [",
						ooO0__OO.O0_.OOo0OO.(),
						"] ([Name],[Type],[DataSource]) Values('',",
						Conversions.ToString(0),
						",'",
						this.oooOo_0oOo0o.0..Name,
						"')"
					});
					try
					{
						sqlcommand.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
					}
				}
			}
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00170E18 File Offset: 0x0016F018
		private void <<EMPTY_NAME>>(object A_0, FormClosingEventArgs A_1)
		{
			if (this.oOoo.oO. | this.o0_0O._o.)
			{
				DialogResult dialogResult = MessageBox.Show("保存修改吗?", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (dialogResult == DialogResult.Cancel)
				{
					A_1.Cancel = true;
					return;
				}
				if (dialogResult == DialogResult.Yes)
				{
					this.oo_ooo.oOOO.();
					return;
				}
				this.O_0__.O_ooo00O.();
			}
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00170E64 File Offset: 0x0016F064
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OO_00oOO.oo0oOO.o.(OO_00oOO.OoOO.oOo_o.oO0oo0o., this.oooOo_0oOo0o.0..Name);
		}

		// Token: 0x04001562 RID: 5474
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04001563 RID: 5475
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001564 RID: 5476
		[CompilerGenerated]
		private C1DockingTab <<EMPTY_NAME>>;

		// Token: 0x04001565 RID: 5477
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001566 RID: 5478
		[CompilerGenerated]
		private C1DockingTabPage <<EMPTY_NAME>>;

		// Token: 0x04001567 RID: 5479
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x04001568 RID: 5480
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04001569 RID: 5481
		[CompilerGenerated]
		private PropertyGrid <<EMPTY_NAME>>;

		// Token: 0x0400156A RID: 5482
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400156B RID: 5483
		[CompilerGenerated]
		private RichTextBox <<EMPTY_NAME>>;

		// Token: 0x0400156C RID: 5484
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400156D RID: 5485
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x0400156E RID: 5486
		private DataTableProperty <<EMPTY_NAME>>;

		// Token: 0x0400156F RID: 5487
		private string <<EMPTY_NAME>>;

		// Token: 0x04001570 RID: 5488
		private string <<EMPTY_NAME>>;

		// Token: 0x04001571 RID: 5489
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001572 RID: 5490
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001573 RID: 5491
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001574 RID: 5492
		private List<string> <<EMPTY_NAME>>;
	}
}
