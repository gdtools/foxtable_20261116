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
	// Token: 0x02000183 RID: 387
	[DesignerGenerated]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public partial class o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000 : Form
	{
		// Token: 0x0600126A RID: 4714 RVA: 0x000814AC File Offset: 0x0007F6AC
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o_Ooo._. != null)
				{
					this.o_Ooo._..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000814EC File Offset: 0x0007F6EC
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.o_Ooo._.(new GroupBox());
			this.o_Ooo._.(new LinkLabel());
			this.o_Ooo._.(new C1ComboBox());
			this.O.OoO_.().SuspendLayout();
			base.SuspendLayout();
			this.O.OoO_.().Anchor = AnchorStyles.None;
			this.O.OoO_.().Controls.Add(this.O.OoO_.());
			this.O.OoO_.().Controls.Add(this.O.OoO_.());
			this.O.OoO_.().Location = new Point(183, 149);
			this.O.OoO_.().Name = "GroupBox1";
			this.O.OoO_.().Size = new Size(269, 99);
			this.O.OoO_.().TabIndex = 3;
			this.O.OoO_.().TabStop = false;
			this.O.OoO_.().Text = "快捷菜单测试";
			this.O.OoO_.().AutoSize = true;
			this.O.OoO_.().Location = new Point(54, 67);
			this.O.OoO_.().Name = "LinkLabel1";
			this.O.OoO_.().Size = new Size(161, 12);
			this.O.OoO_.().TabIndex = 1;
			this.O.OoO_.().TabStop = true;
			this.O.OoO_.().Text = "右击此处测试选定的快捷菜单";
			this.O.OoO_.().DropDownStyle = DropDownStyle.DropDownList;
			this.O.OoO_.().Location = new Point(52, 27);
			this.O.OoO_.().Name = "ContextMenuList";
			this.O.OoO_.().Size = new Size(165, 20);
			this.O.OoO_.().TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(635, 435);
			base.Controls.Add(this.O.OoO_.());
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o..o.O.0";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "窗口菜单预览";
			this.O.OoO_.().ResumeLayout(false);
			this.O.OoO_.().PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00081727 File Offset: 0x0007F927
		[CompilerGenerated]
		internal virtual GroupBox <<EMPTY_NAME>>()
		{
			return this.o_Ooo._.;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0008172F File Offset: 0x0007F92F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(GroupBox A_0)
		{
			this.o_Ooo._. = A_0;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00081738 File Offset: 0x0007F938
		[CompilerGenerated]
		internal virtual LinkLabel <<EMPTY_NAME>>()
		{
			return this.o_Ooo._.;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00081740 File Offset: 0x0007F940
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(LinkLabel A_0)
		{
			this.o_Ooo._. = A_0;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00081749 File Offset: 0x0007F949
		[CompilerGenerated]
		internal virtual C1ComboBox <<EMPTY_NAME>>()
		{
			return this.o_Ooo._.;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00081754 File Offset: 0x0007F954
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1ComboBox A_0)
		{
			EventHandler value = new EventHandler(this.O.OoO_.);
			C1ComboBox c1ComboBox = this.o_Ooo._.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged -= value;
			}
			this.o_Ooo._. = A_0;
			c1ComboBox = this.o_Ooo._.;
			if (c1ComboBox != null)
			{
				c1ComboBox.SelectedIndexChanged += value;
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00081798 File Offset: 0x0007F998
		public o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000()
		{
			base.FormClosed += this.O.OoO_.;
			this.OO00O.0O0O0o. = new Dictionary<string, ToolStrip>();
			this.o_Ooo._. = "(default)";
			this.o_Ooo._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x000817F0 File Offset: 0x0007F9F0
		internal void <<EMPTY_NAME>>(string A_0)
		{
			OO_ oo_ = new OO_(A_0, null);
			oo_.O_oOoo._o_oo. = this.o_Ooo._.;
			oo_.o.__o_O.();
			this.OO00O.0O0O0o. = oo_.o.__o_O.;
			List<string> list = new List<string>();
			list.AddRange(this.OO00O.0O0O0o..Keys);
			for (int i = list.Count - 1; i >= 0; i += -1)
			{
				ToolStrip toolStrip = this.OO00O.0O0O0o.[list[i]];
				if (toolStrip is ContextMenuStrip)
				{
					this.O.OoO_.().Items.Add(list[i]);
				}
				else
				{
					base.Controls.Add(toolStrip);
				}
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0008188E File Offset: 0x0007FA8E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O.OoO_.().ContextMenuStrip = (ContextMenuStrip)this.OO00O.0O0O0o.[this.O.OoO_.().SelectedItem.ToString()];
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000818BB File Offset: 0x0007FABB
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04000708 RID: 1800
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x04000709 RID: 1801
		[CompilerGenerated]
		private GroupBox <<EMPTY_NAME>>;

		// Token: 0x0400070A RID: 1802
		[CompilerGenerated]
		private LinkLabel <<EMPTY_NAME>>;

		// Token: 0x0400070B RID: 1803
		[CompilerGenerated]
		private C1ComboBox <<EMPTY_NAME>>;

		// Token: 0x0400070C RID: 1804
		private Dictionary<string, ToolStrip> <<EMPTY_NAME>>;

		// Token: 0x0400070D RID: 1805
		internal string <<EMPTY_NAME>>;
	}
}
