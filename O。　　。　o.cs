using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using ADOX;
using C1.Win.C1Input;
using Foxtable.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x020000D8 RID: 216
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000\u3002\u3000o : Form
	{
		// Token: 0x06000A04 RID: 2564 RVA: 0x000529F8 File Offset: 0x00050BF8
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.O0_0oo.o0oooOo. != null)
				{
					this.O0_0oo.o0oooOo..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00052A38 File Offset: 0x00050C38
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.O0_0oo.o0oooOo. = new Container();
			this.o0oO_00.0_O.(new C1Button());
			this.oO__O.O0oO.(new C1Button());
			this.o0oO_00.0_O.(new Label());
			this.o0oO_00.0_O.(new TreeView());
			this.o0oO_00.0_O.(new ImageList(this.O0_0oo.o0oooOo.));
			this.o0oO_00.0_O.(new C1CheckBox());
			((ISupportInitialize)this.o0o__0.0_o.()).BeginInit();
			((ISupportInitialize)this.o_00_.oO0oo__0.()).BeginInit();
			((ISupportInitialize)this.o_00_.oO0oo__0.()).BeginInit();
			base.SuspendLayout();
			this.o0o__0.0_o.().Location = new Point(97, 483);
			this.o0o__0.0_o.().Name = "Button1";
			this.o0o__0.0_o.().Size = new Size(75, 23);
			this.o0o__0.0_o.().TabIndex = 2;
			this.o0o__0.0_o.().Text = "确定";
			this.o0o__0.0_o.().UseVisualStyleBackColor = true;
			this.o_00_.oO0oo__0.().Location = new Point(189, 483);
			this.o_00_.oO0oo__0.().Name = "Button2";
			this.o_00_.oO0oo__0.().Size = new Size(75, 23);
			this.o_00_.oO0oo__0.().TabIndex = 3;
			this.o_00_.oO0oo__0.().Text = "取消";
			this.o_00_.oO0oo__0.().UseVisualStyleBackColor = true;
			this.o_00_.oO0oo__0.().AutoSize = true;
			this.o_00_.oO0oo__0.().Location = new Point(14, 18);
			this.o_00_.oO0oo__0.().Name = "Label1";
			this.o_00_.oO0oo__0.().Size = new Size(107, 12);
			this.o_00_.oO0oo__0.().TabIndex = 4;
			this.o_00_.oO0oo__0.().Text = "选择要导出的函数:";
			this.o0oO_00.0_O.().Location = new Point(15, 51);
			this.o0oO_00.0_O.().Name = "TreeView1";
			this.o0oO_00.0_O.().Size = new Size(330, 417);
			this.o0oO_00.0_O.().TabIndex = 5;
			this.o_00_.oO0oo__0.().ColorDepth = ColorDepth.Depth8Bit;
			this.o_00_.oO0oo__0.().ImageSize = new Size(16, 16);
			this.o_00_.oO0oo__0.().TransparentColor = Color.Transparent;
			this.o_00_.oO0oo__0.().AutoSize = true;
			this.o_00_.oO0oo__0.().BorderStyle = BorderStyle.None;
			this.o_00_.oO0oo__0.().Location = new Point(250, 18);
			this.o_00_.oO0oo__0.().Name = "CheckBox1";
			this.o_00_.oO0oo__0.().Size = new Size(96, 16);
			this.o_00_.oO0oo__0.().TabIndex = 1;
			this.o_00_.oO0oo__0.().Text = "选择所有函数";
			this.o_00_.oO0oo__0.().UseVisualStyleBackColor = true;
			this.o_00_.oO0oo__0.().Value = null;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(361, 518);
			base.Controls.Add(this.o0oO_00.0_O.());
			base.Controls.Add(this.o_00_.oO0oo__0.());
			base.Controls.Add(this.o_00_.oO0oo__0.());
			base.Controls.Add(this.o_00_.oO0oo__0.());
			base.Controls.Add(this.o0o__0.0_o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "O.o_0..0.";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "导出函数";
			((ISupportInitialize)this.o0o__0.0_o.()).EndInit();
			((ISupportInitialize)this.o_00_.oO0oo__0.()).EndInit();
			((ISupportInitialize)this.o_00_.oO0oo__0.()).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00052DDD File Offset: 0x00050FDD
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O0_0oo.o0oooOo.;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00052DE8 File Offset: 0x00050FE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_0oO0.__O_.);
			C1Button o0_0oo.o0oooOo. = this.O0_0oo.o0oooOo.;
			if (o0_0oo.o0oooOo. != null)
			{
				o0_0oo.o0oooOo..Click -= value;
			}
			this.O0_0oo.o0oooOo. = A_0;
			o0_0oo.o0oooOo. = this.O0_0oo.o0oooOo.;
			if (o0_0oo.o0oooOo. != null)
			{
				o0_0oo.o0oooOo..Click += value;
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00052E2B File Offset: 0x0005102B
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O._OO0.;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00052E34 File Offset: 0x00051034
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o.0O00o_0O.);
			C1Button o._OO0. = this.O._OO0.;
			if (o._OO0. != null)
			{
				o._OO0..Click -= value;
			}
			this.O._OO0. = A_0;
			o._OO0. = this.O._OO0.;
			if (o._OO0. != null)
			{
				o._OO0..Click += value;
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00052E77 File Offset: 0x00051077
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.O0_0oo.o0oooOo.;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00052E7F File Offset: 0x0005107F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.O0_0oo.o0oooOo. = A_0;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00052E88 File Offset: 0x00051088
		[CompilerGenerated]
		internal virtual TreeView <<EMPTY_NAME>>()
		{
			return this.O0_0oo.o0oooOo.;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00052E90 File Offset: 0x00051090
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TreeView A_0)
		{
			TreeViewEventHandler value = new TreeViewEventHandler(this.o0oO_00.0_O.);
			TreeView o0_0oo.o0oooOo. = this.O0_0oo.o0oooOo.;
			if (o0_0oo.o0oooOo. != null)
			{
				o0_0oo.o0oooOo..AfterCheck -= value;
			}
			this.O0_0oo.o0oooOo. = A_0;
			o0_0oo.o0oooOo. = this.O0_0oo.o0oooOo.;
			if (o0_0oo.o0oooOo. != null)
			{
				o0_0oo.o0oooOo..AfterCheck += value;
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00052ED3 File Offset: 0x000510D3
		[CompilerGenerated]
		internal virtual ImageList <<EMPTY_NAME>>()
		{
			return this.O0_0oo.o0oooOo.;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00052EDB File Offset: 0x000510DB
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ImageList A_0)
		{
			this.O0_0oo.o0oooOo. = A_0;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00052EE4 File Offset: 0x000510E4
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.O0_0oo.o0oooOo.;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00052EEC File Offset: 0x000510EC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			EventHandler value = new EventHandler(this.o0o__0.0_o.);
			C1CheckBox o0_0oo.o0oooOo. = this.O0_0oo.o0oooOo.;
			if (o0_0oo.o0oooOo. != null)
			{
				o0_0oo.o0oooOo..CheckedChanged -= value;
			}
			this.O0_0oo.o0oooOo. = A_0;
			o0_0oo.o0oooOo. = this.O0_0oo.o0oooOo.;
			if (o0_0oo.o0oooOo. != null)
			{
				o0_0oo.o0oooOo..CheckedChanged += value;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00052F30 File Offset: 0x00051130
		public O\u3002\u3000\u3000\u3002\u3000o(string A_0)
		{
			base.Load += this.O__.O.;
			base.FormClosed += this.o_00_.oO0oo__0.;
			base.Activated += this.o_00_.oO0oo__0.;
			this.O0_0oo.o0oooOo. = new HashSet<TreeNode>();
			this.oO__O.O0oO.();
			this.O0_0oo.o0oooOo. = A_0;
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
			this.o0oO_00.0_O.().PathSeparator = "\t";
			this.o_00_.oO0oo__0.().Images.Add(a.oO0O_O.__oo.());
			this.o_00_.oO0oo__0.().Images.Add(a.O.o_oo0O_.());
			this.o0oO_00.0_O.().ImageList = this.o_00_.oO0oo__0.();
			this.o0oO_00.0_O.().CheckBoxes = true;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00053000 File Offset: 0x00051200
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			o0\u3000\u3000\u3000\u3000\u3002\u3002.O0Oo_o_._O0o_O.(this.o0oO_00.0_O.(), "", null);
			if (this.o0oO_00.0_O.().Nodes.Count > 0)
			{
				this.o0oO_00.0_O.().SelectedNode = this.o0oO_00.0_O.().Nodes[0];
				this.o0oO_00.0_O.().Select();
			}
			this.o0oO_00.0_O.().ExpandAll();
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00053063 File Offset: 0x00051263
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0005306C File Offset: 0x0005126C
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
				this.o0oO_00.0_O.();
				IL_0F:
				num2 = 3;
				Catalog catalog = new CatalogClass();
				IL_17:
				num2 = 4;
				Table table = new TableClass();
				IL_20:
				num2 = 5;
				Index index = new IndexClass();
				IL_29:
				num2 = 6;
				new SaveFileDialog();
				IL_31:
				num2 = 7;
				if (!OO_00oOO.FileSys.FileExists(this.O0_0oo.o0oooOo.))
				{
					goto IL_57;
				}
				IL_45:
				num2 = 8;
				OO_00oOO.FileSys.DeleteFile(this.O0_0oo.o0oooOo.);
				IL_57:
				num2 = 9;
				catalog.Create(Oo00.o00.0OO.(this.O0_0oo.o0oooOo.));
				IL_6C:
				num2 = 10;
				table = new TableClass();
				IL_76:
				num2 = 11;
				index = new IndexClass();
				IL_80:
				num2 = 12;
				table.Name = "Functions";
				IL_8F:
				num2 = 13;
				table.Columns.Append("Path", ADOX.DataTypeEnum.adVarWChar, 64);
				IL_AA:
				num2 = 14;
				table.Columns.Append("Name", ADOX.DataTypeEnum.adVarWChar, 64);
				IL_C5:
				num2 = 15;
				table.Columns.Append("Code", ADOX.DataTypeEnum.adLongVarWChar, 0);
				IL_DF:
				num2 = 16;
				table.Columns.Append("Type", ADOX.DataTypeEnum.adUnsignedTinyInt, 0);
				IL_F6:
				num2 = 17;
				table.Columns.Append("srt", ADOX.DataTypeEnum.adInteger, 0);
				IL_10C:
				num2 = 18;
				table.Columns["Code"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_126:
				num2 = 19;
				table.Columns["srt"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_140:
				num2 = 20;
				table.Columns["Path"].Attributes = ColumnAttributesEnum.adColNullable;
				IL_15A:
				num2 = 21;
				index.Name = "PrimaryKey";
				IL_169:
				num2 = 22;
				index.Columns.Append("Name", ADOX.DataTypeEnum.adVarWChar, 0);
				IL_183:
				num2 = 23;
				index.Columns.Append("Type", ADOX.DataTypeEnum.adVarWChar, 0);
				IL_19D:
				num2 = 24;
				index.PrimaryKey = true;
				IL_1A8:
				num2 = 25;
				index.Unique = true;
				IL_1B3:
				num2 = 26;
				table.Indexes.Append(index, RuntimeHelpers.GetObjectValue(Missing.Value));
				IL_1CE:
				num2 = 27;
				catalog.Tables.Append(table);
				IL_1DE:
				num2 = 28;
				((Connection)catalog.ActiveConnection).Close();
				IL_1F1:
				num2 = 29;
				catalog = null;
				IL_1F6:
				num2 = 30;
				OleDbConnection selectConnection = new OleDbConnection(Oo00.o_._0OOo.(this.O0_0oo.o0oooOo.));
				IL_20B:
				num2 = 31;
				OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("Select * From [Functions]", selectConnection);
				IL_21C:
				num2 = 32;
				DataTable dataTable = new DataTable();
				IL_226:
				num2 = 33;
				oleDbDataAdapter.FillSchema(dataTable, SchemaType.Source);
				IL_234:
				num2 = 34;
				o_O_o_oOoo__.OO_O0oO0.oooO_.(oleDbDataAdapter);
				IL_23E:
				num2 = 35;
				List<TreeNode> list = new List<TreeNode>();
				IL_248:
				num2 = 36;
				o_O_o_oOoo__.oo.O0o0o.(this.o0oO_00.0_O.().Nodes, list);
				IL_25D:
				num2 = 37;
				List<TreeNode>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = enumerator.Current;
					IL_277:
					num2 = 38;
					if (treeNode.Checked || this.O0_0oo.o0oooOo..Contains(treeNode))
					{
						IL_295:
						num2 = 39;
						if (treeNode.Tag != null)
						{
							IL_2A4:
							num2 = 40;
							DataRow dataRow = (DataRow)treeNode.Tag;
							IL_2B5:
							num2 = 41;
							DataRow dataRow2 = dataTable.NewRow();
							IL_2C1:
							num2 = 42;
							dataRow2["Path"] = RuntimeHelpers.GetObjectValue(dataRow["Path"]);
							IL_2E1:
							num2 = 43;
							dataRow2["Name"] = RuntimeHelpers.GetObjectValue(dataRow["Name"]);
							IL_301:
							num2 = 44;
							dataRow2["srt"] = RuntimeHelpers.GetObjectValue(dataRow["srt"]);
							IL_321:
							num2 = 45;
							dataRow2["Type"] = RuntimeHelpers.GetObjectValue(dataRow["Type"]);
							IL_341:
							num2 = 46;
							if (!dataRow.IsNull("Config"))
							{
								IL_352:
								num2 = 47;
								dataRow2["code"] = O_O0OO.OoO_00._.(dataRow["Config"].ToString());
							}
							IL_377:
							num2 = 48;
							dataTable.Rows.Add(dataRow2);
						}
					}
					IL_388:
					num2 = 49;
				}
				IL_397:
				num2 = 50;
				((IDisposable)enumerator).Dispose();
				IL_3A7:
				num2 = 51;
				oleDbDataAdapter.Update(dataTable);
				IL_3B4:
				num2 = 52;
				base.Close();
				IL_3BD:
				goto IL_4E3;
				IL_3C2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_4A4:
				goto IL_4D8;
				IL_4A6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4B6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4A6;
			}
			IL_4D8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4E3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00053580 File Offset: 0x00051780
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00053594 File Offset: 0x00051794
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			List<TreeNode> list = o_O_o_oOoo__.OO_O0oO0.oooO_.(this.o0oO_00.0_O.());
			try
			{
				foreach (TreeNode treeNode in list)
				{
					treeNode.Checked = this.o_00_.oO0oo__0.().Checked;
				}
			}
			finally
			{
				List<TreeNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000535F8 File Offset: 0x000517F8
		private void <<EMPTY_NAME>>(object A_0, TreeViewEventArgs A_1)
		{
			if (A_1.Action != TreeViewAction.Unknown)
			{
				List<TreeNode> list = new List<TreeNode>();
				o_O_o_oOoo__.oo.O0o0o.(A_1.Node.Nodes, list);
				try
				{
					foreach (TreeNode treeNode in list)
					{
						treeNode.Checked = A_1.Node.Checked;
					}
				}
				finally
				{
					List<TreeNode>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00053670 File Offset: 0x00051870
		private void <<EMPTY_NAME>>()
		{
			this.O0_0oo.o0oooOo..Clear();
			List<TreeNode> list = new List<TreeNode>();
			o_O_o_oOoo__.oo.O0o0o.(this.o0oO_00.0_O.().Nodes, list);
			try
			{
				foreach (TreeNode treeNode in list)
				{
					if (treeNode.Nodes.Count == 0 && treeNode.Checked && (treeNode.Tag == null || Conversions.ToInteger(((DataRow)treeNode.Tag)["Type"]) == 9))
					{
						for (TreeNode parent = treeNode.Parent; parent != null; parent = parent.Parent)
						{
							if (!parent.Checked)
							{
								this.O0_0oo.o0oooOo..Add(parent);
							}
						}
					}
				}
			}
			finally
			{
				List<TreeNode>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0005373C File Offset: 0x0005193C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.o0oO_00.0_O.().SelectedNode != null)
			{
				this.o0oO_00.0_O.().SelectedNode.EnsureVisible();
			}
		}

		// Token: 0x040003A8 RID: 936
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040003A9 RID: 937
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003AA RID: 938
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040003AB RID: 939
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040003AC RID: 940
		[CompilerGenerated]
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x040003AD RID: 941
		[CompilerGenerated]
		private ImageList <<EMPTY_NAME>>;

		// Token: 0x040003AE RID: 942
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x040003AF RID: 943
		private DataView <<EMPTY_NAME>>;

		// Token: 0x040003B0 RID: 944
		private string <<EMPTY_NAME>>;

		// Token: 0x040003B1 RID: 945
		private HashSet<TreeNode> <<EMPTY_NAME>>;
	}
}
