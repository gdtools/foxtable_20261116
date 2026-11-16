using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000283 RID: 643
	[DesignerGenerated]
	internal class oo0_o0o_0o__ : UserControl
	{
		// Token: 0x0600202F RID: 8239 RVA: 0x000DF6BB File Offset: 0x000DD8BB
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.O_oo.0oOO. != null)
			{
				this.O_oo.0oOO..Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x000DF6DC File Offset: 0x000DD8DC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O_oo.0oOO. = new Container();
			this.O0OOo.o.(new ContextMenuStrip(this.O_oo.0oOO.));
			this.o_.oO0.(new ToolStripMenuItem());
			this.o0_O.OOoOoo_.(new ToolStripMenuItem());
			this.o0.Oo_oo0Oo0O.(new ToolStripMenuItem());
			this.o0.Oo_oo0Oo0O.(new SplitContainer());
			this.O0OOo.o.(new Label());
			this.O0OOo.o.(new o_0OOo0o_0O_());
			this.o00o._.().SuspendLayout();
			this.o00o._.().Panel1.SuspendLayout();
			this.o00o._.().Panel2.SuspendLayout();
			this.o00o._.().SuspendLayout();
			((ISupportInitialize)this.o00o._.()).BeginInit();
			base.SuspendLayout();
			this.o00o._.().Items.AddRange(new ToolStripItem[]
			{
				this.Ooo_ooo.0.(),
				this.o.o0__.(),
				this.o00o._.()
			});
			this.o00o._.().Name = "ContextMenuStrip1";
			this.o00o._.().Size = new Size(101, 70);
			this.Ooo_ooo.0.().Name = "DeleteMenuItem";
			this.Ooo_ooo.0.().Size = new Size(100, 22);
			this.Ooo_ooo.0.().Text = "删除";
			this.o.o0__.().Name = "MoveUpMenuItem";
			this.o.o0__.().Size = new Size(100, 22);
			this.o.o0__.().Text = "上移";
			this.o00o._.().Name = "MoveDownMenuItem";
			this.o00o._.().Size = new Size(100, 22);
			this.o00o._.().Text = "下移";
			this.o00o._.().Dock = DockStyle.Fill;
			this.o00o._.().FixedPanel = FixedPanel.Panel2;
			this.o00o._.().Location = new Point(0, 0);
			this.o00o._.().Name = "SplitContainer1";
			this.o00o._.().Orientation = Orientation.Horizontal;
			this.o00o._.().Panel1.Controls.Add(this.o00o._.());
			this.o00o._.().Panel2.Controls.Add(this.o00o._.());
			this.o00o._.().Size = new Size(523, 333);
			this.o00o._.().SplitterDistance = 267;
			this.o00o._.().TabIndex = 7;
			this.o00o._.().BorderStyle = BorderStyle.Fixed3D;
			this.o00o._.().Dock = DockStyle.Fill;
			this.o00o._.().Location = new Point(0, 0);
			this.o00o._.().Name = "Description";
			this.o00o._.().Size = new Size(523, 62);
			this.o00o._.().TabIndex = 0;
			this.o00o._.().Text = "提示:表设计器只能增加数据列，表达式列请执行\"列\"菜单下的\"增加列→表达式列\"命令来增加。列标题是列名更具描述性的表述，通常无需设置。";
			this.o00o._.().AllowAddNew = true;
			this.o00o._.().AllowDelete = true;
			this.o00o._.().AllowSorting = AllowSortingEnum.None;
			this.o00o._.().BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this.o00o._.().ColumnInfo = "10,1,0,0,0,0,Columns:";
			this.o00o._.().ContextMenuStrip = this.o00o._.();
			this.o00o._.().Dock = DockStyle.Fill;
			this.o00o._.().ExtendLastCol = true;
			this.o00o._.().Location = new Point(0, 0);
			this.o00o._.().Name = "C1FlexGrid1";
			this.o00o._.().Rows.DefaultSize = 21;
			this.o00o._.().SelectionMode = SelectionModeEnum.ListBox;
			this.o00o._.().Size = new Size(523, 267);
			this.o00o._.().TabIndex = 6;
			this.o00o._.().VisualStyle = VisualStyle.Office2010Silver;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.o00o._.());
			base.Name = "OO.....o";
			base.Size = new Size(523, 333);
			this.o00o._.().ResumeLayout(false);
			this.o00o._.().Panel1.ResumeLayout(false);
			this.o00o._.().Panel2.ResumeLayout(false);
			this.o00o._.().ResumeLayout(false);
			((ISupportInitialize)this.o00o._.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x000DFB12 File Offset: 0x000DDD12
		[CompilerGenerated]
		internal virtual o_0OOo0o_0O_ <<EMPTY_NAME>>()
		{
			return this.o0.Oo_oo0Oo0O.;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x000DFB1C File Offset: 0x000DDD1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(o_0OOo0o_0O_ A_0)
		{
			RowColEventHandler value = new RowColEventHandler(this.O0o.OOoo.);
			RowColEventHandler value2 = new RowColEventHandler(this.oo.Oo_Oo.);
			RowColEventHandler value3 = new RowColEventHandler(this.oo_._oO.);
			RangeEventHandler value4 = new RangeEventHandler(this.ooo.O00_0__0.);
			RowColEventHandler value5 = new RowColEventHandler(this.oo0_oo_0_00.oO.);
			MouseEventHandler value6 = new MouseEventHandler(this.ooo.O00_0__0.);
			RowColEventHandler value7 = new RowColEventHandler(this.ooo.O00_0__0.);
			ValidateEditEventHandler value8 = new ValidateEditEventHandler(this.ooo.O00_0__0.);
			PreviewKeyDownEventHandler value9 = new PreviewKeyDownEventHandler(this.ooo.O00_0__0.);
			o_0OOo0o_0O_ o_0OOo0o_0O_ = this.o0.Oo_oo0Oo0O.;
			if (o_0OOo0o_0O_ != null)
			{
				o_0OOo0o_0O_.AfterAddRow -= value;
				o_0OOo0o_0O_.AfterDeleteRow -= value2;
				o_0OOo0o_0O_.AfterEdit -= value3;
				o_0OOo0o_0O_.AfterRowColChange -= value4;
				o_0OOo0o_0O_.BeforeEdit -= value5;
				o_0OOo0o_0O_.MouseUp -= value6;
				o_0OOo0o_0O_.SetupEditor -= value7;
				o_0OOo0o_0O_.ValidateEdit -= value8;
				o_0OOo0o_0O_.PreviewKeyDown -= value9;
			}
			this.o0.Oo_oo0Oo0O. = A_0;
			o_0OOo0o_0O_ = this.o0.Oo_oo0Oo0O.;
			if (o_0OOo0o_0O_ != null)
			{
				o_0OOo0o_0O_.AfterAddRow += value;
				o_0OOo0o_0O_.AfterDeleteRow += value2;
				o_0OOo0o_0O_.AfterEdit += value3;
				o_0OOo0o_0O_.AfterRowColChange += value4;
				o_0OOo0o_0O_.BeforeEdit += value5;
				o_0OOo0o_0O_.MouseUp += value6;
				o_0OOo0o_0O_.SetupEditor += value7;
				o_0OOo0o_0O_.ValidateEdit += value8;
				o_0OOo0o_0O_.PreviewKeyDown += value9;
			}
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x000DFC5C File Offset: 0x000DDE5C
		[CompilerGenerated]
		internal virtual SplitContainer <<EMPTY_NAME>>()
		{
			return this.O_oo.0oOO.;
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x000DFC64 File Offset: 0x000DDE64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(SplitContainer A_0)
		{
			this.O_oo.0oOO. = A_0;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x000DFC6D File Offset: 0x000DDE6D
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o0.Oo_oo0Oo0O.;
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x000DFC75 File Offset: 0x000DDE75
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o0.Oo_oo0Oo0O. = A_0;
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000DFC7E File Offset: 0x000DDE7E
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.o0.Oo_oo0Oo0O.;
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x000DFC86 File Offset: 0x000DDE86
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.o0.Oo_oo0Oo0O. = A_0;
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x000DFC90 File Offset: 0x000DDE90
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0.Oo_oo0Oo0O.;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000DFCA4 File Offset: 0x000DDEA4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o.o0__.);
				ToolStripMenuItem toolStripMenuItem = this.o0.Oo_oo0Oo0O.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					case 2:
						toolStripMenuItem.Click -= value;
						num = 5;
						continue;
					case 3:
						toolStripMenuItem.Click += value;
						num = 0;
						continue;
					case 4:
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						return;
					case 5:
						goto IL_62;
					}
					break;
					IL_62:
					this.o0.Oo_oo0Oo0O. = A_0;
					toolStripMenuItem = this.o0.Oo_oo0Oo0O.;
					num = 4;
				}
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x000DFD50 File Offset: 0x000DDF50
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oo__O.0_00.;
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x000DFD64 File Offset: 0x000DDF64
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O_._O0Oo_o.);
				ToolStripMenuItem toolStripMenuItem = this.oo__O.0_00.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 4;
						continue;
					case 1:
						toolStripMenuItem.Click -= value;
						num = 2;
						continue;
					case 2:
						goto IL_62;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						if (toolStripMenuItem != null)
						{
							if (true)
							{
							}
							num = 1;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.oo__O.0_00. = A_0;
					toolStripMenuItem = this.oo__O.0_00.;
					num = 3;
				}
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000DFE10 File Offset: 0x000DE010
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0_O.OOoOoo_.;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000DFE24 File Offset: 0x000DE024
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OoO_Oo._o.);
				ToolStripMenuItem toolStripMenuItem = this.o0_O.OOoOoo_.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						goto IL_5A;
					case 2:
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						return;
					case 3:
						toolStripMenuItem.Click += value;
						num = 0;
						continue;
					case 4:
						goto IL_5A;
					case 5:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					}
					break;
					IL_5A:
					this.o0_O.OOoOoo_. = A_0;
					toolStripMenuItem = this.o0_O.OOoOoo_.;
					num = 2;
				}
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000DFECC File Offset: 0x000DE0CC
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			this.o00o._.().Rows[A_1.Row]["类型"] = ColumnDataTypeEnum.String;
			this.o00o._.().Rows[A_1.Row]["长度"] = 16;
			this.O0OOo.o.();
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000DFF30 File Offset: 0x000DE130
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			this.O0OOo.o.();
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000DFF38 File Offset: 0x000DE138
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			try
			{
				this.O_oo.0oOO..DefaultView[this.o00o._.().Rows[A_1.Row].DataIndex].EndEdit();
				if (Operators.CompareString(this.o00o._.().Cols[A_1.Col].Name, "类型", true) == 0)
				{
					if (Conversions.ToInteger(this.o00o._.()[A_1.Row, "类型"]) == 202)
					{
						this.o00o._.()[A_1.Row, "长度"] = 16;
					}
					else
					{
						this.o00o._.()[A_1.Row, "长度"] = DBNull.Value;
					}
					this.O0OOo.o.();
				}
				if (A_1.Row == this.o00o._.().Rows.Count - 2)
				{
					this.o00o._.().TopRow = this.o00o._.().Rows.Count - 1;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000E006C File Offset: 0x000DE26C
		private void <<EMPTY_NAME>>()
		{
			if (this.o00o._.().Row >= 1)
			{
				o_0OOo0o_0O_ o_0OOo0o_0O_ = this.o00o._.();
				if (o_0OOo0o_0O_[o_0OOo0o_0O_.Row, "类型"] == DBNull.Value)
				{
					this.o00o._.().Text = "";
				}
				else
				{
					this.o00o._.().Text = ooO.oO0__o.0o__.((ColumnDataTypeEnum)Conversions.ToInteger(o_0OOo0o_0O_[o_0OOo0o_0O_.Row, "类型"]));
				}
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000E00E0 File Offset: 0x000DE2E0
		private void <<EMPTY_NAME>>(object A_0, RangeEventArgs A_1)
		{
			if (A_1.NewRange.r1 != A_1.OldRange.r1)
			{
				this.O0OOo.o.();
			}
			if (Operators.CompareString(this.o00o._.().Cols[this.o00o._.().Col].Name, "长度", true) == 0)
			{
				this.o00o._.().ImeMode = ImeMode.Close;
			}
			else
			{
				this.o00o._.().ImeMode = ImeMode.NoControl;
			}
			if (Operators.CompareString(this.o00o._.().Cols[this.o00o._.().Col].Name, "列名", true) == 0 && this.o00o._.().Row > 0)
			{
				MouseButtons mouseButtons = Control.MouseButtons;
			}
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000E019A File Offset: 0x000DE39A
		public oo0_o0o_0o__()
		{
			base.Load += this.o0.Oo_oo0Oo0O.;
			this.O_oo.0oOO. = new DataTable();
			this.o.o0__.();
			this.o00o._.().Rows.DefaultSize = 21;
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000E01D8 File Offset: 0x000DE3D8
		internal void <<EMPTY_NAME>>()
		{
			this.O_oo.0oOO..Columns.Add("ID", typeof(int));
			this.O_oo.0oOO..Columns.Add("列名", typeof(string));
			this.O_oo.0oOO..Columns.Add("类型", typeof(ColumnDataTypeEnum));
			this.O_oo.0oOO..Columns.Add("长度", typeof(byte));
			this.O_oo.0oOO..Columns.Add("标题", typeof(string));
			this.O_oo.0oOO..Columns["列名"].MaxLength = 64;
			this.O_oo.0oOO..Columns["列名"].Unique = true;
			this.O_oo.0oOO..Columns["ID"].AutoIncrement = true;
			this.O_oo.0oOO..DefaultView.Sort = "ID";
			this.o00o._.().DataSource = this.O_oo.0oOO.;
			this.o00o._.().Cols.Remove("ID");
			this.O_oo.0oOO. = (CurrencyManager)this.BindingContext[this.O_oo.0oOO.];
			this.O_0Oo_._00oo0.();
			this.o00o._.().Cols["列名"].Width = 120;
			this.o00o._.().Cols["类型"].Width = 80;
			this.o00o._.().Cols["长度"].Width = 40;
			this.o00o._.().Cols["标题"].Width = 10;
			this.o00o._.().ExtendLastCol = true;
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000E03B4 File Offset: 0x000DE5B4
		internal void <<EMPTY_NAME>>()
		{
			ListDictionary listDictionary = new ListDictionary();
			listDictionary.Add(ColumnDataTypeEnum.String, "字符");
			listDictionary.Add(ColumnDataTypeEnum.DateTime, "日期时间");
			listDictionary.Add(ColumnDataTypeEnum.Boolean, "逻辑");
			listDictionary.Add(ColumnDataTypeEnum.Integer, "整数");
			if (!this.O_oo.0oOO.)
			{
				listDictionary.Add(ColumnDataTypeEnum.Long, "长整数");
			}
			listDictionary.Add(ColumnDataTypeEnum.Short, "短整数");
			listDictionary.Add(ColumnDataTypeEnum.Byte, "微整数");
			listDictionary.Add(ColumnDataTypeEnum.Double, "双精度小数");
			listDictionary.Add(ColumnDataTypeEnum.Single, "单精度小数");
			listDictionary.Add(ColumnDataTypeEnum.Decimal, "高精度小数");
			listDictionary.Add(ColumnDataTypeEnum.Text, "备注");
			this.o00o._.().Cols["类型"].DataMap = listDictionary;
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000E04B4 File Offset: 0x000DE6B4
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (A_1.Row != 0 && Operators.CompareString(this.o00o._.().Cols[A_1.Col].Name, "长度", true) == 0 && Conversions.ToInteger(this.o00o._.()[A_1.Row, "类型"]) != 202)
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000E051C File Offset: 0x000DE71C
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (Operators.CompareString(this.o00o._.().Cols[this.o00o._.().Col].Name, "列名", true) == 0 && this.o00o._.().Selection.IsSingleCell && this.o00o._.().Row > 0)
			{
				MouseButtons mouseButtons = Control.MouseButtons;
			}
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000E057F File Offset: 0x000DE77F
		private void <<EMPTY_NAME>>(object A_0, RowColEventArgs A_1)
		{
			if (this.o00o._.().Editor is ComboBox)
			{
				((ComboBox)this.o00o._.().Editor).MaxDropDownItems = 20;
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000E05AC File Offset: 0x000DE7AC
		private void <<EMPTY_NAME>>(object A_0, ValidateEditEventArgs A_1)
		{
			if (Operators.CompareString(this.o00o._.().Cols[A_1.Col].Name, "列名", true) == 0 && !o_O_o_oOoo__.O_o_._o0.(this.o00o._.().Editor.Text, "列名", 64, false))
			{
				A_1.Cancel = true;
			}
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000E0607 File Offset: 0x000DE807
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_._O0Oo_o.();
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000E0610 File Offset: 0x000DE810
		internal void <<EMPTY_NAME>>()
		{
			if (this.O_oo.0oOO..Position < this.O_oo.0oOO..Count - 1)
			{
				int position = this.O_oo.0oOO..Position;
				DataRow row = this.O_oo.0oOO..DefaultView[this.O_oo.0oOO..Position].Row;
				DataRow row2 = this.O_oo.0oOO..DefaultView[this.O_oo.0oOO..Position + 1].Row;
				int num = Conversions.ToInteger(row["ID"]);
				row["ID"] = RuntimeHelpers.GetObjectValue(row2["ID"]);
				row2["ID"] = num;
				this.O_oo.0oOO..Position = position + 1;
			}
			this.o00o._.().Focus();
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x000E06DF File Offset: 0x000DE8DF
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OoO_Oo._o.();
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x000E06E8 File Offset: 0x000DE8E8
		internal void <<EMPTY_NAME>>()
		{
			if (this.O_oo.0oOO..Position > 0)
			{
				int position = this.O_oo.0oOO..Position;
				DataRow row = this.O_oo.0oOO..DefaultView[this.O_oo.0oOO..Position].Row;
				DataRow row2 = this.O_oo.0oOO..DefaultView[this.O_oo.0oOO..Position - 1].Row;
				int num = Conversions.ToInteger(row["ID"]);
				row["ID"] = RuntimeHelpers.GetObjectValue(row2["ID"]);
				row2["ID"] = num;
				this.O_oo.0oOO..Position = position - 1;
			}
			this.o00o._.().Focus();
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x000E07AB File Offset: 0x000DE9AB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O0o.OOoo.();
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000E07B4 File Offset: 0x000DE9B4
		internal void <<EMPTY_NAME>>()
		{
			List<DataRow> list = new List<DataRow>();
			if (this.o00o._.().Selection.TopRow >= this.o00o._.().Rows.Fixed)
			{
				int topRow = this.o00o._.().Selection.TopRow;
				int bottomRow = this.o00o._.().Selection.BottomRow;
				int num = topRow;
				while (num <= bottomRow && num != this.o00o._.().Rows.Count - 1)
				{
					list.Add(this.O_oo.0oOO..DefaultView[num - 1].Row);
					num++;
				}
				try
				{
					foreach (DataRow dataRow in list)
					{
						dataRow.Delete();
					}
				}
				finally
				{
					List<DataRow>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.o00o._.().Focus();
			}
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x000E08A0 File Offset: 0x000DEAA0
		private void <<EMPTY_NAME>>(object A_0, PreviewKeyDownEventArgs A_1)
		{
			if ((this.o00o._.().Row >= this.o00o._.().Rows.Fixed & this.o00o._.().Col >= this.o00o._.().Cols.Fixed) && this.o00o._.().Editor == null && A_1.KeyCode == Keys.ProcessKey && (this.o00o._.().Col == 1 || this.o00o._.().Col == 4))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.o00o._.().GetData(this.o00o._.().Row, this.o00o._.().Col));
				string text = "";
				if (objectValue != null)
				{
					text = objectValue.ToString();
				}
				this.o00o._.().StartEditing();
				Application.DoEvents();
				if (Operators.CompareString(this.o00o._.().Editor.Text, text, true) != 0)
				{
					text = this.o00o._.().Editor.Text;
					this.o00o._.().Editor.Text = "";
					SendKeys.Send(text);
				}
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000E09C0 File Offset: 0x000DEBC0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			C1FlexGrid c1FlexGrid = this.o00o._.();
			c1FlexGrid.Styles.SelectedColumnHeader.Clear();
			c1FlexGrid.Styles.Alternate.Clear();
			c1FlexGrid.Styles.Focus.Clear();
			c1FlexGrid.Styles.Focus.MergeWith(c1FlexGrid.Styles.Normal);
			c1FlexGrid.FocusRect = FocusRectEnum.Solid;
			c1FlexGrid.AllowSorting = AllowSortingEnum.None;
			this.o00o._.().BackColor = Color.White;
			this.o00o._.().Padding = new Padding(3, 4, 3, 0);
		}

		// Token: 0x04000D89 RID: 3465
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000D8A RID: 3466
		[CompilerGenerated]
		private o_0OOo0o_0O_ <<EMPTY_NAME>>;

		// Token: 0x04000D8B RID: 3467
		[CompilerGenerated]
		private SplitContainer <<EMPTY_NAME>>;

		// Token: 0x04000D8C RID: 3468
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04000D8D RID: 3469
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04000D8E RID: 3470
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000D8F RID: 3471
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000D90 RID: 3472
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000D91 RID: 3473
		internal DataTable <<EMPTY_NAME>>;

		// Token: 0x04000D92 RID: 3474
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04000D93 RID: 3475
		internal string <<EMPTY_NAME>>;

		// Token: 0x04000D94 RID: 3476
		private CurrencyManager <<EMPTY_NAME>>;
	}
}
