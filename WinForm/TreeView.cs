using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable.WinForm
{
	/// <summary>
	/// 目录树控件
	/// </summary>
	// Token: 0x0200053D RID: 1341
	[ComVisible(true)]
	public class TreeView : Control
	{
		// Token: 0x060059EA RID: 23018 RVA: 0x00260F11 File Offset: 0x0025F111
		public TreeView(TreeView A_0) : base(A_0, ControlTypeEnum.TreeView)
		{
			this.oO._o_00_O. = A_0;
			A_0.ShowNodeToolTips = true;
			A_0.HideSelection = false;
		}

		/// <summary>
		/// 是否显示复选框
		/// </summary>
		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x060059EB RID: 23019 RVA: 0x00260F31 File Offset: 0x0025F131
		// (set) Token: 0x060059EC RID: 23020 RVA: 0x00260F3E File Offset: 0x0025F13E
		[oO0oooo("1286")]
		public bool CheckBoxes
		{
			get
			{
				return this.oO._o_00_O..CheckBoxes;
			}
			set
			{
				this.oO._o_00_O..CheckBoxes = value;
				if (value)
				{
					this.ItemHeight = Math.Max(16, this.ItemHeight);
				}
			}
		}

		/// <summary>
		/// 是否显示加减号
		/// </summary>
		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x060059ED RID: 23021 RVA: 0x00260F62 File Offset: 0x0025F162
		// (set) Token: 0x060059EE RID: 23022 RVA: 0x00260F6F File Offset: 0x0025F16F
		public bool ShowPlusMinus
		{
			get
			{
				return this.oO._o_00_O..ShowPlusMinus;
			}
			set
			{
				this.oO._o_00_O..ShowPlusMinus = value;
			}
		}

		/// <summary>
		/// 是否显示显示节点连线
		/// </summary>
		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x00260F7D File Offset: 0x0025F17D
		// (set) Token: 0x060059F0 RID: 23024 RVA: 0x00260F8A File Offset: 0x0025F18A
		public bool ShowLines
		{
			get
			{
				return this.oO._o_00_O..ShowLines;
			}
			set
			{
				this.oO._o_00_O..ShowLines = value;
			}
		}

		/// <summary>
		/// 节点高度
		/// </summary>
		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x060059F1 RID: 23025 RVA: 0x00260F98 File Offset: 0x0025F198
		// (set) Token: 0x060059F2 RID: 23026 RVA: 0x00260FA5 File Offset: 0x0025F1A5
		public int ItemHeight
		{
			get
			{
				return this.oO._o_00_O..ItemHeight;
			}
			set
			{
				if (value > 0)
				{
					this.oO._o_00_O..ItemHeight = value;
					return;
				}
				this.oO._o_00_O..ItemHeight = (int)Math.Ceiling((double)this.oO._o_00_O..Font.Size * 1.5);
			}
		}

		/// <summary>
		/// 默认节点图标文件
		/// </summary>
		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x00260FE4 File Offset: 0x0025F1E4
		// (set) Token: 0x060059F4 RID: 23028 RVA: 0x00260FEC File Offset: 0x0025F1EC
		public string ImageFile
		{
			get
			{
				return this.oO._o_00_O.;
			}
			set
			{
				this.oO._o_00_O. = value;
				this.SetImageKey();
			}
		}

		/// <summary>
		/// 选定节点的图表文件
		/// </summary>
		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x060059F5 RID: 23029 RVA: 0x00260FFB File Offset: 0x0025F1FB
		// (set) Token: 0x060059F6 RID: 23030 RVA: 0x00261003 File Offset: 0x0025F203
		public string SelectedImageFile
		{
			get
			{
				return this.OO_OOOOOO00.O.;
			}
			set
			{
				this.OO_OOOOOO00.O. = value;
				this.SetImageKey();
			}
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00261014 File Offset: 0x0025F214
		private void SetImageKey()
		{
			if (Operators.CompareString(this.ImageFile, "", true) <= 0 && Operators.CompareString(this.SelectedImageFile, "", true) <= 0)
			{
				this.oO._o_00_O..ImageKey = string.Empty;
				this.oO._o_00_O..SelectedImageKey = string.Empty;
				return;
			}
			ImageList imageList;
			if (this.oO._o_00_O..ImageList == null)
			{
				imageList = new ImageList();
				this.oO._o_00_O..ImageList = imageList;
			}
			else
			{
				imageList = this.oO._o_00_O..ImageList;
			}
			if (Operators.CompareString(this.ImageFile, "", true) > 0 && !imageList.Images.Keys.Contains(this.ImageFile))
			{
				Image image = OO_00oOO.GetImage(this.ImageFile);
				if (image != null)
				{
					imageList.Images.Add(this.ImageFile, image);
				}
			}
			if (Operators.CompareString(this.SelectedImageFile, "", true) > 0 && !imageList.Images.Keys.Contains(this.SelectedImageFile))
			{
				Image image2 = OO_00oOO.GetImage(this.SelectedImageFile);
				if (image2 != null)
				{
					imageList.Images.Add(this.SelectedImageFile, image2);
				}
			}
			if (Operators.CompareString(this.ImageFile, "", true) > 0)
			{
				this.oO._o_00_O..ImageKey = this.ImageFile;
			}
			else if (Operators.CompareString(this.SelectedImageFile, "", true) > 0)
			{
				this.oO._o_00_O..ImageKey = this.SelectedImageFile;
			}
			else
			{
				this.oO._o_00_O..ImageKey = string.Empty;
			}
			if (Operators.CompareString(this.SelectedImageFile, "", true) > 0)
			{
				this.oO._o_00_O..SelectedImageKey = this.SelectedImageFile;
				return;
			}
			if (Operators.CompareString(this.ImageFile, "", true) > 0)
			{
				this.oO._o_00_O..SelectedImageKey = this.ImageFile;
				return;
			}
			this.oO._o_00_O..SelectedImageKey = string.Empty;
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x060059F8 RID: 23032 RVA: 0x002611ED File Offset: 0x0025F3ED
		// (set) Token: 0x060059F9 RID: 23033 RVA: 0x002611F0 File Offset: 0x0025F3F0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string NodesSettingString
		{
			get
			{
				return null;
			}
			set
			{
				if (Operators.CompareString(value, "", true) != 0)
				{
					string[] array = value.Split(new char[]
					{
						'\f'
					});
					TreeNodeCollection nodes = this.oO._o_00_O..Nodes;
					O_o__00Ooo o_o__00Ooo = null;
					this.oO._o_00_O..BeginUpdate();
					foreach (string text in array)
					{
						if (Operators.CompareString(text, "Inner", true) == 0)
						{
							nodes = o_o__00Ooo.Nodes;
						}
						else if (Operators.CompareString(text, "Outer", true) == 0)
						{
							if (nodes[0].Parent.Parent == null)
							{
								nodes = this.oO._o_00_O..Nodes;
							}
							else
							{
								nodes = nodes[0].Parent.Parent.Nodes;
							}
						}
						else
						{
							o_o__00Ooo = new O_o__00Ooo();
							nodes.Add(o_o__00Ooo);
							o_O_o_oOoo__.OOOO_OO._oo.(new CustomTreeNodeProperty(o_o__00Ooo), text, '\t');
						}
					}
					this.oO._o_00_O..EndUpdate();
				}
			}
		}

		/// <summary>
		/// 节点集合
		/// </summary>
		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x060059FA RID: 23034 RVA: 0x002612DC File Offset: 0x0025F4DC
		[oO0oooo("0887")]
		public TreeNodes Nodes
		{
			get
			{
				if (this.oO._o_00_O. == null)
				{
					Interlocked.CompareExchange<StaticLocalInitFlag>(ref this.oO._o_00_O., new StaticLocalInitFlag(), null);
				}
				bool flag = false;
				try
				{
					Monitor.Enter(this.oO._o_00_O., ref flag);
					if (this.oO._o_00_O..State == 0)
					{
						this.oO._o_00_O..State = 2;
						this.oO_0o_.0__O. = null;
					}
					else if (this.oO._o_00_O..State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.oO._o_00_O..State = 1;
					if (flag)
					{
						Monitor.Exit(this.oO._o_00_O.);
					}
				}
				if (this.oO_0o_.0__O. == null)
				{
					this.oO_0o_.0__O. = new TreeNodes(this.oO._o_00_O..Nodes);
				}
				return this.oO_0o_.0__O.;
			}
		}

		/// <summary>
		/// 返回或者设置选定的节点
		/// </summary>
		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060059FB RID: 23035 RVA: 0x0026139C File Offset: 0x0025F59C
		// (set) Token: 0x060059FC RID: 23036 RVA: 0x002613D1 File Offset: 0x0025F5D1
		[oO0oooo("0884")]
		public TreeNode SelectedNode
		{
			get
			{
				TreeNode result;
				if (this.oO._o_00_O..SelectedNode != null)
				{
					result = new TreeNode((O_o__00Ooo)this.oO._o_00_O..SelectedNode);
				}
				else
				{
					result = null;
				}
				return result;
			}
			set
			{
				if (value == null)
				{
					this.oO._o_00_O..SelectedNode = null;
					return;
				}
				this.oO._o_00_O..SelectedNode = value.BaseNode;
			}
		}

		/// <summary>
		/// 折叠所有节点
		/// </summary>
		// Token: 0x060059FD RID: 23037 RVA: 0x002613F4 File Offset: 0x0025F5F4
		public void CollapseAll()
		{
			this.oO._o_00_O..CollapseAll();
		}

		/// <summary>
		/// 展开所有节点
		/// </summary>
		// Token: 0x060059FE RID: 23038 RVA: 0x00261401 File Offset: 0x0025F601
		public void ExpandAll()
		{
			this.oO._o_00_O..ExpandAll();
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x0026140E File Offset: 0x0025F60E
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildDataTree2(string DataTable, string RowFilter, string RowSort, params string[] Columns)
		{
			this.BuildDataTree2(OO_00oOO.DataTables[DataTable], RowFilter, RowSort, Columns);
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x00261425 File Offset: 0x0025F625
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildDataTree2(DataTable DataTable, string RowFilter, string RowSort, params string[] Columns)
		{
			oOO0oo_o0.O.ooooo.(this.oO._o_00_O., DataTable.BaseTable, RowFilter, RowSort, "", string.Join("|", Columns), true);
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x0026144C File Offset: 0x0025F64C
		public void BuildDataTree(string DataTable, string RowFilter, params string[] Columns)
		{
			if (OO_00oOO.DataTables.Contains(DataTable))
			{
				this.BuildDataTree2(OO_00oOO.DataTables[DataTable], RowFilter, "", Columns);
			}
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x00261473 File Offset: 0x0025F673
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void BuildDataTree(DataTable DataTable, string RowFilter, params string[] Columns)
		{
			this.BuildDataTree2(DataTable, RowFilter, "", Columns);
		}

		/// <summary>
		/// 生成多列内容生成目录树
		/// </summary>
		/// <param name="DataTable">数据表</param>
		/// <param name="ColumnNames">指定数据列，不同的列之间用符号“|”隔开，例如：产品|客户|雇员”</param>
		/// <param name="Filter">过滤条件</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06005A03 RID: 23043 RVA: 0x00261483 File Offset: 0x0025F683
		[oO0oooo("0893")]
		public void BuildTree(DataTable DataTable, string ColumnNames, string Filter = "", string Sort = "")
		{
			oOO0oo_o0.O.ooooo.(this.oO._o_00_O., DataTable.BaseTable, Filter, Sort, "", ColumnNames, true);
		}

		/// <summary>
		/// 生成多列内容生成目录树
		/// </summary>
		/// <param name="DataTableName">数据表名</param>
		/// <param name="ColumnNames">指定数据列，不同的列之间用符号“|”隔开，例如：产品|客户|雇员”</param>
		/// <param name="Filter">过滤条件</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06005A04 RID: 23044 RVA: 0x002614A0 File Offset: 0x0025F6A0
		[oO0oooo("0893")]
		public void BuildTree(string DataTableName, string ColumnNames, string Filter = "", string Sort = "")
		{
			string[] columns = ColumnNames.Split(new char[]
			{
				'|'
			});
			this.BuildDataTree2(DataTableName, Filter, Sort, columns);
		}

		/// <summary>
		/// 根据单列内容生成目录树
		/// </summary>
		/// <param name="DataTable">数据表</param>
		/// <param name="Column">数据列名</param>
		/// <param name="Separator">设置分隔符，默认分隔符为"\"</param>
		/// <param name="Filter">过滤条件</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06005A05 RID: 23045 RVA: 0x002614CA File Offset: 0x0025F6CA
		[oO0oooo("1969")]
		public void CreateTree(DataTable DataTable, string Column, string Separator = "\\", string Filter = "", string Sort = "")
		{
			this.CreateDataTree(DataTable.BaseTable, Column, Separator, Filter, Sort, "", "");
		}

		/// <summary>
		/// 根据路径列和标题列生成目录树
		/// </summary>
		/// <param name="DataTable">数据表</param>
		/// <param name="Column">数据列名</param>
		/// <param name="CaptionColumn">标题列名</param>
		/// <param name="Separator">设置分隔符，默认分隔符为"\"</param>
		/// <param name="Filter">过滤条件</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06005A06 RID: 23046 RVA: 0x002614E8 File Offset: 0x0025F6E8
		[oO0oooo("2621")]
		public void GenerateTree(DataTable DataTable, string Column, string CaptionColumn, string Separator = "\\", string Filter = "", string Sort = "")
		{
			this.CreateDataTree(DataTable.BaseTable, Column, Separator, Filter, Sort, CaptionColumn, "");
		}

		/// <summary>
		/// 根据路径列和标题列生成目录树
		/// </summary>
		/// <param name="DataTableName">数据表名</param>
		/// <param name="Column">数据列名</param>
		/// <param name="CaptionColumn">标题列名</param>
		/// <param name="Separator">设置分隔符，默认分隔符为"\"</param>
		/// <param name="Filter">过滤条件</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06005A07 RID: 23047 RVA: 0x00261503 File Offset: 0x0025F703
		[oO0oooo("2621")]
		public void GenerateTree(string DataTableName, string Column, string CaptionColumn, string Separator = "\\", string Filter = "", string Sort = "")
		{
			this.CreateDataTree(OO_00oOO.DataTables[DataTableName].BaseTable, Column, Separator, Filter, Sort, CaptionColumn, "");
		}

		/// <summary>
		/// 根据单列内容生成目录树
		/// </summary>
		/// <param name="DataTableName">数据表</param>
		/// <param name="Column">数据列名</param>
		/// <param name="Separator">设置分隔符，默认分隔符为"\"</param>
		/// <param name="Filter">过滤条件</param>
		/// <param name="Sort">排序列</param>
		// Token: 0x06005A08 RID: 23048 RVA: 0x00261528 File Offset: 0x0025F728
		[oO0oooo("1969")]
		public void CreateTree(string DataTableName, string Column, string Separator = "\\", string Filter = "", string Sort = "")
		{
			this.CreateDataTree(OO_00oOO.DataTables[DataTableName].BaseTable, Column, Separator, Filter, Sort, "", "");
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x00261550 File Offset: 0x0025F750
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void CreateDataTree(string DataTablename, string Column, string Separator = "\\", string Filter = "", string Sort = "")
		{
			this.CreateDataTree(OO_00oOO.DataTables[DataTablename].BaseTable, Column, Separator, Filter, Sort, "", "");
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x00261578 File Offset: 0x0025F778
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void CreateDataTree(DataTable DataTable, string Column, string Separator = "\\", string Filter = "", string Sort = "", string CaptionColumn = "", string SourceCols = "")
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
				if (Operators.CompareString(Sort, "", true) != 0)
				{
					goto IL_1F;
				}
				IL_18:
				num2 = 3;
				Sort = Column;
				goto IL_24;
				IL_1F:
				num2 = 5;
				bool flag = true;
				IL_24:
				num2 = 6;
				if (Operators.CompareString(Filter, "", true) <= 0)
				{
					goto IL_4E;
				}
				IL_36:
				num2 = 7;
				Filter = Filter + " And [" + Column + "] IS NOT NULL";
				goto IL_63;
				IL_4E:
				num2 = 9;
				Filter = "[" + Column + "] IS NOT NULL";
				IL_63:
				num2 = 10;
				if (Operators.CompareString(Separator, "", true) != 0)
				{
					goto IL_7E;
				}
				IL_74:
				num2 = 11;
				Separator = "\\";
				IL_7E:
				num2 = 12;
				string pathSeparator = this.oO._o_00_O..PathSeparator;
				IL_8E:
				num2 = 13;
				DataRow[] array = DataTable.Select(Filter, Sort);
				IL_9D:
				num2 = 14;
				List<string> list = new List<string>();
				IL_A7:
				num2 = 15;
				this.oO._o_00_O..BeginUpdate();
				IL_B5:
				num2 = 16;
				this.oO._o_00_O..Nodes.Clear();
				IL_C8:
				num2 = 17;
				TreeNode treeNode = null;
				IL_CE:
				num2 = 18;
				Dictionary<string, DataRow> dictionary = new Dictionary<string, DataRow>();
				IL_D8:
				num2 = 19;
				if (SourceCols != null)
				{
					goto IL_E9;
				}
				IL_DF:
				num2 = 20;
				SourceCols = "";
				IL_E9:
				num2 = 21;
				string[] array2 = SourceCols.Split(new char[]
				{
					'|'
				}, StringSplitOptions.RemoveEmptyEntries);
				IL_101:
				num2 = 22;
				foreach (string text in array2)
				{
					IL_114:
					num2 = 23;
					if (!DataTable.Columns.Contains(text))
					{
						IL_126:
						num2 = 24;
						MessageBox.Show("无效列名：" + text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						IL_5E8:
						goto IL_7D2;
					}
					IL_148:
					num2 = 26;
				}
				IL_159:
				num2 = 27;
				this.oO._o_00_O..PathSeparator = "\\";
				IL_16C:
				num2 = 28;
				int num3 = array.Length - 1;
				int j = 0;
				while (j <= num3)
				{
					IL_17F:
					num2 = 29;
					DataRow value = array[j];
					IL_189:
					num2 = 30;
					if (j <= 0)
					{
						goto IL_1BE;
					}
					IL_191:
					num2 = 31;
					if (Operators.CompareString(array[j][Column].ToString(), array[j - 1][Column].ToString(), true) != 0)
					{
						goto IL_1BE;
					}
					IL_21C:
					num2 = 39;
					j++;
					continue;
					IL_1BE:
					num2 = 33;
					string text2;
					if (Operators.CompareString(Separator, "\\", true) == 0)
					{
						IL_1CF:
						num2 = 34;
						text2 = array[j][Column].ToString();
					}
					else
					{
						IL_1E5:
						num2 = 36;
						text2 = array[j][Column].ToString().Replace(Separator, "\\");
					}
					IL_204:
					num2 = 37;
					list.Add(text2);
					IL_20F:
					num2 = 38;
					dictionary.Add(text2, value);
					goto IL_21C;
				}
				IL_22E:
				num2 = 40;
				if (Operators.CompareString(Separator, "\\", true) == 0 || Operators.CompareString(Sort, Column, true) != 0)
				{
					goto IL_254;
				}
				IL_24A:
				num2 = 41;
				list.Sort();
				IL_254:
				num2 = 42;
				List<string>.Enumerator enumerator = list.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text3 = enumerator.Current;
					IL_26E:
					num2 = 43;
					string[] array4 = text3.Split(new char[]
					{
						'\\'
					});
					IL_285:
					num2 = 44;
					DataRow tag = dictionary[text3];
					IL_293:
					num2 = 45;
					int num4;
					if (treeNode != null)
					{
						for (;;)
						{
							IL_29D:
							num2 = 47;
							if (text3.StartsWith(treeNode.FullPath + "\\"))
							{
								break;
							}
							IL_362:
							num2 = 61;
							treeNode = treeNode.ParentNode;
							IL_36E:
							num2 = 62;
							if (treeNode == null)
							{
								goto IL_378;
							}
						}
						IL_2BD:
						num2 = 48;
						num4 = treeNode.Level + 1;
						IL_2CB:
						num2 = 49;
						if (flag)
						{
							IL_2D2:
							num2 = 50;
							if (treeNode.Nodes.Contains(array4[num4]))
							{
								IL_2E8:
								num2 = 51;
								treeNode = treeNode.Nodes[array4[num4]];
							}
							else
							{
								IL_300:
								num2 = 53;
								treeNode = treeNode.Nodes.Add(array4[num4], array4[num4]);
							}
						}
						else
						{
							IL_31D:
							num2 = 55;
							treeNode = treeNode.Nodes.Add(array4[num4], array4[num4]);
						}
						IL_338:
						num2 = 56;
						if (array2.Length == 0)
						{
							IL_341:
							num2 = 57;
							treeNode.BaseNode.Tag = tag;
						}
						IL_352:
						num2 = 58;
						num4 = treeNode.Level + 1;
					}
					IL_378:
					num2 = 65;
					if (treeNode == null)
					{
						IL_37F:
						num2 = 66;
						treeNode = this.Nodes[array4[0]];
						IL_393:
						num2 = 67;
						if (treeNode == null)
						{
							IL_39A:
							num2 = 68;
							treeNode = this.Nodes.Add(array4[0], array4[0]);
						}
						IL_3B2:
						num2 = 69;
						if (array2.Length == 0)
						{
							IL_3BB:
							num2 = 70;
							treeNode.BaseNode.Tag = tag;
						}
						IL_3CC:
						num2 = 71;
						num4 = 1;
					}
					IL_3D2:
					num2 = 72;
					int num5 = num4;
					int num6 = array4.Length - 1;
					for (int k = num5; k <= num6; k++)
					{
						IL_3E6:
						num2 = 73;
						if (flag)
						{
							IL_3ED:
							num2 = 74;
							if (treeNode.Nodes.Contains(array4[k]))
							{
								IL_403:
								num2 = 75;
								treeNode = treeNode.Nodes[array4[k]];
							}
							else
							{
								IL_41B:
								num2 = 77;
								treeNode = treeNode.Nodes.Add(array4[k], array4[k]);
							}
						}
						else
						{
							IL_438:
							num2 = 79;
							treeNode = treeNode.Nodes.Add(array4[k], array4[k]);
						}
						IL_453:
						num2 = 80;
						if (array2.Length == 0)
						{
							IL_45C:
							num2 = 81;
							treeNode.BaseNode.Tag = tag;
						}
						IL_46D:
						num2 = 82;
					}
					IL_47F:
					num2 = 83;
				}
				IL_48E:
				num2 = 84;
				((IDisposable)enumerator).Dispose();
				IL_49E:
				num2 = 85;
				if (Operators.CompareString(CaptionColumn, "", true) <= 0 && array2.Length <= 0)
				{
					goto IL_5CA;
				}
				IL_4BB:
				num2 = 86;
				if (dictionary.Count <= 0)
				{
					goto IL_5CA;
				}
				IL_4CB:
				num2 = 87;
				for (int l = this.AllNodes.Count - 1; l >= 0; l += -1)
				{
					IL_4E2:
					num2 = 88;
					TreeNode treeNode2 = this.AllNodes[l];
					IL_4F4:
					num2 = 89;
					string text2 = treeNode2.FullPath;
					IL_4FF:
					num2 = 90;
					if (dictionary.ContainsKey(text2))
					{
						IL_50F:
						num2 = 91;
						if (Operators.CompareString(CaptionColumn, "", true) > 0)
						{
							IL_522:
							num2 = 92;
							treeNode2.Text = dictionary[text2][CaptionColumn].ToString();
						}
						IL_540:
						num2 = 93;
						if (array2.Length > 0)
						{
							IL_54A:
							num2 = 94;
							string text4 = "";
							IL_554:
							num2 = 95;
							foreach (string columnName in array2)
							{
								IL_567:
								num2 = 96;
								text4 = text4 + "\t" + dictionary[text2][columnName].ToString();
								IL_58C:
								num2 = 97;
							}
							IL_59D:
							num2 = 98;
							treeNode2.Tag = text4.Trim(new char[]
							{
								'\t'
							});
						}
					}
					IL_5B9:
					num2 = 99;
				}
				IL_5CA:
				num2 = 100;
				this.oO._o_00_O..PathSeparator = pathSeparator;
				IL_5DA:
				num2 = 101;
				this.oO._o_00_O..EndUpdate();
				goto IL_5E8;
				IL_5ED:
				int num7 = num8 + 1;
				num8 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num7);
				IL_793:
				goto IL_7C7;
				IL_795:
				num8 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_7A5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num8 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_795;
			}
			IL_7C7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7D2:
			if (num8 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		/// <summary>
		/// 将目录树保存为一个文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		/// <param name="All">否保存节点的所有属性，默认为False，只保存节点的名称和标题属性</param>
		// Token: 0x06005A0B RID: 23051 RVA: 0x00261D7C File Offset: 0x0025FF7C
		[oO0oooo("1974")]
		public void Save(string FileName, bool All = false)
		{
			OO_00oOO.FileSys.WriteAllText(FileName, this.SaveToString(All), false, Encoding.Unicode);
		}

		/// <summary>
		/// 根据指定的文件生成目录树
		/// </summary>
		/// <param name="FileName">文件名</param>
		// Token: 0x06005A0C RID: 23052 RVA: 0x00261D98 File Offset: 0x0025FF98
		[oO0oooo("1975")]
		public void Load(string FileName)
		{
			if (OO_00oOO.FileSys.FileExists(FileName))
			{
				string str = OO_00oOO.FileSys.ReadAllText(FileName, Encoding.Unicode);
				this.LoadFromString(str);
				return;
			}
			MessageBox.Show("没有找到文件：" + FileName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		/// <summary>
		/// 根据指定的字符串生成目录树
		/// </summary>
		/// <param name="Str1"></param>
		// Token: 0x06005A0D RID: 23053 RVA: 0x00261DE4 File Offset: 0x0025FFE4
		[oO0oooo("2015")]
		public void LoadFromString(string Str1)
		{
			this.NodesSettingString = Str1;
		}

		/// <summary>
		/// 将目录树保存为一个字符串
		/// </summary>
		/// <param name="All">可选参数，逻辑型，是否保存节点的所有属性，默认为False，只保存节点的名称和标题属性</param>
		// Token: 0x06005A0E RID: 23054 RVA: 0x00261DF0 File Offset: 0x0025FFF0
		[oO0oooo("2014")]
		public string SaveToString(bool All = false)
		{
			string result = null;
			if (All)
			{
				oOO0oo_o0.O__o0o0O0O_.0.(this.oO._o_00_O..Nodes, ref result);
			}
			else
			{
				oOO0oo_o0.o.O0o000_.(this.oO._o_00_O..Nodes, ref result);
			}
			return result;
		}

		/// <summary>
		/// 编辑选定节点的标题
		/// </summary>
		// Token: 0x06005A0F RID: 23055 RVA: 0x00261E29 File Offset: 0x00260029
		public void BeginEdit()
		{
			if (this.oO._o_00_O..SelectedNode != null)
			{
				this.oO._o_00_O..LabelEdit = true;
				this.oO._o_00_O..SelectedNode.BeginEdit();
			}
		}

		/// <summary>
		/// 一个集合，包括目录树的全部节点
		/// </summary>
		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06005A10 RID: 23056 RVA: 0x00261E54 File Offset: 0x00260054
		[oO0oooo("2302")]
		public List<TreeNode> AllNodes
		{
			get
			{
				List<TreeNode> list = new List<TreeNode>();
				ooO_0O.o_O0.O_.(this.oO._o_00_O..Nodes, list);
				return list;
			}
		}

		/// <summary>
		/// 停止绘制目录树
		/// </summary>
		// Token: 0x06005A11 RID: 23057 RVA: 0x00261E79 File Offset: 0x00260079
		[oO0oooo("2439")]
		public void StopRedraw()
		{
			this.oO._o_00_O..BeginUpdate();
		}

		/// <summary>
		/// 恢复绘制目录树
		/// </summary>
		// Token: 0x06005A12 RID: 23058 RVA: 0x00261E86 File Offset: 0x00260086
		[oO0oooo("2440")]
		public void ResumeRedraw()
		{
			this.oO._o_00_O..EndUpdate();
		}

		/// <summary>
		/// 默认为False，如果设置为True，那么通过代码代码设置目录树节点的勾选状态时，也会触发AfterCheckNode事件
		/// </summary>
		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06005A13 RID: 23059 RVA: 0x00261E94 File Offset: 0x00260094
		// (set) Token: 0x06005A14 RID: 23060 RVA: 0x00261EC4 File Offset: 0x002600C4
		public bool RaiseCheckedEventAnyWay
		{
			get
			{
				return !(this.oO._o_00_O. is O__oO_o0_o_o) || ((O__oO_o0_o_o)this.oO._o_00_O.).Ooo__.ooO_0.();
			}
			set
			{
				if (this.oO._o_00_O. is O__oO_o0_o_o)
				{
					((O__oO_o0_o_o)this.oO._o_00_O.).Ooo__.ooO_0.(value);
				}
			}
		}

		// Token: 0x04002334 RID: 9012
		private TreeView <<EMPTY_NAME>>;

		// Token: 0x04002335 RID: 9013
		private string <<EMPTY_NAME>>;

		// Token: 0x04002336 RID: 9014
		private string <<EMPTY_NAME>>;

		// Token: 0x04002337 RID: 9015
		private TreeNodes <<EMPTY_NAME>>;

		// Token: 0x04002338 RID: 9016
		private StaticLocalInitFlag <<EMPTY_NAME>>;
	}
}
