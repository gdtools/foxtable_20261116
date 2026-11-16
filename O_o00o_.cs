using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Analysis;
using ActiproSoftware.Text.Languages.DotNet;
using ActiproSoftware.Text.Languages.DotNet.Ast.Implementation;
using ActiproSoftware.Text.Languages.DotNet.Reflection;
using ActiproSoftware.Text.Languages.DotNet.Reflection.Implementation;
using ActiproSoftware.Text.Languages.DotNet.Resolution;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Parsing.Implementation;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.EditActions;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.Outlining;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.Primitives;
using Foxtable.My;
using Foxtable.RibbonMenu;
using Foxtable.WinForm;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000068 RID: 104
	internal class O_o00o_ : SyntaxEditor
	{
		// Token: 0x0600039F RID: 927 RVA: 0x0000DEDC File Offset: 0x0000C0DC
		public O_o00o_()
		{
			int a_ = 7;
			base..ctor();
			base.KeyDown += this.OO._o__o.;
			base.OverlayPaneOpened += this.Oo__.ooO_o_.;
			base.DocumentTextChanging += this.OO._o__o.;
			base.DocumentTextChanged += this.OO._o__o.;
			base.UserInterfaceUpdate += this.ooOoo.0_o0o.;
			base.MenuRequested += this.Oo__.ooO_o_.;
			base.MouseWheel += this.Oo__.ooO_o_.;
			this.o_.0ooOooOoo00.(O00OOOo_O0_O.b("뫩駫賭鳯鯱音훵뻷迹鋻鷽瓿欁欃栅⠇䔉", a_) + OoOo0O.OO_o.0o_O.(8) + O00OOOo_O0_O.b("싩엫컭뇯臱퓳맵髷郹駻鷽瓿", a_));
			this.OOoO.o.(O00OOOo_O0_O.b("꿩苫諭탯등至飵鯷軹闻釽滿", a_));
			this.o0o_O_._. = true;
			this.O0_.o0o. = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			this.o.00oO0Oo. = new List<string>();
			this.O0.oOOO_o0. = new CompletionSession();
			this.o.00oO0Oo. = true;
			this.OOo__.O0.(new CompletionSession());
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000DFF6 File Offset: 0x0000C1F6
		[CompilerGenerated]
		internal virtual ContextMenuStrip <<EMPTY_NAME>>()
		{
			return this.o.0_0o00_.;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000DFFE File Offset: 0x0000C1FE
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ContextMenuStrip A_0)
		{
			this.o.0_0o00_. = A_0;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000E008 File Offset: 0x0000C208
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o.0_0o00_.;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000E01C File Offset: 0x0000C21C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O_0__0ooO_O.00.);
				ToolStripMenuItem toolStripMenuItem = this.o.0_0o00_.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_62;
					case 2:
						toolStripMenuItem.Click -= value;
						num = 1;
						continue;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						return;
					case 4:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					case 5:
						toolStripMenuItem.Click += value;
						num = 0;
						continue;
					}
					break;
					IL_62:
					this.o.0_0o00_. = A_0;
					toolStripMenuItem = this.o.0_0o00_.;
					num = 3;
				}
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O0O.__Oo_0__o.;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0O.o00.);
				ToolStripMenuItem o0O.__Oo_0__o. = this.O0O.__Oo_0__o.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (o0O.__Oo_0__o. != null)
						{
							if (true)
							{
							}
							num = 5;
							continue;
						}
						goto IL_62;
					case 1:
						return;
					case 2:
						o0O.__Oo_0__o..Click += value;
						num = 1;
						continue;
					case 3:
						goto IL_62;
					case 4:
						if (o0O.__Oo_0__o. != null)
						{
							num = 2;
							continue;
						}
						return;
					case 5:
						o0O.__Oo_0__o..Click -= value;
						num = 3;
						continue;
					}
					break;
					IL_62:
					this.O0O.__Oo_0__o. = A_0;
					o0O.__Oo_0__o. = this.O0O.__Oo_0__o.;
					num = 4;
				}
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000E188 File Offset: 0x0000C388
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oO_0O.o_0_0.;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000E19C File Offset: 0x0000C39C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.Oo0.O_.);
				ToolStripMenuItem toolStripMenuItem = this.oO_0O.o_0_0.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 1;
						continue;
					case 1:
						return;
					case 2:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 5;
						continue;
					case 3:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
					case 4:
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						goto IL_5A;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					this.oO_0O.o_0_0. = A_0;
					toolStripMenuItem = this.oO_0O.o_0_0.;
					num = 3;
				}
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000E244 File Offset: 0x0000C444
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O0ooO._.;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000E258 File Offset: 0x0000C458
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O.0_0OO0o0.);
				ToolStripMenuItem o0ooO._. = this.O0ooO._.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						o0ooO._..Click += value;
						num = 1;
						continue;
					case 1:
						return;
					case 2:
						if (o0ooO._. != null)
						{
							num = 0;
							continue;
						}
						return;
					case 3:
						if (true)
						{
						}
						o0ooO._..Click -= value;
						num = 4;
						continue;
					case 4:
						goto IL_5A;
					case 5:
						if (o0ooO._. != null)
						{
							num = 3;
							continue;
						}
						goto IL_5A;
					}
					break;
					IL_5A:
					this.O0ooO._. = A_0;
					o0ooO._. = this.O0ooO._.;
					num = 2;
				}
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000E300 File Offset: 0x0000C500
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o_O.0.;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000E314 File Offset: 0x0000C514
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O0oO_Oo0.o0o.);
				ToolStripMenuItem toolStripMenuItem = this.o_O.0.;
				int num = 1;
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
						return;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 4;
							continue;
						}
						goto IL_5A;
					case 2:
						return;
					case 3:
						toolStripMenuItem.Click += value;
						num = 2;
						continue;
					case 4:
						toolStripMenuItem.Click -= value;
						num = 5;
						continue;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					this.o_O.0. = A_0;
					toolStripMenuItem = this.o_O.0.;
					num = 0;
				}
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O_00.oO.;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000E3D4 File Offset: 0x0000C5D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.O.o0OO_0_00o0.);
				ToolStripMenuItem o_00.oO. = this.O_00.oO.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (o_00.oO. != null)
						{
							num = 2;
							continue;
						}
						return;
					case 1:
						goto IL_62;
					case 2:
						o_00.oO..Click += value;
						num = 3;
						continue;
					case 3:
						return;
					case 4:
						if (o_00.oO. != null)
						{
							if (true)
							{
							}
							num = 5;
							continue;
						}
						goto IL_62;
					case 5:
						o_00.oO..Click -= value;
						num = 1;
						continue;
					}
					break;
					IL_62:
					this.O_00.oO. = A_0;
					o_00.oO. = this.O_00.oO.;
					num = 0;
				}
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000E480 File Offset: 0x0000C680
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.oOoo___o._0_0o.;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000E494 File Offset: 0x0000C694
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.ooOOo.O0O_.);
				ToolStripMenuItem toolStripMenuItem = this.oOoo___o._0_0o.;
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
							num = 1;
							continue;
						}
						goto IL_62;
					case 1:
						toolStripMenuItem.Click -= value;
						num = 5;
						continue;
					case 2:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 3:
						return;
					case 4:
						if (toolStripMenuItem != null)
						{
							num = 2;
							continue;
						}
						return;
					case 5:
						goto IL_62;
					}
					break;
					IL_62:
					this.oOoo___o._0_0o. = A_0;
					toolStripMenuItem = this.oOoo___o._0_0o.;
					num = 4;
				}
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000E540 File Offset: 0x0000C740
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0.o_0O0_oo.;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000E554 File Offset: 0x0000C754
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o0.O__oo0.);
				ToolStripMenuItem toolStripMenuItem = this.o0.o_0O0_oo.;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 1:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						goto IL_5A;
					case 2:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						return;
					case 3:
						return;
					case 4:
						goto IL_5A;
					case 5:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					}
					break;
					IL_5A:
					this.o0.o_0O0_oo. = A_0;
					toolStripMenuItem = this.o0.o_0O0_oo.;
					if (true)
					{
					}
					num = 2;
				}
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000E600 File Offset: 0x0000C800
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.ooOOo.O0O_.;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000E614 File Offset: 0x0000C814
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o.O___Oo.);
				ToolStripMenuItem toolStripMenuItem = this.ooOOo.O0O_.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						return;
					case 1:
						toolStripMenuItem.Click += value;
						num = 2;
						continue;
					case 2:
						return;
					case 3:
						goto IL_62;
					case 4:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						goto IL_62;
					case 5:
						toolStripMenuItem.Click -= value;
						num = 3;
						continue;
					}
					break;
					IL_62:
					this.ooOOo.O0O_. = A_0;
					toolStripMenuItem = this.ooOOo.O0O_.;
					num = 0;
				}
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0OO0.oo0o00O_.;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o.O_ooOo0o_.);
				ToolStripMenuItem toolStripMenuItem = this.o0OO0.oo0o00O_.;
				int num = 5;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_5A;
					case 1:
						return;
					case 2:
						if (toolStripMenuItem != null)
						{
							num = 4;
							continue;
						}
						return;
					case 3:
						if (true)
						{
						}
						toolStripMenuItem.Click -= value;
						num = 0;
						continue;
					case 4:
						toolStripMenuItem.Click += value;
						num = 1;
						continue;
					case 5:
						if (toolStripMenuItem != null)
						{
							num = 3;
							continue;
						}
						goto IL_5A;
					}
					break;
					IL_5A:
					this.o0OO0.oo0o00O_. = A_0;
					toolStripMenuItem = this.o0OO0.oo0o00O_.;
					num = 2;
				}
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000E77C File Offset: 0x0000C97C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.O.O_oo__ooO0OO.;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000E790 File Offset: 0x0000C990
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OO_.oO.);
				ToolStripMenuItem o.O_oo__ooO0OO. = this.O.O_oo__ooO0OO.;
				int num = 1;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 0:
						goto IL_62;
					case 1:
						if (o.O_oo__ooO0OO. != null)
						{
							num = 4;
							continue;
						}
						goto IL_62;
					case 2:
						o.O_oo__ooO0OO..Click += value;
						num = 5;
						continue;
					case 3:
						if (o.O_oo__ooO0OO. != null)
						{
							num = 2;
							continue;
						}
						return;
					case 4:
						o.O_oo__ooO0OO..Click -= value;
						num = 0;
						continue;
					case 5:
						return;
					}
					break;
					IL_62:
					this.O.O_oo__ooO0OO. = A_0;
					o.O_oo__ooO0OO. = this.O.O_oo__ooO0OO.;
					num = 3;
				}
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000E83C File Offset: 0x0000CA3C
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o0o_O_O.Oo0_.;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000E850 File Offset: 0x0000CA50
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.o__0oo.___o_.);
				ToolStripMenuItem toolStripMenuItem = this.o0o_O_O.Oo0_.;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (toolStripMenuItem != null)
						{
							if (true)
							{
							}
							num = 1;
							continue;
						}
						goto IL_62;
					case 1:
						toolStripMenuItem.Click -= value;
						num = 4;
						continue;
					case 2:
						if (toolStripMenuItem != null)
						{
							num = 5;
							continue;
						}
						return;
					case 3:
						return;
					case 4:
						goto IL_62;
					case 5:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					}
					break;
					IL_62:
					this.o0o_O_O.Oo0_. = A_0;
					toolStripMenuItem = this.o0o_O_O.Oo0_.;
					num = 2;
				}
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000E8FC File Offset: 0x0000CAFC
		[CompilerGenerated]
		internal virtual ToolStripMenuItem <<EMPTY_NAME>>()
		{
			return this.o.__o_.;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000E910 File Offset: 0x0000CB10
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal virtual void <<EMPTY_NAME>>(ToolStripMenuItem A_0)
		{
			for (;;)
			{
				EventHandler value = new EventHandler(this.OO._o__o.);
				ToolStripMenuItem toolStripMenuItem = this.o.__o_.;
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						toolStripMenuItem.Click += value;
						num = 3;
						continue;
					case 1:
						toolStripMenuItem.Click -= value;
						num = 2;
						continue;
					case 2:
						goto IL_62;
					case 3:
						return;
					case 4:
						if (true)
						{
						}
						if (toolStripMenuItem != null)
						{
							num = 1;
							continue;
						}
						goto IL_62;
					case 5:
						if (toolStripMenuItem != null)
						{
							num = 0;
							continue;
						}
						return;
					}
					break;
					IL_62:
					this.o.__o_. = A_0;
					toolStripMenuItem = this.o.__o_.;
					num = 5;
				}
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000E9B9 File Offset: 0x0000CBB9
		[CompilerGenerated]
		internal string <<EMPTY_NAME>>()
		{
			return this.o_0_O0o0.0oO.;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000E9C1 File Offset: 0x0000CBC1
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.o_0_O0o0.0oO. = A_0;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000E9CA File Offset: 0x0000CBCA
		[CompilerGenerated]
		internal string <<EMPTY_NAME>>()
		{
			return this.O0O.__Oo_0__o.;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000E9D2 File Offset: 0x0000CBD2
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(string A_0)
		{
			this.O0O.__Oo_0__o. = A_0;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000E9DC File Offset: 0x0000CBDC
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(O_o00o_.o_0__o0_OO__ A_0)
		{
			O_o00o_.o_0__o0_OO__ o_0__o0_OO__ = this.O0_.o0o.;
			O_o00o_.o_0__o0_OO__ o_0__o0_OO__2;
			do
			{
				o_0__o0_OO__2 = o_0__o0_OO__;
				O_o00o_.o_0__o0_OO__ value = (O_o00o_.o_0__o0_OO__)Delegate.Combine(o_0__o0_OO__2, A_0);
				o_0__o0_OO__ = Interlocked.CompareExchange<O_o00o_.o_0__o0_OO__>(ref this.O0_.o0o., value, o_0__o0_OO__2);
			}
			while (o_0__o0_OO__ != o_0__o0_OO__2);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000EA14 File Offset: 0x0000CC14
		[CompilerGenerated]
		internal void <<EMPTY_NAME>>(O_o00o_.o_0__o0_OO__ A_0)
		{
			O_o00o_.o_0__o0_OO__ o_0__o0_OO__ = this.O0_.o0o.;
			O_o00o_.o_0__o0_OO__ o_0__o0_OO__2;
			do
			{
				o_0__o0_OO__2 = o_0__o0_OO__;
				O_o00o_.o_0__o0_OO__ value = (O_o00o_.o_0__o0_OO__)Delegate.Remove(o_0__o0_OO__2, A_0);
				o_0__o0_OO__ = Interlocked.CompareExchange<O_o00o_.o_0__o0_OO__>(ref this.O0_.o0o., value, o_0__o0_OO__2);
			}
			while (o_0__o0_OO__ != o_0__o0_OO__2);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000EA4C File Offset: 0x0000CC4C
		static O_o00o_()
		{
			int a_ = 17;
			O_o00o_.O0.oOOO_o0. = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			O_o00o_.O0_.o0o. = new List<string>
			{
				O00OOOo_O0_O.b("郳鿵", a_),
				O00OOOo_O0_O.b("鷳郵", a_),
				O00OOOo_O0_O.b("鋳駵", a_),
				O00OOOo_O0_O.b("郳駵", a_),
				O00OOOo_O0_O.b("菳黵", a_),
				O00OOOo_O0_O.b("菳鿵", a_),
				O00OOOo_O0_O.b("釳飵", a_),
				O00OOOo_O0_O.b("蛳鏵", a_)
			};
			O_o00o_.OOO.00_. = new List<string>
			{
				O00OOOo_O0_O.b("郳", a_),
				O00OOOo_O0_O.b("鷳", a_),
				O00OOOo_O0_O.b("鋳", a_),
				O00OOOo_O0_O.b("菳", a_),
				O00OOOo_O0_O.b("蟳", a_),
				O00OOOo_O0_O.b("釳", a_),
				O00OOOo_O0_O.b("蛳", a_)
			};
			O_o00o_.o_O.0. = "";
			O_o00o_.Ooo0.00.();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000EBC0 File Offset: 0x0000CDC0
		private static void <<EMPTY_NAME>>()
		{
			if (O_o00o_.o_0_O0o0.0oO. == null && OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + "help.dat"))
			{
				OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + O_O0OO.o.00O_O.() + "help.dat;Persist Security Info=False");
				DbDataAdapter dbDataAdapter = new OleDbDataAdapter("select * from help", selectConnection);
				O_o00o_.o_0_O0o0.0oO. = new DataTable();
				dbDataAdapter.Fill(O_o00o_.o_0_O0o0.0oO.);
				O_o00o_.o_0_O0o0.0oO..DefaultView.Sort = "[type],[member]";
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000EC40 File Offset: 0x0000CE40
		internal void <<EMPTY_NAME>>()
		{
			this.AllowDrop = false;
			base.AllowDrag = false;
			this.Font = new Font("新宋体", 10f);
			this.OoO_.0o00o0. = base.FindForm().Text;
			base.FindForm().Text = "正在缓存反射数据...";
			if (AmbientParseRequestDispatcherProvider.Dispatcher == null)
			{
				AmbientParseRequestDispatcherProvider.Dispatcher = new ThreadedParseRequestDispatcher();
				AmbientAssemblyRepositoryProvider.Repository = new FileBasedAssemblyRepository(Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Foxtable CodeStudio"), "Assembly Repository"));
			}
			base.AreIndentationGuidesVisible = true;
			base.AreMultipleSelectionRangesEnabled = false;
			base.IsLineNumberMarginVisible = true;
			base.CanCutCopyDragWithHtml = false;
			base.CanCutCopyDragWithRtf = true;
			base.LineNumberMarginMinWidth = 24;
			VBSyntaxLanguage vbsyntaxLanguage = new VBSyntaxLanguage();
			this.O0.oOOO_o0. = vbsyntaxLanguage.GetService<IProjectAssembly>();
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.RunWorkerCompleted += this.oOo00O0._oO.;
			backgroundWorker.DoWork += this.OO._o__o.;
			backgroundWorker.RunWorkerAsync();
			base.Document.AutoConvertTabsToSpaces = true;
			base.Document.Language = vbsyntaxLanguage;
			base.Document.FileName = OoOo0O.OO_o.0o_O.(10) + ".vb";
			vbsyntaxLanguage.UnregisterService<IOutliner>();
			vbsyntaxLanguage.RegisterService<IOutliner>(new O_0o());
			vbsyntaxLanguage.UnregisterService<IAutoCorrector>();
			vbsyntaxLanguage.RegisterService<IAutoCorrector>(new o_oO());
			vbsyntaxLanguage.UnregisterService<VBCompletionProvider>();
			vbsyntaxLanguage.RegisterService<VBCompletionProvider>(new oO0O_oO_0O_());
			vbsyntaxLanguage.UnregisterService<VBTokenTaggerProvider>();
			vbsyntaxLanguage.RegisterService<TextViewTaggerProvider<Oo0O_O0o000>>(new TextViewTaggerProvider<Oo0O_O0o000>());
			vbsyntaxLanguage.UnregisterService<VBQuickInfoProvider>();
			vbsyntaxLanguage.RegisterService<OOO0o__OoOO>(new OOO0o__OoOO());
			vbsyntaxLanguage.UnregisterService<VBParameterInfoProvider>();
			vbsyntaxLanguage.RegisterService<O_o>(new O_o());
			new DisplayItemClassificationTypeProvider().RegisterAll();
			this.oOo00O0._oO.();
			this.ContextMenuStrip = this.Oo__.ooO_o_.();
			if (O_o00o_.O0.oOOO_o0..Count == 0)
			{
				string[] array = SysInfo.spaceNames.Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				DataRow dataRow;
				checked
				{
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new char[]
						{
							'(',
							')'
						}, StringSplitOptions.RemoveEmptyEntries);
						if (!array2[0].StartsWith("'"))
						{
							if (array2.Length == 1)
							{
								O_o00o_.O0.oOOO_o0..Add(array2[0], null);
							}
							else
							{
								O_o00o_.O0.oOOO_o0..Add(array2[0], array2[1]);
							}
						}
					}
					dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
					{
						"Space",
						o0_O.oo0o_OoO_.Oo.
					});
				}
				if (dataRow != null && !dataRow.IsNull("Config"))
				{
					string[] array3 = dataRow["Config"].ToString().Split(new char[]
					{
						'\n',
						'\r'
					}, StringSplitOptions.RemoveEmptyEntries);
					int num = array3.Length - 1;
					for (int j = 0; j <= num; j++)
					{
						string[] array4 = array3[j].Split(new char[]
						{
							'(',
							')'
						}, StringSplitOptions.RemoveEmptyEntries);
						if (array4.Length == 1)
						{
							O_o00o_.O0.oOOO_o0.[array4[0]] = null;
						}
						else
						{
							O_o00o_.O0.oOOO_o0.[array4[0]] = array4[1];
						}
					}
				}
				Regex regex = new Regex("[\\r\\n]+", RegexOptions.Singleline);
				Regex regex2 = new Regex("[=\\s]+");
				foreach (string input in regex.Split(SysInfo.ImportsStrings))
				{
					string[] array6 = regex2.Split(input);
					if (array6.Length == 3)
					{
						O_o00o_.O0.oOOO_o0.[array6[2]] = array6[1];
					}
				}
			}
			base.ActiveView.Properties["OnlyCommonTypes"] = "1";
			base.ActiveView.Properties["CommitWithSpaceKey"] = "1";
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		private void <<EMPTY_NAME>>(object A_0, DoWorkEventArgs A_1)
		{
			FileAssemblyDocumentation documentation = new FileAssemblyDocumentation(O_O0OO.o.00O_O.() + "Foxtable.xml");
			this.O0.oOOO_o0..AssemblyReferences.AddMsCorLib().Assembly.Documentation = documentation;
			this.O0.oOOO_o0..AssemblyReferences.Add("System");
			foreach (string text in SysInfo.referFiles.Split(new char[]
			{
				'\n',
				'\r'
			}, StringSplitOptions.RemoveEmptyEntries))
			{
				text = Path.GetFileNameWithoutExtension(text);
				IProjectAssemblyReference projectAssemblyReference = this.O0.oOOO_o0..AssemblyReferences.Add(text);
				if (projectAssemblyReference == null)
				{
					projectAssemblyReference = this.O0.oOOO_o0..AssemblyReferences.Add(Assembly.LoadWithPartialName(text));
				}
				if (projectAssemblyReference != null && projectAssemblyReference.Assembly.Name.StartsWith("Foxtable"))
				{
					projectAssemblyReference.Assembly.Documentation = documentation;
				}
			}
			this.o.00oO0Oo..Clear();
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
			{
				"Refrence",
				o0_O.oOO0.oO0O0__.
			});
			if (dataRow != null && !dataRow.IsNull("Config"))
			{
				string[] array2 = dataRow["Config"].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				int num = array2.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(array2[j]);
					IProjectAssemblyReference projectAssemblyReference2 = null;
					if (array2[j].StartsWith("System.", StringComparison.CurrentCultureIgnoreCase))
					{
						projectAssemblyReference2 = this.O0.oOOO_o0..AssemblyReferences.Add(fileNameWithoutExtension);
					}
					else if (OO_00oOO.FileSys.FileExists(O_O0OO.o.00O_O.() + array2[j]))
					{
						projectAssemblyReference2 = this.O0.oOOO_o0..AssemblyReferences.Add(fileNameWithoutExtension);
					}
					if (projectAssemblyReference2 != null)
					{
						try
						{
							foreach (INamespaceDefinition namespaceDefinition in projectAssemblyReference2.Assembly.Namespaces)
							{
								if (Operators.CompareString(namespaceDefinition.FullName, "", true) > 0)
								{
									this.o.00oO0Oo..Add(namespaceDefinition.FullName);
								}
							}
						}
						finally
						{
							IEnumerator<INamespaceDefinition> enumerator;
							if (enumerator != null)
							{
								enumerator.Dispose();
							}
						}
					}
				}
			}
			if (this.o0o_O_._.)
			{
				this.o_.o_o_O_0.();
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000F250 File Offset: 0x0000D450
		private void <<EMPTY_NAME>>(object A_0, RunWorkerCompletedEventArgs A_1)
		{
			if (base.FindForm() != null && !base.FindForm().Disposing && !base.FindForm().IsDisposed)
			{
				base.FindForm().Text = this.OoO_.0o00o0.;
				if (base.ActiveView != null)
				{
					base.ActiveView.Properties.Add("SystemReady", "True");
				}
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000F2B4 File Offset: 0x0000D4B4
		internal void <<EMPTY_NAME>>()
		{
			if (this.O0.oOOO_o0. != null)
			{
				this.O0.oOOO_o0..AssemblyReferences.Remove(this.O0.oOOO_o0.);
			}
			string text = OO_00oOO.ProjectPath + "Bin\\" + Path.GetFileNameWithoutExtension(OO_00oOO.FileSys.GetName(OO_00oOO.ProjectFile)) + ".Public.dll";
			if (!c.OOOOO.o.().FileSystem.FileExists(text))
			{
				o0_.Oo_0.OOo0oO0.("'abcde", "", O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()], false, "", true);
			}
			if (c.OOOOO.o.().FileSystem.FileExists(text))
			{
				Assembly assembly = Assembly.Load(File.ReadAllBytes(text));
				this.O0.oOOO_o0. = this.O0.oOOO_o0..AssemblyReferences.Add(assembly);
				List<string> list = new List<string>();
				try
				{
					foreach (ITypeDefinition typeDefinition in this.O0.oOOO_o0..Assembly.Namespaces[0].Types["UserCode", false].NestedTypes)
					{
						if (typeDefinition.Access == TypeAccess.Public && !typeDefinition.IsHidden)
						{
							list.Add(typeDefinition.Name);
						}
					}
				}
				finally
				{
					IEnumerator<ITypeDefinition> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				oO0O_oO_0O_ oO0O_oO_0O_ = (oO0O_oO_0O_)base.Document.Language.GetService<VBCompletionProvider>();
				if (oO0O_oO_0O_ != null)
				{
					oO0O_oO_0O_.o_OO000.o_0oO. = list;
				}
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000F42C File Offset: 0x0000D62C
		internal void <<EMPTY_NAME>>()
		{
			base.Document.SetHeaderAndFooterText(this.Ooo0.00.(), this.OoO.O_O.());
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000F448 File Offset: 0x0000D648
		internal string <<EMPTY_NAME>>()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Option Strict Off\r\n");
			stringBuilder.Append("Option Compare Text\r\n");
			string[] array = SysInfo.spaceNames.Split(new char[]
			{
				'\n',
				'\r'
			}, StringSplitOptions.RemoveEmptyEntries);
			DataRow dataRow;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(new char[]
					{
						'(',
						')'
					}, StringSplitOptions.RemoveEmptyEntries);
					if (!array2[0].StartsWith("'"))
					{
						if (array2.Length == 1)
						{
							stringBuilder.Append("Imports " + array2[0] + "\r\n");
						}
						else
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								"Imports ",
								array2[1],
								" = ",
								array2[0],
								"\r\n"
							}));
						}
					}
				}
				dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.OOo0._00O_o00.()].Rows.Find(new object[]
				{
					"Space",
					o0_O.oo0o_OoO_.Oo.
				});
			}
			if (dataRow != null && !dataRow.IsNull("Config"))
			{
				string[] array3 = dataRow["Config"].ToString().Split(new char[]
				{
					'\n',
					'\r'
				}, StringSplitOptions.RemoveEmptyEntries);
				int num = array3.Length - 1;
				for (int j = 0; j <= num; j++)
				{
					string[] array4 = array3[j].Split(new char[]
					{
						'(',
						')'
					}, StringSplitOptions.RemoveEmptyEntries);
					if (array4.Length == 1)
					{
						stringBuilder.Append("Imports " + array4[0] + "\r\n");
					}
					else
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							"Imports ",
							array4[1],
							" = ",
							array4[0],
							"\r\n"
						}));
					}
				}
			}
			stringBuilder.Append(SysInfo.ImportsStrings + "\r\n");
			stringBuilder.Append("Public Module O" + OoOo0O.OO_o.0o_O.(8) + "\r\n");
			stringBuilder.AppendLine(this.O0oOO0_.00Ooo.());
			foreach (string item in new string[]
			{
				"List",
				"Dictionary",
				"MessageBox",
				"TimeSpan",
				"Math",
				"Font",
				"OpenFileDialog",
				"SaveFileDialog",
				"ClipBoard",
				"SendKeys",
				"JObject",
				"JArray",
				"JToken",
				"JProperty",
				"Image",
				"JsonConvert",
				"StringBuilder",
				"DialogResult",
				"Array"
			})
			{
				this.O0_.o0o..Add(item);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000F74A File Offset: 0x0000D94A
		public string <<EMPTY_NAME>>()
		{
			return "\r\n" + this.OO.O0ooO_.() + "\r\nEnd Module";
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000F764 File Offset: 0x0000D964
		private void <<EMPTY_NAME>>(object A_0, KeyEventArgs A_1)
		{
			if (base.IntelliPrompt.Sessions.Contains(IntelliPromptSessionTypes.Completion) && A_1.KeyCode == Keys.Space)
			{
				ITextSnapshotReader reader = base.ActiveView.GetReader();
				if (reader.GoToPreviousWordStart())
				{
					IToken token = O_ooO0.Oo_Oo0O._oOoO.(reader);
					if (token != null && (token.Id == 11068 || token.Id == 11152 || token.Id == 11159))
					{
						int num = base.IntelliPrompt.Sessions.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							if (base.IntelliPrompt.Sessions[i] is CompletionSession)
							{
								CompletionSession completionSession = (CompletionSession)base.IntelliPrompt.Sessions[i];
								if (completionSession.IsOpen && Operators.CompareString(completionSession.Selection.Item.AutoCompletePreText, "New", true) != 0)
								{
									completionSession.Commit();
									A_1.Handled = true;
									A_1.SuppressKeyPress = true;
									return;
								}
							}
						}
					}
				}
			}
			if (A_1.KeyCode == Keys.Space && !base.ActiveView.Properties.ContainsKey("CommitWithSpaceKey") && base.IntelliPrompt.Sessions.Contains(IntelliPromptSessionTypes.Completion))
			{
				base.IntelliPrompt.CloseSessions(IntelliPromptSessionTypes.Completion);
			}
			bool flag = false;
			if (A_1.KeyCode == Keys.Return && (DateTime.Now - this.OOO.00_.).TotalMilliseconds > 50.0)
			{
				flag = true;
			}
			if (OO_00oOO.ModifierKey == Keys.Control && A_1.KeyCode == Keys.D)
			{
				if (base.ActiveView.Selection.Length == 0 && Operators.CompareString(base.ActiveView.CurrentSnapshotLine.Text, "", true) > 0)
				{
					base.SuspendPainting();
					string text = base.ActiveView.CurrentSnapshotLine.Text;
					int caretCharacterColumn = base.ActiveView.Selection.CaretCharacterColumn;
					base.ActiveView.Selection.MoveToNextLineStartAfterIndentation();
					base.ActiveView.Selection.MoveToLineStart();
					base.ActiveView.InsertSurroundingText(text, "\n");
					base.ActiveView.Selection.StartPosition = new TextPosition(base.ActiveView.CurrentSnapshotLine.Index, caretCharacterColumn, false);
					base.ResumePainting();
					A_1.Handled = true;
					A_1.SuppressKeyPress = true;
					return;
				}
			}
			else if (A_1.KeyCode == Keys.Space)
			{
				if (base.IntelliPrompt.Sessions.Contains(IntelliPromptSessionTypes.Completion))
				{
					IToken token2 = base.ActiveView.GetReader().ReadTokenReverse();
					if (token2 != null && (token2.Id == 11000 || token2.Id == 11003 || token2.Id == 11010))
					{
						A_1.Handled = true;
						A_1.SuppressKeyPress = true;
						SendKeys.Send("{TAB}");
						if (this.O0.oOOO_o0. != null && this.O0.oOOO_o0..IsOpen)
						{
							SendKeys.Send(" ");
							return;
						}
					}
				}
			}
			else if (A_1.KeyCode == Keys.F1)
			{
				ITextSnapshotReader reader2 = base.ActiveView.GetReader();
				IToken token3 = reader2.PeekToken();
				if (token3 != null)
				{
					if (token3.Id == 11033)
					{
						IToken token4 = null;
						while (!reader2.IsAtSnapshotLineEnd)
						{
							token4 = reader2.ReadToken();
							if (token4.Id == 11068)
							{
								break;
							}
						}
						if (token4 != null && token4.Id == 11068)
						{
							while (!reader2.IsAtSnapshotLineEnd)
							{
								token3 = reader2.ReadToken();
								if (token3.Id != 11000 && token3.Id != 11152)
								{
									break;
								}
							}
						}
					}
					if ((token3.Id == 11033 || token3.Id == 11192 || token3.Id == 11097) && reader2.Offset >= token3.StartOffset)
					{
						IDotNetContext dotNetContext = new VBContextFactory().CreateContext(new TextSnapshotOffset(base.ActiveView.CurrentSnapshot, token3.EndOffset - 1), DotNetContextKind.Self);
						IResolverResultSet a_ = dotNetContext.Resolve();
						this.ooO0._o_0O0.(a_, dotNetContext);
						return;
					}
				}
			}
			else if (A_1.KeyCode == Keys.Return && !A_1.Control && !A_1.Shift && !A_1.Alt)
			{
				ITextSnapshotReader reader3 = base.ActiveView.GetReader();
				int offset = reader3.Offset;
				int num2 = reader3.SnapshotLine.EndOffset;
				int startOffset = reader3.SnapshotLine.StartOffset;
				IToken token5 = reader3.PeekToken();
				if (!VBTokenId.IsVBXmlLiteralClassificationType(token5.Id) && !VBTokenId.IsXmlDocumentationCommentClassificationType(token5.Id) && !VBTokenId.IsXmlDocumentationTagClassificationType(token5.Id))
				{
					reader3.GoToCurrentSnapshotLineEnd();
					IToken token6 = reader3.ReadTokenReverse();
					if (token6 != null && token6.Id == 11000)
					{
						num2 -= token6.Length;
						base.Document.DeleteText(TextChangeTypes.AutoCorrect, token6.TextRange);
					}
					if (offset >= num2)
					{
						string input = base.ActiveView.CurrentViewLine.Text.Trim();
						string[] array = O_ooO0.O__o.O000..Split(input);
						if (Operators.CompareString(array[0], "if", true) == 0 || (Operators.CompareString(array[0], "for", true) == 0 && flag) || (Operators.CompareString(array[0], "do", true) == 0 || Operators.CompareString(array[0], "while", true) == 0 || Operators.CompareString(array[0], "#if", true) == 0 || Operators.CompareString(array[0], "#region", true) == 0 || Operators.CompareString(array[0], "try", true) == 0 || (array.Length > 1 && Operators.CompareString(array[0], "with", true) == 0)) || (array.Length > 1 && Operators.CompareString(array[0], "select", true) == 0 && Operators.CompareString(array[1], "case", true) == 0))
						{
							IOutliningNode outliningNode = base.Document.OutliningManager.RootNode.FindNodeRecursive(num2);
							if (outliningNode != null && base.ActiveView.CurrentSnapshotLine.Index != outliningNode.SnapshotRange.StartLine.Index)
							{
								outliningNode = null;
							}
							if (outliningNode == null)
							{
								string text2 = base.ActiveView.CurrentViewLine.Text.Substring(0, base.ActiveView.CurrentViewLine.FirstNonWhitespaceCharacterIndex);
								string text3 = string.Concat(new string[]
								{
									"\n",
									text2,
									this.o._OOOO__.(),
									"\n",
									text2
								});
								string left = array[0];
								if (Operators.CompareString(left, "if", true) == 0)
								{
									if (O_ooO0.o.o__O_.(reader3) != null)
									{
										return;
									}
									text3 += "End If ";
								}
								else if (Operators.CompareString(left, "for", true) == 0)
								{
									text3 += "Next ";
								}
								else if (Operators.CompareString(left, "do", true) == 0)
								{
									text3 += "Loop ";
								}
								else if (Operators.CompareString(left, "while", true) == 0)
								{
									text3 += "End While ";
								}
								else if (Operators.CompareString(left, "with", true) == 0)
								{
									text3 += "End With ";
								}
								else if (Operators.CompareString(left, "select", true) == 0)
								{
									text3 = string.Concat(new string[]
									{
										"\n",
										text2,
										this.o._OOOO__.(),
										"Case \n",
										text2,
										"End Select "
									});
								}
								else if (Operators.CompareString(left, "try", true) == 0)
								{
									text3 = string.Concat(new string[]
									{
										"\n",
										text2,
										this.o._OOOO__.(),
										"\nCatch ex As Exception \n",
										text2,
										this.o._OOOO__.(),
										"\n",
										text2,
										"End Try "
									});
								}
								else if (Operators.CompareString(left, "#if", true) == 0)
								{
									text3 += "#End If";
								}
								else if (Operators.CompareString(left, "#region", true) == 0)
								{
									text3 += "#End region";
								}
								base.Document.InsertText(TextChangeTypes.AutoCorrect, num2, text3);
								base.ActiveView.Selection.CaretOffset = startOffset;
								base.ActiveView.Selection.MoveToNextLineStartAfterIndentation();
								base.ActiveView.Selection.MoveToLineEnd();
								A_1.Handled = true;
								A_1.SuppressKeyPress = true;
							}
						}
					}
				}
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00010024 File Offset: 0x0000E224
		private bool <<EMPTY_NAME>>()
		{
			ITextSnapshotReader reader = base.ActiveView.GetReader();
			IToken token = null;
			IToken token2 = null;
			while (!reader.IsAtSnapshotLineStart)
			{
				IToken token3 = reader.ReadTokenReverse();
				if (token3.Id == 11196)
				{
					token = token3;
				}
				if (token2 == null && !VBTokenId.IsCommentClassificationType(token3.Id))
				{
					token2 = token3;
				}
			}
			return token != null && token.StartOffset != token2.StartOffset;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00010090 File Offset: 0x0000E290
		private string <<EMPTY_NAME>>()
		{
			return new string(' ', 4);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001009C File Offset: 0x0000E29C
		private void <<EMPTY_NAME>>(object A_0, OverlayPaneEventArgs A_1)
		{
			SearchOverlayPane searchOverlayPane = (SearchOverlayPane)A_1.Pane;
			if (!O_o00o_.O0_.o0o.)
			{
				O_o00o_.O0_.o0o. = true;
				searchOverlayPane.SearchOptions.MatchWholeWord = true;
			}
			searchOverlayPane.SearchOptions.Scope = EditorSearchScope.Document;
			searchOverlayPane.CanToggleReplace = true;
			try
			{
				foreach (object obj in searchOverlayPane.Controls)
				{
					System.Windows.Forms.Control control = (System.Windows.Forms.Control)obj;
					if (control is System.Windows.Forms.ComboBox)
					{
						control.Visible = false;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0001013C File Offset: 0x0000E33C
		private void <<EMPTY_NAME>>(object A_0, EditorSnapshotChangingEventArgs A_1)
		{
			int num;
			int num6;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (A_1.TextChange.Type != TextChangeTypes.Typing || A_1.TextChange.IsRedo || A_1.TextChange.IsUndo || Operators.CompareString(A_1.TypedText, "", true) <= 0)
				{
					goto IL_11F;
				}
				IL_55:
				num2 = 3;
				if (A_1.TypedText.Length != 1 || (DateTime.Now - this.O.00_O.).TotalSeconds >= 0.5)
				{
					goto IL_157;
				}
				IL_8F:
				num2 = 4;
				int num3 = Strings.AscW(A_1.TypedText);
				if (num3 <= 41)
				{
					if (num3 != 34)
					{
						if (num3 != 41)
						{
							goto IL_157;
						}
						goto IL_FA;
					}
				}
				else if (num3 - 8220 > 3 && num3 != 65282)
				{
					if (num3 != 65289)
					{
						goto IL_157;
					}
					goto IL_FA;
				}
				IL_D7:
				num2 = 6;
				if (Operators.CompareString(this.o.o00_., "\"\"", true) != 0)
				{
					goto IL_157;
				}
				IL_EC:
				num2 = 7;
				A_1.Cancel = true;
				goto IL_77A;
				IL_FA:
				num2 = 10;
				if (Operators.CompareString(this.o.o00_., "()", true) != 0)
				{
					goto IL_157;
				}
				IL_110:
				num2 = 11;
				A_1.Cancel = true;
				goto IL_77A;
				IL_11F:
				num2 = 15;
				if (A_1.TextChange.Type != TextChangeTypes.Enter)
				{
					goto IL_157;
				}
				IL_134:
				num2 = 16;
				base.ActiveView.ReplaceSelectedText(TextChangeTypes.Typing, "\n");
				IL_14D:
				num2 = 17;
				A_1.Cancel = true;
				IL_157:
				num2 = 18;
				this.O0.oOOO_o0. = DateTime.Now;
				IL_165:
				num2 = 19;
				string left = "";
				IL_16E:
				num2 = 20;
				if (A_1.TextChange.Type != TextChangeTypes.Indent && Operators.CompareString(A_1.TypedText, "\t", true) != 0)
				{
					goto IL_1D6;
				}
				IL_196:
				num2 = 21;
				left = O_ooO0.o.o__O_.(base.ActiveView.GetReader(), null, base.ActiveView);
				IL_1B1:
				num2 = 22;
				if (Operators.CompareString(left, "", true) <= 0)
				{
					goto IL_1D6;
				}
				IL_1C3:
				num2 = 23;
				base.ActiveView.SelectedText = "";
				IL_1D6:
				num2 = 24;
				if ((A_1.TextChange.Type != TextChangeTypes.Typing && A_1.TextChange.Type != TextChangeTypes.Indent) || A_1.TextChange.Operations.Count != 1 || Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, "", true) <= 0 || (A_1.TextChange.Operations[0].InsertedText.Length != 1 && A_1.TextChange.Type != TextChangeTypes.Indent) || base.ActiveView.Selection.Length != 0)
				{
					goto IL_77A;
				}
				IL_285:
				num2 = 25;
				if (Operators.CompareString(A_1.TypedText, "\t", true) != 0 && A_1.TextChange.Type != TextChangeTypes.Indent)
				{
					goto IL_3F0;
				}
				IL_2B0:
				num2 = 26;
				if (Operators.CompareString(left, "", true) <= 0)
				{
					goto IL_365;
				}
				IL_2C5:
				num2 = 27;
				if (Operators.CompareString(left, "Functions", true) != 0)
				{
					goto IL_343;
				}
				IL_2D6:
				num2 = 28;
				if (!base.IntelliPrompt.Sessions.Contains(IntelliPromptSessionTypes.ParameterInfo))
				{
					goto IL_343;
				}
				IL_2F0:
				num2 = 29;
				IEnumerator<IIntelliPromptSession> enumerator = base.IntelliPrompt.Sessions.GetEnumerator();
				while (enumerator.MoveNext())
				{
					IIntelliPromptSession intelliPromptSession = enumerator.Current;
					IL_310:
					num2 = 30;
					if (intelliPromptSession is ParameterInfoSession)
					{
						IL_31C:
						num2 = 31;
						intelliPromptSession.Close(true);
						break;
					}
					IL_329:
					num2 = 33;
				}
				IL_335:
				num2 = 34;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_343:
				num2 = 35;
				A_1.Cancel = true;
				IL_34D:
				num2 = 36;
				base.ActiveView.IntelliPrompt.RequestCompletionSession();
				goto IL_77A;
				IL_365:
				num2 = 38;
				ITextSnapshotReader reader = base.ActiveView.GetReader();
				IL_375:
				num2 = 39;
				IToken token = reader.PeekTokenReverse();
				IL_381:
				num2 = 40;
				if (token == null)
				{
					goto IL_77A;
				}
				IL_38B:
				num2 = 41;
				if ((token.Id != 11010 && token.Id != 11033 && token.Id != 11142) || token.EndOffset != reader.Offset)
				{
					goto IL_77A;
				}
				IL_3CE:
				num2 = 42;
				A_1.Cancel = true;
				IL_3D8:
				num2 = 43;
				base.ActiveView.IntelliPrompt.RequestAutoComplete();
				goto IL_77A;
				IL_3F0:
				num2 = 45;
				ITextSnapshotReader reader2 = base.ActiveView.GetReader();
				IL_400:
				num2 = 46;
				bool flag = true;
				IL_406:
				num2 = 47;
				if (!reader2.IsAtSnapshotLineEnd)
				{
					goto IL_45A;
				}
				IL_412:
				num2 = 48;
				IToken token2 = reader2.ReadTokenReverse();
				IL_41E:
				num2 = 49;
				if (token2 == null || (token2.Id != 11017 && token2.Id != 11019 && token2.Id != 11021))
				{
					goto IL_4AB;
				}
				IL_452:
				num2 = 50;
				flag = false;
				goto IL_4AB;
				IL_45A:
				num2 = 52;
				IToken token3 = reader2.ReadToken();
				IL_466:
				num2 = 53;
				if (token3 == null || (token3.Id != 11028 && token3.Id != 11017 && token3.Id != 11019 && token3.Id != 11021))
				{
					goto IL_4AB;
				}
				IL_4A5:
				num2 = 54;
				flag = false;
				IL_4AB:
				num2 = 55;
				if (!flag || Operators.CompareString(A_1.TypedText, "", true) <= 0)
				{
					goto IL_77A;
				}
				IL_4CC:
				num2 = 56;
				int num4 = Strings.AscW(A_1.TypedText);
				if (num4 <= 8223)
				{
					if (num4 - 8216 <= 1)
					{
						goto IL_72F;
					}
					if (num4 - 8220 > 3)
					{
						goto IL_77A;
					}
				}
				else
				{
					if (num4 != 12288)
					{
						if (num4 != 12290)
						{
							switch (num4)
							{
							case 65282:
								goto IL_6BC;
							case 65283:
							case 65284:
							case 65306:
							case 65307:
							case 65311:
							case 65312:
							case 65339:
							case 65341:
							case 65344:
								goto IL_77A;
							case 65285:
							case 65286:
							case 65287:
							case 65289:
							case 65290:
							case 65291:
							case 65292:
							case 65293:
							case 65295:
							case 65296:
							case 65297:
							case 65298:
							case 65299:
							case 65300:
							case 65301:
							case 65302:
							case 65303:
							case 65304:
							case 65305:
							case 65308:
							case 65309:
							case 65310:
							case 65313:
							case 65314:
							case 65315:
							case 65316:
							case 65317:
							case 65318:
							case 65319:
							case 65320:
							case 65321:
							case 65322:
							case 65323:
							case 65324:
							case 65325:
							case 65326:
							case 65327:
							case 65328:
							case 65329:
							case 65330:
							case 65331:
							case 65332:
							case 65333:
							case 65334:
							case 65335:
							case 65336:
							case 65337:
							case 65338:
							case 65340:
							case 65342:
							case 65343:
							case 65345:
							case 65346:
							case 65347:
							case 65348:
							case 65349:
							case 65350:
							case 65351:
							case 65352:
							case 65353:
							case 65354:
							case 65355:
							case 65356:
							case 65357:
							case 65358:
							case 65359:
							case 65360:
							case 65361:
							case 65362:
							case 65363:
							case 65364:
							case 65365:
							case 65366:
							case 65367:
							case 65368:
							case 65369:
							case 65370:
								goto IL_72F;
							case 65288:
								IL_6F7:
								num2 = 65;
								base.ActiveView.ReplaceSelectedText(TextChangeTypes.Typing, "()");
								IL_710:
								num2 = 66;
								base.ActiveView.Selection.MoveLeft();
								IL_723:
								num2 = 67;
								A_1.Cancel = true;
								goto IL_77A;
							case 65294:
								break;
							default:
								goto IL_77A;
							}
						}
						IL_694:
						num2 = 58;
						base.ActiveView.ReplaceSelectedText(TextChangeTypes.Typing, ".");
						IL_6AD:
						num2 = 59;
						A_1.Cancel = true;
						goto IL_77A;
					}
					goto IL_72F;
				}
				IL_6BC:
				num2 = 61;
				base.ActiveView.ReplaceSelectedText(TextChangeTypes.Typing, "\"\"");
				IL_6D5:
				num2 = 62;
				base.ActiveView.Selection.MoveLeft();
				IL_6E8:
				num2 = 63;
				A_1.Cancel = true;
				goto IL_77A;
				IL_72F:
				num2 = 69;
				string text = "＋－＊＼／％＝（）＜＞＾１２３４５６７８９０ａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺ＿＆＇‘’\u3000，";
				IL_739:
				num2 = 70;
				string text2 = "+-*\\/%=()<>^1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_&''' ,";
				IL_743:
				num2 = 71;
				base.ActiveView.ReplaceSelectedText(TextChangeTypes.Typing, Conversions.ToString(text2[text.IndexOf(A_1.TypedText)]));
				IL_770:
				num2 = 72;
				A_1.Cancel = true;
				IL_77A:
				goto IL_8F4;
				IL_77F:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_8B5:
				goto IL_8E9;
				IL_8B7:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_8C7:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_8B7;
			}
			IL_8E9:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_8F4:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00010A64 File Offset: 0x0000EC64
		private void <<EMPTY_NAME>>(object A_0, EditorSnapshotChangedEventArgs A_1)
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
				if (A_1.TextChange.Type != TextChangeTypes.Typing || A_1.TextChange.IsRedo || A_1.TextChange.IsUndo || Operators.CompareString(A_1.TypedText, "", true) <= 0)
				{
					goto IL_8C;
				}
				IL_49:
				num2 = 3;
				if (Operators.CompareString(A_1.TypedText, "\"\"", true) != 0 && Operators.CompareString(A_1.TypedText, "()", true) != 0)
				{
					goto IL_8C;
				}
				IL_71:
				num2 = 4;
				this.o.o00_. = A_1.TypedText;
				IL_7F:
				num2 = 5;
				this.O.00_O. = DateTime.Now;
				IL_8C:
				num2 = 6;
				oO0O_oO_0O_ oO0O_oO_0O_ = (oO0O_oO_0O_)base.Document.Language.GetService<VBCompletionProvider>();
				IL_A4:
				num2 = 7;
				if (A_1.TextChange.Type != TextChangeTypes.AutoComplete || A_1.TextChange.IsRedo || A_1.TextChange.IsUndo)
				{
					goto IL_177;
				}
				IL_DB:
				num2 = 8;
				this.OOO.00_. = DateTime.Now;
				IL_E8:
				num2 = 9;
				ITextSnapshotReader reader = base.ActiveView.GetReader();
				IL_F8:
				num2 = 10;
				IToken token = reader.ReadToken();
				IL_104:
				num2 = 11;
				if (token.Id != 11028 || token.Length <= 2)
				{
					goto IL_177;
				}
				IL_11F:
				num2 = 12;
				if (token.EndOffset >= reader.SnapshotLine.EndOffset)
				{
					goto IL_158;
				}
				IL_137:
				num2 = 13;
				base.ActiveView.Selection.CaretOffset = token.EndOffset + 1;
				goto IL_17F3;
				IL_158:
				num2 = 15;
				base.ActiveView.Selection.CaretOffset = token.EndOffset;
				goto IL_17F3;
				IL_177:
				num2 = 17;
				if (A_1.TextChange.Type != TextChangeTypes.Typing || A_1.TextChange.Operations.Count != 1 || (Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, ",", true) != 0 && Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, "(", true) != 0))
				{
					goto IL_500;
				}
				IL_1EE:
				num2 = 18;
				if (!base.IntelliPrompt.Sessions.Contains(IntelliPromptSessionTypes.ParameterInfo))
				{
					goto IL_433;
				}
				IL_20B:
				num2 = 19;
				ParameterInfoSession parameterInfoSession = null;
				IL_211:
				num2 = 20;
				IEnumerator<IIntelliPromptSession> enumerator = base.IntelliPrompt.Sessions.GetEnumerator();
				while (enumerator.MoveNext())
				{
					IIntelliPromptSession intelliPromptSession = enumerator.Current;
					IL_231:
					num2 = 21;
					if (intelliPromptSession is ParameterInfoSession)
					{
						IL_23D:
						num2 = 22;
						parameterInfoSession = (ParameterInfoSession)intelliPromptSession;
					}
					IL_249:
					num2 = 23;
				}
				IL_255:
				num2 = 24;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_263:
				num2 = 25;
				if (Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, " ", true) != 0)
				{
					goto IL_2D2;
				}
				IL_289:
				num2 = 26;
				ITextSnapshotReader reader2 = base.ActiveView.GetReader();
				IL_299:
				num2 = 27;
				reader2.ReadTokenReverse();
				IL_2A4:
				num2 = 28;
				IToken token2 = reader2.ReadTokenReverse();
				IL_2B0:
				num2 = 29;
				if (!(token2 == null | token2.Id != 11228))
				{
					goto IL_2D2;
				}
				IL_2CC:
				num2 = 30;
				parameterInfoSession = null;
				IL_2D2:
				num2 = 31;
				if (parameterInfoSession == null)
				{
					goto IL_1730;
				}
				IL_2DC:
				num2 = 32;
				if (parameterInfoSession.Items[parameterInfoSession.DisplaySelectedIndex - 1].ContentProvider == null)
				{
					goto IL_1730;
				}
				IL_2FE:
				num2 = 33;
				if (parameterInfoSession.Items[parameterInfoSession.DisplaySelectedIndex - 1].Tag == null)
				{
					goto IL_1730;
				}
				IL_320:
				num2 = 34;
				if (((IParameterizedContentProvider)parameterInfoSession.Items[parameterInfoSession.DisplaySelectedIndex - 1].ContentProvider).ParameterIndex == null)
				{
					goto IL_1730;
				}
				IL_355:
				num2 = 35;
				IParameterDefinitionCollection parameters = ((ITypeMemberResolverResult)parameterInfoSession.Items[parameterInfoSession.DisplaySelectedIndex - 1].Tag).Member.Parameters;
				IL_383:
				num2 = 36;
				int value = ((IParameterizedContentProvider)parameterInfoSession.Items[parameterInfoSession.DisplaySelectedIndex - 1].ContentProvider).ParameterIndex.Value;
				IL_3B5:
				num2 = 37;
				IParameterDefinition parameterDefinition = parameters[value];
				IL_3C3:
				num2 = 38;
				ITypeDefinition typeDefinition = this.O00.0o.(parameterDefinition.Type);
				IL_3D5:
				num2 = 39;
				if (typeDefinition == null || typeDefinition.Kind != TypeDefinitionKind.Enumeration)
				{
					goto IL_3F6;
				}
				IL_3E6:
				num2 = 40;
				this.ooO0._o_0O0.(typeDefinition);
				goto IL_1730;
				IL_3F6:
				num2 = 42;
				if (typeDefinition == null || Operators.CompareString(typeDefinition.FullName, "System.Boolean", true) != 0)
				{
					goto IL_1730;
				}
				IL_417:
				num2 = 43;
				if (!oO0O_oO_0O_.CanShowOnTypedWordStart)
				{
					goto IL_1730;
				}
				IL_425:
				num2 = 44;
				this.O.0_00o__0.();
				goto IL_1730;
				IL_433:
				num2 = 46;
				if (Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, ",", true) != 0)
				{
					goto IL_1730;
				}
				IL_45C:
				num2 = 47;
				ITextSnapshotReader reader3 = base.ActiveView.GetReader();
				IL_46C:
				num2 = 48;
				IToken token3 = O_ooO0.Oo_Oo0O._oOoO.(reader3);
				IL_478:
				num2 = 49;
				if (token3 == null || token3.Id != 11009)
				{
					goto IL_1730;
				}
				IL_493:
				num2 = 50;
				reader3.Offset = token3.StartOffset;
				IL_4A4:
				num2 = 51;
				token3 = O_ooO0.Oo_Oo0O._oOoO.(reader3);
				IL_4B0:
				num2 = 52;
				if (token3 == null)
				{
					goto IL_1730;
				}
				IL_4BA:
				num2 = 53;
				reader3.Offset = token3.StartOffset;
				IL_4CB:
				num2 = 54;
				token3 = O_ooO0.Oo_Oo0O._oOoO.(reader3);
				IL_4D7:
				num2 = 55;
				if (token3 == null || token3.Id != 11159)
				{
					goto IL_1730;
				}
				IL_4F2:
				num2 = 56;
				this.O__o0O.0O_0.();
				goto IL_1730;
				IL_500:
				num2 = 58;
				if (A_1.TextChange.Type != TextChangeTypes.Typing || A_1.TextChange.Operations.Count != 1 || (Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, "=", true) != 0 && Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, " ", true) != 0))
				{
					goto IL_15DC;
				}
				IL_577:
				num2 = 59;
				ITextSnapshotReader reader4 = base.ActiveView.GetReader();
				IL_587:
				num2 = 60;
				bool flag = false;
				IL_58D:
				num2 = 61;
				if (Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, " ", true) != 0)
				{
					goto IL_8BB;
				}
				IL_5B6:
				num2 = 62;
				IToken token4 = O_ooO0.OO00_._00o.(reader4);
				IL_5C2:
				num2 = 63;
				IToken token5 = O_ooO0.Oo_Oo0O._oOoO.(reader4);
				IL_5CE:
				num2 = 64;
				bool flag2 = false;
				IL_5D4:
				num2 = 65;
				if (token4.Id != 11128 || token5.Id == 11225 || token5.Id == 11196)
				{
					goto IL_60C;
				}
				IL_601:
				num2 = 66;
				flag2 = true;
				goto IL_71F;
				IL_60C:
				num2 = 68;
				if (token5.Id != 11159)
				{
					goto IL_62B;
				}
				IL_61D:
				num2 = 69;
				this.O__o0O.0O_0.();
				goto IL_71F;
				IL_62B:
				num2 = 71;
				if (token4.Id != 11033 || token5.Id == 11225 || token5.Id == 11154 || token5.Id == 11196)
				{
					goto IL_71F;
				}
				IL_672:
				num2 = 72;
				IDotNetContext dotNetContext = new VBContextFactory().CreateContext(new TextSnapshotOffset(reader4.Snapshot, token4.StartOffset), DotNetContextKind.Self);
				IL_695:
				num2 = 73;
				IResolverResultSet resolverResultSet = dotNetContext.Resolve();
				IL_6A1:
				num2 = 74;
				if (resolverResultSet.Results.Count != 1 || !(resolverResultSet.Results[0] is IVariableResolverResult))
				{
					goto IL_71F;
				}
				IL_6C7:
				num2 = 75;
				if (!(((IVariableResolverResult)resolverResultSet.Results[0]).Type is ITypeDefinition))
				{
					goto IL_71F;
				}
				IL_6E8:
				num2 = 76;
				if (Operators.CompareString(((ITypeDefinition)((IVariableResolverResult)resolverResultSet.Results[0]).Type).FullName, "System.Boolean", true) != 0)
				{
					goto IL_71F;
				}
				IL_719:
				num2 = 77;
				flag2 = true;
				IL_71F:
				num2 = 78;
				if (!flag2)
				{
					goto IL_89A;
				}
				IL_729:
				num2 = 79;
				IToken token6 = reader4.PeekToken();
				IL_735:
				num2 = 80;
				if (token6.Id != 11001)
				{
					goto IL_752;
				}
				IL_746:
				num2 = 81;
				token6 = reader4.PeekTokenReverse();
				IL_752:
				num2 = 82;
				if (VBTokenId.IsCommentClassificationType(token6.Id))
				{
					goto IL_89A;
				}
				IL_766:
				num2 = 83;
				IDotNetContext dotNetContext2 = new VBContextFactory().CreateContext(new TextSnapshotOffset(base.ActiveView.GetReader().Snapshot, base.ActiveView.Selection.CaretOffset), DotNetContextKind.Self);
				IL_79B:
				num2 = 84;
				IAstNode containingAstNode = dotNetContext2.ContainingAstNode;
				IL_7A7:
				num2 = 85;
				int caretOffset = base.ActiveView.Selection.CaretOffset;
				IL_7BC:
				num2 = 86;
				if (containingAstNode.Children.Count <= 1)
				{
					goto IL_89A;
				}
				IL_7D1:
				num2 = 87;
				IToken token7 = O_ooO0.o00Ooo_0OO.0_.(reader4);
				IL_7DD:
				num2 = 88;
				if (token7 == null || caretOffset < token7.EndOffset)
				{
					goto IL_89A;
				}
				IL_7F5:
				num2 = 89;
				this.Oo__.ooO_o_.().Items.Clear();
				IL_808:
				num2 = 90;
				foreach (string text in new string[]
				{
					"AndAlso",
					"And",
					"OrElse",
					"Or",
					"Is",
					"IsNot"
				})
				{
					IL_84F:
					num2 = 91;
					this.Oo__.ooO_o_.().Items.Add(new CompletionItem(text, new CommonImageSourceProvider(CommonImageKind.Keyword)));
					IL_870:
					num2 = 92;
				}
				IL_881:
				num2 = 93;
				this.Oo__.ooO_o_.().Open(base.ActiveView);
				goto IL_17F3;
				IL_89A:
				num2 = 95;
				reader4 = base.ActiveView.GetReader();
				IL_8AA:
				num2 = 96;
				flag = true;
				IL_8B0:
				num2 = 97;
				reader4.ReadTokenReverse();
				IL_8BB:
				num2 = 98;
				IToken token8 = reader4.ReadTokenReverse();
				IL_8C7:
				num2 = 99;
				IToken token9 = O_ooO0.Oo_Oo0O._oOoO.(reader4);
				IL_8D3:
				num2 = 100;
				IToken token10 = O_ooO0.OO00_._00o.(reader4);
				IL_8DF:
				num2 = 101;
				if (token8 == null || token8.Id != 11118 || !O_ooO0.O__o.O000.(reader4, token8) || !flag)
				{
					goto IL_961;
				}
				IL_903:
				num2 = 102;
				this.O0.oOOO_o0..Items.Clear();
				IL_916:
				num2 = 103;
				this.O0.oOOO_o0..Items.Add(new CompletionItem("Each", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
				IL_93A:
				num2 = 104;
				if (!oO0O_oO_0O_.CanShowOnTypedWordStart)
				{
					goto IL_1730;
				}
				IL_948:
				num2 = 105;
				this.O0.oOOO_o0..Open(base.ActiveView);
				goto IL_1730;
				IL_961:
				num2 = 107;
				if (token8 == null || token8.Id != 11183 || !O_ooO0.O__o.O000.(reader4, token8) || !flag)
				{
					goto IL_9E3;
				}
				IL_985:
				num2 = 108;
				this.O0.oOOO_o0..Items.Clear();
				IL_998:
				num2 = 109;
				this.O0.oOOO_o0..Items.Add(new CompletionItem("Case", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
				IL_9BC:
				num2 = 110;
				if (!oO0O_oO_0O_.CanShowOnTypedWordStart)
				{
					goto IL_1730;
				}
				IL_9CA:
				num2 = 111;
				this.O0.oOOO_o0..Open(base.ActiveView);
				goto IL_1730;
				IL_9E3:
				num2 = 113;
				if (token8 == null || token8.Id != 11033 || token9 == null || (token9.Id != 11102 && token9.Id != 11106 && token9.Id != 11118) || !flag)
				{
					goto IL_A91;
				}
				IL_A33:
				num2 = 114;
				this.O0.oOOO_o0..Items.Clear();
				IL_A46:
				num2 = 115;
				this.O0.oOOO_o0..Items.Add(new CompletionItem("As", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
				IL_A6A:
				num2 = 116;
				if (!oO0O_oO_0O_.CanShowOnTypedWordStart)
				{
					goto IL_1730;
				}
				IL_A78:
				num2 = 117;
				this.O0.oOOO_o0..Open(base.ActiveView);
				goto IL_1730;
				IL_A91:
				num2 = 119;
				if (token8 == null || token8.Id != 11033 || token9 == null || token9.Id != 11068 || token10.Id != 11118 || !flag)
				{
					goto IL_B2E;
				}
				IL_AD0:
				num2 = 120;
				this.O0.oOOO_o0..Items.Clear();
				IL_AE3:
				num2 = 121;
				this.O0.oOOO_o0..Items.Add(new CompletionItem("In", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
				IL_B07:
				num2 = 122;
				if (!oO0O_oO_0O_.CanShowOnTypedWordStart)
				{
					goto IL_1730;
				}
				IL_B15:
				num2 = 123;
				this.O0.oOOO_o0..Open(base.ActiveView);
				goto IL_1730;
				IL_B2E:
				num2 = 125;
				if (token8 == null || token8.Id != 11023 || token9 == null || token9.Id != 11225 || !flag)
				{
					goto IL_C22;
				}
				IL_B68:
				num2 = 126;
				reader4.GoToCurrentSnapshotLineStart();
				IL_B72:
				num2 = 127;
				token8 = reader4.ReadToken();
				IL_B7E:
				num2 = 128;
				if (token8.Id != 11000)
				{
					goto IL_BA1;
				}
				IL_B92:
				num2 = 129;
				token8 = reader4.ReadToken();
				IL_BA1:
				num2 = 130;
				if (token8.Id != 11118)
				{
					goto IL_1730;
				}
				IL_BB8:
				num2 = 131;
				this.O0.oOOO_o0..Items.Clear();
				IL_BCE:
				num2 = 132;
				this.O0.oOOO_o0..Items.Add(new CompletionItem("To", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
				IL_BF5:
				num2 = 133;
				if (!oO0O_oO_0O_.CanShowOnTypedWordStart)
				{
					goto IL_1730;
				}
				IL_C06:
				num2 = 134;
				this.O0.oOOO_o0..Open(base.ActiveView);
				goto IL_1730;
				IL_C22:
				num2 = 136;
				if (token8 == null || token8.Id != 11074 || !O_ooO0.O__o.O000.(reader4, token8))
				{
					goto IL_E56;
				}
				IL_C4E:
				num2 = 137;
				SwitchStatement switchStatement = O_ooO0.O__o.O000.(base.ActiveView.CurrentSnapshot, base.ActiveView.Selection.CaretOffset);
				IL_C76:
				num2 = 138;
				if (switchStatement == null)
				{
					goto IL_1730;
				}
				IL_C83:
				num2 = 139;
				if (switchStatement.StartOffset == null)
				{
					goto IL_1730;
				}
				IL_C9E:
				num2 = 140;
				reader4.Offset = switchStatement.StartOffset.Value;
				IL_CBB:
				num2 = 141;
				reader4.GoToCurrentSnapshotLineEnd();
				for (;;)
				{
					IL_E3F:
					num2 = 143;
					if (reader4.IsAtSnapshotLineStart)
					{
						goto Block_52;
					}
					IL_CCD:
					num2 = 144;
					token8 = reader4.ReadTokenReverse();
					IL_CDC:
					num2 = 145;
					if (token8.Id == 11033)
					{
						break;
					}
					IL_DF6:
					num2 = 159;
					if (token8.Id == 11004)
					{
						IL_E0A:
						num2 = 160;
						if (!reader4.GoToPreviousMatchingTokenById(11004, 11003))
						{
							goto Block_51;
						}
					}
					else
					{
						IL_E28:
						num2 = 163;
						if (VBTokenId.IsKeywordClassificationType(token8.Id))
						{
							goto IL_1730;
						}
					}
				}
				IL_CF3:
				num2 = 146;
				IDotNetContext dotNetContext3 = new VBContextFactory().CreateContext(new TextSnapshotOffset(base.ActiveView.CurrentSnapshot, token8.StartOffset + 1), DotNetContextKind.Self);
				IL_D1F:
				num2 = 147;
				IResolverResultSet resolverResultSet2 = dotNetContext3.Resolve();
				IL_D2E:
				num2 = 148;
				if (resolverResultSet2.Results.Count <= 0)
				{
					goto IL_1730;
				}
				IL_D46:
				num2 = 149;
				IResolverResult resolverResult = resolverResultSet2.Results[0];
				IL_D5B:
				num2 = 150;
				PropertyInfo property = resolverResult.Type.GetType().GetProperty("Kind");
				IL_D79:
				num2 = 151;
				if (property == null)
				{
					goto IL_1730;
				}
				IL_D86:
				num2 = 152;
				TypeDefinitionKind typeDefinitionKind = (TypeDefinitionKind)Conversions.ToInteger(property.GetValue(resolverResult.Type, null));
				IL_DA2:
				num2 = 153;
				if (typeDefinitionKind != TypeDefinitionKind.Unknown && typeDefinitionKind != TypeDefinitionKind.Enumeration)
				{
					goto IL_1730;
				}
				IL_DB4:
				num2 = 154;
				ITypeDefinition typeDefinition2 = this.O00.0o.(resolverResult.Type);
				IL_DC9:
				num2 = 155;
				if (typeDefinition2 == null || typeDefinition2.Kind != TypeDefinitionKind.Enumeration)
				{
					goto IL_1730;
				}
				IL_DE3:
				num2 = 156;
				this.ooO0._o_0O0.(typeDefinition2);
				Block_51:
				Block_52:
				goto IL_1730;
				IL_E56:
				num2 = 167;
				if (token8 == null || token8.Id != 11225)
				{
					goto IL_1730;
				}
				IL_E74:
				num2 = 168;
				token8 = reader4.ReadTokenReverse();
				IL_E83:
				num2 = 169;
				if (token8.Id != 11000 || reader4.IsAtSnapshotLineStart)
				{
					goto IL_EAF;
				}
				IL_EA0:
				num2 = 170;
				token8 = reader4.ReadTokenReverse();
				IL_EAF:
				num2 = 171;
				if (token8 == null || token8.Id != 11004)
				{
					goto IL_EF2;
				}
				IL_EC7:
				num2 = 172;
				if (!reader4.GoToPreviousMatchingTokenById(11004, 11003))
				{
					goto IL_17F3;
				}
				IL_EE3:
				num2 = 174;
				token8 = reader4.ReadTokenReverse();
				IL_EF2:
				num2 = 175;
				if ((token8 == null || token8.Id != 11033) && token8.Id != 11069)
				{
					goto IL_1730;
				}
				IL_F1B:
				num2 = 176;
				IDotNetContext dotNetContext4 = new VBContextFactory().CreateContext(new TextSnapshotOffset(base.ActiveView.CurrentSnapshot, reader4.Offset), DotNetContextKind.Self);
				IL_F45:
				num2 = 177;
				IResolverResultSet resolverResultSet3 = dotNetContext4.Resolve();
				IL_F54:
				num2 = 178;
				if (resolverResultSet3.Results.Count <= 0)
				{
					goto IL_1246;
				}
				IL_F6C:
				num2 = 179;
				IResolverResult resolverResult2 = resolverResultSet3.Results[0];
				IL_F81:
				num2 = 180;
				if (resolverResult2.Type == null || !resolverResult2.Type.QualifiedName.ToString().EndsWith("System.Boolean", StringComparison.OrdinalIgnoreCase))
				{
					goto IL_FBF;
				}
				IL_FAE:
				num2 = 181;
				this.O.0_00o__0.();
				goto IL_1730;
				IL_FBF:
				num2 = 183;
				if (resolverResult2.Type == null)
				{
					goto IL_1730;
				}
				IL_FD1:
				num2 = 184;
				if (dotNetContext4.TargetExpression == null)
				{
					goto IL_1129;
				}
				IL_FE3:
				num2 = 185;
				if (dotNetContext4.TargetExpression.StartOffset == null)
				{
					goto IL_1129;
				}
				IL_1003:
				num2 = 186;
				string substring = reader4.Snapshot.GetSubstring(dotNetContext4.TargetExpression.StartOffset.Value, dotNetContext4.TargetExpression.Length);
				IL_1038:
				num2 = 187;
				if (Operators.CompareString(substring, "e.datacol.name", true) != 0 && Operators.CompareString(substring, "e.col.name", true) != 0)
				{
					goto IL_1129;
				}
				IL_105F:
				num2 = 188;
				if (System.Windows.Forms.Form.ActiveForm == null || !(System.Windows.Forms.Form.ActiveForm is O\u3000\u3002\u3000\u3000))
				{
					goto IL_1129;
				}
				IL_107E:
				num2 = 189;
				ITextSnapshotReader reader5 = base.ActiveView.GetReader();
				IL_1091:
				num2 = 190;
				oO0O_oO_0O_.o_0.O0__OO.().Items.Clear();
				IL_10A6:
				num2 = 191;
				string text2 = O_ooO0.O__o.O000.(reader5, reader5.Offset, oO0O_oO_0O_.o_0.O0__OO.());
				IL_10C1:
				num2 = 192;
				if (Operators.CompareString(text2, "", true) <= 0)
				{
					goto IL_17F3;
				}
				IL_10DA:
				num2 = 193;
				O_ooO0.O._OOo__.(text2, oO0O_oO_0O_.o_0.O0__OO.(), false);
				IL_10ED:
				num2 = 194;
				((oO0O_oO_0O_)base.Document.Language.GetService<VBCompletionProvider>()).CanShowOnTypedWordStart = false;
				IL_110E:
				num2 = 195;
				oO0O_oO_0O_.o_0.O0__OO.().Open(base.ActiveView);
				goto IL_17F3;
				IL_1129:
				num2 = 197;
				PropertyInfo property2 = resolverResult2.Type.GetType().GetProperty("Kind");
				IL_1147:
				num2 = 198;
				if (property2 == null)
				{
					goto IL_1730;
				}
				IL_1154:
				num2 = 199;
				TypeDefinitionKind typeDefinitionKind2 = (TypeDefinitionKind)Conversions.ToInteger(property2.GetValue(resolverResult2.Type, null));
				IL_1170:
				num2 = 200;
				if (typeDefinitionKind2 != TypeDefinitionKind.Unknown && typeDefinitionKind2 != TypeDefinitionKind.Enumeration)
				{
					goto IL_11C1;
				}
				IL_117F:
				num2 = 201;
				ITypeDefinition typeDefinition3 = this.O00.0o.(resolverResult2.Type);
				IL_1194:
				num2 = 202;
				if (typeDefinition3 == null || typeDefinition3.Kind != TypeDefinitionKind.Enumeration)
				{
					goto IL_1730;
				}
				IL_11AE:
				num2 = 203;
				this.ooO0._o_0O0.(typeDefinition3);
				goto IL_1730;
				IL_11C1:
				num2 = 205;
				if (typeDefinitionKind2 != TypeDefinitionKind.Class)
				{
					goto IL_1730;
				}
				IL_11CF:
				num2 = 206;
				ITypeDefinition typeDefinition4 = this.O00.0o.(resolverResult2.Type);
				IL_11E4:
				num2 = 207;
				if (oO0O_oO_0O_.CanShowOnTypedWordStart && typeDefinition4 != null && Operators.CompareString(typeDefinition4.FullName, "Foxtable.Datatable", true) != 0 && Operators.CompareString(typeDefinition4.FullName, "Foxtable.Table", true) != 0 && Operators.CompareString(typeDefinition4.FullName, "FoxTable.WinForm.Form", true) == 0)
				{
					goto IL_1730;
				}
				goto IL_1730;
				IL_1246:
				num2 = 209;
				if (token8.Id != 11033)
				{
					goto IL_1730;
				}
				IL_125D:
				num2 = 210;
				ControlTypeEnum controlTypeEnum = ControlTypeEnum.None;
				IL_126A:
				num2 = 211;
				RibbonItemTypeEnum ribbonItemTypeEnum = RibbonItemTypeEnum.None;
				IL_1277:
				num2 = 212;
				string substring2 = reader4.Snapshot.GetSubstring(token8.TextRange);
				IL_1292:
				num2 = 213;
				token8 = reader4.ReadTokenReverse();
				IL_12A1:
				num2 = 214;
				int offset = reader4.Offset;
				IL_12B0:
				num2 = 215;
				if (O_ooO0.O__o.O000.(reader4, token8, ref controlTypeEnum))
				{
					goto IL_12E4;
				}
				IL_12C3:
				num2 = 216;
				reader4.Offset = offset;
				IL_12D2:
				num2 = 217;
				O_ooO0.O__o.O000.(reader4, token8, ref ribbonItemTypeEnum);
				IL_12E4:
				num2 = 218;
				if (controlTypeEnum == ControlTypeEnum.None && ribbonItemTypeEnum == RibbonItemTypeEnum.None)
				{
					goto IL_1730;
				}
				IL_12FF:
				num2 = 219;
				List<ITypeDefinition> list = new List<ITypeDefinition>();
				IL_130C:
				num2 = 220;
				IEnumerator<IProjectAssemblyReference> enumerator2 = base.Document.Language.GetService<IProjectAssembly>().AssemblyReferences.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					IProjectAssemblyReference projectAssemblyReference = enumerator2.Current;
					IL_133C:
					num2 = 221;
					if (Operators.CompareString(projectAssemblyReference.Assembly.Name, "Foxtable", true) == 0)
					{
						IL_135E:
						num2 = 222;
						if (controlTypeEnum != ControlTypeEnum.None)
						{
							IL_1370:
							num2 = 223;
							list.Add(projectAssemblyReference.Assembly.Namespaces["Foxtable.WinForm", true].Types["Control", true]);
							IL_13A4:
							num2 = 224;
							if (controlTypeEnum != ControlTypeEnum.None)
							{
								IL_13B6:
								num2 = 225;
								list.Add(projectAssemblyReference.Assembly.Namespaces["Foxtable.WinForm", true].Types[controlTypeEnum.ToString(), true]);
							}
						}
						else
						{
							IL_13F7:
							num2 = 227;
							if (ribbonItemTypeEnum != RibbonItemTypeEnum.None)
							{
								IL_1406:
								num2 = 228;
								list.Add(projectAssemblyReference.Assembly.Namespaces["Foxtable.RibbonMenu", true].Types["RibbonItem", true]);
								IL_143A:
								num2 = 229;
								if (ribbonItemTypeEnum != RibbonItemTypeEnum.None)
								{
									IL_1449:
									num2 = 230;
									list.Add(projectAssemblyReference.Assembly.Namespaces["Foxtable.RibbonMenu", true].Types[ribbonItemTypeEnum.ToString(), true]);
								}
							}
						}
						IL_1485:
						num2 = 231;
						List<ITypeDefinition>.Enumerator enumerator3 = list.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							ITypeDefinition typeDefinition5 = enumerator3.Current;
							IL_14A2:
							num2 = 232;
							IEnumerator<ITypeMemberDefinition> enumerator4 = typeDefinition5.Members.GetEnumerator();
							while (enumerator4.MoveNext())
							{
								ITypeMemberDefinition typeMemberDefinition = enumerator4.Current;
								IL_14C4:
								num2 = 233;
								if (Operators.CompareString(typeMemberDefinition.Name, substring2, true) == 0)
								{
									IL_14DB:
									num2 = 234;
									if (typeMemberDefinition.ReturnType == null)
									{
										break;
									}
									IL_14ED:
									num2 = 235;
									ITypeDefinition typeDefinition6 = this.O00.0o.(typeMemberDefinition.ReturnType);
									IL_1502:
									num2 = 236;
									if (typeDefinition6.Kind == TypeDefinitionKind.Enumeration)
									{
										IL_1512:
										num2 = 237;
										this.ooO0._o_0O0.(typeDefinition6);
										break;
									}
									IL_1522:
									num2 = 239;
									if (Operators.CompareString(typeDefinition6.Name, "Boolean", true) == 0)
									{
										IL_153C:
										num2 = 240;
										this.O.0_00o__0.();
										break;
									}
									break;
								}
								else
								{
									IL_154A:
									num2 = 242;
									if (base.IntelliPrompt.Sessions.Contains(IntelliPromptSessionTypes.Completion))
									{
										break;
									}
									IL_1567:
									num2 = 244;
								}
							}
							IL_1579:
							num2 = 245;
							if (enumerator4 != null)
							{
								enumerator4.Dispose();
							}
							IL_158A:
							num2 = 246;
						}
						IL_159C:
						num2 = 247;
						((IDisposable)enumerator3).Dispose();
						break;
					}
					IL_15B1:
					num2 = 249;
				}
				IL_15C3:
				num2 = 250;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
					goto IL_1730;
				}
				goto IL_1730;
				IL_15DC:
				num2 = 252;
				if (A_1.TextChange.Type != TextChangeTypes.Typing || A_1.TextChange.Operations.Count != 1 || Operators.CompareString(A_1.TextChange.Operations[0].InsertedText, "", true) <= 0 || A_1.TextChange.Operations[0].InsertedText.Length != 1)
				{
					goto IL_1730;
				}
				IL_1655:
				num2 = 253;
				if (!oO0O_oO_0O_.CanShowOnTypedWordStart || base.IntelliPrompt.Sessions.Contains(IntelliPromptSessionTypes.Completion))
				{
					goto IL_1730;
				}
				IL_1680:
				num2 = 254;
				ITextSnapshotReader reader6 = base.ActiveView.GetReader();
				IL_1693:
				num2 = 255;
				IToken token11 = reader6.ReadTokenReverse();
				IL_16A2:
				num2 = 256;
				if (token11 == null || token11.Id != 11033)
				{
					goto IL_1730;
				}
				IL_16BD:
				num2 = 257;
				if (token11.Length <= 2 && (token11.Length != 1 || O_o00o_.OOO.00_..Contains(reader6.PeekText(1))) && (token11.Length != 2 || O_o00o_.O0_.o0o..Contains(reader6.PeekText(2))))
				{
					goto IL_1730;
				}
				IL_1709:
				num2 = 258;
				if (!O_ooO0.O__o.O000.(reader6, token11))
				{
					goto IL_1730;
				}
				IL_171A:
				num2 = 259;
				base.ActiveView.IntelliPrompt.RequestCompletionSession();
				IL_1730:
				num2 = 260;
				if (A_1.TextChange.Type != TextChangeTypes.AutoComplete)
				{
					goto IL_17F3;
				}
				IL_174B:
				num2 = 261;
				IEditorView activeView = base.ActiveView;
				IL_1759:
				num2 = 262;
				ITextSnapshotReader reader7 = activeView.GetReader();
				IL_1768:
				num2 = 263;
				IToken token12 = reader7.PeekTokenReverse();
				IL_1777:
				num2 = 264;
				IToken token13 = reader7.PeekToken();
				IL_1786:
				num2 = 265;
				if (token13 != null && token13.Id == 11028)
				{
					goto IL_17F3;
				}
				IL_179E:
				num2 = 267;
				if (token12 == null)
				{
					goto IL_17F3;
				}
				IL_17A8:
				num2 = 268;
				IDotNetContext dotNetContext5 = new VBContextFactory().CreateContext(new TextSnapshotOffset(activeView.CurrentSnapshot, activeView.Selection.CaretOffset), DotNetContextKind.Self);
				IL_17D3:
				num2 = 269;
				IResolverResultSet a_ = dotNetContext5.Resolve();
				IL_17E2:
				num2 = 270;
				this.ooO0._o_0O0.(a_, dotNetContext5);
				IL_17F3:
				goto IL_1C81;
				IL_17F8:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1C42:
				goto IL_1C76;
				IL_1C44:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1C54:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1C44;
			}
			IL_1C76:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1C81:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00012718 File Offset: 0x00010918
		private void <<EMPTY_NAME>>()
		{
			this.Oo__.ooO_o_.().Items.Clear();
			foreach (string text in new string[]
			{
				"Double",
				"Integer",
				"Long",
				"Date",
				"Byte",
				"String",
				"DataRow",
				"Row",
				"DataTale",
				"Table",
				"TimeSpan",
				"Char"
			})
			{
				this.Oo__.ooO_o_.().Items.Add(new CompletionItem(text, new CommonImageSourceProvider(CommonImageKind.ClassPublic)));
			}
			this.Oo__.ooO_o_.().SortItems();
			this.Oo__.ooO_o_.().Open(base.ActiveView);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000127EC File Offset: 0x000109EC
		private void <<EMPTY_NAME>>()
		{
			this.Oo__.ooO_o_.().Items.Clear();
			this.Oo__.ooO_o_.().Items.Add(new CompletionItem("True", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
			this.Oo__.ooO_o_.().Items.Add(new CompletionItem("False", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
			this.Oo__.ooO_o_.().Items.Add(new CompletionItem("Not", new CommonImageSourceProvider(CommonImageKind.FieldPublic)));
			this.Oo__.ooO_o_.().Open(base.ActiveView);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0001287D File Offset: 0x00010A7D
		[CompilerGenerated]
		private virtual CompletionSession <<EMPTY_NAME>>()
		{
			return this.O0O.__Oo_0__o.;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00012888 File Offset: 0x00010A88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(CompletionSession A_0)
		{
			EventHandler value = new EventHandler(this.OO.0_O_O0O__0.);
			EventHandler<CancelEventArgs> value2 = new EventHandler<CancelEventArgs>(this.OO._o__o.);
			CompletionSession o0O.__Oo_0__o. = this.O0O.__Oo_0__o.;
			if (o0O.__Oo_0__o. != null)
			{
				o0O.__Oo_0__o..Opened -= value;
				o0O.__Oo_0__o..Closed -= value2;
			}
			this.O0O.__Oo_0__o. = A_0;
			o0O.__Oo_0__o. = this.O0O.__Oo_0__o.;
			if (o0O.__Oo_0__o. != null)
			{
				o0O.__Oo_0__o..Opened += value;
				o0O.__Oo_0__o..Closed += value2;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000128E8 File Offset: 0x00010AE8
		private void <<EMPTY_NAME>>(ITypeDefinition A_0)
		{
			if (A_0.Name.StartsWith("MessageBox"))
			{
				base.IntelliPrompt.CloseAllSessions();
			}
			if (A_0 != null && A_0.Kind == TypeDefinitionKind.Enumeration)
			{
				this.Oo__.ooO_o_.().Items.Clear();
				string str;
				if (O_o00o_.O0.oOOO_o0..ContainsKey(A_0.FullName))
				{
					str = O_o00o_.O0.oOOO_o0.[A_0.FullName];
				}
				else if (O_o00o_.O0.oOOO_o0..ContainsKey(A_0.Namespace))
				{
					if (Operators.CompareString(O_o00o_.O0.oOOO_o0.[A_0.Namespace], "", true) > 0)
					{
						str = O_o00o_.O0.oOOO_o0.[A_0.Namespace] + "." + A_0.Name;
					}
					else
					{
						str = A_0.Name;
					}
				}
				else
				{
					string text = this.O00.0o.(A_0.Namespace);
					if (Operators.CompareString(text, "", true) > 0)
					{
						str = text + "." + A_0.Name;
					}
					else
					{
						str = A_0.FullName;
					}
				}
				str += ".";
				try
				{
					foreach (ITypeMemberDefinition typeMemberDefinition in A_0.Members)
					{
						if (typeMemberDefinition.Access == TypeMemberAccess.Public && typeMemberDefinition.Kind == TypeMemberDefinitionKind.Field && Operators.CompareString(typeMemberDefinition.ReturnType.QualifiedName.ToString(), A_0.QualifiedName.ToString(), true) == 0)
						{
							this.Oo__.ooO_o_.().Items.Add(new CompletionItem(str + typeMemberDefinition.Name, new CommonImageSourceProvider(CommonImageKind.ConstantPublic)));
						}
					}
				}
				finally
				{
					IEnumerator<ITypeMemberDefinition> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.Oo__.ooO_o_.().MatchOptions = (CompletionMatchOptions.TargetsDisplayText | CompletionMatchOptions.UseAcronyms | CompletionMatchOptions.UseShorthand);
				this.Oo__.ooO_o_.().Open(base.ActiveView);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00012AB0 File Offset: 0x00010CB0
		private string <<EMPTY_NAME>>(string A_0)
		{
			try
			{
				foreach (string text in O_o00o_.O0.oOOO_o0..Keys)
				{
					if (A_0.StartsWith(text + ".", StringComparison.OrdinalIgnoreCase))
					{
						string text2 = A_0.Substring(text.Length + 1);
						if (Operators.CompareString(O_o00o_.O0.oOOO_o0.[text], "", true) > 0)
						{
							return O_o00o_.O0.oOOO_o0.[text] + "." + text2;
						}
						if (Operators.CompareString(text2, "Windows.Forms", true) == 0)
						{
							text2 = "System.Windows.Forms";
						}
						return text2;
					}
				}
			}
			finally
			{
				Dictionary<string, string>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return "";
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00012B74 File Offset: 0x00010D74
		private ITypeDefinition <<EMPTY_NAME>>(ITypeReference A_0)
		{
			ITypeDefinition result = null;
			if (A_0.IsTypeDefinition)
			{
				result = (ITypeDefinition)A_0;
			}
			else
			{
				if (A_0.AssemblyName == null)
				{
					return null;
				}
				IAssembly assembly = null;
				try
				{
					foreach (IProjectAssemblyReference projectAssemblyReference in this.O0.oOOO_o0..AssemblyReferences)
					{
						if (Operators.CompareString(projectAssemblyReference.AssemblyName.FullName, A_0.AssemblyName.FullName, true) == 0)
						{
							assembly = projectAssemblyReference.Assembly;
							break;
						}
					}
				}
				finally
				{
					IEnumerator<IProjectAssemblyReference> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				if (assembly != null)
				{
					string text = A_0.QualifiedName.ToString();
					if (text.StartsWith("global::"))
					{
						text = text.Substring(8);
					}
					string[] array = text.Split(new char[]
					{
						'.'
					});
					for (int i = array.Length - 1; i >= 1; i += -1)
					{
						text = string.Join(".", array, 0, i);
						INamespaceDefinition namespaceDefinition = assembly.Namespaces[text, false];
						if (namespaceDefinition != null)
						{
							string name = string.Join(".", array, i, array.Length - i);
							result = namespaceDefinition.Types[name, false];
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00012CB8 File Offset: 0x00010EB8
		private bool <<EMPTY_NAME>>(IResolverResultSet A_0, IDotNetContext A_1)
		{
			string text = null;
			Type type = null;
			MemberInfo memberInfo = null;
			if (A_0.Results.Count > 0)
			{
				switch (A_0.Results[0].Kind)
				{
				case ResolverResultKind.Type:
				{
					ITypeResolverResult typeResolverResult = (ITypeResolverResult)A_0.Results[0];
					if (typeResolverResult.Type.IsTypeDefinition)
					{
						type = Type.GetType(((ITypeDefinition)typeResolverResult.Type).FullName);
					}
					break;
				}
				case ResolverResultKind.TypeMember:
				{
					ITypeMemberDefinition member = ((ITypeMemberResolverResult)A_0.Results[0]).Member;
					if (member.SourceFileLocation != null)
					{
						return false;
					}
					if (member.DeclaringType.IsTypeDefinition)
					{
						type = Type.GetType(member.DeclaringType.FullName);
						if (type == null)
						{
							Assembly assembly = null;
							foreach (Assembly assembly2 in AppDomain.CurrentDomain.GetAssemblies())
							{
								if (assembly2.FullName.StartsWith(member.DeclaringType.AssemblyName.FullName))
								{
									assembly = assembly2;
									break;
								}
							}
							if (assembly == null)
							{
								assembly = Assembly.Load(member.DeclaringType.AssemblyName.FullName);
							}
							if (assembly != null)
							{
								type = assembly.GetType(member.DeclaringType.FullName);
							}
						}
						if (type != null)
						{
							MemberInfo[] member2 = type.GetMember(member.Name);
							if (member2.Length > 0)
							{
								memberInfo = member2[0];
							}
						}
					}
					break;
				}
				case ResolverResultKind.Parameter:
				{
					IParameterResolverResult parameterResolverResult = (IParameterResolverResult)A_0.Results[0];
					if (Operators.CompareString(parameterResolverResult.Name, "e", true) == 0 && parameterResolverResult.TypeIsInstance)
					{
						string fullName = ((ITypeDefinition)parameterResolverResult.Type).FullName;
						if (fullName.StartsWith("Foxtable.", StringComparison.OrdinalIgnoreCase) && fullName.EndsWith("EventArgs", StringComparison.OrdinalIgnoreCase) && base.FindForm() is O\u3000\u3002\u3000\u3000)
						{
							text = ((O\u3000\u3002\u3000\u3000)base.FindForm()).O.O_0o_Oo_.().ooo_O0_0.o_.();
						}
					}
					break;
				}
				case ResolverResultKind.Variable:
				{
					IVariableResolverResult variableResolverResult = (IVariableResolverResult)A_0.Results[0];
					if (variableResolverResult.Type != null && variableResolverResult.Type.IsTypeDefinition)
					{
						type = Type.GetType(((ITypeDefinition)variableResolverResult.Type).FullName);
					}
					break;
				}
				}
				if (memberInfo != null && System.Attribute.IsDefined(memberInfo, typeof(oO0oooo)))
				{
					text = ((oO0oooo)System.Attribute.GetCustomAttribute(memberInfo, typeof(oO0oooo))).ooo_0.o.();
				}
				if (Operators.CompareString(text, "", true) == 0 && type != null && System.Attribute.IsDefined(type, typeof(oO0oooo)))
				{
					text = ((oO0oooo)System.Attribute.GetCustomAttribute(type, typeof(oO0oooo))).ooo_0.o.();
				}
				if (Operators.CompareString(text, "", true) == 0 && A_0.Results[0] is ITypeMemberResolverResult)
				{
					ITypeMemberResolverResult typeMemberResolverResult = (ITypeMemberResolverResult)A_0.Results[0];
					if (typeMemberResolverResult.Member != null && typeMemberResolverResult.Member.DeclaringType != null && typeMemberResolverResult.Member.DeclaringType.Name.EndsWith("EventArgs", StringComparison.OrdinalIgnoreCase) && base.FindForm() is O\u3000\u3002\u3000\u3000)
					{
						text = ((O\u3000\u3002\u3000\u3000)base.FindForm()).O.O_0o_Oo_.().ooo_O0_0.o_.();
					}
				}
				if (Operators.CompareString(text, "", true) == 0)
				{
					object[] array = new object[2];
					int num = -1;
					if (type != null)
					{
						if (type.Name.IndexOf("`") > 0)
						{
							array[0] = type.Name.Substring(0, type.Name.IndexOf("`"));
						}
						else
						{
							array[0] = type.Name;
						}
						if (memberInfo != null)
						{
							array[1] = memberInfo.Name;
						}
						else
						{
							array[1] = DBNull.Value;
						}
						num = O_o00o_.o_0_O0o0.0oO..DefaultView.Find(array);
						if (num < 0)
						{
							array[1] = DBNull.Value;
							num = O_o00o_.o_0_O0o0.0oO..DefaultView.Find(array);
						}
					}
					else if (A_0.Results[0].Kind == ResolverResultKind.Type)
					{
						ITypeResolverResult typeResolverResult2 = (ITypeResolverResult)A_0.Results[0];
						if (typeResolverResult2.Type.IsTypeDefinition)
						{
							array[0] = ((ITypeDefinition)typeResolverResult2.Type).Name;
							array[1] = DBNull.Value;
							num = O_o00o_.o_0_O0o0.0oO..DefaultView.Find(array);
						}
					}
					else if (A_0.Results[0].Kind == ResolverResultKind.Variable)
					{
						IVariableResolverResult variableResolverResult2 = (IVariableResolverResult)A_0.Results[0];
						if (variableResolverResult2.Type != null && variableResolverResult2.Type.IsTypeDefinition)
						{
							array[0] = ((ITypeDefinition)variableResolverResult2.Type).Name;
							array[1] = DBNull.Value;
							num = O_o00o_.o_0_O0o0.0oO..DefaultView.Find(array);
						}
					}
					if (num >= 0)
					{
						text = O_o00o_.o_0_O0o0.0oO..DefaultView[num]["helpid"].ToString();
					}
				}
			}
			else if (A_1.TargetExpression != null)
			{
				ITextSnapshotReader reader = base.ActiveView.GetReader();
				reader.Offset = A_1.SnapshotOffset;
				IToken token = reader.ReadToken();
				if (token.Id == 11033)
				{
					ControlTypeEnum controlTypeEnum = ControlTypeEnum.None;
					RibbonItemTypeEnum ribbonItemTypeEnum = RibbonItemTypeEnum.None;
					string substring = reader.Snapshot.GetSubstring(token.TextRange);
					token = reader.ReadTokenReverse();
					token = reader.ReadTokenReverse();
					if (token != null)
					{
						int offset = reader.Offset;
						if (!O_ooO0.O__o.O000.(reader, token, ref controlTypeEnum))
						{
							reader.Offset = offset;
							O_ooO0.O__o.O000.(reader, token, ref ribbonItemTypeEnum);
						}
						if (controlTypeEnum != ControlTypeEnum.None || ribbonItemTypeEnum != RibbonItemTypeEnum.None)
						{
							List<Type> list;
							if (controlTypeEnum != ControlTypeEnum.None)
							{
								list = new List<Type>
								{
									typeof(Foxtable.WinForm.Control),
									Assembly.GetExecutingAssembly().GetType("Foxtable.WinForm." + controlTypeEnum.ToString())
								};
							}
							else
							{
								list = new List<Type>
								{
									typeof(RibbonItem),
									Assembly.GetExecutingAssembly().GetType("Foxtable.RibbonMenu." + ribbonItemTypeEnum.ToString())
								};
							}
							try
							{
								List<Type>.Enumerator enumerator = list.GetEnumerator();
								while (enumerator.MoveNext())
								{
									type = enumerator.Current;
									MemberInfo[] member3 = type.GetMember(substring);
									if (member3.Length > 0)
									{
										oO0oooo oO0oooo = (oO0oooo)System.Attribute.GetCustomAttribute(member3[0], typeof(oO0oooo));
										if (oO0oooo != null)
										{
											text = oO0oooo.ooo_0.o.();
											break;
										}
									}
								}
							}
							finally
							{
								List<Type>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
				}
				if (Operators.CompareString(text, "", true) == 0)
				{
					object[] key = new object[]
					{
						A_1.TargetExpression.ToString(),
						DBNull.Value
					};
					int num2 = O_o00o_.o_0_O0o0.0oO..DefaultView.Find(key);
					if (num2 >= 0)
					{
						text = O_o00o_.o_0_O0o0.0oO..DefaultView[num2]["helpid"].ToString();
					}
				}
			}
			else if (A_1.InitializationSnapshotRange != null && A_1.InitializationSnapshotRange.GetType() == typeof(TextSnapshotRange))
			{
				object[] key2 = new object[]
				{
					DBNull.Value,
					A_1.InitializationSnapshotRange.Value.Text
				};
				int num3 = O_o00o_.o_0_O0o0.0oO..DefaultView.Find(key2);
				if (num3 >= 0)
				{
					text = O_o00o_.o_0_O0o0.0oO..DefaultView[num3]["helpid"].ToString();
				}
			}
			if (Operators.CompareString(text, "", true) > 0 && text.IndexOf(",") > 0)
			{
				int num4 = text.IndexOf(",");
				if (memberInfo != null && memberInfo.MemberType == MemberTypes.Method)
				{
					text = text.Substring(num4 + 1);
				}
				else
				{
					text = text.Substring(0, num4);
				}
			}
			if (Operators.CompareString(this.o_o_._000oO_o0., text, true) != 0 && Operators.CompareString(text, "", true) > 0)
			{
				this.o_o_._000oO_o0. = text;
				o0OoOOoOOo0.O0OoO_0o.O.();
				O_o00o_.o_0__o0_OO__ o0_.o0o. = this.O0_.o0o.;
				if (o0_.o0o. != null)
				{
					o0_.o0o.(this, new o_OO00o(text));
				}
			}
			bool result;
			return result;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00013524 File Offset: 0x00011724
		internal void <<EMPTY_NAME>>()
		{
			O_o00o_.o_0__o0_OO__ o0_.o0o. = this.O0_.o0o.;
			if (o0_.o0o. != null)
			{
				o0_.o0o.(this, new o_OO00o(this.o_o_._000oO_o0.));
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00013550 File Offset: 0x00011750
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			if (!base.Disposing && !base.IsDisposed && (DateTime.Now - this.O0.oOOO_o0.).TotalSeconds >= 1.0)
			{
				Oo0O_O0o000 oo0O_O0o = null;
				object activeView = base.ActiveView;
				lock (activeView)
				{
					base.ActiveView.Properties.TryGetValue<Oo0O_O0o000>("CurrentChanged", out oo0O_O0o);
					base.ActiveView.Properties.Remove("CurrentChanged");
				}
				if (oo0O_O0o != null)
				{
					oo0O_O0o.OOo0.oO0OoO0o_.();
				}
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000135FC File Offset: 0x000117FC
		private void <<EMPTY_NAME>>()
		{
			this.OOo__.O0.(new ContextMenuStrip());
			this.ooO.OOO00.(new ToolStripMenuItem());
			this.O.o0OO_0_00o0.(new ToolStripMenuItem());
			this.OO0o__.oO.(new ToolStripMenuItem());
			this.O_o_.Oo0o0O.(new ToolStripMenuItem());
			this.OOo.0OO_Oo__O.(new ToolStripMenuItem());
			this.o.OO_o0_OO.(new ToolStripMenuItem());
			this.oO0o_oo_Oo._.(new ToolStripMenuItem());
			this.O__o0O.0O_0.(new ToolStripMenuItem());
			this.O_O_0O_O.0O0.(new ToolStripMenuItem());
			this.o_.0ooOooOoo00.(new ToolStripMenuItem());
			this.OOoO.o.(new ToolStripMenuItem());
			this.O0oO_Oo0.o0o.(new ToolStripMenuItem());
			this.oO.00O_o_OO.(new ToolStripMenuItem());
			this.Oo__.ooO_o_.().Items.AddRange(new ToolStripItem[]
			{
				this.o_._OoOO.(),
				this.oOo0oO.O.(),
				this.o_.O0O_Oo_0.(),
				new ToolStripSeparator(),
				this.O__O0o0Oo.0OO.(),
				this.OO.O0ooO_.(),
				new ToolStripSeparator(),
				this.o_OO0.0_0_0o_.(),
				this.o._OOOO__.(),
				this.oOo.0__oo_.(),
				new ToolStripSeparator(),
				this.OO._OOo.(),
				this.O_00O.0.(),
				new ToolStripSeparator(),
				this.O_.__O0__000O.(),
				new ToolStripSeparator(),
				this.oo_Oo._o_0.(),
				this.oO__O.0.()
			});
			this.Oo__.ooO_o_.().Name = "ContextMenuStrip1";
			this.Oo__.ooO_o_.().Size = new Size(170, 192);
			this.o_._OoOO.().Name = "CopyMenuItem";
			this.o_._OoOO.().Size = new Size(180, 22);
			this.o_._OoOO.().Text = "复制(&C)";
			this.oOo0oO.O.().Name = "CutMenuItem";
			this.oOo0oO.O.().Size = new Size(180, 22);
			this.oOo0oO.O.().Text = "剪切(&T)";
			this.o_.O0O_Oo_0.().Name = "PasteMenuItem";
			this.o_.O0O_Oo_0.().Size = new Size(180, 22);
			this.o_.O0O_Oo_0.().Text = "粘贴(&P)";
			this.o_OO0.0_0_0o_.().Name = "UndoMenuItem";
			this.o_OO0.0_0_0o_.().Size = new Size(180, 22);
			this.o_OO0.0_0_0o_.().Text = "撤销(&U)";
			this.o._OOOO__.().Name = "RedoMenuItem";
			this.o._OOOO__.().Size = new Size(180, 22);
			this.o._OOOO__.().Text = "重复(&R)";
			this.oOo.0__oo_.().Name = "SelectAllMenuItem";
			this.oOo.0__oo_.().Size = new Size(180, 22);
			this.oOo.0__oo_.().Text = "全选(&A)";
			this.O_.__O0__000O.().Name = "FormatMenuItem";
			this.O_.__O0__000O.().Size = new Size(180, 22);
			this.O_.__O0__000O.().ShortcutKeys = Keys.F10;
			this.O_.__O0__000O.().Text = "格式重排";
			this.oo_Oo._o_0.().Name = "CollapseMenuItem";
			this.oo_Oo._o_0.().Size = new Size(180, 22);
			this.oo_Oo._o_0.().ShortcutKeys = Keys.F11;
			this.oo_Oo._o_0.().Text = "全部折叠";
			this.oO__O.0.().Name = "ExpandMenuItem";
			this.oO__O.0.().Size = new Size(180, 22);
			this.oO__O.0.().ShortcutKeys = Keys.F12;
			this.oO__O.0.().Text = "全部展开";
			this.O__O0o0Oo.0OO.().Name = "FindMenuItem";
			this.O__O0o0Oo.0OO.().Size = new Size(180, 22);
			this.O__O0o0Oo.0OO.().ShortcutKeys = (Keys)131142;
			this.O__O0o0Oo.0OO.().Text = "查找";
			this.OO.O0ooO_.().Name = "RepalceMenuItem";
			this.OO.O0ooO_.().Size = new Size(180, 22);
			this.OO.O0ooO_.().ShortcutKeys = (Keys)131144;
			this.OO.O0ooO_.().Text = "替换";
			this.OO._OOo.().Name = "zhushiMenuItem";
			this.OO._OOo.().ShortcutKeys = Keys.F8;
			this.OO._OOo.().Size = new Size(180, 22);
			this.OO._OOo.().Text = "注释代码";
			this.O_00O.0.().Name = "UndozhushiMenuItem";
			this.O_00O.0.().ShortcutKeys = Keys.F9;
			this.O_00O.0.().Size = new Size(180, 22);
			this.O_00O.0.().Text = "取消注释代码";
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00013AB6 File Offset: 0x00011CB6
		private void <<EMPTY_NAME>>(object A_0, SyntaxEditorMenuEventArgs A_1)
		{
			A_1.Menu = this.Oo__.ooO_o_.();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00013AC4 File Offset: 0x00011CC4
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.CopyToClipboard();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00013AD1 File Offset: 0x00011CD1
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.CutToClipboard();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00013ADE File Offset: 0x00011CDE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.PasteFromClipboard();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00013AEB File Offset: 0x00011CEB
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new RedoAction());
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00013AFE File Offset: 0x00011CFE
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new UndoAction());
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00013B11 File Offset: 0x00011D11
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new CommentLinesAction());
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00013B24 File Offset: 0x00011D24
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new UncommentLinesAction());
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00013B37 File Offset: 0x00011D37
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new SelectAllAction());
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00013B4C File Offset: 0x00011D4C
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			ITextSnapshot currentSnapshot = base.ActiveView.CurrentSnapshot;
			TextSnapshotOffset snapshotOffset = new TextSnapshotOffset(currentSnapshot, base.ActiveView.Selection.StartOffset);
			new OooOOO_0_O(base.Document.CurrentSnapshot).Oo_O.0_0o0_.(base.Document.CurrentSnapshot);
			base.ActiveView.Selection.StartOffset = snapshotOffset;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00013BB3 File Offset: 0x00011DB3
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new FindAction());
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00013BC6 File Offset: 0x00011DC6
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new ReplaceAction());
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00013BD9 File Offset: 0x00011DD9
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			((oO0O_oO_0O_)base.Document.Language.GetService<VBCompletionProvider>()).CanShowOnTypedWordStart = false;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00013BF6 File Offset: 0x00011DF6
		private void <<EMPTY_NAME>>(object A_0, CancelEventArgs A_1)
		{
			((oO0O_oO_0O_)base.Document.Language.GetService<VBCompletionProvider>()).CanShowOnTypedWordStart = this.o.00oO0Oo.;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00013C18 File Offset: 0x00011E18
		private void <<EMPTY_NAME>>(object A_0, MouseEventArgs A_1)
		{
			if (OO_00oOO.ModifierKey == Keys.Control)
			{
				float num;
				if (A_1.Delta > 0)
				{
					num = this.Font.Size + 1f;
				}
				else
				{
					num = this.Font.Size - 1f;
				}
				num = Math.Min(Math.Max(6f, num), 30f);
				this.Font = new Font(this.Font.Name, num);
				base.ActiveView.Scroller.ScrollToCaret();
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00013C9D File Offset: 0x00011E9D
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new CollapseToDefinitionsAction());
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00013CB0 File Offset: 0x00011EB0
		private void <<EMPTY_NAME>>(object A_0, EventArgs A_1)
		{
			base.ActiveView.ExecuteEditAction(new ExpandAllOutliningAction());
		}

		// Token: 0x040000CC RID: 204
		[CompilerGenerated]
		private ContextMenuStrip <<EMPTY_NAME>>;

		// Token: 0x040000CD RID: 205
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000CE RID: 206
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000CF RID: 207
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D0 RID: 208
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D1 RID: 209
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D2 RID: 210
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D3 RID: 211
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D4 RID: 212
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D5 RID: 213
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D6 RID: 214
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D7 RID: 215
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D8 RID: 216
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000D9 RID: 217
		[CompilerGenerated]
		private ToolStripMenuItem <<EMPTY_NAME>>;

		// Token: 0x040000DA RID: 218
		private static bool <<EMPTY_NAME>>;

		// Token: 0x040000DB RID: 219
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040000DC RID: 220
		private IProjectAssemblyReference <<EMPTY_NAME>>;

		// Token: 0x040000DD RID: 221
		internal IProjectAssembly <<EMPTY_NAME>>;

		// Token: 0x040000DE RID: 222
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040000DF RID: 223
		[CompilerGenerated]
		private string <<EMPTY_NAME>>;

		// Token: 0x040000E0 RID: 224
		[CompilerGenerated]
		private O_o00o_.o_0__o0_OO__ <<EMPTY_NAME>>;

		// Token: 0x040000E1 RID: 225
		internal static Dictionary<string, string> <<EMPTY_NAME>>;

		// Token: 0x040000E2 RID: 226
		private static List<string> <<EMPTY_NAME>>;

		// Token: 0x040000E3 RID: 227
		private static List<string> <<EMPTY_NAME>>;

		// Token: 0x040000E4 RID: 228
		internal string <<EMPTY_NAME>>;

		// Token: 0x040000E5 RID: 229
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040000E6 RID: 230
		private string <<EMPTY_NAME>>;

		// Token: 0x040000E7 RID: 231
		internal HashSet<string> <<EMPTY_NAME>>;

		// Token: 0x040000E8 RID: 232
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x040000E9 RID: 233
		private static DataTable <<EMPTY_NAME>>;

		// Token: 0x040000EA RID: 234
		private CompletionSession <<EMPTY_NAME>>;

		// Token: 0x040000EB RID: 235
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040000EC RID: 236
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040000ED RID: 237
		internal static string <<EMPTY_NAME>>;

		// Token: 0x040000EE RID: 238
		private DateTime <<EMPTY_NAME>>;

		// Token: 0x040000EF RID: 239
		private string <<EMPTY_NAME>>;

		// Token: 0x040000F0 RID: 240
		[CompilerGenerated]
		private CompletionSession <<EMPTY_NAME>>;

		// Token: 0x040000F1 RID: 241
		internal string <<EMPTY_NAME>>;

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060003F0 RID: 1008
		internal delegate void o_0__o0_OO__(object A_0, o_OO00o A_1);
	}
}
