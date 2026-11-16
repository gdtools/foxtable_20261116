using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Input;
using Foxtable.Syscmd;
using Foxtable.WinForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000395 RID: 917
	[DesignerGenerated]
	internal partial class O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000 : System.Windows.Forms.Form
	{
		// Token: 0x06003C19 RID: 15385 RVA: 0x001B4B36 File Offset: 0x001B2D36
		[DebuggerNonUserCode]
		protected virtual void <<EMPTY_NAME>>(bool A_0)
		{
			if (A_0 && this.ooooooO0.o. != null)
			{
				this.ooooooO0.o..Dispose();
			}
			base.Dispose(A_0);
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x001B4B58 File Offset: 0x001B2D58
		[DebuggerStepThrough]
		private void <<EMPTY_NAME>>()
		{
			this.ooooooO0.o. = new Container();
			this.O_O__.Oo0.(new C1Button());
			this.o.0_0_ooO_00__.(new C1Button());
			this.O_o0Oo.__0OOOO.(new C1Button());
			this.o0_O0._0OO.(new C1Button());
			this.Oo0.0___0Ooo.(new C1Button());
			this.O_O__.Oo0.(new System.Windows.Forms.ListBox());
			this.O_O__.Oo0.(new ContextMenuStrip(this.ooooooO0.o.));
			this.O_O__.Oo0.(new ToolStripMenuItem());
			this.Ooo.O0.(new ToolStripMenuItem());
			this.O_O0_Oo_Oo.o_.(new C1Button());
			this.oOo._O_0O__o.(new oOOoo_0_0o_());
			((ISupportInitialize)this.oOOoo0.__0o.()).BeginInit();
			((ISupportInitialize)this.o_Oo.OO_.()).BeginInit();
			((ISupportInitialize)this.o0o.o_O.()).BeginInit();
			((ISupportInitialize)this.O__0.__00o_O.()).BeginInit();
			((ISupportInitialize)this.OoOooOo__._o.()).BeginInit();
			this.oO.__Oo_O_O_0_.().SuspendLayout();
			((ISupportInitialize)this.O__O00.O0OO.()).BeginInit();
			base.SuspendLayout();
			this.oOOoo0.__0o.().Location = new Point(331, 416);
			this.oOOoo0.__0o.().Name = "btnClose";
			this.oOOoo0.__0o.().Size = new Size(75, 23);
			this.oOOoo0.__0o.().TabIndex = 5;
			this.oOOoo0.__0o.().Text = "关闭";
			this.oOOoo0.__0o.().UseVisualStyleBackColor = true;
			this.o_Oo.OO_.().Location = new Point(331, 102);
			this.o_Oo.OO_.().Name = "btnRename";
			this.o_Oo.OO_.().Size = new Size(75, 23);
			this.o_Oo.OO_.().TabIndex = 4;
			this.o_Oo.OO_.().Text = "重命名";
			this.o_Oo.OO_.().UseVisualStyleBackColor = true;
			this.o0o.o_O.().Location = new Point(331, 73);
			this.o0o.o_O.().Name = "btnDelete";
			this.o0o.o_O.().Size = new Size(75, 23);
			this.o0o.o_O.().TabIndex = 3;
			this.o0o.o_O.().Text = "删除";
			this.o0o.o_O.().UseVisualStyleBackColor = true;
			this.O__0.__00o_O.().Location = new Point(331, 44);
			this.O__0.__00o_O.().Name = "btnEdit";
			this.O__0.__00o_O.().Size = new Size(75, 23);
			this.O__0.__00o_O.().TabIndex = 2;
			this.O__0.__00o_O.().Text = "编辑";
			this.O__0.__00o_O.().UseVisualStyleBackColor = true;
			this.OoOooOo__._o.().Location = new Point(331, 15);
			this.OoOooOo__._o.().Name = "btnAdd";
			this.OoOooOo__._o.().Size = new Size(75, 23);
			this.OoOooOo__._o.().TabIndex = 1;
			this.OoOooOo__._o.().Text = "增加";
			this.OoOooOo__._o.().UseVisualStyleBackColor = true;
			this.oO.__Oo_O_O_0_.().DrawMode = DrawMode.OwnerDrawFixed;
			this.oO.__Oo_O_O_0_.().FormattingEnabled = true;
			this.oO.__Oo_O_O_0_.().IntegralHeight = false;
			this.oO.__Oo_O_O_0_.().ItemHeight = 15;
			this.oO.__Oo_O_O_0_.().Location = new Point(12, 15);
			this.oO.__Oo_O_O_0_.().Name = "lstTables";
			this.oO.__Oo_O_O_0_.().Size = new Size(302, 424);
			this.oO.__Oo_O_O_0_.().TabIndex = 0;
			this.oO.__Oo_O_O_0_.().Items.AddRange(new ToolStripItem[]
			{
				this.oO.__Oo_O_O_0_.(),
				this.OOO_OOOOOo._.()
			});
			this.oO.__Oo_O_O_0_.().Name = "ContextMenuStrip1";
			this.oO.__Oo_O_O_0_.().ShowImageMargin = false;
			this.oO.__Oo_O_O_0_.().Size = new Size(133, 48);
			this.oO.__Oo_O_O_0_.().Name = "JoinTableBuilder";
			this.oO.__Oo_O_O_0_.().Size = new Size(132, 22);
			this.oO.__Oo_O_O_0_.().Text = "查询表生成器...";
			this.OOO_OOOOOo._.().Name = "SelectString";
			this.OOO_OOOOOo._.().Size = new Size(132, 22);
			this.OOO_OOOOOo._.().Text = "Select语句...";
			this.O__O00.O0OO.().Location = new Point(331, 131);
			this.O__O00.O0OO.().Name = "btnFilter";
			this.O__O00.O0OO.().Size = new Size(75, 23);
			this.O__O00.O0OO.().TabIndex = 22;
			this.O__O00.O0OO.().Text = "查找";
			this.O__O00.O0OO.().UseVisualStyleBackColor = true;
			this.oO.__Oo_O_O_0_.().o0_OOo___o.0O.(500);
			this.oO.__Oo_O_O_0_.().Location = new Point(12, 450);
			this.oO.__Oo_O_O_0_.().Name = "SearchBox1";
			this.oO.__Oo_O_O_0_.().Size = new Size(302, 24);
			this.oO.__Oo_O_O_0_.().TabIndex = 21;
			this.oO.__Oo_O_O_0_.().Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(418, 455);
			base.Controls.Add(this.O__O00.O0OO.());
			base.Controls.Add(this.oO.__Oo_O_O_0_.());
			base.Controls.Add(this.oO.__Oo_O_O_0_.());
			base.Controls.Add(this.o_Oo.OO_.());
			base.Controls.Add(this.o0o.o_O.());
			base.Controls.Add(this.oOOoo0.__0o.());
			base.Controls.Add(this.O__0.__00o_O.());
			base.Controls.Add(this.OoOooOo__._o.());
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "o0.o0_o0.";
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "查询表管理";
			((ISupportInitialize)this.oOOoo0.__0o.()).EndInit();
			((ISupportInitialize)this.o_Oo.OO_.()).EndInit();
			((ISupportInitialize)this.o0o.o_O.()).EndInit();
			((ISupportInitialize)this.O__0.__00o_O.()).EndInit();
			((ISupportInitialize)this.OoOooOo__._o.()).EndInit();
			this.oO.__Oo_O_O_0_.().ResumeLayout(false);
			((ISupportInitialize)this.O__O00.O0OO.()).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x001B518D File Offset: 0x001B338D
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.oOo._O_0O__o.;
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x001B5198 File Offset: 0x001B3398
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.o_00o.__O.);
			C1Button c1Button = this.oOo._O_0O__o.;
			if (c1Button != null)
			{
				c1Button.Click -= value;
			}
			this.oOo._O_0O__o. = A_0;
			c1Button = this.oOo._O_0O__o.;
			if (c1Button != null)
			{
				c1Button.Click += value;
			}
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x001B51DB File Offset: 0x001B33DB
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo.O0.;
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x001B51E4 File Offset: 0x001B33E4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.oOOoo0.__0o.);
			C1Button ooo.O0. = this.Ooo.O0.;
			if (ooo.O0. != null)
			{
				ooo.O0..Click -= value;
			}
			this.Ooo.O0. = A_0;
			ooo.O0. = this.Ooo.O0.;
			if (ooo.O0. != null)
			{
				ooo.O0..Click += value;
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x001B5227 File Offset: 0x001B3427
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.OO0O.0o_o.;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x001B5230 File Offset: 0x001B3430
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O_O.O0_O.);
			C1Button oo0O.0o_o. = this.OO0O.0o_o.;
			if (oo0O.0o_o. != null)
			{
				oo0O.0o_o..Click -= value;
			}
			this.OO0O.0o_o. = A_0;
			oo0O.0o_o. = this.OO0O.0o_o.;
			if (oo0O.0o_o. != null)
			{
				oo0O.0o_o..Click += value;
			}
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x001B5273 File Offset: 0x001B3473
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Ooo_OooO.O.;
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x001B527C File Offset: 0x001B347C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0_0o__.00o_.);
			C1Button ooo_OooO.O. = this.Ooo_OooO.O.;
			if (ooo_OooO.O. != null)
			{
				ooo_OooO.O..Click -= value;
			}
			this.Ooo_OooO.O. = A_0;
			ooo_OooO.O. = this.Ooo_OooO.O.;
			if (ooo_OooO.O. != null)
			{
				ooo_OooO.O..Click += value;
			}
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x001B52BF File Offset: 0x001B34BF
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.Oo.oOo00O.;
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x001B52C8 File Offset: 0x001B34C8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O0.Oo.);
			C1Button oo.oOo00O. = this.Oo.oOo00O.;
			if (oo.oOo00O. != null)
			{
				oo.oOo00O..Click -= value;
			}
			this.Oo.oOo00O. = A_0;
			oo.oOo00O. = this.Oo.oOo00O.;
			if (oo.oOo00O. != null)
			{
				oo.oOo00O..Click += value;
			}
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x001B530B File Offset: 0x001B350B
		[CompilerGenerated]
		internal virtual System.Windows.Forms.ListBox <<EMPTY_NAME>>()
		{
			return this.ooooooO0.o.;
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x001B5314 File Offset: 0x001B3514
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(System.Windows.Forms.ListBox A_0)
		{
			DrawItemEventHandler value = new DrawItemEventHandler(this.oO.__Oo_O_O_0_.);
			System.Windows.Forms.ListBox listBox = this.ooooooO0.o.;
			if (listBox != null)
			{
				listBox.DrawItem -= value;
			}
			this.ooooooO0.o. = A_0;
			listBox = this.ooooooO0.o.;
			if (listBox != null)
			{
				listBox.DrawItem += value;
			}
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x001B5357 File Offset: 0x001B3557
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.oOo._O_0O__o.;
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x001B535F File Offset: 0x001B355F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.oOo._O_0O__o. = A_0;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x001B5368 File Offset: 0x001B3568
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.ooooooO0.o.;
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x001B537C File Offset: 0x001B357C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o_Oo.OO_.);
				ToolStripMenuItem toolStripMenuItem = this.ooooooO0.o.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						goto IL_62;
					case 1:
						toolStripMenuItem.Click += value;
						num = 5;
						continue;
					case 2:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					case 3:
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 4:
						goto IL_62;
					case 5:
						return;
					}
					break;
					IL_62:
					this.ooooooO0.o. = A_0;
					toolStripMenuItem = this.ooooooO0.o.;
					num = 2;
				}
			}
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x001B5428 File Offset: 0x001B3628
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_0_O__0_.0.;
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x001B543C File Offset: 0x001B363C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0_O0._0OO.);
				ToolStripMenuItem o_0_O__0_.0. = this.O_0_O__0_.0.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (o_0_O__0_.0. != null)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						goto IL_62;
					case 2:
						o_0_O__0_.0..Click -= value;
						num = 1;
						continue;
					case 3:
						return;
					case 4:
						o_0_O__0_.0..Click += value;
						num = 3;
						continue;
					case 5:
						if (o_0_O__0_.0. != null)
						{
							if (true)
							{
							}
							num = 2;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.O_0_O__0_.0. = A_0;
					o_0_O__0_.0. = this.O_0_O__0_.0.;
					num = 0;
				}
			}
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x001B54E5 File Offset: 0x001B36E5
		[CompilerGenerated]
		internal virtual oOOoo_0_0o_ <<EMPTY_NAME>>()
		{
			return this.ooooooO0.o.;
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x001B54F0 File Offset: 0x001B36F0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(oOOoo_0_0o_ A_0)
		{
			EventHandler a_ = new EventHandler(this.oO.__Oo_O_O_0_.);
			oOOoo_0_0o_ oOOoo_0_0o_ = this.ooooooO0.o.;
			if (oOOoo_0_0o_ != null)
			{
				oOOoo_0_0o_.o0_OOo___o.0O.(a_);
			}
			this.ooooooO0.o. = A_0;
			oOOoo_0_0o_ = this.ooooooO0.o.;
			if (oOOoo_0_0o_ != null)
			{
				oOOoo_0_0o_.o.oOO_O.(a_);
			}
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x001B5533 File Offset: 0x001B3733
		[CompilerGenerated]
		internal virtual C1Button <<EMPTY_NAME>>()
		{
			return this.O_0Oo_O_O0_.O.;
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x001B553C File Offset: 0x001B373C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(C1Button A_0)
		{
			EventHandler value = new EventHandler(this.O.0ooOO.);
			C1Button o_0Oo_O_O0_.O. = this.O_0Oo_O_O0_.O.;
			if (o_0Oo_O_O0_.O. != null)
			{
				o_0Oo_O_O0_.O..Click -= value;
			}
			this.O_0Oo_O_O0_.O. = A_0;
			o_0Oo_O_O0_.O. = this.O_0Oo_O_O0_.O.;
			if (o_0Oo_O_O0_.O. != null)
			{
				o_0Oo_O_O0_.O..Click += value;
			}
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x001B5580 File Offset: 0x001B3780
		public O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000()
		{
			base.Load += this.oo0.o_oO.;
			base.FormClosed += this.o0o.o_O.;
			this.OOO_OOOOOo._.();
			Main.OO_O.o..OOoo___.0.(base.Controls, "(default)");
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x001B55D4 File Offset: 0x001B37D4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO.__Oo_O_O_0_.().DataSource = new DataView(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], "[Type] <> " + Conversions.ToString(0), "", DataViewRowState.CurrentRows);
			this.oO.__Oo_O_O_0_.().DisplayMember = "Name";
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x001B562C File Offset: 0x001B382C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.oO.__Oo_O_O_0_.().Show(this.OoOooOo__._o.(), new Point(0, this.OoOooOo__._o.().Height));
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x001B5650 File Offset: 0x001B3850
		private void <<EMPTY_NAME>>()
		{
			if (this.oO.__Oo_O_O_0_.().Visible && Operators.CompareString(this.oO.__Oo_O_O_0_.().Text, "", true) > 0)
			{
				this.oO.__Oo_O_O_0_.().Text = "";
				this.oO.__Oo_O_O_0_.().O_o_.O0o00o__0.(EventArgs.Empty);
			}
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x001B56A4 File Offset: 0x001B38A4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO.__Oo_O_O_0_.().SelectedItem != null)
			{
				DataRowView dataRowView = (DataRowView)this.oO.__Oo_O_O_0_.().SelectedItem;
				string text = Conversions.ToString(dataRowView["Name"]);
				if (Oo00.o0.__oO0_.(text))
				{
					try
					{
						IEnumerator<Foxtable.WinForm.Form> enumerator = OO_00oOO.Forms.GetEnumerator();
						while (enumerator.MoveNext())
						{
							if (Operators.CompareString(enumerator.Current.TableName, text, true) == 0)
							{
								MessageBox.Show("请在删除表之前，先删除此表的窗口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
						}
					}
					finally
					{
						IEnumerator<Foxtable.WinForm.Form> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					if (O_O0OO.OOOo.oo_OOOO_0.().Tables.Contains(text))
					{
						OO_00oOO.DataTables.OO0o00.0O_0o.(text, true);
						return;
					}
					dataRowView.Row.Delete();
					Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					OO_00oOO.DataTables.OO0o00.0O_0o.(text);
				}
			}
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x001B579C File Offset: 0x001B399C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x001B57A4 File Offset: 0x001B39A4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO.__Oo_O_O_0_.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.oO.__Oo_O_O_0_.().SelectedItem).Row;
				if (Oo00.o0.__oO0_.(row["Name"].ToString()))
				{
					if (row["Property"].ToString().StartsWith("{"))
					{
						new af(row).ShowDialog();
						return;
					}
					new O\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u30000\u30000(row).ShowDialog();
				}
			}
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x001B5820 File Offset: 0x001B3A20
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (this.oO.__Oo_O_O_0_.().SelectedItem != null)
			{
				DataRow row = ((DataRowView)this.oO.__Oo_O_O_0_.().SelectedItem).Row;
				string a_ = row["Name"].ToString();
				if (Oo00.o0.__oO0_.(a_))
				{
					if (OO_00oOO.DataTables.Contains(""))
					{
						Foxtable.Syscmd.Table.OO.OO_0o.(OO_00oOO.DataTables[a_]);
						return;
					}
					o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000 o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u = new o\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002O\u3000\u3002\u3000(a_, "");
					if (o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.ShowDialog() == DialogResult.OK)
					{
						row["Name"] = o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.();
						Foxtable.Syscmd.Table.OO.OO_0o.(a_, o_u3000_u3000_u3002_u3002_u3002_u3000_u3002_u3002O_u3000_u3002_u.O_O.OO0O_oO__.());
						Oo00.o0_o._O_.(O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()], true);
					}
				}
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x001B58DC File Offset: 0x001B3ADC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Foxtable.Syscmd.Table.OO__OO.0.())
			{
				this.o0o.o_O.();
				int count = this.oO.__Oo_O_O_0_.().Items.Count;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].NewRow();
				dataRow["Type"] = OtherTableTypeEnum.Query;
				new af(dataRow).ShowDialog();
				if (this.oO.__Oo_O_O_0_.().Items.Count > count)
				{
					this.oO.__Oo_O_O_0_.().SelectedIndex = this.oO.__Oo_O_O_0_.().Items.Count - 1;
					OO_00oOO.MainTable = OO_00oOO.Tables[dataRow["Name"].ToString()];
				}
			}
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x001B5990 File Offset: 0x001B3B90
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (Foxtable.Syscmd.Table.OO__OO.0.())
			{
				this.o0o.o_O.();
				int count = this.oO.__Oo_O_O_0_.().Items.Count;
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0_.OOo0OO.()].NewRow();
				dataRow["Type"] = OtherTableTypeEnum.Query;
				new O\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u30000\u30000(dataRow).ShowDialog();
				if (this.oO.__Oo_O_O_0_.().Items.Count > count)
				{
					this.oO.__Oo_O_O_0_.().SelectedIndex = this.oO.__Oo_O_O_0_.().Items.Count - 1;
					OO_00oOO.MainTable = OO_00oOO.Tables[dataRow["Name"].ToString()];
				}
			}
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x001B5A44 File Offset: 0x001B3C44
		private void <<EMPTY_NAME>>(object A_0, FormClosedEventArgs A_1)
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(base.Controls);
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x001B5A58 File Offset: 0x001B3C58
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!this.oO.__Oo_O_O_0_.().Visible)
			{
				this.oOo._O_0O__o. = base.Height;
				base.Height = this.oO.__Oo_O_O_0_.().Bottom + 44;
				this.oO.__Oo_O_O_0_.().Visible = true;
				this.oO.__Oo_O_O_0_.().ooO00_0.0.().Select();
				return;
			}
			base.Height = this.oOo._O_0O__o.;
			this.oO.__Oo_O_O_0_.().Visible = false;
			this.oO.__Oo_O_O_0_.().Text = "";
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x001B5AD8 File Offset: 0x001B3CD8
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			DataView dataView = this.oO.__Oo_O_O_0_.().DataSource as DataView;
			if (string.IsNullOrWhiteSpace(this.oO.__Oo_O_O_0_.().Text))
			{
				dataView.RowFilter = "[Type] <> " + Conversions.ToString(0);
				return;
			}
			dataView.RowFilter = "name like '%" + this.oO.__Oo_O_O_0_.().Text.Trim() + "%' And [Type] <> " + Conversions.ToString(0);
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x001B5B4C File Offset: 0x001B3D4C
		private void <<EMPTY_NAME>>(object A_0, DrawItemEventArgs A_1)
		{
			if (A_1.Index >= 0)
			{
				A_1.DrawBackground();
				A_1.DrawFocusRectangle();
				A_1.Graphics.DrawString(((DataRowView)this.oO.__Oo_O_O_0_.().Items[A_1.Index])[this.oO.__Oo_O_O_0_.().DisplayMember].ToString(), A_1.Font, new SolidBrush(A_1.ForeColor), A_1.Bounds, StringFormat.GenericDefault);
			}
		}

		// Token: 0x040018C0 RID: 6336
		private IContainer <<EMPTY_NAME>>;

		// Token: 0x040018C1 RID: 6337
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018C2 RID: 6338
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018C3 RID: 6339
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018C4 RID: 6340
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018C5 RID: 6341
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018C6 RID: 6342
		[CompilerGenerated]
		private System.Windows.Forms.ListBox <<EMPTY_NAME>>;

		// Token: 0x040018C7 RID: 6343
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x040018C8 RID: 6344
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040018C9 RID: 6345
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040018CA RID: 6346
		[CompilerGenerated]
		private oOOoo_0_0o_ <<EMPTY_NAME>>;

		// Token: 0x040018CB RID: 6347
		[CompilerGenerated]
		private C1Button <<EMPTY_NAME>>;

		// Token: 0x040018CC RID: 6348
		private int <<EMPTY_NAME>>;
	}
}
