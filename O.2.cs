using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000388 RID: 904
	[DesignerGenerated]
	internal partial class O\u3000\u3000 : Form
	{
		// Token: 0x06003A96 RID: 14998 RVA: 0x001A4FDE File Offset: 0x001A31DE
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.OO0oo0.O_OoOo_. != null)
			{
				this.OO0oo0.O_OoOo_..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x001A5000 File Offset: 0x001A3200
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O00_000OO.oo_o.(new Label());
			this.ooOo0_o0._O.(new Label());
			this.O00_000OO.oo_o.(new C1ComboBox());
			this.ooOo0_o0._O.(new C1ComboBox());
			this.ooOo0_o0._O.(new C1FlexGrid());
			this.ooOo0_o0._O.(new C1CheckBox());
			this.oo_Oo.0.(new C1Button());
			this.ooOo0_o0._O.(new C1Button());
			this.oo_Oo.0.(new C1CheckBox());
			this.o0._o.(new Label());
			this.oo_Oo.0.(new C1ComboBox());
			((ISupportInitialize)this.o.0O_0.()).BeginInit();
			((ISupportInitialize)this.o_OO_._.()).BeginInit();
			((ISupportInitialize)this.o.0O_0.()).BeginInit();
			((ISupportInitialize)this.o.0O_0.()).BeginInit();
			((ISupportInitialize)this.ooOOo._.()).BeginInit();
			((ISupportInitialize)this.O0.OOo.()).BeginInit();
			((ISupportInitialize)this.O0.OOo.()).BeginInit();
			((ISupportInitialize)this.Oo_O_.O_.()).BeginInit();
			base.SuspendLayout();
			this.o.0O_0.().AutoSize = true;
			this.o.0O_0.().Location = new Point(10, 13);
			this.o.0O_0.().Name = "Label1";
			this.o.0O_0.().Size = new Size(77, 12);
			this.o.0O_0.().TabIndex = 0;
			this.o.0O_0.().Text = "父表/关联列:";
			this.o_OO_._.().AutoSize = true;
			this.o_OO_._.().Location = new Point(273, 13);
			this.o_OO_._.().Name = "Label2";
			this.o_OO_._.().Size = new Size(77, 12);
			this.o_OO_._.().TabIndex = 1;
			this.o_OO_._.().Tag = "子表";
			this.o_OO_._.().Text = "子表/关联列:";
			this.o.0O_0.().AllowSpinLoop = false;
			this.o.0O_0.().Cursor = Cursors.Arrow;
			this.o.0O_0.().DropDownStyle = DropDownStyle.DropDownList;
			this.o.0O_0.().GapHeight = 0;
			this.o.0O_0.().ImagePadding = new Padding(0);
			this.o.0O_0.().ItemsDisplayMember = "";
			this.o.0O_0.().ItemsValueMember = "";
			this.o.0O_0.().Location = new Point(12, 28);
			this.o.0O_0.().Name = "cmbParentTable";
			this.o.0O_0.().Size = new Size(263, 19);
			this.o.0O_0.().TabIndex = 0;
			this.o.0O_0.().Tag = null;
			this.o_OO_._.().AllowSpinLoop = false;
			this.o_OO_._.().Cursor = Cursors.Arrow;
			this.o_OO_._.().DropDownStyle = DropDownStyle.DropDownList;
			this.o_OO_._.().GapHeight = 0;
			this.o_OO_._.().ImagePadding = new Padding(0);
			this.o_OO_._.().ItemsDisplayMember = "";
			this.o_OO_._.().ItemsValueMember = "";
			this.o_OO_._.().Location = new Point(275, 28);
			this.o_OO_._.().Name = "cmbChildTable";
			this.o_OO_._.().Size = new Size(263, 19);
			this.o_OO_._.().TabIndex = 1;
			this.o_OO_._.().Tag = null;
			this.o.0O_0.().AutoClipboard = true;
			this.o.0O_0.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this.o.0O_0.().ColumnInfo = "2,0,0,20,0,0,Columns:0{Width:261;}\t";
			this.o.0O_0.().ExtendLastCol = true;
			this.o.0O_0.().HighLight = HighLightEnum.WithFocus;
			this.o.0O_0.().Location = new Point(12, 55);
			this.o.0O_0.().Name = "grdCols";
			this.o.0O_0.().Rows.Count = 7;
			this.o.0O_0.().Rows.DefaultSize = 21;
			this.o.0O_0.().Rows.Fixed = 0;
			this.o.0O_0.().Size = new Size(526, 153);
			this.o.0O_0.().TabIndex = 2;
			this.o.0O_0.().AutoSize = true;
			this.o.0O_0.().BorderStyle = BorderStyle.None;
			this.o.0O_0.().Location = new Point(12, 221);
			this.o.0O_0.().Name = "CascateUpdate";
			this.o.0O_0.().Size = new Size(132, 16);
			this.o.0O_0.().TabIndex = 6;
			this.o.0O_0.().Text = "同步更新关联列内容";
			this.o.0O_0.().UseVisualStyleBackColor = true;
			this.o.0O_0.().Value = null;
			this.ooOOo._.().Location = new Point(197, 275);
			this.ooOOo._.().Name = "btnAccept";
			this.ooOOo._.().Size = new Size(75, 23);
			this.ooOOo._.().TabIndex = 3;
			this.ooOOo._.().Text = "确定";
			this.ooOOo._.().UseVisualStyleBackColor = true;
			this.O0.OOo.().DialogResult = DialogResult.Cancel;
			this.O0.OOo.().Location = new Point(278, 275);
			this.O0.OOo.().Name = "btnCancel";
			this.O0.OOo.().Size = new Size(75, 23);
			this.O0.OOo.().TabIndex = 4;
			this.O0.OOo.().Text = "取消";
			this.O0.OOo.().UseVisualStyleBackColor = true;
			this.O0.OOo.().AutoSize = true;
			this.O0.OOo.().BorderStyle = BorderStyle.None;
			this.O0.OOo.().Location = new Point(12, 243);
			this.O0.OOo.().Name = "CascateDelete";
			this.O0.OOo.().Size = new Size(108, 16);
			this.O0.OOo.().TabIndex = 7;
			this.O0.OOo.().Text = "同步删除关联行";
			this.O0.OOo.().UseVisualStyleBackColor = true;
			this.O0.OOo.().Value = null;
			this.Oo_O_.O_.().AutoSize = true;
			this.Oo_O_.O_.().Location = new Point(340, 223);
			this.Oo_O_.O_.().Name = "Label3";
			this.Oo_O_.O_.().Size = new Size(71, 12);
			this.Oo_O_.O_.().TabIndex = 8;
			this.Oo_O_.O_.().Text = "生成关联表:";
			this.Oo_O_.O_.().AllowSpinLoop = false;
			this.Oo_O_.O_.().Cursor = Cursors.Arrow;
			this.Oo_O_.O_.().DropDownStyle = DropDownStyle.DropDownList;
			this.Oo_O_.O_.().GapHeight = 0;
			this.Oo_O_.O_.().ImagePadding = new Padding(0);
			this.Oo_O_.O_.().Items.Add("单向");
			this.Oo_O_.O_.().Items.Add("双向");
			this.Oo_O_.O_.().Items.Add("无");
			this.Oo_O_.O_.().ItemsDisplayMember = "";
			this.Oo_O_.O_.().ItemsValueMember = "";
			this.Oo_O_.O_.().Location = new Point(417, 220);
			this.Oo_O_.O_.().Name = "cmRelationTable";
			this.Oo_O_.O_.().Size = new Size(121, 19);
			this.Oo_O_.O_.().TabIndex = 9;
			this.Oo_O_.O_.().Tag = null;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(550, 307);
			base.Controls.Add(this.Oo_O_.O_.());
			base.Controls.Add(this.Oo_O_.O_.());
			base.Controls.Add(this.O0.OOo.());
			base.Controls.Add(this.O0.OOo.());
			base.Controls.Add(this.ooOOo._.());
			base.Controls.Add(this.o.0O_0.());
			base.Controls.Add(this.o.0O_0.());
			base.Controls.Add(this.o_OO_._.());
			base.Controls.Add(this.o.0O_0.());
			base.Controls.Add(this.o_OO_._.());
			base.Controls.Add(this.o.0O_0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.o.O0.OO.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "编辑关联";
			((ISupportInitialize)this.o.0O_0.()).EndInit();
			((ISupportInitialize)this.o_OO_._.()).EndInit();
			((ISupportInitialize)this.o.0O_0.()).EndInit();
			((ISupportInitialize)this.o.0O_0.()).EndInit();
			((ISupportInitialize)this.ooOOo._.()).EndInit();
			((ISupportInitialize)this.O0.OOo.()).EndInit();
			((ISupportInitialize)this.O0.OOo.()).EndInit();
			((ISupportInitialize)this.Oo_O_.O_.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x001A58BF File Offset: 0x001A3ABF
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO0.O_o.;
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x001A58C7 File Offset: 0x001A3AC7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO0.O_o. = A_0;
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x001A58D0 File Offset: 0x001A3AD0
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O.o0O_O0o0_O.;
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x001A58D8 File Offset: 0x001A3AD8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O.o0O_O0o0_O. = A_0;
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x001A58E1 File Offset: 0x001A3AE1
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.oO0.O_o.;
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x001A58EC File Offset: 0x001A3AEC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.OOoOOOOoo0_._0.);
			C1ComboBox c1ComboBox = this.oO0.O_o.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.oO0.O_o. = A_0;
			c1ComboBox = this.oO0.O_o.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x001A592F File Offset: 0x001A3B2F
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o0._o.;
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x001A5938 File Offset: 0x001A3B38
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.o__Oo0o.0O_oO_.);
			C1ComboBox c1ComboBox = this.o0._o.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o0._o. = A_0;
			c1ComboBox = this.o0._o.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x001A597B File Offset: 0x001A3B7B
		[CompilerGenerated]
		internal virtual C1FlexGrid <<EMPTY_NAME>>()
		{
			return this.oO0.O_o.;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x001A5983 File Offset: 0x001A3B83
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1FlexGrid A_0)
		{
			this.oO0.O_o. = A_0;
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x001A598C File Offset: 0x001A3B8C
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oO0.O_o.;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x001A5994 File Offset: 0x001A3B94
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oO0.O_o. = A_0;
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x001A599D File Offset: 0x001A3B9D
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oO0.O_o.;
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x001A59A8 File Offset: 0x001A3BA8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.OOo.);
			C1Button c1Button = this.oO0.O_o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oO0.O_o. = A_0;
			c1Button = this.oO0.O_o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x001A59EB File Offset: 0x001A3BEB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o0._o.;
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x001A59F4 File Offset: 0x001A3BF4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.ooOOo._.);
			C1Button c1Button = this.o0._o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o0._o. = A_0;
			c1Button = this.o0._o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x001A5A37 File Offset: 0x001A3C37
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o0._o.;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x001A5A3F File Offset: 0x001A3C3F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o0._o. = A_0;
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x001A5A48 File Offset: 0x001A3C48
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oo0.oO_OOoo.;
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x001A5A50 File Offset: 0x001A3C50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oo0.oO_OOoo. = A_0;
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x001A5A59 File Offset: 0x001A3C59
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_oOo._o_00.;
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x001A5A61 File Offset: 0x001A3C61
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			this.o_oOo._o_00. = A_0;
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x001A5A6C File Offset: 0x001A3C6C
		public O\u3000\u3000(DataRow A_0)
		{
			base.Load += this.OOOo_._oO_0.;
			base.FormClosed += this.ooOOo._.;
			this.o.0O_0.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.OO0oo0.O_OoOo_. = A_0;
			if (A_0.RowState != DataRowState.Detached)
			{
				this.Text = this.Text + " - " + Conversions.ToString(A_0["Name"]);
				return;
			}
			this.Text += " - 新建";
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x001A5B0C File Offset: 0x001A3D0C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IEnumerator<DataTable> enumerator = OO_00oOO.DataTables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataTable dataTable = enumerator.Current;
					IL_1E:
					num2 = 3;
					if (!dataTable.frd_IsTemporary)
					{
						IL_29:
						num2 = 4;
						this.o.0O_0.().Items.Add(dataTable.Name);
						IL_43:
						num2 = 5;
						this.o_OO_._.().Items.Add(dataTable.Name);
					}
					IL_5D:
					num2 = 6;
				}
				IL_67:
				num2 = 7;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_72:
				num2 = 8;
				if (this.OO0oo0.O_OoOo_..IsNull("ParentTable"))
				{
					goto IL_A9;
				}
				IL_86:
				num2 = 9;
				this.o.0O_0.().SelectedItem = Conversions.ToString(this.OO0oo0.O_OoOo_.["ParentTable"]);
				IL_A9:
				num2 = 10;
				if (this.OO0oo0.O_OoOo_..IsNull("ChildTable"))
				{
					goto IL_E1;
				}
				IL_BE:
				num2 = 11;
				this.o_OO_._.().SelectedItem = Conversions.ToString(this.OO0oo0.O_OoOo_.["ChildTable"]);
				IL_E1:
				num2 = 12;
				if (this.OO0oo0.O_OoOo_..IsNull("ParentCols"))
				{
					goto IL_196;
				}
				IL_F9:
				num2 = 13;
				string[] array = Conversions.ToString(this.OO0oo0.O_OoOo_.["ParentCols"]).Split("\t".ToCharArray());
				IL_122:
				num2 = 14;
				string[] array2 = Conversions.ToString(this.OO0oo0.O_OoOo_.["ChildCols"]).Split("\t".ToCharArray());
				IL_14B:
				num2 = 15;
				int num3 = array.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_15B:
					num2 = 16;
					this.o.0O_0.()[i, 0] = array[i];
					IL_171:
					num2 = 17;
					this.o.0O_0.()[i, 1] = array2[i];
					IL_187:
					num2 = 18;
				}
				IL_196:
				num2 = 19;
				if (this.OO0oo0.O_OoOo_..IsNull("Property"))
				{
					goto IL_223;
				}
				IL_1AB:
				num2 = 20;
				fxDataRelationProperty fxDataRelationProperty = new fxDataRelationProperty();
				IL_1B5:
				num2 = 21;
				o_O_o_oOoo__.OOOO_OO._oo.(fxDataRelationProperty, Conversions.ToString(this.OO0oo0.O_OoOo_.["Property"]), '\v');
				IL_1D6:
				num2 = 22;
				if (!fxDataRelationProperty.CascadeUpdate)
				{
					goto IL_1F1;
				}
				IL_1E2:
				num2 = 23;
				this.o.0O_0.().Checked = true;
				IL_1F1:
				num2 = 24;
				if (!fxDataRelationProperty.CascadeDelete)
				{
					goto IL_20C;
				}
				IL_1FD:
				num2 = 25;
				this.O0.OOo.().Checked = true;
				IL_20C:
				num2 = 26;
				this.Oo_O_.O_.().SelectedIndex = (int)fxDataRelationProperty.RelationTable;
				goto IL_232;
				IL_223:
				num2 = 28;
				this.Oo_O_.O_.().SelectedIndex = 0;
				IL_232:
				goto IL_2F8;
				IL_237:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_2B9:
				goto IL_2ED;
				IL_2BB:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2CB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2BB;
			}
			IL_2ED:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2F8:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x001A5E38 File Offset: 0x001A4038
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o.0O_0.().SelectedItem != null)
			{
				string a_ = Conversions.ToString(this.o.0O_0.().SelectedItem);
				this.o.0O_0.().Cols[0].ComboList = this.o.0O_0.(OO_00oOO.DataTables[a_]);
				if (OO_00oOO.DataTables[a_].BaseTable.PrimaryKey.Length > 0 && Operators.CompareString(OO_00oOO.DataTables[a_].BaseTable.PrimaryKey[0].ColumnName, "_Identify", true) == 0)
				{
					this.o.0O_0.().Cols[0].ComboList = this.o.0O_0.(OO_00oOO.DataTables[a_]) + "|_Identify";
				}
				else
				{
					this.o.0O_0.().Cols[0].ComboList = this.o.0O_0.(OO_00oOO.DataTables[a_]);
				}
				int num = this.o.0O_0.().Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(Conversions.ToString(this.o.0O_0.()[i, 0]), "", true) > 0 && !OO_00oOO.DataTables[Conversions.ToString(this.o.0O_0.().SelectedItem)].DataCols.Contains(Conversions.ToString(this.o.0O_0.()[i, 0])))
					{
						this.o.0O_0.()[i, 0] = "";
					}
				}
			}
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x001A5FB4 File Offset: 0x001A41B4
		private string <<EMPTY_NAME>>(DataTable A_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				foreach (DataCol dataCol in A_0.DataCols)
				{
					if (!dataCol.IsTemporary)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append("|");
						}
						stringBuilder.Append(dataCol.Name);
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
			return stringBuilder.ToString();
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x001A6030 File Offset: 0x001A4230
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o_OO_._.().SelectedItem != null)
			{
				this.o.0O_0.().Cols[1].ComboList = this.o.0O_0.(OO_00oOO.DataTables[Conversions.ToString(this.o_OO_._.().SelectedItem)]);
				int num = this.o.0O_0.().Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(Conversions.ToString(this.o.0O_0.()[i, 1]), "", true) > 0 && !OO_00oOO.DataTables[Conversions.ToString(this.o_OO_._.().SelectedItem)].DataCols.Contains(Conversions.ToString(this.o.0O_0.()[i, 1])))
					{
						this.o.0O_0.()[i, 1] = "";
					}
				}
			}
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x001A610C File Offset: 0x001A430C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			int num;
			int num10;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!(this.o.0O_0.().SelectedItem == null | this.o_OO_._.().SelectedItem == null))
				{
					goto IL_42;
				}
				IL_28:
				num2 = 3;
				MessageBox.Show("没有选择关联表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_56C;
				IL_42:
				num2 = 5;
				DataTable dataTable = O_O0OO.OOOo.oo_OOOO_0.().Tables[Conversions.ToString(this.o.0O_0.().SelectedItem)];
				IL_65:
				num2 = 6;
				DataTable dataTable2 = O_O0OO.OOOo.oo_OOOO_0.().Tables[Conversions.ToString(this.o_OO_._.().SelectedItem)];
				IL_88:
				num2 = 7;
				StringBuilder stringBuilder = new StringBuilder();
				IL_91:
				num2 = 8;
				StringBuilder stringBuilder2 = new StringBuilder();
				IL_9A:
				num2 = 9;
				fxDataRelationProperty fxDataRelationProperty = new fxDataRelationProperty();
				IL_A4:
				num2 = 10;
				if (!Oo00.O____0O._0.(dataTable.TableName, dataTable2.TableName, this.OO0oo0.O_OoOo_.))
				{
					goto IL_DD;
				}
				IL_C2:
				num2 = 11;
				MessageBox.Show("指定的表之间已经存在关联，必须先删除之，才能重新定义关联！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_56C;
				IL_DD:
				num2 = 13;
				if (!this.o.0O_0.().Checked)
				{
					goto IL_F8;
				}
				IL_ED:
				num2 = 14;
				fxDataRelationProperty.CascadeUpdate = true;
				IL_F8:
				num2 = 15;
				if (!this.O0.OOo.().Checked)
				{
					goto IL_113;
				}
				IL_108:
				num2 = 16;
				fxDataRelationProperty.CascadeDelete = true;
				IL_113:
				num2 = 17;
				switch (this.Oo_O_.O_.().SelectedIndex)
				{
				case 0:
					IL_138:
					num2 = 19;
					fxDataRelationProperty.RelationTable = RelationPathEnum.One;
					break;
				case 1:
					IL_145:
					num2 = 21;
					fxDataRelationProperty.RelationTable = RelationPathEnum.Both;
					break;
				case 2:
					IL_152:
					num2 = 23;
					fxDataRelationProperty.RelationTable = RelationPathEnum.None;
					break;
				}
				IL_15D:
				num2 = 25;
				int num3 = this.o.0O_0.().Rows.Count - 1;
				int num4;
				for (int i = 0; i <= num3; i++)
				{
					IL_179:
					num2 = 26;
					if (Operators.CompareString(Conversions.ToString(this.o.0O_0.()[i, 0]), "", true) > 0 || Operators.CompareString(Conversions.ToString(this.o.0O_0.()[i, 1]), "", true) > 0)
					{
						IL_1BE:
						num2 = 27;
						num4 = i;
					}
					IL_1C4:
					num2 = 28;
				}
				IL_1D3:
				num2 = 29;
				int num5 = num4;
				for (int j = 0; j <= num5; j++)
				{
					IL_1DE:
					num2 = 30;
					if (Operators.CompareString(Conversions.ToString(this.o.0O_0.()[j, 0]), "", true) == 0 || Operators.CompareString(Conversions.ToString(this.o.0O_0.()[j, 1]), "", true) == 0)
					{
						IL_221:
						num2 = 31;
						MessageBox.Show("第" + Conversions.ToString(j) + "行没有选择关联列！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						goto IL_56C;
					}
					IL_24D:
					num2 = 33;
				}
				IL_25C:
				num2 = 34;
				int num6 = num4;
				for (int k = 0; k <= num6; k++)
				{
					IL_26A:
					num2 = 35;
					if (dataTable.Columns[Conversions.ToString(this.o.0O_0.()[k, 0])].DataType != dataTable2.Columns[Conversions.ToString(this.o.0O_0.()[k, 1])].DataType)
					{
						IL_2B7:
						num2 = 36;
						MessageBox.Show("第" + Conversions.ToString(k) + "行关联列的类型不匹配！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						goto IL_56C;
					}
					IL_2E3:
					num2 = 38;
				}
				IL_2F5:
				num2 = 39;
				if (dataTable != dataTable2)
				{
					goto IL_35D;
				}
				IL_2FE:
				num2 = 40;
				IL_304:
				num2 = 41;
				int num7 = num4;
				for (int l = 0; l <= num7; l++)
				{
					IL_30F:
					num2 = 42;
					if (Operators.CompareString(Conversions.ToString(this.o.0O_0.()[l, 0]), Conversions.ToString(this.o.0O_0.()[l, 1]), true) != 0)
					{
						IL_340:
						num2 = 43;
						break;
					}
					IL_348:
					num2 = 45;
				}
				IL_357:
				num2 = 46;
				IL_35D:
				num2 = 47;
				if (!Oo00.oO.OO.(dataTable.TableName, dataTable2.TableName))
				{
					goto IL_390;
				}
				IL_375:
				num2 = 48;
				MessageBox.Show("表间关系存在死循环!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_56C;
				IL_390:
				num2 = 50;
				if (this.OO0oo0.O_OoOo_..RowState != DataRowState.Detached)
				{
					goto IL_43C;
				}
				IL_3A4:
				num2 = 51;
				o\u3000\u3000 o_u3000_u = new o\u3000\u3000("新建关联", "请输入关联名称:", "");
				IL_3BD:
				num2 = 52;
				o_u3000_u.Oo.__0o_0_Oo.(new o\u3000\u3000.ooOOO_O_Oo_0(Oo00.O0o._.));
				IL_3D3:
				num2 = 53;
				if (o_u3000_u.ShowDialog() != DialogResult.OK)
				{
					goto IL_56C;
				}
				IL_3E3:
				num2 = 54;
				if (!Oo00.o0.__oO0_.(o_u3000_u.Value, dataTable, dataTable2))
				{
					goto IL_56C;
				}
				IL_3FB:
				num2 = 56;
				this.OO0oo0.O_OoOo_.["Name"] = o_u3000_u.Value;
				IL_415:
				num2 = 57;
				O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].Rows.Add(this.OO0oo0.O_OoOo_.);
				IL_43C:
				num2 = 60;
				int num8 = num4;
				for (int m = 0; m <= num8; m++)
				{
					IL_447:
					num2 = 61;
					if (stringBuilder.Length > 0)
					{
						IL_454:
						num2 = 62;
						stringBuilder.Append("\t");
						IL_464:
						num2 = 63;
						stringBuilder2.Append("\t");
					}
					IL_474:
					num2 = 64;
					stringBuilder.Append(Conversions.ToString(this.o.0O_0.()[m, 0]));
					IL_492:
					num2 = 65;
					stringBuilder2.Append(Conversions.ToString(this.o.0O_0.()[m, 1]));
					IL_4B0:
					num2 = 66;
				}
				IL_4BF:
				num2 = 67;
				this.OO0oo0.O_OoOo_.["ParentTable"] = dataTable.TableName;
				IL_4D9:
				num2 = 68;
				this.OO0oo0.O_OoOo_.["ChildTable"] = dataTable2.TableName;
				IL_4F3:
				num2 = 69;
				this.OO0oo0.O_OoOo_.["ParentCols"] = stringBuilder.ToString();
				IL_50D:
				num2 = 70;
				this.OO0oo0.O_OoOo_.["ChildCols"] = stringBuilder2.ToString();
				IL_527:
				num2 = 71;
				this.OO0oo0.O_OoOo_.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(fxDataRelationProperty, false, '\v', false);
				IL_545:
				num2 = 72;
				Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()], true);
				IL_562:
				num2 = 73;
				base.DialogResult = DialogResult.OK;
				IL_56C:
				goto IL_6E6;
				IL_571:
				int num9 = num10 + 1;
				num10 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9);
				IL_6A7:
				goto IL_6DB;
				IL_6A9:
				num10 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6B9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num10 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_6A9;
			}
			IL_6DB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6E6:
			if (num10 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x001A6824 File Offset: 0x001A4A24
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO0oo0.O_OoOo_..RowState != DataRowState.Detached)
			{
				this.OO0oo0.O_OoOo_..RejectChanges();
			}
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x001A6846 File Offset: 0x001A4A46
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x0400180B RID: 6155
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400180C RID: 6156
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400180D RID: 6157
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400180E RID: 6158
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400180F RID: 6159
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001810 RID: 6160
		[CompilerGenerated]
		private C1FlexGrid <<EMPTY_NAME>>;

		// Token: 0x04001811 RID: 6161
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001812 RID: 6162
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001813 RID: 6163
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001814 RID: 6164
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x04001815 RID: 6165
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001816 RID: 6166
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x04001817 RID: 6167
		private DataRow <<EMPTY_NAME>>;
	}
}
