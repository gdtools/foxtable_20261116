using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using C1.C1Excel;
using C1.C1Preview;
using C1.Win.C1Command;
using C1.Win.C1FlexGrid;
using C1.Win.C1FlexGrid.Util.BaseControls;
using C1.Win.C1Preview;
using Foxtable.My.Resources;
using Foxtable.RibbonMenu;
using Foxtable.WinForm;
using Foxtable.XLS;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200031C RID: 796
	[ComVisible(true)]
	[oO0oooo("1585")]
	public class Table : IEnumerable<Foxtable.Row>
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06002B35 RID: 11061 RVA: 0x00133EE8 File Offset: 0x001320E8
		// (remove) Token: 0x06002B36 RID: 11062 RVA: 0x00133F20 File Offset: 0x00132120
		[EditorBrowsable(EditorBrowsableState.Never)]
		public event Table.oO00_O_O NameChanged
		{
			[CompilerGenerated]
			add
			{
				Table.oO00_O_O oO00_O_O = this.O.OoOo_.;
				Table.oO00_O_O oO00_O_O2;
				do
				{
					oO00_O_O2 = oO00_O_O;
					Table.oO00_O_O value2 = (Table.oO00_O_O)Delegate.Combine(oO00_O_O2, value);
					oO00_O_O = Interlocked.CompareExchange<Table.oO00_O_O>(ref this.O.OoOo_., value2, oO00_O_O2);
				}
				while (oO00_O_O != oO00_O_O2);
			}
			[CompilerGenerated]
			remove
			{
				Table.oO00_O_O oO00_O_O = this.O.OoOo_.;
				Table.oO00_O_O oO00_O_O2;
				do
				{
					oO00_O_O2 = oO00_O_O;
					Table.oO00_O_O value2 = (Table.oO00_O_O)Delegate.Remove(oO00_O_O2, value);
					oO00_O_O = Interlocked.CompareExchange<Table.oO00_O_O>(ref this.O.OoOo_., value2, oO00_O_O2);
				}
				while (oO00_O_O != oO00_O_O2);
			}
		}

		// Token: 0x06002B37 RID: 11063
		[DllImport("Interop.ADOSC.dll")]
		private static extern int FindPort_2(int A_0, int A_1, int A_2, StringBuilder A_3);

		// Token: 0x06002B38 RID: 11064 RVA: 0x00133F58 File Offset: 0x00132158
		internal Table(O_0 A_0)
		{
			this.oO._0ooO_o0_. = StateFilterEnum.Default;
			this.oO._0ooO_o0_. = TableTypeEnum.Normal;
			this.oO.O0OOO___. = BooleanEnum.Default;
			this.O._0_0ooO0_o0o. = BooleanEnum.Default;
			this.Oo_00o0_.o00. = BooleanEnum.Default;
			this.o.OO0O0O. = BooleanEnum.Default;
			this.o_oo___0.0. = BooleanEnum.Default;
			this.Oo_o._oO0o. = BooleanEnum.Default;
			this.OOO.ooO. = BooleanEnum.Default;
			this.O0O_o0.O_Oo0O0. = BooleanEnum.Default;
			this.Oo_.o0__0. = BooleanEnum.Default;
			this.o_oo.o_. = BooleanEnum.Default;
			this.O_0_O0Oo__.O_o. = BooleanEnum.Default;
			this.OOo0O._0__0. = BooleanEnum.Default;
			this.Oo.0o_0_0. = BooleanEnum.Default;
			this.ooo0.O_. = BooleanEnum.Default;
			this.oo_._0oo_o_0. = BooleanEnum.Default;
			this.o.O_o. = BooleanEnum.Default;
			this.oO._oo_00. = BooleanEnum.Default;
			this.oO00__O_.oO. = MergeModeEnum.None;
			this.oO00__O_.oO. = new List<string>();
			this.o0__OOo0._oO. = DockAreaEnum.底;
			this.O0oooo_o0o0.o. = false;
			this.o.OO0O0O. = true;
			this.ooo.__00__0. = false;
			this.Oo_oo_.o_. = true;
			this.OO0.O__. = true;
			this.oO._0ooO_o0_. = new SubtotalGroupCollection();
			this.o0O_o00_.0__O. = false;
			this.o.Oo_o_o_0oo. = false;
			this.Oo_0o.0. = true;
			this.o_o0O000o.000. = true;
			this.o.0o00ooo_. = new List<string>();
			this.o.OOoo_o. = new List<string>();
			this.O_O__.ooOo. = new Dictionary<string, ListSortDirection>();
			this.O.OoOo_. = 1;
			this.oo_o_.oOO. = false;
			this.O.O000. = false;
			this.ooo_Ooo0.__. = true;
			this.o.0o00ooo_. = 0;
			this.O0oO0_._0. = false;
			this.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.;
			this.OOoOO.OO0. = true;
			this.o.0__o0. = 10000;
			this.oo.o_ooO. = false;
			this.O_O0._. = new InlineGroupTableBuilder();
			this.O_O0._. = new LayersGroupTableBuilder();
			this.o__.O0o. = 0;
			this.o.0ooOO_0__. = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			this.ooo00.o0__OO0. = "(default)";
			this.O_O__.ooOo. = new List<Oo0__O__O_0__>();
			this.O_o0OOo_.o0. = new o_0oo_OOO_0o_(this.O_O__.ooOo.);
			this.o.0ooOO_0__. = A_0;
			this.O_o0OOo_.o0. = new O_oOooO_O(this);
			this.oO._0ooO_o0_. = new Foxtable.RowCollection(this);
			this.o0__OOo0._oO. = new ColCollection(this);
			this.O_o0OOo_.o0..Dock = DockStyle.Fill;
			this.Ooo0ooOOo.o.();
			this.oO._0ooO_o0_. = new PrintInfo(this);
			this.o.0ooOO_0__..O00o0.0_0O_.();
			if (A_0.o_o.O0ooOo.() != null && OO_00oOO.DataTables.Contains(A_0.o_o.O0ooOo.().TableName))
			{
				this.AllowBackEndFilter = OO_00oOO.DataTables[A_0.o_o.O0ooOo.().TableName].o0OOOo_.0_o_0o.;
				this.O_o0OOo_.o0..PreserveEditMode = OO_00oOO.DataTables[A_0.o_o.O0ooOo.().TableName].PreserveEditMode;
			}
			this.O_o0OOo_.o0..PreserveEditMode = this.PreserveEditMode;
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x001341DD File Offset: 0x001323DD
		internal void <<EMPTY_NAME>>()
		{
			this.O_o0OOo_.o0..O.00oO.();
			this.O_o0OOo_.o0..DataSource = null;
			this.O_o0OOo_.o0..Controls.Clear();
			this.O_o0OOo_.o0..Dispose();
			this.O_o0OOo_.o0. = null;
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x00134218 File Offset: 0x00132418
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x00134230 File Offset: 0x00132430
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool HierarchyData
		{
			get
			{
				return this.O0_O.0oOO0Oo0. && this.DataTable.oOOO.OOO_0ooO0.;
			}
			set
			{
				this.O0_O.0oOO0Oo0. = value;
				this.StopRedraw();
				int num = this.Grid.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					this.Grid.Rows[i].Visible = true;
				}
				this.ResumeRedraw();
				this.Grid.Refresh();
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x00134294 File Offset: 0x00132494
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x001342BD File Offset: 0x001324BD
		internal bool Loaded
		{
			get
			{
				return this.IsCopy || this.TableType != TableTypeEnum.Normal || this.o.O0_0o_0O0O.;
			}
			set
			{
				this.o.O0_0o_0O0O. = true;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x001342C6 File Offset: 0x001324C6
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x001342CE File Offset: 0x001324CE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool NeedSaveSetting
		{
			get
			{
				return this.O.0_oooOo00.;
			}
			set
			{
				this.O.0_oooOo00. = value;
			}
		}

		/// <summary>
		/// 名称
		/// </summary>
		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x001342D7 File Offset: 0x001324D7
		[oO0oooo("0440")]
		public string Name
		{
			get
			{
				return this.View.Oo._Oo0OO.();
			}
		}

		/// <summary>
		/// 是否可见
		/// </summary>
		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x001342E4 File Offset: 0x001324E4
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x00134370 File Offset: 0x00132570
		[oO0oooo("0441")]
		public bool Visible
		{
			get
			{
				bool result;
				if (this.IsRelation)
				{
					result = (this.foxGrid.FindForm() != null);
				}
				else
				{
					try
					{
						foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
						{
							Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
							if (oo0__Oo.O_000__.o.() == this)
							{
								result = oo0__Oo.TabVisible;
								break;
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
				return result;
			}
			set
			{
				if (this.IsRelation)
				{
					if (!value)
					{
						if (this.foxGrid.FindForm() == Main.OO_O.o.)
						{
							for (System.Windows.Forms.Control parent = this.foxGrid.Parent; parent != null; parent = parent.Parent)
							{
								if (parent is o_O0_0O0)
								{
									((o_O0_0O0)parent).o_o.O___0o.(this.foxGrid);
									return;
								}
							}
							return;
						}
					}
					else if (this.foxGrid.FindForm() == null)
					{
						string key = this.Name.Substring(0, this.Name.IndexOf("."));
						o_O0_0O0 o_O0_0O;
						switch (this._frdDockArea)
						{
						case DockAreaEnum.右:
							o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[key]).o__0_.o0OoOOO.();
							goto IL_128;
						case DockAreaEnum.左:
							o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[key]).O__O.o_oOO.();
							goto IL_128;
						case DockAreaEnum.上:
							o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[key]).O_000__.o.();
							goto IL_128;
						}
						o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[key]).O._o_00__.();
						IL_128:
						o_O0_0O.OO_o0_oO.0.(this, this._frdDockTitle);
						return;
					}
				}
				else
				{
					try
					{
						foreach (object obj in Main.OO_O.o..OO_O_0Oo.___o.().TabPages)
						{
							Oo0__Oo oo0__Oo = (Oo0__Oo)obj;
							if (oo0__Oo.O_000__.o.() == this)
							{
								oo0__Oo.TabVisible = value;
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
			}
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00134520 File Offset: 0x00132720
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Show()
		{
			if (!this.IsRelation)
			{
				try
				{
					foreach (Foxtable.WinForm.Form form in OO_00oOO.Forms)
					{
						if (form.IsMain && Operators.CompareString(form.TableName, this.Name, true) == 0)
						{
							form.Close();
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
			}
			if (this.foxGrid.FindForm() != null)
			{
				for (System.Windows.Forms.Control parent = this.foxGrid.Parent; parent != null; parent = parent.Parent)
				{
					if (parent is FormPanel)
					{
						Foxtable.WinForm.Form form2 = OO_00oOO.Forms[parent.Name];
						form2.Close();
						if (form2.IsMain & Operators.CompareString(form2.TableName, this.Name, true) != 0)
						{
							OO_00oOO.Tables[form2.TableName].Show();
						}
						break;
					}
				}
			}
			oOO0oo_o0.o.O0o000_.(this.foxGrid);
		}

		/// <summary>
		/// 返回Table所属的DataTable。
		/// </summary>
		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x00134618 File Offset: 0x00132818
		[oO0oooo("0442")]
		public DataTable DataTable
		{
			get
			{
				return OO_00oOO.DataTables[this.View.o_o.O0ooOo.().TableName];
			}
		}

		/// <summary>
		/// 字体
		/// </summary>
		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x00134634 File Offset: 0x00132834
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x00134641 File Offset: 0x00132841
		[oO0oooo("0497")]
		public Font Font
		{
			get
			{
				return this.foxGrid.Font;
			}
			set
			{
				this.foxGrid.Font = value;
			}
		}

		/// <summary>
		/// 字体颜色
		/// </summary>
		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x0013464F File Offset: 0x0013284F
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x0013465C File Offset: 0x0013285C
		[oO0oooo("0498")]
		public Color ForeColor
		{
			get
			{
				return this.foxGrid.ForeColor;
			}
			set
			{
				this.foxGrid.ForeColor = value;
			}
		}

		/// <summary>
		/// 判断指定的Table是否有可以撤销的编辑操作。
		/// </summary>
		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x0013466A File Offset: 0x0013286A
		[oO0oooo("0459")]
		public bool CanUndo
		{
			get
			{
				return this.O_o0OOo_.o0..Count > 0;
			}
		}

		/// <summary>
		/// 判断指定Table是否有可以重做的编辑操作。
		/// </summary>
		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x0013467A File Offset: 0x0013287A
		[oO0oooo("0460")]
		public bool CanRedo
		{
			get
			{
				return this.O_O__.ooOo..Count > 0;
			}
		}

		/// <summary>
		/// 撤销上次编辑操作
		/// </summary>
		// Token: 0x06002B4C RID: 11084 RVA: 0x0013468C File Offset: 0x0013288C
		[oO0oooo("0542")]
		public void Undo()
		{
			if (this.O_o0OOo_.o0..Count > 0)
			{
				Oo0__O__O_0__ oo0__O__O_0__ = this.O_o0OOo_.o0.[this.O_o0OOo_.o0..Count - 1];
				oo0__O__O_0__.O__00.__0_O.();
				this.O_O__.ooOo..Add(oo0__O__O_0__);
				this.O_o0OOo_.o0..Remove(oo0__O__O_0__);
				this.Refresh();
			}
		}

		/// <summary>
		/// 重做最近一次撤销的编辑操作
		/// </summary>
		// Token: 0x06002B4D RID: 11085 RVA: 0x001346E8 File Offset: 0x001328E8
		[oO0oooo("0543")]
		public void Redo()
		{
			if (this.O_O__.ooOo..Count > 0)
			{
				Oo0__O__O_0__ oo0__O__O_0__ = this.O_O__.ooOo.[this.O_O__.ooOo..Count - 1];
				oo0__O__O_0__.oO_o_0.0.();
				this.O_o0OOo_.o0..O__00.__0_O.(oo0__O__O_0__);
				this.O_O__.ooOo..Remove(oo0__O__O_0__);
				this.Refresh();
			}
		}

		/// <summary>
		/// 清除所有的编辑信息，使得撤销和重做按钮无效。
		/// </summary>
		// Token: 0x06002B4E RID: 11086 RVA: 0x00134741 File Offset: 0x00132941
		[oO0oooo("0544")]
		public void ClearEditInfos()
		{
			this.O_o0OOo_.o0..Clear();
			this.O_O__.ooOo..Clear();
		}

		/// <summary>
		/// 统计指定区域的数据
		/// </summary>
		/// <param name="AggregateType">统计类型</param>
		/// <param name="R1">开始行位置</param>
		/// <param name="C1">开始列位置</param>
		/// <param name="R2">结束行位置</param>
		/// <param name="C2">结束列位置</param>
		// Token: 0x06002B4F RID: 11087 RVA: 0x0013475C File Offset: 0x0013295C
		[oO0oooo("0545")]
		public double Aggregate(AggregateEnum AggregateType, int R1, int C1, int R2, int C2)
		{
			O_oOooO_O o_oOooO_O = this.foxGrid;
			int digits = 2;
			R1 = o_oOooO_O.Rows.Fixed + R1;
			R2 = o_oOooO_O.Rows.Fixed + R2;
			C1 = o_oOooO_O.Cols.Fixed + C1;
			C2 = o_oOooO_O.Cols.Fixed + C2;
			double result;
			if (R1 < 0 || R2 < 0 || C1 < 0 || C2 < 0)
			{
				result = 0.0;
			}
			else
			{
				if (this.Cols[o_oOooO_O.Cols[C1].Name].DataCol.Decimals > 2)
				{
					digits = this.Cols[o_oOooO_O.Cols[C1].Name].DataCol.Decimals;
				}
				int dataIndex = this.foxGrid.Rows[R2].DataIndex;
				if (this.GridTreeVisible)
				{
					if (dataIndex >= 0 && this.Rows[dataIndex].HasChild)
					{
						int hierarchy = this.Rows[dataIndex].Hierarchy;
						int num = R2 + 1;
						int num2 = this.foxGrid.Rows.Count - 1;
						for (int i = num; i <= num2; i++)
						{
							dataIndex = this.foxGrid.Rows[i].DataIndex;
							if (dataIndex >= 0)
							{
								if (this.Rows[dataIndex].Hierarchy <= hierarchy)
								{
									break;
								}
								R2 = i;
							}
						}
					}
					result = Math.Round(this.foxGrid.Aggregate((AggregateEnum)AggregateType, R1, C1, R2, C2, AggregateFlags.ExcludeNodes), digits);
				}
				else
				{
					if (dataIndex < 0 && o_oOooO_O.Rows[R2].Node != null && o_oOooO_O.SubtotalPosition == SubtotalPositionEnum.AboveData)
					{
						int level = o_oOooO_O.Rows[R2].Node.Level;
						int num3 = o_oOooO_O.Rows.Count - 1;
						int num4 = R2 + 1;
						int num5 = this.foxGrid.Rows.Count - 1;
						for (int j = num4; j <= num5; j++)
						{
							if (o_oOooO_O.Rows[j].IsNode && o_oOooO_O.Rows[j].Node.Level == level)
							{
								num3 = j - 1;
								break;
							}
						}
						R2 = num3;
					}
					result = Math.Round(this.foxGrid.Aggregate((AggregateEnum)AggregateType, R1, C1, R2, C2, AggregateFlags.ExcludeNodes | AggregateFlags.ExcludeHiddenCells), digits);
				}
			}
			return result;
		}

		/// <summary>
		/// 字符串集合，包括所有需要合并列的名称
		/// </summary>
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x001349BD File Offset: 0x00132BBD
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x001349C5 File Offset: 0x00132BC5
		[oO0oooo("1373")]
		public List<string> MergeCols
		{
			get
			{
				return this.oO00__O_.oO.;
			}
			set
			{
				this.oO00__O_.oO. = value;
			}
		}

		/// <summary>
		/// 在设置合并模式式，用于指定排序的列
		/// </summary>
		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x001349CE File Offset: 0x00132BCE
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x001349D6 File Offset: 0x00132BD6
		[oO0oooo("1373")]
		public string MergeSort
		{
			get
			{
				return this.oO00__O_.oO.;
			}
			set
			{
				this.oO00__O_.oO. = value;
			}
		}

		/// <summary>
		/// 合并方式
		/// </summary>
		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x001349DF File Offset: 0x00132BDF
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x001349E7 File Offset: 0x00132BE7
		[oO0oooo("1373")]
		public MergeModeEnum MergeMode
		{
			get
			{
				return this.oO00__O_.oO.;
			}
			set
			{
				this.oO00__O_.oO. = value;
			}
		}

		/// <summary>
		/// 是否开启合并模式
		/// </summary>
		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x001349F0 File Offset: 0x00132BF0
		// (set) Token: 0x06002B57 RID: 11095 RVA: 0x00134A14 File Offset: 0x00132C14
		[oO0oooo("1373")]
		public bool AllowMerge
		{
			get
			{
				return this.foxGrid.AllowMerging != AllowMergingEnum.Nodes;
			}
			set
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
					if (!value || this.MergeCols == null)
					{
						goto IL_13C;
					}
					IL_1A:
					num2 = 3;
					IEnumerator<Col> enumerator = this.Cols.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Col col = enumerator.Current;
						IL_32:
						num2 = 4;
						col.AllowMerging = false;
						IL_3C:
						num2 = 5;
					}
					IL_46:
					num2 = 6;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
					IL_51:
					num2 = 7;
					switch (this.MergeMode)
					{
					case MergeModeEnum.None:
						IL_92:
						num2 = 13;
						this.foxGrid.AllowMerging = AllowMergingEnum.Nodes;
						break;
					case MergeModeEnum.Standard:
						IL_70:
						num2 = 9;
						this.foxGrid.AllowMerging = AllowMergingEnum.RestrictCols;
						break;
					case MergeModeEnum.Free:
						IL_81:
						num2 = 11;
						this.foxGrid.AllowMerging = AllowMergingEnum.Free;
						break;
					}
					IL_A1:
					num2 = 15;
					List<string>.Enumerator enumerator2 = this.MergeCols.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						string text = enumerator2.Current;
						IL_BC:
						num2 = 16;
						if (this.Cols.Contains(text))
						{
							IL_CE:
							num2 = 17;
							this.Cols[text].AllowMerging = true;
						}
						IL_E4:
						num2 = 18;
					}
					IL_F0:
					num2 = 19;
					((IDisposable)enumerator2).Dispose();
					IL_100:
					num2 = 20;
					this.MergeMode = this.MergeMode;
					IL_10F:
					num2 = 21;
					if (Operators.CompareString(this.View.oO_O.o_OOO.(), this.MergeSort, true) == 0)
					{
						goto IL_14B;
					}
					IL_12B:
					num2 = 22;
					this.Sort = this.MergeSort;
					goto IL_14B;
					IL_13C:
					num2 = 24;
					this.foxGrid.AllowMerging = AllowMergingEnum.Nodes;
					IL_14B:
					num2 = 25;
					this.foxGrid.Invalidate();
					IL_159:
					goto IL_213;
					IL_15E:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_1D4:
					goto IL_208;
					IL_1D6:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_1E6:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_1D6;
				}
				IL_208:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_213:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		/// <summary>
		/// 汇总模式下的各个分组设置
		/// </summary>
		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x00134C58 File Offset: 0x00132E58
		[oO0oooo("1372")]
		public SubtotalGroupCollection SubtotalGroups
		{
			get
			{
				return this.oO._0ooO_o0_.;
			}
		}

		/// <summary>
		/// 分组行是否位于数据行之前，默认为False，设为True，分组行将位于数据行之前
		/// </summary>
		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x00134C60 File Offset: 0x00132E60
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x00134C68 File Offset: 0x00132E68
		[oO0oooo("1372")]
		public bool GroupAboveData
		{
			get
			{
				return this.o0O_o00_.0__O.;
			}
			set
			{
				this.o0O_o00_.0__O. = value;
			}
		}

		/// <summary>
		/// 是否在汇总模式下显示目录树，默认为False，设为True，将显示目录树
		/// </summary>
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x00134C71 File Offset: 0x00132E71
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x00134C7C File Offset: 0x00132E7C
		[oO0oooo("1372")]
		public bool TreeVisible
		{
			get
			{
				return this.o.Oo_o_o_0oo.;
			}
			set
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
					this.o.Oo_o_o_0oo. = value;
					IL_10:
					num2 = 3;
					if (!value)
					{
						goto IL_2D;
					}
					IL_15:
					num2 = 4;
					this.foxGrid.Tree.Style = TreeStyleFlags.Complete;
					goto IL_FD;
					IL_2D:
					num2 = 6;
					if (!this.IsSubtotal)
					{
						goto IL_E9;
					}
					IL_3A:
					num2 = 7;
					if (this.foxGrid.Rows.Count <= this.foxGrid.Rows.Fixed)
					{
						goto IL_E9;
					}
					IL_61:
					num2 = 8;
					if (this.foxGrid.SubtotalPosition != SubtotalPositionEnum.AboveData)
					{
						goto IL_A3;
					}
					IL_70:
					num2 = 9;
					int level = this.foxGrid.Rows[this.foxGrid.Rows.Count - 1].Node.Level;
					goto IL_D2;
					IL_A3:
					num2 = 11;
					level = this.foxGrid.Rows[this.foxGrid.Rows.Fixed].Node.Level;
					IL_D2:
					num2 = 12;
					this.foxGrid.Tree.Show(level + 1);
					IL_E9:
					num2 = 13;
					this.foxGrid.Tree.Style = TreeStyleFlags.None;
					IL_FD:
					num2 = 14;
					if (this.foxGrid.FindForm() == null || !this.IsSubtotal)
					{
						goto IL_1C9;
					}
					IL_11B:
					num2 = 16;
					int width = this.foxGrid.Cols[this.foxGrid.Cols.Fixed].Width;
					IL_144:
					num2 = 17;
					this.foxGrid.AutoSizeCols(this.foxGrid.Cols.Fixed - 1, this.foxGrid.Cols.Fixed, 0);
					IL_175:
					num2 = 18;
					if (this.foxGrid.Cols[this.foxGrid.Cols.Fixed].Width >= width)
					{
						goto IL_1C9;
					}
					IL_1A0:
					num2 = 19;
					this.foxGrid.Cols[this.foxGrid.Cols.Fixed].Width = width;
					IL_1C9:
					goto IL_26B;
					IL_1CE:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_22C:
					goto IL_260;
					IL_22E:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_23E:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_22E;
				}
				IL_260:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_26B:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		/// <summary>
		/// 返回或设置滚动条的滚动位置
		/// </summary>
		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x00134F18 File Offset: 0x00133118
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x00134F25 File Offset: 0x00133125
		public Point ScrollPosition
		{
			get
			{
				return this.foxGrid.ScrollPosition;
			}
			set
			{
				this.foxGrid.ScrollPosition = value;
			}
		}

		/// <summary>
		/// 判断Table是否处于汇总模式
		/// </summary>
		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002B5F RID: 11103 RVA: 0x00134F34 File Offset: 0x00133134
		[oO0oooo("1372")]
		public bool IsSubtotal
		{
			get
			{
				bool result;
				if (this.foxGrid.Rows.Count - this.foxGrid.Rows.Fixed == this.View.Count)
				{
					result = false;
				}
				else
				{
					O_oOooO_O o_oOooO_O = this.foxGrid;
					result = ((o_oOooO_O.Rows[o_oOooO_O.Rows.Count - 1].DataIndex != -1 || o_oOooO_O.Rows[o_oOooO_O.Rows.Count - 1].IsNode) && !this.foxGrid.OO.o_o00o.());
				}
				return result;
			}
		}

		/// <summary>
		/// 是否进入合计模式
		/// </summary>
		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x00134FD3 File Offset: 0x001331D3
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x00134FE0 File Offset: 0x001331E0
		[oO0oooo("2750")]
		public bool GrandTotal
		{
			get
			{
				return this.foxGrid.AllowAddNew;
			}
			set
			{
				if (value && (this.IsSubtotal || this.foxGrid.OO.o_o00o.()))
				{
					MessageBox.Show("不能在汇总模式下显示总计行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					this.foxGrid.AllowAddNew = value;
				}
				this.Grid.Rows[this.Grid.Rows.Count - 1].Invalidate();
			}
		}

		/// <summary>
		/// 退出汇总模式
		/// </summary>
		// Token: 0x06002B62 RID: 11106 RVA: 0x0013504D File Offset: 0x0013324D
		[oO0oooo("1372")]
		public void ClearSubtotal()
		{
			if (this.IsSubtotal)
			{
				this.foxGrid.Subtotal(AggregateEnum.Clear);
			}
			this.foxGrid.O.O00O_oO_OO00.(true);
		}

		/// <summary>
		/// 生成汇总模式
		/// </summary>
		/// <param name="UseCurrentSort"></param>
		// Token: 0x06002B63 RID: 11107 RVA: 0x00135070 File Offset: 0x00133270
		[oO0oooo("1372")]
		public void Subtotal(bool UseCurrentSort = false)
		{
			int num = this.SubtotalGroups.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(this.SubtotalGroups[i].Caption, "", true) == 0)
				{
					this.SubtotalGroups[i].Caption = this.SubtotalGroups[i].O_oo.0oOO.(this);
				}
				if (Operators.CompareString(this.SubtotalGroups[i].GroupOn, "*", true) != 0)
				{
					for (int j = i - 1; j >= 0; j += -1)
					{
						if (Operators.CompareString(this.SubtotalGroups[j].GroupOn, "*", true) != 0 && this.Cols[this.SubtotalGroups[i].GroupOn].IsDate() && this.SubtotalGroups[i].DateGroup != DateGroupEnum.None && !this.Cols[this.SubtotalGroups[j].GroupOn].IsDate())
						{
							MessageBox.Show("汇总模式的日期分组列必须作为第一个分组！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return;
						}
					}
				}
			}
			this.O0o._oo_.(UseCurrentSort);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x001351A8 File Offset: 0x001333A8
		private void <<EMPTY_NAME>>(bool A_0 = false)
		{
			int num3;
			int num21;
			object obj;
			try
			{
				IL_00:
				int num = 1;
				if (this.View.Count == 0)
				{
					goto IL_1F6E;
				}
				IL_12:
				num = 3;
				this.GrandTotal = false;
				IL_1B:
				num = 4;
				int num2 = 0;
				IL_20:
				num = 5;
				IL_22:
				num = 6;
				SubtotalGroup subtotalGroup = null;
				IL_27:
				num = 7;
				List<string> list = new List<string>();
				IL_30:
				num = 8;
				Dictionary<string, double> dictionary = new Dictionary<string, double>();
				IL_39:
				num = 9;
				List<string> list2 = new List<string>();
				IL_43:
				num = 10;
				string text = "";
				IL_4D:
				num = 11;
				this.StopRedraw();
				IL_56:
				num = 12;
				if (!this.GridTreeVisible)
				{
					goto IL_6A;
				}
				IL_61:
				num = 13;
				this.CloseGridTree();
				IL_6A:
				num = 14;
				Information.Err().Clear();
				IL_77:
				ProjectData.ClearProjectError();
				num3 = 1;
				IL_7E:
				num = 16;
				if (!this.GroupAboveData)
				{
					goto IL_9A;
				}
				IL_89:
				num = 17;
				this.foxGrid.SubtotalPosition = SubtotalPositionEnum.AboveData;
				goto IL_A9;
				IL_9A:
				num = 19;
				this.foxGrid.SubtotalPosition = SubtotalPositionEnum.BelowData;
				IL_A9:
				num = 20;
				this.foxGrid.Subtotal(AggregateEnum.Clear);
				IL_B8:
				num = 21;
				this.foxGrid.Tree.Column = this.foxGrid.Cols.Fixed - 1;
				IL_DD:
				num = 22;
				int num4;
				for (int i = this.SubtotalGroups.Count - 1; i >= 0; i += -1)
				{
					IL_F4:
					num = 23;
					SubtotalGroup subtotalGroup2 = this.SubtotalGroups[i];
					IL_106:
					num = 24;
					if (Operators.CompareString(subtotalGroup2.GroupOn, "", true) != 0 && Operators.CompareString(subtotalGroup2.GroupOn, "*", true) != 0 && this.foxGrid.Cols.Contains(subtotalGroup2.GroupOn))
					{
						IL_153:
						num = 27;
						if (subtotalGroup != null)
						{
							IL_15A:
							num = 28;
							if (Operators.CompareString(subtotalGroup2.GroupOn, subtotalGroup.GroupOn, true) != 0 || subtotalGroup2.DateGroup != subtotalGroup.DateGroup)
							{
								IL_183:
								num = 29;
								num2++;
							}
						}
						IL_18C:
						num = 30;
						subtotalGroup2.Level = num2;
						IL_198:
						num = 31;
						subtotalGroup = subtotalGroup2;
						IL_19F:
						num = 32;
						if (!list2.Contains(subtotalGroup2.GroupOn))
						{
							IL_1B2:
							num = 33;
							list2.Add(subtotalGroup2.GroupOn);
							IL_1C3:
							num = 34;
							if (list2.Count > 1)
							{
								IL_1D0:
								num = 35;
								text += ",";
							}
							IL_1E1:
							num = 36;
							text += subtotalGroup2.GroupOn;
						}
						IL_1F4:
						num = 37;
						num4++;
					}
					IL_1FB:
					num = 38;
				}
				IL_20C:
				num = 39;
				if (A_0)
				{
					goto IL_253;
				}
				IL_212:
				num = 40;
				if (Operators.CompareString(text, "", true) <= 0)
				{
					goto IL_253;
				}
				IL_225:
				num = 41;
				this.View.o_O_.00o.(text);
				IL_235:
				num = 42;
				this.View.o_o.O0ooOo.().Sort = text;
				IL_24A:
				num = 43;
				this.O0O.O00oO.();
				IL_253:
				num = 44;
				Foxtable.RibbonMenu.StatusBar.Message1 = "正在统计";
				IL_260:
				num = 45;
				Foxtable.RibbonMenu.StatusBar.ProgressBar.Visible = true;
				IL_269:
				num = 46;
				for (int j = this.SubtotalGroups.Count - 1; j >= 0; j += -1)
				{
					IL_280:
					num = 47;
					SubtotalGroup subtotalGroup2 = this.SubtotalGroups[j];
					IL_292:
					num = 48;
					list.Clear();
					IL_29C:
					num = 49;
					dictionary.Clear();
					IL_2A6:
					num = 50;
					if (Operators.CompareString(subtotalGroup2.GroupOn, "", true) != 0 && (Operators.CompareString(subtotalGroup2.GroupOn, "*", true) == 0 || this.foxGrid.Cols.Contains(subtotalGroup2.GroupOn)))
					{
						IL_2F0:
						num = 52;
						bool flag;
						if (Operators.CompareString(subtotalGroup2.GroupOn, "*", true) != 0 && this.View.o_o.O0ooOo.().Columns[this.foxGrid.Cols[subtotalGroup2.GroupOn].Name].DataType == typeof(DateTime) && subtotalGroup2.DateGroup != DateGroupEnum.None)
						{
							IL_352:
							num = 53;
							flag = true;
						}
						else
						{
							IL_35A:
							num = 55;
							flag = false;
						}
						IL_360:
						num = 56;
						list.AddRange(subtotalGroup2.TotalOn.Split(new char[]
						{
							','
						}, StringSplitOptions.RemoveEmptyEntries));
						IL_382:
						num = 57;
						if (subtotalGroup2.Aggregate == AggregateEnum.Percent)
						{
							IL_392:
							num = 58;
							List<string>.Enumerator enumerator = list.GetEnumerator();
							while (enumerator.MoveNext())
							{
								string text2 = enumerator.Current;
								IL_3AC:
								num = 59;
								int num5 = this.foxGrid.Cols.IndexOf(text2);
								IL_3C3:
								num = 60;
								if (!dictionary.ContainsKey(text2))
								{
									IL_3D4:
									num = 62;
									double value;
									if (this.View.o_o.O0ooOo.().Columns[text2].DataType == typeof(DateTime))
									{
										IL_3FF:
										num = 63;
										value = this.foxGrid.Aggregate(AggregateEnum.Count, this.foxGrid.Rows.Fixed, num5, this.foxGrid.Rows.Count - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateDates);
									}
									else
									{
										IL_43C:
										num = 65;
										if (this.View.o_o.O0ooOo.().Columns[text2].DataType == typeof(bool))
										{
											IL_467:
											num = 66;
											value = this.foxGrid.Aggregate(AggregateEnum.Count, this.foxGrid.Rows.Fixed, num5, this.foxGrid.Rows.Count - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateBooleans);
										}
										else
										{
											IL_4A1:
											num = 68;
											value = this.foxGrid.Aggregate(AggregateEnum.Sum, this.foxGrid.Rows.Fixed, num5, this.foxGrid.Rows.Count - 1, num5, AggregateFlags.ExcludeNodes);
										}
									}
									IL_4D9:
									num = 69;
									dictionary.Add(text2, value);
								}
								IL_4E7:
								num = 70;
							}
							IL_4F6:
							num = 71;
							((IDisposable)enumerator).Dispose();
						}
						IL_506:
						num = 72;
						if (Operators.CompareString(subtotalGroup2.GroupOn, "*", true) == 0)
						{
							IL_520:
							num = 73;
							int num7;
							if (this.foxGrid.SubtotalPosition == SubtotalPositionEnum.BelowData)
							{
								IL_534:
								num = 74;
								int num6 = this.foxGrid.Rows.Count - 1;
								int @fixed = this.foxGrid.Rows.Fixed;
								for (int k = num6; k >= @fixed; k += -1)
								{
									IL_55F:
									num = 75;
									if (!this.foxGrid.Rows[k].IsNode || this.foxGrid.Rows[k].Node.Level > -1)
									{
										IL_59A:
										num = 76;
										num7 = k + 1;
										break;
									}
									IL_5A8:
									num = 78;
								}
							}
							else
							{
								IL_5B9:
								num = 80;
								int fixed2 = this.foxGrid.Rows.Fixed;
								int num8 = this.foxGrid.Rows.Count - 1;
								for (int l = fixed2; l <= num8; l++)
								{
									IL_5E4:
									num = 81;
									if (!this.foxGrid.Rows[l].IsNode || this.foxGrid.Rows[l].Node.Level > -1)
									{
										IL_61F:
										num = 82;
										num7 = l;
										break;
									}
									IL_628:
									num = 84;
								}
							}
							IL_637:
							num = 85;
							if (num7 != 0)
							{
								IL_641:
								num = 87;
								C1.Win.C1FlexGrid.Row row = this.foxGrid.Rows.InsertNode(num7, -1).Row;
								IL_65E:
								num = 88;
								this.foxGrid.SetData(row.Index, this.foxGrid.Cols.Fixed, subtotalGroup2.Caption, false);
								IL_68C:
								num = 89;
								row.Style = this.foxGrid.Styles[CellStyleEnum.GrandTotal];
								IL_6A8:
								num = 90;
								List<string>.Enumerator enumerator2 = list.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									string text3 = enumerator2.Current;
									IL_6C2:
									num = 91;
									int num5 = this.foxGrid.Cols.IndexOf(text3);
									IL_6D9:
									num = 92;
									if (this.Cols[text3].IsNumeric())
									{
										IL_6F0:
										num = 93;
										this.foxGrid.GetCellRange(row.Index, num5).StyleNew.DataType = typeof(decimal);
									}
									IL_71F:
									num = 94;
									if (this.View.o_o.O0ooOo.().Columns[text3].DataType == typeof(bool))
									{
										IL_74A:
										num = 95;
										this.foxGrid.GetCellRange(row.Index, num5).StyleNew.DataType = typeof(double);
									}
									IL_779:
									num = 96;
									if (subtotalGroup2.Aggregate == AggregateEnum.Percent)
									{
										IL_786:
										num = 97;
										row[num5] = 1;
										IL_798:
										num = 98;
										this.foxGrid.GetCellRange(row.Index, num5).StyleNew.Format = "0.##%";
									}
									else
									{
										IL_7C7:
										num = 100;
										if (this.View.o_o.O0ooOo.().Columns[text3].DataType == typeof(DateTime))
										{
											IL_7F2:
											num = 101;
											row[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, this.foxGrid.Rows.Fixed, num5, this.foxGrid.Rows.Count - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateDates);
										}
										else
										{
											IL_841:
											num = 103;
											if (this.View.o_o.O0ooOo.().Columns[text3].DataType == typeof(bool) && subtotalGroup2.Aggregate == AggregateEnum.Sum)
											{
												IL_876:
												num = 104;
												row[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, this.foxGrid.Rows.Fixed, num5, this.foxGrid.Rows.Count - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateBooleans);
											}
											else
											{
												IL_8C2:
												num = 106;
												row[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, this.foxGrid.Rows.Fixed, num5, this.foxGrid.Rows.Count - 1, num5, AggregateFlags.ExcludeNodes);
											}
										}
									}
									IL_90C:
									num = 107;
								}
								IL_91B:
								num = 108;
								((IDisposable)enumerator2).Dispose();
							}
						}
						else
						{
							IL_930:
							num = 111;
							int num9 = this.foxGrid.Cols.IndexOf(subtotalGroup2.GroupOn);
							IL_94C:
							num = 112;
							if (this.foxGrid.SubtotalPosition == SubtotalPositionEnum.BelowData)
							{
								IL_960:
								num = 113;
								bool flag2 = false;
								IL_966:
								num = 114;
								int num10 = this.foxGrid.Rows.Fixed;
								IL_97B:
								num = 115;
								int num11 = this.foxGrid.Rows.Fixed + 1;
								IL_992:
								num = 116;
								subtotalGroup2.oOo0.0_. = num10;
								IL_99E:
								num = 117;
								string text4;
								if (this.foxGrid[num10, num9] == DBNull.Value)
								{
									IL_9B7:
									num = 118;
									text4 = "";
								}
								else
								{
									IL_9C6:
									num = 120;
									if (flag)
									{
										IL_9CD:
										num = 121;
										text4 = this.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup);
									}
									else
									{
										IL_9E8:
										num = 123;
										if (this.foxGrid[num10, num9] == DBNull.Value)
										{
											IL_A01:
											num = 124;
											text4 = "";
										}
										else
										{
											IL_A10:
											num = 126;
											text4 = Conversions.ToString(this.foxGrid[num10, num9]);
										}
									}
								}
								for (;;)
								{
									IL_1319:
									num = 128;
									IL_A2E:
									num = 129;
									bool flag3;
									if (num10 == this.foxGrid.Rows.Count - 1)
									{
										IL_A4A:
										num = 130;
										flag3 = true;
										IL_A53:
										num = 131;
										num11 = this.foxGrid.Rows.Count;
									}
									else
									{
										IL_A70:
										num = 133;
										if (this.foxGrid.Rows[num11].DataIndex == -1)
										{
											IL_A90:
											num = 134;
											if (subtotalGroup2.Level != this.foxGrid.Rows[num11].Node.Level)
											{
												IL_ABB:
												num = 135;
												flag2 = true;
											}
											IL_AC4:
											num = 136;
											flag3 = true;
										}
										else
										{
											IL_AD2:
											num = 138;
											if (num11 == this.foxGrid.Rows.Count - 1)
											{
												IL_AF1:
												num = 139;
												flag3 = true;
												IL_AFA:
												num = 140;
												if (this.foxGrid.Rows[num11].DataIndex > -1)
												{
													IL_B1D:
													num = 141;
													if (Operators.CompareString(this.foxGrid[num11, num9].ToString(), text4, true) == 0)
													{
														IL_B41:
														num = 142;
														num11 = this.foxGrid.Rows.Count;
													}
													else
													{
														IL_B5E:
														num = 144;
														if (flag && Operators.CompareString(this.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, true) == 0)
														{
															IL_B89:
															num = 145;
															num11 = this.foxGrid.Rows.Count;
														}
													}
												}
											}
											else
											{
												IL_BA6:
												num = 147;
												if (Operators.CompareString(text4, "", true) == 0 && this.foxGrid[num11, num9] != DBNull.Value)
												{
													IL_BD1:
													num = 148;
													flag3 = true;
												}
												else
												{
													IL_BDF:
													num = 150;
													if (flag)
													{
														IL_BE9:
														num = 151;
														if (Operators.CompareString(this.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, true) != 0)
														{
															IL_C0A:
															num = 152;
															flag3 = true;
														}
													}
													else
													{
														IL_C15:
														num = 154;
														if (this.foxGrid[num11, num9] == DBNull.Value)
														{
															IL_C31:
															num = 155;
															if (Operators.CompareString(text4, "", true) != 0)
															{
																IL_C46:
																num = 156;
																flag3 = true;
															}
														}
														else
														{
															IL_C51:
															num = 158;
															if (Operators.CompareString(Conversions.ToString(this.foxGrid[num11, num9]), text4, true) != 0)
															{
																IL_C75:
																num = 159;
																flag3 = true;
															}
														}
													}
												}
											}
										}
									}
									IL_C7E:
									num = 160;
									if (flag3)
									{
										IL_C8B:
										num = 161;
										flag3 = false;
										IL_C94:
										num = 162;
										string arg;
										if (this.foxGrid.Cols[num9].DataMap == null)
										{
											IL_CB3:
											num = 163;
											arg = text4;
										}
										else
										{
											IL_CBF:
											num = 165;
											arg = this.foxGrid.GetDataDisplay(num10, num9);
										}
										IL_CD6:
										num = 166;
										C1.Win.C1FlexGrid.Row row2 = this.foxGrid.Rows.InsertNode(num11, subtotalGroup2.Level).Row;
										IL_CFC:
										num = 167;
										row2.Style = this.foxGrid.Styles[(CellStyleEnum)Conversions.ToInteger(Enum.Parse(typeof(CellStyleEnum), "Subtotal" + Conversions.ToString(Math.Min(subtotalGroup2.Level, 5))))];
										IL_D49:
										num = 168;
										this.foxGrid.SetData(row2.Index, this.foxGrid.Cols.Fixed, string.Format(subtotalGroup2.Caption, arg), false);
										IL_D81:
										num = 169;
										int topRow = num10;
										IL_D8B:
										num = 170;
										if (subtotalGroup2.upto)
										{
											IL_D9A:
											num = 171;
											topRow = subtotalGroup2.oOo0.0_.;
										}
										IL_DA9:
										num = 172;
										List<string>.Enumerator enumerator3 = list.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											string text5 = enumerator3.Current;
											IL_DC6:
											num = 173;
											int num5 = this.foxGrid.Cols.IndexOf(text5);
											IL_DE0:
											num = 174;
											if (this.Cols[text5].IsNumeric())
											{
												IL_DFA:
												num = 175;
												this.foxGrid.GetCellRange(row2.Index, num5).StyleNew.DataType = typeof(decimal);
											}
											IL_E2C:
											num = 176;
											if (num5 >= this.foxGrid.Cols.Fixed)
											{
												IL_E49:
												num = 178;
												if (this.View.o_o.O0ooOo.().Columns[text5].DataType == typeof(bool))
												{
													IL_E77:
													num = 179;
													this.foxGrid.GetCellRange(row2.Index, num5).StyleNew.DataType = typeof(double);
												}
												IL_EA9:
												num = 180;
												if (subtotalGroup2.Aggregate == AggregateEnum.Percent)
												{
													IL_EBC:
													num = 181;
													this.foxGrid.GetCellRange(row2.Index, num5).StyleNew.Format = "0.##%";
													IL_EE9:
													num = 182;
													double num12;
													if (this.View.o_o.O0ooOo.().Columns[text5].DataType == typeof(DateTime))
													{
														IL_F17:
														num = 183;
														num12 = this.foxGrid.Aggregate(AggregateEnum.Count, topRow, num5, num11 - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateDates);
													}
													else
													{
														IL_F38:
														num = 185;
														if (this.View.o_o.O0ooOo.().Columns[text5].DataType == typeof(bool))
														{
															IL_F66:
															num = 186;
															num12 = this.foxGrid.Aggregate(AggregateEnum.Count, topRow, num5, num11 - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateBooleans);
														}
														else
														{
															IL_F87:
															num = 188;
															num12 = this.foxGrid.Aggregate(AggregateEnum.Sum, topRow, num5, num11 - 1, num5, AggregateFlags.ExcludeNodes);
														}
													}
													IL_FA6:
													num = 189;
													if (dictionary[text5] > 0.0)
													{
														IL_FC0:
														num = 190;
														row2[num5] = num12 / dictionary[text5];
													}
													else
													{
														IL_FE5:
														num = 192;
														row2[num5] = 0;
													}
												}
												else
												{
													IL_FFF:
													num = 194;
													if (this.View.o_o.O0ooOo.().Columns[text5].DataType == typeof(DateTime))
													{
														IL_102D:
														num = 195;
														row2[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, topRow, num5, num11 - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateDates);
													}
													else
													{
														IL_1063:
														num = 197;
														if (this.View.o_o.O0ooOo.().Columns[text5].DataType == typeof(bool) && subtotalGroup2.Aggregate == AggregateEnum.Sum)
														{
															IL_109B:
															num = 198;
															row2[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, topRow, num5, num11 - 1, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateBooleans);
														}
														else
														{
															IL_10CE:
															num = 200;
															row2[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, topRow, num5, num11 - 1, num5, AggregateFlags.ExcludeNodes);
														}
													}
												}
											}
											IL_10FF:
											num = 201;
										}
										IL_1111:
										num = 202;
										((IDisposable)enumerator3).Dispose();
										IL_1124:
										num = 203;
										num10 = -1;
										IL_112D:
										num = 204;
										text4 = "";
										IL_113A:
										num = 205;
										int num13 = num11;
										int num14 = this.foxGrid.Rows.Count - 1;
										int m = num13;
										while (m <= num14)
										{
											IL_115D:
											num = 206;
											if (this.foxGrid.Rows[m].DataIndex != -1)
											{
												IL_1180:
												num = 209;
												num10 = m;
												IL_118A:
												num = 210;
												num11 = num10 + 1;
												IL_1196:
												num = 211;
												if (this.foxGrid[num10, num9] == null)
												{
													IL_11AD:
													num = 212;
													text4 = "";
													break;
												}
												IL_11BF:
												num = 214;
												if (flag)
												{
													IL_11C9:
													num = 215;
													text4 = this.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup);
													break;
												}
												IL_11E4:
												num = 217;
												if (this.foxGrid[num10, num9] == DBNull.Value)
												{
													IL_1200:
													num = 218;
													text4 = "";
													break;
												}
												IL_120F:
												num = 220;
												text4 = Conversions.ToString(this.foxGrid[num10, num9]);
												break;
											}
											else
											{
												IL_122D:
												num = 222;
												m++;
											}
										}
										IL_1242:
										num = 223;
										if (num10 == -1)
										{
											break;
										}
										IL_1250:
										num = 225;
										if (flag2)
										{
											IL_125A:
											num = 226;
											subtotalGroup2.oOo0.0_. = num10;
											IL_1269:
											num = 227;
											flag2 = false;
										}
									}
									else
									{
										IL_1274:
										num = 229;
										num11++;
										IL_1280:
										num = 230;
										if (num11 > this.foxGrid.Rows.Count - 1)
										{
											break;
										}
									}
									IL_129F:
									num = 232;
									if (num11 % 500 == 0)
									{
										IL_12AF:
										num = 233;
										int value2 = (int)Math.Round((double)num11 / (double)this.foxGrid.Rows.Count / (double)num4 * (double)(j + 1) * 100.0);
										IL_12E5:
										num = 234;
										Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = value2;
										IL_12F2:
										num = 235;
										Foxtable.RibbonMenu.StatusBar.Message2 = Conversions.ToString(value2) + "%";
										IL_130E:
										num = 236;
										Application.DoEvents();
									}
								}
							}
							else
							{
								IL_1324:
								num = 239;
								if (this.foxGrid.SubtotalPosition == SubtotalPositionEnum.AboveData)
								{
									IL_133A:
									num = 240;
									bool flag2 = false;
									IL_1343:
									num = 241;
									int fixed3 = this.foxGrid.Rows.Fixed;
									int num15 = this.foxGrid.Rows.Count - 1;
									int num10;
									for (int n = fixed3; n <= num15; n++)
									{
										IL_1371:
										num = 242;
										if (this.foxGrid.Rows[n].DataIndex > -1)
										{
											IL_1391:
											num = 243;
											num10 = n;
											break;
										}
										IL_139D:
										num = 245;
									}
									IL_13AF:
									num = 246;
									subtotalGroup2.oOo0.0_. = num10;
									IL_13BE:
									num = 247;
									int num11 = num10 + 1;
									IL_13CA:
									num = 248;
									string text4;
									if (this.foxGrid[num10, num9] == DBNull.Value)
									{
										IL_13E6:
										num = 249;
										text4 = "";
									}
									else
									{
										IL_13F8:
										num = 251;
										if (flag)
										{
											IL_1402:
											num = 252;
											text4 = this.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup);
										}
										else
										{
											IL_1420:
											num = 254;
											if (this.foxGrid[num10, num9] == DBNull.Value)
											{
												IL_143C:
												num = 255;
												text4 = "";
											}
											else
											{
												IL_144E:
												num = 257;
												text4 = Conversions.ToString(this.foxGrid[num10, num9]);
											}
										}
									}
									for (;;)
									{
										IL_1D37:
										num = 259;
										IL_146F:
										num = 260;
										bool flag3;
										if (num10 == this.foxGrid.Rows.Count - 1)
										{
											IL_148B:
											num = 261;
											flag3 = true;
											IL_1494:
											num = 262;
											num11 = this.foxGrid.Rows.Count;
										}
										else
										{
											IL_14B1:
											num = 264;
											if (this.foxGrid.Rows[num11].DataIndex == -1)
											{
												IL_14D1:
												num = 265;
												if (subtotalGroup2.Level != this.foxGrid.Rows[num11].Node.Level)
												{
													IL_14FC:
													num = 266;
													flag2 = true;
												}
												IL_1505:
												num = 267;
												flag3 = true;
											}
											else
											{
												IL_1513:
												num = 269;
												if (num11 == this.foxGrid.Rows.Count - 1)
												{
													IL_1532:
													num = 270;
													flag3 = true;
													IL_153B:
													num = 271;
													if (flag)
													{
														IL_1545:
														num = 272;
														if (Operators.CompareString(this.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, true) == 0)
														{
															IL_1569:
															num = 273;
															num11 = this.foxGrid.Rows.Count;
														}
													}
													else
													{
														IL_1586:
														num = 275;
														if (Operators.CompareString(this.foxGrid[num11, num9].ToString(), text4, true) == 0)
														{
															IL_15AD:
															num = 276;
															num11 = this.foxGrid.Rows.Count;
														}
													}
												}
												else
												{
													IL_15CA:
													num = 278;
													if (Operators.CompareString(text4, "", true) == 0 && this.foxGrid[num11, num9] != DBNull.Value)
													{
														IL_15F5:
														num = 279;
														flag3 = true;
													}
													else
													{
														IL_1603:
														num = 281;
														if (flag)
														{
															IL_160D:
															num = 282;
															if (Operators.CompareString(this.o.oO__OO_oo_0_.(num11, num9, subtotalGroup2.DateGroup), text4, true) != 0)
															{
																IL_162E:
																num = 283;
																flag3 = true;
															}
														}
														else
														{
															IL_1639:
															num = 285;
															if (this.foxGrid[num11, num9] == DBNull.Value)
															{
																IL_1655:
																num = 286;
																if (Operators.CompareString(text4, "", true) != 0)
																{
																	IL_166A:
																	num = 287;
																	flag3 = true;
																}
															}
															else
															{
																IL_1675:
																num = 289;
																if (Operators.CompareString(Conversions.ToString(this.foxGrid[num11, num9]), text4, true) != 0)
																{
																	IL_1699:
																	num = 290;
																	flag3 = true;
																}
															}
														}
													}
												}
											}
										}
										IL_16A2:
										num = 291;
										if (flag3)
										{
											IL_16AF:
											num = 292;
											flag3 = false;
											IL_16B8:
											num = 293;
											string arg;
											if (this.foxGrid.Cols[num9].DataMap == null)
											{
												IL_16D7:
												num = 294;
												arg = text4;
											}
											else
											{
												IL_16E3:
												num = 296;
												arg = this.foxGrid.GetDataDisplay(num10, num9);
											}
											IL_16FA:
											num = 297;
											C1.Win.C1FlexGrid.Row row3 = this.foxGrid.Rows.InsertNode(num10, subtotalGroup2.Level).Row;
											IL_1720:
											num = 298;
											row3.Style = this.foxGrid.Styles[(CellStyleEnum)Conversions.ToInteger(Enum.Parse(typeof(CellStyleEnum), "Subtotal" + Conversions.ToString(Math.Min(subtotalGroup2.Level, 5))))];
											IL_176D:
											num = 299;
											this.foxGrid.SetData(row3.Index, this.foxGrid.Cols.Fixed, string.Format(subtotalGroup2.Caption, arg), false);
											IL_17A5:
											num = 300;
											int topRow2 = num10 + 1;
											IL_17B1:
											num = 301;
											if (subtotalGroup2.upto)
											{
												IL_17C0:
												num = 302;
												topRow2 = subtotalGroup2.oOo0.0_. + 1;
											}
											IL_17D1:
											num = 303;
											List<string>.Enumerator enumerator4 = list.GetEnumerator();
											while (enumerator4.MoveNext())
											{
												string text6 = enumerator4.Current;
												IL_17EE:
												num = 304;
												int num5 = this.foxGrid.Cols.IndexOf(text6);
												IL_1808:
												num = 305;
												if (this.Cols[text6].IsNumeric())
												{
													IL_1822:
													num = 306;
													this.foxGrid.GetCellRange(row3.Index, num5).StyleNew.DataType = typeof(decimal);
												}
												IL_1854:
												num = 307;
												if (num5 >= this.foxGrid.Cols.Fixed)
												{
													IL_1871:
													num = 309;
													if (this.View.o_o.O0ooOo.().Columns[text6].DataType == typeof(bool))
													{
														IL_189F:
														num = 310;
														this.foxGrid.GetCellRange(row3.Index, num5).StyleNew.DataType = typeof(double);
													}
													IL_18D1:
													num = 311;
													if (subtotalGroup2.Aggregate == AggregateEnum.Percent)
													{
														IL_18E4:
														num = 312;
														this.foxGrid.GetCellRange(row3.Index, num5).StyleNew.Format = "0.##%";
														IL_1911:
														num = 313;
														double num16;
														if (this.View.o_o.O0ooOo.().Columns[text6].DataType == typeof(DateTime))
														{
															IL_193F:
															num = 314;
															num16 = this.foxGrid.Aggregate(AggregateEnum.Count, topRow2, num5, num11, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateDates);
														}
														else
														{
															IL_195E:
															num = 316;
															if (this.View.o_o.O0ooOo.().Columns[text6].DataType == typeof(bool))
															{
																IL_198C:
																num = 317;
																num16 = this.foxGrid.Aggregate(AggregateEnum.Count, topRow2, num5, num11, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateBooleans);
															}
															else
															{
																IL_19AB:
																num = 319;
																num16 = this.foxGrid.Aggregate(AggregateEnum.Sum, topRow2, num5, num11, num5, AggregateFlags.ExcludeNodes);
															}
														}
														IL_19C8:
														num = 320;
														if (dictionary[text6] > 0.0)
														{
															IL_19E2:
															num = 321;
															row3[num5] = num16 / dictionary[text6];
														}
														else
														{
															IL_1A07:
															num = 323;
															row3[num5] = 0;
														}
													}
													else
													{
														IL_1A21:
														num = 325;
														if (this.View.o_o.O0ooOo.().Columns[text6].DataType == typeof(DateTime))
														{
															IL_1A4F:
															num = 326;
															row3[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, topRow2, num5, num11, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateDates);
														}
														else
														{
															IL_1A83:
															num = 328;
															if (this.View.o_o.O0ooOo.().Columns[text6].DataType == typeof(bool) && subtotalGroup2.Aggregate == AggregateEnum.Sum)
															{
																IL_1ABB:
																num = 329;
																row3[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, topRow2, num5, num11, num5, AggregateFlags.ExcludeNodes | AggregateFlags.AggregateBooleans);
															}
															else
															{
																IL_1AEC:
																num = 331;
																row3[num5] = this.foxGrid.Aggregate((AggregateEnum)subtotalGroup2.Aggregate, topRow2, num5, num11, num5, AggregateFlags.ExcludeNodes);
															}
														}
													}
												}
												IL_1B1B:
												num = 332;
											}
											IL_1B2D:
											num = 333;
											((IDisposable)enumerator4).Dispose();
											IL_1B40:
											num = 334;
											num10 = -1;
											IL_1B49:
											num = 335;
											text4 = "";
											IL_1B56:
											num = 336;
											int num17 = num11 + 1;
											int num18 = this.foxGrid.Rows.Count - 1;
											int num19 = num17;
											while (num19 <= num18)
											{
												IL_1B7B:
												num = 337;
												if (this.foxGrid.Rows[num19].DataIndex != -1)
												{
													IL_1B9E:
													num = 340;
													num10 = num19;
													IL_1BA8:
													num = 341;
													num11 = num10 + 1;
													IL_1BB4:
													num = 342;
													if (this.foxGrid[num10, num9] == null)
													{
														IL_1BCB:
														num = 343;
														text4 = "";
														break;
													}
													IL_1BDD:
													num = 345;
													if (flag)
													{
														IL_1BE7:
														num = 346;
														text4 = this.o.oO__OO_oo_0_.(num10, num9, subtotalGroup2.DateGroup);
														break;
													}
													IL_1C02:
													num = 348;
													if (this.foxGrid[num10, num9] == DBNull.Value)
													{
														IL_1C1E:
														num = 349;
														text4 = "";
														break;
													}
													IL_1C2D:
													num = 351;
													text4 = Conversions.ToString(this.foxGrid[num10, num9]);
													break;
												}
												else
												{
													IL_1C4B:
													num = 353;
													num19++;
												}
											}
											IL_1C60:
											num = 354;
											if (num10 == -1)
											{
												break;
											}
											IL_1C6E:
											num = 356;
											if (flag2)
											{
												IL_1C78:
												num = 357;
												subtotalGroup2.oOo0.0_. = num10;
												IL_1C87:
												num = 358;
												flag2 = false;
											}
										}
										else
										{
											IL_1C92:
											num = 360;
											num11++;
											IL_1C9E:
											num = 361;
											if (num11 > this.foxGrid.Rows.Count - 1)
											{
												break;
											}
										}
										IL_1CBD:
										num = 363;
										if (num11 % 500 == 0)
										{
											IL_1CCD:
											num = 364;
											int value3 = (int)Math.Round((double)num11 / (double)this.foxGrid.Rows.Count / (double)num4 * (double)(j + 1) * 100.0);
											IL_1D03:
											num = 365;
											Foxtable.RibbonMenu.StatusBar.ProgressBar.Value = value3;
											IL_1D10:
											num = 366;
											Foxtable.RibbonMenu.StatusBar.Message2 = Conversions.ToString(value3) + "%";
											IL_1D2C:
											num = 367;
											Application.DoEvents();
										}
									}
								}
							}
						}
					}
					IL_1D42:
					num = 369;
				}
				IL_1D56:
				num = 370;
				if (!this.TreeVisible)
				{
					goto IL_1D7D;
				}
				IL_1D64:
				num = 371;
				this.foxGrid.Tree.Style = TreeStyleFlags.Complete;
				goto IL_1D94;
				IL_1D7D:
				num = 373;
				this.foxGrid.Tree.Style = TreeStyleFlags.None;
				IL_1D94:
				num = 374;
				int width = this.Grid.Cols[0].Width;
				IL_1DB2:
				num = 375;
				if (this.SpillNode)
				{
					goto IL_1EB3;
				}
				IL_1DC3:
				num = 376;
				int width2 = this.foxGrid.Cols[this.foxGrid.Cols.Fixed].Width;
				IL_1DF0:
				num = 377;
				if (!this.TreeVisible)
				{
					goto IL_1E34;
				}
				IL_1DFE:
				num = 378;
				this.foxGrid.AutoSizeCols(this.foxGrid.Cols.Fixed - 1, this.foxGrid.Cols.Fixed, 4);
				goto IL_1E55;
				IL_1E34:
				num = 380;
				this.foxGrid.AutoSizeCol(this.foxGrid.Cols.Fixed);
				IL_1E55:
				num = 381;
				if (this.foxGrid.Cols[this.foxGrid.Cols.Fixed].Width >= width2)
				{
					goto IL_1EE9;
				}
				IL_1E84:
				num = 382;
				this.foxGrid.Cols[this.foxGrid.Cols.Fixed].Width = width2;
				goto IL_1EE9;
				IL_1EB3:
				num = 384;
				this.foxGrid.AutoSizeCols(this.foxGrid.Cols.Fixed - 1, this.foxGrid.Cols.Fixed - 1, 4);
				IL_1EE9:
				num = 385;
				if (this.Grid.Cols[0].Width >= width)
				{
					goto IL_1F27;
				}
				IL_1F09:
				num = 386;
				this.Grid.Cols[0].Width = width;
				IL_1F27:
				num = 387;
				Foxtable.RibbonMenu.StatusBar.Reset();
				IL_1F32:
				num = 388;
				this.ResumeRedraw();
				IL_1F3E:
				num = 389;
				if (Information.Err().Number == 0)
				{
					goto IL_1F6E;
				}
				IL_1F50:
				num = 390;
				MessageBox.Show(Information.Err().Description, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_1F6E:
				goto IL_25DC;
				IL_1F73:
				int num20 = num21 + 1;
				num21 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num20);
				IL_259D:
				goto IL_25D1;
				IL_259F:
				num21 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_25AF:;
			}
			catch when (endfilter(obj is Exception & num3 != 0 & num21 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_259F;
			}
			IL_25D1:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_25DC:
			if (num21 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x001377B8 File Offset: 0x001359B8
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x00137890 File Offset: 0x00135A90
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Value
		{
			get
			{
				switch (A_0.Length)
				{
				case 0:
					return this.Value;
				case 2:
				{
					int a_ = Conversions.ToInteger(A_0[0]);
					if (A_0[1] is int)
					{
						return this.O000o_oO.Oo_o.(a_, Conversions.ToInteger(A_0[1]), false);
					}
					if (A_0[1] is string)
					{
						return this.OooO.0.(a_, Conversions.ToString(A_0[1]), false);
					}
					break;
				}
				case 3:
				{
					int a_2 = Conversions.ToInteger(A_0[0]);
					bool a_3 = Conversions.ToBoolean(A_0[2]);
					if (A_0[1] is int)
					{
						return this.O000o_oO.Oo_o.(a_2, Conversions.ToInteger(A_0[1]), a_3);
					}
					if (A_0[1] is string)
					{
						return this.OooO.0.(a_2, Conversions.ToString(A_0[1]), a_3);
					}
					break;
				}
				}
				throw new ArgumentException("Value属性仅支持2个或3个参数！");
			}
			set
			{
				switch (A_0.Length)
				{
				case 0:
					this.Value = RuntimeHelpers.GetObjectValue(value);
					return;
				case 1:
					break;
				case 2:
				{
					int a_ = Conversions.ToInteger(A_0[0]);
					if (A_0[1] is int)
					{
						this.OO_oo_._.(a_, Conversions.ToInteger(A_0[1]), false, RuntimeHelpers.GetObjectValue(value));
						return;
					}
					if (A_0[1] is string)
					{
						this.OO_oo_._.(a_, Conversions.ToString(A_0[1]), false, RuntimeHelpers.GetObjectValue(value));
						return;
					}
					break;
				}
				case 3:
				{
					int a_2 = Conversions.ToInteger(A_0[0]);
					bool a_3 = Conversions.ToBoolean(A_0[2]);
					if (A_0[1] is int)
					{
						this.OO_oo_._.(a_2, Conversions.ToInteger(A_0[1]), a_3, RuntimeHelpers.GetObjectValue(value));
						return;
					}
					if (A_0[1] is string)
					{
						this.OO_oo_._.(a_2, Conversions.ToString(A_0[1]), a_3, RuntimeHelpers.GetObjectValue(value));
					}
					break;
				}
				default:
					return;
				}
			}
		}

		/// <summary>
		/// 获取焦点单元格的值
		/// </summary>
		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x00137964 File Offset: 0x00135B64
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x00137A5C File Offset: 0x00135C5C
		[oO0oooo("0443")]
		public object Value
		{
			get
			{
				object result;
				if (this.foxGrid.Row < this.foxGrid.Rows.Fixed || this.foxGrid.Col < this.foxGrid.Cols.Fixed)
				{
					result = null;
				}
				else if (this.Grid.Rows[this.foxGrid.Row].DataIndex >= 0)
				{
					result = this.O000o_oO.Oo_o.(this.Grid.Rows[this.foxGrid.Row].DataIndex, this.Grid.Col - this.Grid.Cols.Fixed, false);
				}
				else
				{
					result = this.O000o_oO.Oo_o.(this.foxGrid.Row - this.Grid.Rows.Fixed, this.Grid.Col - this.Grid.Cols.Fixed, true);
				}
				return result;
			}
			set
			{
				if (this.foxGrid.Row >= this.foxGrid.Rows.Fixed && this.foxGrid.Col >= this.foxGrid.Cols.Fixed)
				{
					if (this.Grid.Rows[this.foxGrid.Row].DataIndex >= 0)
					{
						this.OO_oo_._.(this.Grid.Rows[this.foxGrid.Row].DataIndex, this.Grid.Col - this.Grid.Cols.Fixed, false, RuntimeHelpers.GetObjectValue(value));
						return;
					}
					this.OO_oo_._.(this.foxGrid.Row - this.Grid.Rows.Fixed, this.Grid.Col - this.Grid.Cols.Fixed, true, RuntimeHelpers.GetObjectValue(value));
				}
			}
		}

		/// <summary>
		/// 获得或设置指定坐标位置的单元格的值
		/// </summary>
		/// <param name="Row">行位置</param>
		/// <param name="Col">列位置</param>
		/// <param name="IncludeGroup">是否包括分组行</param>
		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x00137B5B File Offset: 0x00135D5B
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x00137B66 File Offset: 0x00135D66
		[oO0oooo("0443")]
		public object Value
		{
			get
			{
				return this[A_0, A_1, A_2];
			}
			set
			{
				this[A_0, A_1, A_2] = RuntimeHelpers.GetObjectValue(value);
			}
		}

		/// <summary>
		/// 获得或设置指定坐标位置的单元格的值
		/// </summary>
		/// <param name="Row">行位置</param>
		/// <param name="ColumnName">列名</param>
		/// <param name="IncludeGroup">是否包括分组行</param>
		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x00137B78 File Offset: 0x00135D78
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x00137B83 File Offset: 0x00135D83
		[oO0oooo("0443")]
		public object Value
		{
			get
			{
				return this[A_0, A_1, A_2];
			}
			set
			{
				this[A_0, A_1, A_2] = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x170009C2 RID: 2498
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[int A_0, int A_1, bool A_2 = false]
		{
			get
			{
				string name = this.O_o0OOo_.o0..Cols[A_1 + this.O_o0OOo_.o0..Cols.Fixed].Name;
				return this[A_0, name, A_2];
			}
			set
			{
				string name = this.O_o0OOo_.o0..Cols[A_1 + this.O_o0OOo_.o0..Cols.Fixed].Name;
				this[A_0, name, A_2] = RuntimeHelpers.GetObjectValue(value);
			}
		}

		// Token: 0x170009C3 RID: 2499
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object this[int A_0, string A_1, bool A_2 = false]
		{
			get
			{
				object result;
				if (A_2)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.foxGrid[A_0 + this.O_o0OOo_.o0..Rows.Fixed, A_1]);
					if (objectValue == DBNull.Value || objectValue == null)
					{
						Type dataType = this.View.o_o.O0ooOo.().Columns[A_1].DataType;
						if (dataType == typeof(string))
						{
							result = "";
						}
						else if (dataType == typeof(bool))
						{
							result = false;
						}
						else if (dataType == typeof(DateTime))
						{
							result = default(DateTime);
						}
						else
						{
							result = 0;
						}
					}
					else
					{
						result = objectValue;
					}
				}
				else if (this.View.O0O_0_0__.0O.(A_0).Row.IsNull(A_1))
				{
					Type dataType2 = this.View.o_o.O0ooOo.().Columns[A_1].DataType;
					if (dataType2 == typeof(string))
					{
						result = "";
					}
					else if (dataType2 == typeof(bool))
					{
						result = false;
					}
					else if (dataType2 == typeof(DateTime))
					{
						result = default(DateTime);
					}
					else
					{
						result = 0;
					}
				}
				else
				{
					if (this.View.o_o.O0ooOo.().Columns[A_1].DataType == typeof(DateTime))
					{
						DateTime dateTime = Conversions.ToDate(this.View.O0O_0_0__.0O.(A_0)[A_1]);
						switch (this.DataTable.DataCols[A_1].DateTimeFormat)
						{
						case DateTimeFormatEnum.Date:
							return dateTime.Date;
						case DateTimeFormatEnum.Time:
							dateTime = new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
							return dateTime.AddSeconds((double)(-(double)dateTime.Second));
						case DateTimeFormatEnum.LongTime:
							return new DateTime(dateTime.Ticks - dateTime.Date.Ticks);
						case DateTimeFormatEnum.DateTime:
							return dateTime.AddSeconds((double)(-(double)dateTime.Second));
						case DateTimeFormatEnum.DateLongTime:
							return dateTime;
						}
					}
					result = this.View.O0O_0_0__.0O.(A_0)[A_1];
				}
				return result;
			}
			set
			{
				if (!o_O_o_oOoo__.oO.O_..Contains(A_1) && Operators.CompareString(A_1, this.DataTable.O_.__0., true) != 0)
				{
					if (A_2)
					{
						if (this.O_o0OOo_.o0..Rows[A_0 + this.O_o0OOo_.o0..Rows.Fixed].IsNode)
						{
							this.O_o0OOo_.o0..SetData(A_0 + this.O_o0OOo_.o0..Rows.Fixed, A_1, RuntimeHelpers.GetObjectValue(value), false);
							return;
						}
						this.O_o0OOo_.o0.[A_0 + this.O_o0OOo_.o0..Rows.Fixed, A_1] = RuntimeHelpers.GetObjectValue(value);
						return;
					}
					else
					{
						this.View.O0O_0_0__.0O.(A_0)[A_1] = RuntimeHelpers.GetObjectValue(value);
					}
				}
			}
		}

		// Token: 0x170009C4 RID: 2500
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Foxtable.Row this[int A_0, bool A_1 = false]
		{
			get
			{
				Foxtable.Row result;
				if (A_1)
				{
					result = new Foxtable.Row(this, A_0);
				}
				else
				{
					result = new Foxtable.Row(this, this.View.O0O_0_0__.0O.(A_0));
				}
				return result;
			}
		}

		/// <summary>
		/// 获得焦点单元格显示内容
		/// </summary>
		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x00137F92 File Offset: 0x00136192
		[oO0oooo("0444")]
		public string Text
		{
			get
			{
				return this.foxGrid.GetDataDisplay(this.foxGrid.Row, this.foxGrid.Col);
			}
		}

		/// <summary>
		/// 获得任意单元格显示内容
		/// </summary>
		/// <param name="Row">行位置</param>
		/// <param name="Col">列位置</param>
		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x00137FB5 File Offset: 0x001361B5
		[oO0oooo("0444")]
		public string Text
		{
			get
			{
				return this.foxGrid.GetDataDisplay(A_0 + this.foxGrid.Rows.Fixed, A_1 + this.foxGrid.Cols.Fixed);
			}
		}

		/// <summary>
		/// 返回Table的行数
		/// </summary>
		/// <param name="IncludeGroup">是否包括分组行</param>
		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x00137FE8 File Offset: 0x001361E8
		public int Count
		{
			get
			{
				int result;
				if (A_0)
				{
					int num = this.foxGrid.Rows.Count - this.foxGrid.Rows.Fixed;
					if (this.GrandTotal)
					{
						num--;
					}
					result = num;
				}
				else
				{
					result = this.View.Count;
				}
				return result;
			}
		}

		/// <summary>
		/// 行集合
		/// </summary>
		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x00138037 File Offset: 0x00136237
		[oO0oooo("1438")]
		public Foxtable.RowCollection Rows
		{
			get
			{
				return this.oO._0ooO_o0_.;
			}
		}

		/// <summary>
		/// 列集合
		/// </summary>
		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0013803F File Offset: 0x0013623F
		[oO0oooo("0561")]
		public ColCollection Cols
		{
			get
			{
				if (this.foxGrid.FindForm() == null)
				{
					this.O.__O0o0.(true, false);
				}
				return this.o0__OOo0._oO.;
			}
		}

		/// <summary>
		/// 状态筛选
		/// </summary>
		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x0013805D File Offset: 0x0013625D
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x00138068 File Offset: 0x00136268
		[oO0oooo("0450")]
		public StateFilterEnum StateFilter
		{
			get
			{
				return this.oO._0ooO_o0_.;
			}
			set
			{
				int num2;
				int num4;
				object obj;
				try
				{
					IL_00:
					int num = 1;
					this.oO._0ooO_o0_. = value;
					IL_09:
					ProjectData.ClearProjectError();
					num2 = 1;
					IL_10:
					num = 3;
					switch (value)
					{
					case StateFilterEnum.Default:
						IL_4C:
						num = 7;
						this.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.CurrentRows;
						break;
					case StateFilterEnum.Added:
						IL_37:
						num = 5;
						this.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.Added;
						break;
					case StateFilterEnum.Modified:
						IL_62:
						num = 9;
						this.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.ModifiedCurrent;
						break;
					case StateFilterEnum.UnChanged:
						IL_A7:
						num = 15;
						this.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.Unchanged;
						break;
					case StateFilterEnum.Original:
						IL_90:
						num = 13;
						this.View.o_o.O0ooOo.().RowStateFilter = (DataViewRowState.Unchanged | DataViewRowState.ModifiedOriginal);
						break;
					case StateFilterEnum.ModifiedOriginal:
						IL_79:
						num = 11;
						this.View.o_o.O0ooOo.().RowStateFilter = DataViewRowState.ModifiedOriginal;
						break;
					}
					IL_BB:
					goto IL_151;
					IL_C0:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_112:
					goto IL_146;
					IL_114:
					num4 = num;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
					IL_124:;
				}
				catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_114;
				}
				IL_146:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_151:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		/// <summary>
		/// 是否是关联子表
		/// </summary>
		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x001381EC File Offset: 0x001363EC
		[oO0oooo("0456")]
		public bool IsChild
		{
			get
			{
				return this.View.O.o_OOOo_OoO.();
			}
		}

		/// <summary>
		/// 是否是关联父表
		/// </summary>
		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x001381F9 File Offset: 0x001363F9
		[oO0oooo("0455")]
		public bool IsParent
		{
			get
			{
				return this.View.O0OOO_0.o.();
			}
		}

		/// <summary>
		/// 是否是关联表
		/// </summary>
		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x00138206 File Offset: 0x00136406
		[oO0oooo("0454")]
		public bool IsRelation
		{
			get
			{
				return this.View.O0O_0_0__.0O.() != null;
			}
		}

		/// <summary>
		/// 返回或设置当前行位置
		/// </summary>
		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x00138218 File Offset: 0x00136418
		// (set) Token: 0x06002B7D RID: 11133 RVA: 0x001382E4 File Offset: 0x001364E4
		[oO0oooo("0446")]
		public int Position
		{
			get
			{
				O_oOooO_O o_oOooO_O = this.foxGrid;
				int result;
				if (o_oOooO_O.Rows.Count == o_oOooO_O.Rows.Fixed && this.View.o_o.O0ooOo.() != null)
				{
					result = this.View.Position;
				}
				else
				{
					if (o_oOooO_O.Row < o_oOooO_O.Rows.Fixed & o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed)
					{
						o_oOooO_O.Row = o_oOooO_O.Rows.Fixed;
					}
					if (o_oOooO_O.Row < o_oOooO_O.Rows.Fixed)
					{
						result = -1;
					}
					else if (o_oOooO_O.Rows[o_oOooO_O.Row].DataIndex < 0)
					{
						result = -1;
					}
					else
					{
						result = this.View.Position;
					}
				}
				return result;
			}
			set
			{
				if ((this.View.Position != value || this.Grid.Row <= this.foxGrid.Rows.Count - 1 || this.foxGrid.Rows[this.foxGrid.Row].DataIndex < 0) && value >= 0)
				{
					O_oOooO_O o_oOooO_O = this.foxGrid;
					if (o_oOooO_O.Row < o_oOooO_O.Rows.Fixed && o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed)
					{
						o_oOooO_O.Row = o_oOooO_O.Rows.Fixed;
					}
					if (o_oOooO_O.Row >= o_oOooO_O.Rows.Fixed && this.View.Position == value && o_oOooO_O.Rows[o_oOooO_O.Row].DataIndex != value)
					{
						int row = o_oOooO_O.Row;
						int @fixed = o_oOooO_O.Rows.Fixed;
						for (int i = row; i >= @fixed; i += -1)
						{
							if (o_oOooO_O.Rows[i].DataIndex != -1)
							{
								o_oOooO_O.Row = i;
							}
						}
					}
					this.View.Position = value;
				}
			}
		}

		/// <summary>
		/// 当前行。
		/// </summary>
		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x00138410 File Offset: 0x00136610
		[oO0oooo("0445")]
		public Foxtable.Row Current
		{
			get
			{
				O_oOooO_O o_oOooO_O = this.foxGrid;
				Foxtable.Row result;
				if (o_oOooO_O.Rows.Count == o_oOooO_O.Rows.Fixed && this.View.o_o.O0ooOo.() != null)
				{
					result = new Foxtable.Row(this, this.View.o_o.O0ooOo.());
				}
				else if (o_oOooO_O.Row > o_oOooO_O.Rows.Count - 1)
				{
					result = null;
				}
				else
				{
					if (o_oOooO_O.Row < o_oOooO_O.Rows.Fixed & o_oOooO_O.Rows.Count > o_oOooO_O.Rows.Fixed)
					{
						o_oOooO_O.Row = o_oOooO_O.Rows.Fixed;
					}
					if (o_oOooO_O.Row < o_oOooO_O.Rows.Fixed)
					{
						result = null;
					}
					else if (o_oOooO_O.Rows[o_oOooO_O.Row].DataIndex < 0)
					{
						result = null;
					}
					else if (this.View.o_o.O0ooOo.() == null)
					{
						result = null;
					}
					else
					{
						result = new Foxtable.Row(this, this.View.o_o.O0ooOo.());
					}
				}
				return result;
			}
		}

		/// <summary>
		/// 选定行位
		/// </summary>
		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x00138515 File Offset: 0x00136715
		[oO0oooo("0447")]
		public int RowSel
		{
			get
			{
				return this.foxGrid.Row - this.foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 选定列位置
		/// </summary>
		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x00138533 File Offset: 0x00136733
		[oO0oooo("0447")]
		public int ColSel
		{
			get
			{
				return this.foxGrid.Col - this.foxGrid.Cols.Fixed;
			}
		}

		/// <summary>
		/// 选定区域的最上面一行的位置
		/// </summary>
		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x00138554 File Offset: 0x00136754
		[oO0oooo("0447")]
		public int TopRow
		{
			get
			{
				return this.foxGrid.Selection.TopRow - this.foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 设置第一个可见行
		/// </summary>
		/// <param name="Index">行号</param>
		// Token: 0x06002B82 RID: 11138 RVA: 0x00138585 File Offset: 0x00136785
		public void SetFirstVisibleRow(int Index)
		{
			this.foxGrid.TopRow = this.foxGrid.Rows.Fixed + Index;
		}

		/// <summary>
		/// 设置第一个可见列
		/// </summary>
		/// <param name="Index">列号</param>
		// Token: 0x06002B83 RID: 11139 RVA: 0x001385A4 File Offset: 0x001367A4
		public void SetFirstVisibleCol(int Index)
		{
			this.foxGrid.LeftCol = this.foxGrid.Cols.Fixed + Index;
		}

		/// <summary>
		/// 选定区域第一个数据行的位置
		/// </summary>
		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x001385C4 File Offset: 0x001367C4
		[oO0oooo("1595")]
		public int TopPosition
		{
			get
			{
				O_oOooO_O o_oOooO_O = this.foxGrid;
				int topRow = o_oOooO_O.Selection.TopRow;
				int bottomRow = o_oOooO_O.Selection.BottomRow;
				int i = topRow;
				while (i <= bottomRow)
				{
					int result;
					if (i < 0)
					{
						result = -1;
					}
					else
					{
						if (o_oOooO_O.Rows[i].DataIndex <= -1)
						{
							i++;
							continue;
						}
						result = o_oOooO_O.Rows[i].DataIndex;
					}
					return result;
				}
				return -1;
			}
		}

		/// <summary>
		/// 选定区域最后一个数据行的位置
		/// </summary>
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x00138638 File Offset: 0x00136838
		[oO0oooo("1596")]
		public int BottomPosition
		{
			get
			{
				O_oOooO_O o_oOooO_O = this.foxGrid;
				int bottomRow = o_oOooO_O.Selection.BottomRow;
				int topRow = o_oOooO_O.Selection.TopRow;
				int i = bottomRow;
				while (i >= topRow)
				{
					int result;
					if (i < 0)
					{
						result = -1;
					}
					else
					{
						if (o_oOooO_O.Rows[i].DataIndex <= -1)
						{
							i += -1;
							continue;
						}
						result = o_oOooO_O.Rows[i].DataIndex;
					}
					return result;
				}
				return -1;
			}
		}

		/// <summary>
		/// 选定区域的最下面一行的位置
		/// </summary>
		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x001386AC File Offset: 0x001368AC
		[oO0oooo("0447")]
		public int BottomRow
		{
			get
			{
				return this.foxGrid.Selection.BottomRow - this.foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 选定区域的最左边一列的位置 
		/// </summary>
		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x001386E0 File Offset: 0x001368E0
		[oO0oooo("0447")]
		public int LeftCol
		{
			get
			{
				int result;
				if (this.foxGrid.Selection.LeftCol < this.foxGrid.Cols.Fixed)
				{
					result = -1;
				}
				else
				{
					result = this.foxGrid.Selection.LeftCol - this.foxGrid.Cols.Fixed;
				}
				return result;
			}
		}

		/// <summary>
		/// 选定区域的最右边一列的位置
		/// </summary>
		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x0013873C File Offset: 0x0013693C
		[oO0oooo("0447")]
		public int RightCol
		{
			get
			{
				int result;
				if (this.foxGrid.Selection.LeftCol < this.foxGrid.Cols.Fixed)
				{
					result = -2;
				}
				else
				{
					result = this.foxGrid.Selection.RightCol - this.foxGrid.Cols.Fixed;
				}
				return result;
			}
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x0013879C File Offset: 0x0013699C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Select(params object[] args)
		{
			switch (args.Length)
			{
			case 0:
				this.Select();
				return;
			case 1:
			case 3:
				break;
			case 2:
				this.Select(Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1]));
				return;
			case 4:
				this.Select(Conversions.ToInteger(args[0]), Conversions.ToInteger(args[1]), Conversions.ToInteger(args[2]), Conversions.ToInteger(args[3]));
				break;
			default:
				return;
			}
		}

		/// <summary>
		/// 选定指定位置的单元格
		/// </summary>
		/// <param name="r1">行位置</param>
		/// <param name="c1">列位置</param>
		// Token: 0x06002B8A RID: 11146 RVA: 0x0013880D File Offset: 0x00136A0D
		[oO0oooo("0550")]
		public void Select(int r1, int c1)
		{
			this.foxGrid.Select(r1 + this.foxGrid.Rows.Fixed, c1 + this.foxGrid.Cols.Fixed, true);
		}

		/// <summary>
		/// 选定某一区域的单元格
		/// </summary>
		/// <param name="r1">起始行位置</param>
		/// <param name="c1">起始列位置</param>
		/// <param name="r2">结束行位置</param>
		/// <param name="c2">结束列位置</param>
		// Token: 0x06002B8B RID: 11147 RVA: 0x00138840 File Offset: 0x00136A40
		[oO0oooo("0550")]
		public void Select(int r1, int c1, int r2, int c2)
		{
			this.foxGrid.Select(r1 + this.foxGrid.Rows.Fixed, c1 + this.foxGrid.Cols.Fixed, r2 + this.foxGrid.Rows.Fixed, c2 + this.foxGrid.Cols.Fixed, true);
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x001388A2 File Offset: 0x00136AA2
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x001388AF File Offset: 0x00136AAF
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Redraw
		{
			get
			{
				return this.foxGrid.Redraw;
			}
			set
			{
				this.foxGrid.Redraw = value;
			}
		}

		/// <summary>
		/// 停止绘制Table
		/// </summary>
		// Token: 0x06002B8E RID: 11150 RVA: 0x001388BD File Offset: 0x00136ABD
		[oO0oooo("0453")]
		public void StopRedraw()
		{
			this.foxGrid.BeginUpdate();
		}

		/// <summary>
		/// 恢复绘制Table
		/// </summary>
		// Token: 0x06002B8F RID: 11151 RVA: 0x001388CA File Offset: 0x00136ACA
		[oO0oooo("1961")]
		public void ResumeRedraw()
		{
			this.foxGrid.EndUpdate();
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x001388D7 File Offset: 0x00136AD7
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x001388E4 File Offset: 0x00136AE4
		internal string _frdFilterString
		{
			get
			{
				return this.View.o0.O0.();
			}
			set
			{
				this.View.Oo._Oo0OO.(value);
			}
		}

		/// <summary>
		/// 筛选条件表达式
		/// </summary>
		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x001388F2 File Offset: 0x00136AF2
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x001388FF File Offset: 0x00136AFF
		[oO0oooo("0448")]
		public string Filter
		{
			get
			{
				return this.View.get_Filter();
			}
			set
			{
				this.O_o0OOo_.o0..Oo.0.(false);
				this.ClearSubtotal();
				this.View.Oo._Oo0OO.(value);
				this.View.set_Filter(value);
			}
		}

		/// <summary>
		/// 切换筛选
		/// </summary>
		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x0013892B File Offset: 0x00136B2B
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x00138938 File Offset: 0x00136B38
		[oO0oooo("0449")]
		public bool ApplyFilter
		{
			get
			{
				return this.View.o__0.O.();
			}
			set
			{
				if (value)
				{
					this.View.set_Filter(this.View.o0.O0.());
					return;
				}
				this.View.set_Filter("");
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x00138964 File Offset: 0x00136B64
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x00138971 File Offset: 0x00136B71
		internal string _frdSortString
		{
			get
			{
				return this.View.o_._0O0o_OoO.();
			}
			set
			{
				this.View.o_O_.00o.(value);
			}
		}

		/// <summary>
		/// 排序列
		/// </summary>
		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x0013897F File Offset: 0x00136B7F
		// (set) Token: 0x06002B99 RID: 11161 RVA: 0x0013898C File Offset: 0x00136B8C
		[oO0oooo("0451")]
		public string Sort
		{
			get
			{
				return this.View.oO_O.o_OOO.();
			}
			set
			{
				this.O_o0OOo_.o0..Oo.0.(false);
				this.View.oO0o0_.OoO_.(value);
				this.O0O.O00oO.();
			}
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x001389AC File Offset: 0x00136BAC
		private void <<EMPTY_NAME>>()
		{
			this.O_O__.ooOo..Clear();
			if (this.View.SortDescriptions != null)
			{
				int num = this.View.SortDescriptions.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string name = this.View.SortDescriptions[i].PropertyDescriptor.Name;
					if (Operators.CompareString(name, "System_Sort_Temporary", true) != 0 && Operators.CompareString(name, "_SortKey", true) != 0)
					{
						this.O_O__.ooOo..Add(this.View.SortDescriptions[i].PropertyDescriptor.Name.ToLower(), this.View.SortDescriptions[i].SortDirection);
					}
				}
			}
		}

		/// <summary>
		/// 切换排序
		/// </summary>
		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x00138A6F File Offset: 0x00136C6F
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x00138A7C File Offset: 0x00136C7C
		[oO0oooo("0452")]
		public bool ApplySort
		{
			get
			{
				return this.View.OO.___OO0O.();
			}
			set
			{
				if (value)
				{
					this.Sort = this.View.o_._0O0o_OoO.();
					return;
				}
				this.View.oO0o0_.OoO_.("");
				this.O0O.O00oO.();
			}
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00138AAC File Offset: 0x00136CAC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public object Compute(params object[] args)
		{
			object result;
			if (args.Length == 1)
			{
				result = this.Compute(Conversions.ToString(args[0]));
			}
			else if (args.Length == 2)
			{
				result = this.Compute(Conversions.ToString(args[0]), Conversions.ToString(args[1]));
			}
			return result;
		}

		/// <summary>
		/// 根据指定的表达式进行计算
		/// </summary>
		/// <param name="Expression"></param>
		// Token: 0x06002B9E RID: 11166 RVA: 0x00138AEE File Offset: 0x00136CEE
		[oO0oooo("0548")]
		public object Compute(string Expression)
		{
			return this.Compute(Expression, "");
		}

		/// <summary>
		/// 根据指定的表达式和条件进行计算
		/// </summary>
		/// <param name="Expression">聚合函数表达式</param>
		/// <param name="Filter">计算条件表达式</param>
		// Token: 0x06002B9F RID: 11167 RVA: 0x00138AFC File Offset: 0x00136CFC
		[oO0oooo("0548")]
		public object Compute(string Expression, string Filter)
		{
			int num;
			object result;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (!this.IsRelation)
				{
					goto IL_1BC;
				}
				IL_14:
				num2 = 3;
				string text = "";
				IL_1D:
				num2 = 4;
				if (!this.IsChild)
				{
					goto IL_51;
				}
				IL_27:
				num2 = 5;
				DataColumn[] array = this.View.O0O_0_0__.0O.().ChildColumns;
				IL_3B:
				num2 = 6;
				DataColumn[] array2 = this.View.O0O_0_0__.0O.().ParentColumns;
				goto IL_7A;
				IL_51:
				num2 = 8;
				array = this.View.O0O_0_0__.0O.().ParentColumns;
				IL_65:
				num2 = 9;
				array2 = this.View.O0O_0_0__.0O.().ChildColumns;
				IL_7A:
				num2 = 10;
				int num3 = this.View.O0O_0_0__.0O.().ChildColumns.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_9B:
					num2 = 11;
					if (Operators.CompareString(text, "", true) > 0)
					{
						IL_AE:
						num2 = 12;
						text += " And ";
					}
					IL_BF:
					num2 = 13;
					text = text + "[" + array[i].ColumnName + "] = ";
					IL_DF:
					num2 = 14;
					if (this.DataTable.DataCols[array[i].ColumnName].IsNumeric)
					{
						IL_103:
						num2 = 15;
						text += Convert.ToString(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.()[array2[i].ColumnName]));
					}
					else
					{
						IL_13A:
						num2 = 17;
						text = text + "'" + Convert.ToString(RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.()[array2[i].ColumnName])) + "'";
					}
					IL_179:
					num2 = 18;
				}
				IL_18B:
				num2 = 19;
				if (Operators.CompareString(Filter, "", true) != 0)
				{
					goto IL_1A5;
				}
				IL_19C:
				num2 = 20;
				Filter = text;
				goto IL_1BC;
				IL_1A5:
				num2 = 22;
				Filter = Filter + " And (" + text + ")";
				IL_1BC:
				num2 = 23;
				if (Operators.CompareString(this.View.get_Filter(), "", true) <= 0)
				{
					goto IL_267;
				}
				IL_1DB:
				num2 = 24;
				if (Operators.CompareString(Filter, "", true) <= 0)
				{
					goto IL_23F;
				}
				IL_1ED:
				num2 = 25;
				object objectValue = RuntimeHelpers.GetObjectValue(this.View.o_o.O0ooOo.().Compute(Expression, string.Concat(new string[]
				{
					"(",
					Filter,
					") And (",
					this.View.get_Filter(),
					")"
				})));
				goto IL_283;
				IL_23F:
				num2 = 27;
				objectValue = RuntimeHelpers.GetObjectValue(this.View.o_o.O0ooOo.().Compute(Expression, this.View.get_Filter()));
				goto IL_283;
				IL_267:
				num2 = 29;
				objectValue = RuntimeHelpers.GetObjectValue(this.View.o_o.O0ooOo.().Compute(Expression, Filter));
				IL_283:
				num2 = 30;
				if (objectValue != DBNull.Value)
				{
					goto IL_296;
				}
				IL_28F:
				num2 = 31;
				result = null;
				goto IL_29C;
				IL_296:
				num2 = 33;
				result = objectValue;
				IL_29C:
				goto IL_376;
				IL_2A1:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_337:
				goto IL_36B;
				IL_339:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_349:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_339;
			}
			IL_36B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_376:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00138EA4 File Offset: 0x001370A4
		internal void <<EMPTY_NAME>>()
		{
			this.o.O_o. = BooleanEnum.Default;
		}

		/// <summary>
		/// 按回车键是否向下移动焦点单元格
		/// </summary>
		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00138EB0 File Offset: 0x001370B0
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00138EE3 File Offset: 0x001370E3
		[oO0oooo("0472")]
		public bool EnterKeyActionDown
		{
			get
			{
				bool result;
				if (this.o.O_o. == BooleanEnum.Default)
				{
					result = this.DataTable.EnterKeyActionDown;
				}
				else
				{
					result = (this.o.O_o. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.o.O_o. = BooleanEnum.True;
				}
				else
				{
					this.o.O_o. = BooleanEnum.False;
				}
				if (this.EnterKeyActionDown)
				{
					this.O_o0OOo_.o0..KeyActionEnter = KeyActionEnum.MoveDown;
					return;
				}
				this.O_o0OOo_.o0..KeyActionEnter = KeyActionEnum.MoveAcross;
			}
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00138F19 File Offset: 0x00137119
		internal void <<EMPTY_NAME>>()
		{
			this.oo_._0oo_o_0. = BooleanEnum.Default;
		}

		/// <summary>
		/// 按Tab键是否向下移动焦点单元格
		/// </summary>
		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x00138F24 File Offset: 0x00137124
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x00138F57 File Offset: 0x00137157
		[oO0oooo("0473")]
		public bool TabKeyActionDown
		{
			get
			{
				bool result;
				if (this.oo_._0oo_o_0. == BooleanEnum.Default)
				{
					result = this.DataTable.TabKeyActionDown;
				}
				else
				{
					result = (this.oo_._0oo_o_0. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.oo_._0oo_o_0. = BooleanEnum.True;
				}
				else
				{
					this.oo_._0oo_o_0. = BooleanEnum.False;
				}
				if (this.TabKeyActionDown)
				{
					this.O_o0OOo_.o0..KeyActionTab = KeyActionEnum.MoveDown;
					return;
				}
				this.O_o0OOo_.o0..KeyActionTab = KeyActionEnum.MoveAcross;
			}
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00138F8D File Offset: 0x0013718D
		internal void <<EMPTY_NAME>>()
		{
			this.Oo_o._oO0o. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许通过拖动列标题来调整列位置
		/// </summary>
		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x00138F98 File Offset: 0x00137198
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x00138FCB File Offset: 0x001371CB
		[oO0oooo("0468")]
		public bool AllowDragColumn
		{
			get
			{
				bool result;
				if (this.Oo_o._oO0o. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowDragColumn;
				}
				else
				{
					result = (this.Oo_o._oO0o. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.Oo_o._oO0o. = BooleanEnum.True;
				}
				else
				{
					this.Oo_o._oO0o. = BooleanEnum.False;
				}
				this.Ooo0ooOOo.o.();
			}
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00138FE6 File Offset: 0x001371E6
		internal void <<EMPTY_NAME>>()
		{
			this.o_oo.o_. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许通过鼠标拖动来调整冻结区。
		/// </summary>
		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x00138FF0 File Offset: 0x001371F0
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00139023 File Offset: 0x00137223
		[oO0oooo("0469")]
		public bool AllowFreezeColumn
		{
			get
			{
				bool result;
				if (this.o_oo.o_. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowFreezeColumn;
				}
				else
				{
					result = (this.o_oo.o_. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.o_oo.o_. = BooleanEnum.True;
				}
				else
				{
					this.o_oo.o_. = BooleanEnum.False;
				}
				this.Ooo0ooOOo.o.();
			}
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x0013903E File Offset: 0x0013723E
		internal void <<EMPTY_NAME>>()
		{
			this.O0O_o0.O_Oo0O0. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许通过鼠标拖动来调整列宽
		/// </summary>
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x00139048 File Offset: 0x00137248
		// (set) Token: 0x06002BAE RID: 11182 RVA: 0x0013907B File Offset: 0x0013727B
		[oO0oooo("0470")]
		public bool AllowResizeColumn
		{
			get
			{
				bool result;
				if (this.O0O_o0.O_Oo0O0. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowResizeColumn;
				}
				else
				{
					result = (this.O0O_o0.O_Oo0O0. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.O0O_o0.O_Oo0O0. = BooleanEnum.True;
				}
				else
				{
					this.O0O_o0.O_Oo0O0. = BooleanEnum.False;
				}
				this.Ooo0ooOOo.o.();
			}
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00139096 File Offset: 0x00137296
		internal void <<EMPTY_NAME>>()
		{
			this.Oo_.o0__0. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许通过鼠标拖动来调整行高
		/// </summary>
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x001390A0 File Offset: 0x001372A0
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x001390D3 File Offset: 0x001372D3
		[oO0oooo("1370")]
		public bool AllowResizeRow
		{
			get
			{
				bool result;
				if (this.Oo_.o0__0. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowResizeRow;
				}
				else
				{
					result = (this.Oo_.o0__0. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.Oo_.o0__0. = BooleanEnum.True;
				}
				else
				{
					this.Oo_.o0__0. = BooleanEnum.False;
				}
				this.Ooo0ooOOo.o.();
			}
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x001390EE File Offset: 0x001372EE
		internal void <<EMPTY_NAME>>()
		{
			this.oO.O0OOO___. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许编辑数据
		/// </summary>
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002BB3 RID: 11187 RVA: 0x001390F8 File Offset: 0x001372F8
		// (set) Token: 0x06002BB4 RID: 11188 RVA: 0x0013913C File Offset: 0x0013733C
		[oO0oooo("0462")]
		public bool AllowEdit
		{
			get
			{
				bool result;
				if (!OO_00oOO.DataTables.AllowEdit)
				{
					result = false;
				}
				else if (this.oO.O0OOO___. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowEdit;
				}
				else
				{
					result = (this.oO.O0OOO___. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.oO.O0OOO___. = BooleanEnum.True;
				}
				else
				{
					this.oO.O0OOO___. = BooleanEnum.False;
				}
				O_O0OO.OoO_o.oO0o0O.(this.DataTable.o_0_00_.oo0O0., "TableAllowEditChanged", new object[0], true, this.DataTable.Name, false);
				this.foxGrid.Rows[0].Invalidate();
				Main.OO_O.o..O.ooO0. = true;
			}
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x001391A6 File Offset: 0x001373A6
		internal void <<EMPTY_NAME>>(bool A_0)
		{
			this.O._0_0ooO0_o0o. = BooleanEnum.Default;
			this.Grid.PreserveEditMode = this.PreserveEditMode;
		}

		/// <summary>
		/// 是否保持编辑模式
		/// </summary>
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x001391C0 File Offset: 0x001373C0
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x001391F3 File Offset: 0x001373F3
		[oO0oooo("3278")]
		public bool PreserveEditMode
		{
			get
			{
				bool result;
				if (this.O._0_0ooO0_o0o. == BooleanEnum.Default)
				{
					result = this.DataTable.PreserveEditMode;
				}
				else
				{
					result = (this.O._0_0ooO0_o0o. == BooleanEnum.True);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.O._0_0ooO0_o0o. = BooleanEnum.True;
				}
				else
				{
					this.O._0_0ooO0_o0o. = BooleanEnum.False;
				}
				this.Grid.PreserveEditMode = value;
			}
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00139214 File Offset: 0x00137414
		internal void <<EMPTY_NAME>>()
		{
			this.Oo_00o0_.o00. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许增加行
		/// </summary>
		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x00139220 File Offset: 0x00137420
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x00139255 File Offset: 0x00137455
		[oO0oooo("0463")]
		public bool AllowAddNew
		{
			get
			{
				DataTable dataTable = this.DataTable;
				bool result;
				if (this.Oo_00o0_.o00. == BooleanEnum.Default)
				{
					result = dataTable.AllowAddNew;
				}
				else
				{
					result = (this.Oo_00o0_.o00. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.Oo_00o0_.o00. = BooleanEnum.True;
					return;
				}
				this.Oo_00o0_.o00. = BooleanEnum.False;
			}
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x00139269 File Offset: 0x00137469
		internal void <<EMPTY_NAME>>()
		{
			this.o.OO0O0O. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许自动增加行
		/// </summary>
		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x00139274 File Offset: 0x00137474
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x001392A9 File Offset: 0x001374A9
		[oO0oooo("0464")]
		public bool AutoAddNew
		{
			get
			{
				DataTable dataTable = this.DataTable;
				bool result;
				if (this.o.OO0O0O. == BooleanEnum.Default)
				{
					result = dataTable.AutoAddNew;
				}
				else
				{
					result = (this.o.OO0O0O. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.o.OO0O0O. = BooleanEnum.True;
					return;
				}
				this.o.OO0O0O. = BooleanEnum.False;
			}
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x001392BD File Offset: 0x001374BD
		internal void <<EMPTY_NAME>>()
		{
			this.o_oo___0.0. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许删除行
		/// </summary>
		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x001392C8 File Offset: 0x001374C8
		// (set) Token: 0x06002BC0 RID: 11200 RVA: 0x001392FD File Offset: 0x001374FD
		[oO0oooo("0465")]
		public bool AllowDelete
		{
			get
			{
				DataTable dataTable = this.DataTable;
				bool result;
				if (this.o_oo___0.0. == BooleanEnum.Default)
				{
					result = dataTable.AllowDelete;
				}
				else
				{
					result = (this.o_oo___0.0. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.o_oo___0.0. = BooleanEnum.True;
					return;
				}
				this.o_oo___0.0. = BooleanEnum.False;
			}
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x00139311 File Offset: 0x00137511
		internal void <<EMPTY_NAME>>()
		{
			this.O_0_O0Oo__.O_o. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许锁定行
		/// </summary>
		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x0013931C File Offset: 0x0013751C
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x0013934F File Offset: 0x0013754F
		[oO0oooo("0466")]
		public bool AllowLockRow
		{
			get
			{
				bool result;
				if (this.O_0_O0Oo__.O_o. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowLockRow;
				}
				else
				{
					result = (this.O_0_O0Oo__.O_o. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.O_0_O0Oo__.O_o. = BooleanEnum.True;
					return;
				}
				this.O_0_O0Oo__.O_o. = BooleanEnum.False;
			}
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00139363 File Offset: 0x00137563
		internal void <<EMPTY_NAME>>()
		{
			this.OOo0O._0__0. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许解锁行
		/// </summary>
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x0013936C File Offset: 0x0013756C
		// (set) Token: 0x06002BC6 RID: 11206 RVA: 0x0013939F File Offset: 0x0013759F
		[oO0oooo("0467")]
		public bool AllowUnLockRow
		{
			get
			{
				bool result;
				if (this.OOo0O._0__0. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowUnlockRow;
				}
				else
				{
					result = (this.OOo0O._0__0. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.OOo0O._0__0. = BooleanEnum.True;
					return;
				}
				this.OOo0O._0__0. = BooleanEnum.False;
			}
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x001393B3 File Offset: 0x001375B3
		internal void <<EMPTY_NAME>>()
		{
			this.ooo0.O_. = BooleanEnum.Default;
		}

		/// <summary>
		/// 是否允许分别调整每一行的高度
		/// </summary>
		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x001393BC File Offset: 0x001375BC
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x001393EF File Offset: 0x001375EF
		[oO0oooo("0471")]
		public bool AllowResizeSingleRow
		{
			get
			{
				bool result;
				if (this.ooo0.O_. == BooleanEnum.Default)
				{
					result = this.DataTable.AllowResizeSingleRow;
				}
				else
				{
					result = (this.ooo0.O_. != BooleanEnum.False);
				}
				return result;
			}
			set
			{
				if (value)
				{
					this.ooo0.O_. = BooleanEnum.True;
					return;
				}
				this.ooo0.O_. = BooleanEnum.False;
			}
		}

		/// <summary>
		/// 将输入焦点移到Table中
		/// </summary>
		// Token: 0x06002BCA RID: 11210 RVA: 0x00139403 File Offset: 0x00137603
		[oO0oooo("0549")]
		public bool Focus()
		{
			return this.foxGrid.Focus();
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00139410 File Offset: 0x00137610
		[EditorBrowsable(EditorBrowsableState.Never)]
		[oO0oooo("0550")]
		public bool Select()
		{
			return this.Focus();
		}

		/// <summary>
		/// Table是否获得了输入焦点
		/// </summary>
		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x00139418 File Offset: 0x00137618
		[oO0oooo("0458")]
		public bool Focused
		{
			get
			{
				return this.foxGrid.Focused;
			}
		}

		/// <summary>
		/// 打印设置
		/// </summary>
		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00139425 File Offset: 0x00137625
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x0013942D File Offset: 0x0013762D
		public PrintInfo PrintInfo
		{
			get
			{
				return this.oO._0ooO_o0_.;
			}
			internal set
			{
				this.oO._0ooO_o0_. = value;
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00139438 File Offset: 0x00137638
		private void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.o.OOoo_o., "", true) > 0)
			{
				this.PrintInfo.PaperSize = this.PrintInfo.PaperSize;
				o_O_o_oOoo__.OOOO_OO._oo.(this.PrintInfo, this.o.OOoo_o., '\n');
				this.o.OOoo_o. = "";
			}
		}

		/// <summary>
		/// 打印
		/// </summary>
		/// <param name="Preview">是否打印预览</param>
		/// <param name="ShowDialog">是否出现打印设置窗口</param>
		// Token: 0x06002BD0 RID: 11216 RVA: 0x00139490 File Offset: 0x00137690
		[oO0oooo("0554")]
		public void Print(bool Preview, bool ShowDialog)
		{
			this.o.O0___OOo0_oO.();
			if (this.View.Count >= 1)
			{
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
				catch (Exception ex)
				{
					return;
				}
				if (Preview)
				{
					new o_00OOooo__0_(this.PrintInfo, false).ooo.0_oO_0.();
					return;
				}
				PrinterSettings printerSettings = (PrinterSettings)this.foxGrid.PrintParameters.PrintDocument.PrinterSettings.Clone();
				if (Operators.CompareString(this.PrintInfo.PrinterName, "", true) > 0)
				{
					printerSettings.PrinterName = this.PrintInfo.PrinterName;
				}
				if (!ShowDialog || new PrintDialog
				{
					PrinterSettings = printerSettings
				}.ShowDialog() != DialogResult.Cancel)
				{
					new o_00OOooo__0_(this.PrintInfo, false).O0o.__.(printerSettings);
				}
			}
		}

		/// <summary>
		/// 直接打印
		/// </summary>
		/// <param name="Preview">是否打印预览</param>
		/// <param name="ShowDialog">是否出现打印设置窗口</param>
		// Token: 0x06002BD1 RID: 11217 RVA: 0x00139584 File Offset: 0x00137784
		[oO0oooo("0555")]
		public void DirectPrint(bool Preview, bool ShowDialog)
		{
			if (!this.O_O0oo_.OO.)
			{
				this.O_O0oo_.OO. = true;
				this.foxGrid.o.O_0o.();
				try
				{
					try
					{
						if (PrinterSettings.InstalledPrinters.Count == 0)
						{
							MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							this.O_O0oo_.OO. = false;
							return;
						}
					}
					catch (Exception ex)
					{
						this.O_O0oo_.OO. = false;
						return;
					}
				}
				catch (Exception ex2)
				{
					this.O_O0oo_.OO. = false;
					return;
				}
				PrintGridFlags printGridFlags;
				if (ShowDialog)
				{
					printGridFlags |= PrintGridFlags.ShowPrintDialog;
				}
				if (this.PrintInfo.DirectFitIntoPage)
				{
					printGridFlags |= PrintGridFlags.FitToPageWidth;
				}
				if (this.PrintInfo.DirectFitIntoOnePage)
				{
					printGridFlags |= PrintGridFlags.FitToPage;
				}
				if (this.PrintInfo.DirectExtendLastCol)
				{
					printGridFlags |= PrintGridFlags.ExtendLastCol;
				}
				if (this.PrintInfo.DirectHighLight)
				{
					printGridFlags |= PrintGridFlags.ShowHighlight;
				}
				this.foxGrid.PrintParameters.HeaderFont = this.PrintInfo.DirectPageHeaderFont;
				this.foxGrid.PrintParameters.FooterFont = this.PrintInfo.DirectPageHeaderFont;
				this.foxGrid.PrintParameters.Header = this.o.oO__OO_oo_0_.(this.PrintInfo.DirectPageHeader);
				this.foxGrid.PrintParameters.Footer = this.o.oO__OO_oo_0_.(this.PrintInfo.DirectPageFooter);
				this.foxGrid.PrintParameters.PrintGridFlags = printGridFlags;
				CellRange selection = this.foxGrid.Selection;
				try
				{
					if (!this.PrintInfo.DirectHighLight)
					{
						OO_00oOO.SystemReady = false;
						this.foxGrid.Select(-1, -1);
						OO_00oOO.SystemReady = true;
					}
					if (!Preview)
					{
						this.foxGrid.PrintGrid(this.Name);
					}
					else
					{
						C1PrintPreviewDialog c1PrintPreviewDialog = new C1PrintPreviewDialog();
						try
						{
							this.O.OoOo_. = 0;
							this.foxGrid.PrintParameters.PrintDocument.PrintPage += this.Oo_oOo_.O0_.;
							this.O.OoOo_. = new o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000();
							this.O.OoOo_..Show();
							Application.DoEvents();
							c1PrintPreviewDialog.PreviewPane.ZoomMode = ZoomModeEnum.ActualSize;
							c1PrintPreviewDialog.ShowInTaskbar = false;
							c1PrintPreviewDialog.Text = "打印预览";
							c1PrintPreviewDialog.Icon = Foxtable.My.Resources.a.O_.o_0oo_000_.();
							c1PrintPreviewDialog.WindowState = FormWindowState.Maximized;
							c1PrintPreviewDialog.Document = this.foxGrid.PrintParameters.PrintDocument;
							this.O.OoOo_..Close();
							if (this.O.OoOo_..Ooo_oo._o.())
							{
								return;
							}
							c1PrintPreviewDialog.ShowDialog();
						}
						catch (Exception a_)
						{
							ooO.oOo0Oo.o.(a_, "");
						}
						finally
						{
							c1PrintPreviewDialog.Dispose();
							this.foxGrid.PrintParameters.PrintDocument.Dispose();
							GC.Collect();
							this.O.OoOo_..Close();
							this.O.OoOo_..Dispose();
							this.O.OoOo_. = null;
							this.foxGrid.PrintParameters.PrintDocument.PrintPage -= this.Oo_oOo_.O0_.;
						}
					}
					if (!this.PrintInfo.DirectHighLight)
					{
						OO_00oOO.SystemReady = false;
						this.foxGrid.Select(selection.r1, selection.c1, selection.r2, selection.c2);
						OO_00oOO.SystemReady = true;
					}
				}
				catch (Exception a_2)
				{
					ooO.oOo0Oo.o.(a_2, "");
				}
				finally
				{
					this.O_O0oo_.OO. = false;
					OO_00oOO.SystemReady = true;
				}
			}
		}

		/// <summary>
		/// 打开视图
		/// </summary>
		/// <param name="ViewName">视图名称</param>
		// Token: 0x06002BD2 RID: 11218 RVA: 0x00139968 File Offset: 0x00137B68
		[oO0oooo("1269")]
		public void OpenView(string ViewName)
		{
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.Oo0o0.oo_0.()].Rows.Find(new object[]
			{
				this.DataTable.Name,
				ViewName,
				ExtendTablePropertyTypeEnum.View
			});
			if (dataRow != null)
			{
				TableViewProperty tableViewProperty = new TableViewProperty(this);
				o_O_o_oOoo__.OOOO_OO._oo.(tableViewProperty, Conversions.ToString(dataRow["Property"]), '\v');
				try
				{
					OO_00oOO.LockBaseMainForm();
					this.StopRedraw();
					tableViewProperty.Restore();
				}
				catch (Exception ex)
				{
				}
				finally
				{
					this.ResumeRedraw();
					OO_00oOO.UnlockBaseMainForm();
				}
			}
		}

		/// <summary>
		/// 重新绘制所有单元格
		/// </summary>
		// Token: 0x06002BD3 RID: 11219 RVA: 0x00139A20 File Offset: 0x00137C20
		public void Refresh()
		{
			this.foxGrid.Invalidate();
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00139A30 File Offset: 0x00137C30
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void RefreshChildTables()
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.Name.StartsWith(this.Name + "."))
					{
						table.Refresh();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x00139A98 File Offset: 0x00137C98
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SaveExcel(params object[] args)
		{
			if (args.Length == 3)
			{
				string fileName = Conversions.ToString(args[0]);
				string sheetName = Conversions.ToString(args[1]);
				if (args[2] is bool)
				{
					this.SaveExcel(fileName, sheetName, Conversions.ToBoolean(args[2]));
					return;
				}
				if (args[2] is int)
				{
					this.SaveExcel(fileName, sheetName, (SaveExcelFlags)args[2]);
				}
			}
		}

		/// <summary>
		/// 保存为Excel文件
		/// </summary>
		/// <param name="FileName">文件名</param>
		/// <param name="SheetName">工作表名</param>
		/// <param name="SelectedRowsOnly">是否只保存选定行</param>
		// Token: 0x06002BD6 RID: 11222 RVA: 0x00139AF4 File Offset: 0x00137CF4
		[oO0oooo("0559")]
		public void SaveExcel(string FileName, string SheetName, bool SelectedRowsOnly)
		{
			this.SaveExcel(FileName, SheetName, new SaveExcelFlags
			{
				SelectedOnly = SelectedRowsOnly,
				MergedRanges = true
			});
		}

		/// <summary>
		/// 为Excel表自动生成表头，包括多层表头
		/// </summary>
		/// <param name="XLSSheet">Excel的工作表</param>
		/// <param name="StartRow">表头在工作表中的起始行</param>
		/// <param name="StartCol">表头在工作表中的起始列</param>
		/// <param name="VisibleOnly">是否只包括可见区列</param>
		// Token: 0x06002BD7 RID: 11223 RVA: 0x00139B20 File Offset: 0x00137D20
		[oO0oooo("1971")]
		public void CreateSheetHeader(Sheet XLSSheet, int StartRow = 0, int StartCol = 0, bool VisibleOnly = true)
		{
			int num;
			int num8;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				XLSheet ooo_O__.0. = XLSSheet.Ooo_O__.0.;
				IL_10:
				num2 = 3;
				IL_12:
				num2 = 4;
				IL_14:
				num2 = 5;
				int num3 = this.foxGrid.Cols.Count - 1;
				int num4;
				for (int i = 1; i <= num3; i++)
				{
					IL_32:
					num2 = 6;
					if (this.foxGrid.Cols[i].Visible || !VisibleOnly)
					{
						IL_54:
						num2 = 7;
						if (this.foxGrid.Cols[i].Visible)
						{
							IL_6F:
							num2 = 8;
							ooo_O__.0..Columns[StartCol + num4].Width = C1XLBook.PixelsToTwips((double)this.foxGrid.Cols[i].WidthDisplay);
						}
						else
						{
							IL_A4:
							num2 = 10;
							ooo_O__.0..Columns[StartCol + num4].Width = C1XLBook.PixelsToTwips((double)this.foxGrid.Cols[i].Width);
						}
						IL_D8:
						num2 = 11;
						int num5 = this.foxGrid.Rows.Fixed - 1;
						for (int j = 0; j <= num5; j++)
						{
							IL_F4:
							num2 = 12;
							ooo_O__.0.[StartRow + j, StartCol + num4].Value = this.foxGrid.GetDataDisplay(j, i);
							IL_119:
							num2 = 13;
						}
						IL_128:
						num2 = 14;
						num4++;
					}
					IL_131:
					num2 = 15;
				}
				IL_143:
				num2 = 16;
				XLStyle xlstyle = new XLStyle(ooo_O__.0..Book);
				IL_153:
				num2 = 17;
				xlstyle.AlignHorz = XLAlignHorzEnum.Center;
				IL_15E:
				num2 = 18;
				xlstyle.AlignVert = XLAlignVertEnum.Center;
				IL_169:
				num2 = 19;
				xlstyle.WordWrap = true;
				IL_174:
				num2 = 20;
				int num6 = StartRow + this.foxGrid.Rows.Fixed - 1;
				for (int k = StartRow; k <= num6; k++)
				{
					IL_192:
					num2 = 21;
					ooo_O__.0..Rows[k].Style = xlstyle;
					IL_1A9:
					num2 = 22;
				}
				IL_1B8:
				num2 = 23;
				this.O0o.00oOo0O.(ooo_O__.0., StartRow, StartRow + this.foxGrid.Rows.Fixed - 1, StartCol, StartCol + num4 - 1);
				IL_1DE:
				goto IL_290;
				IL_1E3:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_251:
				goto IL_285;
				IL_253:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_263:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_253;
			}
			IL_285:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_290:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 返回表头的层数
		/// </summary>
		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x00139DE4 File Offset: 0x00137FE4
		public int HeaderRows
		{
			get
			{
				return this.foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 为RenderTable自动生成多层表头
		/// </summary>
		/// <param name="RenderTable">RenderTable</param>
		/// <param name="VisibleOnly">是否只包括可见列</param>
		// Token: 0x06002BD9 RID: 11225 RVA: 0x00139DF8 File Offset: 0x00137FF8
		[oO0oooo("1973")]
		public void CreateReportHeader(RenderTable RenderTable, bool VisibleOnly = true)
		{
			int num;
			int num29;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				RenderTable.Rows.Clear();
				IL_14:
				num2 = 3;
				RenderTable.Cols.Clear();
				IL_21:
				num2 = 4;
				int num3 = this.foxGrid.Cols.Count - 1;
				int num4;
				for (int i = 1; i <= num3; i++)
				{
					IL_3F:
					num2 = 5;
					if (this.foxGrid.Cols[i].Visible || !VisibleOnly)
					{
						IL_60:
						num2 = 6;
						RenderTable.Cols[num4].Width = this.Cols[this.foxGrid.Cols[i].Name].PrintWidth;
						IL_9F:
						num2 = 7;
						int num5 = this.foxGrid.Rows.Fixed - 1;
						for (int j = 0; j <= num5; j++)
						{
							IL_BA:
							num2 = 8;
							RenderTable.Cells[j, num4].Text = this.foxGrid.GetDataDisplay(j, i);
							IL_DE:
							num2 = 9;
						}
						IL_ED:
						num2 = 10;
						num4++;
					}
					IL_F4:
					num2 = 11;
				}
				IL_106:
				num2 = 12;
				int num6 = num4 - 1;
				for (int k = 0; k <= num6; k++)
				{
					IL_116:
					num2 = 13;
					int num7 = this.foxGrid.Rows.Count - 1;
					for (int l = 0; l <= num7; l++)
					{
						IL_135:
						num2 = 14;
						int num8 = l;
						IL_13C:
						num2 = 15;
						int num9 = k;
						IL_143:
						num2 = 16;
						int num10 = l;
						IL_14A:
						num2 = 17;
						int num11 = k;
						IL_151:
						num2 = 18;
						string text = RenderTable.Cells[l, k].Text;
						IL_16A:
						num2 = 19;
						if (Operators.CompareString(text, "", true) != 0)
						{
							IL_17F:
							num2 = 21;
							for (int m = l - 1; m >= 0; m += -1)
							{
								IL_18A:
								num2 = 22;
								if (Operators.CompareString(RenderTable.Cells[m, k].Text, text, true) != 0)
								{
									break;
								}
								IL_1AB:
								num2 = 23;
								num8 = m;
								IL_1B2:
								num2 = 26;
							}
							IL_1C0:
							num2 = 27;
							int num12 = l + 1;
							int num13 = this.foxGrid.Rows.Count - 1;
							for (int n = num12; n <= num13; n++)
							{
								IL_1DF:
								num2 = 28;
								if (Operators.CompareString(RenderTable.Cells[n, k].Text, text, true) != 0)
								{
									break;
								}
								IL_200:
								num2 = 29;
								num10 = n;
								IL_207:
								num2 = 32;
							}
							IL_216:
							num2 = 33;
							bool flag = false;
							IL_21C:
							num2 = 34;
							for (int num14 = k - 1; num14 >= 0; num14 += -1)
							{
								IL_227:
								num2 = 35;
								flag = false;
								IL_22D:
								num2 = 36;
								int num15 = num8;
								int num16 = num10;
								for (int num17 = num15; num17 <= num16; num17++)
								{
									IL_23A:
									num2 = 37;
									if (Operators.CompareString(RenderTable.Cells[num17, num14].Text, text, true) != 0)
									{
										IL_25B:
										num2 = 38;
										flag = false;
										break;
									}
									IL_263:
									num2 = 40;
								}
								IL_272:
								num2 = 41;
								if (!flag)
								{
									break;
								}
								IL_279:
								num2 = 42;
								num9 = num14;
								IL_280:
								num2 = 45;
							}
							IL_28E:
							num2 = 46;
							int num18 = k + 1;
							int num19 = num4 - 1;
							for (int num20 = num18; num20 <= num19; num20++)
							{
								IL_29E:
								num2 = 47;
								flag = true;
								IL_2A4:
								num2 = 48;
								int num21 = num8;
								int num22 = num10;
								for (int num23 = num21; num23 <= num22; num23++)
								{
									IL_2B1:
									num2 = 49;
									if (Operators.CompareString(RenderTable.Cells[num23, num20].Text, text, true) != 0)
									{
										IL_2D2:
										num2 = 50;
										flag = false;
										break;
									}
									IL_2DA:
									num2 = 52;
								}
								IL_2E9:
								num2 = 53;
								if (!flag)
								{
									break;
								}
								IL_2F0:
								num2 = 54;
								num11 = num20;
								IL_2F7:
								num2 = 57;
							}
							IL_306:
							num2 = 58;
							if (num8 != num10 || num9 != num11)
							{
								IL_315:
								num2 = 59;
								if (num8 == l && num9 == k)
								{
									IL_324:
									num2 = 60;
									RenderTable.Cells[l, k].SpanRows = num10 - num8 + 1;
									IL_342:
									num2 = 61;
									RenderTable.Cells[l, k].SpanCols = num11 - num9 + 1;
								}
							}
						}
						IL_360:
						num2 = 62;
					}
					IL_372:
					num2 = 63;
				}
				IL_384:
				num2 = 64;
				int num24 = this.foxGrid.Rows.Fixed - 1;
				for (int num25 = 0; num25 <= num24; num25++)
				{
					IL_3A0:
					num2 = 65;
					int num26 = num4 - 1;
					for (int num27 = 0; num27 <= num26; num27++)
					{
						IL_3AD:
						num2 = 66;
						RenderTable.Cells[num25, num27].Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center;
						IL_3CA:
						num2 = 67;
						RenderTable.Cells[num25, num27].Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center;
						IL_3E7:
						num2 = 68;
					}
					IL_3F6:
					num2 = 69;
				}
				IL_405:
				goto IL_56F;
				IL_40A:
				int num28 = num29 + 1;
				num29 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num28);
				IL_530:
				goto IL_564;
				IL_532:
				num29 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_542:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num29 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_532;
			}
			IL_564:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_56F:
			if (num29 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 保存为Excel文件
		/// </summary>
		/// <param name="FileName">文件名</param>
		/// <param name="SheetName">工作表名</param>
		/// <param name="Flags">SaveExcelFlags类型，用于设置保存选项</param>
		// Token: 0x06002BDA RID: 11226 RVA: 0x0013A398 File Offset: 0x00138598
		[oO0oooo("0559")]
		public void SaveExcel(string FileName, string SheetName, SaveExcelFlags Flags = null)
		{
			int num;
			int num8;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				C1XLBook c1XLBook = new C1XLBook();
				IL_0F:
				num2 = 3;
				if (!OO_00oOO.FileSys.FileExists(FileName))
				{
					goto IL_86;
				}
				IL_1E:
				num2 = 4;
				c1XLBook.Load(FileName);
				IL_27:
				num2 = 5;
				if (!c1XLBook.Sheets.Contains(SheetName))
				{
					goto IL_74;
				}
				IL_37:
				num2 = 6;
				XLSheet xlsheet = c1XLBook.Sheets[SheetName];
				IL_47:
				num2 = 7;
				xlsheet.Rows.Clear();
				IL_55:
				num2 = 8;
				xlsheet.Columns.Clear();
				IL_63:
				num2 = 9;
				xlsheet.MergedCells.Clear();
				goto IL_97;
				IL_74:
				num2 = 11;
				xlsheet = c1XLBook.Sheets.Add();
				goto IL_97;
				IL_86:
				num2 = 13;
				xlsheet = c1XLBook.Sheets[0];
				IL_97:
				num2 = 14;
				xlsheet.Name = SheetName;
				IL_A2:
				num2 = 15;
				xlsheet.PrintSettings.PrintGridlines = true;
				IL_B2:
				num2 = 16;
				if (Flags != null)
				{
					goto IL_C2;
				}
				IL_B8:
				num2 = 17;
				Flags = new SaveExcelFlags();
				IL_C2:
				num2 = 18;
				if (!FileName.EndsWith(".xlsx", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_DD;
				}
				IL_D3:
				num2 = 19;
				c1XLBook.CompatibilityMode = CompatibilityMode.Excel2007;
				IL_DD:
				num2 = 20;
				c1XLBook.DefaultFont = this.foxGrid.Font;
				IL_F1:
				num2 = 21;
				Bitmap bitmap = null;
				IL_F7:
				num2 = 22;
				bitmap = new Bitmap(400, 100);
				IL_108:
				num2 = 23;
				Graphics graphics = Graphics.FromImage(bitmap);
				IL_114:
				num2 = 24;
				int num3 = this.foxGrid.Rows.Count - 1;
				int num4;
				for (int i = 0; i <= num3; i++)
				{
					IL_133:
					num2 = 25;
					xlsheet.Rows[i].Height = C1XLBook.PixelsToTwips((double)this.foxGrid.Rows[i].HeightDisplay);
					IL_166:
					num2 = 26;
					num4 = 0;
					IL_16C:
					num2 = 27;
					if (Flags.RowNumber)
					{
						IL_17A:
						num2 = 28;
						if (i == 0)
						{
							IL_181:
							num2 = 29;
							xlsheet.Columns[0].Width = C1XLBook.PixelsToTwips((double)this.foxGrid.Cols[0].WidthDisplay);
							IL_1B2:
							num2 = 30;
							XLStyle xlstyle = new XLStyle(c1XLBook);
							IL_1BD:
							num2 = 31;
							xlstyle.AlignVert = XLAlignVertEnum.Center;
							IL_1C8:
							num2 = 32;
							xlstyle.AlignHorz = XLAlignHorzEnum.Center;
							IL_1D3:
							num2 = 33;
							xlsheet.Columns[0].Style = xlstyle;
						}
						else
						{
							IL_1EC:
							num2 = 35;
							if (this.foxGrid.Rows[i].DataIndex >= 0)
							{
								IL_209:
								num2 = 36;
								xlsheet[i, 0].Value = this.foxGrid.Rows[i].DataIndex + 1;
							}
						}
						IL_239:
						num2 = 37;
						num4 = 1;
					}
					IL_23F:
					num2 = 38;
					if (i < this.foxGrid.Rows.Fixed)
					{
						IL_256:
						num2 = 39;
						XLStyle xlstyle2 = new XLStyle(c1XLBook);
						IL_261:
						num2 = 40;
						xlstyle2.AlignHorz = XLAlignHorzEnum.Center;
						IL_26C:
						num2 = 41;
						xlstyle2.AlignVert = XLAlignVertEnum.Center;
						IL_277:
						num2 = 42;
						xlstyle2.WordWrap = true;
						IL_282:
						num2 = 43;
						xlsheet.Rows[i].Style = xlstyle2;
					}
					IL_29A:
					num2 = 44;
					if (this.foxGrid.Rows[i].IsNode)
					{
						IL_2B6:
						num2 = 45;
						XLStyle xlstyle3 = new XLStyle(c1XLBook);
						IL_2C1:
						num2 = 46;
						xlstyle3.BackColor = this.foxGrid.GetCellStyleDisplay(i, 1).BackColor;
						IL_2DE:
						num2 = 47;
						xlsheet.Rows[i].Style = xlstyle3;
					}
					IL_2F6:
					num2 = 48;
					int num5 = this.foxGrid.Cols.Count - 1;
					for (int j = 1; j <= num5; j++)
					{
						IL_315:
						num2 = 49;
						if (this.foxGrid.Cols[j].Visible || !Flags.VisibleOnly)
						{
							IL_33C:
							num2 = 50;
							if (i == 0)
							{
								IL_346:
								num2 = 51;
								if (this.foxGrid.Cols[j].Visible)
								{
									IL_362:
									num2 = 52;
									xlsheet.Columns[num4].Width = C1XLBook.PixelsToTwips((double)this.foxGrid.Cols[j].WidthDisplay);
								}
								else
								{
									IL_397:
									num2 = 54;
									if (this.foxGrid.Cols[j].Width > 0)
									{
										IL_3B4:
										num2 = 55;
										xlsheet.Columns[num4].Width = C1XLBook.PixelsToTwips((double)this.foxGrid.Cols[j].Width);
									}
									else
									{
										IL_3E9:
										num2 = 57;
										xlsheet.Columns[num4].Width = C1XLBook.PixelsToTwips((double)this.foxGrid.Cols.DefaultSize);
									}
								}
								IL_415:
								num2 = 58;
								XLStyle xlstyle4 = new XLStyle(c1XLBook);
								IL_420:
								num2 = 59;
								if (this.foxGrid.Cols[j].DataType == typeof(DateTime))
								{
									IL_446:
									num2 = 60;
									xlstyle4.Format = XLStyle.FormatDotNetToXL(this.foxGrid.Cols[j].Format);
								}
								else
								{
									IL_471:
									num2 = 62;
									string name = this.foxGrid.Cols[j].Name;
									IL_48D:
									num2 = 63;
									if (this.Cols[name].IsNumeric())
									{
										IL_4A7:
										num2 = 64;
										if (this.DataTable.DataCols[name].FixedDecimals)
										{
											IL_4C6:
											num2 = 65;
											if (this.DataTable.DataCols[name].PercentStyle)
											{
												IL_4E2:
												num2 = 66;
												if (this.DataTable.DataCols[name].Decimals >= 2)
												{
													IL_4FF:
													num2 = 67;
													xlstyle4.Format = "0." + new string('0', this.DataTable.DataCols[name].Decimals - 2);
												}
												else
												{
													IL_535:
													num2 = 69;
													xlstyle4.Format = "0";
												}
											}
											else
											{
												IL_546:
												num2 = 71;
												xlstyle4.Format = "0." + new string('0', this.DataTable.DataCols[name].Decimals);
											}
											IL_578:
											num2 = 72;
											if (this.DataTable.DataCols[name].PercentStyle)
											{
												IL_594:
												num2 = 73;
												xlstyle4.Format += "%";
											}
										}
										else
										{
											IL_5B1:
											num2 = 75;
											if (this.DataTable.DataCols[name].PercentStyle)
											{
												IL_5CD:
												num2 = 76;
												xlstyle4.Format = "0.00%";
											}
										}
									}
								}
								IL_5DC:
								num2 = 77;
								TextAlignEnum textAlign = this.foxGrid.Cols[j].TextAlign;
								if (textAlign != TextAlignEnum.LeftCenter)
								{
									if (textAlign != TextAlignEnum.CenterCenter)
									{
										if (textAlign == TextAlignEnum.RightCenter)
										{
											IL_623:
											num2 = 83;
											xlstyle4.AlignHorz = XLAlignHorzEnum.Right;
										}
									}
									else
									{
										IL_609:
										num2 = 79;
										xlstyle4.AlignHorz = XLAlignHorzEnum.Center;
									}
								}
								else
								{
									IL_616:
									num2 = 81;
									xlstyle4.AlignHorz = XLAlignHorzEnum.Left;
								}
								IL_62E:
								num2 = 85;
								xlstyle4.AlignVert = XLAlignVertEnum.Center;
								IL_639:
								num2 = 86;
								xlsheet.Columns[num4].Style = xlstyle4;
							}
							IL_651:
							num2 = 87;
							xlsheet[i, num4].Value = RuntimeHelpers.GetObjectValue(this.foxGrid.GetData(i, j));
							IL_678:
							num2 = 88;
							if ((Flags.CellStyle && this.DataTable.OO00.oO_. != null) || this.DataTable.GlobalHandler.DrawCell)
							{
								IL_6A5:
								num2 = 89;
								if (i >= this.foxGrid.Rows.Fixed)
								{
									IL_6BF:
									num2 = 90;
									string text;
									if (xlsheet[i, num4].Value == null)
									{
										IL_6D4:
										num2 = 91;
										text = "";
									}
									else
									{
										IL_6E0:
										num2 = 93;
										text = xlsheet[i, num4].Value.ToString();
									}
									IL_6FA:
									num2 = 94;
									OwnerDrawCellEventArgs ownerDrawCellEventArgs = new OwnerDrawCellEventArgs(null, graphics, i, j, null, new Rectangle(0, 0, bitmap.Width, bitmap.Height), text, null);
									IL_724:
									num2 = 95;
									O_oOooO_O o_o0OOo_.o0. = this.O_o0OOo_.o0.;
									object o_o0OOo_.o0.2 = this.O_o0OOo_.o0.;
									OwnerDrawCellEventArgs a_ = ownerDrawCellEventArgs;
									bool excuteDrawCell = this.oO._0ooO_o0_..ExcuteDrawCell;
									bool a_2 = true;
									bool flag = false;
									o_o0OOo_.o0..OO_.00oO0Oo.(o_o0OOo_.o0.2, a_, excuteDrawCell, a_2, ref flag);
									IL_74B:
									num2 = 96;
									if (Operators.CompareString(ownerDrawCellEventArgs.Text, text, true) != 0)
									{
										IL_75F:
										num2 = 97;
										xlsheet[i, num4].Value = ownerDrawCellEventArgs.Text;
									}
									IL_779:
									num2 = 98;
									if (ownerDrawCellEventArgs.Style != null)
									{
										IL_785:
										num2 = 99;
										XLStyle xlstyle5 = xlsheet.Columns[num4].Style.Clone();
										IL_7A2:
										num2 = 100;
										xlstyle5.BackColor = ownerDrawCellEventArgs.Style.BackColor;
										IL_7B8:
										num2 = 101;
										xlstyle5.ForeColor = ownerDrawCellEventArgs.Style.ForeColor;
										IL_7CE:
										num2 = 102;
										xlsheet[i, num4].Style = xlstyle5;
									}
								}
							}
							IL_7E3:
							num2 = 103;
							if (Flags.MergedRanges && this.AllowMerge && i == this.foxGrid.Rows.Count - 1)
							{
								IL_815:
								num2 = 104;
								if (this.MergeCols.Contains(this.foxGrid.Cols[j].Name))
								{
									IL_83F:
									num2 = 105;
									int @fixed = this.foxGrid.Rows.Fixed;
									int num6 = this.foxGrid.Rows.Count - 1;
									for (int k = @fixed; k <= num6; k++)
									{
										IL_86A:
										num2 = 106;
										CellRange cellRange = this.foxGrid.OO_.00oO0Oo.(k, j, false);
										IL_87F:
										num2 = 107;
										if (cellRange.r1 == k && cellRange.r2 > k)
										{
											IL_898:
											num2 = 108;
											xlsheet.MergedCells.Add(k, num4, cellRange.r2 - cellRange.r1 + 1, 1);
										}
										IL_8BE:
										num2 = 109;
									}
								}
							}
							IL_8CD:
							num2 = 110;
							num4++;
						}
						IL_8D6:
						num2 = 111;
					}
					IL_8E8:
					num2 = 112;
				}
				IL_8FA:
				num2 = 113;
				if (this.foxGrid.Rows.Fixed <= 1)
				{
					goto IL_963;
				}
				IL_910:
				num2 = 114;
				if (!Flags.RowNumber)
				{
					goto IL_940;
				}
				IL_91B:
				num2 = 115;
				this.O0o.00oOo0O.(xlsheet, 0, this.foxGrid.Rows.Fixed - 1, 1, num4 - 1);
				goto IL_963;
				IL_940:
				num2 = 117;
				this.O0o.00oOo0O.(xlsheet, 0, this.foxGrid.Rows.Fixed - 1, 0, num4 - 1);
				IL_963:
				num2 = 118;
				string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
				IL_973:
				num2 = 119;
				if (OO_00oOO.FileSys.DirectoryExists(parentPath))
				{
					goto IL_993;
				}
				IL_984:
				num2 = 120;
				OO_00oOO.FileSys.CreateDirectory(parentPath);
				IL_993:
				num2 = 121;
				if (!FileName.EndsWith(".xlsx", StringComparison.CurrentCultureIgnoreCase))
				{
					goto IL_9B1;
				}
				IL_9A4:
				num2 = 122;
				c1XLBook.Save(FileName, FileFormat.OpenXml);
				goto IL_9BC;
				IL_9B1:
				num2 = 124;
				c1XLBook.Save(FileName, FileFormat.Biff8);
				IL_9BC:
				goto IL_C02;
				IL_9C1:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_BC3:
				goto IL_BF7;
				IL_BC5:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_BD5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_BC5;
			}
			IL_BF7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_C02:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 保存为网页
		/// </summary>
		/// <param name="FileName">文件名</param>
		// Token: 0x06002BDB RID: 11227 RVA: 0x0013AFCC File Offset: 0x001391CC
		public void SaveHTM(string FileName)
		{
			this.o.O0___OOo0_oO.();
			if (this.View.Count >= 1)
			{
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
				catch (Exception ex)
				{
					return;
				}
				new o_00OOooo__0_(this.PrintInfo, true).o.OO__0.(FileName);
			}
		}

		/// <summary>
		/// 保存为PDF
		/// </summary>
		/// <param name="FileName">文件名</param>
		// Token: 0x06002BDC RID: 11228 RVA: 0x0013B044 File Offset: 0x00139244
		[oO0oooo("2458")]
		public void SavePDF(string FileName)
		{
			this.o.O0___OOo0_oO.();
			if (this.View.Count >= 1)
			{
				try
				{
					if (PrinterSettings.InstalledPrinters.Count == 0)
					{
						MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
				catch (Exception ex)
				{
					return;
				}
				new o_00OOooo__0_(this.PrintInfo, true).oOO_0o_.oOo_o0.(FileName);
			}
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x0013B0BC File Offset: 0x001392BC
		private void <<EMPTY_NAME>>(XLSheet A_0, int A_1, int A_2, int A_3, int A_4)
		{
			int num;
			int num14;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				for (int i = A_3; i <= A_4; i++)
				{
					IL_16:
					num2 = 3;
					for (int j = A_1; j <= A_2; j++)
					{
						IL_23:
						num2 = 4;
						int num3 = j;
						IL_28:
						num2 = 5;
						int num4 = i;
						IL_2E:
						num2 = 6;
						int num5 = j;
						IL_34:
						num2 = 7;
						int num6 = i;
						IL_3A:
						num2 = 8;
						string text = A_0[j, i].Text;
						IL_4D:
						num2 = 9;
						for (int k = j - 1; k >= A_1; k += -1)
						{
							IL_5B:
							num2 = 10;
							string text2 = A_0[k, i].Text;
							IL_6F:
							num2 = 11;
							if (Operators.CompareString(text, text2, true) != 0)
							{
								break;
							}
							IL_7E:
							num2 = 12;
							num3 = k;
							IL_84:
							num2 = 15;
						}
						IL_93:
						num2 = 16;
						for (int l = j + 1; l <= A_2; l++)
						{
							IL_A1:
							num2 = 17;
							string text2 = A_0[l, i].Text;
							IL_B5:
							num2 = 18;
							if (Operators.CompareString(text, text2, true) != 0)
							{
								break;
							}
							IL_C4:
							num2 = 19;
							num5 = l;
							IL_CB:
							num2 = 22;
						}
						IL_DA:
						num2 = 23;
						bool flag = false;
						IL_E0:
						num2 = 24;
						for (int m = i - 1; m >= A_3; m += -1)
						{
							IL_EF:
							num2 = 25;
							flag = true;
							IL_F5:
							num2 = 26;
							int num7 = num3;
							int num8 = num5;
							for (int n = num7; n <= num8; n++)
							{
								IL_101:
								num2 = 27;
								string text2 = A_0[n, m].Text;
								IL_115:
								num2 = 28;
								if (Operators.CompareString(text, text2, true) != 0)
								{
									IL_124:
									num2 = 29;
									flag = false;
									break;
								}
								IL_12C:
								num2 = 31;
							}
							IL_13B:
							num2 = 32;
							if (!flag)
							{
								break;
							}
							IL_142:
							num2 = 33;
							num4 = m;
							IL_149:
							num2 = 36;
						}
						IL_158:
						num2 = 37;
						for (int num9 = i + 1; num9 <= A_4; num9++)
						{
							IL_167:
							num2 = 38;
							flag = true;
							IL_16D:
							num2 = 39;
							int num10 = num3;
							int num11 = num5;
							for (int num12 = num10; num12 <= num11; num12++)
							{
								IL_179:
								num2 = 40;
								string text2 = A_0[num12, num9].Text;
								IL_18D:
								num2 = 41;
								if (Operators.CompareString(text, text2, true) != 0)
								{
									IL_19C:
									num2 = 42;
									flag = false;
									break;
								}
								IL_1A4:
								num2 = 44;
							}
							IL_1B3:
							num2 = 45;
							if (!flag)
							{
								break;
							}
							IL_1BA:
							num2 = 46;
							num6 = num9;
							IL_1C1:
							num2 = 49;
						}
						IL_1D0:
						num2 = 50;
						if (num3 != num5 || num4 != num6)
						{
							IL_1DE:
							num2 = 51;
							if (num3 == j && num4 == i)
							{
								IL_1EC:
								num2 = 52;
								A_0.MergedCells.Add(num3, num4, num5 - num3 + 1, num6 - num4 + 1);
							}
						}
						IL_20B:
						num2 = 53;
					}
					IL_21D:
					num2 = 54;
				}
				IL_22F:
				goto IL_35D;
				IL_234:
				int num13 = num14 + 1;
				num14 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num13);
				IL_31E:
				goto IL_352;
				IL_320:
				num14 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_330:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num14 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_320;
			}
			IL_352:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_35D:
			if (num14 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 打开打印设置对话框
		/// </summary>
		// Token: 0x06002BDE RID: 11230 RVA: 0x0013B44C File Offset: 0x0013964C
		[oO0oooo("0556")]
		public void PrintSetting()
		{
			this.o.O0___OOo0_oO.();
			try
			{
				if (PrinterSettings.InstalledPrinters.Count == 0)
				{
					MessageBox.Show("未安装打印机！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
			}
			catch (Exception ex)
			{
				return;
			}
			new o\u3002\u3002\u3000\u3002\u3000\u3000\u3002\u3000\u3002\u3002(this.PrintInfo).ShowDialog();
			OO_00oOO.Vars["SysUpdatePrintInfo"] = true;
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x0013B4C8 File Offset: 0x001396C8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Find(params object[] args)
		{
			int result;
			if (args.Length == 6)
			{
				if (args[2] is int)
				{
					result = this.Find(Conversions.ToString(args[0]), Conversions.ToInteger(args[1]), Conversions.ToInteger(args[2]), Conversions.ToBoolean(args[3]), Conversions.ToBoolean(args[4]), Conversions.ToBoolean(args[5]));
				}
				else if (args[2] is string)
				{
					result = this.Find(Conversions.ToString(args[0]), Conversions.ToInteger(args[1]), Conversions.ToString(args[2]), Conversions.ToBoolean(args[3]), Conversions.ToBoolean(args[4]), Conversions.ToBoolean(args[5]));
				}
			}
			return result;
		}

		/// <summary>
		/// 在指定列中查找指定的字符串内容，如果找到，返回行的位置，否则返回-1
		/// </summary>
		/// <param name="StrFind">要查找的内容</param>
		/// <param name="RowStart">从此行开始查找</param>
		/// <param name="Col">在此列查找</param>
		/// <param name="caseSensitive">是否区分大小写</param>
		/// <param name="fullMatch">是否完全匹配，如果设为False，那么查找“北京”,“北京市”也符合要求。</param>
		/// <param name="Wrap">是否循环查找</param>
		// Token: 0x06002BE0 RID: 11232 RVA: 0x0013B564 File Offset: 0x00139764
		[oO0oooo("0552")]
		public int Find(string StrFind, int RowStart, int Col, bool caseSensitive, bool fullMatch, bool Wrap)
		{
			int num = this.foxGrid.FindRow(StrFind, RowStart + this.foxGrid.Rows.Fixed, Col + this.foxGrid.Cols.Fixed, caseSensitive, fullMatch, Wrap);
			int result;
			if (num > -1)
			{
				result = this.foxGrid.Rows[num].DataIndex;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		/// <summary>
		/// 在指定列中查找指定的字符串内容，如果找到，返回行的位置，否则返回-1
		/// </summary>
		/// <param name="StrFind">要查找的内容</param>
		/// <param name="RowStart">从此行开始查找</param>
		/// <param name="ColName">在此列查找</param>
		/// <param name="caseSensitive">是否区分大小写</param>
		/// <param name="fullMatch">是否完全匹配，如果设为False，那么查找“北京”,“北京市”也符合要求。</param>
		/// <param name="Wrap">是否循环查找</param>
		// Token: 0x06002BE1 RID: 11233 RVA: 0x0013B5C8 File Offset: 0x001397C8
		[oO0oooo("0552")]
		public int Find(string StrFind, int RowStart, string ColName, bool caseSensitive, bool fullMatch, bool Wrap)
		{
			int index = this.Cols[ColName].Index;
			return this.Find(StrFind, RowStart, index, caseSensitive, fullMatch, Wrap);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x0013B5F8 File Offset: 0x001397F8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int FindRow(params object[] args)
		{
			int result;
			switch (args.Length)
			{
			case 1:
				if (args[0] is DataRow)
				{
					result = this.FindRow((DataRow)args[0]);
				}
				else
				{
					result = this.FindRow(Conversions.ToString(args[0]));
				}
				break;
			case 2:
				result = this.FindRow(Conversions.ToString(args[0]), Conversions.ToInteger(args[1]));
				break;
			case 3:
				result = this.FindRow(Conversions.ToString(args[0]), Conversions.ToInteger(args[1]), Conversions.ToBoolean(args[2]));
				break;
			}
			return result;
		}

		/// <summary>
		/// 查找符合条件的行
		/// </summary>
		/// <param name="Expression">条件表达式</param>
		// Token: 0x06002BE3 RID: 11235 RVA: 0x0013B684 File Offset: 0x00139884
		[oO0oooo("0553")]
		public int FindRow(string Expression)
		{
			return this.FindRow(Expression, 0, false);
		}

		/// <summary>
		/// 查找符合条件的行
		/// </summary>
		/// <param name="Expression">条件表达式</param>
		/// <param name="RowStart">从此行开始查找</param>
		// Token: 0x06002BE4 RID: 11236 RVA: 0x0013B68F File Offset: 0x0013988F
		[oO0oooo("0553")]
		public int FindRow(string Expression, int RowStart)
		{
			return this.FindRow(Expression, RowStart, false);
		}

		/// <summary>
		/// 查找符合条件的行
		/// </summary>
		/// <param name="Expression">条件表达式</param>
		/// <param name="RowStart">从此行开始查找</param>
		/// <param name="Wrap">是否循环查找</param>
		// Token: 0x06002BE5 RID: 11237 RVA: 0x0013B69C File Offset: 0x0013989C
		[oO0oooo("0553")]
		public int FindRow(string Expression, int RowStart, bool Wrap)
		{
			object obj = this.DataTable.BaseTable;
			DataRow[] array;
			lock (obj)
			{
				array = this.DataTable.BaseTable.Select(Expression, this.View.o_o.O0ooOo.().Sort);
			}
			if (array.Length > 0)
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = this.View.o_o.O0ooOo.(array[i]);
					if (num2 >= RowStart)
					{
						return num2;
					}
				}
				if (Wrap)
				{
					int num3 = array.Length - 1;
					for (int j = 0; j <= num3; j++)
					{
						int num4 = this.View.o_o.O0ooOo.(array[j]);
						if (num4 >= 0)
						{
							return num4;
						}
					}
				}
			}
			return -1;
		}

		/// <summary>
		/// 查找某个DataRow在Table中的位置
		/// </summary>
		/// <param name="dataRow">要查找的DataRow</param>
		// Token: 0x06002BE6 RID: 11238 RVA: 0x0013B770 File Offset: 0x00139970
		[oO0oooo("0553")]
		public int FindRow(DataRow dataRow)
		{
			int result;
			if (dataRow != null)
			{
				result = this.View.o_o.O0ooOo.(dataRow.BaseRow);
			}
			else
			{
				result = -1;
			}
			return result;
		}

		/// <summary>
		/// 进入编辑状态
		/// </summary>
		// Token: 0x06002BE7 RID: 11239 RVA: 0x0013B798 File Offset: 0x00139998
		[oO0oooo("0557")]
		public void StartEditing()
		{
			O_oOooO_O o_oOooO_O = this.foxGrid;
			if (o_oOooO_O.Row >= o_oOooO_O.Rows.Fixed & o_oOooO_O.Col >= o_oOooO_O.Cols.Fixed)
			{
				o_oOooO_O.StartEditing();
			}
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0013B7E4 File Offset: 0x001399E4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Foxtable.Row AddNew(params object[] args)
		{
			Foxtable.Row result;
			if (args.Length == 0)
			{
				result = this.AddNew();
			}
			else
			{
				if (args.Length == 1)
				{
					int num = -1;
					if (int.TryParse(Conversions.ToString(args[0]), out num) && num > 0)
					{
						return this.AddNew(num);
					}
				}
				result = null;
			}
			return result;
		}

		/// <summary>
		/// 增加行
		/// </summary>
		// Token: 0x06002BE9 RID: 11241 RVA: 0x0013B829 File Offset: 0x00139A29
		[oO0oooo("0560")]
		public Foxtable.Row AddNew()
		{
			return this.Rows.AddNew(1);
		}

		/// <summary>
		/// 增加一行或多行
		/// </summary>
		/// <param name="Count"></param>
		// Token: 0x06002BEA RID: 11242 RVA: 0x0013B837 File Offset: 0x00139A37
		[oO0oooo("0560")]
		public Foxtable.Row AddNew(int Count)
		{
			return this.Rows.AddNew(Count);
		}

		/// <summary>
		/// 插入行
		/// </summary>
		// Token: 0x06002BEB RID: 11243 RVA: 0x0013B845 File Offset: 0x00139A45
		[oO0oooo("1981")]
		public Foxtable.Row InsertNew()
		{
			return this.Rows.InsertNew();
		}

		/// <summary>
		/// 退出编辑状态
		/// </summary>
		// Token: 0x06002BEC RID: 11244 RVA: 0x0013B854 File Offset: 0x00139A54
		[oO0oooo("0558")]
		public void FinishEditing()
		{
			O_oOooO_O o_oOooO_O = this.foxGrid;
			if (o_oOooO_O.Editor != null)
			{
				o_oOooO_O.FinishEditing();
			}
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x0013B87C File Offset: 0x00139A7C
		private void <<EMPTY_NAME>>(Foxtable.Row A_0, Foxtable.Row A_1)
		{
			if (Operators.CompareString(this.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., true) == 0 && this.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) && this.DataTable.BaseTable.Columns[O_O0OO.ooO0oO0O.o_O_.].DataType == typeof(int))
			{
				Foxtable.Row prevSlibing = A_1.PrevSlibing;
				Foxtable.Row nextSlibing = A_1.NextSlibing;
				if (prevSlibing != null || nextSlibing != null)
				{
					if (prevSlibing == null)
					{
						Foxtable.Row nextSlibing2 = nextSlibing.NextSlibing;
						if (nextSlibing2 == null)
						{
							A_1.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = 0;
							nextSlibing.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = 1;
							return;
						}
						if (!nextSlibing2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.))
						{
							int num = Conversions.ToInteger(nextSlibing2[O_O0OO.ooO0oO0O.o_O_.]);
							A_1.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num - 2;
							nextSlibing.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num - 1;
							return;
						}
						if (A_0 != null)
						{
							this.OO.0OO000_0__.(A_0.GetChildren(false), A_1);
							return;
						}
						this.Oo_o0_o_o.0O_.();
						return;
					}
					else if (nextSlibing == null)
					{
						Foxtable.Row prevSlibing2 = prevSlibing.PrevSlibing;
						if (prevSlibing2 == null)
						{
							prevSlibing.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = 0;
							A_1.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = 1;
							return;
						}
						if (!prevSlibing2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.))
						{
							int num2 = Conversions.ToInteger(prevSlibing2[O_O0OO.ooO0oO0O.o_O_.]);
							prevSlibing.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num2 + 1;
							A_1.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num2 + 2;
							return;
						}
						if (A_0 != null)
						{
							this.OO.0OO000_0__.(A_0.GetChildren(false), A_1);
							return;
						}
						this.Oo_o0_o_o.0O_.();
						return;
					}
					else
					{
						if (!prevSlibing.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) && !A_1.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) && !nextSlibing.get_IsNull(O_O0OO.ooO0oO0O.o_O_.))
						{
							int[] array = new int[]
							{
								Conversions.ToInteger(prevSlibing[O_O0OO.ooO0oO0O.o_O_.]),
								Conversions.ToInteger(A_1[O_O0OO.ooO0oO0O.o_O_.]),
								Conversions.ToInteger(nextSlibing[O_O0OO.ooO0oO0O.o_O_.])
							};
							Array.Sort<int>(array);
							if (array[0] != array[1] && array[0] != array[2] && array[1] != array[2])
							{
								prevSlibing.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = array[0];
								A_1.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = array[1];
								nextSlibing.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = array[2];
								return;
							}
						}
						if (A_0 != null)
						{
							this.OO.0OO000_0__.(A_0.GetChildren(false), A_1);
							return;
						}
						this.Oo_o0_o_o.0O_.();
					}
				}
			}
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x0013BB50 File Offset: 0x00139D50
		private void <<EMPTY_NAME>>(List<Foxtable.Row> A_0, Foxtable.Row A_1)
		{
			if (Operators.CompareString(this.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., true) == 0 && this.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) && this.DataTable.BaseTable.Columns[O_O0OO.ooO0oO0O.o_O_.].DataType == typeof(int))
			{
				if (this.oO_.ooo0o.)
				{
					A_0.Reverse();
				}
				int num = 0;
				int num2 = A_0.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (A_0[i].BaseDataRow == A_1.BaseDataRow)
					{
						num = i;
						break;
					}
				}
				if ((double)num <= (double)A_0.Count / 2.0)
				{
					if (num < A_0.Count - 1)
					{
						Foxtable.Row row = A_0[num + 1];
						if (!row.get_IsNull(O_O0OO.ooO0oO0O.o_O_.))
						{
							int num3 = Conversions.ToInteger(row[O_O0OO.ooO0oO0O.o_O_.]) - 1;
							for (int j = num; j >= 0; j += -1)
							{
								A_0[j].BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num3;
								num3--;
							}
							return;
						}
					}
				}
				else if ((double)num > (double)A_0.Count / 2.0 && num > 0)
				{
					Foxtable.Row row2 = A_0[num - 1];
					if (!row2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.))
					{
						int num4 = Conversions.ToInteger(row2[O_O0OO.ooO0oO0O.o_O_.]) + 1;
						int num5 = num;
						int num6 = A_0.Count - 1;
						for (int k = num5; k <= num6; k++)
						{
							A_0[k].BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num4;
							num4++;
						}
						return;
					}
				}
				int num7 = A_0.Count - 1;
				for (int l = 0; l <= num7; l++)
				{
					A_0[l].BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = l;
				}
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0013BD44 File Offset: 0x00139F44
		private void <<EMPTY_NAME>>()
		{
			if (Operators.CompareString(this.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., true) == 0 && this.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) && this.DataTable.BaseTable.Columns[O_O0OO.ooO0oO0O.o_O_.].DataType == typeof(int))
			{
				try
				{
					foreach (Foxtable.Row row in this.Rows)
					{
						if (row.Hierarchy == 0)
						{
							int num;
							row.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num;
							num++;
						}
					}
				}
				finally
				{
					IEnumerator<Foxtable.Row> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x0013BE0C File Offset: 0x0013A00C
		internal void <<EMPTY_NAME>>()
		{
			if (this.GridTreeVisible && this.Current != null && this.o.0ooOO_0__. != null)
			{
				Foxtable.Row row = this.Current;
				if (row.Hierarchy > 0)
				{
					Foxtable.Row parent = row.Parent;
					if (parent != null)
					{
						Foxtable.Row parent2 = parent.Parent;
						List<Foxtable.Row> children = parent.GetChildren(true);
						List<Foxtable.Row> children2 = row.GetChildren(true);
						children2.Insert(0, row);
						List<Foxtable.Row> list = new List<Foxtable.Row>();
						this.O0o._oo_.(this.Current.BaseDataRow, true);
						int num = children.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							if (children[i].BaseDataRow == children2[children2.Count - 1].BaseDataRow)
							{
								int num2 = i + 1;
								int num3 = children.Count - 1;
								for (int j = num2; j <= num3; j++)
								{
									list.Add(children[j]);
								}
								break;
							}
						}
						bool[] array = new bool[children2.Count - 1 + 1];
						bool[] array2 = new bool[list.Count - 1 + 1];
						object[] array3 = new object[children2.Count - 1 + 1];
						object[] array4 = new object[list.Count - 1 + 1];
						List<double> list2 = new List<double>();
						int num4 = this.Grid.Rows.Fixed + row.Index;
						int num5 = num4;
						int num6 = children2.Count - 1;
						for (int k = 0; k <= num6; k++)
						{
							list2.Add(Conversions.ToDouble(children2[k]["System_Sort_Temporary"]));
							array[k] = this.Grid.Rows[num5 + k].Visible;
							object objectValue = RuntimeHelpers.GetObjectValue(this.Grid.GetUserData(num5 + k, this.Grid.Cols.Fixed - 1));
							if (objectValue != null)
							{
								array3[k] = RuntimeHelpers.GetObjectValue(objectValue);
							}
						}
						num5 += children2.Count;
						int num7 = list.Count - 1;
						for (int l = 0; l <= num7; l++)
						{
							list2.Add(Conversions.ToDouble(list[l]["System_Sort_Temporary"]));
							array2[l] = this.Grid.Rows[num5 + l].Visible;
							object objectValue2 = RuntimeHelpers.GetObjectValue(this.Grid.GetUserData(num5 + l, this.Grid.Cols.Fixed - 1));
							if (objectValue2 != null)
							{
								array4[l] = RuntimeHelpers.GetObjectValue(objectValue2);
							}
						}
						List<DataRow> list3 = new List<DataRow>();
						List<DataRow> list4 = new List<DataRow>();
						try
						{
							foreach (Foxtable.Row row2 in list)
							{
								list3.Add(row2.DataRow.BaseRow);
							}
						}
						finally
						{
							List<Foxtable.Row>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						try
						{
							foreach (Foxtable.Row row3 in children2)
							{
								list3.Add(row3.DataRow.BaseRow);
								list4.Add(row3.DataRow.BaseRow);
							}
						}
						finally
						{
							List<Foxtable.Row>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						this.StopRedraw();
						OO_00oOO.SystemReady = false;
						int num8 = list3.Count - 1;
						for (int m = 0; m <= num8; m++)
						{
							list3[m]["System_Sort_Temporary"] = list2[m];
						}
						num5 = num4;
						int num9 = list.Count - 1;
						for (int n = 0; n <= num9; n++)
						{
							this.Grid.Rows[num5 + n].Visible = array2[n];
							if (array4[n] != null)
							{
								this.Grid.SetUserData(num5 + n, this.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array4[n]));
							}
						}
						num5 += list.Count;
						int num10 = children2.Count - 1;
						for (int num11 = 0; num11 <= num10; num11++)
						{
							this.Grid.Rows[num5 + num11].Visible = array[num11];
							if (array3[num11] != null)
							{
								this.Grid.SetUserData(num5 + num11, this.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array3[num11]));
							}
						}
						if (Operators.CompareString(Conversions.ToString(this.o.0ooOO_0__..O_OOO.0o.), "\0", true) > 0)
						{
							Conversions.ToString(this.o.0ooOO_0__..O_OOO.0o.);
						}
						if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
						{
							if (parent2 != null)
							{
								list4[0][this.o.0ooOO_0__..O_OOO.0o.] = RuntimeHelpers.GetObjectValue(parent[this.o.0ooOO_0__..O_OOO.0o.]);
							}
							else if (!parent.get_IsNull(this.o.0ooOO_0__..O_OOO.0o.))
							{
								list4[0][this.o.0ooOO_0__..O_OOO.0o.] = RuntimeHelpers.GetObjectValue(parent[this.o.0ooOO_0__..O_OOO.0o.]);
							}
							else
							{
								list4[0][this.o.0ooOO_0__..O_OOO.0o.] = RuntimeHelpers.GetObjectValue(list4[0][this.o.0ooOO_0__..OO._o0_o_OO0O.]);
							}
						}
						else
						{
							string text = Conversions.ToString(row[this.o.0ooOO_0__..OOOO._.]);
							string str;
							if (parent2 != null)
							{
								str = this.o.0ooOO_0__..O0____o.o.(parent2, row);
							}
							else
							{
								str = this.o.0ooOO_0__..O0____o.o.(this);
							}
							try
							{
								foreach (DataRow dataRow in list4)
								{
									string text2 = Conversions.ToString(dataRow[this.o.0ooOO_0__..OOOO._.]);
									if (text2.Length >= text.Length)
									{
										text2 = str + text2.Substring(text.Length);
									}
									dataRow[this.o.0ooOO_0__..OOOO._.] = text2;
								}
							}
							finally
							{
								List<DataRow>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
						try
						{
							foreach (DataRow dataRow2 in list4)
							{
								dataRow2["sys_Hierarchy_Level"] = Conversions.ToInteger(dataRow2["sys_Hierarchy_Level"]) - 1;
							}
						}
						finally
						{
							List<DataRow>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						OO_00oOO.SystemReady = true;
						if (this.Current.BaseDataRow != list4[0])
						{
							this.Position = this.FindRow(new DataRow(list4[0]));
						}
						if (this.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.))
						{
							this.Current.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = DBNull.Value;
						}
						this.OO.0OO000_0__.(this.Current.Parent, this.Current);
						this.ResumeRedraw();
					}
				}
			}
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0013C544 File Offset: 0x0013A744
		internal void <<EMPTY_NAME>>()
		{
			if (this.GridTreeVisible && this.Current != null && this.o.0ooOO_0__. != null && this.Position > 0)
			{
				Foxtable.Row row = this.Current;
				int hierarchy = row.Hierarchy;
				Foxtable.Row prevSlibing = row.PrevSlibing;
				if (prevSlibing != null)
				{
					this.StopRedraw();
					OO_00oOO.SystemReady = false;
					prevSlibing.Collapsed = false;
					if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
					{
						row[this.o.0ooOO_0__..O_OOO.0o.] = RuntimeHelpers.GetObjectValue(prevSlibing[this.o.0ooOO_0__..OO._o0_o_OO0O.]);
						int num = this.Position;
						int num2 = this.Rows.Count - 1;
						for (int i = num; i <= num2; i++)
						{
							if (i > this.Position && this.Rows[i].Hierarchy <= hierarchy)
							{
								break;
							}
							this.Rows[i].BaseDataRow["sys_Hierarchy_Level"] = Conversions.ToInteger(this.Rows[i].BaseDataRow["sys_Hierarchy_Level"]) + 1;
						}
					}
					else
					{
						if (Operators.CompareString(Conversions.ToString(this.o.0ooOO_0__..O_OOO.0o.), "\0", true) > 0)
						{
							Conversions.ToString(this.o.0ooOO_0__..O_OOO.0o.);
						}
						string text = Conversions.ToString(row[this.o.0ooOO_0__..OOOO._.]);
						string str = this.o.0ooOO_0__..O0____o.o.(prevSlibing, row);
						int num3 = this.Position;
						int num4 = this.Rows.Count - 1;
						int num5 = num3;
						while (num5 <= num4 && (num5 <= this.Position || this.Rows[num5].Hierarchy > hierarchy))
						{
							string text2 = this.Rows[num5][this.o.0ooOO_0__..OOOO._.].ToString();
							if (text2.Length >= text.Length)
							{
								text2 = str + text2.Substring(text.Length);
							}
							this.Rows[num5].BaseDataRow[this.o.0ooOO_0__..OOOO._.] = text2;
							this.Rows[num5].BaseDataRow["sys_Hierarchy_Level"] = Conversions.ToInteger(this.Rows[num5]["sys_Hierarchy_Level"]) + 1;
							num5++;
						}
					}
					OO_00oOO.SystemReady = true;
					this.OO.0OO000_0__.(this.Current.Parent, this.Current);
					if (this.Current.Parent != null)
					{
						this.o0O_o0.oOO.(this.Current.BaseDataRow);
					}
					this.ResumeRedraw();
				}
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0013C810 File Offset: 0x0013AA10
		internal void <<EMPTY_NAME>>()
		{
			if (this.GridTreeVisible && this.Current != null && this.Position < this.Rows.Count - 1)
			{
				Foxtable.Row row = this.Current;
				DataRow dataRow = row.DataRow;
				this.O0o.00oOo0O.(row);
				if (this.Current.BaseDataRow != dataRow.BaseRow)
				{
					this.Position = this.FindRow(dataRow);
				}
				this.OO.0OO000_0__.(this.Current.Parent, this.Current);
			}
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0013C890 File Offset: 0x0013AA90
		internal void <<EMPTY_NAME>>()
		{
			if (this.GridTreeVisible && this.Current != null && this.Position > 0)
			{
				Foxtable.Row row = this.Current;
				DataRow dataRow = row.DataRow;
				Foxtable.Row prevSlibing = row.PrevSlibing;
				if (prevSlibing != null)
				{
					this.O0o.00oOo0O.(prevSlibing);
					if (this.Current.BaseDataRow != dataRow.BaseRow)
					{
						this.Position = this.FindRow(dataRow);
					}
					this.OO.0OO000_0__.(this.Current.Parent, this.Current);
				}
			}
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x0013C90C File Offset: 0x0013AB0C
		private void <<EMPTY_NAME>>(Foxtable.Row A_0)
		{
			Foxtable.Row nextSlibing = A_0.NextSlibing;
			if (nextSlibing != null)
			{
				List<Foxtable.Row> children = A_0.GetChildren(true);
				List<Foxtable.Row> children2 = nextSlibing.GetChildren(true);
				children.Insert(0, A_0);
				children2.Insert(0, nextSlibing);
				bool[] array = new bool[children.Count - 1 + 1];
				bool[] array2 = new bool[children2.Count - 1 + 1];
				object[] array3 = new object[children.Count - 1 + 1];
				object[] array4 = new object[children2.Count - 1 + 1];
				List<double> list = new List<double>();
				int num = this.Grid.Rows.Fixed + A_0.Index;
				int num2 = num;
				int num3 = children.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					list.Add(Conversions.ToDouble(children[i]["System_Sort_Temporary"]));
					array[i] = this.Grid.Rows[num2 + i].Visible;
					object objectValue = RuntimeHelpers.GetObjectValue(this.Grid.GetUserData(num2 + i, this.Grid.Cols.Fixed - 1));
					if (objectValue != null)
					{
						array3[i] = RuntimeHelpers.GetObjectValue(objectValue);
					}
				}
				num2 += children.Count;
				int num4 = children2.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					list.Add(Conversions.ToDouble(children2[j]["System_Sort_Temporary"]));
					array2[j] = this.Grid.Rows[num2 + j].Visible;
					object objectValue2 = RuntimeHelpers.GetObjectValue(this.Grid.GetUserData(num2 + j, this.Grid.Cols.Fixed - 1));
					if (objectValue2 != null)
					{
						array4[j] = RuntimeHelpers.GetObjectValue(objectValue2);
					}
				}
				List<DataRow> list2 = new List<DataRow>();
				try
				{
					foreach (Foxtable.Row row in children2)
					{
						list2.Add(row.DataRow.BaseRow);
					}
				}
				finally
				{
					List<Foxtable.Row>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Foxtable.Row row2 in children)
					{
						list2.Add(row2.DataRow.BaseRow);
					}
				}
				finally
				{
					List<Foxtable.Row>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				this.StopRedraw();
				OO_00oOO.SystemReady = false;
				int num5 = list2.Count - 1;
				for (int k = 0; k <= num5; k++)
				{
					list2[k]["System_Sort_Temporary"] = list[k];
				}
				num2 = num;
				int num6 = children2.Count - 1;
				for (int l = 0; l <= num6; l++)
				{
					this.Grid.Rows[num2 + l].Visible = array2[l];
					if (array4[l] != null)
					{
						this.Grid.SetUserData(num2 + l, this.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array4[l]));
					}
				}
				num2 += children2.Count;
				int num7 = children.Count - 1;
				for (int m = 0; m <= num7; m++)
				{
					this.Grid.Rows[num2 + m].Visible = array[m];
					if (array3[m] != null)
					{
						this.Grid.SetUserData(num2 + m, this.Grid.Cols.Fixed - 1, RuntimeHelpers.GetObjectValue(array3[m]));
					}
				}
				OO_00oOO.SystemReady = true;
				this.ResumeRedraw();
			}
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x0013CCC0 File Offset: 0x0013AEC0
		internal Foxtable.Row <<EMPTY_NAME>>()
		{
			Foxtable.Row result;
			if (!this.GridTreeVisible)
			{
				result = null;
			}
			else
			{
				Foxtable.Row row = this.Current;
				if (row == null)
				{
					row = this.AddNew();
					row.DataRow.BaseRow["sys_Hierarchy_Level"] = 0;
					row.DataRow.BaseRow["System_Sort_Temporary"] = 0;
					if (this.o.0ooOO_0__. != null)
					{
						if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
						{
							string value = this.o.0ooOO_0__..o0Oo.0_Oo0__O.(this);
							row[this.o.0ooOO_0__..O_OOO.0o.] = value;
							row[this.o.0ooOO_0__..OO._o0_o_OO0O.] = value;
						}
						else
						{
							row[this.o.0ooOO_0__..OOOO._.] = this.o.0ooOO_0__..O0____o.o.(this);
						}
					}
					result = row;
				}
				else
				{
					this.StopRedraw();
					DataRow baseRow = row.DataRow.BaseRow;
					int num = 0;
					if (!baseRow.IsNull("sys_Hierarchy_Level"))
					{
						num = Conversions.ToInteger(baseRow["sys_Hierarchy_Level"]);
					}
					double num2 = -1.0;
					Foxtable.Row parent = row.Parent;
					string text = "";
					string value2 = "";
					if (this.o.0ooOO_0__. != null)
					{
						if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
						{
							if (num > 0)
							{
								text = Conversions.ToString(baseRow[this.o.0ooOO_0__..O_OOO.0o.]);
								value2 = this.o.0ooOO_0__..o0o0OOO.OO0o.(parent);
							}
							else
							{
								text = this.o.0ooOO_0__..o0Oo.0_Oo0__O.(this);
								value2 = text;
							}
						}
						else if (parent != null)
						{
							text = this.o.0ooOO_0__..O0____o.o.(parent, null);
						}
						else
						{
							text = this.o.0ooOO_0__..O0____o.o.(this);
						}
					}
					if (parent == null || this.Position == this.Rows.Count - 1)
					{
						num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[this.Rows.Count - 1]["System_Sort_Temporary"])) + 1.0;
					}
					else
					{
						int num3 = this.Position;
						int num4 = this.Rows.Count - 1;
						for (int i = num3; i <= num4; i++)
						{
							if (Conversions.ToInteger(this.Rows[i]["sys_Hierarchy_Level"]) < num)
							{
								num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[i - 1]["System_Sort_Temporary"])) + (Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[i]["System_Sort_Temporary"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[i - 1]["System_Sort_Temporary"]))) * 0.2;
								break;
							}
						}
						if (num2 == -1.0)
						{
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[this.Rows.Count - 1]["System_Sort_Temporary"])) + 1.0;
						}
					}
					DataRow dataRow = this.DataTable.AddNew(1);
					if (dataRow == null)
					{
						this.ResumeRedraw();
						result = null;
					}
					else
					{
						if (this.IsChild)
						{
							DataRelation dataRelation = this.View.O0O_0_0__.0O.();
							int num5 = dataRelation.ChildColumns.Length - 1;
							for (int j = 0; j <= num5; j++)
							{
								dataRow[dataRelation.ChildColumns[j].ColumnName] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row[dataRelation.ParentColumns[j].ColumnName]);
							}
						}
						dataRow.BaseRow["sys_Hierarchy_Level"] = num;
						dataRow.BaseRow["System_Sort_Temporary"] = num2;
						if (Operators.CompareString(text, "", true) > 0)
						{
							if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
							{
								dataRow[this.o.0ooOO_0__..O_OOO.0o.] = text;
								dataRow[this.o.0ooOO_0__..OO._o0_o_OO0O.] = value2;
							}
							else
							{
								dataRow[this.o.0ooOO_0__..OOOO._.] = text;
							}
						}
						this.Position = this.FindRow(dataRow);
						if (this.Current != null)
						{
							this.OO.0OO000_0__.(this.Current.Parent, this.Current);
						}
						this.ResumeRedraw();
						result = this.Current;
					}
				}
			}
			return result;
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0013D140 File Offset: 0x0013B340
		internal void <<EMPTY_NAME>>()
		{
			if (this.GridTreeVisible && this.o.0ooOO_0__. != null && this.Current != null)
			{
				Foxtable.Row row = this.Current;
				Foxtable.Row row2 = this.O____o.0.();
				try
				{
					foreach (Col col in this.Cols)
					{
						if (Operators.CompareString(col.Name, this.o.0ooOO_0__..O_OOO.0o., true) != 0 && Operators.CompareString(col.Name, this.o.0ooOO_0__..OO._o0_o_OO0O., true) != 0 && Operators.CompareString(col.Name, this.o.0ooOO_0__..OOOO._., true) != 0 && Operators.CompareString(col.DataCol.BaseColumn.Expression, "", true) <= 0)
						{
							row2[col.Name] = RuntimeHelpers.GetObjectValue(row[col.Name]);
						}
					}
				}
				finally
				{
					IEnumerator<Col> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x0013D244 File Offset: 0x0013B444
		internal void <<EMPTY_NAME>>()
		{
			if (this.foxGrid.OO.o_o00o.() && this.o.0ooOO_0__. != null && this.Current != null)
			{
				Foxtable.Row row = this.Current;
				Foxtable.Row row2 = this.O_.o__ooo.(false);
				try
				{
					foreach (Col col in this.Cols)
					{
						if (Operators.CompareString(col.DataCol.BaseColumn.Expression, "", true) <= 0)
						{
							row2[col.Name] = RuntimeHelpers.GetObjectValue(row[col.Name]);
						}
					}
				}
				finally
				{
					IEnumerator<Col> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x0013D2F4 File Offset: 0x0013B4F4
		internal Foxtable.Row <<EMPTY_NAME>>()
		{
			Foxtable.Row result;
			if (!this.GridTreeVisible)
			{
				result = null;
			}
			else
			{
				Foxtable.Row row = this.Current;
				if (row == null)
				{
					result = this.O____o.0.();
				}
				else
				{
					this.StopRedraw();
					DataRow baseRow = row.DataRow.BaseRow;
					if (!baseRow.IsNull("sys_Hierarchy_Level"))
					{
						int num = Conversions.ToInteger(baseRow["sys_Hierarchy_Level"]);
						Foxtable.Row parent = row.Parent;
						string text = "";
						string value = "";
						if (this.o.0ooOO_0__. != null)
						{
							if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
							{
								if (num > 0)
								{
									text = Conversions.ToString(baseRow[this.o.0ooOO_0__..O_OOO.0o.]);
									value = this.o.0ooOO_0__..o0o0OOO.OO0o.(parent);
								}
								else
								{
									text = this.o.0ooOO_0__..o0Oo.0_Oo0__O.(this);
									value = text;
								}
							}
							else if (parent != null)
							{
								text = this.o.0ooOO_0__..O0____o.o.(parent, null);
							}
							else
							{
								text = this.o.0ooOO_0__..O0____o.o.(this);
							}
						}
						double num2;
						if (this.Position == 0)
						{
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow["System_Sort_Temporary"])) - 1.0;
						}
						else
						{
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[this.Position - 1]["System_Sort_Temporary"])) + (Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow["System_Sort_Temporary"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[this.Position - 1]["System_Sort_Temporary"]))) * 0.8;
						}
						Point scrollPosition = this.foxGrid.ScrollPosition;
						DataRow dataRow = this.DataTable.AddNew(1);
						if (this.IsChild)
						{
							DataRelation dataRelation = this.View.O0O_0_0__.0O.();
							int num3 = dataRelation.ChildColumns.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								dataRow[dataRelation.ChildColumns[i].ColumnName] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row[dataRelation.ParentColumns[i].ColumnName]);
							}
						}
						dataRow.BaseRow["sys_Hierarchy_Level"] = num;
						dataRow.BaseRow["System_Sort_Temporary"] = num2;
						if (Operators.CompareString(text, "", true) > 0)
						{
							if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
							{
								dataRow[this.o.0ooOO_0__..O_OOO.0o.] = text;
								dataRow[this.o.0ooOO_0__..OO._o0_o_OO0O.] = value;
							}
							else
							{
								dataRow[this.o.0ooOO_0__..OOOO._.] = text;
							}
						}
						this.Position = this.FindRow(dataRow);
						if (this.Current != null)
						{
							this.OO.0OO000_0__.(this.Current.Parent, this.Current);
						}
						this.foxGrid.ScrollPosition = scrollPosition;
						this.ResumeRedraw();
						result = this.Current;
					}
					else
					{
						this.ResumeRedraw();
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x0013D610 File Offset: 0x0013B810
		internal Foxtable.Row <<EMPTY_NAME>>()
		{
			Foxtable.Row result;
			if (!this.GridTreeVisible)
			{
				result = null;
			}
			else
			{
				Foxtable.Row row = this.Current;
				if (row == null)
				{
					result = this.O____o.0.();
				}
				else
				{
					this.StopRedraw();
					bool flag;
					if (this.Position == this.Rows.Count - 1)
					{
						flag = true;
					}
					else if (row.Collapsed)
					{
						row.Collapsed = false;
					}
					string text = "";
					string value = "";
					if (this.o.0ooOO_0__. != null)
					{
						if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
						{
							text = Conversions.ToString(row[this.o.0ooOO_0__..OO._o0_o_OO0O.]);
							value = this.o.0ooOO_0__..o0o0OOO.OO0o.(row);
						}
						else
						{
							text = this.o.0ooOO_0__..O0____o.o.(row, null);
						}
					}
					DataRow baseRow = row.DataRow.BaseRow;
					if (!baseRow.IsNull("sys_Hierarchy_Level"))
					{
						int num = Conversions.ToInteger(baseRow["sys_Hierarchy_Level"]);
						double num2 = -1.0;
						if (this.Position < this.Rows.Count - 1)
						{
							if (Conversions.ToInteger(this.Rows[this.Position + 1]["sys_Hierarchy_Level"]) == num + 1)
							{
								int num3 = this.Position + 1;
								int num4 = this.Rows.Count - 1;
								for (int i = num3; i <= num4; i++)
								{
									if (Conversions.ToInteger(this.Rows[i]["sys_Hierarchy_Level"]) <= num)
									{
										num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[i - 1]["System_Sort_Temporary"])) + (Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[i]["System_Sort_Temporary"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[i - 1]["System_Sort_Temporary"]))) * 0.2;
										break;
									}
								}
								if (num2 == -1.0)
								{
									num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[this.Rows.Count - 1]["System_Sort_Temporary"])) + 1.0;
								}
							}
							else
							{
								num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow["System_Sort_Temporary"])) + (Conversion.Val(RuntimeHelpers.GetObjectValue(this.Rows[this.Position + 1]["System_Sort_Temporary"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow["System_Sort_Temporary"]))) * 0.2;
							}
						}
						else
						{
							num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(baseRow["System_Sort_Temporary"])) + 1.0;
						}
						DataRow dataRow = this.DataTable.AddNew(1);
						if (this.IsChild)
						{
							DataRelation dataRelation = this.View.O0O_0_0__.0O.();
							int num5 = dataRelation.ChildColumns.Length - 1;
							for (int j = 0; j <= num5; j++)
							{
								dataRow[dataRelation.ChildColumns[j].ColumnName] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row[dataRelation.ParentColumns[j].ColumnName]);
							}
						}
						dataRow.BaseRow["sys_Hierarchy_Level"] = num + 1;
						dataRow.BaseRow["System_Sort_Temporary"] = num2;
						if (Operators.CompareString(text, "", true) > 0)
						{
							if (Operators.CompareString(this.o.0ooOO_0__..O_OOO.0o., "", true) > 0)
							{
								dataRow[this.o.0ooOO_0__..O_OOO.0o.] = text;
								dataRow[this.o.0ooOO_0__..OO._o0_o_OO0O.] = value;
							}
							else
							{
								dataRow[this.o.0ooOO_0__..OOOO._.] = text;
							}
						}
						if (flag)
						{
							row.Collapsed = false;
						}
						this.Position = this.FindRow(dataRow);
						if (this.Current != null)
						{
							this.OO.0OO000_0__.(this.Current.Parent, this.Current);
						}
						this.ResumeRedraw();
						result = this.Current;
					}
					else
					{
						this.ResumeRedraw();
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x0013DA58 File Offset: 0x0013BC58
		internal Foxtable.Row <<EMPTY_NAME>>(bool A_0)
		{
			Foxtable.Row result;
			if (this.foxGrid.OO.o_o00o.() && this.o.0ooOO_0__. != null)
			{
				int num = this.foxGrid.Row;
				while (this.foxGrid.Rows[num].DataIndex == -1)
				{
					if (this.foxGrid.Rows[num].IsNode)
					{
						this.foxGrid.Rows[num].Node.Expanded = true;
					}
					if (num >= this.foxGrid.Rows.Count - 1)
					{
						break;
					}
					num++;
				}
				if (this.foxGrid.Rows[num].DataIndex == -1)
				{
					result = null;
				}
				else
				{
					Foxtable.Row row = this.Rows[this.foxGrid.Rows[num].DataIndex];
					Foxtable.Row row2 = null;
					if (!A_0)
					{
						int num2 = num + 1;
						int num3 = this.foxGrid.Rows.Count - 1;
						int num4 = num2;
						while (num4 <= num3 && this.foxGrid.Rows[num4].DataIndex != -1)
						{
							row = this.Rows[this.foxGrid.Rows[num4].DataIndex];
							num4++;
						}
					}
					if (row.Index > 0)
					{
						row2 = this.Rows[row.Index - 1];
					}
					double num5 = Conversions.ToDouble(row["System_Sort_Temporary"]);
					double num6;
					if (row.Index == 0)
					{
						num6 = num5 - 1.0;
					}
					else if (A_0)
					{
						num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(row2["System_Sort_Temporary"])) + (Conversion.Val(RuntimeHelpers.GetObjectValue(row["System_Sort_Temporary"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(row2["System_Sort_Temporary"]))) * 0.8;
					}
					else
					{
						num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(row2["System_Sort_Temporary"])) + (Conversion.Val(RuntimeHelpers.GetObjectValue(row["System_Sort_Temporary"])) - Conversion.Val(RuntimeHelpers.GetObjectValue(row2["System_Sort_Temporary"]))) * 0.2;
					}
					this.StopRedraw();
					Point scrollPosition = this.foxGrid.ScrollPosition;
					DataRow dataRow = this.DataTable.AddNew(1);
					if (this.IsChild)
					{
						DataRelation dataRelation = this.View.O0O_0_0__.0O.();
						int num7 = dataRelation.ChildColumns.Length - 1;
						for (int i = 0; i <= num7; i++)
						{
							dataRow[dataRelation.ChildColumns[i].ColumnName] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row[dataRelation.ParentColumns[i].ColumnName]);
						}
					}
					if (A_0)
					{
						dataRow.BaseRow["System_Sort_Temporary"] = num6;
					}
					else
					{
						dataRow.BaseRow["System_Sort_Temporary"] = num6;
						row.BaseDataRow["System_Sort_Temporary"] = num6;
						dataRow.BaseRow["System_Sort_Temporary"] = num5;
					}
					foreach (string columnName in this.o.0ooOO_0__..O_OOO.0o.)
					{
						dataRow[columnName] = RuntimeHelpers.GetObjectValue(row[columnName]);
					}
					this.Position = this.FindRow(dataRow);
					this.foxGrid.ScrollPosition = scrollPosition;
					if (Operators.CompareString(this.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., true) == 0 && this.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) && this.DataTable.BaseTable.Columns[O_O0OO.ooO0oO0O.o_O_.].DataType == typeof(int))
					{
						this.OO.0OO000_0__.(this.foxGrid.Row);
					}
					this.ResumeRedraw();
					result = this.Current;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x0013DE5C File Offset: 0x0013C05C
		internal void <<EMPTY_NAME>>(string A_0)
		{
			if (Operators.CompareString(A_0, this.Name, true) != 0)
			{
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					"[" + A_0 + "]",
					""
				});
				if (dataRow != null)
				{
					dataRow["Table"] = "[" + this.Name + "]";
				}
			}
			Table.oO00_O_O o.OoOo_. = this.O.OoOo_.;
			if (o.OoOo_. != null)
			{
				o.OoOo_.();
			}
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x0013DEEB File Offset: 0x0013C0EB
		internal void <<EMPTY_NAME>>()
		{
			this.oo0OO0Ooo._.(false);
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x0013DEF4 File Offset: 0x0013C0F4
		internal void <<EMPTY_NAME>>(bool A_0)
		{
			if (this.NeedSaveSetting && this.TableType == TableTypeEnum.Normal && !this.View.O0O.o__0.())
			{
				TableProperty a_ = new TableProperty(this);
				DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
				{
					"[" + this.Name + "]",
					""
				});
				if (dataRow == null)
				{
					dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].NewRow();
					dataRow["Table"] = "[" + this.Name + "]";
					dataRow["Column"] = "";
					O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Add(dataRow);
				}
				dataRow["Config"] = o_O_o_oOoo__.OOOO_OO._oo.(a_, false, '\v', false);
				this.NeedSaveSetting = false;
				if (A_0)
				{
					Oo00.O0Oo_O.0O_0O.(dataRow);
				}
			}
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x0013E004 File Offset: 0x0013C204
		internal TableProperty <<EMPTY_NAME>>(bool A_0)
		{
			TableProperty tableProperty = new TableProperty(this);
			DataRow dataRow = O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0O.0o0.()].Rows.Find(new object[]
			{
				"[" + this.Name + "]",
				""
			});
			if (dataRow != null)
			{
				o_O_o_oOoo__.OOOO_OO._oo.(tableProperty, dataRow["Config"].ToString(), '\v');
				if (A_0)
				{
					tableProperty.Restore();
				}
			}
			this.NeedSaveSetting = false;
			this.Loaded = true;
			return tableProperty;
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x0013E090 File Offset: 0x0013C290
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x0013E098 File Offset: 0x0013C298
		internal O_oOooO_O foxGrid
		{
			get
			{
				return this.O_o0OOo_.o0.;
			}
			set
			{
				this.O_o0OOo_.o0. = value;
			}
		}

		/// <summary>
		/// 返回底层的C1FlexGrid控件
		/// </summary>
		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x0013E0A1 File Offset: 0x0013C2A1
		public C1FlexGrid Grid
		{
			get
			{
				return this.O_o0OOo_.o0.;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x0013E0A9 File Offset: 0x0013C2A9
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x0013E0B1 File Offset: 0x0013C2B1
		internal O_0 View
		{
			get
			{
				return this.o.0ooOO_0__.;
			}
			set
			{
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x0013E0B3 File Offset: 0x0013C2B3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ResetCurrentItem()
		{
			this.o.0ooOO_0__..ResetCurrentItem();
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x0013E0C0 File Offset: 0x0013C2C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ResetBindings(bool metadataChanged = false)
		{
			this.o.0ooOO_0__..ResetBindings(metadataChanged);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x0013E0CE File Offset: 0x0013C2CE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ResetItem(int Itemindex)
		{
			this.o.0ooOO_0__..ResetItem(Itemindex);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x0013E0DC File Offset: 0x0013C2DC
		internal void <<EMPTY_NAME>>()
		{
			if (this.AllowFreezeColumn)
			{
				this.O_o0OOo_.o0..AllowFreezing = AllowFreezingEnum.Columns;
			}
			else
			{
				this.O_o0OOo_.o0..AllowFreezing = AllowFreezingEnum.None;
			}
			if (this.AllowResizeColumn & this.AllowResizeRow)
			{
				this.O_o0OOo_.o0..AllowResizing = AllowResizingEnum.Both;
			}
			else if (this.AllowResizeColumn)
			{
				this.O_o0OOo_.o0..AllowResizing = AllowResizingEnum.Columns;
			}
			else if (this.AllowResizeRow)
			{
				this.O_o0OOo_.o0..AllowResizing = AllowResizingEnum.RowsUniform;
			}
			else
			{
				this.O_o0OOo_.o0..AllowResizing = AllowResizingEnum.None;
			}
			if (this.EnterKeyActionDown)
			{
				this.O_o0OOo_.o0..KeyActionEnter = KeyActionEnum.MoveDown;
			}
			else
			{
				this.O_o0OOo_.o0..KeyActionEnter = KeyActionEnum.MoveAcross;
			}
			if (this.TabKeyActionDown)
			{
				this.O_o0OOo_.o0..KeyActionTab = KeyActionEnum.MoveDown;
				return;
			}
			this.O_o0OOo_.o0..KeyActionTab = KeyActionEnum.MoveAcross;
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x0013E1A4 File Offset: 0x0013C3A4
		internal bool <<EMPTY_NAME>>()
		{
			string tableName = this.View.o_o.O0ooOo.().TableName;
			bool result;
			if (this.IsParent)
			{
				MessageBox.Show("不能直接在父表增加行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = false;
			}
			else
			{
				if (this.IsChild)
				{
					if (this.View.O0O_0_0__.0O.().Position < 0)
					{
						MessageBox.Show("增加行失败，父表无有效行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return false;
					}
					int num = this.View.O0O_0_0__.0O.().ChildColumns.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (this.View.O0O_0_0__.0O.().o_o.O0ooOo.().Row.IsNull(this.View.O0O_0_0__.0O.().ParentColumns[i].ColumnName))
						{
							MessageBox.Show("增加行失败，父行(" + this.View.O0O_0_0__.0O.().ParentColumns[i].ColumnName + ")未输入有效值！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0013E2AB File Offset: 0x0013C4AB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Foxtable.Row> GetEnumerator()
		{
			return new O_0o_0o_o0O_(this);
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x0013E2B3 File Offset: 0x0013C4B3
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new O_0o_0o_o0O_(this);
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x0013E2BC File Offset: 0x0013C4BC
		internal bool <<EMPTY_NAME>>(bool A_0 = true, bool A_1 = false)
		{
			int num;
			bool result;
			int num4;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				List<string>.Enumerator enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator();
				bool flag;
				while (enumerator.MoveNext())
				{
					string columnName = enumerator.Current;
					IL_20:
					num2 = 3;
					if (this.foxGrid.Cols.Contains(columnName))
					{
						IL_36:
						num2 = 4;
						flag = true;
						break;
					}
					IL_3D:
					num2 = 6;
				}
				IL_48:
				num2 = 7;
				((IDisposable)enumerator).Dispose();
				IL_57:
				num2 = 8;
				IEnumerator enumerator2 = O_O0OO.OOOo.oo_OOOO_0.().Relations.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					DataRelation dataRelation = (DataRelation)obj;
					IL_7A:
					num2 = 9;
					if (this.DataTable.BaseTable == dataRelation.ParentTable || this.DataTable.BaseTable == dataRelation.ChildTable)
					{
						IL_A5:
						num2 = 10;
						if (this.foxGrid.Cols.Contains(dataRelation.RelationName))
						{
							IL_C1:
							num2 = 11;
							flag = true;
							break;
						}
					}
					IL_C9:
					num2 = 13;
				}
				IL_D5:
				num2 = 14;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_ED:
				num2 = 15;
				for (int i = this.foxGrid.Cols.Count - 1; i >= 1; i += -1)
				{
					IL_109:
					num2 = 16;
					if (OO_00oOO.User.Type != UserTypeEnum.Developer)
					{
						IL_118:
						num2 = 17;
						if (this.foxGrid.Cols[i].Name.StartsWith("sys_", StringComparison.CurrentCultureIgnoreCase))
						{
							IL_13F:
							num2 = 18;
							flag = true;
							break;
						}
					}
					IL_14A:
					num2 = 20;
					if (!this.DataTable.BaseTable.Columns.Contains(this.foxGrid.Cols[i].Name))
					{
						IL_17B:
						num2 = 21;
						flag = true;
						break;
					}
					IL_183:
					num2 = 23;
					if (this.foxGrid.Cols[this.foxGrid.Cols[i].Name].Index != i)
					{
						IL_1B6:
						num2 = 24;
						flag = true;
						break;
					}
					IL_1BE:
					num2 = 26;
				}
				IL_1CF:
				num2 = 27;
				if (!flag && !A_1)
				{
					goto IL_1F7;
				}
				IL_1D8:
				num2 = 28;
				this.oO_o_0o._0oooo.(A_0);
				IL_1E2:
				num2 = 29;
				this.foxGrid.Refresh();
				IL_1F0:
				num2 = 30;
				result = true;
				goto IL_1FC;
				IL_1F7:
				num2 = 32;
				result = false;
				IL_1FC:
				goto IL_2D2;
				IL_201:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_293:
				goto IL_2C7;
				IL_295:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_2A5:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_295;
			}
			IL_2C7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2D2:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x0013E5C0 File Offset: 0x0013C7C0
		internal void <<EMPTY_NAME>>(bool A_0 = true)
		{
			int num;
			int num6;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				int num3 = 0;
				IL_0B:
				num2 = 3;
				if (this.Grid.Cols.Count <= 1 || Operators.CompareString(this.Grid.Cols[1].Name, "", true) != 0)
				{
					goto IL_60;
				}
				IL_43:
				num2 = 4;
				this.Grid.DataSource = RuntimeHelpers.GetObjectValue(this.Grid.DataSource);
				IL_60:
				num2 = 5;
				int num4 = 1;
				do
				{
					IL_65:
					num2 = 6;
					List<string>.Enumerator enumerator = o_O_o_oOoo__.oO.O_..GetEnumerator();
					while (enumerator.MoveNext())
					{
						string columnName = enumerator.Current;
						IL_7E:
						num2 = 7;
						if (this.foxGrid.Cols.Contains(columnName))
						{
							IL_94:
							num2 = 8;
							this.foxGrid.Cols.Remove(columnName);
							IL_A9:
							num2 = 9;
							num3++;
						}
						IL_B0:
						num2 = 10;
					}
					IL_BC:
					num2 = 11;
					((IDisposable)enumerator).Dispose();
					IL_CC:
					num2 = 12;
					num4++;
				}
				while (num4 <= 3);
				IL_DA:
				num2 = 13;
				IEnumerator enumerator2 = O_O0OO.OOOo.oo_OOOO_0.().Relations.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					object obj = enumerator2.Current;
					DataRelation dataRelation = (DataRelation)obj;
					IL_FE:
					num2 = 14;
					if (this.DataTable.BaseTable == dataRelation.ParentTable || this.DataTable.BaseTable == dataRelation.ChildTable)
					{
						IL_129:
						num2 = 15;
						if (this.foxGrid.Cols.Contains(dataRelation.RelationName))
						{
							IL_145:
							num2 = 16;
							this.foxGrid.Cols.Remove(dataRelation.RelationName);
							IL_160:
							num2 = 17;
							num3++;
						}
					}
					IL_167:
					num2 = 18;
				}
				IL_176:
				num2 = 19;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
				IL_18E:
				num2 = 20;
				int i = this.foxGrid.Cols.Count - 1;
				while (i >= 1)
				{
					IL_1AA:
					num2 = 21;
					if (OO_00oOO.User.Type == UserTypeEnum.Developer)
					{
						goto IL_1FB;
					}
					IL_1B9:
					num2 = 22;
					if (!this.foxGrid.Cols[i].Name.StartsWith("sys_", StringComparison.CurrentCultureIgnoreCase))
					{
						goto IL_1FB;
					}
					IL_1E0:
					num2 = 23;
					this.foxGrid.Cols.Remove(i);
					IL_28D:
					num2 = 30;
					i += -1;
					continue;
					IL_1FB:
					num2 = 25;
					if (!this.DataTable.BaseTable.Columns.Contains(this.foxGrid.Cols[i].Name))
					{
						IL_22C:
						num2 = 26;
						this.foxGrid.Cols.Remove(i);
						goto IL_28D;
					}
					IL_244:
					num2 = 28;
					if (this.foxGrid.Cols[this.foxGrid.Cols[i].Name].Index != i)
					{
						IL_277:
						num2 = 29;
						this.foxGrid.Cols.Remove(i);
						goto IL_28D;
					}
					goto IL_28D;
				}
				IL_29E:
				num2 = 31;
				if (num3 != 0)
				{
					goto IL_2B0;
				}
				IL_2A4:
				num2 = 32;
				this.O0oO0oo_O_o.Oo.(false);
				goto IL_2BA;
				IL_2B0:
				num2 = 34;
				this.O0oO0oo_O_o.Oo.(true);
				IL_2BA:
				num2 = 35;
				this.o.OO0O0O. = "";
				IL_2C8:
				num2 = 36;
				if (!A_0)
				{
					goto IL_30A;
				}
				IL_2CE:
				num2 = 37;
				TableEventArgs tableEventArgs = new TableEventArgs(this);
				IL_2D9:
				num2 = 38;
				O_O0OO.OoO_o.oO0o0O.(this.DataTable.o_0_00_.oo0O0., "AfterLoadTableSetting", new object[]
				{
					tableEventArgs
				}, true, this.DataTable.Name, false);
				IL_30A:
				goto IL_3F8;
				IL_30F:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_3B9:
				goto IL_3ED;
				IL_3BB:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3CB:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_3BB;
			}
			IL_3ED:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3F8:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0013E9EC File Offset: 0x0013CBEC
		internal void <<EMPTY_NAME>>(bool A_0 = true)
		{
			int num;
			int num9;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				int num3 = 1;
				IL_0B:
				num2 = 3;
				this.foxGrid.BeginUpdate();
				IL_18:
				num2 = 4;
				int @fixed = this.foxGrid.Cols.Fixed;
				int num4 = this.foxGrid.Cols.Count - 1;
				for (int i = @fixed; i <= num4; i++)
				{
					IL_45:
					num2 = 5;
					Col col = this.Cols[this.foxGrid.Cols[i].Name];
					IL_6B:
					num2 = 6;
					if (A_0)
					{
						IL_70:
						num2 = 7;
						if (this.TableType == TableTypeEnum.Normal && !this.DataTable.AddByCode)
						{
							IL_87:
							num2 = 8;
							col.o0.O.();
						}
						else
						{
							IL_92:
							num2 = 10;
							if (col.IsDate())
							{
								IL_9E:
								num2 = 11;
								col.SetDateTimeFormat(DateTimeFormatEnum.Date);
							}
						}
					}
					IL_A9:
					num2 = 12;
					this.foxGrid.Cols[i].Caption = col.Caption;
					IL_CA:
					num2 = 13;
					num3 = Math.Max(num3, this.foxGrid.Cols[i].Caption.ToString().Split(new char[]
					{
						'_',
						'＿'
					}).Length);
					IL_10A:
					num2 = 14;
				}
				IL_11C:
				num2 = 15;
				if (!this.DataTable.MultiRowHeader)
				{
					goto IL_142;
				}
				IL_12C:
				num2 = 16;
				this.foxGrid.Rows.Fixed = num3;
				goto IL_156;
				IL_142:
				num2 = 18;
				this.foxGrid.Rows.Fixed = 1;
				IL_156:
				num2 = 19;
				if (num3 <= 1 || !this.DataTable.MultiRowHeader)
				{
					goto IL_256;
				}
				IL_170:
				num2 = 20;
				int num5 = num3 - 1;
				for (int j = 0; j <= num5; j++)
				{
					IL_17D:
					num2 = 21;
					this.foxGrid.Rows[j].AllowMerging = true;
					IL_198:
					num2 = 22;
				}
				IL_1A7:
				num2 = 23;
				int fixed2 = this.foxGrid.Cols.Fixed;
				int num6 = this.foxGrid.Cols.Count - 1;
				for (int k = fixed2; k <= num6; k++)
				{
					IL_1D2:
					num2 = 24;
					string[] array = this.foxGrid.Cols[k].Caption.Split(new char[]
					{
						'_',
						'＿'
					});
					IL_206:
					num2 = 25;
					int num7 = num3 - 1;
					for (int l = 0; l <= num7; l++)
					{
						IL_213:
						num2 = 26;
						this.foxGrid[l, k] = array[Math.Min(l, array.Length - 1)];
						IL_235:
						num2 = 27;
					}
					IL_244:
					num2 = 28;
				}
				IL_256:
				num2 = 29;
				if (this.foxGrid.Col >= this.foxGrid.Cols.Fixed || this.foxGrid.Cols.Count <= this.foxGrid.Cols.Fixed)
				{
					goto IL_2B6;
				}
				IL_298:
				num2 = 30;
				this.foxGrid.Col = this.foxGrid.Cols.Fixed;
				IL_2B6:
				num2 = 31;
				this.foxGrid.EndUpdate();
				IL_2C4:
				goto IL_396;
				IL_2C9:
				int num8 = num9 + 1;
				num9 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8);
				IL_357:
				goto IL_38B;
				IL_359:
				num9 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_369:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num9 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_359;
			}
			IL_38B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_396:
			if (num9 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0013EDB4 File Offset: 0x0013CFB4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildHeader()
		{
			this.O0oO0oo_O_o.Oo.(false);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0013EDC0 File Offset: 0x0013CFC0
		internal void <<EMPTY_NAME>>()
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
				if (this.View.Count == 0)
				{
					goto IL_312;
				}
				IL_19:
				num2 = 4;
				if (this.foxGrid.Col < this.foxGrid.Cols.Fixed)
				{
					goto IL_312;
				}
				IL_3B:
				num2 = 6;
				if (this.foxGrid.Rows[this.foxGrid.Selection.TopRow].DataIndex < 0)
				{
					goto IL_312;
				}
				IL_6C:
				num2 = 8;
				string name = this.foxGrid.Cols[this.foxGrid.Col].Name;
				IL_8F:
				num2 = 9;
				if (!this.AllowEdit || !this.Cols[name].AllowEdit)
				{
					goto IL_312;
				}
				IL_B3:
				num2 = 11;
				this.O_o0OOo_.o0..O__00.__0_O.(new oOOOo0oOOOO_(this, this.foxGrid.Selection));
				IL_D2:
				num2 = 12;
				if (this.foxGrid.Selection.TopRow != this.foxGrid.Selection.BottomRow)
				{
					goto IL_1D5;
				}
				IL_102:
				num2 = 13;
				int dataIndex = this.foxGrid.Rows[this.foxGrid.Selection.TopRow].DataIndex;
				IL_130:
				num2 = 14;
				if (dataIndex <= 0)
				{
					goto IL_312;
				}
				IL_13B:
				num2 = 17;
				if (!this.foxGrid.o000OOo.OO.(this.foxGrid.Selection.TopRow, this.foxGrid.Col))
				{
					goto IL_2EE;
				}
				IL_16D:
				num2 = 18;
				this.View.O0O_0_0__.0O.(dataIndex).Row[name] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(dataIndex - 1)[name]);
				IL_1A2:
				num2 = 19;
				this.foxGrid.O.O0_0.(this.foxGrid.Selection.TopRow, this.foxGrid.Col, null);
				goto IL_2EE;
				IL_1D5:
				num2 = 21;
				DataRowView dataRowView = this.View.O0O_0_0__.0O.(this.foxGrid.Rows[this.foxGrid.Selection.TopRow].DataIndex);
				IL_20E:
				num2 = 22;
				if (dataRowView.Row.IsNull(name))
				{
					goto IL_312;
				}
				IL_223:
				num2 = 24;
				int topRow = this.foxGrid.Selection.TopRow;
				int bottomRow = this.foxGrid.Selection.BottomRow;
				for (int i = topRow; i <= bottomRow; i++)
				{
					IL_257:
					num2 = 25;
					int dataIndex2 = this.foxGrid.Rows[i].DataIndex;
					IL_273:
					num2 = 26;
					if (dataIndex2 >= 0)
					{
						IL_27B:
						num2 = 27;
						if (this.foxGrid.o000OOo.OO.(i, this.foxGrid.Col))
						{
							IL_298:
							num2 = 28;
							this.View.O0O_0_0__.0O.(dataIndex2).Row[name] = RuntimeHelpers.GetObjectValue(dataRowView[name]);
							IL_2C0:
							num2 = 29;
							this.foxGrid.O.O0_0.(i, this.foxGrid.Col, null);
						}
					}
					IL_2DC:
					num2 = 30;
				}
				IL_2EE:
				num2 = 31;
				if (this.View.Position < 0)
				{
					goto IL_312;
				}
				IL_2FF:
				num2 = 32;
				this.View.o_o.O0ooOo.().EndEdit();
				IL_312:
				goto IL_3E8;
				IL_317:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_3A9:
				goto IL_3DD;
				IL_3AB:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_3BB:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3AB;
			}
			IL_3DD:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3E8:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x0013F1DC File Offset: 0x0013D3DC
		internal void <<EMPTY_NAME>>()
		{
			int num;
			int num10;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				DataTable dataTable = this.DataTable;
				IL_10:
				num2 = 3;
				string name = this.foxGrid.Cols[this.foxGrid.Col].Name;
				IL_34:
				num2 = 4;
				if (!this.AllowEdit || !this.Cols[name].AllowEdit)
				{
					goto IL_AE8;
				}
				IL_58:
				num2 = 6;
				if (this.View.Count == 0)
				{
					goto IL_AE8;
				}
				IL_6A:
				num2 = 8;
				if (this.foxGrid.Selection.TopRow != this.foxGrid.Selection.BottomRow)
				{
					goto IL_192;
				}
				IL_99:
				num2 = 9;
				int dataIndex = this.foxGrid.Rows[this.foxGrid.Selection.TopRow].DataIndex;
				IL_C7:
				num2 = 10;
				if (dataIndex != 1)
				{
					goto IL_187;
				}
				IL_D2:
				num2 = 11;
				if (!this.foxGrid.o000OOo.OO.(this.foxGrid.Selection.TopRow, this.foxGrid.Col))
				{
					goto IL_187;
				}
				IL_104:
				num2 = 12;
				this.O_o0OOo_.o0..O__00.__0_O.(new o0o0o00(this, this.View.O0O_0_0__.0O.(1).Row, name));
				IL_12B:
				num2 = 13;
				this.View.O0O_0_0__.0O.(1)[name] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(0)[name]);
				IL_159:
				num2 = 14;
				this.foxGrid.O.O0_0.(this.foxGrid.Selection.TopRow, this.foxGrid.Col, null);
				IL_187:
				num2 = 15;
				if (dataIndex <= 1)
				{
					goto IL_AE8;
				}
				IL_192:
				num2 = 17;
				this.O_o0OOo_.o0..O__00.__0_O.(new oOOOo0oOOOO_(this, this.foxGrid.Selection));
				IL_1B1:
				num2 = 18;
				if (!dataTable.DataCols[name].IsNumeric)
				{
					goto IL_48E;
				}
				IL_1CB:
				num2 = 19;
				if (this.foxGrid.Selection.TopRow != this.foxGrid.Selection.BottomRow)
				{
					goto IL_355;
				}
				IL_1FB:
				num2 = 20;
				int dataIndex2 = this.foxGrid.Rows[this.foxGrid.Selection.TopRow].DataIndex;
				IL_229:
				num2 = 21;
				DataRowView dataRowView = this.View.O0O_0_0__.0O.(dataIndex2 - 2);
				IL_23D:
				num2 = 22;
				DataRowView dataRowView2 = this.View.O0O_0_0__.0O.(dataIndex2 - 1);
				IL_251:
				num2 = 23;
				DataRowView dataRowView3 = this.View.O0O_0_0__.0O.(dataIndex2);
				IL_263:
				num2 = 24;
				if (!this.foxGrid.o000OOo.OO.(this.foxGrid.Selection.TopRow, this.foxGrid.Col))
				{
					goto IL_AC4;
				}
				IL_295:
				num2 = 25;
				if (!(dataRowView.Row.IsNull(name) | dataRowView2.Row.IsNull(name)))
				{
					goto IL_2D8;
				}
				IL_2B7:
				num2 = 26;
				dataRowView3.Row[name] = RuntimeHelpers.GetObjectValue(dataRowView2[name]);
				goto IL_322;
				IL_2D8:
				num2 = 28;
				dataRowView3.Row[name] = decimal.Add(Conversions.ToDecimal(dataRowView2[name]), decimal.Subtract(Conversions.ToDecimal(dataRowView2[name]), Conversions.ToDecimal(dataRowView[name])));
				IL_322:
				num2 = 29;
				this.foxGrid.O.O0_0.(this.foxGrid.Selection.TopRow, this.foxGrid.Col, null);
				goto IL_AC4;
				IL_355:
				num2 = 31;
				DataRowView dataRowView4 = null;
				IL_35B:
				num2 = 32;
				DataRowView dataRowView5 = null;
				IL_361:
				num2 = 33;
				int num3;
				this.o.oO__OO_oo_0_.(ref dataRowView4, ref dataRowView5, ref num3);
				IL_370:
				num2 = 34;
				if (dataRowView5 == null)
				{
					goto IL_AE8;
				}
				IL_37A:
				num2 = 37;
				if (dataRowView4.Row.IsNull(name) | dataRowView5.Row.IsNull(name))
				{
					goto IL_AE8;
				}
				IL_39F:
				num2 = 39;
				double num4 = Conversions.ToDouble(dataRowView5[name]);
				IL_3B2:
				num2 = 40;
				double num5 = num4 - Conversions.ToDouble(dataRowView4[name]);
				IL_3C8:
				num2 = 41;
				int num6 = num3;
				int bottomRow = this.foxGrid.Selection.BottomRow;
				for (int i = num6; i <= bottomRow; i++)
				{
					IL_3EA:
					num2 = 42;
					int dataIndex3 = this.foxGrid.Rows[i].DataIndex;
					IL_406:
					num2 = 43;
					if (dataIndex3 >= 0)
					{
						IL_40E:
						num2 = 44;
						if (this.foxGrid.o000OOo.OO.(i, this.foxGrid.Col))
						{
							IL_42B:
							num2 = 45;
							this.View.O0O_0_0__.0O.(dataIndex3).Row[name] = num4 + num5;
							IL_451:
							num2 = 46;
							this.foxGrid.O.O0_0.(i, this.foxGrid.Col, null);
						}
						IL_46D:
						num2 = 47;
						num4 += num5;
					}
					IL_477:
					num2 = 48;
				}
				goto IL_AC4;
				IL_48E:
				num2 = 50;
				if (!dataTable.DataCols[name].IsDate)
				{
					goto IL_782;
				}
				IL_4A8:
				num2 = 51;
				if (this.foxGrid.Selection.TopRow != this.foxGrid.Selection.BottomRow)
				{
					goto IL_637;
				}
				IL_4D8:
				num2 = 52;
				int dataIndex4 = this.foxGrid.Rows[this.foxGrid.Selection.TopRow].DataIndex;
				IL_506:
				num2 = 53;
				DataRowView dataRowView6 = this.View.O0O_0_0__.0O.(dataIndex4 - 2);
				IL_51A:
				num2 = 54;
				DataRowView dataRowView7 = this.View.O0O_0_0__.0O.(dataIndex4 - 1);
				IL_52E:
				num2 = 55;
				DataRowView dataRowView8 = this.View.O0O_0_0__.0O.(dataIndex4);
				IL_540:
				num2 = 56;
				if (!this.foxGrid.o000OOo.OO.(this.foxGrid.Selection.TopRow, this.foxGrid.Col))
				{
					goto IL_AC4;
				}
				IL_572:
				num2 = 57;
				if (!(dataRowView6.Row.IsNull(name) | dataRowView7.Row.IsNull(name)))
				{
					goto IL_5B5;
				}
				IL_594:
				num2 = 58;
				dataRowView8.Row[name] = RuntimeHelpers.GetObjectValue(dataRowView7[name]);
				goto IL_604;
				IL_5B5:
				num2 = 60;
				dataRowView8.Row[name] = DateAndTime.DateAdd(DateInterval.Day, (double)DateAndTime.DateDiff(DateInterval.Day, Conversions.ToDate(dataRowView6[name]), Conversions.ToDate(dataRowView7[name]), FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1), Conversions.ToDate(dataRowView7[name]));
				IL_604:
				num2 = 61;
				this.foxGrid.O.O0_0.(this.foxGrid.Selection.TopRow, this.foxGrid.Col, null);
				goto IL_AC4;
				IL_637:
				num2 = 63;
				DataRowView dataRowView9 = null;
				IL_63D:
				num2 = 64;
				DataRowView dataRowView10 = null;
				IL_643:
				num2 = 65;
				int num7;
				this.o.oO__OO_oo_0_.(ref dataRowView9, ref dataRowView10, ref num7);
				IL_652:
				num2 = 66;
				if (dataRowView10 == null)
				{
					goto IL_AE8;
				}
				IL_65C:
				num2 = 69;
				if (dataRowView9.Row.IsNull(name) | dataRowView10.Row.IsNull(name))
				{
					goto IL_AE8;
				}
				IL_681:
				num2 = 71;
				DateTime dateTime = Conversions.ToDate(dataRowView10[name]);
				IL_694:
				num2 = 72;
				double number = (double)DateAndTime.DateDiff(DateInterval.Day, Conversions.ToDate(dataRowView9[name]), dateTime, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				IL_6B2:
				num2 = 73;
				int num8 = num7;
				int bottomRow2 = this.foxGrid.Selection.BottomRow;
				for (int j = num8; j <= bottomRow2; j++)
				{
					IL_6D4:
					num2 = 74;
					int dataIndex5 = this.foxGrid.Rows[j].DataIndex;
					IL_6F0:
					num2 = 75;
					if (dataIndex5 >= 0)
					{
						IL_6F8:
						num2 = 76;
						if (this.foxGrid.o000OOo.OO.(j, this.foxGrid.Col))
						{
							IL_715:
							num2 = 77;
							this.View.O0O_0_0__.0O.(dataIndex5).Row[name] = DateAndTime.DateAdd(DateInterval.Day, number, dateTime);
							IL_740:
							num2 = 78;
							this.foxGrid.O.O0_0.(j, this.foxGrid.Col, null);
						}
						IL_75C:
						num2 = 79;
						dateTime = DateAndTime.DateAdd(DateInterval.Day, number, dateTime);
					}
					IL_76B:
					num2 = 80;
				}
				goto IL_AC4;
				IL_782:
				num2 = 82;
				if (!dataTable.DataCols[name].IsString)
				{
					goto IL_AC4;
				}
				IL_79C:
				num2 = 83;
				if (this.foxGrid.Selection.TopRow != this.foxGrid.Selection.BottomRow)
				{
					goto IL_9E4;
				}
				IL_7CC:
				num2 = 84;
				int dataIndex6 = this.foxGrid.Rows[this.foxGrid.Selection.TopRow].DataIndex;
				IL_7FA:
				num2 = 85;
				DataRowView dataRowView11 = this.View.O0O_0_0__.0O.(dataIndex6 - 2);
				IL_80E:
				num2 = 86;
				DataRowView dataRowView12 = this.View.O0O_0_0__.0O.(dataIndex6 - 1);
				IL_822:
				num2 = 87;
				DataRowView dataRowView13 = this.View.O0O_0_0__.0O.(dataIndex6);
				IL_834:
				num2 = 88;
				if (!this.foxGrid.o000OOo.OO.(this.foxGrid.Selection.TopRow, this.foxGrid.Col))
				{
					goto IL_AC4;
				}
				IL_866:
				num2 = 89;
				if (!(dataRowView11.Row.IsNull(name) | dataRowView12.Row.IsNull(name)))
				{
					goto IL_8AC;
				}
				IL_888:
				num2 = 90;
				dataRowView13.Row[name] = RuntimeHelpers.GetObjectValue(dataRowView12[name]);
				goto IL_9B1;
				IL_8AC:
				num2 = 92;
				if (Operators.CompareString(Conversions.ToString(dataRowView11[name]), Conversions.ToString(dataRowView12[name]), true) != 0)
				{
					goto IL_8F7;
				}
				IL_8D3:
				num2 = 93;
				dataRowView13.Row[name] = RuntimeHelpers.GetObjectValue(dataRowView12[name]);
				goto IL_9B1;
				IL_8F7:
				num2 = 95;
				if (!Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Right(Conversions.ToString(dataRowView11[name]), 1)) || !Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Right(Conversions.ToString(dataRowView12[name]), 1)))
				{
					goto IL_955;
				}
				IL_930:
				num2 = 96;
				this.o0O0oo.o.(dataRowView11, dataRowView12, this.foxGrid.Selection.TopRow, name);
				goto IL_9B1;
				IL_955:
				num2 = 98;
				if (!Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Left(Conversions.ToString(dataRowView11[name]), 1)) || !Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Left(Conversions.ToString(dataRowView12[name]), 1)))
				{
					goto IL_9B1;
				}
				IL_98E:
				num2 = 99;
				this.O0o._oo_.(dataRowView11, dataRowView12, this.foxGrid.Selection.TopRow, name);
				IL_9B1:
				num2 = 100;
				this.foxGrid.O.O0_0.(this.foxGrid.Selection.TopRow, this.foxGrid.Col, null);
				goto IL_AC4;
				IL_9E4:
				num2 = 102;
				DataRowView dataRowView14 = null;
				IL_9EA:
				num2 = 103;
				DataRowView dataRowView15 = null;
				IL_9F0:
				num2 = 104;
				int a_;
				this.o.oO__OO_oo_0_.(ref dataRowView14, ref dataRowView15, ref a_);
				IL_9FF:
				num2 = 105;
				if (dataRowView15 == null)
				{
					goto IL_AE8;
				}
				IL_A09:
				num2 = 108;
				if (dataRowView14.Row.IsNull(name) | dataRowView15.Row.IsNull(name))
				{
					goto IL_AE8;
				}
				IL_A2E:
				num2 = 110;
				if (!Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Right(Conversions.ToString(dataRowView14[name]), 1)) || !Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Right(Conversions.ToString(dataRowView15[name]), 1)))
				{
					goto IL_A7A;
				}
				IL_A67:
				num2 = 111;
				this.o0O0oo.o.(dataRowView14, dataRowView15, a_, name);
				goto IL_AC4;
				IL_A7A:
				num2 = 113;
				if (!Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Left(Conversions.ToString(dataRowView14[name]), 1)) || !Versioned.IsNumeric(Microsoft.VisualBasic.Strings.Left(Conversions.ToString(dataRowView15[name]), 1)))
				{
					goto IL_AC4;
				}
				IL_AB3:
				num2 = 114;
				this.O0o._oo_.(dataRowView14, dataRowView15, a_, name);
				IL_AC4:
				num2 = 115;
				if (this.View.Position < 0)
				{
					goto IL_AE8;
				}
				IL_AD5:
				num2 = 116;
				this.View.o_o.O0ooOo.().EndEdit();
				IL_AE8:
				goto IL_D0E;
				IL_AED:
				int num9 = num10 + 1;
				num10 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9);
				IL_CCF:
				goto IL_D03;
				IL_CD1:
				num10 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_CE1:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num10 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_CD1;
			}
			IL_D03:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_D0E:
			if (num10 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x0013FF1C File Offset: 0x0013E11C
		private void <<EMPTY_NAME>>(DataRowView A_0, DataRowView A_1, int A_2, string A_3)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = Conversions.ToString(A_0[A_3]);
				IL_17:
				num2 = 3;
				string text2 = Conversions.ToString(A_1[A_3]);
				IL_28:
				num2 = 4;
				string str = null;
				IL_2D:
				num2 = 5;
				string text3 = null;
				IL_32:
				num2 = 6;
				int num3 = Math.Min(text.Length, text2.Length);
				IL_48:
				num2 = 7;
				int index = this.foxGrid.Cols[A_3].Index;
				IL_63:
				num2 = 8;
				for (int i = num3 - 1; i >= 0; i += -1)
				{
					IL_6D:
					num2 = 9;
					if (!Versioned.IsNumeric(text.Substring(i, 1)) || !Versioned.IsNumeric(text2.Substring(i, 1)))
					{
						IL_A4:
						num2 = 12;
						str = Microsoft.VisualBasic.Strings.Left(text, i + 1);
						IL_B3:
						num2 = 13;
						text = text.Substring(i + 1);
						IL_C1:
						num2 = 14;
						text2 = text2.Substring(i + 1);
						break;
					}
					IL_91:
					num2 = 10;
					text3 += "0";
					IL_D3:
					num2 = 16;
				}
				IL_E1:
				num2 = 17;
				long num4 = Conversions.ToLong(text2);
				IL_ED:
				num2 = 18;
				long num5 = Conversions.ToLong(text2) - Conversions.ToLong(text);
				IL_100:
				num2 = 19;
				int bottomRow = this.foxGrid.Selection.BottomRow;
				for (int j = A_2; j <= bottomRow; j++)
				{
					IL_121:
					num2 = 20;
					int dataIndex = this.foxGrid.Rows[j].DataIndex;
					IL_13D:
					num2 = 21;
					if (dataIndex >= 0)
					{
						IL_145:
						num2 = 22;
						if (this.foxGrid.o000OOo.OO.(j, index))
						{
							IL_159:
							num2 = 23;
							this.View.O0O_0_0__.0O.(dataIndex).Row[A_3] = str + Microsoft.VisualBasic.Strings.Format(num4 + num5, text3);
							IL_18D:
							num2 = 24;
							this.foxGrid.O.O0_0.(j, index, null);
						}
						IL_1A0:
						num2 = 25;
						num4 += num5;
					}
					IL_1AA:
					num2 = 26;
				}
				IL_1BC:
				goto IL_27A;
				IL_1C1:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_23B:
				goto IL_26F;
				IL_23D:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_24D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_23D;
			}
			IL_26F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_27A:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x001401C8 File Offset: 0x0013E3C8
		private void <<EMPTY_NAME>>(DataRowView A_0, DataRowView A_1, int A_2, string A_3)
		{
			int num;
			int num8;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				string text = Conversions.ToString(A_0[A_3]);
				IL_17:
				num2 = 3;
				string text2 = Conversions.ToString(A_1[A_3]);
				IL_28:
				num2 = 4;
				string str = null;
				IL_2D:
				num2 = 5;
				string text3 = null;
				IL_32:
				num2 = 6;
				int num3 = Math.Min(text.Length, text2.Length);
				IL_48:
				num2 = 7;
				int index = this.foxGrid.Cols[A_3].Index;
				IL_63:
				num2 = 8;
				int num4 = num3 - 1;
				for (int i = 0; i <= num4; i++)
				{
					IL_70:
					num2 = 9;
					if (!Versioned.IsNumeric(text.Substring(i, 1)) || !Versioned.IsNumeric(text2.Substring(i, 1)))
					{
						IL_A7:
						num2 = 12;
						str = text.Substring(i);
						IL_B4:
						num2 = 13;
						text = text.Substring(0, i);
						IL_C1:
						num2 = 14;
						text2 = text2.Substring(0, i);
						break;
					}
					IL_94:
					num2 = 10;
					text3 += "0";
					IL_D2:
					num2 = 16;
				}
				IL_E1:
				num2 = 17;
				long num5 = Conversions.ToLong(text2);
				IL_ED:
				num2 = 18;
				long num6 = Conversions.ToLong(text2) - Conversions.ToLong(text);
				IL_100:
				num2 = 19;
				int bottomRow = this.foxGrid.Selection.BottomRow;
				for (int j = A_2; j <= bottomRow; j++)
				{
					IL_121:
					num2 = 20;
					int dataIndex = this.foxGrid.Rows[j].DataIndex;
					IL_13D:
					num2 = 21;
					if (dataIndex >= 0)
					{
						IL_145:
						num2 = 22;
						if (this.foxGrid.o000OOo.OO.(j, index))
						{
							IL_159:
							num2 = 23;
							this.View.O0O_0_0__.0O.(dataIndex).Row[A_3] = Microsoft.VisualBasic.Strings.Format(num5 + num6, text3) + str;
							IL_18D:
							num2 = 24;
							this.foxGrid.O.O0_0.(j, index, null);
						}
						IL_1A0:
						num2 = 25;
						num5 += num6;
					}
					IL_1AA:
					num2 = 26;
				}
				IL_1BC:
				goto IL_27A;
				IL_1C1:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_23B:
				goto IL_26F;
				IL_23D:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_24D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_23D;
			}
			IL_26F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_27A:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00140474 File Offset: 0x0013E674
		private void <<EMPTY_NAME>>(ref DataRowView A_0, ref DataRowView A_1, ref int A_2)
		{
			int topRow = this.foxGrid.Selection.TopRow;
			int bottomRow = this.foxGrid.Selection.BottomRow;
			for (int i = topRow; i <= bottomRow; i++)
			{
				if (this.foxGrid.Rows[i].DataIndex >= 0)
				{
					if (A_0 == null)
					{
						A_0 = this.View.O0O_0_0__.0O.(this.foxGrid.Rows[i].DataIndex);
					}
					else if (A_1 == null)
					{
						A_1 = this.View.O0O_0_0__.0O.(this.foxGrid.Rows[i].DataIndex);
						A_2 = i + 1;
						return;
					}
				}
			}
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00140524 File Offset: 0x0013E724
		private string <<EMPTY_NAME>>(int A_0, int A_1, DateGroupEnum A_2)
		{
			string result;
			if (this.foxGrid[A_0, A_1] == null || this.foxGrid[A_0, A_1] == DBNull.Value)
			{
				result = null;
			}
			else
			{
				DateTime dateTime = Conversions.ToDate(this.foxGrid[A_0, A_1]);
				switch (A_2)
				{
				case DateGroupEnum.Year:
					result = dateTime.Year.ToString();
					break;
				case DateGroupEnum.Quarter:
					result = DateAndTime.DatePart(DateInterval.Quarter, dateTime, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
					break;
				case DateGroupEnum.Month:
					result = dateTime.Month.ToString();
					break;
				case DateGroupEnum.Week:
					result = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString();
					break;
				case DateGroupEnum.Day:
					result = dateTime.Day.ToString();
					break;
				case DateGroupEnum.Hour:
					result = dateTime.Hour.ToString();
					break;
				case DateGroupEnum.Minute:
					result = dateTime.Minute.ToString();
					break;
				case DateGroupEnum.Second:
					result = dateTime.Second.ToString();
					break;
				default:
					result = dateTime.ToString();
					break;
				}
			}
			return result;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x00140648 File Offset: 0x0013E848
		private void <<EMPTY_NAME>>(object A_0, PrintPageEventArgs A_1)
		{
			if (this.O.OoOo_. != null)
			{
				this.O.OoOo_.++;
				this.O.OoOo_..Oo0._.("已经完成" + Conversions.ToString(this.O.OoOo_.) + "页...");
				if (this.O.OoOo_..Ooo_oo._o.())
				{
					A_1.HasMorePages = false;
				}
			}
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x001406A4 File Offset: 0x0013E8A4
		private string <<EMPTY_NAME>>(string A_0)
		{
			string result;
			if (string.IsNullOrEmpty(A_0))
			{
				result = "";
			}
			else
			{
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "|", "\t");
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[PageNo]", "{0}");
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[PageCount]", "{1}");
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Today]", Microsoft.VisualBasic.Strings.Format(DateTime.Today, "yyyy-MM-dd"));
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Time]", Microsoft.VisualBasic.Strings.Format(DateTime.Now, "HH:mm:ss"));
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[ShortTime]", Microsoft.VisualBasic.Strings.Format(DateTime.Now, "HH:mm"));
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Year]", DateTime.Today.Year.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Month]", DateTime.Today.Month.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Day]", DateTime.Today.Day.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Hour]", DateTime.Now.Hour.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Minute]", DateTime.Now.Minute.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[Second]", DateTime.Now.Second.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[WeekDay]", DateTime.Today.DayOfWeek.ToString());
				A_0 = ShareLibriay.ReplaceIgnoreCase(A_0, "[TableName]", this.oO._0ooO_o0_..Table.DataTable.Name);
				result = A_0;
			}
			return result;
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00140878 File Offset: 0x0013EA78
		internal void <<EMPTY_NAME>>(int A_0, int A_1, int A_2, bool A_3 = true)
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
				O_oOooO_O o_oOooO_O = this.foxGrid;
				IL_10:
				num2 = 3;
				if (A_0 > A_1 || A_0 < o_oOooO_O.Cols.Fixed || A_1 > o_oOooO_O.Cols.Count - 1)
				{
					goto IL_267;
				}
				IL_3D:
				num2 = 5;
				if (A_2 >= A_0 && A_2 <= A_1)
				{
					goto IL_267;
				}
				IL_4A:
				num2 = 7;
				DragColumnEventArgs dragColumnEventArgs = new DragColumnEventArgs(this, A_0 - o_oOooO_O.Cols.Fixed, A_1 - o_oOooO_O.Cols.Fixed, A_2 - o_oOooO_O.Cols.Fixed);
				IL_7B:
				num2 = 8;
				string a_ = "BeforeDragColumn";
				IL_84:
				num2 = 9;
				O_O0OO.OoO_o.oO0o0O.(this.DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					dragColumnEventArgs
				}, false, this.DataTable.Name, false);
				IL_B2:
				num2 = 10;
				if (dragColumnEventArgs.Cancel || !this.DataTable.GlobalHandler.BeforeDragColumn)
				{
					goto IL_F2;
				}
				IL_D0:
				num2 = 11;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					dragColumnEventArgs
				}, false, "全局表事件", false);
				IL_F2:
				num2 = 12;
				if (dragColumnEventArgs.Cancel)
				{
					goto IL_267;
				}
				IL_101:
				num2 = 14;
				if (dragColumnEventArgs.Cancel)
				{
					goto IL_267;
				}
				IL_110:
				num2 = 16;
				A_2 = dragColumnEventArgs.Position + o_oOooO_O.Cols.Fixed;
				IL_128:
				num2 = 17;
				if (A_2 >= A_0 && A_2 <= A_1)
				{
					goto IL_267;
				}
				IL_136:
				num2 = 19;
				o_0oOOOOO__ a_2 = new o_0oOOOOO__(this, A_0, A_1, A_2);
				IL_144:
				num2 = 20;
				if (!(A_2 < A_0 & A_2 >= o_oOooO_O.Cols.Fixed))
				{
					goto IL_190;
				}
				IL_15F:
				num2 = 21;
				for (int i = A_0; i <= A_1; i++)
				{
					IL_16A:
					num2 = 22;
					o_oOooO_O.Cols[A_1].Move(A_2);
					IL_17F:
					num2 = 23;
				}
				goto IL_1DF;
				IL_190:
				num2 = 25;
				if (!(A_2 > A_0 & A_2 <= o_oOooO_O.Cols.Count - 1))
				{
					goto IL_267;
				}
				IL_1B0:
				num2 = 26;
				for (int j = A_0; j <= A_1; j++)
				{
					IL_1BB:
					num2 = 27;
					o_oOooO_O.Cols[A_0].Move(A_2);
					IL_1D0:
					num2 = 28;
				}
				IL_1DF:
				num2 = 31;
				if (!A_3)
				{
					goto IL_1F6;
				}
				IL_1E6:
				num2 = 32;
				this.O_o0OOo_.o0..O__00.__0_O.(a_2);
				IL_1F6:
				num2 = 33;
				a_ = "AfterDragColumn";
				IL_200:
				num2 = 34;
				O_O0OO.OoO_o.oO0o0O.(this.DataTable.o_0_00_.oo0O0., a_, new object[]
				{
					dragColumnEventArgs
				}, false, this.DataTable.Name, false);
				IL_22E:
				num2 = 35;
				if (!this.DataTable.GlobalHandler.AfterDragColumn)
				{
					goto IL_265;
				}
				IL_243:
				num2 = 36;
				O_O0OO.OoO_o.oO0o0O.(O_O0OO.oo0_o_.o., a_, new object[]
				{
					dragColumnEventArgs
				}, false, "全局表事件", false);
				IL_265:
				o_oOooO_O = null;
				IL_267:
				goto IL_351;
				IL_26C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_312:
				goto IL_346;
				IL_314:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_324:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_314;
			}
			IL_346:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_351:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x00140BFC File Offset: 0x0013EDFC
		// (set) Token: 0x06002C19 RID: 11289 RVA: 0x00140C04 File Offset: 0x0013EE04
		internal DockAreaEnum _frdDockArea
		{
			get
			{
				return this.o0__OOo0._oO.;
			}
			set
			{
				this.o0__OOo0._oO. = value;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x00140C0D File Offset: 0x0013EE0D
		// (set) Token: 0x06002C1B RID: 11291 RVA: 0x00140C15 File Offset: 0x0013EE15
		internal bool _frdDockTitle
		{
			get
			{
				return this.O0oooo_o0o0.o.;
			}
			set
			{
				this.O0oooo_o0o0.o. = value;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002C1C RID: 11292 RVA: 0x00140C1E File Offset: 0x0013EE1E
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x00140C26 File Offset: 0x0013EE26
		internal bool _frdAutoHide
		{
			get
			{
				return this.ooo.__00__0.;
			}
			set
			{
				this.ooo.__00__0. = value;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x00140C2F File Offset: 0x0013EE2F
		// (set) Token: 0x06002C1F RID: 11295 RVA: 0x00140C37 File Offset: 0x0013EE37
		internal bool _frdShowCaption
		{
			get
			{
				return this.Oo_oo_.o_.;
			}
			set
			{
				this.Oo_oo_.o_. = value;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002C20 RID: 11296 RVA: 0x00140C40 File Offset: 0x0013EE40
		// (set) Token: 0x06002C21 RID: 11297 RVA: 0x00140C48 File Offset: 0x0013EE48
		internal bool _frdAllowClose
		{
			get
			{
				return this.OO0.O__.;
			}
			set
			{
				this.OO0.O__. = value;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x00140C51 File Offset: 0x0013EE51
		// (set) Token: 0x06002C23 RID: 11299 RVA: 0x00140C5E File Offset: 0x0013EE5E
		internal Image _frdIcon
		{
			get
			{
				return this.DataTable.frd_Icon;
			}
			set
			{
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002C24 RID: 11300 RVA: 0x00140C60 File Offset: 0x0013EE60
		// (set) Token: 0x06002C25 RID: 11301 RVA: 0x00140C68 File Offset: 0x0013EE68
		internal bool _frdAutoOpen
		{
			get
			{
				return this.o.OO0O0O.;
			}
			set
			{
				this.o.OO0O0O. = value;
			}
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00140C74 File Offset: 0x0013EE74
		internal decimal <<EMPTY_NAME>>(Table A_0, params decimal[] A_1)
		{
			int num;
			decimal result;
			int num10;
			object obj2;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				decimal num3 = A_1[0];
				IL_12:
				num2 = 3;
				decimal num4 = A_1[1];
				IL_1D:
				num2 = 4;
				int num5 = 1;
				IL_22:
				num2 = 5;
				foreach (decimal num6 in A_1)
				{
					IL_37:
					num2 = 6;
					string text = num6.ToString().Trim(new char[]
					{
						'0'
					});
					IL_52:
					num2 = 7;
					num5 = Math.Max(num5, text.Length - text.IndexOf(".") - 1);
					IL_73:
					num2 = 8;
				}
				IL_83:
				num2 = 9;
				decimal num6 = decimal.Subtract(num4, Convert.ToDecimal(1.0 / Math.Pow(10.0, (double)num5)));
				IL_AF:
				num2 = 10;
				if (decimal.Compare(num6, num3) > 0 && decimal.Compare(num6, num4) < 0)
				{
					goto IL_364;
				}
				IL_CD:
				num2 = 11;
				if (num5 + 1 <= 14 && decimal.Compare(num3, num4) != 0)
				{
					goto IL_30D;
				}
				IL_E6:
				num2 = 12;
				A_0.StopRedraw();
				IL_EF:
				num2 = 13;
				OO_00oOO.SystemReady = false;
				IL_F8:
				num2 = 14;
				string rowFilter = A_0.View.o_o.O0ooOo.().RowFilter;
				IL_10D:
				num2 = 15;
				A_0.View.o_o.O0ooOo.().RowFilter = "False";
				IL_125:
				num2 = 16;
				object obj = this.DataTable.BaseTable;
				DataRow[] array;
				lock (obj)
				{
					array = this.DataTable.BaseTable.Select("[_SortKey] >= " + Conversions.ToString(Math.Floor(num3)) + " And [_SortKey] <= " + Conversions.ToString(Math.Ceiling(num4)), "_SortKey");
				}
				IL_18D:
				num2 = 17;
				int num7 = array.Length;
				IL_196:
				num2 = 18;
				num5 = Convert.ToInt32(Math.Floor(Math.Log10((double)array.Length) + 1.0));
				IL_1B9:
				num2 = 19;
				int num8 = array.Length - 1;
				for (int j = 0; j <= num8; j++)
				{
					IL_1CC:
					num2 = 20;
					if (decimal.Compare(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(array[j]["_SortKey"])), num3) == 0 && num7 == array.Length)
					{
						IL_1F9:
						num2 = 21;
						num6 = decimal.Add(Math.Floor(num3), Convert.ToDecimal(1.0 / Math.Pow(10.0, (double)num5) * (double)(j + 1)));
						IL_230:
						num2 = 22;
						num7 = j;
					}
					IL_237:
					num2 = 23;
					if (j <= num7)
					{
						IL_240:
						num2 = 24;
						array[j]["_SortKey"] = decimal.Add(Math.Floor(num3), Convert.ToDecimal(1.0 / Math.Pow(10.0, (double)num5) * (double)j));
					}
					else
					{
						IL_289:
						num2 = 26;
						array[j]["_SortKey"] = decimal.Add(Math.Floor(num3), Convert.ToDecimal(1.0 / Math.Pow(10.0, (double)num5) * (double)(j + 1)));
					}
					IL_2D2:
					num2 = 27;
				}
				IL_2E4:
				num2 = 28;
				A_0.View.o_o.O0ooOo.().RowFilter = rowFilter;
				IL_2F9:
				num2 = 29;
				OO_00oOO.SystemReady = true;
				IL_302:
				num2 = 30;
				A_0.ResumeRedraw();
				goto IL_364;
				IL_30D:
				num2 = 32;
				if (num5 % 3 != 0)
				{
					goto IL_321;
				}
				IL_316:
				num2 = 33;
				num5++;
				goto IL_32A;
				IL_321:
				num2 = 35;
				num5 += 2;
				IL_32A:
				num2 = 36;
				num5 = Math.Min(num5, 14);
				IL_338:
				num2 = 37;
				num6 = decimal.Subtract(num4, Convert.ToDecimal(1.0 / Math.Pow(10.0, (double)num5)));
				IL_364:
				num2 = 38;
				result = num6;
				IL_36A:
				goto IL_458;
				IL_36F:
				int num9 = num10 + 1;
				num10 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9);
				IL_419:
				goto IL_44D;
				IL_41B:
				num10 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_42B:;
			}
			catch when (endfilter(obj2 is Exception & num != 0 & num10 == 0))
			{
				Exception ex = (Exception)obj3;
				goto IL_41B;
			}
			IL_44D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_458:
			if (num10 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00141118 File Offset: 0x0013F318
		internal void <<EMPTY_NAME>>(string A_0, string A_1)
		{
			int num;
			int num14;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				IEnumerator<SubtotalGroup> enumerator = this.SubtotalGroups.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SubtotalGroup subtotalGroup = enumerator.Current;
					IL_22:
					num2 = 3;
					if (Operators.CompareString(subtotalGroup.GroupOn, A_0, true) == 0)
					{
						IL_34:
						num2 = 4;
						subtotalGroup.GroupOn = A_1;
					}
					IL_3E:
					num2 = 5;
					if (Operators.CompareString(subtotalGroup.TotalOn, "", true) > 0)
					{
						IL_58:
						num2 = 6;
						string[] array = subtotalGroup.TotalOn.Split(new char[]
						{
							','
						});
						IL_73:
						num2 = 7;
						int num3 = array.Length - 1;
						for (int i = 0; i <= num3; i++)
						{
							IL_82:
							num2 = 8;
							if (Operators.CompareString(array[i], A_0, true) == 0)
							{
								IL_92:
								num2 = 9;
								array[i] = A_1;
							}
							IL_9B:
							num2 = 10;
						}
						IL_AA:
						num2 = 11;
						subtotalGroup.TotalOn = array[0];
						IL_B8:
						num2 = 12;
						int num4 = array.Length - 1;
						for (int j = 1; j <= num4; j++)
						{
							IL_C8:
							num2 = 13;
							subtotalGroup.TotalOn = subtotalGroup.TotalOn + "," + array[j];
							IL_E8:
							num2 = 14;
						}
					}
					IL_F7:
					num2 = 15;
				}
				IL_105:
				num2 = 16;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_111:
				num2 = 17;
				int num5 = this.MergeCols.Count - 1;
				for (int k = 0; k <= num5; k++)
				{
					IL_128:
					num2 = 18;
					if (Operators.CompareString(this.MergeCols[k], A_0, true) == 0)
					{
						IL_141:
						num2 = 19;
						this.MergeCols[k] = A_1;
					}
					IL_152:
					num2 = 20;
				}
				IL_161:
				num2 = 21;
				if (this.O_0._O_0OO000O. == null)
				{
					goto IL_241;
				}
				IL_16F:
				num2 = 22;
				int num6 = this.O_0._O_0OO000O..Groups.Count - 1;
				for (int l = 0; l <= num6; l++)
				{
					IL_18B:
					num2 = 23;
					if (Operators.CompareString(this.O_0._O_0OO000O..Groups[l].Name, A_0, true) == 0)
					{
						IL_1AE:
						num2 = 24;
						this.O_0._O_0OO000O..Groups[l].Name = A_1;
					}
					IL_1C9:
					num2 = 25;
				}
				IL_1D8:
				num2 = 26;
				int num7 = this.O_0._O_0OO000O..Totals.Count - 1;
				for (int m = 0; m <= num7; m++)
				{
					IL_1F4:
					num2 = 27;
					if (Operators.CompareString(this.O_0._O_0OO000O..Totals[m].Name, A_0, true) == 0)
					{
						IL_217:
						num2 = 28;
						this.O_0._O_0OO000O..Totals[m].Name = A_1;
					}
					IL_232:
					num2 = 29;
				}
				IL_241:
				num2 = 30;
				if (this.O_0._O_0OO000O. == null)
				{
					goto IL_38A;
				}
				IL_24F:
				num2 = 31;
				int num8 = this.O_0._O_0OO000O..HGroups.Count - 1;
				for (int n = 0; n <= num8; n++)
				{
					IL_26B:
					num2 = 32;
					if (Operators.CompareString(this.O_0._O_0OO000O..HGroups[n].Name, A_0, true) == 0)
					{
						IL_28E:
						num2 = 33;
						this.O_0._O_0OO000O..HGroups[n].Name = A_1;
					}
					IL_2A9:
					num2 = 34;
				}
				IL_2B8:
				num2 = 35;
				int num9 = this.O_0._O_0OO000O..VGroups.Count - 1;
				for (int num10 = 0; num10 <= num9; num10++)
				{
					IL_2D4:
					num2 = 36;
					if (Operators.CompareString(this.O_0._O_0OO000O..VGroups[num10].Name, A_0, true) == 0)
					{
						IL_2F7:
						num2 = 37;
						this.O_0._O_0OO000O..VGroups[num10].Name = A_1;
					}
					IL_312:
					num2 = 38;
				}
				IL_321:
				num2 = 39;
				int num11 = this.O_0._O_0OO000O..Totals.Count - 1;
				for (int num12 = 0; num12 <= num11; num12++)
				{
					IL_33D:
					num2 = 40;
					if (Operators.CompareString(this.O_0._O_0OO000O..Totals[num12].Name, A_0, true) == 0)
					{
						IL_360:
						num2 = 41;
						this.O_0._O_0OO000O..Totals[num12].Name = A_1;
					}
					IL_37B:
					num2 = 42;
				}
				IL_38A:
				goto IL_488;
				IL_38F:
				int num13 = num14 + 1;
				num14 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num13);
				IL_449:
				goto IL_47D;
				IL_44B:
				num14 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_45B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num14 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_44B;
			}
			IL_47D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_488:
			if (num14 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 设置标题行高度
		/// </summary>
		/// <param name="Heights">各标题行高度</param>
		// Token: 0x06002C28 RID: 11304 RVA: 0x001415D4 File Offset: 0x0013F7D4
		[oO0oooo("1548")]
		public void SetHeaderRowHeight(params int[] Heights)
		{
			int num = Math.Min(Heights.Length - 1, this.foxGrid.Rows.Fixed - 1);
			for (int i = 0; i <= num; i++)
			{
				this.foxGrid.Rows[i].Height = Heights[i];
			}
		}

		/// <summary>
		/// 自动调整标题行高度
		/// </summary>
		// Token: 0x06002C29 RID: 11305 RVA: 0x00141624 File Offset: 0x0013F824
		[oO0oooo("1551")]
		public void AutoSizeHeaderRow()
		{
			int num = this.foxGrid.Rows.Fixed - 1;
			for (int i = 0; i <= num; i++)
			{
				this.foxGrid.AutoSizeRow(i);
			}
		}

		/// <summary>
		/// 自动调整行高
		/// </summary>
		/// <param name="extraSpace">在自动计算得出的行高基础上，额外增加指定数值的高度</param>
		// Token: 0x06002C2A RID: 11306 RVA: 0x0014165C File Offset: 0x0013F85C
		[oO0oooo("1552")]
		public void AutoSizeRows(int extraSpace = 2)
		{
			O_oOooO_O o_oOooO_O = this.foxGrid;
			o_oOooO_O.AutoSizeRows(o_oOooO_O.Rows.Fixed, o_oOooO_O.Cols.Fixed, o_oOooO_O.Rows.Count - 1, o_oOooO_O.Cols.Count - 1, extraSpace, AutoSizeFlags.IgnoreHidden | AutoSizeFlags.IgnoreMerged);
		}

		/// <summary>
		/// 自动调整指定行高度
		/// </summary>
		/// <param name="Index">行位置</param>
		// Token: 0x06002C2B RID: 11307 RVA: 0x001416AA File Offset: 0x0013F8AA
		[oO0oooo("1564")]
		public void AutoSizeRow(int Index)
		{
			O_oOooO_O o_oOooO_O = this.foxGrid;
			o_oOooO_O.AutoSizeRow(o_oOooO_O.Rows.Fixed + Index);
		}

		/// <summary>
		/// 自动调整列宽
		/// </summary>
		/// <param name="extraSpace">在自动计算得出的列宽基础上，额外增加指定数值的宽度</param>
		// Token: 0x06002C2C RID: 11308 RVA: 0x001416C8 File Offset: 0x0013F8C8
		[oO0oooo("1554")]
		public void AutoSizeCols(int extraSpace = 2)
		{
			this.foxGrid;
			O_oOooO_O o_oOooO_O = this.foxGrid;
			o_oOooO_O.AutoSizeCols(0, o_oOooO_O.Cols.Fixed, o_oOooO_O.Rows.Count - 1, o_oOooO_O.Cols.Count - 1, extraSpace, AutoSizeFlags.IgnoreHidden);
		}

		/// <summary>
		/// 自动调整指定列宽度
		/// </summary>
		/// <param name="ColName">列名</param>
		/// <param name="extraSpace">在自动计算得出的列宽基础上，额外增加指定数值的宽度</param>
		// Token: 0x06002C2D RID: 11309 RVA: 0x00141718 File Offset: 0x0013F918
		[oO0oooo("1553")]
		public void AutoSizeCol(string ColName, int extraSpace = 2)
		{
			int index = this.foxGrid.Cols[ColName].Index;
			this.foxGrid.AutoSizeCol(index, extraSpace);
		}

		/// <summary>
		/// 设置指定列的标题的字体
		/// </summary>
		/// <param name="ColName">列名</param>
		/// <param name="font">字体</param>
		/// <param name="level">如果存在多层表头，可以用此参数指定要设置的是哪一层的标题</param>
		// Token: 0x06002C2E RID: 11310 RVA: 0x0014174C File Offset: 0x0013F94C
		[oO0oooo("1550")]
		public void SetHeaderCellFont(string ColName, Font font, int level = 0)
		{
			int index = this.foxGrid.Cols[ColName].Index;
			this.foxGrid.GetCellRange(level, index).StyleNew.Font = font;
		}

		/// <summary>
		/// 设置指定列的标题的字体颜色
		/// </summary>
		/// <param name="ColName">列名</param>
		/// <param name="color">颜色</param>
		/// <param name="level">如果存在多层表头，可以用此参数指定要设置的是哪一层的标题</param>
		// Token: 0x06002C2F RID: 11311 RVA: 0x0014178C File Offset: 0x0013F98C
		[oO0oooo("1549")]
		public void SetHeaderCellForeColor(string ColName, Color color, int level = 0)
		{
			int index = this.foxGrid.Cols[ColName].Index;
			this.foxGrid.GetCellRange(level, index).StyleNew.ForeColor = color;
		}

		/// <summary>
		/// 设置指定列的标题的背景颜色
		/// </summary>
		/// <param name="ColName"></param>
		/// <param name="color">颜色</param>
		/// <param name="Level">如果存在多层表头，可以用此参数指定要设置的是哪一层的标题</param>
		// Token: 0x06002C30 RID: 11312 RVA: 0x001417CC File Offset: 0x0013F9CC
		[oO0oooo("2066")]
		public void SetHeaderCellBackColor(string ColName, Color color, int Level = 0)
		{
			int index = this.foxGrid.Cols[ColName].Index;
			this.foxGrid.GetCellRange(Level, index).StyleNew.BackColor = color;
		}

		/// <summary>
		/// Table的类型
		/// </summary>
		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x0014180B File Offset: 0x0013FA0B
		// (set) Token: 0x06002C32 RID: 11314 RVA: 0x00141813 File Offset: 0x0013FA13
		[oO0oooo("1779")]
		public TableTypeEnum TableType
		{
			get
			{
				return this.oO._0ooO_o0_.;
			}
			internal set
			{
				this.oO._0ooO_o0_. = value;
			}
		}

		/// <summary>
		/// 是否是副本Table
		/// </summary>
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x0014181C File Offset: 0x0013FA1C
		[oO0oooo("1780")]
		public bool IsCopy
		{
			get
			{
				return this.View.O0O.o__0.();
			}
		}

		/// <summary>
		/// 是否高亮显示当前行
		/// </summary>
		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x00141829 File Offset: 0x0013FA29
		// (set) Token: 0x06002C35 RID: 11317 RVA: 0x00141831 File Offset: 0x0013FA31
		[oO0oooo("1634")]
		public bool ListMode
		{
			get
			{
				return this.oO00__O_.oO.;
			}
			set
			{
				this.oO00__O_.oO. = value;
				if (OO_00oOO.SystemReady)
				{
					this.foxGrid.Oo0._0.();
				}
				this.foxGrid.Invalidate();
			}
		}

		/// <summary>
		/// 是否允许单击列标题排序
		/// </summary>
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x00141857 File Offset: 0x0013FA57
		// (set) Token: 0x06002C37 RID: 11319 RVA: 0x0014185F File Offset: 0x0013FA5F
		[oO0oooo("1774")]
		public bool AllowClickSort
		{
			get
			{
				return this.O_0o__O0O0_0.0.;
			}
			set
			{
				this.O_0o__O0O0_0.0. = value;
			}
		}

		/// <summary>
		/// 是否显示行号列
		/// </summary>
		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x00141868 File Offset: 0x0013FA68
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x00141880 File Offset: 0x0013FA80
		[oO0oooo("1773")]
		public bool RowHeaderVisible
		{
			get
			{
				return this.foxGrid.Cols[0].Visible;
			}
			set
			{
				this.foxGrid.Cols[0].Visible = value;
			}
		}

		/// <summary>
		/// 是否行号列显示复选框
		/// </summary>
		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x00141899 File Offset: 0x0013FA99
		// (set) Token: 0x06002C3B RID: 11323 RVA: 0x001418C0 File Offset: 0x0013FAC0
		[oO0oooo("1635")]
		public bool ShowCheckBox
		{
			get
			{
				return this.foxGrid.Cols[0].DataType == typeof(bool);
			}
			set
			{
				if (value)
				{
					if (this.foxGrid.Cols[0].DataType != typeof(bool))
					{
						this.foxGrid.Cols[0].Width = 25;
						this.foxGrid.Cols[0].DataType = typeof(bool);
						return;
					}
				}
				else if (this.foxGrid.Cols[0].DataType == typeof(bool))
				{
					this.foxGrid.Cols[0].DataType = typeof(string);
					this.foxGrid.O.O00O_oO_OO00.(true);
				}
			}
		}

		/// <summary>
		/// 获取所有复选框已经选中的行
		/// </summary>
		// Token: 0x06002C3C RID: 11324 RVA: 0x0014197C File Offset: 0x0013FB7C
		[oO0oooo("1636")]
		public List<Foxtable.Row> GetCheckedRows()
		{
			List<Foxtable.Row> list = new List<Foxtable.Row>();
			int @fixed = this.foxGrid.Rows.Fixed;
			int num = this.foxGrid.Rows.Count - 1;
			for (int i = @fixed; i <= num; i++)
			{
				if (this.foxGrid.GetCellCheck(i, 0) == CheckEnum.Checked && this.foxGrid.Rows[i].DataIndex >= 0)
				{
					list.Add(new Foxtable.Row(this, this.View.O0O_0_0__.0O.(this.foxGrid.Rows[i].DataIndex)));
				}
			}
			return list;
		}

		/// <summary>
		/// 清除所有行的复选框的选中标记
		/// </summary>
		// Token: 0x06002C3D RID: 11325 RVA: 0x00141A14 File Offset: 0x0013FC14
		[oO0oooo("1637")]
		public void ClearCheckedRows()
		{
			if (this.foxGrid.Cols[0].DataType == typeof(bool))
			{
				int @fixed = this.foxGrid.Rows.Fixed;
				int num = this.foxGrid.Rows.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					if (this.foxGrid.Rows[i].DataIndex >= 0)
					{
						this.foxGrid.SetCellCheck(i, 0, CheckEnum.Unchecked);
					}
				}
			}
		}

		/// <summary>
		/// 动态设置Table绑定的DataTable
		/// </summary>
		// Token: 0x17000A00 RID: 2560
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x00141A98 File Offset: 0x0013FC98
		[oO0oooo("1778")]
		public object DataSource
		{
			set
			{
				int num;
				int num4;
				object obj4;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					object obj = RuntimeHelpers.GetObjectValue(value);
					IL_10:
					num2 = 3;
					DataTable dataTable = null;
					IL_15:
					num2 = 4;
					if (this.TableType == TableTypeEnum.Normal && !this.IsCopy)
					{
						goto IL_974;
					}
					IL_2A:
					num2 = 6;
					this.foxGrid.BeginUpdate();
					IL_37:
					num2 = 7;
					if (!(value is DataTable))
					{
						goto IL_73;
					}
					IL_41:
					num2 = 8;
					DataTable dataTable2 = ((DataTable)value).BaseTable;
					IL_50:
					num2 = 9;
					if (dataTable2.DataSet == O_O0OO.OOOo.oo_OOOO_0.())
					{
						goto IL_73;
					}
					IL_61:
					num2 = 10;
					dataTable = (DataTable)value;
					IL_6C:
					num2 = 11;
					value = dataTable2;
					IL_73:
					num2 = 12;
					if (!(value is DataTable))
					{
						goto IL_307;
					}
					IL_81:
					num2 = 13;
					DataTable dataTable3 = ((DataTable)value).BaseTable;
					IL_91:
					num2 = 14;
					if (this.TableType == TableTypeEnum.Normal)
					{
						goto IL_FF;
					}
					IL_9C:
					num2 = 15;
					if (this.DataTable.BaseTable.DataSet != O_O0OO.OOOo.oo_OOOO_0.() || Operators.CompareString(this.DataTable.BaseTable.TableName, this.Name, true) != 0)
					{
						goto IL_EC;
					}
					IL_D4:
					num2 = 16;
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(this.Name);
					IL_EC:
					num2 = 17;
					OO_00oOO.DataTables.OoO_00.O.(this.Name);
					IL_FF:
					num2 = 18;
					this.TableType = TableTypeEnum.Normal;
					IL_109:
					num2 = 19;
					O_0 o_ = O_O0OO.o__.O.()[this.View.Oo._Oo0OO.()];
					IL_123:
					num2 = 20;
					O_O0OO.o__.O.().Remove(this.View.Oo._Oo0OO.());
					IL_13C:
					num2 = 21;
					O_0 dataSource = new O_0(dataTable3, this.View.Oo._Oo0OO.());
					IL_153:
					num2 = 22;
					this.o.0ooOO_0__. = dataSource;
					IL_15E:
					num2 = 23;
					this.o.0ooOO_0__..O00o0.0_0O_.();
					IL_16C:
					num2 = 24;
					this.foxGrid.DataSource = dataSource;
					IL_17C:
					num2 = 25;
					this.Cols.Reset();
					IL_18A:
					num2 = 26;
					this.oO_o_0o._0oooo.(true);
					IL_194:
					num2 = 27;
					IEnumerator enumerator = ((IEnumerable)this.foxGrid.Styles).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						CellStyle cellStyle = (CellStyle)obj2;
						IL_1B9:
						num2 = 28;
						if (Operators.CompareString(Conversions.ToString(cellStyle.UserData), "User", true) == 0)
						{
							IL_1D5:
							num2 = 29;
							this.foxGrid.Styles.Remove(cellStyle);
						}
						IL_1EA:
						num2 = 30;
					}
					IL_1F6:
					num2 = 31;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					IL_20E:
					num2 = 32;
					if (!OO_00oOO.Tables.get_Contains(dataTable3.TableName))
					{
						goto IL_2DC;
					}
					IL_227:
					num2 = 33;
					IEnumerator enumerator2 = ((IEnumerable)OO_00oOO.Tables[dataTable3.TableName].Grid.Styles).GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object obj3 = enumerator2.Current;
						CellStyle cellStyle2 = (CellStyle)obj3;
						IL_25C:
						num2 = 34;
						if (!this.foxGrid.Styles.Contains(cellStyle2.Name))
						{
							IL_278:
							num2 = 35;
							this.foxGrid.Styles.Add(cellStyle2.Name, cellStyle2);
						}
						else
						{
							IL_297:
							num2 = 37;
							this.foxGrid.Styles[cellStyle2.Name].MergeWith(cellStyle2);
						}
						IL_2B8:
						num2 = 38;
					}
					IL_2C4:
					num2 = 39;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
					IL_2DC:
					num2 = 40;
					this.View.o_._0O0o_OoO.();
					IL_2EA:
					num2 = 41;
					this.View.Oo._Oo0OO.();
					IL_2F8:
					num2 = 42;
					o_.Dispose();
					goto IL_7D5;
					IL_307:
					num2 = 44;
					if (!(value is DataTable))
					{
						goto IL_7D5;
					}
					IL_315:
					num2 = 45;
					DataTable dataTable4 = (DataTable)value;
					IL_320:
					num2 = 46;
					bool o000_00._0_o. = true;
					IL_326:
					num2 = 47;
					dataTable4.TableName = this.Name;
					IL_336:
					num2 = 48;
					if (this.TableType != TableTypeEnum.Normal)
					{
						goto IL_386;
					}
					IL_341:
					num2 = 49;
					if (dataTable4.DataSet != null)
					{
						goto IL_361;
					}
					IL_34D:
					num2 = 50;
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable4);
					IL_361:
					num2 = 51;
					OO_00oOO.DataTables.OO0o00.0O_0o.(new DataTable(dataTable4, null, null, "", O_O0OO.OoO.0OO__0ooo.()));
					goto IL_4D8;
					IL_386:
					num2 = 53;
					if (dataTable4.Columns.Contains("_Locked"))
					{
						goto IL_3C1;
					}
					IL_39C:
					num2 = 54;
					dataTable4.Columns.Add("_Locked", typeof(bool));
					IL_3BB:
					num2 = 55;
					o000_00._0_o. = false;
					IL_3C1:
					num2 = 56;
					if (dataTable4.Columns.Contains("System_Sort_Temporary"))
					{
						goto IL_434;
					}
					IL_3D7:
					num2 = 57;
					dataTable4.Columns.Add("System_Sort_Temporary", typeof(double));
					IL_3F6:
					num2 = 58;
					dataTable4.Columns.Add("System_Filter_Temporary", typeof(int));
					IL_415:
					num2 = 59;
					dataTable4.Columns.Add("System_Filter_Unique", typeof(int));
					IL_434:
					num2 = 60;
					if (this.DataTable.BaseTable.DataSet != O_O0OO.OOOo.oo_OOOO_0.() || Operators.CompareString(this.DataTable.BaseTable.TableName, this.Name, true) != 0)
					{
						goto IL_484;
					}
					IL_46C:
					num2 = 61;
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Remove(this.Name);
					IL_484:
					num2 = 62;
					if (dataTable4.DataSet != null)
					{
						goto IL_4A4;
					}
					IL_490:
					num2 = 63;
					O_O0OO.OOOo.oo_OOOO_0.().Tables.Add(dataTable4);
					IL_4A4:
					num2 = 64;
					OO_00oOO.DataTables[this.Name].BaseTable = dataTable4;
					IL_4BE:
					num2 = 65;
					OO_00oOO.DataTables[this.Name].O000_00._0_o. = o000_00._0_o.;
					IL_4D8:
					num2 = 66;
					OO_00oOO.DataTables[this.Name].o.0O000_.();
					IL_4F0:
					num2 = 67;
					OO_00oOO.DataTables[this.Name].AddByCode = true;
					IL_509:
					num2 = 68;
					if (dataTable == null)
					{
						goto IL_5C4;
					}
					IL_513:
					num2 = 69;
					DataTable dataTable5 = OO_00oOO.DataTables[this.Name];
					IL_528:
					num2 = 70;
					dataTable5._Adapter = dataTable._Adapter;
					IL_539:
					num2 = 71;
					dataTable5.o._OOO0oOo0__. = dataTable.o._OOO0oOo0__.;
					IL_54A:
					num2 = 72;
					dataTable5.o0__.Oo0o__O. = dataTable.o0__.Oo0o__O.;
					IL_55B:
					num2 = 73;
					dataTable5.ConnectionName = dataTable.ConnectionName;
					IL_56C:
					num2 = 74;
					dataTable5.OO00.oO_. = dataTable.OO00.oO_.;
					IL_57D:
					num2 = 75;
					dataTable5.DataServer = dataTable.DataServer;
					IL_58E:
					num2 = 76;
					dataTable5.HttpSelect = dataTable.HttpSelect;
					IL_59F:
					num2 = 77;
					dataTable5.UpdateServer = dataTable.UpdateServer;
					IL_5B0:
					num2 = 78;
					dataTable5.UpdateColumns = dataTable.UpdateColumns;
					IL_5C1:
					dataTable5 = null;
					IL_5C4:
					num2 = 80;
					IEnumerator<DataCol> enumerator3 = OO_00oOO.DataTables[this.Name].DataCols.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataCol dataCol = enumerator3.Current;
						IL_5EE:
						num2 = 81;
						if (dataCol.BaseColumn.ExtendedProperties.ContainsKey("IsTimeSpan"))
						{
							IL_609:
							num2 = 82;
							dataCol.ExtendColumnType = ExtendColumnTypeEnum.时段;
						}
						IL_614:
						num2 = 83;
					}
					IL_620:
					num2 = 84;
					if (enumerator3 != null)
					{
						enumerator3.Dispose();
					}
					IL_62E:
					num2 = 85;
					DataTable dataTable6 = OO_00oOO.DataTables[this.Name];
					IL_643:
					num2 = 86;
					if (dataTable6._Adapter == null || Operators.CompareString(dataTable6.o._OOO0oOo0__., "", true) <= 0)
					{
						goto IL_670;
					}
					IL_664:
					num2 = 87;
					this.TableType = TableTypeEnum.SQLTable;
					goto IL_6B3;
					IL_670:
					num2 = 89;
					if (Operators.CompareString(dataTable6.DataServer, "", true) <= 0 || Operators.CompareString(dataTable6.UpdateServer, "", true) <= 0)
					{
						goto IL_6A9;
					}
					IL_69D:
					num2 = 90;
					this.TableType = TableTypeEnum.SQLTable;
					goto IL_6B3;
					IL_6A9:
					num2 = 92;
					this.TableType = TableTypeEnum.SQLQuery;
					IL_6B3:
					dataTable6 = null;
					IL_6B6:
					num2 = 94;
					IEnumerator<DataCol> enumerator4 = OO_00oOO.DataTables[this.Name].DataCols.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						DataCol dataCol2 = enumerator4.Current;
						IL_6E0:
						num2 = 95;
						dataCol2.Caption = dataCol2.BaseColumn.Caption;
						IL_6F6:
						num2 = 96;
						dataCol2.BaseColumn.Caption = "";
						IL_70A:
						num2 = 97;
					}
					IL_716:
					num2 = 98;
					if (enumerator4 != null)
					{
						enumerator4.Dispose();
					}
					IL_724:
					num2 = 99;
					O_0 o_2 = O_O0OO.o__.O.()[this.View.Oo._Oo0OO.()];
					IL_73E:
					num2 = 100;
					O_O0OO.o__.O.().Remove(this.View.Oo._Oo0OO.());
					IL_757:
					num2 = 101;
					O_0 dataSource2 = new O_0(dataTable4, this.View.Oo._Oo0OO.());
					IL_76E:
					num2 = 102;
					this.o.0ooOO_0__. = dataSource2;
					IL_779:
					num2 = 103;
					this.o.0ooOO_0__..O00o0.0_0O_.();
					IL_787:
					num2 = 104;
					this.foxGrid.DataSource = dataSource2;
					IL_797:
					num2 = 105;
					this.Cols.Reset();
					IL_7A5:
					num2 = 106;
					this.oO_o_0o._0oooo.(true);
					IL_7AF:
					num2 = 107;
					this.View.o_._0O0o_OoO.();
					IL_7BD:
					num2 = 108;
					this.View.Oo._Oo0OO.();
					IL_7CB:
					num2 = 109;
					o_2.Dispose();
					IL_7D5:
					num2 = 110;
					if (!(obj is fxDataSource2))
					{
						goto IL_7EF;
					}
					IL_7E0:
					num2 = 111;
					obj = ((fxDataSource2)obj).DataSource;
					IL_7EF:
					num2 = 112;
					if (!(obj is fxDataSource))
					{
						goto IL_917;
					}
					IL_7FD:
					num2 = 113;
					fxDataSource fxDataSource = (fxDataSource)obj;
					IL_808:
					num2 = 114;
					if (fxDataSource.O_O_O.00. == null)
					{
						goto IL_847;
					}
					IL_814:
					num2 = 115;
					if (!fxDataSource.O_O_O.00..Subtotal)
					{
						goto IL_884;
					}
					IL_825:
					num2 = 116;
					fxDataSource.O_O_O.00..oO0.O00oO.(this.Name, this.DataTable.BaseTable);
					goto IL_884;
					IL_847:
					num2 = 118;
					if (fxDataSource.O_O_O.00. == null)
					{
						goto IL_884;
					}
					IL_853:
					num2 = 119;
					if (!fxDataSource.O_O_O.00..Subtotal)
					{
						goto IL_884;
					}
					IL_864:
					num2 = 120;
					fxDataSource.O_O_O.00..o_o00_O.0_oo.(this.Name, this.DataTable.BaseTable);
					IL_884:
					num2 = 121;
					IEnumerator<DataCol> enumerator5 = this.DataTable.DataCols.GetEnumerator();
					while (enumerator5.MoveNext())
					{
						DataCol dataCol3 = enumerator5.Current;
						IL_8A4:
						num2 = 122;
						if (dataCol3.DataType == typeof(double))
						{
							IL_8BA:
							num2 = 123;
							if (dataCol3.BaseColumn.ExtendedProperties.Contains("displayformat"))
							{
								IL_8D5:
								num2 = 124;
								dataCol3.SetFormat(dataCol3.BaseColumn.ExtendedProperties["displayformat"].ToString());
							}
						}
						IL_8FA:
						num2 = 125;
					}
					IL_906:
					num2 = 126;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
					IL_914:
					fxDataSource = null;
					IL_917:
					num2 = 128;
					this.foxGrid.EndUpdate();
					IL_928:
					num2 = 129;
					this.foxGrid.EndUpdate();
					IL_939:
					num2 = 130;
					this.foxGrid.EndUpdate();
					IL_94A:
					num2 = 131;
					this.foxGrid.Enabled = true;
					IL_95C:
					num2 = 132;
					this.RaiseCurrentChanged();
					IL_968:
					num2 = 133;
					this.RaisePositionChanged();
					IL_974:
					goto IL_BDE;
					IL_979:
					int num3 = num4 + 1;
					num4 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
					IL_B9F:
					goto IL_BD3;
					IL_BA1:
					num4 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_BB1:;
				}
				catch when (endfilter(obj4 is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj5;
					goto IL_BA1;
				}
				IL_BD3:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_BDE:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x001426A8 File Offset: 0x001408A8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Fill(params object[] args)
		{
			int num = args.Length;
			if (num == 2)
			{
				this.Fill(Conversions.ToString(args[0]), Conversions.ToBoolean(args[1]));
				return;
			}
			if (num != 3)
			{
				return;
			}
			this.Fill(Conversions.ToString(args[0]), Conversions.ToString(args[1]), Conversions.ToBoolean(args[2]));
		}

		/// <summary>
		/// 使用Select语句加载数据。
		/// </summary>
		/// <param name="SelectString">Select语句</param>
		/// <param name="IsQuery">是否是查询表</param>
		// Token: 0x06002C40 RID: 11328 RVA: 0x001426F7 File Offset: 0x001408F7
		[oO0oooo("1777")]
		public void Fill(string SelectString, bool IsQuery)
		{
			this.Fill(SelectString, "", IsQuery);
		}

		/// <summary>
		/// 使用Select语句加载数据，数据源和数据表可以和当前不同。
		/// </summary>
		/// <param name="SelectString">Select语句</param>
		/// <param name="connName">数据源名称</param>
		/// <param name="IsQuery">是否是查询表</param>
		// Token: 0x06002C41 RID: 11329 RVA: 0x00142708 File Offset: 0x00140908
		[oO0oooo("1777")]
		public void Fill(string SelectString, string connName, bool IsQuery)
		{
			this.foxGrid.BeginUpdate();
			try
			{
				this.DataTable.o0O_ooo__.O0o_.();
				if (this.TableType != TableTypeEnum.Normal)
				{
					this.DataTable.Fill(SelectString, connName, IsQuery);
					this.DataTable.AddByCode = true;
					if (IsQuery)
					{
						this.TableType = TableTypeEnum.SQLQuery;
					}
					else
					{
						this.TableType = TableTypeEnum.SQLTable;
					}
				}
				else if (this.IsCopy)
				{
					OleDbConnection oleDbConnection = null;
					O0O o0O = null;
					HttpClient httpClient = null;
					if (Operators.CompareString(connName, "", true) == 0)
					{
						oleDbConnection = O_O0OO.OoO.0OO__0ooo.();
					}
					else if (O_O0OO.O._o_.().ContainsKey(connName))
					{
						oleDbConnection = O_O0OO.O._o_.()[connName];
					}
					else if (O_O0OO.OoO__.0oO0oo.().ContainsKey(connName))
					{
						o0O = O_O0OO.OoO__.0oO0oo.()[connName];
					}
					string a_ = "";
					string text = this.View.Oo._Oo0OO.();
					if (!IsQuery)
					{
						a_ = "?";
					}
					OO_00oOO.SystemReady = false;
					Component component = this.View;
					O_O0OO.o__.O.().Remove(text);
					if (oleDbConnection != null)
					{
						SelectString = Oo00.o0_o._O_.(oleDbConnection, SelectString, false);
					}
					else
					{
						SelectString = Oo00.o0_o._O_.(o0O.OO.OoO0., SelectString, false);
						httpClient = o0O.oO0_0.o.();
						httpClient.Select = SelectString;
						if (!IsQuery)
						{
							httpClient.FormData["Action"] = 1.ToString();
						}
						else
						{
							httpClient.FormData["Action"] = 2.ToString();
						}
					}
					o0OoOOoOOo0.OOOOO.o000.(oleDbConnection, SelectString, text, O_O0OO.OOOo.oo_OOOO_0.(), OO_00oOO.DataTables, a_, true, O_O0OO.OoO.0OO__0ooo.(), OO_00oOO.User, O_O0OO.OoO.0OO__0ooo.(), this.DataTable.FillLoadTimeOut, null, connName, httpClient);
					OO_00oOO.DataTables[text].o.0O000_.();
					OO_00oOO.DataTables[text].AddByCode = true;
					if (this.o0__OOo0._oO. != null)
					{
						OO_00oOO.DataTables[text].o_0_00_.oo0O0. = this.o0__OOo0._oO.;
						OO_00oOO.DataTables[text].o0O.O_0.(OO_00oOO.DataTables[text].o_0_00_.oo0O0.);
					}
					this.o.0ooOO_0__. = O_O0OO.o__.O.()[text];
					this.foxGrid.DataSource = this.o.0ooOO_0__.;
					this.Cols.Reset();
					this.oO_o_0o._0oooo.(true);
					component.Dispose();
					if (IsQuery)
					{
						this.TableType = TableTypeEnum.SQLQuery;
						this.DataTable.AllowEdit = false;
					}
					else
					{
						this.TableType = TableTypeEnum.SQLTable;
					}
					OO_00oOO.SystemReady = true;
					this.View.o_._0O0o_OoO.();
					this.View.Oo._Oo0OO.();
				}
			}
			catch (Exception a_2)
			{
				ooO.oOo0Oo.o.(a_2, "");
			}
			finally
			{
				OO_00oOO.SystemReady = true;
				this.foxGrid.EndUpdate();
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x001429CC File Offset: 0x00140BCC
		// (set) Token: 0x06002C43 RID: 11331 RVA: 0x001429E8 File Offset: 0x00140BE8
		internal OOO0o _frdTableLayout
		{
			get
			{
				if (this.oO._0ooO_o0_. == null)
				{
					this.oO._0ooO_o0_. = new OOO0o(this);
				}
				return this.oO._0ooO_o0_.;
			}
			set
			{
			}
		}

		/// <summary>
		/// 批量设置要显示的列及其列宽。
		/// </summary>
		/// <param name="setting">用符号"|"分割的列名和列宽。</param>
		// Token: 0x06002C44 RID: 11332 RVA: 0x001429EC File Offset: 0x00140BEC
		[oO0oooo("1775")]
		public void SetColVisibleWidth(string setting)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			string[] array = setting.Split(new char[]
			{
				'|'
			});
			int num = array.Length - 2;
			for (int i = 0; i <= num; i += 2)
			{
				int value;
				if (Operators.CompareString(array[i], "", true) > 0 && Operators.CompareString(array[i + 1], "", true) > 0 && int.TryParse(array[i + 1], out value))
				{
					dictionary.Add(array[i], value);
				}
			}
			this.foxGrid.BeginUpdate();
			try
			{
				try
				{
					foreach (Col col in this.Cols)
					{
						col.Visible = dictionary.ContainsKey(col.Name);
						if (col.Visible)
						{
							col.Width = dictionary[col.Name];
						}
					}
				}
				finally
				{
					IEnumerator<Col> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				int num2 = this.foxGrid.Cols.Fixed;
				try
				{
					foreach (string text in dictionary.Keys)
					{
						if (Operators.CompareString(text, "", true) > 0 && this.foxGrid.Cols.Contains(text))
						{
							this.foxGrid.Cols[text].Move(num2);
							num2++;
						}
					}
				}
				finally
				{
					Dictionary<string, int>.KeyCollection.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.foxGrid.EndUpdate();
			}
		}

		/// <summary>
		/// 返回一个字符串，包括显示的列及列宽信息
		/// </summary>
		// Token: 0x06002C45 RID: 11333 RVA: 0x00142BE0 File Offset: 0x00140DE0
		[oO0oooo("2496")]
		public string GetColVisibleWidth()
		{
			string text = "";
			try
			{
				foreach (Col col in this.Cols)
				{
					if (col.Visible)
					{
						text = string.Concat(new string[]
						{
							text,
							col.Name,
							"|",
							Conversions.ToString(this.foxGrid.Cols[col.Name].WidthDisplay),
							"|"
						});
					}
				}
			}
			finally
			{
				IEnumerator<Col> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return text.Trim(new char[]
			{
				'|'
			});
		}

		/// <summary>
		/// 强行触发CurrentChanged事件
		/// </summary>
		// Token: 0x06002C46 RID: 11334 RVA: 0x00142C94 File Offset: 0x00140E94
		[oO0oooo("2367")]
		public void RaiseCurrentChanged()
		{
			this.View.o_._0O0o_OoO.();
		}

		/// <summary>
		/// 强行触发PositionChangedd事件
		/// </summary>
		// Token: 0x06002C47 RID: 11335 RVA: 0x00142CA1 File Offset: 0x00140EA1
		[oO0oooo("2367")]
		public void RaisePositionChanged()
		{
			this.View.Oo._Oo0OO.();
		}

		/// <summary>
		/// 默认行高
		/// </summary>
		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x00142CAE File Offset: 0x00140EAE
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x00142CC0 File Offset: 0x00140EC0
		[oO0oooo("1662")]
		public int DefaultRowHeight
		{
			get
			{
				return this.foxGrid.Rows.DefaultSize;
			}
			set
			{
				this.foxGrid.Rows.DefaultSize = value;
			}
		}

		/// <summary>
		/// 默认列宽
		/// </summary>
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x00142CD3 File Offset: 0x00140ED3
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x00142CE5 File Offset: 0x00140EE5
		[oO0oooo("2651")]
		public int DefaultColWidth
		{
			get
			{
				return this.foxGrid.Cols.DefaultSize;
			}
			set
			{
				this.foxGrid.Cols.DefaultSize = value;
			}
		}

		/// <summary>
		/// 突出显示焦点单元格
		/// </summary>
		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002C4C RID: 11340 RVA: 0x00142CF8 File Offset: 0x00140EF8
		// (set) Token: 0x06002C4D RID: 11341 RVA: 0x00142D08 File Offset: 0x00140F08
		[oO0oooo("1923")]
		public bool FocusRect
		{
			get
			{
				return this.foxGrid.FocusRect > FocusRectEnum.None;
			}
			set
			{
				if (value)
				{
					this.foxGrid.FocusRect = FocusRectEnum.Solid;
					this.foxGrid.HighLight = HighLightEnum.Always;
					return;
				}
				this.foxGrid.FocusRect = FocusRectEnum.None;
				this.foxGrid.HighLight = HighLightEnum.Never;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x00142D3E File Offset: 0x00140F3E
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x00142D46 File Offset: 0x00140F46
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool SpillNode
		{
			get
			{
				return this.Oo_0o.0.;
			}
			set
			{
				this.Oo_0o.0. = value;
			}
		}

		/// <summary>
		/// 单独设置某行的高度
		/// </summary>
		/// <param name="Index">行号</param>
		/// <param name="Height">高度，单位为像素</param>
		// Token: 0x06002C50 RID: 11344 RVA: 0x00142D4F File Offset: 0x00140F4F
		public void SetRowHeight(int Index, int Height)
		{
			this.foxGrid.Rows[Index + this.foxGrid.Rows.Fixed].Height = Height;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00142D79 File Offset: 0x00140F79
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetLayersBOMTree()
		{
			this.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.;
			this.SetLayersTree();
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x00142D88 File Offset: 0x00140F88
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetLayersFilterTree()
		{
			this.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.;
			this.SetLayersTree();
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00142D98 File Offset: 0x00140F98
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetLayersTree()
		{
			if (this.TableType == TableTypeEnum.Normal && !this.IsCopy && !this.IsRelation)
			{
				this.NeedSaveSetting = true;
				new o\u3000\u3002\u3000\u3002\u3000\u3002(this, this.o00oOO00_.ooOo.).ShowDialog(Main.OO_O.o.);
				return;
			}
			MessageBox.Show("只有主表才能设置多级分类树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00142DEF File Offset: 0x00140FEF
		public void OpenLayersBOMTree(params object[] args)
		{
			if (args.Length == 0)
			{
				this.OpenLayersBOMTree();
				return;
			}
			if (args.Length == 1)
			{
				this.OpenLayersBOMTree((LayerTreeSetting)args[0], -1);
				return;
			}
			if (args.Length == 2)
			{
				this.OpenLayersBOMTree((LayerTreeSetting)args[0], Conversions.ToInteger(args[1]));
			}
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00142E30 File Offset: 0x00141030
		[oO0oooo("3354")]
		public void OpenLayersBOMTree(LayerTreeSetting setting, int Size = -1)
		{
			this.Oo_oOo_.O0_.(O0_0_0O0___O.OOO.__O_oO_., setting.PathCol, setting.TextCol, setting.ValueCol, setting.SortCol, setting.SortDesc, setting.Separator2, setting.Lengths2, setting.IncludeSub, setting.Subtotal, setting.GridTree, setting.ExpandTo != 0, setting.Unique, Size != 0, 0);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x00142E94 File Offset: 0x00141094
		[oO0oooo("3354")]
		public void OpenLayersBOMTree()
		{
			if (this.o00oOO00_.ooOo. == O0_0_0O0___O.OOO.__O_oO_. && Operators.CompareString(this.o_O_0._O_., "", true) > 0 && this.DataTable.BaseTable.Columns.Contains(this.o_O_0._O_.) && (Operators.CompareString(Conversions.ToString(this.o00oOO00_.ooOo.), "", true) > 0 || Operators.CompareString(this.oo.o0o0O_o_., "", true) > 0))
			{
				this.OpenLayersTree();
				return;
			}
			this.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.;
			this.SetLayersTree();
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x00142F1B File Offset: 0x0014111B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenLayersFilterTree(params object[] args)
		{
			if (args.Length == 0)
			{
				this.OpenLayersFilterTree();
				return;
			}
			if (args.Length == 1)
			{
				this.OpenLayersFilterTree((LayerTreeSetting)args[0], -1);
				return;
			}
			if (args.Length == 2)
			{
				this.OpenLayersFilterTree((LayerTreeSetting)args[0], Conversions.ToInteger(args[1]));
			}
		}

		/// <summary>
		/// 根据指定设置打开层级筛选树
		/// </summary>
		/// <param name="setting">LayerTreeSetting类型，用于设置筛选树。</param>
		/// <param name="Size"></param>
		// Token: 0x06002C58 RID: 11352 RVA: 0x00142F5C File Offset: 0x0014115C
		[oO0oooo("3356")]
		public void OpenLayersFilterTree(LayerTreeSetting setting, int Size = -1)
		{
			this.Oo_oOo_.O0_.(O0_0_0O0___O.oOO___o.0oO., setting.PathCol, setting.TextCol, setting.ValueCol, setting.SortCol, setting.SortDesc, setting.Separator2, setting.Lengths2, setting.IncludeSub, setting.Subtotal, setting.GridTree, setting.ExpandTo != 0, setting.Unique, setting.MergeTotal, Size);
		}

		/// <summary>
		/// 根据上次设置打开层级筛选树
		/// </summary>
		// Token: 0x06002C59 RID: 11353 RVA: 0x00142FC4 File Offset: 0x001411C4
		[oO0oooo("3356")]
		public void OpenLayersFilterTree()
		{
			if (this.o00oOO00_.ooOo. == O0_0_0O0___O.oOO___o.0oO. && Operators.CompareString(this.o_O_0._O_., "", true) > 0 && this.DataTable.BaseTable.Columns.Contains(this.o_O_0._O_.) && (Operators.CompareString(Conversions.ToString(this.o00oOO00_.ooOo.), "", true) > 0 || Operators.CompareString(this.oo.o0o0O_o_., "", true) > 0))
			{
				this.OpenLayersTree();
				return;
			}
			this.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.;
			this.SetLayersTree();
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x0014304C File Offset: 0x0014124C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenLayersTree()
		{
			checked
			{
				if (Operators.CompareString(this.o_O_0._O_., "", true) > 0 && this.DataTable.BaseTable.Columns.Contains(this.o_O_0._O_.))
				{
					if (Operators.CompareString(Conversions.ToString(this.o00oOO00_.ooOo.), "", true) > 0)
					{
						this.Oo_oOo_.O0_.(this.o00oOO00_.ooOo., this.o_O_0._O_., this.ooO0o.o_O., this.Oo_0o_O0._., this.ooo._Ooo., this.O0_.__o00_., this.o00oOO00_.ooOo., null, this.oo_o_.oOO., this.O.O000., this.O0oO0_._0., this.o.0o00ooo_. != 0, this.OOoOO.OO0., this.ooo_Ooo0.__., 0);
						return;
					}
					if (this.oo.o0o0O_o_..Length > 0)
					{
						string[] array = Regex.Split(this.oo.o0o0O_o_., "[^\\d]+");
						List<int> list = new List<int>();
						string[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							int item;
							if (int.TryParse(array2[i], out item))
							{
								list.Add(item);
							}
						}
						this.Oo_oOo_.O0_.(this.o00oOO00_.ooOo., this.o_O_0._O_., this.ooO0o.o_O., this.Oo_0o_O0._., this.ooo._Ooo., this.O0_.__o00_., this.o00oOO00_.ooOo., list.ToArray(), this.oo_o_.oOO., this.O.O000., this.O0oO0_._0., this.o.0o00ooo_. != 0, this.OOoOO.OO0., this.ooo_Ooo0.__., 0);
						return;
					}
				}
				this.SetLayersTree();
			}
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x001431B4 File Offset: 0x001413B4
		private void <<EMPTY_NAME>>(O0_0_0O0___O A_0, string A_1, string A_2, string A_3, string A_4, bool A_5, char A_6, int[] A_7, bool A_8, bool A_9, bool A_10, bool A_11, bool A_12, bool A_13, int A_14 = 0)
		{
			if (A_0 == O0_0_0O0___O.OOO.__O_oO_.)
			{
				A_12 = true;
			}
			if (this.o.0ooOO_0__. != null)
			{
				if (this.o.0ooOO_0__..Disposing || this.o.0ooOO_0__..IsDisposed)
				{
					this.o.0ooOO_0__. = null;
				}
				else if (!(this.o.0ooOO_0__. is oO_oo0Oo) || ((oO_oo0Oo)this.o.0ooOO_0__.).OO_0._O_. != A_0)
				{
					this.CloseFilterTree();
					this.o.0ooOO_0__. = null;
				}
			}
			if (this.TableType == TableTypeEnum.Normal && !this.IsCopy && !this.IsRelation)
			{
				if (this.o.0ooOO_0__. != null && this.o.0ooOO_0__. is oO_oo0Oo)
				{
					oO_oo0Oo oO_oo0Oo = (oO_oo0Oo)this.o.0ooOO_0__.;
					oO_oo0Oo.oo.00__O0o. = A_1;
					if (Operators.CompareString(A_2, "", true) > 0)
					{
						oO_oo0Oo.OO0_0O._oO0O_o. = A_2;
					}
					else
					{
						oO_oo0Oo.OO0_0O._oO0O_o. = oO_oo0Oo.oo.00__O0o.;
					}
					oO_oo0Oo.OO_0._O_. = A_0;
					oO_oo0Oo.oo__._0. = A_3;
					oO_oo0Oo.o_._O0___O. = A_4;
					oO_oo0Oo.oOo.O. = A_5;
					oO_oo0Oo.o0ooOo0.0o_Oo. = A_10;
					oO_oo0Oo.OOOOO0.0. = ((-((A_11 > false) ? 1 : 0)) ? 1 : 0);
					oO_oo0Oo.OO_0o0.O_o_. = A_8;
					oO_oo0Oo.OO_0._O_. = A_9;
					oO_oo0Oo.oo.00__O0o. = A_6;
					oO_oo0Oo.o_._O0___O. = A_12;
					oO_oo0Oo.oo.00__O0o. = A_7;
					if (oO_oo0Oo.Oo0_o0_oOoo.O.() != null)
					{
						oO_oo0Oo.Oo0_o0_oOoo.O.().Checked = A_13;
					}
					if (!((oO_oo0Oo)this.o.0ooOO_0__.).o.0o__.())
					{
						this.CloseFilterTree();
						this.o.0ooOO_0__. = null;
						return;
					}
					((C1DockingTabPage)this.o.0ooOO_0__..Parent).CaptionText = Conversions.ToString(Interaction.IIf(A_0 == O0_0_0O0___O.OOO.__O_oO_., "层级BOM树", RuntimeHelpers.GetObjectValue(Interaction.IIf(A_12, "层级项目树", "层级筛选树"))));
				}
				else if (A_7 != null && A_7.Length > 0)
				{
					this.o.0ooOO_0__. = new oO_oo0Oo(A_0, this, A_1, A_2, A_3, A_4, A_5, A_8, A_9, A_12, A_13, A_7);
				}
				else
				{
					if (Operators.CompareString(Conversions.ToString(A_6), "", true) <= 0)
					{
						return;
					}
					this.o.0ooOO_0__. = new oO_oo0Oo(A_0, this, A_1, A_2, A_3, A_4, A_5, A_6, A_8, A_9, A_12, A_13);
				}
				((oO_oo0Oo)this.o.0ooOO_0__.).o0ooOo0.0o_Oo. = A_10;
				((oO_oo0Oo)this.o.0ooOO_0__.).OOOOO0.0. = ((-((A_11 > false) ? 1 : 0)) ? 1 : 0);
				if (this.o.0ooOO_0__..FindForm() == null)
				{
					string text = this.Name;
					if (text.IndexOf(".") > 0)
					{
						text = text.Substring(0, text.IndexOf("."));
					}
					o_O0_0O0 o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).O__O.o_oOO.();
					if (A_14 > 0)
					{
						o_O0_0O.OoOoo_O0o0.0O_.(A_14);
					}
					if (A_0 == O0_0_0O0___O.OOO.__O_oO_.)
					{
						o_O0_0O.OO_o0_oO.0.(this.o.0ooOO_0__., "层级BOM树", true, null, null, true);
						return;
					}
					if (A_12)
					{
						o_O0_0O.OO_o0_oO.0.(this.o.0ooOO_0__., "层级项目树", true, null, null, true);
						return;
					}
					o_O0_0O.OO_o0_oO.0.(this.o.0ooOO_0__., "层级筛选树", true, null, null, true);
					return;
				}
			}
			else
			{
				MessageBox.Show("只有主表才能打开筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x001434B5 File Offset: 0x001416B5
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetInlineBOMTree()
		{
			this.o00oOO00_.ooOo. = O0_0_0O0___O.OOO.__O_oO_.;
			this.SetInlineTree();
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x001434C4 File Offset: 0x001416C4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetInlineFilterTree()
		{
			this.o00oOO00_.ooOo. = O0_0_0O0___O.oOO___o.0oO.;
			this.SetInlineTree();
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x001434D4 File Offset: 0x001416D4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void SetInlineTree()
		{
			if (this.TableType == TableTypeEnum.Normal && !this.IsCopy && !this.IsRelation)
			{
				this.NeedSaveSetting = true;
				new OO\u3000(this, this.o00oOO00_.ooOo.).ShowDialog(Main.OO_O.o.);
				return;
			}
			MessageBox.Show("只有主表才能设内联树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x0014352B File Offset: 0x0014172B
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenInlineBomTree(params object[] args)
		{
			if (args.Length == 0)
			{
				this.OpenInlineBomTree();
				return;
			}
			if (args.Length == 1)
			{
				this.OpenInlineBomTree((InlineTreeSetting)args[0], -1);
				return;
			}
			if (args.Length == 2)
			{
				this.OpenInlineBomTree((InlineTreeSetting)args[0], Conversions.ToInteger(args[1]));
			}
		}

		/// <summary>
		/// 按指定设置打开内联BOM树
		/// </summary>
		/// <param name="Setting">InlineTreeSetting类型，用于设置BOM树</param>
		/// <param name="Size">目录树宽度</param>
		// Token: 0x06002C60 RID: 11360 RVA: 0x0014356C File Offset: 0x0014176C
		[oO0oooo("3353")]
		public void OpenInlineBomTree(InlineTreeSetting Setting, int Size = -1)
		{
			this.Oo_oOo_.O0_.(O0_0_0O0___O.OOO.__O_oO_., Setting.ParentCol, Setting.ChildCol, Setting.ValueCol, Setting.TextCol, Setting.SortCol, Setting.SortDesc, Setting.IncludeSub, Setting.Subtotal, Setting.GridTree, Setting.ExpandTo, Setting.Unique, Setting.MergeTotal, Size);
		}

		/// <summary>
		/// 根据上一次设置打开内联BOM树
		/// </summary>
		// Token: 0x06002C61 RID: 11361 RVA: 0x001435CC File Offset: 0x001417CC
		[oO0oooo("3353")]
		public void OpenInlineBomTree()
		{
			if (Operators.CompareString(this.oo.0___0O00., "", true) > 0 && Operators.CompareString(this.oOo0.____., "", true) > 0 && this.o00oOO00_.ooOo. == O0_0_0O0___O.OOO.__O_oO_. && this.DataTable.BaseTable.Columns.Contains(this.oo.0___0O00.) && this.DataTable.BaseTable.Columns.Contains(this.oOo0.____.))
			{
				this.OpenInlineTree();
				return;
			}
			this.SetInlineBOMTree();
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00143650 File Offset: 0x00141850
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenInlineFilterTree(params object[] args)
		{
			if (args.Length == 0)
			{
				this.OpenInlineFilterTree();
				return;
			}
			if (args.Length == 1)
			{
				this.OpenInlineFilterTree((InlineTreeSetting)args[0], -1);
				return;
			}
			if (args.Length == 2)
			{
				this.OpenInlineFilterTree((InlineTreeSetting)args[0], Conversions.ToInteger(args[1]));
			}
		}

		/// <summary>
		/// 根据指定设置打开内联筛选树
		/// </summary>
		/// <param name="Setting">InlineTreeSetting类型，用于设置筛选树</param>
		/// <param name="Size">目录树宽度</param>
		// Token: 0x06002C63 RID: 11363 RVA: 0x00143690 File Offset: 0x00141890
		[oO0oooo("3355")]
		public void OpenInlineFilterTree(InlineTreeSetting Setting, int Size = -1)
		{
			this.Oo_oOo_.O0_.(O0_0_0O0___O.oOO___o.0oO., Setting.ParentCol, Setting.ChildCol, Setting.ValueCol, Setting.TextCol, Setting.SortCol, Setting.SortDesc, Setting.IncludeSub, Setting.Subtotal, Setting.GridTree, Setting.ExpandTo, Setting.Unique, Setting.MergeTotal, Size);
		}

		/// <summary>
		/// 根据上次设置打开内联筛选树
		/// </summary>
		// Token: 0x06002C64 RID: 11364 RVA: 0x001436F0 File Offset: 0x001418F0
		[oO0oooo("3355")]
		public void OpenInlineFilterTree()
		{
			if (Operators.CompareString(this.oo.0___0O00., "", true) > 0 && Operators.CompareString(this.oOo0.____., "", true) > 0 && this.o00oOO00_.ooOo. == O0_0_0O0___O.oOO___o.0oO. && this.DataTable.BaseTable.Columns.Contains(this.oo.0___0O00.) && this.DataTable.BaseTable.Columns.Contains(this.oOo0.____.))
			{
				this.OpenInlineTree();
				return;
			}
			this.SetInlineFilterTree();
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00143778 File Offset: 0x00141978
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenInlineTree()
		{
			if (Operators.CompareString(this.oo.0___0O00., "", true) > 0 && Operators.CompareString(this.oOo0.____., "", true) > 0 && this.DataTable.BaseTable.Columns.Contains(this.oo.0___0O00.) && this.DataTable.BaseTable.Columns.Contains(this.oOo0.____.))
			{
				this.Oo_oOo_.O0_.(this.o00oOO00_.ooOo., this.oo.0___0O00., this.oOo0.____., this.Oo_0o_O0._., this.ooO0o.o_O., this.ooo._Ooo., this.O0_.__o00_., this.oo_o_.oOO., this.O.O000., this.O0oO0_._0., this.o.0o00ooo_., this.OOoOO.OO0., this.ooo_Ooo0.__., 0);
				return;
			}
			this.SetInlineTree();
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x0014384C File Offset: 0x00141A4C
		private void <<EMPTY_NAME>>(O0_0_0O0___O A_0, string A_1, string A_2, string A_3, string A_4, string A_5, bool A_6, bool A_7, bool A_8, bool A_9, int A_10, bool A_11, bool A_12, int A_13 = 0)
		{
			if (A_0 == O0_0_0O0___O.OOO.__O_oO_.)
			{
				A_11 = true;
			}
			if (this.o.0ooOO_0__. != null)
			{
				if (this.o.0ooOO_0__..Disposing || this.o.0ooOO_0__..IsDisposed)
				{
					this.o.0ooOO_0__. = null;
				}
				else if (!(this.o.0ooOO_0__. is oo__) || ((oo__)this.o.0ooOO_0__.).O_OOo0o0__0.0_. != A_0)
				{
					this.CloseFilterTree();
					this.o.0ooOO_0__. = null;
				}
			}
			if (this.TableType == TableTypeEnum.Normal && !this.IsCopy && !this.IsRelation)
			{
				if (this.o.0ooOO_0__. != null && this.o.0ooOO_0__. is oo__)
				{
					oo__ oo__ = (oo__)this.o.0ooOO_0__.;
					oo__.O_OOo0o0__0.0_. = A_0;
					oo__.oO0.o_O. = A_1;
					oo__.O_o_o.oo0_. = A_2;
					oo__.Ooo_00_OO.0Oo_. = A_3;
					oo__.oO0__0_oO0.O_0. = A_5;
					oo__.oO0.o_O. = A_6;
					oo__.Ooo_00_OO.0Oo_. = A_11;
					if (Operators.CompareString(A_4, "", true) > 0)
					{
						oo__.o0O_Oo0_O._. = A_4;
					}
					else
					{
						oo__.o0O_Oo0_O._. = A_2;
					}
					oo__.O_00.0___0. = A_8;
					oo__.o.ooO_. = A_7;
					if (oo__.oOO.oOOO000O.() != null)
					{
						oo__.oOO.oOOO000O.().Checked = A_12;
					}
					oo__.o00O_o.OO0oO. = "";
					if (!((oo__)this.o.0ooOO_0__.).Oo0___O.0.())
					{
						this.CloseFilterTree();
						this.o.0ooOO_0__. = null;
						return;
					}
					((C1DockingTabPage)this.o.0ooOO_0__..Parent).CaptionText = Conversions.ToString(Interaction.IIf(A_0 == O0_0_0O0___O.OOO.__O_oO_., "内联BOM树", RuntimeHelpers.GetObjectValue(Interaction.IIf(A_11, "内联项目树", "内联筛选树"))));
				}
				else
				{
					this.o.0ooOO_0__. = new oo__(A_0, this, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_11, A_12);
				}
				if (this.o.0ooOO_0__..FindForm() == null)
				{
					string text = this.Name;
					if (text.IndexOf(".") > 0)
					{
						text = text.Substring(0, text.IndexOf("."));
					}
					o_O0_0O0 o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).O__O.o_oOO.();
					if (A_13 > 0)
					{
						o_O0_0O.OoOoo_O0o0.0O_.(A_13);
					}
					if (A_0 == O0_0_0O0___O.OOO.__O_oO_.)
					{
						o_O0_0O.OO_o0_oO.0.(this.o.0ooOO_0__., "内联BOM树", true, null, null, true);
					}
					else if (A_11)
					{
						o_O0_0O.OO_o0_oO.0.(this.o.0ooOO_0__., "内联项目树", true, null, null, true);
					}
					else
					{
						o_O0_0O.OO_o0_oO.0.(this.o.0ooOO_0__., "内联筛选树", true, null, null, true);
					}
				}
				((oo__)this.o.0ooOO_0__.).o__oO0.OOo_O. = A_9;
				((oo__)this.o.0ooOO_0__.).o_.0Oo_oo0_. = A_10;
				return;
			}
			MessageBox.Show("只有主表才能打开筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// 根据上一次设置打开筛选树
		/// </summary>
		// Token: 0x06002C67 RID: 11367 RVA: 0x00143AF2 File Offset: 0x00141CF2
		[oO0oooo("2020")]
		public void OpenFilterTree()
		{
			if (Operators.CompareString(this.O00.o_0OO__., "", true) > 0)
			{
				this.OpenFilterTree(this.O00.o_0OO__., 0);
				return;
			}
			this.SetFilterTree();
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00143B1C File Offset: 0x00141D1C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenFilterTree(params object[] args)
		{
			int num = args.Length;
			if (num == 0)
			{
				this.OpenFilterTree();
				return;
			}
			if (num >= 1 && num <= 2)
			{
				string colNames = Conversions.ToString(args[0]);
				int size = (args.Length >= 2) ? Conversions.ToInteger(args[1]) : 0;
				this.OpenFilterTree(colNames, size);
			}
		}

		/// <summary>
		/// 根据指定设置打开筛选树
		/// </summary>
		/// <param name="ColNames">指定分组列，不同的列之间用符号"|"隔开，例如“产品|客户”</param>
		/// <param name="size">目录树宽度</param>
		// Token: 0x06002C69 RID: 11369 RVA: 0x00143B64 File Offset: 0x00141D64
		[oO0oooo("2020")]
		public void OpenFilterTree(string ColNames, int size = 0)
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
				OO_00oOO.LockBaseMainForm();
				IL_0E:
				num2 = 3;
				if (Operators.CompareString(this.O00.o_0OO__., ColNames, true) == 0)
				{
					goto IL_31;
				}
				IL_1F:
				num2 = 4;
				this.O00.o_0OO__. = ColNames;
				IL_28:
				num2 = 5;
				this.NeedSaveSetting = true;
				IL_31:
				num2 = 6;
				if (this.o.0ooOO_0__. == null)
				{
					goto IL_85;
				}
				IL_3B:
				num2 = 7;
				if (!this.o.0ooOO_0__..Disposing && !this.o.0ooOO_0__..IsDisposed)
				{
					goto IL_62;
				}
				IL_57:
				num2 = 8;
				this.o.0ooOO_0__. = null;
				goto IL_85;
				IL_62:
				num2 = 10;
				if (this.o.0ooOO_0__. is o_o0ooOooO)
				{
					goto IL_85;
				}
				IL_72:
				num2 = 11;
				this.CloseFilterTree();
				IL_7B:
				num2 = 12;
				this.o.0ooOO_0__. = null;
				IL_85:
				num2 = 13;
				if (this.TableType != TableTypeEnum.Normal || this.IsCopy || this.IsRelation)
				{
					goto IL_1AF;
				}
				IL_A9:
				num2 = 14;
				if (this.o.0ooOO_0__. == null || !(this.o.0ooOO_0__. is o_o0ooOooO))
				{
					goto IL_EF;
				}
				IL_C1:
				num2 = 15;
				if (((o_o0ooOooO)this.o.0ooOO_0__.).O0o.0oo0_.(ColNames))
				{
					goto IL_FF;
				}
				IL_D7:
				num2 = 16;
				this.CloseFilterTree();
				IL_E0:
				num2 = 17;
				this.o.0ooOO_0__. = null;
				goto IL_1CD;
				IL_EF:
				num2 = 20;
				this.o.0ooOO_0__. = new o_o0ooOooO(this, ColNames);
				IL_FF:
				num2 = 21;
				this.o.0ooOO_0__..Nodes.Insert(0, "显示所有行");
				IL_119:
				num2 = 22;
				if (this.o.0ooOO_0__..FindForm() != null)
				{
					goto IL_1C5;
				}
				IL_12C:
				num2 = 23;
				string text = this.Name;
				IL_136:
				num2 = 24;
				if (text.IndexOf(".") <= 0)
				{
					goto IL_15D;
				}
				IL_147:
				num2 = 25;
				text = text.Substring(0, text.IndexOf("."));
				IL_15D:
				num2 = 26;
				o_O0_0O0 o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).O__O.o_oOO.();
				IL_181:
				num2 = 27;
				if (size <= 0)
				{
					goto IL_193;
				}
				IL_188:
				num2 = 28;
				o_O0_0O.OoOoo_O0o0.0O_.(size);
				IL_193:
				num2 = 29;
				o_O0_0O.OO_o0_oO.0.(this.o.0ooOO_0__., "筛选树", true, null, null, true);
				goto IL_1C5;
				IL_1AF:
				num2 = 31;
				MessageBox.Show("只有主表才能打开筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_1C5:
				num2 = 32;
				OO_00oOO.UnlockBaseMainForm();
				IL_1CD:
				goto IL_2A3;
				IL_1D2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_264:
				goto IL_298;
				IL_266:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_276:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_266;
			}
			IL_298:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2A3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 关闭筛选树
		/// </summary>
		// Token: 0x06002C6A RID: 11370 RVA: 0x00143E38 File Offset: 0x00142038
		public void CloseFilterTree()
		{
			if (this.o.0ooOO_0__. != null)
			{
				System.Windows.Forms.Control parent = this.o.0ooOO_0__..Parent;
				while (parent != null && !(parent is FormPanel))
				{
					if (parent is o_O0_0O0)
					{
						((o_O0_0O0)parent).o_o.O___0o.(this.o.0ooOO_0__.);
						return;
					}
					parent = parent.Parent;
				}
			}
		}

		/// <summary>
		/// 是否已经打开记录窗口
		/// </summary>
		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x00143E88 File Offset: 0x00142088
		[oO0oooo("2203")]
		public bool RecordGridVisible
		{
			get
			{
				return this.o00oOO00_.ooOo. != null && this.o00oOO00_.ooOo..FindForm() != null;
			}
		}

		/// <summary>
		/// 打开记录窗口
		/// </summary>
		/// <param name="size">记录窗口宽度</param>
		// Token: 0x06002C6C RID: 11372 RVA: 0x00143EB4 File Offset: 0x001420B4
		[oO0oooo("2203")]
		public void OpenRecordGrid(int size = 0)
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
				if (this.TableType != TableTypeEnum.Normal || this.IsCopy)
				{
					goto IL_192;
				}
				IL_1F:
				num2 = 4;
				if (this.o00oOO00_.ooOo. != null && this.o00oOO00_.ooOo..FindForm() != null)
				{
					goto IL_192;
				}
				IL_39:
				num2 = 6;
				OooOo0___oO oooOo0___oO = new OooOo0___oO(this, "", true, true);
				IL_49:
				num2 = 7;
				string text = this.Name;
				IL_53:
				num2 = 8;
				if (text.IndexOf(".") <= 0)
				{
					goto IL_7D;
				}
				IL_64:
				num2 = 9;
				text = text.Substring(0, text.IndexOf("."));
				IL_7D:
				num2 = 10;
				o_O0_0O0 o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).o__0_.o0OoOOO.();
				IL_A2:
				num2 = 11;
				if (size <= 0)
				{
					goto IL_B4;
				}
				IL_A9:
				num2 = 12;
				o_O0_0O.OoOoo_O0o0.0O_.(size);
				IL_B4:
				num2 = 13;
				oooOo0___oO.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
				IL_BE:
				num2 = 14;
				string[] array = this.Name.Split(new char[]
				{
					'.'
				});
				IL_D9:
				num2 = 15;
				string text2 = "";
				IL_E3:
				num2 = 16;
				foreach (string text3 in array)
				{
					IL_F6:
					num2 = 17;
					if (Operators.CompareString(text2, "", true) > 0)
					{
						IL_109:
						num2 = 18;
						text2 += ".";
					}
					IL_11A:
					num2 = 19;
					text2 += Interaction.IIf(Operators.CompareString(OO_00oOO.DataTables[text3].Caption, "", true) > 0, OO_00oOO.DataTables[text3].Caption, text3).ToString();
					IL_162:
					num2 = 20;
				}
				IL_176:
				num2 = 21;
				o_O0_0O.OO_o0_oO.0.(oooOo0___oO, text2, true, null, null, true);
				IL_188:
				num2 = 22;
				this.o00oOO00_.ooOo. = oooOo0___oO;
				IL_192:
				goto IL_240;
				IL_197:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_201:
				goto IL_235;
				IL_203:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_213:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_203;
			}
			IL_235:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_240:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 关闭记录窗口
		/// </summary>
		// Token: 0x06002C6D RID: 11373 RVA: 0x00144128 File Offset: 0x00142328
		public void CloseRecordGrid()
		{
			if (this.o00oOO00_.ooOo. != null)
			{
				if (this.o00oOO00_.ooOo..Editor != null && !this.o00oOO00_.ooOo..FinishEditing())
				{
					this.o00oOO00_.ooOo..FinishEditing(true);
				}
				System.Windows.Forms.Control parent = this.o00oOO00_.ooOo..Parent;
				while (parent != null && !(parent is FormPanel))
				{
					if (parent is o_O0_0O0)
					{
						((o_O0_0O0)parent).o_o.O___0o.(this.o00oOO00_.ooOo.);
						break;
					}
					parent = parent.Parent;
				}
				this.o00oOO00_.ooOo..O_._0o00_.();
				this.o00oOO00_.ooOo. = null;
			}
		}

		/// <summary>
		/// 设置筛选树
		/// </summary>
		// Token: 0x06002C6E RID: 11374 RVA: 0x001441B4 File Offset: 0x001423B4
		public void SetFilterTree()
		{
			if (this.TableType == TableTypeEnum.Normal && !this.IsCopy && !this.IsRelation)
			{
				this.NeedSaveSetting = true;
				new jr(this).ShowDialog(Main.OO_O.o.);
				return;
			}
			MessageBox.Show("只有主表才能设置筛选树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00144208 File Offset: 0x00142408
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void OpenLoadTree(params object[] args)
		{
			int num = args.Length;
			if (num == 0)
			{
				this.OpenLoadTree();
				return;
			}
			if (num >= 1 && num <= 5)
			{
				string colNames = Conversions.ToString(args[0]);
				int size = (args.Length >= 2) ? Conversions.ToInteger(args[1]) : 0;
				int pageRows = (args.Length >= 3) ? Conversions.ToInteger(args[2]) : 0;
				bool loadFirstPage = args.Length >= 4 && Conversions.ToBoolean(args[3]);
				string filter = (args.Length >= 5) ? Conversions.ToString(args[4]) : "-";
				this.OpenLoadTree(colNames, size, pageRows, loadFirstPage, filter);
			}
		}

		/// <summary>
		/// 根据上一次设置打开加载树
		/// </summary>
		// Token: 0x06002C70 RID: 11376 RVA: 0x0014428F File Offset: 0x0014248F
		[oO0oooo("2022")]
		public void OpenLoadTree()
		{
			if (Operators.CompareString(this.o.Ooo__., "", true) == 0)
			{
				this.SetLoadTree();
				return;
			}
			this.OpenLoadTree(this.o.Ooo__., 0, 0, false, this.oO.oO_00o__o.);
		}

		/// <summary>
		/// 根据指定设置打开加载树
		/// </summary>
		/// <param name="ColNames">指定分组列，不同的列之间用符号"|"隔开，例如“产品|客户”</param>
		/// <param name="size">加载树宽度</param>
		/// <param name="PageRows">每页加载的行数，默认为10000。</param>
		/// <param name="LoadFirstPage">是否自动加载第一页数据</param>
		/// <param name="Filter">设置加载树的生成条件，默认是根据后台所有数据生成加载树的</param>
		// Token: 0x06002C71 RID: 11377 RVA: 0x001442C0 File Offset: 0x001424C0
		[oO0oooo("2022")]
		public void OpenLoadTree(string ColNames, int size = 0, int PageRows = 0, bool LoadFirstPage = false, string Filter = "-")
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
				OO_00oOO.LockBaseMainForm();
				IL_0E:
				num2 = 3;
				if (Operators.CompareString(this.o.Ooo__., ColNames, true) == 0)
				{
					goto IL_31;
				}
				IL_1F:
				num2 = 4;
				this.o.Ooo__. = ColNames;
				IL_28:
				num2 = 5;
				this.NeedSaveSetting = true;
				IL_31:
				num2 = 6;
				if (PageRows <= 0)
				{
					goto IL_40;
				}
				IL_37:
				num2 = 7;
				this.o.0__o0. = PageRows;
				IL_40:
				num2 = 8;
				this.O0__O_.O. = this.DataTable.LoadOver;
				IL_53:
				num2 = 9;
				if (Operators.CompareString(Filter, "-", true) == 0)
				{
					goto IL_70;
				}
				IL_65:
				num2 = 10;
				this.oO.oO_00o__o. = Filter;
				IL_70:
				num2 = 11;
				if (this.O.OoOo_. == null)
				{
					goto IL_A2;
				}
				IL_7B:
				num2 = 12;
				if (!this.O.OoOo_..Disposing && !this.O.OoOo_..IsDisposed)
				{
					goto IL_A2;
				}
				IL_98:
				num2 = 13;
				this.O.OoOo_. = null;
				IL_A2:
				num2 = 14;
				if (this.TableType != TableTypeEnum.Normal || this.IsCopy || this.IsRelation || (Operators.CompareString(this.DataTable.DataServer, "", true) <= 0 && this.DataTable.frd_IsTemporary))
				{
					goto IL_23F;
				}
				IL_EF:
				num2 = 15;
				if (this.O.OoOo_. == null)
				{
					goto IL_129;
				}
				IL_FA:
				num2 = 16;
				this.O.OoOo_..oOo0O.___ooOO0. = Filter;
				IL_10A:
				num2 = 17;
				if (this.O.OoOo_..o000.oO0.(ColNames))
				{
					goto IL_13B;
				}
				IL_11B:
				num2 = 18;
				this.CloseLoadTree();
				goto IL_25D;
				IL_129:
				num2 = 21;
				this.O.OoOo_. = new o_0(this, ColNames, Filter);
				IL_13B:
				num2 = 22;
				this.O.OoOo_..OOOO_.o.().Nodes.Insert(0, "加载所有行");
				IL_15A:
				num2 = 23;
				if (this.O.OoOo_..FindForm() != null)
				{
					goto IL_1EE;
				}
				IL_16D:
				num2 = 24;
				string text = this.Name;
				IL_177:
				num2 = 25;
				if (text.IndexOf(".") <= 0)
				{
					goto IL_19E;
				}
				IL_188:
				num2 = 26;
				text = text.Substring(0, text.IndexOf("."));
				IL_19E:
				num2 = 27;
				o_O0_0O0 o_O0_0O = ((Oo0__Oo)Main.OO_O.o..OO_O_0Oo.___o.().TabPages[text]).O__O.o_oOO.();
				IL_1C2:
				num2 = 28;
				if (size <= 0)
				{
					goto IL_1D4;
				}
				IL_1C9:
				num2 = 29;
				o_O0_0O.OoOoo_O0o0.0O_.(size);
				IL_1D4:
				num2 = 30;
				o_O0_0O.OO_o0_oO.0.(this.O.OoOo_., "加载树", true, null, null, true);
				IL_1EE:
				num2 = 31;
				if (!LoadFirstPage || PageRows <= 0)
				{
					goto IL_255;
				}
				IL_1F9:
				num2 = 32;
				if (this.O.OoOo_..OOOO_.o.().Nodes.Count <= 0)
				{
					goto IL_255;
				}
				IL_214:
				num2 = 33;
				this.O.OoOo_..OOOO_.o.().SelectedNode = this.O.OoOo_..OOOO_.o.().Nodes[0];
				goto IL_255;
				IL_23F:
				num2 = 35;
				MessageBox.Show("只有主表才能打开加载树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_255:
				num2 = 36;
				OO_00oOO.UnlockBaseMainForm();
				IL_25D:
				goto IL_343;
				IL_262:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_304:
				goto IL_338;
				IL_306:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_316:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_306;
			}
			IL_338:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_343:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 打开加载树设置窗口
		/// </summary>
		// Token: 0x06002C72 RID: 11378 RVA: 0x00144634 File Offset: 0x00142834
		public void SetLoadTree()
		{
			if (this.TableType == TableTypeEnum.Normal && !this.IsCopy && !this.IsRelation && !this.DataTable.frd_IsTemporary)
			{
				this.NeedSaveSetting = true;
				new ky(this).ShowDialog(Main.OO_O.o.);
				return;
			}
			MessageBox.Show("只有主表才能设置加载树！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// 关闭加载树
		/// </summary>
		// Token: 0x06002C73 RID: 11379 RVA: 0x00144694 File Offset: 0x00142894
		public void CloseLoadTree()
		{
			if (this.O.OoOo_. != null)
			{
				System.Windows.Forms.Control parent = this.O.OoOo_..Parent;
				while (parent != null && !(parent is FormPanel))
				{
					if (parent is o_O0_0O0)
					{
						((o_O0_0O0)parent).o_o.O___0o.(this.O.OoOo_.);
						return;
					}
					parent = parent.Parent;
				}
			}
		}

		/// <summary>
		/// 打开图表设置窗口
		/// </summary>
		// Token: 0x06002C74 RID: 11380 RVA: 0x001446E3 File Offset: 0x001428E3
		public void BuildChart()
		{
			new O\u3002_\u3000\u3002\u3000\u3000\u3000\u3000(this).ShowDialog(Main.OO_O.o.);
		}

		/// <summary>
		/// 使指定单元格处于可视范围内
		/// </summary>
		/// <param name="Row">行位置</param>
		/// <param name="col">列位置</param>
		// Token: 0x06002C75 RID: 11381 RVA: 0x001446F6 File Offset: 0x001428F6
		public void ShowCell(int Row, int col)
		{
			this.foxGrid.ShowCell(this.foxGrid.Rows.Fixed + Row, this.foxGrid.Cols.Fixed + col);
		}

		/// <summary>
		/// 是否允许分组统计和交叉统计窗口出现"直接统计后台数据"选项
		/// </summary>
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x00144727 File Offset: 0x00142927
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x0014472F File Offset: 0x0014292F
		[oO0oooo("1623")]
		public bool AllowBackgroundStatistics
		{
			get
			{
				return this.o_o0O000o.000.;
			}
			set
			{
				this.o_o0O000o.000. = value;
			}
		}

		/// <summary>
		/// 复制选定区域的数据到剪贴板
		/// </summary>
		// Token: 0x06002C78 RID: 11384 RVA: 0x00144738 File Offset: 0x00142938
		public void EditCopy()
		{
			this.foxGrid.Oo.O_.();
		}

		/// <summary>
		/// 剪切选定区域的数据到剪切板
		/// </summary>
		// Token: 0x06002C79 RID: 11385 RVA: 0x00144745 File Offset: 0x00142945
		public void EditCut()
		{
			this.foxGrid.Oo.O_.();
			this.foxGrid.oO0O00o0o.O.();
		}

		/// <summary>
		/// 从剪切板粘贴数据
		/// </summary>
		// Token: 0x06002C7A RID: 11386 RVA: 0x0014475D File Offset: 0x0014295D
		public void EditPaste()
		{
			this.foxGrid.o0o0__.o.();
		}

		/// <summary>
		/// 删除选定区域的数据
		/// </summary>
		// Token: 0x06002C7B RID: 11387 RVA: 0x0014476A File Offset: 0x0014296A
		public void EditDelete()
		{
			this.foxGrid.oO0O00o0o.O.();
		}

		/// <summary>
		/// 返回或设置第一个可见列
		/// </summary>
		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x00144777 File Offset: 0x00142977
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x00144795 File Offset: 0x00142995
		[oO0oooo("2358")]
		public int LeftVisibleCol
		{
			get
			{
				return this.foxGrid.LeftCol - this.foxGrid.Cols.Fixed;
			}
			set
			{
				this.foxGrid.LeftCol = value + this.foxGrid.Cols.Fixed;
			}
		}

		/// <summary>
		/// 最后一个可见列
		/// </summary>
		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x001447B4 File Offset: 0x001429B4
		[oO0oooo("2358")]
		public int RightVisibleCol
		{
			get
			{
				return this.foxGrid.RightCol - this.foxGrid.Cols.Fixed;
			}
		}

		/// <summary>
		/// 返回或设置第一个可见行
		/// </summary>
		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x001447D2 File Offset: 0x001429D2
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x001447F0 File Offset: 0x001429F0
		[oO0oooo("2358")]
		public int TopVisibleRow
		{
			get
			{
				return this.foxGrid.TopRow - this.foxGrid.Rows.Fixed;
			}
			set
			{
				this.foxGrid.TopRow = value + this.foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 最后一个可见行
		/// </summary>
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0014480F File Offset: 0x00142A0F
		[oO0oooo("2358")]
		public int BottomVisibleRow
		{
			get
			{
				return this.foxGrid.BottomRow - this.foxGrid.Rows.Fixed;
			}
		}

		/// <summary>
		/// 是否自动调整最后一列的宽度，以适用表宽。
		/// </summary>
		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x0014482D File Offset: 0x00142A2D
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x0014483A File Offset: 0x00142A3A
		[oO0oooo("2380")]
		public bool ExtendLastCol
		{
			get
			{
				return this.foxGrid.ExtendLastCol;
			}
			set
			{
				this.foxGrid.ExtendLastCol = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x00144848 File Offset: 0x00142A48
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LookAndFeelProperty Appearance
		{
			get
			{
				return this.foxGrid.OO_.00oO0Oo.();
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x00144858 File Offset: 0x00142A58
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ShowToolTip(params object[] args)
		{
			int num = args.Length;
			if (num != 3)
			{
				if (num != 4)
				{
					return;
				}
				string text = Conversions.ToString(args[0]);
				Foxtable.Row row = (Foxtable.Row)args[1];
				int dutation = Conversions.ToInteger(args[3]);
				if (args[2] is Col)
				{
					this.ShowToolTip(text, row, (Col)args[2], dutation);
					return;
				}
				if (args[2] is string)
				{
					this.ShowToolTip(text, row, Conversions.ToString(args[2]), dutation);
				}
			}
			else
			{
				string text2 = Conversions.ToString(args[0]);
				Foxtable.Row row2 = (Foxtable.Row)args[1];
				if (args[2] is Col)
				{
					this.ShowToolTip(text2, row2, (Col)args[2], -1);
					return;
				}
				if (args[2] is string)
				{
					this.ShowToolTip(text2, row2, Conversions.ToString(args[2]), -1);
					return;
				}
			}
		}

		/// <summary>
		/// 在指定的单元格位置，动态显示一个提示内容
		/// </summary>
		/// <param name="Text">提示内容</param>
		/// <param name="row">行位置</param>
		/// <param name="col">列位置</param>
		/// <param name="dutation">设置提示持续显示的时间，单位为毫秒，如果省略，则一直显示</param>
		// Token: 0x06002C86 RID: 11398 RVA: 0x00144914 File Offset: 0x00142B14
		[oO0oooo("2680")]
		public void ShowToolTip(string Text, Foxtable.Row row, Col col, int dutation = -1)
		{
			int num = this.Grid.Cols[col.Index + this.Grid.Cols.Fixed].Left + this.Grid.ScrollPosition.X;
			int num2;
			if (this.IsSubtotal)
			{
				num2 = row.Index;
				C1FlexGrid c1FlexGrid = this.foxGrid;
				if (c1FlexGrid.MouseRow >= c1FlexGrid.Rows.Fixed && c1FlexGrid.Rows[c1FlexGrid.MouseRow].DataIndex == num2)
				{
					num2 = c1FlexGrid.MouseRow;
				}
				else
				{
					int @fixed = c1FlexGrid.Rows.Fixed;
					int num3 = c1FlexGrid.Rows.Count - 1;
					for (int i = @fixed; i <= num3; i++)
					{
						if (c1FlexGrid.Rows[i].DataIndex == num2)
						{
							num2 = i;
							break;
						}
					}
				}
				if (num2 == row.Index)
				{
					num2 += c1FlexGrid.Rows.Fixed;
				}
			}
			else
			{
				num2 = row.Index + this.Grid.Rows.Fixed;
			}
			int num4 = this.Grid.Rows[num2].Top + this.Grid.ScrollPosition.Y;
			if (this.Grid.Cols.Frozen > 0 && this.Grid.Cols[col.Name].Index - this.Grid.Cols.Fixed < this.Grid.Cols.Frozen)
			{
				num -= this.Grid.ScrollPosition.X;
			}
			num--;
			num4 = num4 + this.Grid.Rows[num2].HeightDisplay - 1;
			if (this.foxGrid.OOOOOO.o0Oo0.)
			{
				Point point = this.foxGrid.PointToClient(System.Windows.Forms.Control.MousePosition);
				num = point.X + 10;
				num4 = point.Y - 30;
			}
			if (dutation <= 0)
			{
				Main.OO_O.o..O0o__0_OO.o.().Show(Text, this.Grid, num, num4);
				return;
			}
			Main.OO_O.o..O0o__0_OO.o.().Show(Text, this.Grid, num, num4, dutation);
		}

		/// <summary>
		/// 在指定的单元格位置，动态显示一个提示内容
		/// </summary>
		/// <param name="Text">提示内容</param>
		/// <param name="row">行位置</param>
		/// <param name="colName">列名</param>
		/// <param name="dutation">设置提示持续显示的时间，单位为毫秒，如果省略，则一直显示</param>
		// Token: 0x06002C87 RID: 11399 RVA: 0x00144B4D File Offset: 0x00142D4D
		[oO0oooo("2680")]
		public void ShowToolTip(string Text, Foxtable.Row row, string colName, int dutation = -1)
		{
			if (this.Cols.Contains(colName))
			{
				this.ShowToolTip(Text, row, this.Cols[colName], dutation);
			}
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00144B73 File Offset: 0x00142D73
		[oO0oooo("2681")]
		public void HideToolTip()
		{
			Main.OO_O.o..O0o__0_OO.o.().Hide(this.Grid);
		}

		/// <summary>
		/// 是否在单元格中显示错误图标
		/// </summary>
		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x00144B8A File Offset: 0x00142D8A
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x00144B97 File Offset: 0x00142D97
		[oO0oooo("2685")]
		public bool ShowErrors
		{
			get
			{
				return this.Grid.ShowErrors;
			}
			set
			{
				this.Grid.ShowErrors = value;
				this.foxGrid.oo0_oo0.ooo_o.();
			}
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00144BB0 File Offset: 0x00142DB0
		internal static bool IsReady()
		{
			StringBuilder stringBuilder = new StringBuilder("", 260);
			bool result;
			if (Table.FindPort_2(0, 999, 1015341241, stringBuilder) == 0)
			{
				stringBuilder.ToString();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00144BF0 File Offset: 0x00142DF0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void RelationFilter(params object[] args)
		{
			int num = args.Length;
			if (num != 4)
			{
				if (num != 5)
				{
					return;
				}
				string colName = Conversions.ToString(args[0]);
				bool match = Conversions.ToBoolean(args[3]);
				bool backFilter = Conversions.ToBoolean(args[4]);
				if (args[1] is DataTable)
				{
					DataTable dataTable = (DataTable)args[1];
					string colName2 = Conversions.ToString(args[2]);
					this.RelationFilter(colName, dataTable, colName2, match, backFilter);
					return;
				}
				if (args[1] is string)
				{
					string dataTableName = Conversions.ToString(args[1]);
					string colName3 = Conversions.ToString(args[2]);
					this.RelationFilter(colName, dataTableName, colName3, match, backFilter);
				}
			}
			else
			{
				string colName4 = Conversions.ToString(args[0]);
				bool match2 = Conversions.ToBoolean(args[3]);
				if (args[1] is DataTable)
				{
					DataTable dataTable2 = (DataTable)args[1];
					string colName5 = Conversions.ToString(args[2]);
					this.RelationFilter(colName4, dataTable2, colName5, match2, false);
					return;
				}
				if (args[1] is string)
				{
					string dataTableName2 = Conversions.ToString(args[1]);
					string colName6 = Conversions.ToString(args[2]);
					this.RelationFilter(colName4, dataTableName2, colName6, match2, false);
					return;
				}
			}
		}

		/// <summary>
		/// 关联筛选
		/// </summary>
		/// <param name="ColName1">本表关联列</param>
		/// <param name="DataTable">另一个表</param>
		/// <param name="ColName2">另一个表的关联列</param>
		/// <param name="Match">关联筛选的模式，True表示有对应值，False表示无对应值</param>
		/// <param name="backFilter">是否后台筛选</param>
		// Token: 0x06002C8D RID: 11405 RVA: 0x00144CF0 File Offset: 0x00142EF0
		[oO0oooo("2711")]
		public void RelationFilter(string ColName1, DataTable DataTable, string ColName2, bool Match, bool backFilter = false)
		{
			if (backFilter && DataTable.frd_Connection == this.DataTable.frd_Connection)
			{
				this.o0O0oo.o.(ColName1, DataTable, ColName2, Match);
				return;
			}
			this.Oo_oOo_.O0_.(ColName1, DataTable, ColName2, Match);
		}

		/// <summary>
		/// 关联筛选
		/// </summary>
		/// <param name="ColName1">本表关联列</param>
		/// <param name="DataTableName">另一个表</param>
		/// <param name="ColName2">另一个表的关联列</param>
		/// <param name="Match">关联筛选的模式，True表示有对应值，False表示无对应值</param>
		/// <param name="backFilter">是否后台筛选</param>
		// Token: 0x06002C8E RID: 11406 RVA: 0x00144D20 File Offset: 0x00142F20
		[oO0oooo("2711")]
		public void RelationFilter(string ColName1, string DataTableName, string ColName2, bool Match, bool backFilter = false)
		{
			if (backFilter && OO_00oOO.DataTables[DataTableName].frd_Connection == this.DataTable.frd_Connection)
			{
				this.o0O0oo.o.(ColName1, OO_00oOO.DataTables[DataTableName], ColName2, Match);
				return;
			}
			this.Oo_oOo_.O0_.(ColName1, OO_00oOO.DataTables[DataTableName], ColName2, Match);
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00144D7C File Offset: 0x00142F7C
		internal void <<EMPTY_NAME>>(string A_0, DataTable A_1, string A_2, bool A_3)
		{
			string a_ = string.Concat(new string[]
			{
				"RelationFilter3\v",
				A_0,
				"\v",
				A_1.Name,
				"\v",
				A_2,
				"\v",
				Conversions.ToString(A_3)
			});
			A_0 = Oo00.OoOo_oo_.o_o.(A_0, this);
			string text;
			if (A_3)
			{
				text = string.Concat(new string[]
				{
					A_0,
					" in ( Select distinct [",
					A_2,
					"] From ",
					Oo00.oo_0__0.o.(A_1._Adapter.SelectCommand.CommandText),
					" Where [",
					A_2,
					"] Is Not Null)"
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					A_0,
					" not in ( Select distinct [",
					A_2,
					"] From ",
					Oo00.oo_0__0.o.(A_1._Adapter.SelectCommand.CommandText),
					" Where [",
					A_2,
					"] Is Not Null)"
				});
			}
			if (Operators.CompareString(this.DataTable.OOOOO._., "", true) > 0)
			{
				text = "(" + this.DataTable.OOOOO._. + ") And " + text;
			}
			this.DataTable.LoadPage = 0;
			this.DataTable.OOO_o_O.OO0o.(text, a_);
			this.DataTable.o0.o.(true, null);
			if (this.O.OoOo_. != null && this.O.OoOo_..FindForm() != null)
			{
				this.O.OoOo_..oO.Oo0__O_.();
			}
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00144EFC File Offset: 0x001430FC
		private void <<EMPTY_NAME>>(string A_0, DataTable A_1, string A_2, bool A_3)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				List<OoO_O00> list = new List<OoO_O00>();
				IL_0F:
				num2 = 3;
				DataTable table = A_1.BaseTable;
				IL_19:
				num2 = 4;
				DataView dataView = new DataView(table, "[" + A_2 + "] Is NOT NULL", A_2, DataViewRowState.CurrentRows);
				IL_37:
				num2 = 5;
				if (!this.View.o_oo._0Oo.() && !this.View.O0OOO_0.o.())
				{
					goto IL_69;
				}
				IL_53:
				num2 = 6;
				DataRow[] array = this.View.o_o.O0ooOo.().Select();
				goto IL_C1;
				IL_69:
				num2 = 8;
				array = new DataRow[this.View.Count - 1 + 1];
				IL_81:
				num2 = 9;
				int num3 = this.View.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_98:
					num2 = 10;
					array[i] = this.View.O0O_0_0__.0O.(i).Row;
					IL_B2:
					num2 = 11;
				}
				IL_C1:
				num2 = 12;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table2 = enumerator.Current;
					IL_DB:
					num2 = 13;
					if (table2.View.o_o.O0ooOo.() == this.View.o_o.O0ooOo.())
					{
						IL_F7:
						num2 = 14;
						list.Add(new OoO_O00(table2));
					}
					IL_107:
					num2 = 15;
				}
				IL_113:
				num2 = 16;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_121:
				num2 = 17;
				Dictionary<DataColumn, string> a_ = Oo00.ooO.ooo.(this.DataTable.BaseTable);
				IL_136:
				num2 = 18;
				if (!A_3)
				{
					goto IL_1A4;
				}
				IL_13D:
				num2 = 19;
				foreach (DataRow dataRow in array)
				{
					IL_150:
					num2 = 20;
					if (dataView.Find(RuntimeHelpers.GetObjectValue(dataRow[A_0])) >= 0)
					{
						IL_16A:
						num2 = 21;
						dataRow["System_Filter_Unique"] = 1;
					}
					else
					{
						IL_181:
						num2 = 23;
						dataRow["System_Filter_Unique"] = null;
					}
					IL_191:
					num2 = 24;
				}
				goto IL_209;
				IL_1A4:
				num2 = 26;
				foreach (DataRow dataRow2 in array)
				{
					IL_1B7:
					num2 = 27;
					if (dataView.Find(RuntimeHelpers.GetObjectValue(dataRow2[A_0])) >= 0)
					{
						IL_1D1:
						num2 = 28;
						dataRow2["System_Filter_Unique"] = null;
					}
					else
					{
						IL_1E3:
						num2 = 30;
						dataRow2["System_Filter_Unique"] = 1;
					}
					IL_1F8:
					num2 = 31;
				}
				IL_209:
				num2 = 32;
				Oo00.o0_o._O_.(a_);
				IL_213:
				num2 = 33;
				List<OoO_O00>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					OoO_O00 ooO_O = enumerator2.Current;
					IL_229:
					num2 = 34;
					ooO_O.O._00000.(this);
					IL_234:
					num2 = 35;
				}
				IL_240:
				num2 = 36;
				((IDisposable)enumerator2).Dispose();
				IL_250:
				num2 = 37;
				if (Operators.CompareString(this.Filter, "", true) != 0)
				{
					goto IL_276;
				}
				IL_266:
				num2 = 38;
				this.Filter = "[System_Filter_Unique] = 1";
				goto IL_2BB;
				IL_276:
				num2 = 40;
				if (this.Filter.IndexOf("[System_Filter_Unique]") >= 0)
				{
					goto IL_2AC;
				}
				IL_28C:
				num2 = 41;
				this.Filter = "(" + this.Filter + ") And [System_Filter_Unique] = 1";
				goto IL_2BB;
				IL_2AC:
				num2 = 43;
				this.Filter = this.Filter;
				IL_2BB:
				num2 = 44;
				this.ResumeRedraw();
				IL_2C4:
				goto IL_3CA;
				IL_2C9:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_38B:
				goto IL_3BF;
				IL_38D:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_39D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_38D;
			}
			IL_3BF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3CA:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x001452F8 File Offset: 0x001434F8
		private void <<EMPTY_NAME>>(string A_0, int A_1)
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
				IL_0B:
				num2 = 3;
				if (this == null)
				{
					goto IL_3E7;
				}
				IL_13:
				num2 = 5;
				if (this.View.Count <= 1)
				{
					goto IL_3E7;
				}
				IL_26:
				num2 = 8;
				this.ClearEditInfos();
				IL_2E:
				num2 = 9;
				List<OoO_O00> list = new List<OoO_O00>();
				IL_38:
				num2 = 10;
				if (!this.View.o_oo._0Oo.() && !this.View.O0OOO_0.o.() && !this.View.O0O.o__0.())
				{
					goto IL_85;
				}
				IL_62:
				num2 = 11;
				DataRow[] array = this.View.o_o.O0ooOo.().Select(this.View.oo_0._o.(), A_0);
				goto IL_DE;
				IL_85:
				num2 = 13;
				array = new DataRow[this.View.Count - 1 + 1];
				IL_9E:
				num2 = 14;
				int num3 = this.View.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_B5:
					num2 = 15;
					array[i] = this.View.O0O_0_0__.0O.(i).Row;
					IL_CF:
					num2 = 16;
				}
				IL_DE:
				num2 = 17;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table = enumerator.Current;
					IL_F8:
					num2 = 18;
					if (table.View.o_o.O0ooOo.() == this.View.o_o.O0ooOo.())
					{
						IL_114:
						num2 = 19;
						list.Add(new OoO_O00(table));
					}
					IL_125:
					num2 = 20;
				}
				IL_131:
				num2 = 21;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_13F:
				num2 = 22;
				Dictionary<DataColumn, string> a_ = Oo00.ooO.ooo.(this.DataTable.BaseTable);
				IL_154:
				num2 = 23;
				if (Operators.CompareString(array[0][A_0].ToString(), array[1][A_0].ToString(), true) != 0)
				{
					goto IL_196;
				}
				IL_17D:
				num2 = 24;
				array[0]["System_Filter_Unique"] = 1;
				goto IL_1A8;
				IL_196:
				num2 = 26;
				array[0]["System_Filter_Unique"] = null;
				IL_1A8:
				num2 = 27;
				if (Operators.CompareString(array[array.Length - 1][A_0].ToString(), array[array.Length - 2][A_0].ToString(), true) != 0)
				{
					goto IL_1F9;
				}
				IL_1DB:
				num2 = 28;
				array[array.Length - 1]["System_Filter_Unique"] = 1;
				goto IL_210;
				IL_1F9:
				num2 = 30;
				array[array.Length - 1]["System_Filter_Unique"] = null;
				IL_210:
				num2 = 31;
				int num4 = array.Length - 2;
				for (int j = 1; j <= num4; j++)
				{
					IL_223:
					num2 = 32;
					if (Operators.CompareString(array[j][A_0].ToString(), array[j - 1][A_0].ToString(), true) == 0)
					{
						IL_250:
						num2 = 33;
						array[j]["System_Filter_Unique"] = 1;
					}
					else
					{
						IL_26A:
						num2 = 35;
						if (Operators.CompareString(array[j][A_0].ToString(), array[j + 1][A_0].ToString(), true) == 0)
						{
							IL_297:
							num2 = 36;
							array[j]["System_Filter_Unique"] = 1;
						}
						else
						{
							IL_2B1:
							num2 = 38;
							array[j]["System_Filter_Unique"] = null;
						}
					}
					IL_2C4:
					num2 = 39;
				}
				IL_2D6:
				num2 = 40;
				Oo00.o0_o._O_.(a_);
				IL_2E0:
				num2 = 41;
				List<OoO_O00>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					OoO_O00 ooO_O = enumerator2.Current;
					IL_2F7:
					num2 = 42;
					ooO_O.O._00000.(this);
					IL_302:
					num2 = 43;
				}
				IL_30E:
				num2 = 44;
				((IDisposable)enumerator2).Dispose();
				IL_31E:
				num2 = 45;
				if (A_1 != 1)
				{
					goto IL_384;
				}
				IL_325:
				num2 = 46;
				if (Operators.CompareString(this.Filter, "", true) != 0)
				{
					goto IL_34E;
				}
				IL_33B:
				num2 = 47;
				this.Filter = "[System_Filter_Unique] = 1";
				goto IL_3DE;
				IL_34E:
				num2 = 49;
				if (this.Filter.IndexOf("[System_Filter_Unique]") >= 0)
				{
					goto IL_3DE;
				}
				IL_364:
				num2 = 50;
				this.Filter = "(" + this.Filter + ") And [System_Filter_Unique] = 1";
				goto IL_3DE;
				IL_384:
				num2 = 52;
				if (Operators.CompareString(this.Filter, "", true) != 0)
				{
					goto IL_3AA;
				}
				IL_39A:
				num2 = 53;
				this.Filter = "[System_Filter_Unique] Is Null";
				goto IL_3DE;
				IL_3AA:
				num2 = 55;
				if (this.Filter.IndexOf("[System_Filter_Unique]") >= 0)
				{
					goto IL_3DE;
				}
				IL_3C0:
				num2 = 56;
				this.Filter = "(" + this.Filter + ") And [System_Filter_Unique] Is Null";
				IL_3DE:
				num2 = 57;
				this.ResumeRedraw();
				IL_3E7:
				goto IL_521;
				IL_3EC:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_4E2:
				goto IL_516;
				IL_4E4:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4F4:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4E4;
			}
			IL_516:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_521:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0014584C File Offset: 0x00143A4C
		private void <<EMPTY_NAME>>(string A_0, int A_1)
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
				IL_0B:
				num2 = 3;
				if (this == null)
				{
					goto IL_2CB;
				}
				IL_13:
				num2 = 5;
				if (this.View.Count <= 1)
				{
					goto IL_2CB;
				}
				IL_26:
				num2 = 8;
				this.ClearEditInfos();
				IL_2E:
				num2 = 9;
				List<OoO_O00> list = new List<OoO_O00>();
				IL_38:
				num2 = 10;
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_1 == 0, 1, null));
				IL_52:
				num2 = 11;
				object objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_1 == 0, null, 1));
				IL_6C:
				num2 = 12;
				if (!this.View.o_oo._0Oo.() && !this.View.O0OOO_0.o.() && !this.View.O0O.o__0.())
				{
					goto IL_B9;
				}
				IL_96:
				num2 = 13;
				DataRow[] array = this.View.o_o.O0ooOo.().Select(this.View.oo_0._o.(), A_0);
				goto IL_112;
				IL_B9:
				num2 = 15;
				array = new DataRow[this.View.Count - 1 + 1];
				IL_D2:
				num2 = 16;
				int num3 = this.View.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_E9:
					num2 = 17;
					array[i] = this.View.O0O_0_0__.0O.(i).Row;
					IL_103:
					num2 = 18;
				}
				IL_112:
				num2 = 19;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table = enumerator.Current;
					IL_12C:
					num2 = 20;
					if (table.View.o_o.O0ooOo.() == this.View.o_o.O0ooOo.())
					{
						IL_148:
						num2 = 21;
						list.Add(new OoO_O00(table));
					}
					IL_159:
					num2 = 22;
				}
				IL_165:
				num2 = 23;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_173:
				num2 = 24;
				Dictionary<DataColumn, string> a_ = Oo00.ooO.ooo.(this.DataTable.BaseTable);
				IL_188:
				num2 = 25;
				array[0]["System_Filter_Unique"] = RuntimeHelpers.GetObjectValue(objectValue);
				IL_1A0:
				num2 = 26;
				int num4 = array.Length - 1;
				for (int j = 1; j <= num4; j++)
				{
					IL_1B0:
					num2 = 27;
					if (Operators.CompareString(array[j][A_0].ToString(), array[j - 1][A_0].ToString(), true) == 0)
					{
						IL_1DD:
						num2 = 28;
						array[j]["System_Filter_Unique"] = RuntimeHelpers.GetObjectValue(objectValue2);
					}
					else
					{
						IL_1F8:
						num2 = 30;
						array[j]["System_Filter_Unique"] = RuntimeHelpers.GetObjectValue(objectValue);
					}
					IL_211:
					num2 = 31;
				}
				IL_220:
				num2 = 32;
				Oo00.o0_o._O_.(a_);
				IL_22A:
				num2 = 33;
				List<OoO_O00>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					OoO_O00 ooO_O = enumerator2.Current;
					IL_241:
					num2 = 34;
					ooO_O.O._00000.(this);
					IL_24C:
					num2 = 35;
				}
				IL_258:
				num2 = 36;
				((IDisposable)enumerator2).Dispose();
				IL_268:
				num2 = 37;
				if (Operators.CompareString(this.Filter, "", true) != 0)
				{
					goto IL_28E;
				}
				IL_27E:
				num2 = 38;
				this.Filter = "[System_Filter_Unique] = 1";
				goto IL_2C2;
				IL_28E:
				num2 = 40;
				if (this.Filter.IndexOf("[System_Filter_Unique]") >= 0)
				{
					goto IL_2C2;
				}
				IL_2A4:
				num2 = 41;
				this.Filter = "(" + this.Filter + ") And [System_Filter_Unique] = 1";
				IL_2C2:
				num2 = 42;
				this.ResumeRedraw();
				IL_2CB:
				goto IL_3C9;
				IL_2D0:
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_38A:
				goto IL_3BE;
				IL_38C:
				num6 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_39C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_38C;
			}
			IL_3BE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3C9:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 重复值筛选
		/// </summary>
		/// <param name="ColName">筛选列</param>
		/// <param name="Mode">筛选模式</param>
		/// <param name="backFilter">是否后台筛选</param>
		// Token: 0x06002C93 RID: 11411 RVA: 0x00145C48 File Offset: 0x00143E48
		[oO0oooo("2712")]
		public void RepeatFilter(string ColName, int Mode, bool backFilter = false)
		{
			if (backFilter && this.DataTable.BaseTable.PrimaryKey.Length != 1)
			{
				backFilter = false;
			}
			switch (Mode)
			{
			case 0:
				if (backFilter)
				{
					this.o_0_O__o0O.oo.(ColName, 1);
					return;
				}
				this.o0O_o0.oOO.(ColName, 1);
				return;
			case 1:
				if (backFilter)
				{
					this.O____o.0.(ColName, Conversions.ToString(0));
					return;
				}
				this.OO.0OO000_0__.(ColName, 0);
				return;
			case 2:
				if (backFilter)
				{
					this.O____o.0.(ColName, Conversions.ToString(1));
					return;
				}
				this.OO.0OO000_0__.(ColName, 1);
				return;
			case 3:
				if (backFilter)
				{
					this.o_0_O__o0O.oo.(ColName, 2);
					return;
				}
				this.o0O_o0.oOO.(ColName, 2);
				return;
			default:
				return;
			}
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00145CE8 File Offset: 0x00143EE8
		internal void <<EMPTY_NAME>>(string A_0, int A_1)
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
				string text = "";
				IL_0F:
				num2 = 3;
				string a_ = "ShowBackSameValues\v" + A_0 + "\v" + Conversions.ToString(A_1);
				IL_29:
				num2 = 4;
				string text2 = Oo00.oo_0__0.o.(this.DataTable._Adapter.SelectCommand.CommandText);
				IL_47:
				num2 = 5;
				A_0 = Oo00.OoOo_oo_.o_o.(A_0, this);
				IL_52:
				num2 = 6;
				if (A_1 != 1)
				{
					goto IL_68;
				}
				IL_58:
				num2 = 7;
				text = A_0 + " in ";
				goto IL_77;
				IL_68:
				num2 = 9;
				text = A_0 + " not in ";
				IL_77:
				num2 = 10;
				if (Operators.CompareString(this.DataTable.LoadFilter, "", true) <= 0)
				{
					goto IL_10C;
				}
				IL_93:
				num2 = 11;
				text = string.Concat(new string[]
				{
					text,
					"( Select ",
					A_0,
					" From ",
					text2,
					" Where ",
					this.DataTable.LoadFilter,
					" group by ",
					A_0,
					" having count(*) > 1)"
				});
				IL_EB:
				num2 = 12;
				text = "(" + this.DataTable.LoadFilter + ") And " + text;
				goto IL_14C;
				IL_10C:
				num2 = 14;
				text = string.Concat(new string[]
				{
					text,
					"( Select ",
					A_0,
					" From ",
					text2,
					" group by ",
					A_0,
					" having count(*) > 1)"
				});
				IL_14C:
				num2 = 15;
				this.DataTable.LoadPage = 0;
				IL_15B:
				num2 = 16;
				this.DataTable.OOO_o_O.OO0o.(text, a_);
				IL_16C:
				num2 = 17;
				this.DataTable.o0.o.(true, null);
				IL_17C:
				num2 = 18;
				if (this.O.OoOo_. == null || this.O.OoOo_..FindForm() == null)
				{
					goto IL_1A2;
				}
				IL_194:
				num2 = 19;
				this.O.OoOo_..oO.Oo0__O_.();
				IL_1A2:
				goto IL_244;
				IL_1A7:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_205:
				goto IL_239;
				IL_207:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_217:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_207;
			}
			IL_239:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_244:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x00145F60 File Offset: 0x00144160
		internal void <<EMPTY_NAME>>(string A_0, string A_1)
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
				string a_ = "BackSameValuesFilter\v" + A_0 + "\v" + A_1;
				IL_1C:
				num2 = 3;
				string text = Oo00.oo_0__0.o.(this.DataTable._Adapter.SelectCommand.CommandText);
				IL_3A:
				num2 = 4;
				string text2 = this.DataTable.BaseTable.PrimaryKey[0].ColumnName;
				IL_55:
				num2 = 5;
				text2 = Oo00.OoOo_oo_.o_o.(text2, this);
				IL_61:
				num2 = 6;
				A_0 = Oo00.OoOo_oo_.o_o.(A_0, this);
				IL_6C:
				num2 = 7;
				if (Conversions.ToDouble(A_1) != 0.0)
				{
					goto IL_90;
				}
				IL_7F:
				num2 = 8;
				string text3 = text2 + " in ";
				goto IL_A0;
				IL_90:
				num2 = 10;
				text3 = text2 + " not in ";
				IL_A0:
				num2 = 11;
				if (Operators.CompareString(this.DataTable.LoadFilter, "", true) <= 0)
				{
					goto IL_136;
				}
				IL_BC:
				num2 = 12;
				text3 = string.Concat(new string[]
				{
					text3,
					"(Select min(",
					text2,
					") From ",
					text,
					" Where ",
					this.DataTable.LoadFilter,
					" Group by ",
					A_0,
					")"
				});
				IL_115:
				num2 = 13;
				text3 = "(" + this.DataTable.LoadFilter + ") And " + text3;
				goto IL_177;
				IL_136:
				num2 = 15;
				text3 = string.Concat(new string[]
				{
					text3,
					"(Select min(",
					text2,
					") From ",
					text,
					" Group by ",
					A_0,
					")"
				});
				IL_177:
				num2 = 16;
				this.DataTable.LoadPage = 0;
				IL_186:
				num2 = 17;
				this.DataTable.OOO_o_O.OO0o.(text3, a_);
				IL_197:
				num2 = 18;
				this.DataTable.o0.o.(true, null);
				IL_1A7:
				num2 = 19;
				if (this.O.OoOo_. == null || this.O.OoOo_..FindForm() == null)
				{
					goto IL_1CD;
				}
				IL_1BF:
				num2 = 20;
				this.O.OoOo_..oO.Oo0__O_.();
				IL_1CD:
				goto IL_273;
				IL_1D2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_234:
				goto IL_268;
				IL_236:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_246:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_236;
			}
			IL_268:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_273:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 打开高级筛选窗口
		/// </summary>
		// Token: 0x06002C96 RID: 11414 RVA: 0x00146204 File Offset: 0x00144404
		[oO0oooo("0126")]
		public void AdvancedFilter()
		{
			new ef(this)
			{
				Owner = Main.OO_O.o.
			}.Show();
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x0014621C File Offset: 0x0014441C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AdvancedFilter(bool Dialog)
		{
			if (!Dialog)
			{
				this.AdvancedFilter();
				return;
			}
			new ef(this).Show();
		}

		/// <summary>
		/// 打开分组统计设置窗口
		/// </summary>
		/// <param name="last">是否继承上次分组统计设置</param>
		// Token: 0x06002C98 RID: 11416 RVA: 0x00146233 File Offset: 0x00144433
		[oO0oooo("2731")]
		public void GroupSubtotal(bool last = true)
		{
			new j8(!last, this).ShowDialog();
		}

		/// <summary>
		/// 打开交叉统计窗口
		/// </summary>
		/// <param name="last">是否继承上次分组统计设置</param>
		// Token: 0x06002C99 RID: 11417 RVA: 0x00146245 File Offset: 0x00144445
		[oO0oooo("2732")]
		public void CrossSubtotal(bool last = true)
		{
			new mf(!last, this).ShowDialog();
		}

		/// <summary>
		/// 打开汇总模式设置窗口
		/// </summary>
		/// <param name="last">是否继承上次分组统计设置</param>
		// Token: 0x06002C9A RID: 11418 RVA: 0x00146257 File Offset: 0x00144457
		[oO0oooo("2733")]
		public void SetSubtotalMode(bool last = true)
		{
			new du(this, !last).ShowDialog();
		}

		/// <summary>
		/// 打开合并模式设置窗口
		/// </summary>
		// Token: 0x06002C9B RID: 11419 RVA: 0x00146269 File Offset: 0x00144469
		[oO0oooo("2734")]
		public void SetMergeMode()
		{
			new O\u3000\u3000\u3000\u3000_\u3002(this).ShowDialog();
		}

		/// <summary>
		/// 保存数据
		/// </summary>
		// Token: 0x06002C9C RID: 11420 RVA: 0x00146277 File Offset: 0x00144477
		public void Save()
		{
			this.DataTable.Save();
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00146284 File Offset: 0x00144484
		internal void <<EMPTY_NAME>>(int A_0)
		{
			int num;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_0 == 0, 1, null));
				IL_20:
				num2 = 3;
				object objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.IIf(A_0 == 0, null, 1));
				IL_39:
				num2 = 4;
				IL_3E:
				num2 = 5;
				Point scrollPosition = this.Grid.ScrollPosition;
				IL_4D:
				num2 = 6;
				if (this.View.O0OOO_0.o.())
				{
					goto IL_366;
				}
				IL_60:
				num2 = 8;
				this.ClearEditInfos();
				IL_69:
				num2 = 9;
				List<DataRow> list = new List<DataRow>();
				IL_73:
				num2 = 10;
				if (!this.View.o_oo._0Oo.() && !this.View.O0OOO_0.o.())
				{
					goto IL_B6;
				}
				IL_92:
				num2 = 11;
				DataRow[] array = this.View.o_o.O0ooOo.().Select(this.View.oo_0._o.());
				goto IL_112;
				IL_B6:
				num2 = 13;
				array = new DataRow[this.View.Count - 1 + 1];
				IL_D0:
				num2 = 14;
				int num3 = this.View.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					IL_E8:
					num2 = 15;
					array[i] = this.View.O0O_0_0__.0O.(i).Row;
					IL_103:
					num2 = 16;
				}
				IL_112:
				num2 = 17;
				int topRow = this.foxGrid.Selection.TopRow;
				IL_12C:
				num2 = 18;
				int bottomRow = this.foxGrid.Selection.BottomRow;
				IL_146:
				num2 = 19;
				if (bottomRow < 0)
				{
					goto IL_366;
				}
				IL_151:
				num2 = 21;
				int num4 = bottomRow;
				int num5 = topRow;
				for (int j = num4; j >= num5; j += -1)
				{
					IL_15E:
					num2 = 22;
					int dataIndex = this.foxGrid.Rows[j].DataIndex;
					IL_17A:
					num2 = 23;
					if (dataIndex >= 0)
					{
						IL_181:
						num2 = 24;
						list.Add(this.View.O0O_0_0__.0O.(dataIndex).Row);
					}
					IL_19D:
					num2 = 25;
				}
				IL_1AC:
				num2 = 26;
				List<OoO_O00> list2 = new List<OoO_O00>();
				IL_1B6:
				num2 = 27;
				IEnumerator<Table> enumerator = OO_00oOO.Tables.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Table table = enumerator.Current;
					IL_1D0:
					num2 = 28;
					if (table.View.o_o.O0ooOo.() == this.View.o_o.O0ooOo.())
					{
						IL_1ED:
						num2 = 29;
						list2.Add(new OoO_O00(table));
					}
					IL_1FE:
					num2 = 30;
				}
				IL_20A:
				num2 = 31;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
				IL_218:
				num2 = 32;
				foreach (DataRow dataRow in array)
				{
					IL_22B:
					num2 = 33;
					dataRow["System_Filter_Unique"] = RuntimeHelpers.GetObjectValue(objectValue);
					IL_241:
					num2 = 34;
				}
				IL_252:
				num2 = 35;
				List<DataRow>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = enumerator2.Current;
					IL_269:
					num2 = 36;
					dataRow2["System_Filter_Unique"] = RuntimeHelpers.GetObjectValue(objectValue2);
					IL_27F:
					num2 = 37;
				}
				IL_28B:
				num2 = 38;
				((IDisposable)enumerator2).Dispose();
				IL_29B:
				num2 = 39;
				List<OoO_O00>.Enumerator enumerator3 = list2.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					OoO_O00 ooO_O = enumerator3.Current;
					IL_2B2:
					num2 = 40;
					ooO_O.O._00000.(this);
					IL_2BE:
					num2 = 41;
				}
				IL_2CA:
				num2 = 42;
				((IDisposable)enumerator3).Dispose();
				IL_2DA:
				num2 = 43;
				if (Operators.CompareString(this.Filter, "", true) != 0)
				{
					goto IL_302;
				}
				IL_2F1:
				num2 = 44;
				this.Filter = "[System_Filter_Unique] Is Not Null";
				goto IL_34C;
				IL_302:
				num2 = 46;
				if (this.Filter.IndexOf("[System_Filter_Unique]") >= 0)
				{
					goto IL_33B;
				}
				IL_319:
				num2 = 47;
				this.Filter = "(" + this.Filter + ") And [System_Filter_Unique] Is Not Null";
				goto IL_34C;
				IL_33B:
				num2 = 49;
				this.Filter = this.Filter;
				IL_34C:
				num2 = 50;
				this.Grid.ScrollPosition = scrollPosition;
				IL_35C:
				num2 = 51;
				this.ResumeRedraw();
				IL_366:
				goto IL_488;
				IL_36B:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_449:
				goto IL_47D;
				IL_44B:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_45B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_44B;
			}
			IL_47D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_488:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 隐藏未选定行
		/// </summary>
		// Token: 0x06002C9E RID: 11422 RVA: 0x00146740 File Offset: 0x00144940
		public void HideUnSelectedRows()
		{
			this.o.O0___OOo0_oO.(1);
		}

		/// <summary>
		/// 隐藏选定行
		/// </summary>
		// Token: 0x06002C9F RID: 11423 RVA: 0x00146749 File Offset: 0x00144949
		public void HideSelectedRows()
		{
			this.o.O0___OOo0_oO.(0);
		}

		/// <summary>
		/// 打开内置计算器
		/// </summary>
		// Token: 0x06002CA0 RID: 11424 RVA: 0x00146752 File Offset: 0x00144952
		[oO0oooo("2737")]
		public void OpenCalculator()
		{
			new O\u3002\u3000\u3002\u3002(this)
			{
				Owner = Main.OO_O.o.
			}.Show();
		}

		/// <summary>
		/// 循环引用筛选
		/// </summary>
		/// <param name="ParentCol">父列</param>
		/// <param name="Childcol">子列</param>
		// Token: 0x06002CA1 RID: 11425 RVA: 0x0014676C File Offset: 0x0014496C
		[oO0oooo("3379")]
		public void LoopFilter(string ParentCol, string Childcol)
		{
			int num;
			int num10;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				this.StopRedraw();
				IL_0F:
				num2 = 3;
				DataView dataView = new DataView(this.DataTable.BaseTable, "", ParentCol, DataViewRowState.CurrentRows);
				IL_2A:
				num2 = 4;
				int num3 = this.DataTable.BaseTable.Columns.IndexOf("System_Filter_Unique");
				IL_48:
				num2 = 5;
				int num4 = this.DataTable.BaseTable.Columns.IndexOf(ParentCol);
				IL_62:
				num2 = 6;
				int num5 = this.DataTable.BaseTable.Columns.IndexOf(Childcol);
				IL_7C:
				num2 = 7;
				string text = "";
				IL_85:
				num2 = 8;
				List<DataRowView> list = new List<DataRowView>();
				IL_8E:
				num2 = 9;
				int num6 = dataView.Count - 1;
				for (int i = 0; i <= num6; i++)
				{
					IL_A0:
					num2 = 10;
					dataView[i][num3] = DBNull.Value;
					IL_B7:
					num2 = 11;
				}
				IL_C6:
				num2 = 12;
				int num7 = 0;
				IL_CC:
				num2 = 13;
				int num8 = dataView.Count - 1;
				for (int j = 0; j <= num8; j++)
				{
					IL_E1:
					num2 = 14;
					if (Operators.CompareString(dataView[j][num4].ToString(), dataView[j][num5].ToString(), true) != 0)
					{
						IL_117:
						num2 = 16;
						text = Conversions.ToString(dataView[j][num4]);
						IL_130:
						num2 = 17;
						DataRowView[] array = dataView.FindRows(RuntimeHelpers.GetObjectValue(dataView[j][num5]));
						IL_14F:
						num2 = 18;
						HashSet<string> hashSet = new HashSet<string>();
						IL_159:
						num2 = 19;
						hashSet.Add(text);
						IL_166:
						num2 = 20;
						foreach (DataRowView dataRowView in array)
						{
							IL_179:
							num2 = 21;
							if (this.DiguiLoopFilter(dataRowView, num4, num5, num3, text, list, hashSet))
							{
								IL_192:
								num2 = 22;
								if (!list.Contains(dataRowView))
								{
									IL_1A0:
									num2 = 23;
									list.Add(dataRowView);
								}
								IL_1AC:
								num2 = 24;
								if (!list.Contains(dataView[j]))
								{
									IL_1C0:
									num2 = 25;
									list.Add(dataView[j]);
								}
							}
							IL_1D2:
							num2 = 26;
						}
						IL_1E3:
						num2 = 27;
						for (int l = list.Count - 1; l >= 0; l += -1)
						{
							IL_1F3:
							num2 = 28;
							if (list[l].Row.IsNull(num3))
							{
								IL_20D:
								num2 = 29;
								list[l][num3] = num7;
							}
							IL_227:
							num2 = 30;
							num7++;
							IL_230:
							num2 = 31;
						}
						IL_23E:
						num2 = 32;
						list.Clear();
					}
					IL_248:
					num2 = 33;
				}
				IL_25A:
				num2 = 34;
				this.Filter = "[System_Filter_Unique] Is Not Null";
				IL_268:
				num2 = 35;
				this.Sort = "System_Filter_Unique";
				IL_276:
				num2 = 36;
				this.ResumeRedraw();
				IL_27F:
				goto IL_365;
				IL_284:
				int num9 = num10 + 1;
				num10 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num9);
				IL_326:
				goto IL_35A;
				IL_328:
				num10 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_338:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num10 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_328;
			}
			IL_35A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_365:
			if (num10 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00146B04 File Offset: 0x00144D04
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool DiguiLoopFilter(DataRowView vr, int parentidx, int childidx, int filtidx, string RootKey, List<DataRowView> returnvrs, HashSet<string> ParentKeys)
		{
			int num;
			bool result;
			int num4;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (Operators.CompareString(vr[parentidx].ToString(), vr[childidx].ToString(), true) != 0)
				{
					goto IL_32;
				}
				IL_29:
				num2 = 3;
				result = false;
				goto IL_131;
				IL_32:
				num2 = 4;
				if (Operators.CompareString(vr[childidx].ToString(), RootKey, true) != 0)
				{
					goto IL_69;
				}
				IL_4A:
				num2 = 5;
				if (returnvrs.Contains(vr))
				{
					goto IL_60;
				}
				IL_56:
				num2 = 6;
				returnvrs.Add(vr);
				IL_60:
				num2 = 7;
				result = true;
				goto IL_131;
				IL_69:
				num2 = 9;
				if (!ParentKeys.Contains(vr[childidx].ToString()))
				{
					goto IL_8B;
				}
				IL_81:
				num2 = 10;
				result = false;
				goto IL_131;
				IL_8B:
				num2 = 12;
				ParentKeys.Add(vr[childidx].ToString());
				IL_A2:
				num2 = 13;
				bool flag = false;
				IL_A8:
				num2 = 14;
				DataRowView[] array = vr.DataView.FindRows(RuntimeHelpers.GetObjectValue(vr[childidx]));
				IL_C4:
				num2 = 15;
				foreach (DataRowView dataRowView in array)
				{
					IL_D7:
					num2 = 16;
					HashSet<string> parentKeys = new HashSet<string>(ParentKeys);
					IL_E3:
					num2 = 17;
					if (this.DiguiLoopFilter(dataRowView, parentidx, childidx, filtidx, RootKey, returnvrs, parentKeys))
					{
						IL_FA:
						num2 = 18;
						if (!returnvrs.Contains(dataRowView))
						{
							IL_108:
							num2 = 19;
							returnvrs.Add(dataRowView);
						}
						IL_114:
						num2 = 20;
						flag = true;
					}
					IL_11A:
					num2 = 21;
				}
				IL_12B:
				num2 = 22;
				result = flag;
				IL_131:
				goto IL_1DF;
				IL_136:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1A0:
				goto IL_1D4;
				IL_1A2:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1B2:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1A2;
			}
			IL_1D4:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1DF:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		/// <summary>
		/// 多列重复值筛选
		/// </summary>
		/// <param name="Columns">一个字符串数组，指定要筛选的多个列名</param>
		// Token: 0x06002CA3 RID: 11427 RVA: 0x00146D18 File Offset: 0x00144F18
		[oO0oooo("3380")]
		public void DuplicateValuesFilter(string[] Columns)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string item in Columns)
			{
				hashSet.Add(item);
			}
			List<string> list = new List<string>();
			list.AddRange(hashSet);
			Columns = list.ToArray();
			string text = Columns[0];
			int[] array2 = new int[Columns.Length - 1 + 1];
			int num = this.DataTable.BaseTable.Columns.IndexOf("System_Filter_Unique");
			array2[0] = this.DataTable.BaseTable.Columns.IndexOf(Columns[0]);
			int num2 = Columns.Length - 1;
			for (int j = 1; j <= num2; j++)
			{
				text = text + "," + Columns[j];
				array2[j] = this.DataTable.BaseTable.Columns.IndexOf(Columns[j]);
			}
			OO_00oOO.LockBaseMainForm();
			this.StopRedraw();
			this.Sort = "";
			DataView dataView = new DataView(this.DataTable.BaseTable, "", text, DataViewRowState.CurrentRows);
			dataView[0][num] = DBNull.Value;
			int num3 = dataView.Count - 1;
			for (int k = 1; k <= num3; k++)
			{
				int num4 = 0;
				foreach (int ndx in array2)
				{
					if (Operators.CompareString(dataView[k][ndx].ToString(), dataView[k - 1][ndx].ToString(), true) != 0)
					{
						num4 = -1;
						break;
					}
				}
				if (num4 == 0)
				{
					dataView[k][num] = 0;
					if (dataView[k - 1].Row.IsNull(num))
					{
						dataView[k - 1][num] = 0;
					}
				}
				else
				{
					dataView[k][num] = DBNull.Value;
				}
			}
			this.Sort = text;
			this.Filter = "[System_Filter_Unique] Is Not Null";
			this.ResumeRedraw();
			OO_00oOO.UnlockBaseMainForm();
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00146F2C File Offset: 0x0014512C
		internal void <<EMPTY_NAME>>()
		{
			int num;
			try
			{
				IEnumerator<Col> enumerator = this.Cols.GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsNumeric())
					{
						num = 1;
						break;
					}
				}
			}
			finally
			{
				IEnumerator<Col> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			if (num == 0)
			{
				MessageBox.Show("只有数值型的列才能进行统计，当前表没有数值列，请合理设置列的数据类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		/// <summary>
		/// 如果Table位于自定义窗口中，可以通过此属性返回其所在窗口.
		/// </summary>
		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x00146F94 File Offset: 0x00145194
		public Foxtable.WinForm.Form Form
		{
			get
			{
				for (System.Windows.Forms.Control parent = this.Grid.Parent; parent != null; parent = parent.Parent)
				{
					if (parent is FormPanel)
					{
						return OO_00oOO.Forms[parent.Name];
					}
				}
				return null;
			}
		}

		/// <summary>
		/// 逻辑型，分页加载时，是否允许筛选后台数据
		/// </summary>
		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00146FD8 File Offset: 0x001451D8
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x00147006 File Offset: 0x00145206
		[oO0oooo("2892")]
		public bool AllowBackEndFilter
		{
			get
			{
				return !this.IsRelation && this.DataTable.CannBackEndFilter && this.O___O0.000OO__.;
			}
			set
			{
				this.O___O0.000OO__. = value;
				if (value && Operators.CompareString(this.Filter, "", true) > 0)
				{
					this.Filter = "";
				}
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x00147031 File Offset: 0x00145231
		// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x0014703D File Offset: 0x0014523D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool UseVisualStyle
		{
			get
			{
				return Conversions.ToBoolean("");
			}
			set
			{
			}
		}

		/// <summary>
		/// 用于设置Table的样式
		/// </summary>
		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x00147040 File Offset: 0x00145240
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x00147078 File Offset: 0x00145278
		[oO0oooo("3305")]
		public string Theme
		{
			get
			{
				string result;
				if (Operators.CompareString(this.ooo00.o0__OO0., "(default)", true) == 0)
				{
					result = this.DataTable.Theme;
				}
				else
				{
					result = this.ooo00.o0__OO0.;
				}
				return result;
			}
			set
			{
				this.ooo00.o0__OO0. = value;
				if (this.Grid.FindForm() != null)
				{
					Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
					{
						this.Grid
					});
					Main.OO_O.o..Oo.oOo_o0Oo0.(this.Theme, new object[]
					{
						this.Grid
					});
					this.foxGrid.Oo0._0.();
				}
			}
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x001470DC File Offset: 0x001452DC
		internal void <<EMPTY_NAME>>()
		{
			Main.OO_O.o..o0oO_O.0Oo_00.(new object[]
			{
				this.Grid
			});
			Main.OO_O.o..Oo.oOo_o0Oo0.(this.Theme, new object[]
			{
				this.Grid
			});
			this.foxGrid.Oo0._0.();
		}

		/// <summary>
		/// 获取系统样式集合
		/// </summary>
		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x0014712C File Offset: 0x0014532C
		[oO0oooo("1577")]
		public CellStyleCollection SysStyles
		{
			get
			{
				return this.foxGrid.Styles;
			}
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00147139 File Offset: 0x00145339
		internal void <<EMPTY_NAME>>(string[] A_0, string A_1, int A_2 = -1)
		{
			this.OOo0_Oo._OOo.(A_0, A_1, "", false, A_2);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0014714C File Offset: 0x0014534C
		internal void <<EMPTY_NAME>>(string[] A_0, string A_1, string A_2, bool A_3, int A_4 = -1)
		{
			string text = "";
			foreach (string text2 in A_0)
			{
				if (!this.DataTable.BaseTable.Columns.Contains(text2))
				{
					return;
				}
				text = text + text2 + ",";
			}
			text = text.Trim(new char[]
			{
				','
			});
			if (Operators.CompareString(A_2, "", true) > 0)
			{
				text = text + "," + A_2;
				if (A_3)
				{
					text += " Desc";
				}
			}
			List<string> list = new List<string>();
			this.o.0ooOO_0__..Clear();
			if (Operators.CompareString(A_1, "", true) > 0)
			{
				foreach (string text3 in A_1.Split(new char[]
				{
					','
				}))
				{
					if (this.DataTable.DataCols.Contains(text3) && this.DataTable.DataCols[text3].IsNumeric)
					{
						list.Add(text3);
						this.o.0ooOO_0__..Add(text3);
					}
				}
			}
			this.o.o0o_0. = true;
			if (this.o.0ooOO_0__. != null)
			{
				this.o.0ooOO_0__..Clear();
			}
			this.o.0ooOO_0__. = new Oo0();
			this.o.0ooOO_0__..O_OOO.0o. = A_0;
			this.O0_O.0oOO0Oo0. = A_2;
			this.oO_.ooo0o. = A_3;
			OO_00oOO.LockBaseMainForm();
			this.StopRedraw();
			try
			{
				this.Grid.Tree.Style = TreeStyleFlags.Symbols;
				this.Grid.Tree.Column = this.Grid.Cols.Fixed;
				this.foxGrid.Subtotal(AggregateEnum.Clear);
				this.foxGrid.SubtotalPosition = SubtotalPositionEnum.AboveData;
				DataView dataView = new DataView(this.DataTable.BaseTable, "", text, DataViewRowState.CurrentRows);
				int num = dataView.Count - 1;
				for (int k = 0; k <= num; k++)
				{
					dataView[k]["System_Sort_Temporary"] = k;
				}
				this.Sort = "[System_Sort_Temporary]";
				C1FlexGrid o_o0OOo_.o0. = this.O_o0OOo_.o0.;
				int l = o_o0OOo_.o0..Rows.Fixed;
				int num2 = -1;
				while (l <= o_o0OOo_.o0..Rows.Count - 1)
				{
					int num3 = this.o.oO__OO_oo_0_.(l, num2, A_0);
					if (num3 > -1)
					{
						num2 = o_o0OOo_.o0..Rows[l].DataIndex;
						int num4 = num3;
						int num5 = A_0.Length - 1;
						for (int m = num4; m <= num5; m++)
						{
							o_o0OOo_.o0..Rows.InsertNode(l, m);
							int num6 = m;
							for (int n = 0; n <= num6; n++)
							{
								o_o0OOo_.o0..Rows[l][A_0[n]] = RuntimeHelpers.GetObjectValue(this.View.O0O_0_0__.0O.(num2)[A_0[n]]);
								o_o0OOo_.o0..Rows[l].Style = this.Grid.Styles[14 + m % 6];
							}
							l++;
						}
					}
					l++;
				}
				this.O_o0OOo_.o0..Oo.0.(true);
				this.O_o0OOo_.o0..SetUserData(this.O_o0OOo_.o0..Rows.Fixed, 0, "GridTreeMode");
				for (int num7 = A_0.Length - 1; num7 >= A_4; num7 += -1)
				{
					this.O_o0OOo_.o0..Tree.Show(num7);
				}
				if (list.Count > 0)
				{
					Dictionary<string, double> dictionary = new Dictionary<string, double>();
					C1.Win.C1FlexGrid.Row row = this.Grid.Rows[this.Grid.Rows.Count - 1];
					try
					{
						foreach (string text4 in list)
						{
							if (row[text4] == DBNull.Value)
							{
								dictionary.Add(text4, 0.0);
							}
							else
							{
								dictionary.Add(text4, Conversion.Val(RuntimeHelpers.GetObjectValue(row[text4])));
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					int num8 = this.Grid.Rows.Count - 2;
					while (num8 >= 0)
					{
						row = this.Grid.Rows[num8];
						if (!row.IsNode)
						{
							goto IL_613;
						}
						if (!this.Grid.Rows[num8 + 1].IsNode)
						{
							try
							{
								foreach (string text5 in list)
								{
									row[text5] = dictionary[text5];
								}
							}
							finally
							{
								List<string>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
						try
						{
							foreach (string key in list)
							{
								dictionary[key] = 0.0;
							}
						}
						finally
						{
							List<string>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						if (this.Grid.Rows[num8 + 1].IsNode)
						{
							foreach (Node node in row.Node.Nodes)
							{
								try
								{
									foreach (string text6 in list)
									{
										if (node.Row[text6] != null && node.Row[text6] != DBNull.Value && node.Row[text6] != DBNull.Value)
										{
											dictionary[text6] += Conversion.Val(RuntimeHelpers.GetObjectValue(node.Row[text6]));
										}
									}
								}
								finally
								{
									List<string>.Enumerator enumerator4;
									((IDisposable)enumerator4).Dispose();
								}
							}
							try
							{
								foreach (string text7 in list)
								{
									row[text7] = dictionary[text7];
									dictionary[text7] = 0.0;
								}
								goto IL_691;
							}
							finally
							{
								List<string>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
							goto IL_613;
						}
						IL_691:
						num8 += -1;
						continue;
						IL_613:
						try
						{
							foreach (string text8 in list)
							{
								if (row[text8] != null && row[text8] != DBNull.Value && row[text8] != DBNull.Value)
								{
									dictionary[text8] += Conversion.Val(RuntimeHelpers.GetObjectValue(row[text8]));
								}
							}
						}
						finally
						{
							List<string>.Enumerator enumerator6;
							((IDisposable)enumerator6).Dispose();
						}
						goto IL_691;
					}
				}
			}
			catch (Exception a_)
			{
				ooO.oOo0Oo.o.(a_, "");
			}
			finally
			{
				this.ResumeRedraw();
				OO_00oOO.UnlockBaseMainForm();
				this.o.o0o_0. = false;
			}
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x001478EC File Offset: 0x00145AEC
		private int <<EMPTY_NAME>>(int A_0, int A_1, string[] A_2)
		{
			if (this.Grid.Rows[A_0].DataIndex > -1)
			{
				if (A_1 == -1)
				{
					return 0;
				}
				int dataIndex = this.Grid.Rows[A_0].DataIndex;
				int num = A_2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(this.View.O0O_0_0__.0O.(dataIndex)[A_2[i]].ToString(), this.View.O0O_0_0__.0O.(A_1)[A_2[i]].ToString(), true) != 0)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x00147984 File Offset: 0x00145B84
		internal void <<EMPTY_NAME>>(string A_0, string A_1, int A_2 = -1)
		{
			this.OOo0_Oo._OOo.(A_0, A_1, "", "", A_2);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0014799C File Offset: 0x00145B9C
		internal void <<EMPTY_NAME>>(string A_0, string A_1, string A_2, string A_3, int A_4 = -1)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				if (this.DataTable.BaseTable.Columns.Contains(A_1) || A_1.Length != 1)
				{
					goto IL_48;
				}
				IL_2A:
				num2 = 3;
				this.O_.o__ooo.(A_0, "", A_1[0], A_3, A_4);
				goto IL_56C;
				IL_48:
				num2 = 5;
				List<string> list = new List<string>();
				IL_50:
				num2 = 6;
				this.o.0ooOO_0__..Clear();
				IL_5D:
				num2 = 7;
				if (Operators.CompareString(A_3, "", true) <= 0)
				{
					goto IL_F8;
				}
				IL_72:
				num2 = 8;
				string[] array = A_3.Split(new char[]
				{
					','
				});
				IL_88:
				num2 = 9;
				foreach (string text in array)
				{
					IL_9B:
					num2 = 10;
					if (this.DataTable.DataCols.Contains(text) && this.DataTable.DataCols[text].IsNumeric)
					{
						IL_CB:
						num2 = 11;
						list.Add(text);
						IL_D6:
						num2 = 12;
						this.o.0ooOO_0__..Add(text);
					}
					IL_E7:
					num2 = 13;
				}
				IL_F8:
				num2 = 14;
				this.o.o0o_0. = true;
				IL_102:
				num2 = 15;
				if (this.o.0ooOO_0__. == null)
				{
					goto IL_11D;
				}
				IL_10D:
				num2 = 16;
				this.o.0ooOO_0__..Clear();
				goto IL_12B;
				IL_11D:
				num2 = 18;
				this.o.0ooOO_0__. = new Dictionary<DataRow, Dictionary<string, double>>();
				IL_12B:
				num2 = 19;
				this.o.0ooOO_0__. = new Oo0();
				IL_139:
				num2 = 20;
				this.o.0ooOO_0__..O_OOO.0o. = A_0;
				IL_148:
				num2 = 21;
				this.o.0ooOO_0__..OO._o0_o_OO0O. = A_1;
				IL_157:
				num2 = 22;
				OO_00oOO.LockBaseMainForm();
				IL_15F:
				num2 = 23;
				this.StopRedraw();
				IL_168:
				num2 = 24;
				if (this.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level"))
				{
					goto IL_190;
				}
				IL_187:
				num2 = 25;
				this.O_.OOoO_Oo.();
				IL_190:
				num2 = 26;
				this.DataTable.oOOO.OOO_0ooO0. = true;
				IL_19F:
				num2 = 27;
				if (Operators.CompareString(A_2, "", true) <= 0)
				{
					goto IL_1BD;
				}
				IL_1B1:
				num2 = 28;
				this.OO0o_o0.0oOo0o. = A_2;
				goto IL_1C7;
				IL_1BD:
				num2 = 30;
				this.OO0o_o0.0oOo0o. = A_1;
				IL_1C7:
				num2 = 31;
				this.Sort = "";
				IL_1D5:
				num2 = 32;
				DataRow[] array3 = this.DataTable.BaseTable.Select(string.Concat(new string[]
				{
					"(",
					A_0,
					" Is Null or ",
					A_1,
					" Is  Null) or (",
					A_0,
					" = ",
					A_1,
					")"
				}), A_1, DataViewRowState.CurrentRows);
				IL_231:
				num2 = 33;
				HashSet<string> hashSet = Oo00.O____0O._0.(this.DataTable.BaseTable, this.Filter, "", A_0);
				IL_252:
				num2 = 34;
				HashSet<string> hashSet2 = Oo00.O____0O._0.(this.DataTable.BaseTable, this.Filter, "", A_1);
				IL_273:
				num2 = 35;
				hashSet.ExceptWith(hashSet2);
				IL_27F:
				num2 = 36;
				List<string> list2 = new List<string>();
				IL_289:
				num2 = 37;
				if (Operators.CompareString(this.O0_O.0oOO0Oo0., "", true) <= 0 || !this.DataTable.BaseTable.Columns.Contains(this.O0_O.0oOO0Oo0.))
				{
					goto IL_39E;
				}
				IL_2C3:
				num2 = 38;
				Array.Sort<DataRow>(array3, new o_oo(this.O0_O.0oOO0Oo0., this.oO_.ooo0o.));
				IL_2DE:
				num2 = 39;
				foreach (DataRow dataRow in array3)
				{
					IL_2F1:
					num2 = 40;
					string item;
					if (dataRow.IsNull(A_1))
					{
						IL_2FE:
						num2 = 41;
						item = dataRow[A_0].ToString();
					}
					else
					{
						IL_312:
						num2 = 43;
						item = dataRow[A_1].ToString();
					}
					IL_324:
					num2 = 44;
					if (!list2.Contains(item))
					{
						IL_332:
						num2 = 45;
						list2.Add(item);
					}
					IL_33E:
					num2 = 46;
				}
				IL_34F:
				num2 = 47;
				HashSet<string>.Enumerator enumerator = hashSet.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string item2 = enumerator.Current;
					IL_366:
					num2 = 48;
					if (!list2.Contains(item2))
					{
						IL_374:
						num2 = 49;
						list2.Add(item2);
					}
					IL_380:
					num2 = 50;
				}
				IL_38C:
				num2 = 51;
				((IDisposable)enumerator).Dispose();
				goto IL_417;
				IL_39E:
				num2 = 53;
				foreach (DataRow dataRow2 in array3)
				{
					IL_3B1:
					num2 = 54;
					if (dataRow2.IsNull(A_1))
					{
						IL_3BE:
						num2 = 55;
						hashSet.Add(dataRow2[A_0].ToString());
					}
					else
					{
						IL_3D8:
						num2 = 57;
						hashSet.Add(dataRow2[A_1].ToString());
					}
					IL_3F0:
					num2 = 58;
				}
				IL_401:
				num2 = 59;
				list2.AddRange(hashSet);
				IL_40D:
				num2 = 60;
				list2.Sort();
				IL_417:
				num2 = 61;
				hashSet.Clear();
				IL_421:
				num2 = 62;
				hashSet2.Clear();
				IL_42B:
				num2 = 63;
				DataView a_ = new DataView(this.DataTable.BaseTable, this.Filter, A_0, DataViewRowState.CurrentRows);
				IL_449:
				num2 = 64;
				DataView dataView = new DataView(this.DataTable.BaseTable, this.Filter, A_1, DataViewRowState.CurrentRows);
				IL_467:
				num2 = 65;
				int num3 = dataView.Count - 1;
				for (int l = 0; l <= num3; l++)
				{
					IL_47A:
					num2 = 66;
					dataView[l]["sys_Hierarchy_Level"] = DBNull.Value;
					IL_495:
					num2 = 67;
				}
				IL_4A4:
				num2 = 68;
				this.OOo_OO.0_0_oo. = 0;
				IL_4AE:
				num2 = 69;
				List<string>.Enumerator enumerator2 = list2.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string text2 = enumerator2.Current;
					IL_4C5:
					num2 = 70;
					if (Operators.CompareString(text2, "", true) != 0)
					{
						IL_4D7:
						num2 = 72;
						this.OOo0_Oo._OOo.(A_0, A_1, a_, dataView, text2, new List<string>(), list, 0);
					}
					IL_4F0:
					num2 = 73;
				}
				IL_4FC:
				num2 = 74;
				((IDisposable)enumerator2).Dispose();
				IL_50C:
				num2 = 75;
				this.Sort = "[System_Sort_Temporary]";
				IL_51A:
				num2 = 76;
				this.HierarchyData = true;
				IL_524:
				num2 = 77;
				this.Cols[this.OO0o_o0.0oOo0o.].TextAlign = TextAlignEnum.Left;
				IL_53E:
				num2 = 78;
				if (A_4 <= -1)
				{
					goto IL_551;
				}
				IL_546:
				num2 = 79;
				this.ExpandGridTree(A_4);
				IL_551:
				num2 = 80;
				this.ResumeRedraw();
				IL_55A:
				num2 = 81;
				OO_00oOO.UnlockBaseMainForm();
				IL_562:
				num2 = 82;
				this.o.o0o_0. = false;
				IL_56C:
				goto IL_70A;
				IL_571:
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_6CB:
				goto IL_6FF;
				IL_6CD:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6DD:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_6CD;
			}
			IL_6FF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_70A:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x001480D8 File Offset: 0x001462D8
		private Dictionary<string, double> <<EMPTY_NAME>>(string A_0, string A_1, DataView A_2, DataView A_3, string A_4, List<string> A_5, List<string> A_6, int A_7)
		{
			int num;
			Dictionary<string, double> result;
			int num7;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				Dictionary<string, double> dictionary = new Dictionary<string, double>();
				IL_10:
				num2 = 3;
				List<string>.Enumerator enumerator = A_6.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string key = enumerator.Current;
					IL_26:
					num2 = 4;
					dictionary.Add(key, 0.0);
					IL_3A:
					num2 = 5;
				}
				IL_45:
				num2 = 6;
				((IDisposable)enumerator).Dispose();
				IL_54:
				num2 = 7;
				if (!A_5.Contains(A_4))
				{
					goto IL_D2;
				}
				IL_61:
				num2 = 8;
				int num3 = A_5.IndexOf(A_4);
				IL_6E:
				num2 = 9;
				MessageBox.Show(string.Concat(new string[]
				{
					"发现循环引用：\r\n",
					string.Join("→", A_5.ToArray(), num3, A_5.Count - num3),
					"→",
					A_4,
					"\r\n无法正确生成折叠树!"
				}), "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				IL_C7:
				num2 = 10;
				result = dictionary;
				goto IL_5C5;
				IL_D2:
				num2 = 11;
				string right = "";
				IL_DC:
				num2 = 12;
				if (A_5.Count <= 0)
				{
					goto IL_FE;
				}
				IL_E9:
				num2 = 13;
				right = A_5[A_5.Count - 1];
				IL_FE:
				num2 = 14;
				A_5.Add(A_4);
				IL_10A:
				num2 = 15;
				List<DataRow> list = new List<DataRow>();
				IL_114:
				num2 = 16;
				DataRowView[] array = A_3.FindRows(A_4);
				IL_122:
				num2 = 17;
				if (array.Length != 0)
				{
					goto IL_18E;
				}
				IL_12B:
				num2 = 18;
				if (A_7 != 0)
				{
					goto IL_215;
				}
				IL_135:
				num2 = 19;
				array = A_2.FindRows(A_4);
				IL_142:
				num2 = 20;
				foreach (DataRowView dataRowView in array)
				{
					IL_155:
					num2 = 21;
					if (dataRowView.Row.IsNull(A_1))
					{
						IL_167:
						num2 = 22;
						list.Add(dataRowView.Row);
					}
					IL_178:
					num2 = 23;
				}
				goto IL_215;
				IL_18E:
				num2 = 25;
				foreach (DataRowView dataRowView2 in array)
				{
					IL_1A1:
					num2 = 26;
					if (dataRowView2.Row.IsNull("sys_Hierarchy_Level"))
					{
						IL_1B7:
						num2 = 28;
						if (Operators.CompareString(dataRowView2[A_0].ToString(), right, true) == 0 || Operators.CompareString(dataRowView2[A_0].ToString(), dataRowView2[A_1].ToString(), true) == 0)
						{
							IL_1F3:
							num2 = 29;
							list.Add(dataRowView2.Row);
						}
					}
					IL_204:
					num2 = 30;
				}
				IL_215:
				num2 = 31;
				if (Operators.CompareString(this.O0_O.0oOO0Oo0., "", true) <= 0 || !this.DataTable.BaseTable.Columns.Contains(this.O0_O.0oOO0Oo0.))
				{
					goto IL_264;
				}
				IL_249:
				num2 = 32;
				list.Sort(new o_oo(this.O0_O.0oOO0Oo0., this.oO_.ooo0o.));
				IL_264:
				num2 = 33;
				int num4 = list.Count - 1;
				for (int k = 0; k <= num4; k++)
				{
					IL_27A:
					num2 = 34;
					DataRow dataRow = list[k];
					IL_288:
					num2 = 35;
					dataRow["sys_Hierarchy_Level"] = A_7;
					IL_29E:
					num2 = 36;
					dataRow["System_Sort_Temporary"] = this.OOo_OO.0_0_oo.;
					IL_2B8:
					num2 = 37;
					this.OOo_OO.0_0_oo.++;
					IL_2C9:
					num2 = 38;
					if (dictionary.Count > 0)
					{
						IL_2D6:
						num2 = 39;
						List<string>.Enumerator enumerator2 = A_6.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text = enumerator2.Current;
							IL_2ED:
							num2 = 40;
							if (!list[k].IsNull(text))
							{
								IL_302:
								num2 = 41;
								dictionary[text] += Conversions.ToDouble(list[k][text]);
							}
							IL_32D:
							num2 = 42;
						}
						IL_339:
						num2 = 43;
						((IDisposable)enumerator2).Dispose();
					}
					IL_349:
					num2 = 44;
				}
				IL_35B:
				num2 = 45;
				int num5 = 1;
				IL_361:
				num2 = 46;
				if (A_7 != 0 || list.Count != 0)
				{
					goto IL_377;
				}
				IL_371:
				num2 = 47;
				num5 = 0;
				IL_377:
				num2 = 48;
				array = A_2.FindRows(A_4);
				IL_384:
				num2 = 49;
				List<string> list2 = new List<string>();
				IL_38E:
				num2 = 50;
				if (Operators.CompareString(this.O0_O.0oOO0Oo0., "", true) <= 0 || !this.DataTable.BaseTable.Columns.Contains(this.O0_O.0oOO0Oo0.))
				{
					goto IL_44F;
				}
				IL_3C8:
				num2 = 51;
				Array.Sort(array, new O0_(this.O0_O.0oOO0Oo0., this.oO_.ooo0o.));
				IL_3E3:
				num2 = 52;
				foreach (DataRowView dataRowView3 in array)
				{
					IL_3F6:
					num2 = 53;
					if (Operators.CompareString(dataRowView3[A_1].ToString(), A_4, true) != 0)
					{
						IL_410:
						num2 = 55;
						string item = dataRowView3[A_1].ToString();
						IL_422:
						num2 = 56;
						if (!list2.Contains(item))
						{
							IL_430:
							num2 = 57;
							list2.Add(item);
						}
					}
					IL_43C:
					num2 = 58;
				}
				goto IL_4C5;
				IL_44F:
				num2 = 60;
				HashSet<string> hashSet = new HashSet<string>();
				IL_459:
				num2 = 61;
				foreach (DataRowView dataRowView4 in array)
				{
					IL_46C:
					num2 = 62;
					if (Operators.CompareString(dataRowView4[A_1].ToString(), A_4, true) != 0)
					{
						IL_486:
						num2 = 64;
						hashSet.Add(dataRowView4[A_1].ToString());
					}
					IL_49E:
					num2 = 65;
				}
				IL_4AF:
				num2 = 66;
				list2.AddRange(hashSet);
				IL_4BB:
				num2 = 67;
				list2.Sort();
				IL_4C5:
				num2 = 68;
				List<string>.Enumerator enumerator3 = list2.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					string a_ = enumerator3.Current;
					IL_4DF:
					num2 = 69;
					List<string> list3 = new List<string>();
					IL_4E9:
					num2 = 70;
					list3.AddRange(A_5);
					IL_4F5:
					num2 = 71;
					Dictionary<string, double> dictionary2 = this.OOo0_Oo._OOo.(A_0, A_1, A_2, A_3, a_, list3, A_6, A_7 + num5);
					IL_510:
					num2 = 72;
					Dictionary<string, double>.KeyCollection.Enumerator enumerator4 = dictionary2.Keys.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						string key2 = enumerator4.Current;
						IL_52C:
						num2 = 73;
						dictionary[key2] += dictionary2[key2];
						IL_54B:
						num2 = 74;
					}
					IL_557:
					num2 = 75;
					((IDisposable)enumerator4).Dispose();
					IL_567:
					num2 = 76;
				}
				IL_576:
				num2 = 77;
				((IDisposable)enumerator3).Dispose();
				IL_586:
				num2 = 78;
				if (dictionary.Count <= 0 || list.Count <= 0 || list2.Count <= 0)
				{
					goto IL_5BF;
				}
				IL_5A7:
				num2 = 79;
				this.o.0ooOO_0__..Add(list[0], dictionary);
				IL_5BF:
				num2 = 80;
				result = dictionary;
				IL_5C5:
				goto IL_75B;
				IL_5CA:
				int num6 = num7 + 1;
				num7 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
				IL_71C:
				goto IL_750;
				IL_71E:
				num7 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_72E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_71E;
			}
			IL_750:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_75B:
			if (num7 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00148868 File Offset: 0x00146A68
		internal void <<EMPTY_NAME>>(string A_0, char A_1, int A_2 = -1)
		{
			this.O_.o__ooo.(A_0, "", A_1, A_2);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x00148878 File Offset: 0x00146A78
		internal void <<EMPTY_NAME>>(string A_0, string A_1, char A_2, int A_3 = -1)
		{
			this.O_.o__ooo.(A_0, A_1, A_2, "", A_3);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0014888C File Offset: 0x00146A8C
		internal void <<EMPTY_NAME>>(string A_0, string A_1, char A_2, string A_3, int A_4 = -1)
		{
			int num;
			int num8;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				List<string> list = new List<string>();
				IL_0F:
				num2 = 3;
				this.o.0ooOO_0__..Clear();
				IL_1C:
				num2 = 4;
				if (Operators.CompareString(A_3, "", true) <= 0)
				{
					goto IL_B4;
				}
				IL_31:
				num2 = 5;
				string[] array = A_3.Split(new char[]
				{
					','
				});
				IL_47:
				num2 = 6;
				foreach (string text in array)
				{
					IL_59:
					num2 = 7;
					if (this.DataTable.DataCols.Contains(text) && this.DataTable.DataCols[text].IsNumeric)
					{
						IL_88:
						num2 = 8;
						list.Add(text);
						IL_92:
						num2 = 9;
						this.o.0ooOO_0__..Add(text);
					}
					IL_A3:
					num2 = 10;
				}
				IL_B4:
				num2 = 11;
				this.o.o0o_0. = true;
				IL_BE:
				num2 = 12;
				if (this.o.0ooOO_0__. == null)
				{
					goto IL_D9;
				}
				IL_C9:
				num2 = 13;
				this.o.0ooOO_0__..Clear();
				goto IL_E7;
				IL_D9:
				num2 = 15;
				this.o.0ooOO_0__. = new Dictionary<DataRow, Dictionary<string, double>>();
				IL_E7:
				num2 = 16;
				this.o.0ooOO_0__. = new Oo0();
				IL_F5:
				num2 = 17;
				this.o.0ooOO_0__..OOOO._. = A_0;
				IL_104:
				num2 = 18;
				this.o.0ooOO_0__..O_OOO.0o. = A_2;
				IL_113:
				num2 = 19;
				OO_00oOO.LockBaseMainForm();
				IL_11B:
				num2 = 20;
				this.StopRedraw();
				IL_124:
				num2 = 21;
				if (this.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level"))
				{
					goto IL_14C;
				}
				IL_143:
				num2 = 22;
				this.O_.OOoO_Oo.();
				IL_14C:
				num2 = 23;
				this.DataTable.oOOO.OOO_0ooO0. = true;
				IL_15B:
				num2 = 24;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_179;
				}
				IL_16D:
				num2 = 25;
				this.OO0o_o0.0oOo0o. = A_1;
				goto IL_183;
				IL_179:
				num2 = 27;
				this.OO0o_o0.0oOo0o. = A_0;
				IL_183:
				num2 = 28;
				this.Sort = "";
				IL_191:
				num2 = 29;
				if (!this.IsChild)
				{
					goto IL_1A9;
				}
				IL_19C:
				num2 = 30;
				IBindingList bindingList = this.View;
				goto IL_1C7;
				IL_1A9:
				num2 = 32;
				bindingList = new DataView(this.DataTable.BaseTable, this.Filter, A_0, DataViewRowState.CurrentRows);
				IL_1C7:
				num2 = 33;
				int num3 = bindingList.Count - 1;
				for (int j = 0; j <= num3; j++)
				{
					IL_1DA:
					num2 = 34;
					NewLateBinding.LateIndexSetComplex(bindingList[j], new object[]
					{
						"sys_Hierarchy_Level",
						DBNull.Value
					}, null, false, true);
					IL_204:
					num2 = 35;
				}
				IL_213:
				num2 = 36;
				this.OOo_OO.0_0_oo. = 0;
				IL_21D:
				num2 = 37;
				bool flag = true;
				IL_223:
				num2 = 38;
				string left = "";
				IL_22D:
				num2 = 39;
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				IL_237:
				num2 = 40;
				System.Windows.Forms.TreeView treeView = null;
				IL_23D:
				num2 = 41;
				Stack<System.Windows.Forms.TreeNode> stack = null;
				IL_243:
				num2 = 42;
				bool flag2 = false;
				IL_249:
				num2 = 43;
				if (list.Count <= 0 && (Operators.CompareString(this.O0_O.0oOO0Oo0., "", true) <= 0 || !this.DataTable.BaseTable.Columns.Contains(this.O0_O.0oOO0Oo0.)))
				{
					goto IL_2D4;
				}
				IL_286:
				num2 = 44;
				treeView = new System.Windows.Forms.TreeView();
				IL_290:
				num2 = 45;
				stack = new Stack<System.Windows.Forms.TreeNode>();
				IL_29A:
				num2 = 46;
				if (Operators.CompareString(this.O0_O.0oOO0Oo0., "", true) <= 0 || !this.DataTable.BaseTable.Columns.Contains(this.O0_O.0oOO0Oo0.))
				{
					goto IL_2D4;
				}
				IL_2CE:
				num2 = 47;
				flag2 = true;
				IL_2D4:
				num2 = 48;
				int num4 = bindingList.Count - 1;
				for (int k = 0; k <= num4; k++)
				{
					IL_2EA:
					num2 = 49;
					object[] array3;
					bool[] array4;
					object value = NewLateBinding.LateGet(NewLateBinding.LateGet(bindingList[k], null, "Row", new object[0], null, null, null), null, "IsNull", array3 = new object[]
					{
						A_0
					}, null, null, array4 = new bool[]
					{
						true
					});
					if (array4[0])
					{
						A_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
					}
					if (Conversions.ToBoolean(value))
					{
						IL_35D:
						num2 = 50;
						NewLateBinding.LateSetComplex(bindingList[k], null, "row", new object[]
						{
							"sys_Hierarchy_Level",
							0
						}, null, null, false, true);
					}
					else
					{
						IL_394:
						num2 = 52;
						string text2 = NewLateBinding.LateIndexGet(bindingList[k], new object[]
						{
							A_0
						}, null).ToString();
						IL_3B7:
						num2 = 53;
						if (!flag2)
						{
							IL_3BE:
							num2 = 54;
							NewLateBinding.LateIndexSetComplex(bindingList[k], new object[]
							{
								"System_Sort_Temporary",
								this.OOo_OO.0_0_oo.
							}, null, false, true);
							IL_3EE:
							num2 = 55;
							this.OOo_OO.0_0_oo.++;
						}
						IL_3FF:
						num2 = 56;
						string[] array5 = text2.Split(new char[]
						{
							A_2
						});
						IL_415:
						num2 = 57;
						int num5 = 0;
						IL_41B:
						num2 = 58;
						if (k != 0 && array5.Length != 1)
						{
							IL_429:
							num2 = 60;
							int num6 = array5.Length - 1;
							string key;
							for (;;)
							{
								IL_474:
								num2 = 62;
								if (num6 <= 0)
								{
									goto IL_47C;
								}
								IL_436:
								num2 = 63;
								key = string.Join(Conversions.ToString(A_2), array5, 0, num6);
								IL_44B:
								num2 = 64;
								if (dictionary.ContainsKey(key))
								{
									break;
								}
								IL_46B:
								num2 = 67;
								num6--;
							}
							IL_459:
							num2 = 65;
							num5 = dictionary[key] + 1;
						}
						IL_47C:
						num2 = 69;
						NewLateBinding.LateIndexSetComplex(bindingList[k], new object[]
						{
							"sys_Hierarchy_Level",
							num5
						}, null, false, true);
						IL_4A8:
						num2 = 70;
						if (num5 == 0)
						{
							IL_4AF:
							num2 = 71;
							dictionary.Clear();
						}
						IL_4B9:
						num2 = 72;
						if (!dictionary.ContainsKey(text2))
						{
							IL_4C7:
							num2 = 73;
							dictionary.Add(text2, num5);
						}
						IL_4D5:
						num2 = 74;
						if (flag && k > 0)
						{
							IL_4E1:
							num2 = 75;
							if (Operators.CompareString(left, text2, true) == 0)
							{
								IL_4F0:
								num2 = 76;
								flag = false;
							}
						}
						IL_4F6:
						num2 = 77;
						left = text2;
						IL_4FD:
						num2 = 78;
						if (treeView != null)
						{
							IL_507:
							num2 = 79;
							System.Windows.Forms.TreeNode treeNode = null;
							IL_50D:
							num2 = 80;
							if (num5 > 0)
							{
								for (;;)
								{
									IL_53E:
									num2 = 82;
									if (stack.Count <= 0)
									{
										break;
									}
									IL_517:
									num2 = 83;
									treeNode = stack.Peek();
									IL_523:
									num2 = 84;
									if (treeNode.Level == num5 - 1)
									{
										break;
									}
									IL_533:
									num2 = 87;
									stack.Pop();
								}
							}
							IL_54B:
							num2 = 89;
							System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode();
							IL_555:
							num2 = 90;
							treeNode2.Text = text2;
							IL_561:
							num2 = 91;
							treeNode2.Tag = RuntimeHelpers.GetObjectValue(bindingList[k]);
							IL_579:
							num2 = 92;
							if (treeNode != null)
							{
								IL_580:
								num2 = 93;
								treeNode.Nodes.Add(treeNode2);
							}
							else
							{
								IL_594:
								num2 = 95;
								treeView.Nodes.Add(treeNode2);
							}
							IL_5A6:
							num2 = 96;
							stack.Push(treeNode2);
						}
					}
					IL_5B2:
					num2 = 97;
				}
				IL_5C4:
				num2 = 98;
				if (treeView == null)
				{
					goto IL_872;
				}
				IL_5CE:
				num2 = 99;
				if (list.Count <= 0)
				{
					goto IL_809;
				}
				IL_5DD:
				num2 = 100;
				List<System.Windows.Forms.TreeNode> list2 = o_O_o_oOoo__.OO_O0oO0.oooO_.(treeView);
				IL_5E9:
				num2 = 101;
				Dictionary<System.Windows.Forms.TreeNode, Dictionary<string, double>> dictionary2 = new Dictionary<System.Windows.Forms.TreeNode, Dictionary<string, double>>();
				IL_5F3:
				num2 = 102;
				for (int l = list2.Count - 1; l >= 0; l += -1)
				{
					IL_606:
					num2 = 103;
					System.Windows.Forms.TreeNode treeNode3 = list2[l];
					IL_614:
					num2 = 104;
					System.Windows.Forms.TreeNode parent = treeNode3.Parent;
					IL_620:
					num2 = 105;
					DataRowView dataRowView = (DataRowView)treeNode3.Tag;
					IL_631:
					num2 = 106;
					Dictionary<string, double> dictionary3 = null;
					IL_637:
					num2 = 107;
					if (parent != null)
					{
						IL_641:
						num2 = 108;
						if (!dictionary2.TryGetValue(parent, out dictionary3))
						{
							IL_654:
							num2 = 109;
							dictionary3 = new Dictionary<string, double>();
							IL_65E:
							num2 = 110;
							List<string>.Enumerator enumerator = list.GetEnumerator();
							while (enumerator.MoveNext())
							{
								string key2 = enumerator.Current;
								IL_674:
								num2 = 111;
								dictionary3[key2] = 0.0;
								IL_689:
								num2 = 112;
							}
							IL_695:
							num2 = 113;
							((IDisposable)enumerator).Dispose();
							IL_6A5:
							num2 = 114;
							dictionary2.Add(parent, dictionary3);
							IL_6B3:
							num2 = 115;
							this.o.0ooOO_0__..Add(((DataRowView)parent.Tag).Row, dictionary3);
						}
						IL_6D4:
						num2 = 116;
						List<string>.Enumerator enumerator2 = list.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text3 = enumerator2.Current;
							IL_6EA:
							num2 = 117;
							if (!dataRowView.Row.IsNull(text3))
							{
								IL_6FD:
								num2 = 118;
								dictionary3[text3] += Conversions.ToDouble(dataRowView[text3]);
							}
							IL_721:
							num2 = 119;
						}
						IL_72D:
						num2 = 120;
						((IDisposable)enumerator2).Dispose();
					}
					IL_73D:
					num2 = 121;
					if (treeNode3.Nodes.Count > 0)
					{
						IL_752:
						num2 = 122;
						Dictionary<string, double> dictionary4 = dictionary2[treeNode3];
						IL_760:
						num2 = 123;
						List<string>.Enumerator enumerator3 = list.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							string text4 = enumerator3.Current;
							IL_776:
							num2 = 124;
							if (parent != null)
							{
								IL_77D:
								num2 = 125;
								dictionary3[text4] += dictionary4[text4];
							}
							IL_79C:
							num2 = 126;
							if (!dataRowView.Row.IsNull(text4))
							{
								IL_7AF:
								num2 = 127;
								dictionary4[text4] += Conversions.ToDouble(dataRowView[text4]);
							}
							IL_7D3:
							num2 = 128;
						}
						IL_7E2:
						num2 = 129;
						((IDisposable)enumerator3).Dispose();
					}
					IL_7F5:
					num2 = 130;
				}
				IL_809:
				num2 = 131;
				if (!flag2)
				{
					goto IL_872;
				}
				IL_813:
				num2 = 132;
				treeView.TreeViewNodeSorter = new OOO(this.O0_O.0oOO0Oo0., this.oO_.ooo0o., flag, A_2);
				IL_834:
				num2 = 133;
				treeView.TreeViewNodeSorter = null;
				IL_842:
				num2 = 134;
				if (flag)
				{
					goto IL_85F;
				}
				IL_84C:
				num2 = 135;
				this.o00O.oooo0.(treeView.Nodes);
				IL_85F:
				num2 = 136;
				this.O0o._oo_.(treeView.Nodes);
				IL_872:
				num2 = 137;
				this.Sort = "[System_Sort_Temporary]";
				IL_883:
				num2 = 138;
				this.HierarchyData = true;
				IL_890:
				num2 = 139;
				this.Cols[this.OO0o_o0.0oOo0o.].TextAlign = TextAlignEnum.Left;
				IL_8AD:
				num2 = 140;
				if (A_4 <= -1)
				{
					goto IL_8C6;
				}
				IL_8B8:
				num2 = 141;
				this.ExpandGridTree(A_4);
				IL_8C6:
				num2 = 142;
				this.ResumeRedraw();
				IL_8D2:
				num2 = 143;
				OO_00oOO.UnlockBaseMainForm();
				IL_8DD:
				num2 = 144;
				this.o.o0o_0. = false;
				IL_8EA:
				goto IL_B80;
				IL_8EF:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_B41:
				goto IL_B75;
				IL_B43:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_B53:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_B43;
			}
			IL_B75:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_B80:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x00149440 File Offset: 0x00147640
		private void <<EMPTY_NAME>>(TreeNodeCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.TreeNode treeNode = (System.Windows.Forms.TreeNode)obj;
					if (treeNode.Nodes.Count > 0)
					{
						System.Windows.Forms.TreeNode treeNode2 = treeNode;
						for (;;)
						{
							System.Windows.Forms.TreeNode nextNode = treeNode2.NextNode;
							if (nextNode == null || Operators.CompareString(treeNode2.NextNode.Text, treeNode.Text, true) != 0)
							{
								break;
							}
							treeNode2 = nextNode;
						}
						if (treeNode2 != treeNode)
						{
							System.Windows.Forms.TreeNode[] array = new System.Windows.Forms.TreeNode[treeNode.Nodes.Count - 1 + 1];
							treeNode.Nodes.CopyTo(array, 0);
							treeNode.Nodes.Clear();
							treeNode2.Nodes.AddRange(array);
							this.o00O.oooo0.(treeNode2.Nodes);
						}
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

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0014951C File Offset: 0x0014771C
		private void <<EMPTY_NAME>>(TreeNodeCollection A_0)
		{
			try
			{
				foreach (object obj in A_0)
				{
					System.Windows.Forms.TreeNode treeNode = (System.Windows.Forms.TreeNode)obj;
					((DataRowView)treeNode.Tag)["System_Sort_Temporary"] = this.OOo_OO.0_0_oo.;
					this.OOo_OO.0_0_oo.++;
					if (treeNode.Nodes.Count > 0)
					{
						this.O0o._oo_.(treeNode.Nodes);
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

		// Token: 0x06002CB9 RID: 11449 RVA: 0x001495B4 File Offset: 0x001477B4
		internal void <<EMPTY_NAME>>(string A_0, int[] A_1, int A_2 = -1)
		{
			this.OOo0_Oo._OOo.(A_0, "", A_1, A_2);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x001495C4 File Offset: 0x001477C4
		internal void <<EMPTY_NAME>>(string A_0, string A_1, int[] A_2, int A_3 = -1)
		{
			this.OOo0_Oo._OOo.(A_0, A_1, A_2, "", A_3);
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x001495D8 File Offset: 0x001477D8
		internal void <<EMPTY_NAME>>(string A_0, string A_1, int[] A_2, string A_3, int A_4 = -1)
		{
			int num;
			int num9;
			object obj;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 1;
				IL_07:
				int num2 = 2;
				List<string> list = new List<string>();
				IL_0F:
				num2 = 3;
				this.o.0ooOO_0__..Clear();
				IL_1C:
				num2 = 4;
				if (Operators.CompareString(A_3, "", true) <= 0)
				{
					goto IL_B4;
				}
				IL_31:
				num2 = 5;
				string[] array = A_3.Split(new char[]
				{
					','
				});
				IL_47:
				num2 = 6;
				foreach (string text in array)
				{
					IL_59:
					num2 = 7;
					if (this.DataTable.DataCols.Contains(text) && this.DataTable.DataCols[text].IsNumeric)
					{
						IL_88:
						num2 = 8;
						list.Add(text);
						IL_92:
						num2 = 9;
						this.o.0ooOO_0__..Add(text);
					}
					IL_A3:
					num2 = 10;
				}
				IL_B4:
				num2 = 11;
				this.o.o0o_0. = true;
				IL_BE:
				num2 = 12;
				if (this.o.0ooOO_0__. == null)
				{
					goto IL_D9;
				}
				IL_C9:
				num2 = 13;
				this.o.0ooOO_0__..Clear();
				goto IL_E7;
				IL_D9:
				num2 = 15;
				this.o.0ooOO_0__. = new Dictionary<DataRow, Dictionary<string, double>>();
				IL_E7:
				num2 = 16;
				this.o.0ooOO_0__. = new Oo0();
				IL_F5:
				num2 = 17;
				this.o.0ooOO_0__..OOOO._. = A_0;
				IL_104:
				num2 = 18;
				this.o.0ooOO_0__..O_OOO.0o. = A_2;
				IL_113:
				num2 = 19;
				OO_00oOO.LockBaseMainForm();
				IL_11B:
				num2 = 20;
				this.StopRedraw();
				IL_124:
				num2 = 21;
				if (this.DataTable.BaseTable.Columns.Contains("sys_Hierarchy_Level"))
				{
					goto IL_14C;
				}
				IL_143:
				num2 = 22;
				this.O_.OOoO_Oo.();
				IL_14C:
				num2 = 23;
				this.DataTable.oOOO.OOO_0ooO0. = true;
				IL_15B:
				num2 = 24;
				if (Operators.CompareString(A_1, "", true) <= 0)
				{
					goto IL_179;
				}
				IL_16D:
				num2 = 25;
				this.OO0o_o0.0oOo0o. = A_1;
				goto IL_183;
				IL_179:
				num2 = 27;
				this.OO0o_o0.0oOo0o. = A_0;
				IL_183:
				num2 = 28;
				this.Sort = "";
				IL_191:
				num2 = 29;
				DataView dataView = new DataView(this.DataTable.BaseTable, this.Filter, A_0, DataViewRowState.CurrentRows);
				IL_1AF:
				num2 = 30;
				int num3 = dataView.Count - 1;
				for (int j = 0; j <= num3; j++)
				{
					IL_1C2:
					num2 = 31;
					dataView[j]["sys_Hierarchy_Level"] = DBNull.Value;
					IL_1DD:
					num2 = 32;
				}
				IL_1EC:
				num2 = 33;
				this.OOo_OO.0_0_oo. = 0;
				IL_1F6:
				num2 = 34;
				bool flag = true;
				IL_1FC:
				num2 = 35;
				string left = "";
				IL_206:
				num2 = 36;
				Dictionary<string, int> dictionary = new Dictionary<string, int>();
				IL_210:
				num2 = 37;
				bool flag2 = false;
				IL_216:
				num2 = 38;
				System.Windows.Forms.TreeView treeView = null;
				IL_21C:
				num2 = 39;
				Stack<System.Windows.Forms.TreeNode> stack = null;
				IL_222:
				num2 = 40;
				if (list.Count <= 0 && (Operators.CompareString(this.O0_O.0oOO0Oo0., "", true) <= 0 || !this.DataTable.BaseTable.Columns.Contains(this.O0_O.0oOO0Oo0.)))
				{
					goto IL_2AD;
				}
				IL_25F:
				num2 = 41;
				treeView = new System.Windows.Forms.TreeView();
				IL_269:
				num2 = 42;
				stack = new Stack<System.Windows.Forms.TreeNode>();
				IL_273:
				num2 = 43;
				if (Operators.CompareString(this.O0_O.0oOO0Oo0., "", true) <= 0 || !this.DataTable.BaseTable.Columns.Contains(this.O0_O.0oOO0Oo0.))
				{
					goto IL_2AD;
				}
				IL_2A7:
				num2 = 44;
				flag2 = true;
				IL_2AD:
				num2 = 45;
				int num4 = dataView.Count - 1;
				for (int k = 0; k <= num4; k++)
				{
					IL_2C3:
					num2 = 46;
					if (!dataView[k].Row.IsNull(A_0))
					{
						IL_2DF:
						num2 = 48;
						if (!flag2)
						{
							IL_2E6:
							num2 = 49;
							dataView[k]["System_Sort_Temporary"] = this.OOo_OO.0_0_oo.;
							IL_307:
							num2 = 50;
							this.OOo_OO.0_0_oo.++;
						}
						IL_318:
						num2 = 51;
						string text2 = Conversions.ToString(dataView[k][A_0]);
						IL_331:
						num2 = 52;
						List<string> list2 = new List<string>();
						IL_33B:
						num2 = 53;
						int num5 = -1;
						IL_341:
						num2 = 54;
						int num6 = 0;
						IL_347:
						num2 = 55;
						int num7 = 0;
						for (;;)
						{
							IL_3A6:
							num2 = 57;
							if (num6 > text2.Length - 1)
							{
								break;
							}
							IL_34F:
							num2 = 58;
							if (num5 < A_2.Length - 1)
							{
								IL_35B:
								num2 = 59;
								num5++;
							}
							else
							{
								IL_366:
								num2 = 61;
								num5 = A_2.Length - 1;
							}
							IL_370:
							num2 = 62;
							if (num6 + A_2[num5] > text2.Length)
							{
								break;
							}
							IL_383:
							num2 = 63;
							list2.Add(text2.Substring(num6, A_2[num5]));
							IL_39A:
							num2 = 64;
							num6 += A_2[num5];
						}
						IL_3B6:
						num2 = 68;
						if (k != 0 && list2.Count != 1)
						{
							IL_3C7:
							num2 = 70;
							num5 = list2.Count - 1;
							string key;
							for (;;)
							{
								IL_419:
								num2 = 72;
								if (num5 <= 0)
								{
									goto IL_421;
								}
								IL_3D7:
								num2 = 73;
								key = string.Join("", list2.ToArray(), 0, num5);
								IL_3F0:
								num2 = 74;
								if (dictionary.ContainsKey(key))
								{
									break;
								}
								IL_410:
								num2 = 77;
								num5--;
							}
							IL_3FE:
							num2 = 75;
							num7 = dictionary[key] + 1;
						}
						IL_421:
						num2 = 79;
						dataView[k]["sys_Hierarchy_Level"] = num7;
						IL_43E:
						num2 = 80;
						if (num7 == 0)
						{
							IL_445:
							num2 = 81;
							dictionary.Clear();
						}
						IL_44F:
						num2 = 82;
						string text3 = dataView[k][A_0].ToString();
						IL_468:
						num2 = 83;
						if (!dictionary.ContainsKey(text3))
						{
							IL_476:
							num2 = 84;
							dictionary.Add(text3, num7);
						}
						IL_484:
						num2 = 85;
						if (flag && k > 0)
						{
							IL_490:
							num2 = 86;
							if (Operators.CompareString(left, text3, true) == 0)
							{
								IL_49F:
								num2 = 87;
								flag = false;
							}
						}
						IL_4A5:
						num2 = 88;
						left = text3;
						IL_4AC:
						num2 = 89;
						if (treeView != null)
						{
							IL_4B6:
							num2 = 90;
							System.Windows.Forms.TreeNode treeNode = null;
							IL_4BC:
							num2 = 91;
							if (num7 > 0)
							{
								for (;;)
								{
									IL_4ED:
									num2 = 93;
									if (stack.Count <= 0)
									{
										break;
									}
									IL_4C6:
									num2 = 94;
									treeNode = stack.Peek();
									IL_4D2:
									num2 = 95;
									if (treeNode.Level == num7 - 1)
									{
										break;
									}
									IL_4E2:
									num2 = 98;
									stack.Pop();
								}
							}
							IL_4FA:
							num2 = 100;
							System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode();
							IL_504:
							num2 = 101;
							treeNode2.Name = text3;
							IL_510:
							num2 = 102;
							treeNode2.Tag = dataView[k];
							IL_523:
							num2 = 103;
							if (treeNode != null)
							{
								IL_52A:
								num2 = 104;
								treeNode.Nodes.Add(treeNode2);
							}
							else
							{
								IL_53E:
								num2 = 106;
								treeView.Nodes.Add(treeNode2);
							}
							IL_550:
							num2 = 107;
							stack.Push(treeNode2);
						}
					}
					IL_55C:
					num2 = 108;
				}
				IL_56E:
				num2 = 109;
				if (treeView == null)
				{
					goto IL_83F;
				}
				IL_578:
				num2 = 110;
				if (list.Count <= 0)
				{
					goto IL_7D7;
				}
				IL_587:
				num2 = 111;
				List<System.Windows.Forms.TreeNode> list3 = o_O_o_oOoo__.OO_O0oO0.oooO_.(treeView);
				IL_593:
				num2 = 112;
				Dictionary<System.Windows.Forms.TreeNode, Dictionary<string, double>> dictionary2 = new Dictionary<System.Windows.Forms.TreeNode, Dictionary<string, double>>();
				IL_59D:
				num2 = 113;
				for (int l = list3.Count - 1; l >= 0; l += -1)
				{
					IL_5B0:
					num2 = 114;
					System.Windows.Forms.TreeNode treeNode3 = list3[l];
					IL_5BE:
					num2 = 115;
					System.Windows.Forms.TreeNode parent = treeNode3.Parent;
					IL_5CA:
					num2 = 116;
					DataRowView dataRowView = (DataRowView)treeNode3.Tag;
					IL_5DB:
					num2 = 117;
					Dictionary<string, double> dictionary3 = null;
					IL_5E1:
					num2 = 118;
					if (parent != null)
					{
						IL_5EB:
						num2 = 119;
						if (!dictionary2.TryGetValue(parent, out dictionary3))
						{
							IL_5FE:
							num2 = 120;
							dictionary3 = new Dictionary<string, double>();
							IL_608:
							num2 = 121;
							List<string>.Enumerator enumerator = list.GetEnumerator();
							while (enumerator.MoveNext())
							{
								string key2 = enumerator.Current;
								IL_61E:
								num2 = 122;
								dictionary3[key2] = 0.0;
								IL_633:
								num2 = 123;
							}
							IL_63F:
							num2 = 124;
							((IDisposable)enumerator).Dispose();
							IL_64F:
							num2 = 125;
							dictionary2.Add(parent, dictionary3);
							IL_65D:
							num2 = 126;
							this.o.0ooOO_0__..Add(((DataRowView)parent.Tag).Row, dictionary3);
						}
						IL_67E:
						num2 = 127;
						List<string>.Enumerator enumerator2 = list.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							string text4 = enumerator2.Current;
							IL_694:
							num2 = 128;
							if (!dataRowView.Row.IsNull(text4))
							{
								IL_6AA:
								num2 = 129;
								dictionary3[text4] += Conversions.ToDouble(dataRowView[text4]);
							}
							IL_6D1:
							num2 = 130;
						}
						IL_6E0:
						num2 = 131;
						((IDisposable)enumerator2).Dispose();
					}
					IL_6F3:
					num2 = 132;
					if (treeNode3.Nodes.Count > 0)
					{
						IL_70B:
						num2 = 133;
						Dictionary<string, double> dictionary4 = dictionary2[treeNode3];
						IL_71C:
						num2 = 134;
						List<string>.Enumerator enumerator3 = list.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							string text5 = enumerator3.Current;
							IL_735:
							num2 = 135;
							if (parent != null)
							{
								IL_73F:
								num2 = 136;
								dictionary3[text5] += dictionary4[text5];
							}
							IL_761:
							num2 = 137;
							if (!dataRowView.Row.IsNull(text5))
							{
								IL_777:
								num2 = 138;
								dictionary4[text5] += Conversions.ToDouble(dataRowView[text5]);
							}
							IL_79E:
							num2 = 139;
						}
						IL_7B0:
						num2 = 140;
						((IDisposable)enumerator3).Dispose();
					}
					IL_7C3:
					num2 = 141;
				}
				IL_7D7:
				num2 = 142;
				if (!flag2)
				{
					goto IL_83F;
				}
				IL_7E1:
				num2 = 143;
				treeView.TreeViewNodeSorter = new OOO(this.O0_O.0oOO0Oo0., this.oO_.ooo0o., flag);
				IL_801:
				num2 = 144;
				treeView.TreeViewNodeSorter = null;
				IL_80F:
				num2 = 145;
				if (flag)
				{
					goto IL_82C;
				}
				IL_819:
				num2 = 146;
				this.o00O.oooo0.(treeView.Nodes);
				IL_82C:
				num2 = 147;
				this.O0o._oo_.(treeView.Nodes);
				IL_83F:
				num2 = 148;
				this.Sort = "[System_Sort_Temporary]";
				IL_850:
				num2 = 149;
				this.HierarchyData = true;
				IL_85D:
				num2 = 150;
				this.Cols[this.OO0o_o0.0oOo0o.].TextAlign = TextAlignEnum.Left;
				IL_87A:
				num2 = 151;
				if (A_4 <= -1)
				{
					goto IL_893;
				}
				IL_885:
				num2 = 152;
				this.ExpandGridTree(A_4);
				IL_893:
				num2 = 153;
				this.ResumeRedraw();
				IL_89F:
				num2 = 154;
				OO_00oOO.UnlockBaseMainForm();
				IL_8AA:
				num2 = 155;
				this.o.o0o_0. = false;
				IL_8B7:
				goto IL_B79;
				IL_8BC:
				int num8 = num9 + 1;
				num9 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8);
				IL_B3A:
				goto IL_B6E;
				IL_B3C:
				num9 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_B4C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num9 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_B3C;
			}
			IL_B6E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_B79:
			if (num9 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 在折叠模式下，展开指定级别的全部节点
		/// </summary>
		/// <param name="level">节点级别</param>
		// Token: 0x06002CBC RID: 11452 RVA: 0x0014A184 File Offset: 0x00148384
		[oO0oooo("3386")]
		public void ExpandGridTree(int level)
		{
			if (this.HierarchyData)
			{
				this.O_o0OOo_.o0..OoO._OOo__.(level);
			}
		}

		/// <summary>
		/// 关闭折叠模式
		/// </summary>
		// Token: 0x06002CBD RID: 11453 RVA: 0x0014A19A File Offset: 0x0014839A
		[oO0oooo("3386")]
		public void CloseGridTree()
		{
			OO_00oOO.LockBaseMainForm();
			this.o.oO000Ooo_.();
			OO_00oOO.UnlockBaseMainForm();
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x0014A1AC File Offset: 0x001483AC
		internal void <<EMPTY_NAME>>()
		{
			this.StopRedraw();
			if (this.foxGrid.OO.o_o00o.())
			{
				this.foxGrid.Oo.0.(false);
				this.foxGrid.Subtotal(AggregateEnum.Clear);
			}
			else
			{
				this.O0_O.0oOO0Oo0. = false;
				if (!this.o.o0o_0. && this.o.0ooOO_0__. != null)
				{
					this.o.0ooOO_0__..Clear();
					this.o.0ooOO_0__. = null;
				}
				C1FlexGrid c1FlexGrid = this.Grid;
				int @fixed = c1FlexGrid.Rows.Fixed;
				int num = c1FlexGrid.Rows.Count - 1;
				for (int i = @fixed; i <= num; i++)
				{
					c1FlexGrid.Rows[i].Visible = true;
					c1FlexGrid.SetUserData(i, c1FlexGrid.Cols.Fixed - 1, null);
				}
			}
			this.ResumeRedraw();
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x0014A26C File Offset: 0x0014846C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ShowGridTree(params object[] Args)
		{
			if (Args.Length == 1)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Args[0]);
				if (objectValue is LayerTreeSetting)
				{
					this.ShowGridTree((LayerTreeSetting)objectValue);
					return;
				}
				if (objectValue is InlineTreeSetting)
				{
					this.ShowGridTree((InlineTreeSetting)objectValue);
					return;
				}
				if (objectValue is GroupTreeSetting)
				{
					this.ShowGridTree((GroupTreeSetting)objectValue, 0);
					return;
				}
			}
			else if (Args.Length == 2)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(Args[0]);
				object objectValue3 = RuntimeHelpers.GetObjectValue(Args[1]);
				if (objectValue2 is GroupTreeSetting && objectValue3 is int)
				{
					this.ShowGridTree((GroupTreeSetting)objectValue2, Conversions.ToInteger(objectValue3));
				}
			}
		}

		/// <summary>
		/// 打开折叠模式
		/// </summary>
		/// <param name="Setting">InlineTreeSetting类型，用于设置内联折叠模式</param>
		// Token: 0x06002CC0 RID: 11456 RVA: 0x0014A304 File Offset: 0x00148504
		[oO0oooo("3348")]
		public void ShowGridTree(InlineTreeSetting Setting)
		{
			this.O0_O.0oOO0Oo0. = Setting.SortCol;
			this.oO_.ooo0o. = Setting.SortDesc;
			this.oO._o. = Setting.UseStyle;
			string a_ = "";
			if (Setting.AggregateCols != null && Setting.AggregateCols.Length > 0)
			{
				a_ = string.Join(",", Setting.AggregateCols);
			}
			this.OOo0_Oo._OOo.(Setting.ParentCol, Setting.ChildCol, Setting.TreeCol, a_, Setting.ExpandTo);
		}

		/// <summary>
		/// 打开折叠模式
		/// </summary>
		/// <param name="Setting">LayerTreeSetting，用于设置层级折叠模式属性</param>
		// Token: 0x06002CC1 RID: 11457 RVA: 0x0014A380 File Offset: 0x00148580
		[oO0oooo("3349")]
		public void ShowGridTree(LayerTreeSetting Setting)
		{
			this.O0_O.0oOO0Oo0. = Setting.SortCol;
			this.oO_.ooo0o. = Setting.SortDesc;
			this.oO._o. = Setting.UseStyle;
			string a_ = "";
			if (Setting.AggregateCols != null && Setting.AggregateCols.Length > 0)
			{
				a_ = string.Join(",", Setting.AggregateCols);
			}
			if (Operators.CompareString(Conversions.ToString(Setting.Separator2), "", true) > 0)
			{
				this.O_.o__ooo.(Setting.PathCol, Setting.TreeCol, Setting.Separator2, a_, Setting.ExpandTo);
				return;
			}
			if (Setting.Lengths2 != null && Setting.Lengths2.Length > 0)
			{
				this.OOo0_Oo._OOo.(Setting.PathCol, Setting.TreeCol, Setting.Lengths2, a_, Setting.ExpandTo);
			}
		}

		/// <summary>
		/// 打开设置折叠模式
		/// </summary>
		/// <param name="Setting">GroupTreeSetting类型，用于设置普通折叠模式的属性。</param>
		/// <param name="ExpandTo">设置初始展开级别</param>
		// Token: 0x06002CC2 RID: 11458 RVA: 0x0014A448 File Offset: 0x00148648
		[oO0oooo("3351")]
		public void ShowGridTree(GroupTreeSetting Setting, int ExpandTo = 0)
		{
			string a_ = "";
			if (Setting.AggregateCols != null && Setting.AggregateCols.Length > 0)
			{
				a_ = string.Join(",", Setting.AggregateCols);
			}
			this.OOo0_Oo._OOo.(Setting.GroupCols2, a_, Setting.SortCol, Setting.SortDesc, ExpandTo);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x0014A499 File Offset: 0x00148699
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ShowGridTree(string[] Groups, int ExpandTo = 0)
		{
			this.OOo0_Oo._OOo.(Groups, "", ExpandTo);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0014A4A8 File Offset: 0x001486A8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void ShowGridTree(string[] Groups, string[] valueCols, int ExpandTo = 0)
		{
			this.OOo0_Oo._OOo.(Groups, string.Join(",", valueCols), ExpandTo);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0014A4C0 File Offset: 0x001486C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ShowGridTree()
		{
			bool result;
			if (Operators.CompareString(this.oooo00O.o__0O., "", true) > 0 && Operators.CompareString(this.O___o0.Oo., "", true) > 0)
			{
				if (this.DataTable.BaseTable.Columns.Contains(this.oooo00O.o__0O.) && this.DataTable.BaseTable.Columns.Contains(this.O___o0.Oo.) && (Operators.CompareString(this.O000__.o_ooo_O., "", true) == 0 || this.DataTable.BaseTable.Columns.Contains(this.O000__.o_ooo_O.)))
				{
					this.OOo0_Oo._OOo.(this.oooo00O.o__0O., this.O___o0.Oo., this.O000__.o_ooo_O., this.oOoo____oo.O0., this.o__.O0o.);
					this.O_O0.0_o.(this.o__.O0o.);
					result = true;
				}
			}
			else if (Operators.CompareString(this.O_.oOoOO0o., "", true) > 0 && this.DataTable.BaseTable.Columns.Contains(this.O_.oOoOO0o.))
			{
				if (Operators.CompareString(this.O000__.o_ooo_O., "", true) == 0 || this.DataTable.BaseTable.Columns.Contains(this.O000__.o_ooo_O.))
				{
					if (Operators.CompareString(this.oO0.00., "", true) > 0)
					{
						this.O_.o__ooo.(this.O_.oOoOO0o., this.O000__.o_ooo_O., this.oO0.00.[0], this.oOoo____oo.O0., this.o__.O0o.);
						this.O_O0.0_o.(this.o__.O0o.);
						result = true;
					}
					else
					{
						if (Operators.CompareString(this.O_OO.oO0_., "", true) > 0)
						{
							string[] array = this.O_OO.oO0_..Split(new char[]
							{
								','
							});
							List<int> list = new List<int>();
							foreach (string value in array)
							{
								list.Add(Conversions.ToInteger(value));
							}
							if (list.Count >= 1)
							{
								this.OOo0_Oo._OOo.(this.O_.oOoOO0o., this.O000__.o_ooo_O., list.ToArray(), this.oOoo____oo.O0., this.o__.O0o.);
								this.O_O0.0_o.(this.o__.O0o.);
								return true;
							}
						}
						result = true;
					}
				}
			}
			else if (Operators.CompareString(this.o_oO__O.0_., "", true) > 0)
			{
				List<string> list2 = new List<string>();
				list2.AddRange(this.o_oO__O.0_..Split(new char[]
				{
					','
				}));
				try
				{
					foreach (string name in list2)
					{
						if (!this.DataTable.BaseTable.Columns.Contains(name))
						{
							return false;
						}
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.OOo0_Oo._OOo.(list2.ToArray(), this.oOoo____oo.O0., this.O0_O.0oOO0Oo0., this.oO_.ooo0o., this.o__.O0o.);
				result = true;
			}
			else if (Operators.CompareString(this.DataTable.OoOo_OoOO0.o., "", true) > 0 && this.DataTable.oOOO.OOO_0ooO0.)
			{
				this.OO0o_o0.0oOo0o. = this.DataTable.OoOo_OoOO0.o.;
				this.HierarchyData = true;
				this.Cols[this.OO0o_o0.0oOo0o.].TextAlign = TextAlignEnum.Left;
				this.ExpandGridTree(0);
				result = true;
			}
			return result;
		}

		/// <summary>
		/// 是否已经开启折叠模式
		/// </summary>
		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x0014A818 File Offset: 0x00148A18
		[oO0oooo("3386")]
		public bool GridTreeVisible
		{
			get
			{
				return this.HierarchyData;
			}
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0014A820 File Offset: 0x00148A20
		internal void <<EMPTY_NAME>>(DataRow A_0, string A_1, object A_2, object A_3)
		{
			if (this.GridTreeVisible && this.o.0ooOO_0__..Contains(A_1))
			{
				int num = this.o.oO__OO_oo_0_.(A_0);
				if (num >= 0)
				{
					DataRow dataRow = null;
					double num2;
					if (A_2 != DBNull.Value)
					{
						num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_2));
					}
					double num3;
					if (A_3 != DBNull.Value)
					{
						num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_3));
					}
					double num4 = num3 - num2;
					Foxtable.Row row;
					if (this.Rows[num].HasChild)
					{
						row = this.Rows[num];
					}
					else
					{
						row = this.Rows[num].Parent;
						if (this.Rows[num].DataRow != null)
						{
							dataRow = this.Rows[num].DataRow.BaseRow;
						}
					}
					if (dataRow != null && this.o.0ooOO_0__..ContainsKey(dataRow))
					{
						this.o.0ooOO_0__..Remove(dataRow);
					}
					while (row != null)
					{
						DataRow baseRow = row.DataRow.BaseRow;
						Dictionary<string, double> dictionary;
						if (!this.o.0ooOO_0__..ContainsKey(baseRow))
						{
							dictionary = new Dictionary<string, double>();
							if (!baseRow.IsNull(A_1))
							{
								if (baseRow == A_0)
								{
									dictionary[A_1] = num2;
								}
								else
								{
									dictionary[A_1] = Conversions.ToDouble(baseRow[A_1]);
								}
							}
							this.o.0ooOO_0__.[baseRow] = dictionary;
						}
						else
						{
							dictionary = this.o.0ooOO_0__.[baseRow];
						}
						if (!dictionary.ContainsKey(A_1))
						{
							dictionary[A_1] = num4;
						}
						else
						{
							dictionary[A_1] += num4;
						}
						row = row.Parent;
					}
				}
			}
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x0014A9C0 File Offset: 0x00148BC0
		internal void <<EMPTY_NAME>>(DataRow A_0, string A_1)
		{
			if (this.GridTreeVisible && this.o.0ooOO_0__..Contains(A_1))
			{
				int num = this.o.oO__OO_oo_0_.(A_0);
				if (num >= 0)
				{
					Foxtable.Row row;
					if (this.Rows[num].HasChild)
					{
						row = this.Rows[num];
					}
					else
					{
						row = this.Rows[num].Parent;
					}
					while (row != null)
					{
						List<Foxtable.Row> children = row.GetChildren(false);
						double num2 = 0.0;
						try
						{
							foreach (Foxtable.Row row2 in children)
							{
								if (row2.HasChild)
								{
									if (!this.o.0ooOO_0__..ContainsKey(row2.DataRow.BaseRow))
									{
										this.o.0ooOO_0__.[row2.DataRow.BaseRow] = new Dictionary<string, double>();
									}
									Dictionary<string, double> dictionary = this.o.0ooOO_0__.[row2.DataRow.BaseRow];
									if (!dictionary.ContainsKey(A_1))
									{
										dictionary[A_1] = 0.0;
									}
									num2 += dictionary[A_1];
								}
								else if (row2[A_1] != DBNull.Value)
								{
									num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(row2[A_1]));
								}
							}
						}
						finally
						{
							List<Foxtable.Row>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (!this.o.0ooOO_0__..ContainsKey(row.DataRow.BaseRow))
						{
							this.o.0ooOO_0__.[row.DataRow.BaseRow] = new Dictionary<string, double>();
						}
						if (!row.BaseDataRow.IsNull(A_1))
						{
							num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(row[A_1]));
						}
						this.o.0ooOO_0__.[row.DataRow.BaseRow][A_1] = num2;
						row = row.Parent;
					}
				}
			}
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x0014ABAC File Offset: 0x00148DAC
		internal void <<EMPTY_NAME>>(DataRow A_0, bool A_1 = false)
		{
			if (this.GridTreeVisible && this.o.0ooOO_0__..Count > 0)
			{
				int num = this.o.oO__OO_oo_0_.(A_0);
				Dictionary<string, double> dictionary = new Dictionary<string, double>();
				if (this.o.0ooOO_0__..ContainsKey(A_0))
				{
					dictionary = this.o.0ooOO_0__.[A_0];
				}
				if (num >= 0)
				{
					Foxtable.Row parent = this.Rows[num].Parent;
					while (parent != null)
					{
						DataRow baseRow = parent.DataRow.BaseRow;
						if (this.o.0ooOO_0__..ContainsKey(baseRow))
						{
							Dictionary<string, double> dictionary2 = this.o.0ooOO_0__.[baseRow];
							try
							{
								foreach (string text in this.o.0ooOO_0__.)
								{
									double num2 = 0.0;
									if (dictionary.ContainsKey(text) && A_1)
									{
										num2 = -dictionary[text];
									}
									else if (!A_0.IsNull(text))
									{
										num2 = -Conversions.ToDouble(A_0[text]);
									}
									dictionary2[text] += num2;
								}
							}
							finally
							{
								HashSet<string>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						parent = parent.Parent;
						if (A_1)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x0014ACEC File Offset: 0x00148EEC
		internal void <<EMPTY_NAME>>(DataRow A_0)
		{
			if (this.GridTreeVisible && this.o.0ooOO_0__..Count > 0)
			{
				int num = this.o.oO__OO_oo_0_.(A_0);
				Dictionary<string, double> dictionary = new Dictionary<string, double>();
				if (this.o.0ooOO_0__..ContainsKey(A_0))
				{
					dictionary = this.o.0ooOO_0__.[A_0];
				}
				if (num >= 0)
				{
					Foxtable.Row parent = this.Rows[num].Parent;
					if (parent != null)
					{
						DataRow baseRow = parent.DataRow.BaseRow;
						Dictionary<string, double> dictionary2;
						if (this.o.0ooOO_0__..ContainsKey(baseRow))
						{
							dictionary2 = this.o.0ooOO_0__.[baseRow];
						}
						else
						{
							dictionary2 = new Dictionary<string, double>();
							try
							{
								foreach (string text in this.o.0ooOO_0__.)
								{
									if (!baseRow.IsNull(text))
									{
										dictionary2[text] = Conversions.ToDouble(baseRow[text]);
									}
								}
							}
							finally
							{
								HashSet<string>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							this.o.0ooOO_0__.[baseRow] = dictionary2;
						}
						try
						{
							foreach (string text2 in this.o.0ooOO_0__.)
							{
								double num2 = 0.0;
								if (dictionary.ContainsKey(text2))
								{
									num2 = dictionary[text2];
								}
								else if (!A_0.IsNull(text2))
								{
									num2 = Conversions.ToDouble(A_0[text2]);
								}
								if (dictionary2.ContainsKey(text2))
								{
									dictionary2[text2] += num2;
								}
								else
								{
									dictionary2[text2] = num2;
								}
							}
						}
						finally
						{
							HashSet<string>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
			}
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x0014AEA4 File Offset: 0x001490A4
		internal void <<EMPTY_NAME>>(DataRow A_0, string A_1, object A_2, object A_3)
		{
			if (this.foxGrid.OO.o_o00o.() && this.o.0ooOO_0__..Contains(A_1))
			{
				int num = this.o.oO__OO_oo_0_.(A_0);
				if (num >= 0)
				{
					double num2;
					if (A_2 != DBNull.Value)
					{
						num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_2));
					}
					double num3;
					if (A_3 != DBNull.Value)
					{
						num3 = Conversion.Val(RuntimeHelpers.GetObjectValue(A_3));
					}
					double num4 = num3 - num2;
					int num5 = -1;
					int num6 = num;
					int num7 = this.Grid.Rows.Count - 1;
					for (int i = num6; i <= num7; i++)
					{
						if (this.Grid.Rows[i].DataIndex == num)
						{
							num5 = i;
							break;
						}
					}
					if (num5 != -1)
					{
						for (Node node = this.Grid.Rows[num5].Node; node != null; node = node.Parent)
						{
							double num8 = 0.0;
							if (node.Row[A_1] != DBNull.Value)
							{
								num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(node.Row[A_1]));
							}
							node.Row[A_1] = num8 + num4;
						}
					}
				}
			}
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x0014AFD4 File Offset: 0x001491D4
		internal void <<EMPTY_NAME>>(DataRow A_0, string A_1)
		{
			if (this.foxGrid.OO.o_o00o.() && this.o.0ooOO_0__..Contains(A_1))
			{
				int num = this.o.oO__OO_oo_0_.(A_0);
				if (num >= 0)
				{
					int num2 = -1;
					int num3 = num;
					int num4 = this.Grid.Rows.Count - 1;
					for (int i = num3; i <= num4; i++)
					{
						if (this.Grid.Rows[i].DataIndex == num)
						{
							num2 = i;
							break;
						}
					}
					if (num2 != -1)
					{
						Node node = this.Grid.Rows[num2].Node;
						num2 = node.Row.Index;
						while (node != null)
						{
							double num5 = 0.0;
							if (node.FirstChild == null)
							{
								int num6 = num2 + 1;
								int num7 = this.Grid.Rows.Count - 1;
								int num8 = num6;
								while (num8 <= num7 && this.Grid.Rows[num8].DataIndex >= 0)
								{
									if (this.Grid.Rows[num8][A_1] != DBNull.Value)
									{
										num5 = Conversions.ToDouble(Operators.AddObject(num5, this.Grid.Rows[num8][A_1]));
									}
									num8++;
								}
								node.Row[A_1] = num5;
							}
							else
							{
								for (Node node2 = node.FirstChild; node2 != null; node2 = node2.NextNode)
								{
									if (node2.Row[A_1] != DBNull.Value)
									{
										num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(node2.Row[A_1]));
									}
								}
								node.Row[A_1] = num5;
							}
							node = node.Parent;
						}
					}
				}
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0014B1A4 File Offset: 0x001493A4
		internal void <<EMPTY_NAME>>(DataRow A_0)
		{
			if (this.foxGrid.OO.o_o00o.() && this.o.0ooOO_0__..Count > 0)
			{
				int num = this.o.oO__OO_oo_0_.(A_0);
				if (num >= 0)
				{
					int num2 = -1;
					int num3 = num;
					int num4 = this.Grid.Rows.Count - 1;
					for (int i = num3; i <= num4; i++)
					{
						if (this.Grid.Rows[i].DataIndex == num)
						{
							num2 = i;
							break;
						}
					}
					if (num2 != -1)
					{
						Node node = this.Grid.Rows[num2].Node;
						num2 = node.Row.Index;
						while (node != null)
						{
							try
							{
								foreach (string columnName in this.o.0ooOO_0__.)
								{
									double num5 = 0.0;
									if (node.Row[columnName] != DBNull.Value)
									{
										num5 = Conversions.ToDouble(node.Row[columnName]);
									}
									if (!A_0.IsNull(columnName))
									{
										num5 -= Conversion.Val(RuntimeHelpers.GetObjectValue(A_0[columnName]));
									}
									node.Row[columnName] = num5;
								}
							}
							finally
							{
								HashSet<string>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							node = node.Parent;
						}
					}
				}
			}
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0014B30C File Offset: 0x0014950C
		private int <<EMPTY_NAME>>(DataRow A_0)
		{
			for (int i = this.View.Position; i >= 0; i += -1)
			{
				if (this.View.O0O_0_0__.0O.(i).Row == A_0)
				{
					return i;
				}
			}
			int num = this.View.Position + 1;
			int num2 = this.View.Count - 1;
			for (int j = num; j <= num2; j++)
			{
				if (this.View.O0O_0_0__.0O.(j).Row == A_0)
				{
					return j;
				}
			}
			return -1;
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x0014B388 File Offset: 0x00149588
		internal void <<EMPTY_NAME>>(int A_0)
		{
			if (this.o.0ooOO_0__. != null && !this.o.0ooOO_0__..Disposing && !this.o.0ooOO_0__..IsDisposed)
			{
				if (this.o.0ooOO_0__. is oO_oo0Oo)
				{
					((oO_oo0Oo)this.o.0ooOO_0__.).o0ooOo0.0o_Oo. = true;
					((oO_oo0Oo)this.o.0ooOO_0__.).OOOOO0.0. = A_0;
				}
				if (this.o.0ooOO_0__. is oo__)
				{
					((oo__)this.o.0ooOO_0__.).o__oO0.OOo_O. = true;
					((oo__)this.o.0ooOO_0__.).o_.0Oo_oo0_. = A_0;
				}
			}
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x0014B415 File Offset: 0x00149615
		internal void <<EMPTY_NAME>>()
		{
			if (this.foxGrid.Row >= this.foxGrid.Rows.Fixed)
			{
				this.o_o.O_.(this.foxGrid.Row);
			}
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x0014B445 File Offset: 0x00149645
		internal void <<EMPTY_NAME>>()
		{
			if (this.foxGrid.Row > this.foxGrid.Rows.Fixed)
			{
				this.o_o.O_.(this.foxGrid.Row - 1);
			}
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x0014B478 File Offset: 0x00149678
		internal void <<EMPTY_NAME>>(int A_0)
		{
			bool flag;
			if (this.foxGrid.Row != A_0)
			{
				flag = true;
			}
			if (this.foxGrid.OO.o_o00o.() && A_0 < this.foxGrid.Rows.Count - 1 && this.foxGrid.Rows[A_0].DataIndex != -1 && this.foxGrid.Rows[A_0 + 1].DataIndex != -1)
			{
				this.StopRedraw();
				Foxtable.Row row = this.Rows[this.foxGrid.Rows[A_0].DataIndex];
				Foxtable.Row row2 = this.Rows[this.foxGrid.Rows[A_0 + 1].DataIndex];
				double num = Conversion.Val(RuntimeHelpers.GetObjectValue(row["System_Sort_Temporary"]));
				row.BaseDataRow["System_Sort_Temporary"] = RuntimeHelpers.GetObjectValue(row2["System_Sort_Temporary"]);
				row2.BaseDataRow["System_Sort_Temporary"] = num;
				if (flag)
				{
					this.Position = this.FindRow(row2.DataRow);
				}
				else
				{
					this.Position = this.FindRow(row.DataRow);
				}
				bool flag2;
				if (Operators.CompareString(this.O0_O.0oOO0Oo0., O_O0OO.ooO0oO0O.o_O_., true) == 0 && this.DataTable.BaseTable.Columns.Contains(O_O0OO.ooO0oO0O.o_O_.) && this.DataTable.BaseTable.Columns[O_O0OO.ooO0oO0O.o_O_.].DataType == typeof(int))
				{
					if (!row.get_IsNull(O_O0OO.ooO0oO0O.o_O_.) && !row2.get_IsNull(O_O0OO.ooO0oO0O.o_O_.))
					{
						int num2 = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(row[O_O0OO.ooO0oO0O.o_O_.])));
						row.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = RuntimeHelpers.GetObjectValue(row2[O_O0OO.ooO0oO0O.o_O_.]);
						row2.BaseDataRow[O_O0OO.ooO0oO0O.o_O_.] = num2;
						flag2 = true;
					}
				}
				else
				{
					flag2 = true;
				}
				if (!flag2)
				{
					this.OO.0OO000_0__.(this.Grid.Row);
				}
				this.ResumeRedraw();
			}
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x0014B6AC File Offset: 0x001498AC
		private void <<EMPTY_NAME>>(int A_0)
		{
			Node node = this.foxGrid.Rows[A_0].Node;
			Foxtable.Row a_ = this.Rows[this.foxGrid.Rows[A_0].DataIndex];
			List<Foxtable.Row> list = new List<Foxtable.Row>();
			if (node != null)
			{
				int num = node.Row.Index + 1;
				int num2 = this.foxGrid.Rows.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					if (this.foxGrid.Rows[i].DataIndex == -1)
					{
						bool flag;
						if (flag)
						{
							break;
						}
					}
					else
					{
						bool flag;
						if (!flag)
						{
							flag = true;
						}
						list.Add(this.Rows[this.foxGrid.Rows[i].DataIndex]);
					}
				}
			}
			this.OO.0OO000_0__.(list, a_);
		}

		/// <summary>
		/// 获取鼠标位置的图表序号
		/// </summary>
		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x0014B780 File Offset: 0x00149980
		[oO0oooo("3751")]
		public int MouseChartIndex
		{
			get
			{
				int num;
				int result;
				int num9;
				object obj;
				try
				{
					IL_00:
					ProjectData.ClearProjectError();
					num = 1;
					IL_07:
					int num2 = 2;
					Point point = this.Grid.PointToClient(System.Windows.Forms.Control.MousePosition);
					IL_1B:
					num2 = 3;
					int mouseRow = this.Grid.MouseRow;
					IL_2A:
					num2 = 4;
					int mouseCol = this.Grid.MouseCol;
					IL_39:
					num2 = 5;
					if (mouseRow >= this.Grid.Rows.Fixed && mouseCol >= this.Grid.Cols.Fixed)
					{
						goto IL_6C;
					}
					IL_63:
					num2 = 6;
					result = -1;
					goto IL_1C7;
					IL_6C:
					num2 = 7;
					object objectValue = RuntimeHelpers.GetObjectValue(this.Grid.GetUserData(mouseRow, mouseCol));
					IL_84:
					num2 = 8;
					if (objectValue != null)
					{
						goto IL_94;
					}
					IL_8A:
					num2 = 9;
					result = -1;
					goto IL_1C7;
					IL_94:
					num2 = 10;
					List<int> list = new List<int>();
					IL_9E:
					num2 = 11;
					foreach (string s in objectValue.ToString().Trim(new char[]
					{
						'@',
						'{',
						'}'
					}).Split(new char[]
					{
						','
					}))
					{
						IL_DC:
						num2 = 12;
						int item;
						if (int.TryParse(s, out item))
						{
							IL_EA:
							num2 = 13;
							list.Add(item);
						}
						IL_F6:
						num2 = 14;
					}
					IL_107:
					num2 = 15;
					if (list.Count == 2)
					{
						goto IL_11E;
					}
					IL_114:
					num2 = 16;
					result = -1;
					goto IL_1C7;
					IL_11E:
					num2 = 17;
					int num3 = list[0];
					IL_12A:
					num2 = 18;
					int num4 = list[1];
					IL_137:
					num2 = 19;
					Rectangle cellRect = this.Grid.GetCellRect(mouseRow, mouseCol);
					IL_14B:
					num2 = 20;
					int num5 = cellRect.X + 5 + num4;
					IL_15C:
					num2 = 21;
					int num6 = cellRect.Width - (5 + num4) * 2;
					IL_16F:
					num2 = 22;
					int num7 = (int)Math.Floor((double)(point.X - num5) / (double)num6 * (double)list[0]);
					IL_193:
					num2 = 23;
					if (num7 >= 0)
					{
						goto IL_1A1;
					}
					IL_19B:
					num2 = 24;
					num7 = 0;
					IL_1A1:
					num2 = 25;
					if (num7 <= list[0] - 1)
					{
						goto IL_1C1;
					}
					IL_1B2:
					num2 = 26;
					num7 = list[0] - 1;
					IL_1C1:
					num2 = 27;
					result = num7;
					IL_1C7:
					goto IL_289;
					IL_1CC:
					int num8 = num9 + 1;
					num9 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num8);
					IL_24A:
					goto IL_27E;
					IL_24C:
					num9 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_25C:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num9 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_24C;
				}
				IL_27E:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_289:
				if (num9 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0014BA3C File Offset: 0x00149C3C
		internal Rectangle <<EMPTY_NAME>>(Rectangle A_0, int A_1, int A_2)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.Grid.GetUserData(A_1, A_2));
			Rectangle result;
			if (objectValue == null)
			{
				result = A_0;
			}
			else
			{
				List<int> list = new List<int>();
				string[] array = objectValue.ToString().Trim(new char[]
				{
					'@',
					'{',
					'}'
				}).Split(new char[]
				{
					','
				});
				int num;
				int num2;
				checked
				{
					for (int i = 0; i < array.Length; i++)
					{
						int item;
						if (int.TryParse(array[i], out item))
						{
							list.Add(item);
						}
					}
					num = list[0];
					num2 = list[1];
				}
				int num3 = (int)Math.Floor((double)(A_0.Width - (5 + num2) * 2) / (double)num);
				A_0.Width += num3;
				result = A_0;
			}
			return result;
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0014BB04 File Offset: 0x00149D04
		private void <<EMPTY_NAME>>()
		{
			try
			{
				foreach (Table table in OO_00oOO.Tables)
				{
					if (table.DataTable.BaseTable == this.DataTable.BaseTable || table.Name.IndexOf(this.DataTable.Name) >= 0)
					{
						table._frdTableLayout.OOooOOo_.0_0_o.();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.DataTable.BaseTable.Columns.Add("sys_Hierarchy_Level", typeof(int));
			try
			{
				foreach (Table table2 in OO_00oOO.Tables)
				{
					if (table2.DataTable.BaseTable == this.DataTable.BaseTable || table2.Name.IndexOf(this.DataTable.Name) >= 0)
					{
						table2.oO_o_0o._0oooo.(true);
						table2._frdTableLayout.Oo_.oo_oOo_oO.();
					}
				}
			}
			finally
			{
				IEnumerator<Table> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
		}

		// Token: 0x040011B1 RID: 4529
		internal O_0 <<EMPTY_NAME>>;

		// Token: 0x040011B2 RID: 4530
		private O_oOooO_O <<EMPTY_NAME>>;

		// Token: 0x040011B3 RID: 4531
		private Foxtable.RowCollection <<EMPTY_NAME>>;

		// Token: 0x040011B4 RID: 4532
		private ColCollection <<EMPTY_NAME>>;

		// Token: 0x040011B5 RID: 4533
		private StateFilterEnum <<EMPTY_NAME>>;

		// Token: 0x040011B6 RID: 4534
		private TableTypeEnum <<EMPTY_NAME>>;

		// Token: 0x040011B7 RID: 4535
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011B8 RID: 4536
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011B9 RID: 4537
		private OOO0o <<EMPTY_NAME>>;

		// Token: 0x040011BA RID: 4538
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011BB RID: 4539
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011BC RID: 4540
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011BD RID: 4541
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011BE RID: 4542
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011BF RID: 4543
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C0 RID: 4544
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C1 RID: 4545
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C2 RID: 4546
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C3 RID: 4547
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C4 RID: 4548
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C5 RID: 4549
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C6 RID: 4550
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C7 RID: 4551
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C8 RID: 4552
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011C9 RID: 4553
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011CA RID: 4554
		private BooleanEnum <<EMPTY_NAME>>;

		// Token: 0x040011CB RID: 4555
		private MergeModeEnum <<EMPTY_NAME>>;

		// Token: 0x040011CC RID: 4556
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x040011CD RID: 4557
		private string <<EMPTY_NAME>>;

		// Token: 0x040011CE RID: 4558
		private DockAreaEnum <<EMPTY_NAME>>;

		// Token: 0x040011CF RID: 4559
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011D0 RID: 4560
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011D1 RID: 4561
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011D2 RID: 4562
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011D3 RID: 4563
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011D4 RID: 4564
		private SubtotalGroupCollection <<EMPTY_NAME>>;

		// Token: 0x040011D5 RID: 4565
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011D6 RID: 4566
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011D7 RID: 4567
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011D8 RID: 4568
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011D9 RID: 4569
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011DA RID: 4570
		private PrintInfo <<EMPTY_NAME>>;

		// Token: 0x040011DB RID: 4571
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011DC RID: 4572
		[CompilerGenerated]
		private Table.oO00_O_O <<EMPTY_NAME>>;

		// Token: 0x040011DD RID: 4573
		internal GroupTableBuilder <<EMPTY_NAME>>;

		// Token: 0x040011DE RID: 4574
		internal CrossTableBuilder <<EMPTY_NAME>>;

		// Token: 0x040011DF RID: 4575
		private bool <<EMPTY_NAME>>;

		// Token: 0x040011E0 RID: 4576
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011E1 RID: 4577
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x040011E2 RID: 4578
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x040011E3 RID: 4579
		internal Dictionary<string, ListSortDirection> <<EMPTY_NAME>>;

		// Token: 0x040011E4 RID: 4580
		internal o_0oo_OOO_0o_ <<EMPTY_NAME>>;

		// Token: 0x040011E5 RID: 4581
		internal List<Oo0__O__O_0__> <<EMPTY_NAME>>;

		// Token: 0x040011E6 RID: 4582
		internal Assembly <<EMPTY_NAME>>;

		// Token: 0x040011E7 RID: 4583
		private o\u3002\u3000\u3002\u3002\u3002\u3000\u3000\u3002\u3002\u3000 <<EMPTY_NAME>>;

		// Token: 0x040011E8 RID: 4584
		private int <<EMPTY_NAME>>;

		// Token: 0x040011E9 RID: 4585
		private System.Windows.Forms.TreeView <<EMPTY_NAME>>;

		// Token: 0x040011EA RID: 4586
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011EB RID: 4587
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011EC RID: 4588
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011ED RID: 4589
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011EE RID: 4590
		internal char <<EMPTY_NAME>>;

		// Token: 0x040011EF RID: 4591
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011F0 RID: 4592
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011F1 RID: 4593
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011F2 RID: 4594
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011F3 RID: 4595
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011F4 RID: 4596
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011F5 RID: 4597
		internal int <<EMPTY_NAME>>;

		// Token: 0x040011F6 RID: 4598
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011F7 RID: 4599
		internal O0_0_0O0___O <<EMPTY_NAME>>;

		// Token: 0x040011F8 RID: 4600
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011F9 RID: 4601
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011FA RID: 4602
		internal bool <<EMPTY_NAME>>;

		// Token: 0x040011FB RID: 4603
		internal o_0 <<EMPTY_NAME>>;

		// Token: 0x040011FC RID: 4604
		internal OooOo0___oO <<EMPTY_NAME>>;

		// Token: 0x040011FD RID: 4605
		internal string <<EMPTY_NAME>>;

		// Token: 0x040011FE RID: 4606
		internal int <<EMPTY_NAME>>;

		// Token: 0x040011FF RID: 4607
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001200 RID: 4608
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001201 RID: 4609
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001202 RID: 4610
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001203 RID: 4611
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001204 RID: 4612
		internal InlineGroupTableBuilder <<EMPTY_NAME>>;

		// Token: 0x04001205 RID: 4613
		internal LayersGroupTableBuilder <<EMPTY_NAME>>;

		// Token: 0x04001206 RID: 4614
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001207 RID: 4615
		private string <<EMPTY_NAME>>;

		// Token: 0x04001208 RID: 4616
		private bool <<EMPTY_NAME>>;

		// Token: 0x04001209 RID: 4617
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400120A RID: 4618
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400120B RID: 4619
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400120C RID: 4620
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400120D RID: 4621
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400120E RID: 4622
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400120F RID: 4623
		internal int <<EMPTY_NAME>>;

		// Token: 0x04001210 RID: 4624
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001211 RID: 4625
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001212 RID: 4626
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001213 RID: 4627
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001214 RID: 4628
		internal bool <<EMPTY_NAME>>;

		// Token: 0x04001215 RID: 4629
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001216 RID: 4630
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001217 RID: 4631
		internal string <<EMPTY_NAME>>;

		// Token: 0x04001218 RID: 4632
		internal List<string> <<EMPTY_NAME>>;

		// Token: 0x04001219 RID: 4633
		internal Dictionary<DataRow, Dictionary<string, double>> <<EMPTY_NAME>>;

		// Token: 0x0400121A RID: 4634
		internal HashSet<string> <<EMPTY_NAME>>;

		// Token: 0x0400121B RID: 4635
		internal bool <<EMPTY_NAME>>;

		// Token: 0x0400121C RID: 4636
		internal Oo0 <<EMPTY_NAME>>;

		// Token: 0x0400121D RID: 4637
		private bool <<EMPTY_NAME>>;

		// Token: 0x0400121E RID: 4638
		internal string <<EMPTY_NAME>>;

		// Token: 0x0400121F RID: 4639
		private int <<EMPTY_NAME>>;

		// Token: 0x04001220 RID: 4640
		private bool <<EMPTY_NAME>>;

		// Token: 0x0200031D RID: 797
		// (Invoke) Token: 0x06002CDA RID: 11482
		public delegate void oO00_O_O();

		// Token: 0x0200031E RID: 798
		// (Invoke) Token: 0x06002CDE RID: 11486
		private delegate int o0Oo_(string A_0, StringBuilder A_1);

		// Token: 0x0200031F RID: 799
		internal class Oo_0O0o_
		{
			// Token: 0x06002CDF RID: 11487 RVA: 0x0014BC24 File Offset: 0x00149E24
			public Oo_0O0o_()
			{
				int a_ = 19;
				base..ctor();
				this.OO._O_o__. = O00OOOo_O0_O.b("쟵죷죹죻", a_);
				this.Ooo.0OOoO_0. = O00OOOo_O0_O.b("黵賷軹賻", a_);
				this.o0.O_0OO0_00_. = ooO0__OO.O00.O__o.();
				this.o0.O0o_00. = ooO0__OO.O0_.OOo0OO.();
				this.O0_O_o0O00_O.o. = ooO0__OO.o0O._ooo_O_.();
				this.o0o_0.0_O_Oo0o. = O_O0OO.o_Oo0_oOo.0.;
				this.oooooo._000_. = ooO0__OO.oo._o.();
				this.oooO_O0.0. = ooO0__OO.o_0_000._O.();
				this.oo0ooO0_O0.o0. = O00OOOo_O0_O.b("黵賷韹", a_);
				this.O0.o_0Oo0__O. = O00OOOo_O0_O.b("蟵黷诹諻鷽狿儁⼃⤅怇稉椋崍紏嬑Ⱃ紕㌗ⴙ伛儝", a_);
				this.O0O0_o.Oo0_O. = O00OOOo_O0_O.b("蟵鋷뿹뿻ꧽ替倁布縅朇䈉甋挍挏圑礓堕嬗㔙䘛㔝焟ἡ", a_);
				this.O___OOo_O.O0. = O00OOOo_O0_O.b("뿵裷黹꿻鿽拿䌁戃䀅䴇砉䜋琍猏☑挓縕焗猙圛Ⱍ栟唡䰣ഥᰧ温", a_);
				this.oOOoOO0_.O_o0. = O00OOOo_O0_O.b("\ud9f5뇷鏹蓻鳽勿焁䬃儅䨇紉嬋䀍小䌑笓⬕", a_);
			}

			// Token: 0x06002CE0 RID: 11488
			[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
			private static extern IntPtr <<EMPTY_NAME>>(string A_0);

			// Token: 0x06002CE1 RID: 11489
			[DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
			private static extern IntPtr <<EMPTY_NAME>>(IntPtr A_0, string A_1);

			// Token: 0x06002CE2 RID: 11490
			[DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
			private static extern bool <<EMPTY_NAME>>(IntPtr A_0);

			// Token: 0x06002CE3 RID: 11491 RVA: 0x0014BD10 File Offset: 0x00149F10
			internal string <<EMPTY_NAME>>(string A_0)
			{
				int a_ = 9;
				StringBuilder stringBuilder = new StringBuilder(32);
				IntPtr intPtr = Table.Oo_0O0o_.o_Oo.0o0oo__o.(O00.DecryptText(this.O0.o_0Oo0__O. + this.O0O0_o.Oo0_O., O00OOOo_O0_O.b("鳫鳭鿯飱釳闵賷", a_), O00OOOo_O0_O.b("迫臭黯铱鷳釵", a_)));
				string result;
				if (intPtr == IntPtr.Zero)
				{
					result = null;
				}
				else
				{
					try
					{
						IntPtr intPtr2 = Table.Oo_0O0o_.O.OoOo_.(intPtr, O00.DecryptText(this.O___OOo_O.O0. + this.oOOoOO0_.O_o0., O00OOOo_O0_O.b("鳫鳭鿯飱釳闵賷", a_), O00OOOo_O0_O.b("迫臭黯铱鷳釵", a_)));
						if (intPtr2 == IntPtr.Zero)
						{
							result = null;
						}
						else if (((Table.o0Oo_)Marshal.GetDelegateForFunctionPointer(intPtr2, typeof(Table.o0Oo_)))(A_0, stringBuilder) == 1)
						{
							result = stringBuilder.ToString();
						}
						else
						{
							result = null;
						}
					}
					finally
					{
						Table.Oo_0O0o_.O.OoOo_.(intPtr);
					}
				}
				return result;
			}

			// Token: 0x06002CE4 RID: 11492 RVA: 0x0014BE0C File Offset: 0x0014A00C
			private bool <<EMPTY_NAME>>(byte[] A_0, int A_1, byte[] A_2, int A_3, int A_4)
			{
				int num = A_4 - 1;
				for (int i = 0; i <= num; i++)
				{
					A_2[A_3 + i] = A_0[A_1 + i];
				}
				return true;
			}

			// Token: 0x06002CE5 RID: 11493 RVA: 0x0014BE38 File Offset: 0x0014A038
			private bool <<EMPTY_NAME>>(string A_0)
			{
				bool result;
				if (OoO0o.WaitNamedPipe(A_0, 4000) == 0)
				{
					result = false;
				}
				else
				{
					this.Oo.00OoO000. = OoO0o.CreateFile(A_0, 3221225472u, 0, 0, 3, 0, 0);
					result = (this.Oo.00OoO000. != -1);
				}
				return result;
			}

			// Token: 0x06002CE6 RID: 11494 RVA: 0x0014BE7C File Offset: 0x0014A07C
			private bool <<EMPTY_NAME>>(int A_0, ref byte[] A_1)
			{
				int num = 1;
				byte[] array = new byte[1];
				int num2;
				do
				{
					num2 = 0;
					byte[] array2 = new byte[1000];
					if (!OoO0o.ReadFile(A_0, array2, 1000u, ref num2, 0u))
					{
						break;
					}
					byte[] array3 = new byte[num - 1 + 1];
					this.o_Oo.0o0oo__o.(array, 0, array3, 0, num);
					num += num2;
					array = new byte[num - 1 + 1];
					this.o_Oo.0o0oo__o.(array3, 0, array, 0, array3.GetLength(0));
					this.o_Oo.0o0oo__o.(array2, 0, array, num - num2, num2);
				}
				while (num2 >= 1000);
				A_1 = new byte[num - 2 + 1];
				this.o_Oo.0o0oo__o.(array, 1, A_1, 0, num - 1);
				return true;
			}

			// Token: 0x06002CE7 RID: 11495 RVA: 0x0014BF20 File Offset: 0x0014A120
			internal bool <<EMPTY_NAME>>()
			{
				this.O.OoOo_.(this.o_Oo.0o0oo__o.());
				bool result;
				return result;
			}

			// Token: 0x06002CE8 RID: 11496 RVA: 0x0014BF3C File Offset: 0x0014A13C
			private string <<EMPTY_NAME>>()
			{
				int a_ = 15;
				int num;
				string result;
				int num7;
				object obj;
				try
				{
					IL_09:
					ProjectData.ClearProjectError();
					num = 1;
					IL_10:
					int num2 = 2;
					if (Operators.CompareString(this.o0oO0_o._ooo0., "", true) <= 0)
					{
						goto IL_34;
					}
					IL_26:
					num2 = 3;
					result = this.o0oO0_o._ooo0.;
					goto IL_7B4;
					IL_34:
					num2 = 4;
					if (string.IsNullOrEmpty(this.o0oO0_o._ooo0.))
					{
						goto IL_1FB;
					}
					IL_46:
					num2 = 6;
					string text = Application.ProductVersion.Replace(O00OOOo_O0_O.b("\udcf1", a_), "");
					IL_67:
					num2 = 7;
					char value = '0';
					IL_6D:
					num2 = 8;
					char[] array = new char[1];
					IL_77:
					num2 = 9;
					string text2 = "";
					IL_81:
					num2 = 10;
					array[0] = '.';
					IL_8A:
					num2 = 11;
					string[] array2 = null;
					IL_90:
					num2 = 12;
					array2 = text.Split(new char[]
					{
						array[0]
					});
					IL_A9:
					num2 = 13;
					int num3;
					if (!(array2[0].Length > 0 & num3 >= 0))
					{
						goto IL_126;
					}
					IL_C3:
					num2 = 14;
					array2[0] = o_O_o_oOoo__.OOOO_OO._oo.(array2[0]);
					IL_D3:
					num2 = 15;
					if (array2[0].Length <= num3)
					{
						goto IL_FD;
					}
					IL_E3:
					num2 = 16;
					text2 = Conversions.ToString(array2[0][num3]);
					goto IL_1A3;
					IL_FD:
					num2 = 18;
					if (array2[0].Length != num3)
					{
						goto IL_11E;
					}
					IL_10D:
					num2 = 19;
					text2 = Conversions.ToString(value);
					goto IL_1A3;
					IL_11E:
					num2 = 21;
					text2 = null;
					goto IL_1A3;
					IL_126:
					num2 = 23;
					if (!(array2.Length > 1 & num3 < 0))
					{
						goto IL_180;
					}
					IL_138:
					num2 = 24;
					if (array2[1].Length < Math.Abs(num3))
					{
						goto IL_16B;
					}
					IL_14D:
					num2 = 25;
					text2 = Conversions.ToString(array2[1][Math.Abs(num3) - 1]);
					goto IL_1A3;
					IL_16B:
					num2 = 27;
					text2 = O00OOOo_O0_O.b("싱", a_);
					goto IL_1A3;
					IL_180:
					num2 = 29;
					if (num3 >= 0)
					{
						goto IL_19D;
					}
					IL_188:
					num2 = 30;
					text2 = O00OOOo_O0_O.b("싱", a_);
					goto IL_1A3;
					IL_19D:
					num2 = 32;
					text2 = null;
					IL_1A3:
					num2 = 33;
					num3 = 0;
					IL_1A9:
					num2 = 34;
					if (Operators.CompareString(text2, "", true) <= 0)
					{
						goto IL_1FB;
					}
					IL_1BC:
					num2 = 35;
					string text3 = text2;
					for (int i = 0; i < text3.Length; i = checked(i + 1))
					{
						string @string = Conversions.ToString(text3[i]);
						IL_1D8:
						num2 = 36;
						num3 += Microsoft.VisualBasic.Strings.Asc(@string);
						IL_1E7:
						num2 = 37;
					}
					IL_1FB:
					num2 = 38;
					DataRow dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("釱鯳飵雷꧹裻賽槿氁挃㜅", a_));
					IL_21D:
					num2 = 39;
					if (dataRow == null)
					{
						goto IL_377;
					}
					IL_227:
					num2 = 40;
					string text4 = dataRow[O00OOOo_O0_O.b("뇱鯳飵黷鏹鯻", a_)].ToString();
					IL_246:
					num2 = 41;
					string text5 = this.O.OoOo_.(O_O0OO.o.00O_O.() + O00.O0o.__O.(SysInfo.DataIdentify, O00OOOo_O0_O.b("蛱闳铵铷鿹", a_), O00OOOo_O0_O.b("蛱闳铵铷鿹", a_))) + this.O.OoOo_.(O_O0OO.o.00O_O.() + O00.O0o.__O.(Conversions.ToString(SysInfo.FoxtableString), O00OOOo_O0_O.b("蛱闳铵铷鿹", a_), O00OOOo_O0_O.b("蛱闳铵铷鿹", a_)));
					IL_2C1:
					num2 = 42;
					text5 = Microsoft.VisualBasic.Strings.Left(o0OO__.O.0ooOoO_0_.(text5), 10);
					IL_2D4:
					num2 = 43;
					text4 = Microsoft.VisualBasic.Strings.Left(O00.ooo000o_0.00o0.(text4, text5, text5), 10);
					IL_2EB:
					num2 = 44;
					dataRow = O_O0OO.O0_00o.o0__o..Rows.Find(O00OOOo_O0_O.b("釱鯳飵雷꧹裻賽槿氁挃㐅", a_));
					IL_30D:
					num2 = 45;
					if (dataRow == null || dataRow.IsNull(O00OOOo_O0_O.b("釱鯳飵黷鏹鯻", a_)))
					{
						goto IL_365;
					}
					IL_32B:
					num2 = 46;
					text4 = O00.oO_.0o_oo_0O_.(dataRow[O00OOOo_O0_O.b("釱鯳飵黷鏹鯻", a_)].ToString(), text4, o_O_o_oOoo__.OOOO_OO._oo.(text4));
					IL_358:
					num2 = 47;
					this.o0oO0_o._ooo0. = text4;
					goto IL_387;
					IL_365:
					num2 = 49;
					this.o0oO0_o._ooo0. = OoOo0O.OO_o.0o_O.(22);
					goto IL_387;
					IL_377:
					num2 = 51;
					this.o0oO0_o._ooo0. = OoOo0O.OO_o.0o_O.(22);
					IL_387:
					num2 = 52;
					this.OO._O_o__. = this.OO._O_o__..TrimEnd(new char[]
					{
						'.'
					});
					IL_3A6:
					num2 = 53;
					if (Versioned.IsNumeric(this.OO._O_o__.))
					{
						goto IL_3CD;
					}
					IL_3B6:
					num2 = 54;
					this.oooO_O0.0. = O00OOOo_O0_O.b("藱釳铵", a_);
					IL_3CD:
					num2 = 55;
					if (Conversion.Val(this.OO._O_o__.) != 0.0)
					{
						goto IL_3FD;
					}
					IL_3E6:
					num2 = 56;
					this.oooO_O0.0. = O00OOOo_O0_O.b("髱胳苵裷", a_);
					IL_3FD:
					num2 = 57;
					if (Operators.CompareString(this.oooO_O0.0., "", true) != 0)
					{
						goto IL_79B;
					}
					IL_416:
					num2 = 58;
					this.Oo.00OoO000. = (long)((int)Math.Floor(Conversion.Val(this.OO._O_o__.)));
					IL_431:
					num2 = 59;
					if (this.OO._O_o__..IndexOf(O00OOOo_O0_O.b("\udcf1", a_)) < 0)
					{
						goto IL_473;
					}
					IL_450:
					num2 = 60;
					this.o0.O_0OO0_00_. = this.OO._O_o__..Substring(this.OO._O_o__..IndexOf('.') + 1);
					IL_473:
					num2 = 61;
					if (this.Oo.00OoO000. <= 0L)
					{
						goto IL_69C;
					}
					IL_483:
					num2 = 62;
					if (this.Oo.00OoO000. != 0L)
					{
						goto IL_4AA;
					}
					IL_48E:
					num2 = 63;
					this.oooO_O0.0. = O00OOOo_O0_O.b("臱蟳髵", a_);
					goto IL_69C;
					IL_4AA:
					num2 = 65;
					this.OO._O_o__. = this.Oo.00OoO000..ToString();
					IL_4BE:
					num2 = 66;
					int num4 = 1;
					do
					{
						IL_4C4:
						num2 = 67;
						this.o0.O0o_00. = Microsoft.VisualBasic.Strings.Right(this.OO._O_o__., 4);
						IL_4D9:
						num2 = 68;
						this.Oo.00OoO000. = long.Parse(this.o0.O0o_00.);
						IL_4ED:
						num2 = 69;
						this.o0.O0o_00. = this.Oo.00OoO000..ToString();
						IL_501:
						num2 = 70;
						if (num4 == 1)
						{
							IL_509:
							num2 = 71;
							this.oooooo._000_. = this.o0.O0o_00.;
						}
						else
						{
							IL_51D:
							num2 = 73;
							if (this.Oo.00OoO000. > 0L)
							{
								IL_52A:
								num2 = 74;
								this.o0o_0.0_O_Oo0o. = this.o0.O0o_00. + Conversions.ToString(this.oo0ooO0_O0.o0.[num4 - 2]);
							}
							IL_552:
							num2 = 75;
							if (Operators.CompareString(this.oooooo._000_., "", true) > 0)
							{
								IL_569:
								num2 = 76;
								if (this.Oo.00OoO000. == 0L || this.O0_O_o0O00_O.o..Length < 4 || this.o0.O0o_00..EndsWith(O00OOOo_O0_O.b("싱", a_)))
								{
									IL_59D:
									num2 = 77;
									this.oooooo._000_. = this.o0o_0.0_O_Oo0o. + O00OOOo_O0_O.b("裱", a_) + this.oooooo._000_.;
								}
								else
								{
									IL_5C7:
									num2 = 79;
									this.oooooo._000_. = this.o0o_0.0_O_Oo0o. + this.oooooo._000_.;
								}
							}
							else
							{
								IL_5E3:
								num2 = 81;
								this.oooooo._000_. = this.o0o_0.0_O_Oo0o.;
							}
						}
						IL_5F2:
						num2 = 82;
						this.O0_O_o0O00_O.o. = this.o0.O0o_00.;
						IL_601:
						num2 = 83;
						if (this.OO._O_o__..Length <= 4)
						{
							break;
						}
						IL_612:
						num2 = 86;
						this.OO._O_o__. = this.OO._O_o__..Substring(0, this.OO._O_o__..Length - 4);
						IL_634:
						num2 = 87;
						num4++;
					}
					while (num4 <= 4);
					IL_645:
					num2 = 88;
					this.oooooo._000_. = this.oooooo._000_..Replace(O00OOOo_O0_O.b("铱胳蛵", a_), "");
					IL_66C:
					num2 = 89;
					this.oooooo._000_. = this.oooooo._000_..Replace(O00OOOo_O0_O.b("髱胳苵裷", a_), O00OOOo_O0_O.b("雱", a_));
					IL_69C:
					num2 = 90;
					if (Operators.CompareString(this.o0.O_0OO0_00_., "", true) <= 0)
					{
						goto IL_78A;
					}
					IL_6B6:
					num2 = 91;
					if (Operators.CompareString(this.oooooo._000_., "", true) != 0)
					{
						goto IL_6E5;
					}
					IL_6CC:
					num2 = 92;
					this.oooooo._000_. = O00OOOo_O0_O.b("髱胳苵裷觹", a_);
					goto IL_707;
					IL_6E5:
					num2 = 94;
					this.oooooo._000_. += O00OOOo_O0_O.b("臱飳髵", a_);
					IL_707:
					num2 = 95;
					int num5 = this.o0.O_0OO0_00_..Length - this.o0.O_0OO0_00_..TrimStart(new char[]
					{
						'0'
					}).Length;
					IL_733:
					num2 = 96;
					if (num5 <= 0)
					{
						goto IL_766;
					}
					IL_73B:
					num2 = 97;
					this.oooooo._000_. += O00OOOo_O0_O.b("藱", a_).PadLeft(num5, 'w');
					IL_766:
					num2 = 98;
					this.oooooo._000_. += Conversions.ToString(Conversions.ToInteger(this.o0.O_0OO0_00_.));
					IL_78A:
					num2 = 99;
					this.oooO_O0.0. = this.oooooo._000_.;
					goto IL_7AA;
					IL_79B:
					num2 = 101;
					this.oooO_O0.0. = this.oooooo._000_.;
					IL_7AA:
					num2 = 102;
					result = this.o0oO0_o._ooo0.;
					IL_7B4:
					goto IL_9A2;
					IL_7B9:
					int num6 = num7 + 1;
					num7 = 0;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num6);
					IL_963:
					goto IL_997;
					IL_965:
					num7 = num2;
					@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
					IL_975:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_965;
				}
				IL_997:
				throw ProjectData.CreateProjectError(-2146828237);
				IL_9A2:
				if (num7 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}

			// Token: 0x06002CE9 RID: 11497 RVA: 0x0014C910 File Offset: 0x0014AB10
			internal bool <<EMPTY_NAME>>(string A_0, ref byte[] A_1)
			{
				byte[] bytes = Encoding.ASCII.GetBytes(A_0);
				int num = 0;
				OoO0o.WriteFile(this.Oo.00OoO000., bytes, (uint)((ulong)bytes.GetLength(0) + 1UL), ref num, 0u);
				this.o_Oo.0o0oo__o.(this.Oo.00OoO000., ref A_1);
				return true;
			}

			// Token: 0x06002CEA RID: 11498 RVA: 0x0014C958 File Offset: 0x0014AB58
			internal string <<EMPTY_NAME>>(string A_0, string A_1)
			{
				int a_ = 13;
				if (Table.Oo_0O0o_.Oo.00OoO000. == null)
				{
					Table.Oo_0O0o_.Oo.00OoO000. = new Stopwatch();
					Table.Oo_0O0o_.Oo.00OoO000..Start();
				}
				string a_2 = A_0 + O00OOOo_O0_O.b("\udcef", a_) + A_1;
				byte[] bytes = new byte[1];
				this.O.OoOo_.(a_2, ref bytes);
				if (Table.Oo_0O0o_.Oo.00OoO000..Elapsed.TotalMinutes >= (double)Microsoft.VisualBasic.Strings.Len(Main.OO_O.o..Name))
				{
					Table.Oo_0O0o_.Oo.00OoO000..Reset();
					O_O0OO.O0_00o.o0__o..O__O0OO_0._O.();
				}
				return Encoding.ASCII.GetString(bytes);
			}

			// Token: 0x04001221 RID: 4641
			internal string <<EMPTY_NAME>>;

			// Token: 0x04001222 RID: 4642
			internal readonly string <<EMPTY_NAME>>;

			// Token: 0x04001223 RID: 4643
			internal long <<EMPTY_NAME>>;

			// Token: 0x04001224 RID: 4644
			internal string <<EMPTY_NAME>>;

			// Token: 0x04001225 RID: 4645
			internal string <<EMPTY_NAME>>;

			// Token: 0x04001226 RID: 4646
			internal string <<EMPTY_NAME>>;

			// Token: 0x04001227 RID: 4647
			internal string <<EMPTY_NAME>>;

			// Token: 0x04001228 RID: 4648
			internal string <<EMPTY_NAME>>;

			// Token: 0x04001229 RID: 4649
			internal string <<EMPTY_NAME>>;

			// Token: 0x0400122A RID: 4650
			internal readonly string <<EMPTY_NAME>>;

			// Token: 0x0400122B RID: 4651
			internal string <<EMPTY_NAME>>;

			// Token: 0x0400122C RID: 4652
			internal string <<EMPTY_NAME>>;

			// Token: 0x0400122D RID: 4653
			internal string <<EMPTY_NAME>>;

			// Token: 0x0400122E RID: 4654
			internal string <<EMPTY_NAME>>;

			// Token: 0x0400122F RID: 4655
			public int <<EMPTY_NAME>>;

			// Token: 0x04001230 RID: 4656
			private static Stopwatch <<EMPTY_NAME>>;

			// Token: 0x04001231 RID: 4657
			private string <<EMPTY_NAME>>;
		}
	}
}
