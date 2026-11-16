using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.EditActions;

namespace Foxtable
{
	// Token: 0x02000075 RID: 117
	internal class oO_oO000oo : UserControl
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00019736 File Offset: 0x00017936
		[CompilerGenerated]
		private virtual SyntaxEditor <<EMPTY_NAME>>()
		{
			return this.o0_._00OOOoo0O.;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00019740 File Offset: 0x00017940
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(SyntaxEditor A_0)
		{
			EventHandler<SyntaxEditorMenuEventArgs> value = new EventHandler<SyntaxEditorMenuEventArgs>(this.o0Oo0OoOO0OO.O.);
			SyntaxEditor syntaxEditor = this.o0_._00OOOoo0O.;
			if (syntaxEditor != null)
			{
				syntaxEditor.MenuRequested -= value;
			}
			this.o0_._00OOOoo0O. = A_0;
			syntaxEditor = this.o0_._00OOOoo0O.;
			if (syntaxEditor != null)
			{
				syntaxEditor.MenuRequested += value;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00019783 File Offset: 0x00017983
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.o0_._00OOOoo0O.;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0001978B File Offset: 0x0001798B
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.o0_._00OOOoo0O. = A_0;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00019794 File Offset: 0x00017994
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0_._00OOOoo0O.;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000197A8 File Offset: 0x000179A8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0.___0Oo.);
				ToolStripMenuItem toolStripMenuItem = this.o0_._00OOOoo0O.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						toolStripMenuItem.Click -= value;
						num = 3;
						continue;
					case 3:
						goto IL_62;
					case 4:
						toolStripMenuItem.Click += value;
						num = 1;
						continue;
					case 5:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					}
					break;
					IL_62:
					this.o0_._00OOOoo0O. = A_0;
					toolStripMenuItem = this.o0_._00OOOoo0O.;
					num = 0;
				}
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00019854 File Offset: 0x00017A54
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.OOO.OOo.;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00019868 File Offset: 0x00017A68
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.oo_.0o__.);
				ToolStripMenuItem ooo.OOo. = this.OOO.OOo.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (ooo.OOo. != null)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						ooo.OOo..Click -= value;
						num = 2;
						continue;
					case 2:
						goto IL_62;
					case 3:
						return;
					case 4:
						ooo.OOo..Click += value;
						num = 3;
						continue;
					case 5:
						if (ooo.OOo. != null)
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
					this.OOO.OOo. = A_0;
					ooo.OOo. = this.OOO.OOo.;
					num = 0;
				}
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00019914 File Offset: 0x00017B14
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o.OoOo__.;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00019928 File Offset: 0x00017B28
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OoO.o0O_oo.);
				ToolStripMenuItem toolStripMenuItem = this.o.OoOo__.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						return;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						goto IL_5A;
					case 2:
						toolStripMenuItem.Click += value;
						num = 4;
						continue;
					case 3:
						goto IL_5A;
					case 4:
						return;
					case 5:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 3;
						continue;
					}
					break;
					IL_5A:
					this.o.OoOo__. = A_0;
					toolStripMenuItem = this.o.OoOo__.;
					num = 0;
				}
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000199D0 File Offset: 0x00017BD0
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0OO__00.oOoOO.;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000199E4 File Offset: 0x00017BE4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OOO.OOo.);
				ToolStripMenuItem toolStripMenuItem = this.o0OO__00.oOoOO.;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 2;
						continue;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						goto IL_5A;
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
					this.o0OO__00.oOoOO. = A_0;
					toolStripMenuItem = this.o0OO__00.oOoOO.;
					num = 1;
				}
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00019A8C File Offset: 0x00017C8C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.OoO._o0oO.;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00019AA0 File Offset: 0x00017CA0
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.Oo0OOO.o__.);
				ToolStripMenuItem ooO._o0oO. = this.OoO._o0oO.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (true)
						{
						}
						if (ooO._o0oO. != null)
						{
							num = 4;
							continue;
						}
						return;
					case 1:
						ooO._o0oO..Click -= value;
						num = 3;
						continue;
					case 2:
						return;
					case 3:
						goto IL_5A;
					case 4:
						ooO._o0oO..Click += value;
						num = 2;
						continue;
					case 5:
						if (ooO._o0oO. != null)
						{
							num = 1;
							continue;
						}
						goto IL_5A;
					}
					break;
					IL_5A:
					this.OoO._o0oO. = A_0;
					ooO._o0oO. = this.OoO._o0oO.;
					num = 0;
				}
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00019B4C File Offset: 0x00017D4C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oOoO.0.;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00019B60 File Offset: 0x00017D60
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O_0_OO_0_.0_00.);
				ToolStripMenuItem toolStripMenuItem = this.oOoO.0.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						return;
					case 1:
						if (toolStripMenuItem != null)
						{
							if (true)
							{
							}
							num = 2;
							continue;
						}
						goto IL_62;
					case 2:
						toolStripMenuItem.Click -= value;
						num = 3;
						continue;
					case 3:
						goto IL_62;
					case 4:
						return;
					case 5:
						toolStripMenuItem.Click += value;
						num = 4;
						continue;
					}
					break;
					IL_62:
					this.oOoO.0. = A_0;
					toolStripMenuItem = this.oOoO.0.;
					num = 0;
				}
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00019C0C File Offset: 0x00017E0C
		public oO_oO000oo()
		{
			this.o0Oo0OoOO0OO.O.(new SyntaxEditor());
			this.O_0_OO_0_.0_00.().WordWrapMode = WordWrapMode.Word;
			this.O_0_OO_0_.0_00.().CanSplitHorizontally = false;
			this.O_0_OO_0_.0_00.().AreLineModificationMarksVisible = false;
			this.O_0_OO_0_.0_00.().IsLineNumberMarginVisible = false;
			this.O_0_OO_0_.0_00.().AreIndentationGuidesVisible = false;
			this.O_0_OO_0_.0_00.().AreColumnGuidesVisible = false;
			this.O_0_OO_0_.0_00.().IsIndicatorMarginVisible = false;
			this.O_0_OO_0_.0_00.().HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
			this.O_0_OO_0_.0_00.().IsOutliningMarginVisible = false;
			this.O_0_OO_0_.0_00.().LineNumberMarginMinWidth = 0;
			this.O_0_OO_0_.0_00.().Font = new Font("新宋体", 10f);
			this.O_0_OO_0_.0_00.().PrintSettings.AreColumnGuidesVisible = false;
			this.oo0.OoO0.();
			base.Controls.Add(this.O_0_OO_0_.0_00.());
			this.O_0_OO_0_.0_00.().Dock = DockStyle.Fill;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00019CF0 File Offset: 0x00017EF0
		internal void <<EMPTY_NAME>>()
		{
			SyntaxLanguageDefinitionSerializer syntaxLanguageDefinitionSerializer = new SyntaxLanguageDefinitionSerializer();
			using (FileStream fileStream = File.OpenRead(O_O0OO.o.00O_O.() + "Sql.langdef"))
			{
				this.O_0_OO_0_.0_00.().Document.Language = syntaxLanguageDefinitionSerializer.LoadFromStream(fileStream);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00019D4C File Offset: 0x00017F4C
		private void <<EMPTY_NAME>>()
		{
			this.o0Oo0OoOO0OO.O.(new ContextMenuStrip());
			this.oO.oooooo_oooo.(new ToolStripMenuItem());
			this.O_00.oO00.(new ToolStripMenuItem());
			this.oO.O_oo_o_O.(new ToolStripMenuItem());
			this.O0OO0o0.o0oO.(new ToolStripMenuItem());
			this.OOOOo_.O0_0.(new ToolStripMenuItem());
			this.o0Oo0OoOO0OO.O.(new ToolStripMenuItem());
			this.oo0.OoO0.().Items.AddRange(new ToolStripItem[]
			{
				this.oo_.0o__.(),
				this.o0oOO_.O_.(),
				this.O_Oo0O_.0.(),
				new ToolStripSeparator(),
				this.Oo0OOO.o__.(),
				this.O_0_OO_0_.0_00.(),
				this.oO.oooooo_oooo.()
			});
			this.oo0.OoO0.().Name = "ContextMenuStrip1";
			this.oo0.OoO0.().Size = new Size(170, 192);
			this.oo_.0o__.().Name = "CopyMenuItem";
			this.oo_.0o__.().Size = new Size(180, 22);
			this.oo_.0o__.().Text = "复制(&C)";
			this.o0oOO_.O_.().Name = "CutMenuItem";
			this.o0oOO_.O_.().Size = new Size(180, 22);
			this.o0oOO_.O_.().Text = "剪切(&T)";
			this.O_Oo0O_.0.().Name = "PasteMenuItem";
			this.O_Oo0O_.0.().Size = new Size(180, 22);
			this.O_Oo0O_.0.().Text = "粘贴(&P)";
			this.Oo0OOO.o__.().Name = "UndoMenuItem";
			this.Oo0OOO.o__.().Size = new Size(180, 22);
			this.Oo0OOO.o__.().Text = "撤销(&U)";
			this.O_0_OO_0_.0_00.().Name = "RedoMenuItem";
			this.O_0_OO_0_.0_00.().Size = new Size(180, 22);
			this.O_0_OO_0_.0_00.().Text = "重复(&R)";
			this.oO.oooooo_oooo.().Name = "SelectAllMenuItem";
			this.oO.oooooo_oooo.().Size = new Size(180, 22);
			this.oO.oooooo_oooo.().Text = "全选(&A)";
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00019F6E File Offset: 0x0001816E
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0_OO_0_.0_00.().ActiveView.CopyToClipboard();
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00019F80 File Offset: 0x00018180
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0_OO_0_.0_00.().ActiveView.CutToClipboard();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00019F92 File Offset: 0x00018192
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0_OO_0_.0_00.().ActiveView.PasteFromClipboard();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00019FA4 File Offset: 0x000181A4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0_OO_0_.0_00.().ActiveView.ExecuteEditAction(new RedoAction());
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00019FBC File Offset: 0x000181BC
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0_OO_0_.0_00.().ActiveView.ExecuteEditAction(new UndoAction());
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00019FD4 File Offset: 0x000181D4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			this.O_0_OO_0_.0_00.().ActiveView.ExecuteEditAction(new SelectAllAction());
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00019FEC File Offset: 0x000181EC
		private void <<EMPTY_NAME>>(object A_0, SyntaxEditorMenuEventArgs A_1)
		{
			A_1.Menu = this.oo0.OoO0.();
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00019FFA File Offset: 0x000181FA
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x0001A007 File Offset: 0x00018207
		public virtual string Text
		{
			get
			{
				return this.O_0_OO_0_.0_00.().Text;
			}
			set
			{
				this.O_0_OO_0_.0_00.().Text = value;
			}
		}

		// Token: 0x0400011E RID: 286
		[CompilerGenerated]
		private SyntaxEditor <<EMPTY_NAME>>;

		// Token: 0x0400011F RID: 287
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x04000120 RID: 288
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000121 RID: 289
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000122 RID: 290
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000123 RID: 291
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000124 RID: 292
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x04000125 RID: 293
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;
	}
}
