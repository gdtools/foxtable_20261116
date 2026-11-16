using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.My
{
	// Token: 0x02000554 RID: 1364
	[HideModuleName]
	[StandardModule]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class c
	{
		// Token: 0x06005B67 RID: 23399 RVA: 0x0026FD0F File Offset: 0x0026DF0F
		[DebuggerHidden]
		internal static Foxtable.My.a <<EMPTY_NAME>>()
		{
			return Foxtable.My.c.OOOOO.o..O._OO0_O.();
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x0026FD1B File Offset: 0x0026DF1B
		[DebuggerHidden]
		internal static d <<EMPTY_NAME>>()
		{
			return Foxtable.My.c.OOOOO.o..O._OO0_O.();
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x0026FD27 File Offset: 0x0026DF27
		[DebuggerHidden]
		internal static User <<EMPTY_NAME>>()
		{
			return Foxtable.My.c.OOOOO.o..O._OO0_O.();
		}

		// Token: 0x06005B6A RID: 23402 RVA: 0x0026FD33 File Offset: 0x0026DF33
		[DebuggerHidden]
		internal static Foxtable.My.c.b <<EMPTY_NAME>>()
		{
			return Foxtable.My.c.OOOOO.o..O._OO0_O.();
		}

		// Token: 0x06005B6B RID: 23403 RVA: 0x0026FD3F File Offset: 0x0026DF3F
		[DebuggerHidden]
		internal static Foxtable.My.c.c <<EMPTY_NAME>>()
		{
			return Foxtable.My.c.OOOOO.o..O._OO0_O.();
		}

		// Token: 0x0400235D RID: 9053
		private static readonly Foxtable.My.c<Foxtable.My.a>.a <<EMPTY_NAME>> = new Foxtable.My.c<Foxtable.My.a>.a();

		// Token: 0x0400235E RID: 9054
		private static readonly Foxtable.My.c<d>.a <<EMPTY_NAME>> = new Foxtable.My.c<d>.a();

		// Token: 0x0400235F RID: 9055
		private static readonly Foxtable.My.c<User>.a <<EMPTY_NAME>> = new Foxtable.My.c<User>.a();

		// Token: 0x04002360 RID: 9056
		private static Foxtable.My.c<Foxtable.My.c.b>.a <<EMPTY_NAME>> = new Foxtable.My.c<Foxtable.My.c.b>.a();

		// Token: 0x04002361 RID: 9057
		private static readonly Foxtable.My.c<Foxtable.My.c.c>.a <<EMPTY_NAME>> = new Foxtable.My.c<Foxtable.My.c.c>.a();

		// Token: 0x02000555 RID: 1365
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class b
		{
			// Token: 0x06005B6C RID: 23404 RVA: 0x0026FD4C File Offset: 0x0026DF4C
			[DebuggerHidden]
			private static a <<EMPTY_NAME>><a>(a A_0) where a : Form, new()
			{
				if (A_0 == null || A_0.IsDisposed)
				{
					if (Foxtable.My.c.b.o._0Oo0O0O. != null)
					{
						if (Foxtable.My.c.b.o._0Oo0O0O..ContainsKey(typeof(a)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						Foxtable.My.c.b.o._0Oo0O0O. = new Hashtable();
					}
					Foxtable.My.c.b.o._0Oo0O0O..Add(typeof(a), null);
					try
					{
						return Activator.CreateInstance<a>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						}), ex.InnerException);
					}
					finally
					{
						Foxtable.My.c.b.o._0Oo0O0O..Remove(typeof(a));
					}
				}
				return A_0;
			}

			// Token: 0x06005B6D RID: 23405 RVA: 0x0026FE50 File Offset: 0x0026E050
			[DebuggerHidden]
			private void <<EMPTY_NAME>><a>(ref a A_0) where a : Form
			{
				A_0.Dispose();
				A_0 = default(a);
			}

			// Token: 0x06005B6E RID: 23406 RVA: 0x0026FE65 File Offset: 0x0026E065
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public b()
			{
			}

			// Token: 0x06005B6F RID: 23407 RVA: 0x0026FE6D File Offset: 0x0026E06D
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool <<EMPTY_NAME>>(object A_0)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(A_0));
			}

			// Token: 0x06005B70 RID: 23408 RVA: 0x0026FE7B File Offset: 0x0026E07B
			[EditorBrowsable(EditorBrowsableState.Never)]
			public int <<EMPTY_NAME>>()
			{
				return base.GetHashCode();
			}

			// Token: 0x06005B71 RID: 23409 RVA: 0x0026FE83 File Offset: 0x0026E083
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type <<EMPTY_NAME>>()
			{
				return typeof(Foxtable.My.c.b);
			}

			// Token: 0x06005B72 RID: 23410 RVA: 0x0026FE8F File Offset: 0x0026E08F
			[EditorBrowsable(EditorBrowsableState.Never)]
			public string <<EMPTY_NAME>>()
			{
				return base.ToString();
			}

			// Token: 0x06005B73 RID: 23411 RVA: 0x0026FE97 File Offset: 0x0026E097
			public oOo_O_0O <<EMPTY_NAME>>()
			{
				this.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.<oOo_O_0O>(this.o._0Oo0O0O.);
				return this.o._0Oo0O0O.;
			}

			// Token: 0x06005B74 RID: 23412 RVA: 0x0026FEB0 File Offset: 0x0026E0B0
			public O0oO_0 <<EMPTY_NAME>>()
			{
				this.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.<O0oO_0>(this.o._0Oo0O0O.);
				return this.o._0Oo0O0O.;
			}

			// Token: 0x06005B75 RID: 23413 RVA: 0x0026FEC9 File Offset: 0x0026E0C9
			public oOo0o0__0 <<EMPTY_NAME>>()
			{
				this.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.<oOo0o0__0>(this.o._0Oo0O0O.);
				return this.o._0Oo0O0O.;
			}

			// Token: 0x06005B76 RID: 23414 RVA: 0x0026FEE2 File Offset: 0x0026E0E2
			public oo0O0oO_OOOo <<EMPTY_NAME>>()
			{
				this.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.<oo0O0oO_OOOo>(this.o._0Oo0O0O.);
				return this.o._0Oo0O0O.;
			}

			// Token: 0x06005B77 RID: 23415 RVA: 0x0026FEFB File Offset: 0x0026E0FB
			public g1 <<EMPTY_NAME>>()
			{
				this.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.<g1>(this.o._0Oo0O0O.);
				return this.o._0Oo0O0O.;
			}

			// Token: 0x06005B78 RID: 23416 RVA: 0x0026FF14 File Offset: 0x0026E114
			public o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.o._0Oo0O0O. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002>(this.o._0Oo0O0O.);
				return this.o._0Oo0O0O.;
			}

			// Token: 0x06005B79 RID: 23417 RVA: 0x0026FF2D File Offset: 0x0026E12D
			public O\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B7A RID: 23418 RVA: 0x0026FF46 File Offset: 0x0026E146
			public o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B7B RID: 23419 RVA: 0x0026FF5F File Offset: 0x0026E15F
			public O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B7C RID: 23420 RVA: 0x0026FF78 File Offset: 0x0026E178
			public O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B7D RID: 23421 RVA: 0x0026FF91 File Offset: 0x0026E191
			public O\u3002\u3002o <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002o>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B7E RID: 23422 RVA: 0x0026FFAA File Offset: 0x0026E1AA
			public oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B7F RID: 23423 RVA: 0x0026FFC3 File Offset: 0x0026E1C3
			public O\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3000\u3000>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B80 RID: 23424 RVA: 0x0026FFDC File Offset: 0x0026E1DC
			public O\u3002\u3002\u3002\u3002_o\u3000 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3002\u3002_o\u3000>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B81 RID: 23425 RVA: 0x0026FFF5 File Offset: 0x0026E1F5
			public O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B82 RID: 23426 RVA: 0x0027000E File Offset: 0x0026E20E
			public o\u3002\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.o_.__0. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3000\u3002>(this.o_.__0.);
				return this.o_.__0.;
			}

			// Token: 0x06005B83 RID: 23427 RVA: 0x00270027 File Offset: 0x0026E227
			public o\u3000\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3000\u3002\u3000\u3000>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B84 RID: 23428 RVA: 0x00270040 File Offset: 0x0026E240
			public O\u3002\u3002\u3002\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3002\u3002\u3000>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B85 RID: 23429 RVA: 0x00270059 File Offset: 0x0026E259
			public O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B86 RID: 23430 RVA: 0x00270072 File Offset: 0x0026E272
			public O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B87 RID: 23431 RVA: 0x0027008B File Offset: 0x0026E28B
			public o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B88 RID: 23432 RVA: 0x002700A4 File Offset: 0x0026E2A4
			public o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B89 RID: 23433 RVA: 0x002700BD File Offset: 0x0026E2BD
			public O\u3002o_\u3002\u3002\u3002\u3000\u3002o <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<O\u3002o_\u3002\u3002\u3002\u3000\u3002o>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B8A RID: 23434 RVA: 0x002700D6 File Offset: 0x0026E2D6
			public o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B8B RID: 23435 RVA: 0x002700EF File Offset: 0x0026E2EF
			public O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B8C RID: 23436 RVA: 0x00270108 File Offset: 0x0026E308
			public oO0\u3002 <<EMPTY_NAME>>()
			{
				this.OO.0o___o0o_. = Foxtable.My.c.b.OOOOO.o.<oO0\u3002>(this.OO.0o___o0o_.);
				return this.OO.0o___o0o_.;
			}

			// Token: 0x06005B8D RID: 23437 RVA: 0x00270121 File Offset: 0x0026E321
			public o0o\u3002 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<o0o\u3002>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B8E RID: 23438 RVA: 0x0027013A File Offset: 0x0026E33A
			public O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B8F RID: 23439 RVA: 0x00270153 File Offset: 0x0026E353
			public O\u3002\u30000 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u30000>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B90 RID: 23440 RVA: 0x0027016C File Offset: 0x0026E36C
			public o\u3002\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3002\u3000>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B91 RID: 23441 RVA: 0x00270185 File Offset: 0x0026E385
			public O\u3002\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3000\u3000>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B92 RID: 23442 RVA: 0x0027019E File Offset: 0x0026E39E
			public oo\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<oo\u3000\u3000\u3000\u3002>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B93 RID: 23443 RVA: 0x002701B7 File Offset: 0x0026E3B7
			public h0 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<h0>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B94 RID: 23444 RVA: 0x002701D0 File Offset: 0x0026E3D0
			public o\u3002\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3000\u3000\u3000\u3002>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B95 RID: 23445 RVA: 0x002701E9 File Offset: 0x0026E3E9
			public o\u30000\u3002 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<o\u30000\u3002>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B96 RID: 23446 RVA: 0x00270202 File Offset: 0x0026E402
			public O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.o0___.o. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000>(this.o0___.o.);
				return this.o0___.o.;
			}

			// Token: 0x06005B97 RID: 23447 RVA: 0x0027021B File Offset: 0x0026E41B
			public ev <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<ev>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B98 RID: 23448 RVA: 0x00270234 File Offset: 0x0026E434
			public di <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<di>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B99 RID: 23449 RVA: 0x0027024D File Offset: 0x0026E44D
			public O\u30000\u3002\u3002O <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<O\u30000\u3002\u3002O>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B9A RID: 23450 RVA: 0x00270266 File Offset: 0x0026E466
			public jk <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<jk>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B9B RID: 23451 RVA: 0x0027027F File Offset: 0x0026E47F
			public o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B9C RID: 23452 RVA: 0x00270298 File Offset: 0x0026E498
			public O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B9D RID: 23453 RVA: 0x002702B1 File Offset: 0x0026E4B1
			public o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B9E RID: 23454 RVA: 0x002702CA File Offset: 0x0026E4CA
			public O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005B9F RID: 23455 RVA: 0x002702E3 File Offset: 0x0026E4E3
			public O\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3000>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005BA0 RID: 23456 RVA: 0x002702FC File Offset: 0x0026E4FC
			public o\u3000\u3002\u3002\u30000\u3000 <<EMPTY_NAME>>()
			{
				this.o_O_.oOo. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3002\u3002\u30000\u3000>(this.o_O_.oOo.);
				return this.o_O_.oOo.;
			}

			// Token: 0x06005BA1 RID: 23457 RVA: 0x00270315 File Offset: 0x0026E515
			public o\u3002\u3000\u3000\u3002\u3002\u30020\u3002 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3000\u3000\u3002\u3002\u30020\u3002>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA2 RID: 23458 RVA: 0x0027032E File Offset: 0x0026E52E
			public O\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3002>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA3 RID: 23459 RVA: 0x00270347 File Offset: 0x0026E547
			public O\u3000\u3002\u3000\u3002\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3002\u3000\u3002\u3000\u3002>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA4 RID: 23460 RVA: 0x00270360 File Offset: 0x0026E560
			public O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA5 RID: 23461 RVA: 0x00270379 File Offset: 0x0026E579
			public O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA6 RID: 23462 RVA: 0x00270392 File Offset: 0x0026E592
			public o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA7 RID: 23463 RVA: 0x002703AB File Offset: 0x0026E5AB
			public o\u3000\u3002\u3002\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3002\u3002\u3002\u3002>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA8 RID: 23464 RVA: 0x002703C4 File Offset: 0x0026E5C4
			public o_\u3000\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<o_\u3000\u3000\u3000>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BA9 RID: 23465 RVA: 0x002703DD File Offset: 0x0026E5DD
			public O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BAA RID: 23466 RVA: 0x002703F6 File Offset: 0x0026E5F6
			public O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.O000O_.0oO0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000>(this.O000O_.0oO0.);
				return this.O000O_.0oO0.;
			}

			// Token: 0x06005BAB RID: 23467 RVA: 0x0027040F File Offset: 0x0026E60F
			public o\u30020\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<o\u30020\u3002\u3000\u3002\u3000>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BAC RID: 23468 RVA: 0x00270428 File Offset: 0x0026E628
			public O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BAD RID: 23469 RVA: 0x00270441 File Offset: 0x0026E641
			public o0\u3002 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<o0\u3002>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BAE RID: 23470 RVA: 0x0027045A File Offset: 0x0026E65A
			public O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BAF RID: 23471 RVA: 0x00270473 File Offset: 0x0026E673
			public o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BB0 RID: 23472 RVA: 0x0027048C File Offset: 0x0026E68C
			public o\u30000\u3002\u3000\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<o\u30000\u3002\u3000\u3000\u3000>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BB1 RID: 23473 RVA: 0x002704A5 File Offset: 0x0026E6A5
			public O\u3002\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3000\u3002\u3000\u3000>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BB2 RID: 23474 RVA: 0x002704BE File Offset: 0x0026E6BE
			public o\u30000\u3000\u3000\u3002O <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<o\u30000\u3000\u3000\u3002O>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BB3 RID: 23475 RVA: 0x002704D7 File Offset: 0x0026E6D7
			public o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BB4 RID: 23476 RVA: 0x002704F0 File Offset: 0x0026E6F0
			public o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.O_0O_O.oOOo0. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002>(this.O_0O_O.oOOo0.);
				return this.O_0O_O.oOOo0.;
			}

			// Token: 0x06005BB5 RID: 23477 RVA: 0x00270509 File Offset: 0x0026E709
			public O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BB6 RID: 23478 RVA: 0x00270522 File Offset: 0x0026E722
			public O\u3002\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3000>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BB7 RID: 23479 RVA: 0x0027053B File Offset: 0x0026E73B
			public O_\u3000 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<O_\u3000>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BB8 RID: 23480 RVA: 0x00270554 File Offset: 0x0026E754
			public O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BB9 RID: 23481 RVA: 0x0027056D File Offset: 0x0026E76D
			public O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BBA RID: 23482 RVA: 0x00270586 File Offset: 0x0026E786
			public O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BBB RID: 23483 RVA: 0x0027059F File Offset: 0x0026E79F
			public o0\u3000\u3000\u3000\u3000\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<o0\u3000\u3000\u3000\u3000\u3002\u3002>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BBC RID: 23484 RVA: 0x002705B8 File Offset: 0x0026E7B8
			public o\u3002\u3000\u3002_ <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<o\u3002\u3000\u3002_>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BBD RID: 23485 RVA: 0x002705D1 File Offset: 0x0026E7D1
			public Oo\u3000\u3000\u3002\u3000\u3002\u3002 <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<Oo\u3000\u3000\u3002\u3000\u3002\u3002>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BBE RID: 23486 RVA: 0x002705EA File Offset: 0x0026E7EA
			public gg <<EMPTY_NAME>>()
			{
				this.O.OOo_OOo__. = Foxtable.My.c.b.OOOOO.o.<gg>(this.O.OOo_OOo__.);
				return this.O.OOo_OOo__.;
			}

			// Token: 0x06005BBF RID: 23487 RVA: 0x00270603 File Offset: 0x0026E803
			public O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.oo_.O0O00. = Foxtable.My.c.b.OOOOO.o.<O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000>(this.oo_.O0O00.);
				return this.oo_.O0O00.;
			}

			// Token: 0x06005BC0 RID: 23488 RVA: 0x0027061C File Offset: 0x0026E81C
			public o\u3000\u3000\u3002\u3002O <<EMPTY_NAME>>()
			{
				this.oo_.O0O00. = Foxtable.My.c.b.OOOOO.o.<o\u3000\u3000\u3002\u3002O>(this.oo_.O0O00.);
				return this.oo_.O0O00.;
			}

			// Token: 0x06005BC1 RID: 23489 RVA: 0x00270635 File Offset: 0x0026E835
			public o\u3000_\u3000\u3002_\u3002\u3000 <<EMPTY_NAME>>()
			{
				this.oo_.O0O00. = Foxtable.My.c.b.OOOOO.o.<o\u3000_\u3000\u3002_\u3002\u3000>(this.oo_.O0O00.);
				return this.oo_.O0O00.;
			}

			// Token: 0x06005BC2 RID: 23490 RVA: 0x0027064E File Offset: 0x0026E84E
			public void <<EMPTY_NAME>>(oOo_O_0O A_0)
			{
				if (A_0 != this.o._0Oo0O0O.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<oOo_O_0O>(ref this.o._0Oo0O0O.);
				}
			}

			// Token: 0x06005BC3 RID: 23491 RVA: 0x00270673 File Offset: 0x0026E873
			public void <<EMPTY_NAME>>(O0oO_0 A_0)
			{
				if (A_0 != this.o._0Oo0O0O.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O0oO_0>(ref this.o._0Oo0O0O.);
				}
			}

			// Token: 0x06005BC4 RID: 23492 RVA: 0x00270698 File Offset: 0x0026E898
			public void <<EMPTY_NAME>>(oOo0o0__0 A_0)
			{
				if (A_0 != this.o._0Oo0O0O.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<oOo0o0__0>(ref this.o._0Oo0O0O.);
				}
			}

			// Token: 0x06005BC5 RID: 23493 RVA: 0x002706BD File Offset: 0x0026E8BD
			public void <<EMPTY_NAME>>(oo0O0oO_OOOo A_0)
			{
				if (A_0 != this.o._0Oo0O0O.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<oo0O0oO_OOOo>(ref this.o._0Oo0O0O.);
				}
			}

			// Token: 0x06005BC6 RID: 23494 RVA: 0x002706E2 File Offset: 0x0026E8E2
			public void <<EMPTY_NAME>>(g1 A_0)
			{
				if (A_0 != this.o._0Oo0O0O.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<g1>(ref this.o._0Oo0O0O.);
				}
			}

			// Token: 0x06005BC7 RID: 23495 RVA: 0x00270707 File Offset: 0x0026E907
			public void <<EMPTY_NAME>>(o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002 A_0)
			{
				if (A_0 != this.o._0Oo0O0O.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002>(ref this.o._0Oo0O0O.);
				}
			}

			// Token: 0x06005BC8 RID: 23496 RVA: 0x0027072C File Offset: 0x0026E92C
			public void <<EMPTY_NAME>>(O\u3002\u3002 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BC9 RID: 23497 RVA: 0x00270751 File Offset: 0x0026E951
			public void <<EMPTY_NAME>>(o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BCA RID: 23498 RVA: 0x00270776 File Offset: 0x0026E976
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BCB RID: 23499 RVA: 0x0027079B File Offset: 0x0026E99B
			public void <<EMPTY_NAME>>(O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BCC RID: 23500 RVA: 0x002707C0 File Offset: 0x0026E9C0
			public void <<EMPTY_NAME>>(O\u3002\u3002o A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002o>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BCD RID: 23501 RVA: 0x002707E5 File Offset: 0x0026E9E5
			public void <<EMPTY_NAME>>(oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BCE RID: 23502 RVA: 0x0027080A File Offset: 0x0026EA0A
			public void <<EMPTY_NAME>>(O\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3000\u3000>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BCF RID: 23503 RVA: 0x0027082F File Offset: 0x0026EA2F
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3002\u3002_o\u3000 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3002\u3002_o\u3000>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BD0 RID: 23504 RVA: 0x00270854 File Offset: 0x0026EA54
			public void <<EMPTY_NAME>>(O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BD1 RID: 23505 RVA: 0x00270879 File Offset: 0x0026EA79
			public void <<EMPTY_NAME>>(o\u3002\u3000\u3002 A_0)
			{
				if (A_0 != this.o_.__0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3000\u3002>(ref this.o_.__0.);
				}
			}

			// Token: 0x06005BD2 RID: 23506 RVA: 0x0027089E File Offset: 0x0026EA9E
			public void <<EMPTY_NAME>>(o\u3000\u3000\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3000\u3002\u3000\u3000>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BD3 RID: 23507 RVA: 0x002708C3 File Offset: 0x0026EAC3
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3002\u3002\u3000 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3002\u3002\u3000>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BD4 RID: 23508 RVA: 0x002708E8 File Offset: 0x0026EAE8
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BD5 RID: 23509 RVA: 0x0027090D File Offset: 0x0026EB0D
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BD6 RID: 23510 RVA: 0x00270932 File Offset: 0x0026EB32
			public void <<EMPTY_NAME>>(o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BD7 RID: 23511 RVA: 0x00270957 File Offset: 0x0026EB57
			public void <<EMPTY_NAME>>(o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BD8 RID: 23512 RVA: 0x0027097C File Offset: 0x0026EB7C
			public void <<EMPTY_NAME>>(O\u3002o_\u3002\u3002\u3002\u3000\u3002o A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002o_\u3002\u3002\u3002\u3000\u3002o>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BD9 RID: 23513 RVA: 0x002709A1 File Offset: 0x0026EBA1
			public void <<EMPTY_NAME>>(o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BDA RID: 23514 RVA: 0x002709C6 File Offset: 0x0026EBC6
			public void <<EMPTY_NAME>>(O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BDB RID: 23515 RVA: 0x002709EB File Offset: 0x0026EBEB
			public void <<EMPTY_NAME>>(oO0\u3002 A_0)
			{
				if (A_0 != this.OO.0o___o0o_.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<oO0\u3002>(ref this.OO.0o___o0o_.);
				}
			}

			// Token: 0x06005BDC RID: 23516 RVA: 0x00270A10 File Offset: 0x0026EC10
			public void <<EMPTY_NAME>>(o0o\u3002 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o0o\u3002>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BDD RID: 23517 RVA: 0x00270A35 File Offset: 0x0026EC35
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BDE RID: 23518 RVA: 0x00270A5A File Offset: 0x0026EC5A
			public void <<EMPTY_NAME>>(O\u3002\u30000 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u30000>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BDF RID: 23519 RVA: 0x00270A7F File Offset: 0x0026EC7F
			public void <<EMPTY_NAME>>(o\u3002\u3002\u3000 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3002\u3000>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BE0 RID: 23520 RVA: 0x00270AA4 File Offset: 0x0026ECA4
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3000\u3000>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BE1 RID: 23521 RVA: 0x00270AC9 File Offset: 0x0026ECC9
			public void <<EMPTY_NAME>>(oo\u3000\u3000\u3000\u3002 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<oo\u3000\u3000\u3000\u3002>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BE2 RID: 23522 RVA: 0x00270AEE File Offset: 0x0026ECEE
			public void <<EMPTY_NAME>>(h0 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<h0>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BE3 RID: 23523 RVA: 0x00270B13 File Offset: 0x0026ED13
			public void <<EMPTY_NAME>>(o\u3002\u3000\u3000\u3000\u3002 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3000\u3000\u3000\u3002>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BE4 RID: 23524 RVA: 0x00270B38 File Offset: 0x0026ED38
			public void <<EMPTY_NAME>>(o\u30000\u3002 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u30000\u3002>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BE5 RID: 23525 RVA: 0x00270B5D File Offset: 0x0026ED5D
			public void <<EMPTY_NAME>>(O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000 A_0)
			{
				if (A_0 != this.o0___.o.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000>(ref this.o0___.o.);
				}
			}

			// Token: 0x06005BE6 RID: 23526 RVA: 0x00270B82 File Offset: 0x0026ED82
			public void <<EMPTY_NAME>>(ev A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<ev>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BE7 RID: 23527 RVA: 0x00270BA7 File Offset: 0x0026EDA7
			public void <<EMPTY_NAME>>(di A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<di>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BE8 RID: 23528 RVA: 0x00270BCC File Offset: 0x0026EDCC
			public void <<EMPTY_NAME>>(O\u30000\u3002\u3002O A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u30000\u3002\u3002O>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BE9 RID: 23529 RVA: 0x00270BF1 File Offset: 0x0026EDF1
			public void <<EMPTY_NAME>>(jk A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<jk>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BEA RID: 23530 RVA: 0x00270C16 File Offset: 0x0026EE16
			public void <<EMPTY_NAME>>(o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002 A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BEB RID: 23531 RVA: 0x00270C3B File Offset: 0x0026EE3B
			public void <<EMPTY_NAME>>(O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002 A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BEC RID: 23532 RVA: 0x00270C60 File Offset: 0x0026EE60
			public void <<EMPTY_NAME>>(o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002 A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BED RID: 23533 RVA: 0x00270C85 File Offset: 0x0026EE85
			public void <<EMPTY_NAME>>(O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002 A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BEE RID: 23534 RVA: 0x00270CAA File Offset: 0x0026EEAA
			public void <<EMPTY_NAME>>(O\u3002\u3000 A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3000>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BEF RID: 23535 RVA: 0x00270CCF File Offset: 0x0026EECF
			public void <<EMPTY_NAME>>(o\u3000\u3002\u3002\u30000\u3000 A_0)
			{
				if (A_0 != this.o_O_.oOo.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3002\u3002\u30000\u3000>(ref this.o_O_.oOo.);
				}
			}

			// Token: 0x06005BF0 RID: 23536 RVA: 0x00270CF4 File Offset: 0x0026EEF4
			public void <<EMPTY_NAME>>(o\u3002\u3000\u3000\u3002\u3002\u30020\u3002 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3000\u3000\u3002\u3002\u30020\u3002>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF1 RID: 23537 RVA: 0x00270D19 File Offset: 0x0026EF19
			public void <<EMPTY_NAME>>(O\u3000\u3002 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3002>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF2 RID: 23538 RVA: 0x00270D3E File Offset: 0x0026EF3E
			public void <<EMPTY_NAME>>(O\u3000\u3002\u3000\u3002\u3000\u3002 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3002\u3000\u3002\u3000\u3002>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF3 RID: 23539 RVA: 0x00270D63 File Offset: 0x0026EF63
			public void <<EMPTY_NAME>>(O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF4 RID: 23540 RVA: 0x00270D88 File Offset: 0x0026EF88
			public void <<EMPTY_NAME>>(O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF5 RID: 23541 RVA: 0x00270DAD File Offset: 0x0026EFAD
			public void <<EMPTY_NAME>>(o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF6 RID: 23542 RVA: 0x00270DD2 File Offset: 0x0026EFD2
			public void <<EMPTY_NAME>>(o\u3000\u3002\u3002\u3002\u3002 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3002\u3002\u3002\u3002>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF7 RID: 23543 RVA: 0x00270DF7 File Offset: 0x0026EFF7
			public void <<EMPTY_NAME>>(o_\u3000\u3000\u3000 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o_\u3000\u3000\u3000>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF8 RID: 23544 RVA: 0x00270E1C File Offset: 0x0026F01C
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BF9 RID: 23545 RVA: 0x00270E41 File Offset: 0x0026F041
			public void <<EMPTY_NAME>>(O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000 A_0)
			{
				if (A_0 != this.O000O_.0oO0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000>(ref this.O000O_.0oO0.);
				}
			}

			// Token: 0x06005BFA RID: 23546 RVA: 0x00270E66 File Offset: 0x0026F066
			public void <<EMPTY_NAME>>(o\u30020\u3002\u3000\u3002\u3000 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u30020\u3002\u3000\u3002\u3000>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005BFB RID: 23547 RVA: 0x00270E8B File Offset: 0x0026F08B
			public void <<EMPTY_NAME>>(O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005BFC RID: 23548 RVA: 0x00270EB0 File Offset: 0x0026F0B0
			public void <<EMPTY_NAME>>(o0\u3002 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o0\u3002>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005BFD RID: 23549 RVA: 0x00270ED5 File Offset: 0x0026F0D5
			public void <<EMPTY_NAME>>(O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005BFE RID: 23550 RVA: 0x00270EFA File Offset: 0x0026F0FA
			public void <<EMPTY_NAME>>(o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005BFF RID: 23551 RVA: 0x00270F1F File Offset: 0x0026F11F
			public void <<EMPTY_NAME>>(o\u30000\u3002\u3000\u3000\u3000 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u30000\u3002\u3000\u3000\u3000>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005C00 RID: 23552 RVA: 0x00270F44 File Offset: 0x0026F144
			public void <<EMPTY_NAME>>(O\u3002\u3000\u3002\u3000\u3000 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3000\u3002\u3000\u3000>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005C01 RID: 23553 RVA: 0x00270F69 File Offset: 0x0026F169
			public void <<EMPTY_NAME>>(o\u30000\u3000\u3000\u3002O A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u30000\u3000\u3000\u3002O>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005C02 RID: 23554 RVA: 0x00270F8E File Offset: 0x0026F18E
			public void <<EMPTY_NAME>>(o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005C03 RID: 23555 RVA: 0x00270FB3 File Offset: 0x0026F1B3
			public void <<EMPTY_NAME>>(o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002 A_0)
			{
				if (A_0 != this.O_0O_O.oOOo0.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002>(ref this.O_0O_O.oOOo0.);
				}
			}

			// Token: 0x06005C04 RID: 23556 RVA: 0x00270FD8 File Offset: 0x0026F1D8
			public void <<EMPTY_NAME>>(O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C05 RID: 23557 RVA: 0x00270FFD File Offset: 0x0026F1FD
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3000 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3000>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C06 RID: 23558 RVA: 0x00271022 File Offset: 0x0026F222
			public void <<EMPTY_NAME>>(O_\u3000 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O_\u3000>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C07 RID: 23559 RVA: 0x00271047 File Offset: 0x0026F247
			public void <<EMPTY_NAME>>(O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C08 RID: 23560 RVA: 0x0027106C File Offset: 0x0026F26C
			public void <<EMPTY_NAME>>(O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C09 RID: 23561 RVA: 0x00271091 File Offset: 0x0026F291
			public void <<EMPTY_NAME>>(O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C0A RID: 23562 RVA: 0x002710B6 File Offset: 0x0026F2B6
			public void <<EMPTY_NAME>>(o0\u3000\u3000\u3000\u3000\u3002\u3002 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o0\u3000\u3000\u3000\u3000\u3002\u3002>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C0B RID: 23563 RVA: 0x002710DB File Offset: 0x0026F2DB
			public void <<EMPTY_NAME>>(o\u3002\u3000\u3002_ A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3002\u3000\u3002_>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C0C RID: 23564 RVA: 0x00271100 File Offset: 0x0026F300
			public void <<EMPTY_NAME>>(Oo\u3000\u3000\u3002\u3000\u3002\u3002 A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<Oo\u3000\u3000\u3002\u3000\u3002\u3002>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C0D RID: 23565 RVA: 0x00271125 File Offset: 0x0026F325
			public void <<EMPTY_NAME>>(gg A_0)
			{
				if (A_0 != this.O.OOo_OOo__.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<gg>(ref this.O.OOo_OOo__.);
				}
			}

			// Token: 0x06005C0E RID: 23566 RVA: 0x0027114A File Offset: 0x0026F34A
			public void <<EMPTY_NAME>>(O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000 A_0)
			{
				if (A_0 != this.oo_.O0O00.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000>(ref this.oo_.O0O00.);
				}
			}

			// Token: 0x06005C0F RID: 23567 RVA: 0x0027116F File Offset: 0x0026F36F
			public void <<EMPTY_NAME>>(o\u3000\u3000\u3002\u3002O A_0)
			{
				if (A_0 != this.oo_.O0O00.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000\u3000\u3002\u3002O>(ref this.oo_.O0O00.);
				}
			}

			// Token: 0x06005C10 RID: 23568 RVA: 0x00271194 File Offset: 0x0026F394
			public void <<EMPTY_NAME>>(o\u3000_\u3000\u3002_\u3002\u3000 A_0)
			{
				if (A_0 != this.oo_.O0O00.)
				{
					if (A_0 != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.OO__00ooO.0O00.<o\u3000_\u3000\u3002_\u3002\u3000>(ref this.oo_.O0O00.);
				}
			}

			// Token: 0x04002362 RID: 9058
			[ThreadStatic]
			private static Hashtable <<EMPTY_NAME>>;

			// Token: 0x04002363 RID: 9059
			[EditorBrowsable(EditorBrowsableState.Never)]
			public oOo_O_0O <<EMPTY_NAME>>;

			// Token: 0x04002364 RID: 9060
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O0oO_0 <<EMPTY_NAME>>;

			// Token: 0x04002365 RID: 9061
			[EditorBrowsable(EditorBrowsableState.Never)]
			public oOo0o0__0 <<EMPTY_NAME>>;

			// Token: 0x04002366 RID: 9062
			[EditorBrowsable(EditorBrowsableState.Never)]
			public oo0O0oO_OOOo <<EMPTY_NAME>>;

			// Token: 0x04002367 RID: 9063
			[EditorBrowsable(EditorBrowsableState.Never)]
			public g1 <<EMPTY_NAME>>;

			// Token: 0x04002368 RID: 9064
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3002\u30000O\u3000o\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002369 RID: 9065
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400236A RID: 9066
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3000\u3002\u3000\u3000\u3002\u3002\u3002\u3000\u3002\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400236B RID: 9067
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3002\u3002\u3000o\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400236C RID: 9068
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400236D RID: 9069
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002o <<EMPTY_NAME>>;

			// Token: 0x0400236E RID: 9070
			[EditorBrowsable(EditorBrowsableState.Never)]
			public oo\u3000\u3002_\u3000\u3000\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400236F RID: 9071
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002370 RID: 9072
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3002\u3002_o\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002371 RID: 9073
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000\u3000\u3000\u3002\u3002\u3000\u3000O\u3002O\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002372 RID: 9074
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002373 RID: 9075
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002374 RID: 9076
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3002\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002375 RID: 9077
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3002\u3000\u3002\u3002\u3002\u3002\u30000 <<EMPTY_NAME>>;

			// Token: 0x04002376 RID: 9078
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3000\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002377 RID: 9079
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000O\u3000\u3002o\u3002\u3000\u3000\u3002\u3002\u30020 <<EMPTY_NAME>>;

			// Token: 0x04002378 RID: 9080
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3002o\u3002\u3000\u3002_\u3002\u3000\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002379 RID: 9081
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002o_\u3002\u3002\u3002\u3000\u3002o <<EMPTY_NAME>>;

			// Token: 0x0400237A RID: 9082
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3000\u3000\u3000\u3002\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400237B RID: 9083
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400237C RID: 9084
			[EditorBrowsable(EditorBrowsableState.Never)]
			public oO0\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400237D RID: 9085
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o0o\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400237E RID: 9086
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3000\u3000\u3002\u3002\u3000\u3002\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400237F RID: 9087
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u30000 <<EMPTY_NAME>>;

			// Token: 0x04002380 RID: 9088
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002381 RID: 9089
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002382 RID: 9090
			[EditorBrowsable(EditorBrowsableState.Never)]
			public oo\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002383 RID: 9091
			[EditorBrowsable(EditorBrowsableState.Never)]
			public h0 <<EMPTY_NAME>>;

			// Token: 0x04002384 RID: 9092
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002385 RID: 9093
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u30000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002386 RID: 9094
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3000\u3000\u3000O\u3002\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002387 RID: 9095
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ev <<EMPTY_NAME>>;

			// Token: 0x04002388 RID: 9096
			[EditorBrowsable(EditorBrowsableState.Never)]
			public di <<EMPTY_NAME>>;

			// Token: 0x04002389 RID: 9097
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u30000\u3002\u3002O <<EMPTY_NAME>>;

			// Token: 0x0400238A RID: 9098
			[EditorBrowsable(EditorBrowsableState.Never)]
			public jk <<EMPTY_NAME>>;

			// Token: 0x0400238B RID: 9099
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3000\u3000\u3000\u3000\u3000\u3002\u3000\u3000\u3002\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400238C RID: 9100
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002o\u3000\u3002\u3000\u3000_\u3002\u3000\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400238D RID: 9101
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3002\u3002\u3000\u3000\u3000\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400238E RID: 9102
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000o\u3000\u3000\u3000\u3000\u3000oo\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400238F RID: 9103
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002390 RID: 9104
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3002\u3002\u30000\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002391 RID: 9105
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3000\u3000\u3002\u3002\u30020\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002392 RID: 9106
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002393 RID: 9107
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3002\u3000\u3002\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002394 RID: 9108
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000_\u3000\u3002\u3002\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002395 RID: 9109
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000\u3002\u3000\u3002\u3002\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002396 RID: 9110
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002397 RID: 9111
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3002\u3002\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x04002398 RID: 9112
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o_\u3000\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x04002399 RID: 9113
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3002\u3002\u3000\u3000O\u3002\u3002\u3002o\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400239A RID: 9114
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3000\u3000_\u30000\u3000\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400239B RID: 9115
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u30020\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400239C RID: 9116
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3002\u3002O\u3000_\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x0400239D RID: 9117
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o0\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400239E RID: 9118
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000\u3000\u3000\u3000_\u3002\u3002\u3002_\u3002 <<EMPTY_NAME>>;

			// Token: 0x0400239F RID: 9119
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3002\u3002O\u3002\u3000\u3000\u3000\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x040023A0 RID: 9120
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u30000\u3002\u3000\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023A1 RID: 9121
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3000\u3002\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023A2 RID: 9122
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u30000\u3000\u3000\u3002O <<EMPTY_NAME>>;

			// Token: 0x040023A3 RID: 9123
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3002\u3000\u3000\u3000\u3002\u3000\u3000\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023A4 RID: 9124
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3002\u3000\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x040023A5 RID: 9125
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000\u3000\u3002\u3000\u3002\u3002\u3002\u3002\u3000\u3002 <<EMPTY_NAME>>;

			// Token: 0x040023A6 RID: 9126
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023A7 RID: 9127
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O_\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023A8 RID: 9128
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000\u3002\u3002\u3002\u3002\u3002\u3000\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023A9 RID: 9129
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3000\u3000\u3000\u3002\u3000\u3000\u3002O\u3000\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x040023AA RID: 9130
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002\u3000\u3000oo\u3000\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023AB RID: 9131
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o0\u3000\u3000\u3000\u3000\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x040023AC RID: 9132
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3002\u3000\u3002_ <<EMPTY_NAME>>;

			// Token: 0x040023AD RID: 9133
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Oo\u3000\u3000\u3002\u3000\u3002\u3002 <<EMPTY_NAME>>;

			// Token: 0x040023AE RID: 9134
			[EditorBrowsable(EditorBrowsableState.Never)]
			public gg <<EMPTY_NAME>>;

			// Token: 0x040023AF RID: 9135
			[EditorBrowsable(EditorBrowsableState.Never)]
			public O\u3002\u3002_\u3002\u3002\u3000O\u3002\u3000 <<EMPTY_NAME>>;

			// Token: 0x040023B0 RID: 9136
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000\u3000\u3002\u3002O <<EMPTY_NAME>>;

			// Token: 0x040023B1 RID: 9137
			[EditorBrowsable(EditorBrowsableState.Never)]
			public o\u3000_\u3000\u3002_\u3002\u3000 <<EMPTY_NAME>>;
		}

		// Token: 0x02000556 RID: 1366
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class c
		{
			// Token: 0x06005C11 RID: 23569 RVA: 0x002711B9 File Offset: 0x0026F3B9
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public bool <<EMPTY_NAME>>(object A_0)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(A_0));
			}

			// Token: 0x06005C12 RID: 23570 RVA: 0x002711C7 File Offset: 0x0026F3C7
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public int <<EMPTY_NAME>>()
			{
				return base.GetHashCode();
			}

			// Token: 0x06005C13 RID: 23571 RVA: 0x002711CF File Offset: 0x0026F3CF
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal Type <<EMPTY_NAME>>()
			{
				return typeof(Foxtable.My.c.c);
			}

			// Token: 0x06005C14 RID: 23572 RVA: 0x002711DB File Offset: 0x0026F3DB
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public string <<EMPTY_NAME>>()
			{
				return base.ToString();
			}

			// Token: 0x06005C15 RID: 23573 RVA: 0x002711E4 File Offset: 0x0026F3E4
			[DebuggerHidden]
			private static a <<EMPTY_NAME>><a>(a A_0) where a : new()
			{
				a result;
				if (A_0 == null)
				{
					result = Activator.CreateInstance<a>();
				}
				else
				{
					result = A_0;
				}
				return result;
			}

			// Token: 0x06005C16 RID: 23574 RVA: 0x00271204 File Offset: 0x0026F404
			[DebuggerHidden]
			private void <<EMPTY_NAME>><a>(ref a A_0)
			{
				A_0 = default(a);
			}

			// Token: 0x06005C17 RID: 23575 RVA: 0x0027120D File Offset: 0x0026F40D
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public c()
			{
			}
		}

		// Token: 0x02000557 RID: 1367
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class a<<<EMPTY_NAME>>> where <<EMPTY_NAME>> : new()
		{
			// Token: 0x06005C18 RID: 23576 RVA: 0x00271215 File Offset: 0x0026F415
			[DebuggerHidden]
			internal oo_.O0O00. <<EMPTY_NAME>>()
			{
				if (Foxtable.My.c<oo_.O0O00.>.a.O._OO0_O. == null)
				{
					Foxtable.My.c<oo_.O0O00.>.a.O._OO0_O. = Activator.CreateInstance<oo_.O0O00.>();
				}
				return Foxtable.My.c<oo_.O0O00.>.a.O._OO0_O.;
			}

			// Token: 0x06005C19 RID: 23577 RVA: 0x00271232 File Offset: 0x0026F432
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public a()
			{
			}

			// Token: 0x040023B2 RID: 9138
			[CompilerGenerated]
			[ThreadStatic]
			private static oo_.O0O00. <<EMPTY_NAME>>;
		}
	}
}
