using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace Foxtable
{
	// Token: 0x02000373 RID: 883
	[DesignerGenerated]
	internal partial class O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002 : Form
	{
		// Token: 0x06003872 RID: 14450 RVA: 0x00192084 File Offset: 0x00190284
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			try
			{
				if (A_0 && this.oO0._oO. != null)
				{
					this.oO0._oO..Dispose();
				}
			}
			finally
			{
				base.Dispose(A_0);
			}
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x001920C4 File Offset: 0x001902C4
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.oo0OO00.o0O.(new C1TextBox());
			this.o._O0_0_oo0oo.(new C1TextBox());
			this.O__._0__o0.(new C1CheckBox());
			this.o00_O.O0oO_00.(new Label());
			this.o00_O.O0oO_00.(new C1Button());
			this.o._O0_0_oo0oo.(new Label());
			this.o0OO_0_o.0oOO.(new C1Button());
			this.O__._0__o0.(new C1Button());
			this.o.o_0__.(new Label());
			this.O__._0__o0.(new FolderBrowserDialog());
			base.SuspendLayout();
			this.OO00o_._O_00.().Location = new Point(14, 77);
			this.OO00o_._O_00.().Name = "txtFolder";
			this.OO00o_._O_00.().ReadOnly = true;
			this.OO00o_._O_00.().Size = new Size(425, 21);
			this.OO00o_._O_00.().TabIndex = 1;
			this.o00_O.O0oO_00.().Location = new Point(14, 28);
			this.o00_O.O0oO_00.().Name = "txtName";
			this.o00_O.O0oO_00.().Size = new Size(425, 21);
			this.o00_O.O0oO_00.().TabIndex = 0;
			this.OO00o_._O_00.().AutoCheck = false;
			this.OO00o_._O_00.().AutoSize = true;
			this.OO00o_._O_00.().Checked = true;
			this.OO00o_._O_00.().CheckState = CheckState.Checked;
			this.OO00o_._O_00.().Location = new Point(14, 115);
			this.OO00o_._O_00.().Name = "chkCreateFolder";
			this.OO00o_._O_00.().Size = new Size(108, 16);
			this.OO00o_._O_00.().TabIndex = 3;
			this.OO00o_._O_00.().Text = "创建专用文件夹";
			this.OO00o_._O_00.().UseVisualStyleBackColor = true;
			this.OO00o_._O_00.().AutoSize = true;
			this.OO00o_._O_00.().Location = new Point(14, 13);
			this.OO00o_._O_00.().Name = "Label1";
			this.OO00o_._O_00.().Size = new Size(59, 12);
			this.OO00o_._O_00.().TabIndex = 9;
			this.OO00o_._O_00.().Text = "项目名称:";
			this.OO00o_._O_00.().Location = new Point(443, 75);
			this.OO00o_._O_00.().Name = "btnFolderBrowser";
			this.OO00o_._O_00.().Size = new Size(65, 23);
			this.OO00o_._O_00.().TabIndex = 2;
			this.OO00o_._O_00.().Text = "浏览(B)";
			this.OO00o_._O_00.().UseVisualStyleBackColor = true;
			this.o.OOoo_.().AutoSize = true;
			this.o.OOoo_.().Location = new Point(14, 62);
			this.o.OOoo_.().Name = "Label2";
			this.o.OOoo_.().Size = new Size(59, 12);
			this.o.OOoo_.().TabIndex = 11;
			this.o.OOoo_.().Text = "项目位置:";
			this.OO_o___O.0.().DialogResult = DialogResult.Cancel;
			this.OO_o___O.0.().Location = new Point(265, 240);
			this.OO_o___O.0.().Name = "btnCancel";
			this.OO_o___O.0.().Size = new Size(75, 23);
			this.OO_o___O.0.().TabIndex = 6;
			this.OO_o___O.0.().Text = "取消(&X)";
			this.OO_o___O.0.().UseVisualStyleBackColor = true;
			this.o.OOoo_.().Location = new Point(184, 240);
			this.o.OOoo_.().Name = "btnOK";
			this.o.OOoo_.().Size = new Size(75, 23);
			this.o.OOoo_.().TabIndex = 5;
			this.o.OOoo_.().Text = "确定(&O)";
			this.o.OOoo_.().UseVisualStyleBackColor = true;
			this.OO_o___O.0.().Location = new Point(14, 159);
			this.OO_o___O.0.().Name = "lblDescription";
			this.OO_o___O.0.().Size = new Size(496, 52);
			this.OO_o___O.0.().TabIndex = 4;
			this.OO_o___O.0.().Text = "提示:";
			this.OO00o_._O_00.().Description = "系统位置";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(525, 276);
			base.Controls.Add(this.OO_o___O.0.());
			base.Controls.Add(this.o.OOoo_.());
			base.Controls.Add(this.OO00o_._O_00.());
			base.Controls.Add(this.o00_O.O0oO_00.());
			base.Controls.Add(this.OO00o_._O_00.());
			base.Controls.Add(this.OO00o_._O_00.());
			base.Controls.Add(this.OO00o_._O_00.());
			base.Controls.Add(this.o.OOoo_.());
			base.Controls.Add(this.OO_o___O.0.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o.OO....";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "另存为";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x001925ED File Offset: 0x001907ED
		[CompilerGenerated]
		public virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.oO0._oO.;
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x001925F5 File Offset: 0x001907F5
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			this.oO0._oO. = A_0;
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x001925FE File Offset: 0x001907FE
		[CompilerGenerated]
		public virtual C1TextBox <<EMPTY_NAME>>()
		{
			return this.OO_OooO0._0O0.;
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x00192608 File Offset: 0x00190808
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1TextBox A_0)
		{
			KeyPressEventHandler value = new KeyPressEventHandler(this.o._O0_0_oo0oo.);
			EventHandler value2 = new EventHandler(this.o.o_0__.);
			CancelEventHandler value3 = new CancelEventHandler(this.o._O0_0_oo0oo.);
			C1TextBox oo_OooO0._0O0. = this.OO_OooO0._0O0.;
			if (oo_OooO0._0O0. != null)
			{
				oo_OooO0._0O0..KeyPress -= value;
				oo_OooO0._0O0..TextChanged -= value2;
				oo_OooO0._0O0..Validating -= value3;
			}
			this.OO_OooO0._0O0. = A_0;
			oo_OooO0._0O0. = this.OO_OooO0._0O0.;
			if (oo_OooO0._0O0. != null)
			{
				oo_OooO0._0O0..KeyPress += value;
				oo_OooO0._0O0..TextChanged += value2;
				oo_OooO0._0O0..Validating += value3;
			}
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x00192681 File Offset: 0x00190881
		[CompilerGenerated]
		public virtual C1CheckBox <<EMPTY_NAME>>()
		{
			return this.oO0._oO.;
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00192689 File Offset: 0x00190889
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void <<EMPTY_NAME>>(C1CheckBox A_0)
		{
			this.oO0._oO. = A_0;
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00192692 File Offset: 0x00190892
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oO0._oO.;
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x0019269A File Offset: 0x0019089A
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oO0._oO. = A_0;
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x001926A3 File Offset: 0x001908A3
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o._O0_0_oo0oo.;
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x001926AC File Offset: 0x001908AC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_o_o0OO_0.o.);
			C1Button c1Button = this.o._O0_0_oo0oo.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o._O0_0_oo0oo. = A_0;
			c1Button = this.o._O0_0_oo0oo.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x0600387E RID: 14462 RVA: 0x001926EF File Offset: 0x001908EF
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.OO_OooO0._0O0.;
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x001926F7 File Offset: 0x001908F7
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.OO_OooO0._0O0. = A_0;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00192700 File Offset: 0x00190900
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oo0OO00.o0O.;
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00192708 File Offset: 0x00190908
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			this.oo0OO00.o0O. = A_0;
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00192711 File Offset: 0x00190911
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.o.o_0__.;
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x0019271C File Offset: 0x0019091C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_o00.o0O0o.);
			C1Button c1Button = this.o.o_0__.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.o.o_0__. = A_0;
			c1Button = this.o.o_0__.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x0019275F File Offset: 0x0019095F
		[CompilerGenerated]
		internal virtual Label <<EMPTY_NAME>>()
		{
			return this.oooo.O_O0O_0O0.;
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00192767 File Offset: 0x00190967
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(Label A_0)
		{
			this.oooo.O_O0O_0O0. = A_0;
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00192770 File Offset: 0x00190970
		[CompilerGenerated]
		internal virtual FolderBrowserDialog <<EMPTY_NAME>>()
		{
			return this.oO0._oO.;
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00192778 File Offset: 0x00190978
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(FolderBrowserDialog A_0)
		{
			this.oO0._oO. = A_0;
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x00192784 File Offset: 0x00190984
		public O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002()
		{
			base.Load += this.OO00o_._O_00.;
			base.FormClosed += this.O_0.ooO0O.;
			this.o00_O.O0oO_00.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x001927D6 File Offset: 0x001909D6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.OO00o_._O_00.().ShowDialog() == DialogResult.OK)
			{
				this.OO00o_._O_00.().Value = this.OO00o_._O_00.().SelectedPath;
				this.O__._0__o0.();
				this.o0OO_0_o.0oOO.();
			}
		}

		// Token: 0x0600388A RID: 14474 RVA: 0x00192808 File Offset: 0x00190A08
		private void <<EMPTY_NAME>>()
		{
			int num = 0;
			try
			{
				foreach (string text in c.OOOOO.o.().FileSystem.GetDirectories(this.OO00o_._O_00.().Text, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, new string[]
				{
					"管理项目*"
				}))
				{
					if (Versioned.IsNumeric(text.Substring(text.LastIndexOf("\\") + "管理项目".Length + 1)))
					{
						num = Convert.ToInt32(Math.Max((double)num, Conversion.Val(text.Substring(text.LastIndexOf("\\") + "管理项目".Length + 1))));
					}
				}
			}
			finally
			{
				IEnumerator<string> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.oO0._oO. = "管理项目" + Conversions.ToString(num + 1);
			this.o00_O.O0oO_00.().Value = this.oO0._oO.;
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x001928F4 File Offset: 0x00190AF4
		public void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.OO00o_._O_00.().Text, "", true) == 0 | Operators.CompareString(this.o00_O.O0oO_00.().Text, "", true) == 0)
			{
				this.OO_o___O.0.().Text = "";
				return;
			}
			if (!this.OO00o_._O_00.().Text.EndsWith("\\"))
			{
				this.OO00o_._O_00.().Value = this.OO00o_._O_00.().Text + "\\";
			}
			this.OO_o___O.0.().Text = string.Concat(new string[]
			{
				"将创建: ",
				this.OO00o_._O_00.().Text,
				this.o00_O.O0oO_00.().Text,
				"\\",
				this.o00_O.O0oO_00.().Text,
				ooO0__OO.oo.Ooo_00.()
			});
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x001929D6 File Offset: 0x00190BD6
		private void <<EMPTY_NAME>>(object A_0, KeyPressEventArgs A_1)
		{
			if (A_1.KeyChar == '.')
			{
				A_1.Handled = true;
			}
		}

		// Token: 0x0600388D RID: 14477 RVA: 0x001929E9 File Offset: 0x00190BE9
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.o0OO_0_o.0oOO.();
		}

		// Token: 0x0600388E RID: 14478 RVA: 0x001929F4 File Offset: 0x00190BF4
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
				string text = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.ProjectFile);
				IL_1E:
				num2 = 3;
				string text2 = this.OO00o_._O_00.().Text + this.o00_O.O0oO_00.().Text + "\\";
				IL_42:
				num2 = 4;
				this.OO00o_._O_00.().Value = this.OO00o_._O_00.().Text.Trim();
				IL_5F:
				num2 = 5;
				this.o00_O.O0oO_00.().Text = this.o00_O.O0oO_00.().Text.Trim();
				IL_7C:
				num2 = 6;
				if (text.EndsWith("\\"))
				{
					goto IL_99;
				}
				IL_8B:
				num2 = 7;
				text += "\\";
				IL_99:
				num2 = 8;
				if (!(Operators.CompareString(this.OO00o_._O_00.().Text, "", true) == 0 | Operators.CompareString(this.o00_O.O0oO_00.().Text, "", true) == 0))
				{
					goto IL_EB;
				}
				IL_D0:
				num2 = 9;
				MessageBox.Show("请输入项目名称和位置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				goto IL_4FC;
				IL_EB:
				num2 = 11;
				if (Operators.CompareString(text.ToLower(), text2.ToLower(), true) != 0)
				{
					goto IL_150;
				}
				IL_103:
				num2 = 12;
				if (Operators.CompareString((this.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.()).ToLower(), c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile).ToLower(), true) != 0)
				{
					goto IL_150;
				}
				IL_141:
				num2 = 13;
				base.DialogResult = DialogResult.OK;
				goto IL_4FC;
				IL_150:
				num2 = 15;
				if (!c.OOOOO.o.().FileSystem.DirectoryExists(text2))
				{
					goto IL_1A1;
				}
				IL_166:
				num2 = 16;
				if (MessageBox.Show("文件夹 " + this.OO00o_._O_00.().Text + this.o00_O.O0oO_00.().Text + " 已经存在，是否覆盖？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					goto IL_4FC;
				}
				IL_1A1:
				num2 = 18;
				this.Cursor = Cursors.WaitCursor;
				IL_1AF:
				num2 = 19;
				if (c.OOOOO.o.().FileSystem.DirectoryExists(text2))
				{
					goto IL_1D9;
				}
				IL_1C5:
				num2 = 20;
				c.OOOOO.o.().FileSystem.CreateDirectory(text2);
				IL_1D9:
				num2 = 21;
				if (!c.OOOOO.o.().FileSystem.FileExists(text2 + this.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.()))
				{
					goto IL_22D;
				}
				IL_204:
				num2 = 22;
				c.OOOOO.o.().FileSystem.DeleteFile(text2 + this.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.());
				IL_22D:
				num2 = 23;
				if (Operators.CompareString(text, text2, true) == 0)
				{
					goto IL_3F4;
				}
				IL_23E:
				num2 = 24;
				string[] array = OO_00oOO.ProjectPath.Split(new char[]
				{
					'\\',
					':'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_25E:
				num2 = 25;
				if (Operators.CompareString(Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile), array[array.Length - 1], true) != 0 || Path.GetFileNameWithoutExtension(OO_00oOO.ProjectFile).Length <= 1)
				{
					goto IL_2EB;
				}
				IL_28E:
				num2 = 26;
				c.OOOOO.o.().FileSystem.CopyDirectory(text, text2, true);
				IL_2A4:
				num2 = 27;
				c.OOOOO.o.().FileSystem.RenameFile(text2 + c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile), this.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.());
				goto IL_3F4;
				IL_2EB:
				num2 = 29;
				c.OOOOO.o.().FileSystem.CopyFile(OO_00oOO.ProjectFile, text2 + this.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.());
				IL_319:
				num2 = 30;
				if (!c.OOOOO.o.().FileSystem.DirectoryExists(text + "Images\\"))
				{
					goto IL_362;
				}
				IL_338:
				num2 = 31;
				c.OOOOO.o.().FileSystem.CopyDirectory(text + "Images\\", text2 + "Images\\", true);
				IL_362:
				num2 = 32;
				if (!c.OOOOO.o.().FileSystem.DirectoryExists(text + "Attachments\\"))
				{
					goto IL_3AB;
				}
				IL_381:
				num2 = 33;
				c.OOOOO.o.().FileSystem.CopyDirectory(text + "Attachments\\", text2 + "Attachments\\", true);
				IL_3AB:
				num2 = 34;
				if (!c.OOOOO.o.().FileSystem.DirectoryExists(text + "Bin\\"))
				{
					goto IL_3F4;
				}
				IL_3CA:
				num2 = 35;
				c.OOOOO.o.().FileSystem.CopyDirectory(text + "Bin\\", text2 + "Bin\\", true);
				IL_3F4:
				num2 = 36;
				OO_00oOO.ProjectFile = text2 + this.o00_O.O0oO_00.().Text + ooO0__OO.oo.Ooo_00.();
				IL_413:
				num2 = 37;
				O_O0OO.OOo_o.0o. = c.OOOOO.o.().FileSystem.GetParentPath(OO_00oOO.ProjectFile) + "\\Images\\";
				IL_439:
				num2 = 38;
				OleDbConnectionStringBuilder oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder(O_O0OO.OoO.0OO__0ooo.().ConnectionString);
				IL_44D:
				num2 = 39;
				oleDbConnectionStringBuilder.DataSource = OO_00oOO.ProjectFile;
				IL_45C:
				num2 = 40;
				O_O0OO.OoO.0OO__0ooo.().ConnectionString = oleDbConnectionStringBuilder.ConnectionString;
				IL_470:
				num2 = 41;
				O_O0OO.O0_00o.o0__o..O_O_.o.(true, false);
				IL_47F:
				num2 = 42;
				OO_00oOO.DataTables.Save();
				IL_48D:
				num2 = 43;
				if (!O_O0OO.o_Oo0_oOo.0.)
				{
					goto IL_4D1;
				}
				IL_497:
				num2 = 44;
				Main.OO_O.o..Text = Main.OO_O.o..O.OOO0_OOo.().Text + " - " + c.OOOOO.o.().FileSystem.GetName(OO_00oOO.ProjectFile);
				IL_4D1:
				num2 = 45;
				Main.OO_O.o..O.OOO0_OOo.().Path = OO_00oOO.ProjectPath + "Bin\\";
				IL_4F2:
				num2 = 46;
				base.DialogResult = DialogResult.OK;
				IL_4FC:
				goto IL_60A;
				IL_501:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_5CB:
				goto IL_5FF;
				IL_5CD:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_5DD:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5CD;
			}
			IL_5FF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_60A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600388F RID: 14479 RVA: 0x00193030 File Offset: 0x00191230
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.OO00o_._O_00.().RootFolder = Environment.SpecialFolder.MyComputer;
			this.OO00o_._O_00.().Value = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Foxtable项目";
			this.O__._0__o0.();
			if (Operators.CompareString(OO_00oOO.ProjectFile, O_O0OO.o0OoO00OO.00O., true) == 0)
			{
				this.Text = "保存";
			}
		}

		// Token: 0x06003890 RID: 14480 RVA: 0x00193088 File Offset: 0x00191288
		private void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			if (Operators.CompareString(this.o00_O.O0oO_00.().Text, "", true) > 0 && this.o00_O.O0oO_00.().Text.IndexOf(".") >= 0)
			{
				this.o00_O.O0oO_00.().Value = this.o00_O.O0oO_00.().Text.Replace(".", "");
			}
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x001930EB File Offset: 0x001912EB
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x04001719 RID: 5913
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x0400171A RID: 5914
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400171B RID: 5915
		[CompilerGenerated]
		private C1TextBox <<EMPTY_NAME>>;

		// Token: 0x0400171C RID: 5916
		[CompilerGenerated]
		private C1CheckBox <<EMPTY_NAME>>;

		// Token: 0x0400171D RID: 5917
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x0400171E RID: 5918
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x0400171F RID: 5919
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001720 RID: 5920
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001721 RID: 5921
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x04001722 RID: 5922
		[CompilerGenerated]
		private Label <<EMPTY_NAME>>;

		// Token: 0x04001723 RID: 5923
		[CompilerGenerated]
		private FolderBrowserDialog <<EMPTY_NAME>>;

		// Token: 0x04001724 RID: 5924
		private string <<EMPTY_NAME>>;

		// Token: 0x04001725 RID: 5925
		private const string <<EMPTY_NAME>> = "管理项目";
	}
}
