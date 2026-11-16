using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.C1Gauge;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000145 RID: 325
	[DesignerGenerated]
	internal class O_O_OO : UserControl
	{
		// Token: 0x06001023 RID: 4131 RVA: 0x0007D031 File Offset: 0x0007B231
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.OO00_.oo. != null)
			{
				this.OO00_.oo..Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0007D050 File Offset: 0x0007B250
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "GaugesOperator";
			base.Size = new Size(9, 9);
			base.ResumeLayout(false);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0007D0A0 File Offset: 0x0007B2A0
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.OO00_.oo.;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0007D0A8 File Offset: 0x0007B2A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.OO00_.oo. = A_0;
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0007D0B4 File Offset: 0x0007B2B4
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.OO00_.oo.;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0007D0C8 File Offset: 0x0007B2C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.Ooo0o._.);
				ToolStripMenuItem oo00_.oo. = this.OO00_.oo.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (oo00_.oo. != null)
						{
							num = 3;
							continue;
						}
						return;
					case 1:
						goto IL_62;
					case 2:
						oo00_.oo..Click -= value;
						num = 1;
						continue;
					case 3:
						oo00_.oo..Click += value;
						num = 5;
						continue;
					case 4:
						if (true)
						{
						}
						if (oo00_.oo. != null)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					case 5:
						return;
					}
					break;
					IL_62:
					this.OO00_.oo. = A_0;
					oo00_.oo. = this.OO00_.oo.;
					num = 0;
				}
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0007D174 File Offset: 0x0007B374
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oO.o00_OO_0_oO.;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0007D188 File Offset: 0x0007B388
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O0__._0o.);
				ToolStripMenuItem toolStripMenuItem = this.oO.o00_OO_0_oO.;
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_62;
					case 1:
						toolStripMenuItem.Click += value;
						num = 4;
						continue;
					case 2:
						if (toolStripMenuItem != null)
						{
							if (true)
							{
							}
							num = 5;
							continue;
						}
						goto IL_62;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						toolStripMenuItem.Click -= value;
						num = 0;
						continue;
					}
					break;
					IL_62:
					this.oO.o00_OO_0_oO. = A_0;
					toolStripMenuItem = this.oO.o00_OO_0_oO.;
					num = 3;
				}
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0007D234 File Offset: 0x0007B434
		public O_O_OO()
		{
			base.MouseDown += this.O0__._0o.;
			base.ParentChanged += this.O00O.ooo0.;
			this.O0__._0o.();
			this.OO00_.oo.(new ContextMenuStrip());
			this.oO.o00_OO_0_oO.(new ToolStripMenuItem("保存为模板(&S)..."));
			this.O0__._0o.(new ToolStripMenuItem("从模板生成(&L)..."));
			this.O0__._0o.().Items.AddRange(new ToolStripItem[]
			{
				this.Ooo0o._.(),
				this.O0__._0o.()
			});
			this.BackgroundImage = OO_00oOO.GetImage("Operator.ico");
			this.BackgroundImageLayout = ImageLayout.Center;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0007D2DB File Offset: 0x0007B4DB
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			this.O0__._0o.().Show(this, A_1.X, A_1.Y);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0007D2F8 File Offset: 0x0007B4F8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Location = new Point(base.Parent.Width - base.Width - 4, base.Parent.Height - base.Height - 4);
			this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BackColor = ((ControlHolder)base.Parent).ChildControl.BackColor;
			base.BringToFront();
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0007D364 File Offset: 0x0007B564
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "仪表模板|*.gauge.xml";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				C1Gauge c1Gauge = (C1Gauge)((ControlHolder)base.Parent).ChildControl;
				MemoryStream memoryStream = new MemoryStream();
				c1Gauge.Save(memoryStream, Encoding.UTF8);
				string @string = Encoding.UTF8.GetString(memoryStream.ToArray(), 3, (int)memoryStream.Length - 3);
				memoryStream.Dispose();
				OO_00oOO.FileSys.WriteAllText(saveFileDialog.FileName, Regex.Replace(@string, "\\sviewTag=\"\\w+\"", ""), false);
			}
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0007D3F8 File Offset: 0x0007B5F8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "仪表模板|*.gauge.xml";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				((C1Gauge)((ControlHolder)base.Parent).ChildControl).Load(openFileDialog.FileName);
			}
		}

		// Token: 0x04000646 RID: 1606
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000647 RID: 1607
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04000648 RID: 1608
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000649 RID: 1609
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;
	}
}
