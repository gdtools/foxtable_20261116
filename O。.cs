using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;
using MSDASC;

namespace Foxtable
{
	// Token: 0x02000352 RID: 850
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000 : Form
	{
		// Token: 0x06003432 RID: 13362 RVA: 0x001659E4 File Offset: 0x00163BE4
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.o.000000o. != null)
				{
					this.o.000000o..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00165A24 File Offset: 0x00163C24
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.OooOOOOO.O0O.(new Label());
			this.o_.o0O.(new C1Button());
			this.OO.o0O0OO.(new C1Button());
			this.O.__0____oo.(new C1Button());
			this.OO.o0O0OO.(new TextBox());
			this.OooOOOOO.O0O.(new C1Button());
			this.OO.o0O0OO.(new Label());
			this.OO.o0O0OO.(new C1CheckBox());
			base.SuspendLayout();
			this.OO._000_O0o_.().AutoSize = true;
			this.OO._000_O0o_.().Location = new Point(10, 16);
			this.OO._000_O0o_.().Name = "Label1";
			this.OO._000_O0o_.().Size = new Size(107, 12);
			this.OO._000_O0o_.().TabIndex = 11;
			this.OO._000_O0o_.().Text = "请修改连接字符串:";
			this.o_.__o.().DialogResult = DialogResult.Cancel;
			this.o_.__o.().Location = new Point(488, 282);
			this.o_.__o.().Name = "btnCancel";
			this.o_.__o.().Size = new Size(75, 23);
			this.o_.__o.().TabIndex = 10;
			this.o_.__o.().Text = "取消";
			this.o_.__o.().UseVisualStyleBackColor = true;
			this.OO._000_O0o_.().Location = new Point(407, 282);
			this.OO._000_O0o_.().Name = "btnOK";
			this.OO._000_O0o_.().Size = new Size(75, 23);
			this.OO._000_O0o_.().TabIndex = 9;
			this.OO._000_O0o_.().Text = "确定";
			this.OO._000_O0o_.().UseVisualStyleBackColor = true;
			this.OO_._o_o0_00.().Location = new Point(12, 282);
			this.OO_._o_o0_00.().Name = "btnCreator";
			this.OO_._o_o0_00.().Size = new Size(75, 23);
			this.OO_._o_o0_00.().TabIndex = 7;
			this.OO_._o_o0_00.().Text = "生成器";
			this.OO_._o_o0_00.().UseVisualStyleBackColor = true;
			this.OO._000_O0o_.().Location = new Point(12, 38);
			this.OO._000_O0o_.().Multiline = true;
			this.OO._000_O0o_.().Name = "TextBox1";
			this.OO._000_O0o_.().ScrollBars = ScrollBars.Vertical;
			this.OO._000_O0o_.().Size = new Size(551, 196);
			this.OO._000_O0o_.().TabIndex = 6;
			this.ooO._0_0O.().Location = new Point(93, 282);
			this.ooO._0_0O.().Name = "btnTest";
			this.ooO._0_0O.().Size = new Size(75, 23);
			this.ooO._0_0O.().TabIndex = 12;
			this.ooO._0_0O.().Text = "测试";
			this.ooO._0_0O.().UseVisualStyleBackColor = true;
			this.OO_._o_o0_00.().AutoSize = true;
			this.OO_._o_o0_00.().Location = new Point(10, 246);
			this.OO_._o_o0_00.().Name = "Label2";
			this.OO_._o_o0_00.().Size = new Size(413, 12);
			this.OO_._o_o0_00.().TabIndex = 13;
			this.OO_._o_o0_00.().Text = "提示：此处默认是临时修改，请在启动项目后，按常规操作修改链接字符串。";
			this.OO._000_O0o_.().AutoSize = true;
			this.OO._000_O0o_.().Location = new Point(488, 246);
			this.OO._000_O0o_.().Name = "CheckBox1";
			this.OO._000_O0o_.().Size = new Size(72, 16);
			this.OO._000_O0o_.().TabIndex = 14;
			this.OO._000_O0o_.().Text = "保存设置";
			this.OO._000_O0o_.().UseVisualStyleBackColor = true;
			this.OO._000_O0o_.().Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(577, 315);
			base.Controls.Add(this.OO._000_O0o_.());
			base.Controls.Add(this.OO_._o_o0_00.());
			base.Controls.Add(this.ooO._0_0O.());
			base.Controls.Add(this.OO._000_O0o_.());
			base.Controls.Add(this.o_.__o.());
			base.Controls.Add(this.OO._000_O0o_.());
			base.Controls.Add(this.OO_._o_o0_00.());
			base.Controls.Add(this.OO._000_O0o_.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "oo0.....";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "链接数据源";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00165EDF File Offset: 0x001640DF
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o.000000o.;
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00165EE7 File Offset: 0x001640E7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o.000000o. = A_0;
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00165EF0 File Offset: 0x001640F0
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.000000o.;
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x00165EF8 File Offset: 0x001640F8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.o.000000o. = A_0;
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00165F01 File Offset: 0x00164101
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o00O__.oO.;
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00165F0C File Offset: 0x0016410C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_ooo_0.0o_.);
			C1Button c1Button = this.o00O__.oO.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o00O__.oO. = A_0;
			c1Button = this.o00O__.oO.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00165F4F File Offset: 0x0016414F
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo0.0_oo.;
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00165F58 File Offset: 0x00164158
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.O00_.);
			C1Button oo0.0_oo. = this.Oo0.0_oo.;
			if (oo0.0_oo. != null)
			{
				oo0.0_oo..Click -= value;
			}
			this.Oo0.0_oo. = A_0;
			oo0.0_oo. = this.Oo0.0_oo.;
			if (oo0.0_oo. != null)
			{
				oo0.0_oo..Click += value;
			}
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00165F9B File Offset: 0x0016419B
		[CompilerGenerated]
		internal virtual TextBox <<EMPTY_NAME>>()
		{
			return this.o.000000o.;
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00165FA3 File Offset: 0x001641A3
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(TextBox A_0)
		{
			this.o.000000o. = A_0;
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x00165FAC File Offset: 0x001641AC
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o_0.0o__O.;
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00165FB4 File Offset: 0x001641B4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_o_.Oo0O0_.);
			C1Button c1Button = this.o_0.0o__O.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o_0.0o__O. = A_0;
			c1Button = this.o_0.0o__O.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00165FF7 File Offset: 0x001641F7
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.o00O__.oO.;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00165FFF File Offset: 0x001641FF
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.o00O__.oO. = A_0;
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00166008 File Offset: 0x00164208
		[CompilerGenerated]
		internal virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.o.000000o.;
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x00166010 File Offset: 0x00164210
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.o.000000o. = A_0;
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x0016601C File Offset: 0x0016421C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			Connection connection = new ConnectionClass();
			DataLinks dataLinks = new DataLinksClass();
			if (Operators.CompareString(this.OO._000_O0o_.().Text, "", true) > 0)
			{
				connection.ConnectionString = this.OO._000_O0o_.().Text;
			}
			else
			{
				connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;";
			}
			try
			{
				IDataSourceLocator dataSourceLocator = dataLinks;
				object obj = connection;
				if (dataSourceLocator.PromptEdit(ref obj) && Operators.CompareString(connection.ConnectionString, "Provider=Microsoft.Jet.OLEDB.4.0;", true) != 0)
				{
					this.OO._000_O0o_.().Text = connection.ConnectionString;
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x001660C8 File Offset: 0x001642C8
		private bool <<EMPTY_NAME>>(ref string A_0)
		{
			string text = this.OO._000_O0o_.().Text.Trim();
			bool result;
			if (Operators.CompareString(text, "", true) == 0)
			{
				result = false;
			}
			else
			{
				try
				{
					if (text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || text.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
					{
						return new O0O(text).OO._o_OO.();
					}
					OleDbConnection oleDbConnection = new OleDbConnection(this.OO._000_O0o_.().Text);
					oleDbConnection.Open();
					oleDbConnection.Close();
					return true;
				}
				catch (Exception ex)
				{
					A_0 = ex.Message;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x0016616C File Offset: 0x0016436C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string str = "";
			if (this.OO.o0O0OO.(ref str))
			{
				MessageBox.Show("链接测试成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show("链接测试失败！错误：\r\n" + str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x001661B8 File Offset: 0x001643B8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			string str = "";
			if (this.OO.o0O0OO.(ref str))
			{
				base.DialogResult = DialogResult.OK;
				return;
			}
			MessageBox.Show("链接无效！ 错误:\r\n" + str, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x001661F6 File Offset: 0x001643F6
		public O\u3002\u3000\u3000()
		{
			base.FormClosed += this.OO._000_O0o_.;
			this.OO.o0O0OO.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x0016622B File Offset: 0x0016442B
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x040014FB RID: 5371
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040014FC RID: 5372
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x040014FD RID: 5373
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014FE RID: 5374
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040014FF RID: 5375
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001500 RID: 5376
		[CompilerGenerated]
		private TextBox <<EMPTY_NAME>>;

		// Token: 0x04001501 RID: 5377
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001502 RID: 5378
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001503 RID: 5379
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;
	}
}
