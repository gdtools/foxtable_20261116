using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// Table控件
	/// </summary>
	// Token: 0x02000539 RID: 1337
	[ComVisible(true)]
	public class Table : Control
	{
		// Token: 0x06005974 RID: 22900 RVA: 0x00260338 File Offset: 0x0025E538
		internal Table(O_oOooO_O A_0) : base(A_0, ControlTypeEnum.Table)
		{
			this.OooO.OO0O_. = true;
			this.OoOO_.OOo0o_. = true;
			this.OooO.OO0O_. = A_0;
			if (Environment.OSVersion.Version.Major >= 6)
			{
				this.OooO.OO0O_..BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			}
		}

		/// <summary>
		/// 每页最小应该打印的行数
		/// </summary>
		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x06005975 RID: 22901 RVA: 0x00260384 File Offset: 0x0025E584
		// (set) Token: 0x06005976 RID: 22902 RVA: 0x0026039C File Offset: 0x0025E59C
		[oO0oooo("1604")]
		public int MinRows
		{
			get
			{
				return this.o.__O0O..PrintSettings.GetMinRows(this.OooO.OO0O_.);
			}
			set
			{
				this.o.__O0O..PrintSettings.SetMinRows(this.OooO.OO0O_., value);
			}
		}

		/// <summary>
		/// 表示每页最多可打印的行数
		/// </summary>
		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06005977 RID: 22903 RVA: 0x002603B5 File Offset: 0x0025E5B5
		// (set) Token: 0x06005978 RID: 22904 RVA: 0x002603CD File Offset: 0x0025E5CD
		[oO0oooo("1604")]
		public int MaxRows
		{
			get
			{
				return this.o.__O0O..PrintSettings.GetMaxRows(this.OooO.OO0O_.);
			}
			set
			{
				this.o.__O0O..PrintSettings.SetMaxRows(this.OooO.OO0O_., value);
			}
		}

		/// <summary>
		/// 表示是否打印行号
		/// </summary>
		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06005979 RID: 22905 RVA: 0x002603E6 File Offset: 0x0025E5E6
		// (set) Token: 0x0600597A RID: 22906 RVA: 0x002603FE File Offset: 0x0025E5FE
		public bool PrintRowNumber
		{
			get
			{
				return this.o.__O0O..PrintSettings.GetPrintRowNumber(this.OooO.OO0O_.);
			}
			set
			{
				this.o.__O0O..PrintSettings.SetPrintRowNumber(this.OooO.OO0O_., value);
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600597B RID: 22907 RVA: 0x00260417 File Offset: 0x0025E617
		// (set) Token: 0x0600597C RID: 22908 RVA: 0x00260429 File Offset: 0x0025E629
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ListMode
		{
			get
			{
				return this.OooO.OO0O_..o.0O_O0o_..ListMode;
			}
			set
			{
				this.OooO.OO0O_..o.0O_O0o_..ListMode = value;
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x0600597D RID: 22909 RVA: 0x0026043C File Offset: 0x0025E63C
		// (set) Token: 0x0600597E RID: 22910 RVA: 0x0026044E File Offset: 0x0025E64E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShowCheckBox
		{
			get
			{
				return this.OooO.OO0O_..o.0O_O0o_..ShowCheckBox;
			}
			set
			{
				this.OooO.OO0O_..o.0O_O0o_..ShowCheckBox = value;
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x0600597F RID: 22911 RVA: 0x00260461 File Offset: 0x0025E661
		// (set) Token: 0x06005980 RID: 22912 RVA: 0x00260473 File Offset: 0x0025E673
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AllowClickSort
		{
			get
			{
				return this.OooO.OO0O_..o.0O_O0o_..AllowClickSort;
			}
			set
			{
				this.OooO.OO0O_..o.0O_O0o_..AllowClickSort = value;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06005981 RID: 22913 RVA: 0x00260488 File Offset: 0x0025E688
		// (set) Token: 0x06005982 RID: 22914 RVA: 0x00260498 File Offset: 0x0025E698
		[EditorBrowsable(EditorBrowsableState.Never)]
		public GridLineDirectionEnum GridLineDirection
		{
			get
			{
				GridLineDirectionEnum result;
				return result;
			}
			set
			{
				switch (value)
				{
				case GridLineDirectionEnum.Both:
					this.OooO.OO0O_..Styles.Normal.Border.Direction = BorderDirEnum.Both;
					return;
				case GridLineDirectionEnum.Horizontal:
					this.OooO.OO0O_..Styles.Normal.Border.Direction = BorderDirEnum.Horizontal;
					return;
				case GridLineDirectionEnum.Vertical:
					this.OooO.OO0O_..Styles.Normal.Border.Direction = BorderDirEnum.Vertical;
					return;
				default:
					return;
				}
			}
		}

		/// <summary>
		/// 设置样式
		/// </summary>
		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x0026050D File Offset: 0x0025E70D
		// (set) Token: 0x06005984 RID: 22916 RVA: 0x0026051F File Offset: 0x0025E71F
		public new string Theme
		{
			get
			{
				return Main.OO_O.o..o0_o_o_0.0O.(this.OooO.OO0O_.);
			}
			set
			{
				if (Operators.CompareString(Main.OO_O.o..o0_o_o_0.0O.(this.OooO.OO0O_.), value, true) != 0)
				{
					this.Table.Theme = value;
					if (this.OooO.OO0O_..FindForm() == null)
					{
						this.Table.O0o_OOO.__O.();
					}
				}
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06005985 RID: 22917 RVA: 0x0026055E File Offset: 0x0025E75E
		// (set) Token: 0x06005986 RID: 22918 RVA: 0x0026057C File Offset: 0x0025E77C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color GridColor
		{
			get
			{
				return this.OooO.OO0O_..Styles.Normal.Border.Color;
			}
			set
			{
				this.OooO.OO0O_..Styles.Normal.Border.Color = value;
				if (this.OooO.OO0O_..Styles.Contains("CurrentRow"))
				{
					this.OooO.OO0O_..Styles["CurrentRow"].Border.Color = value;
				}
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06005987 RID: 22919 RVA: 0x002605DB File Offset: 0x0025E7DB
		// (set) Token: 0x06005988 RID: 22920 RVA: 0x002605F7 File Offset: 0x0025E7F7
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int BorderWidth
		{
			get
			{
				return this.OooO.OO0O_..Styles.Normal.Border.Width;
			}
			set
			{
				this.OooO.OO0O_..Styles.Normal.Border.Width = value;
				this.OooO.OO0O_..Styles.EmptyArea.Border.Width = value;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06005989 RID: 22921 RVA: 0x0026062F File Offset: 0x0025E82F
		// (set) Token: 0x0600598A RID: 22922 RVA: 0x00260647 File Offset: 0x0025E847
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RowHeaderVisible
		{
			get
			{
				return this.OooO.OO0O_..Cols[0].Visible;
			}
			set
			{
				this.OooO.OO0O_..Cols[0].Visible = value;
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x0600598B RID: 22923 RVA: 0x00260660 File Offset: 0x0025E860
		// (set) Token: 0x0600598C RID: 22924 RVA: 0x0026067C File Offset: 0x0025E87C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color CurrentRowBackColor
		{
			get
			{
				return this.OooO.OO0O_..Styles["CurrentRow"].BackColor;
			}
			set
			{
				this.OooO.OO0O_..Styles["CurrentRow"].BackColor = value;
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600598D RID: 22925 RVA: 0x00260699 File Offset: 0x0025E899
		// (set) Token: 0x0600598E RID: 22926 RVA: 0x002606B5 File Offset: 0x0025E8B5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Color CurrentRowForeColor
		{
			get
			{
				return this.OooO.OO0O_..Styles["CurrentRow"].ForeColor;
			}
			set
			{
				this.OooO.OO0O_..Styles["CurrentRow"].ForeColor = value;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600598F RID: 22927 RVA: 0x002606D2 File Offset: 0x0025E8D2
		// (set) Token: 0x06005990 RID: 22928 RVA: 0x002606DA File Offset: 0x0025E8DA
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ColumnList
		{
			get
			{
				return this.OooO.OO0O_.;
			}
			set
			{
				this.OooO.OO0O_. = value;
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06005991 RID: 22929 RVA: 0x002606E3 File Offset: 0x0025E8E3
		// (set) Token: 0x06005992 RID: 22930 RVA: 0x002606EB File Offset: 0x0025E8EB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool FocusRect
		{
			get
			{
				return this.OooO.OO0O_.;
			}
			set
			{
				this.OooO.OO0O_. = value;
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06005993 RID: 22931 RVA: 0x002606F4 File Offset: 0x0025E8F4
		// (set) Token: 0x06005994 RID: 22932 RVA: 0x002606FC File Offset: 0x0025E8FC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool AllowEdit
		{
			get
			{
				return this.OoOO_.OOo0o_.;
			}
			set
			{
				this.OoOO_.OOo0o_. = value;
			}
		}

		/// <summary>
		/// 返回此控件所绑定的Table
		/// </summary>
		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06005995 RID: 22933 RVA: 0x00260705 File Offset: 0x0025E905
		public Table Table
		{
			get
			{
				return OO_00oOO.Tables[((O_0)this.OooO.OO0O_..DataSource).Oo._Oo0OO.()];
			}
		}

		// Token: 0x0400232B RID: 9003
		private O_oOooO_O <<EMPTY_NAME>>;

		// Token: 0x0400232C RID: 9004
		private string <<EMPTY_NAME>>;

		// Token: 0x0400232D RID: 9005
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400232E RID: 9006
		private bool <<EMPTY_NAME>>;
	}
}
