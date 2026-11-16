using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Languages.DotNet.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.UI.WinForms.Controls.SyntaxEditor.Highlighting.Implementation;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000072 RID: 114
	internal class Oo0O_O0o000 : VBTokenTagger
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x00018D6C File Offset: 0x00016F6C
		[CompilerGenerated]
		private virtual IEditorView <<EMPTY_NAME>>()
		{
			return this.o_O0O_O.__o.;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00018D74 File Offset: 0x00016F74
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private virtual void <<EMPTY_NAME>>(IEditorView A_0)
		{
			this.o_O0O_O.__o. = A_0;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00018D80 File Offset: 0x00016F80
		static Oo0O_O0o000()
		{
			IHighlightingStyle style = new HighlightingStyle(null, new Color?(Color.LightGoldenrodYellow));
			AmbientHighlightingStyleRegistry.Instance.Register(Oo0O_O0o000.O_oo00_o_0.OO., style);
			style = new HighlightingStyle(new Color?(Color.MediumVioletRed), null);
			AmbientHighlightingStyleRegistry.Instance.Register(Oo0O_O0o000.o_OO.oo., style);
			style = new HighlightingStyle(new Color?(Color.Blue), null);
			AmbientHighlightingStyleRegistry.Instance.Register(Oo0O_O0o000.o00_.0_oOO., style);
			style = new HighlightingStyle(new Color?(Color.RoyalBlue), null);
			AmbientHighlightingStyleRegistry.Instance.Register(Oo0O_O0o000.Ooo._OOo0., style);
			style = new HighlightingStyle(new Color?(Color.DarkCyan), null);
			AmbientHighlightingStyleRegistry.Instance.Register(Oo0O_O0o000.ooO_.o., style);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00018F1A File Offset: 0x0001711A
		public Oo0O_O0o000(ICodeDocument A_0) : base(A_0, new DotNetClassificationTypeProvider())
		{
			this.O_oo00_o_0.OO. = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00018F38 File Offset: 0x00017138
		public Oo0O_O0o000(IEditorView A_0) : base(A_0.SyntaxEditor.Document, new DotNetClassificationTypeProvider())
		{
			this.O_oo00_o_0.OO. = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			this.o_O0O_O.__o.(A_0);
			this.o_O0O_O.__o.().SelectionChanged += this.o_O0O_O.__o.;
			this.o_O0O_O.__o.();
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00018F90 File Offset: 0x00017190
		private void <<EMPTY_NAME>>()
		{
			this.O_oo00_o_0.OO..Clear();
			try
			{
				foreach (DataTable dataTable in OO_00oOO.DataTables)
				{
					this.O_oo00_o_0.OO..Add(dataTable.Name);
					try
					{
						foreach (DataCol dataCol in dataTable.DataCols)
						{
							this.O_oo00_o_0.OO..Add(dataCol.Name);
						}
					}
					finally
					{
						IEnumerator<DataCol> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<DataTable> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001903C File Offset: 0x0001723C
		internal void <<EMPTY_NAME>>()
		{
			if (this.o_O0O_O.__o.() != null && this.o_O0O_O.__o.().Selection != null)
			{
				string o_oo00_o_0.OO. = this.O_oo00_o_0.OO.;
				this.O_oo00_o_0.OO. = string.Empty;
				this.o_O0O_O.__o. = -100;
				ITextSnapshotReader reader = this.o_O0O_O.__o.().GetReader();
				IToken token;
				if (reader.IsAtTokenStart)
				{
					token = reader.PeekToken();
					if (!VBTokenId.IsIdentifierClassificationType(token.Id))
					{
						reader.GoToCurrentWordStart();
					}
				}
				token = reader.ReadToken();
				if (VBTokenId.IsIdentifierClassificationType(token.Id))
				{
					this.O_oo00_o_0.OO. = new TextSnapshotRange(this.o_O0O_O.__o.().CurrentSnapshot, token.TextRange).Text;
					this.o_O0O_O.__o. = token.Id;
				}
				if (Operators.CompareString(o_oo00_o_0.OO., this.O_oo00_o_0.OO., true) != 0)
				{
					this.OnTagsChanged(new TagsChangedEventArgs(new TextSnapshotRange(this.o_O0O_O.__o.().SyntaxEditor.Document.CurrentSnapshot, this.o_O0O_O.__o.().SyntaxEditor.Document.CurrentSnapshot.TextRange)));
				}
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001913D File Offset: 0x0001733D
		public override IEnumerable<TagSnapshotRange<ITokenTag>> GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter)
		{
			Oo0O_O0o000.oo0_oO oo0_oO = new Oo0O_O0o000.oo0_oO(-2);
			oo0_oO.o00.0. = this;
			oo0_oO.OO_0Oo.o0O. = snapshotRanges;
			oo0_oO.OO_0Oo.o0O. = parameter;
			return oo0_oO;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001915C File Offset: 0x0001735C
		private void <<EMPTY_NAME>>(object A_0, EditorViewSelectionEventArgs A_1)
		{
			if (A_1.CaretPosition.Line != A_1.PreviousCaretPosition.Line || Math.Abs(A_1.CaretPosition.Character - A_1.PreviousCaretPosition.Character) > 2)
			{
				object obj = this.o_O0O_O.__o.();
				lock (obj)
				{
					if (this.o_O0O_O.__o.().Properties.ContainsKey("CurrentChanged"))
					{
						this.o_O0O_O.__o.().Properties.Remove("CurrentChanged");
					}
				}
				this.OOo0.oO0OoO0o_.();
				return;
			}
			object obj2 = this.o_O0O_O.__o.();
			lock (obj2)
			{
				this.o_O0O_O.__o.().Properties["CurrentChanged"] = this;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00019250 File Offset: 0x00017450
		protected override void OnClosed()
		{
			if (this.o_O0O_O.__o.() != null)
			{
				this.o_O0O_O.__o.().SelectionChanged -= this.o_O0O_O.__o.;
				this.o_O0O_O.__o.(null);
			}
			base.OnClosed();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001927E File Offset: 0x0001747E
		[CompilerGenerated]
		[CompilerGenerated]
		private IEnumerable<TagSnapshotRange<ITokenTag>> <<EMPTY_NAME>>(NormalizedTextSnapshotRangeCollection A_0, object A_1)
		{
			return base.GetTags(A_0, A_1);
		}

		// Token: 0x04000109 RID: 265
		[CompilerGenerated]
		private IEditorView <<EMPTY_NAME>>;

		// Token: 0x0400010A RID: 266
		private string <<EMPTY_NAME>>;

		// Token: 0x0400010B RID: 267
		private int <<EMPTY_NAME>>;

		// Token: 0x0400010C RID: 268
		private HashSet<string> <<EMPTY_NAME>>;

		// Token: 0x0400010D RID: 269
		private static IClassificationType <<EMPTY_NAME>> = new ClassificationType("CurrentIdentify", "当前标识");

		// Token: 0x0400010E RID: 270
		private static IClassificationType <<EMPTY_NAME>> = new ClassificationType("NameOfTableOrColumn", "表名与列名");

		// Token: 0x0400010F RID: 271
		private static IClassificationType <<EMPTY_NAME>> = new ClassificationType("CommonTypes", "常用类型");

		// Token: 0x04000110 RID: 272
		private static IClassificationType <<EMPTY_NAME>> = new ClassificationType("NumberOrDateTime", "数字与日期");

		// Token: 0x04000111 RID: 273
		private static IClassificationType <<EMPTY_NAME>> = new ClassificationType("StringsConnector", "字符链接符号");

		// Token: 0x04000112 RID: 274
		private static HashSet<string> <<EMPTY_NAME>> = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"Table",
			"Row",
			"Col",
			"Datatable",
			"DataCol",
			"DataRow"
		};

		// Token: 0x02000073 RID: 115
		[CompilerGenerated]
		private sealed class oo0_oO : IEnumerable<TagSnapshotRange<ITokenTag>>, IEnumerator<TagSnapshotRange<ITokenTag>>
		{
			// Token: 0x06000429 RID: 1065 RVA: 0x00019288 File Offset: 0x00017488
			public oo0_oO(int A_0)
			{
				this.Oo0o_._0_00. = A_0;
				this.OO_0Oo.o0O. = Environment.CurrentManagedThreadId;
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x000192A4 File Offset: 0x000174A4
			void IDisposable.<<EMPTY_NAME>>()
			{
				int oo0o_._0_00. = this.Oo0o_._0_00.;
				if (oo0o_._0_00. == 1 || oo0o_._0_00. - 3 <= 4)
				{
					this.Oo0o_._0_00. = 2;
				}
				else
				{
					this.Oo0o_._0_00. = -1;
				}
				this.Oo0o_._0_00.();
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x000192DC File Offset: 0x000174DC
			[CompilerGenerated]
			bool IEnumerator.<<EMPTY_NAME>>()
			{
				int num = this.Oo0o_._0_00.;
				if (num != 0)
				{
					if (num - 1 > 6)
					{
						return false;
					}
				}
				else
				{
					num = (this.Oo0o_._0_00. = -1);
				}
				try
				{
					switch (num)
					{
					case 1:
						num = (this.Oo0o_._0_00. = -1);
						break;
					case 2:
						num = (this.Oo0o_._0_00. = -1);
						return true;
					case 3:
						num = (this.Oo0o_._0_00. = -1);
						goto IL_367;
					case 4:
						num = (this.Oo0o_._0_00. = -1);
						goto IL_367;
					case 5:
						num = (this.Oo0o_._0_00. = -1);
						goto IL_367;
					case 6:
						num = (this.Oo0o_._0_00. = -1);
						goto IL_367;
					case 7:
						num = (this.Oo0o_._0_00. = -1);
						goto IL_367;
					default:
						this.Oo0o_._0_00. = this.o00.0..o_O0O_O.__o.(this.o00.0., RuntimeHelpers.GetObjectValue(this.o00.0.)).GetEnumerator();
						goto IL_367;
					}
					IL_120:
					if (this.oooo.O0oO_00..Tag.Token.Id == 11028 && this.o00.0..O_oo00_o_0.OO..Contains(this.oooo.O0oO_00..SnapshotRange.Text.Trim(new char[]
					{
						'"'
					})))
					{
						this.Oo0o_._0_00. = new TagSnapshotRange<ITokenTag>(this.oooo.O0oO_00..SnapshotRange, new TokenClassificationTag(this.oooo.O0oO_00..Tag.Token, Oo0O_O0o000.o_OO.oo.));
						num = (this.Oo0o_._0_00. = 3);
						return true;
					}
					if (this.oooo.O0oO_00..Tag.Token.Id == 11033 && Oo0O_O0o000.o_OO.oo..Contains(this.oooo.O0oO_00..SnapshotRange.Text.Trim(new char[]
					{
						'"'
					})))
					{
						this.Oo0o_._0_00. = new TagSnapshotRange<ITokenTag>(this.oooo.O0oO_00..SnapshotRange, new TokenClassificationTag(this.oooo.O0oO_00..Tag.Token, Oo0O_O0o000.o00_.0_oOO.));
						num = (this.Oo0o_._0_00. = 4);
						return true;
					}
					if (VBTokenId.IsNumberClassificationType(this.oooo.O0oO_00..Tag.Token.Id) || this.oooo.O0oO_00..Tag.Token.Id == 11030)
					{
						this.Oo0o_._0_00. = new TagSnapshotRange<ITokenTag>(this.oooo.O0oO_00..SnapshotRange, new TokenClassificationTag(this.oooo.O0oO_00..Tag.Token, Oo0O_O0o000.Ooo._OOo0.));
						num = (this.Oo0o_._0_00. = 5);
						return true;
					}
					if (this.oooo.O0oO_00..Tag.Token.Id == 11217)
					{
						this.Oo0o_._0_00. = new TagSnapshotRange<ITokenTag>(this.oooo.O0oO_00..SnapshotRange, new TokenClassificationTag(this.oooo.O0oO_00..Tag.Token, Oo0O_O0o000.ooO_.o.));
						num = (this.Oo0o_._0_00. = 6);
						return true;
					}
					this.Oo0o_._0_00. = this.oooo.O0oO_00.;
					num = (this.Oo0o_._0_00. = 7);
					return true;
					IL_367:
					if (this.Oo0o_._0_00..MoveNext())
					{
						this.oooo.O0oO_00. = this.Oo0o_._0_00..Current;
						if (this.oooo.O0oO_00..Tag.Token.Id == this.o00.0..o_O0O_O.__o. && Operators.CompareString(this.o00.0..O_oo00_o_0.OO., this.oooo.O0oO_00..SnapshotRange.Text, true) == 0)
						{
							this.Oo0o_._0_00. = new TagSnapshotRange<ITokenTag>(this.oooo.O0oO_00..SnapshotRange, new TokenClassificationTag(this.oooo.O0oO_00..Tag.Token, Oo0O_O0o000.O_oo00_o_0.OO.));
							num = (this.Oo0o_._0_00. = 1);
							return true;
						}
						goto IL_120;
					}
				}
				finally
				{
					if (num < 0 && this.Oo0o_._0_00. != null)
					{
						this.Oo0o_._0_00..Dispose();
					}
				}
				return false;
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x0001969C File Offset: 0x0001789C
			IEnumerator<TagSnapshotRange<ITokenTag>> IEnumerable<TagSnapshotRange<ITokenTag>>.<<EMPTY_NAME>>()
			{
				Oo0O_O0o000.oo0_oO oo0_oO;
				if (this.Oo0o_._0_00. == -2 && this.OO_0Oo.o0O. == Environment.CurrentManagedThreadId)
				{
					this.Oo0o_._0_00. = 0;
					oo0_oO = this;
				}
				else
				{
					oo0_oO = new Oo0O_O0o000.oo0_oO(0);
					oo0_oO.o00.0. = this.o00.0.;
				}
				oo0_oO.o00.0. = this.OO_0Oo.o0O.;
				oo0_oO.o00.0. = this.OO_0Oo.o0O.;
				return oo0_oO;
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x000196F7 File Offset: 0x000178F7
			IEnumerator IEnumerable.<<EMPTY_NAME>>()
			{
				return this.O_oo00_o_0.OO.();
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x000196FF File Offset: 0x000178FF
			TagSnapshotRange<ITokenTag> IEnumerator<TagSnapshotRange<ITokenTag>>.<<EMPTY_NAME>>()
			{
				return this.Oo0o_._0_00.;
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x00019707 File Offset: 0x00017907
			void IEnumerator.<<EMPTY_NAME>>()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x0001970E File Offset: 0x0001790E
			object IEnumerator.<<EMPTY_NAME>>()
			{
				return this.Oo0o_._0_00.;
			}

			// Token: 0x04000113 RID: 275
			public int <<EMPTY_NAME>>;

			// Token: 0x04000114 RID: 276
			public TagSnapshotRange<ITokenTag> <<EMPTY_NAME>>;

			// Token: 0x04000115 RID: 277
			public int <<EMPTY_NAME>>;

			// Token: 0x04000116 RID: 278
			internal NormalizedTextSnapshotRangeCollection <<EMPTY_NAME>>;

			// Token: 0x04000117 RID: 279
			internal NormalizedTextSnapshotRangeCollection <<EMPTY_NAME>>;

			// Token: 0x04000118 RID: 280
			internal object <<EMPTY_NAME>>;

			// Token: 0x04000119 RID: 281
			internal object <<EMPTY_NAME>>;

			// Token: 0x0400011A RID: 282
			internal Oo0O_O0o000 <<EMPTY_NAME>>;

			// Token: 0x0400011B RID: 283
			internal IEnumerator<TagSnapshotRange<ITokenTag>> <<EMPTY_NAME>>;

			// Token: 0x0400011C RID: 284
			internal TagSnapshotRange<ITokenTag> <<EMPTY_NAME>>;
		}
	}
}
