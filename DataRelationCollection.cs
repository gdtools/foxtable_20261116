using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000312 RID: 786
	[EditorBrowsable(EditorBrowsableState.Never)]
	[oO0oooo("1942")]
	[ComVisible(true)]
	public class DataRelationCollection : IEnumerable<Relation>
	{
		// Token: 0x17000958 RID: 2392
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Relation this[object A_0]
		{
			get
			{
				int a_ = -1;
				Relation result;
				if (int.TryParse(A_0.ToString(), out a_))
				{
					result = this.oo._Oo0.(a_);
				}
				else
				{
					result = this.oo._Oo0.(A_0.ToString());
				}
				return result;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x0012D3A4 File Offset: 0x0012B5A4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Relation Item
		{
			get
			{
				Relation result;
				if (this.Contains(A_0))
				{
					result = new Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations[A_0]);
				}
				else
				{
					MessageBox.Show("关联[" + A_0 + "]不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x0012D3F4 File Offset: 0x0012B5F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Relation Item
		{
			get
			{
				Relation result;
				if (O_O0OO.OOOo.oo_OOOO_0.().Relations.Count > A_0 & A_0 >= 0)
				{
					result = new Relation(O_O0OO.OOOo.oo_OOOO_0.().Relations[A_0]);
				}
				else
				{
					MessageBox.Show("关联索引超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				return result;
			}
		}

		/// <summary>
		/// 判断是否包括指定名称的关联
		/// </summary>
		/// <param name="RelationName"></param>
		// Token: 0x06002A66 RID: 10854 RVA: 0x0012D44B File Offset: 0x0012B64B
		public bool Contains(string RelationName)
		{
			return O_O0OO.OOOo.oo_OOOO_0.().Relations.Contains(RelationName);
		}

		/// <summary>
		/// 关联数量
		/// </summary>
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x0012D45D File Offset: 0x0012B65D
		public int Count
		{
			get
			{
				return O_O0OO.OOOo.oo_OOOO_0.().Relations.Count;
			}
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x0012D470 File Offset: 0x0012B670
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Relation Add(params object[] args)
		{
			switch (args.Length)
			{
			case 3:
			{
				object objectValue = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue2 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue3 = RuntimeHelpers.GetObjectValue(args[2]);
				if (objectValue is string && objectValue2 is DataCol && objectValue3 is DataCol)
				{
					string relationName = Conversions.ToString(objectValue).Trim();
					DataCol parentCol = (DataCol)objectValue2;
					DataCol childCol = (DataCol)objectValue3;
					return this.Add(relationName, parentCol, childCol);
				}
				if (objectValue is string && objectValue2 is object[] && objectValue3 is object[])
				{
					string relationName2 = Conversions.ToString(objectValue).Trim();
					DataCol[] parentCols = (DataCol[])objectValue2;
					DataCol[] childCols = (DataCol[])objectValue3;
					return this.Add(relationName2, parentCols, childCols);
				}
				break;
			}
			case 4:
			{
				object objectValue4 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue5 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue6 = RuntimeHelpers.GetObjectValue(args[2]);
				object objectValue7 = RuntimeHelpers.GetObjectValue(args[3]);
				if (objectValue4 is string && objectValue5 is DataCol && objectValue6 is DataCol && objectValue7 is bool)
				{
					string relationName3 = Conversions.ToString(objectValue4).Trim();
					DataCol parentCol2 = (DataCol)objectValue5;
					DataCol childCol2 = (DataCol)objectValue6;
					bool visible = Conversions.ToBoolean(objectValue7);
					return this.Add(relationName3, parentCol2, childCol2, visible);
				}
				if (objectValue4 is string && objectValue5 is DataCol && objectValue6 is DataCol && objectValue7 is int)
				{
					string relationName4 = Conversions.ToString(objectValue4).Trim();
					DataCol parentCol3 = (DataCol)objectValue5;
					DataCol childCol3 = (DataCol)objectValue6;
					RelationPathEnum relationPath = (RelationPathEnum)Conversions.ToInteger(objectValue7);
					return this.Add(relationName4, parentCol3, childCol3, relationPath);
				}
				if (objectValue4 is string && objectValue5 is object[] && objectValue6 is object[] && objectValue7 is bool)
				{
					string relationName5 = Conversions.ToString(objectValue4).Trim();
					DataCol[] parentCols2 = (DataCol[])objectValue5;
					DataCol[] childCols2 = (DataCol[])objectValue6;
					bool visible2 = Conversions.ToBoolean(objectValue7);
					return this.Add(relationName5, parentCols2, childCols2, visible2);
				}
				if (objectValue4 is string && objectValue5 is object[] && objectValue6 is object[] && objectValue7 is int)
				{
					string relationName6 = Conversions.ToString(objectValue4).Trim();
					DataCol[] parentCols3 = (DataCol[])objectValue5;
					DataCol[] childCols3 = (DataCol[])objectValue6;
					RelationPathEnum relationPath2 = (RelationPathEnum)Conversions.ToInteger(objectValue7);
					return this.Add(relationName6, parentCols3, childCols3, relationPath2);
				}
				break;
			}
			case 5:
			{
				object objectValue8 = RuntimeHelpers.GetObjectValue(args[0]);
				object objectValue9 = RuntimeHelpers.GetObjectValue(args[1]);
				object objectValue10 = RuntimeHelpers.GetObjectValue(args[2]);
				object objectValue11 = RuntimeHelpers.GetObjectValue(args[3]);
				object objectValue12 = RuntimeHelpers.GetObjectValue(args[4]);
				if (objectValue8 is string && objectValue9 is DataCol && objectValue10 is DataCol && objectValue11 is bool && objectValue12 is int)
				{
					string relationName7 = Conversions.ToString(objectValue8).Trim();
					DataCol parentCol4 = (DataCol)objectValue9;
					DataCol childCol4 = (DataCol)objectValue10;
					bool visible3 = Conversions.ToBoolean(objectValue11);
					RelationPathEnum relationPath3 = (RelationPathEnum)Conversions.ToInteger(objectValue12);
					return this.Add(relationName7, parentCol4, childCol4, visible3, relationPath3);
				}
				if (objectValue8 is string && objectValue9 is object[] && objectValue10 is object[] && objectValue11 is bool && objectValue12 is int)
				{
					string relationName8 = Conversions.ToString(objectValue8).Trim();
					DataCol[] parentCols4 = (DataCol[])objectValue9;
					DataCol[] childCols4 = (DataCol[])objectValue10;
					bool visible4 = Conversions.ToBoolean(objectValue11);
					RelationPathEnum relationPath4 = (RelationPathEnum)Conversions.ToInteger(objectValue12);
					return this.Add(relationName8, parentCols4, childCols4, visible4, relationPath4);
				}
				break;
			}
			}
			return null;
		}

		/// <summary>
		/// 增加多列关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCols">父表关联列数组</param>
		/// <param name="ChildCols">子表关联列数组</param>
		/// <param name="Visible">是否显示关联表 </param>
		/// <param name="RelationPath">关联表生成模式</param>
		// Token: 0x06002A69 RID: 10857 RVA: 0x0012D824 File Offset: 0x0012BA24
		public Relation Add(string RelationName, DataCol[] ParentCols, DataCol[] ChildCols, bool Visible, RelationPathEnum RelationPath)
		{
			DataColumn[] array = new DataColumn[ParentCols.Length - 1 + 1];
			DataColumn[] array2 = new DataColumn[ChildCols.Length - 1 + 1];
			Relation result;
			if (this.Contains(RelationName))
			{
				MessageBox.Show("关联[" + RelationName + "]已经存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else if (ParentCols.Length != ChildCols.Length)
			{
				MessageBox.Show("创建关联[" + RelationName + "[失败，父表和子表的关联列数量必须相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				result = null;
			}
			else
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = ParentCols[i].BaseColumn;
					array2[i] = ChildCols[i].BaseColumn;
					if (array[i].DataType != array2[i].DataType)
					{
						MessageBox.Show("创建关联[" + RelationName + "[失败，父表和子表对应关联列的数据类型必须相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return null;
					}
				}
				if (Oo00.O____0O._0.(array[0].Table.TableName, array2[0].Table.TableName, null))
				{
					MessageBox.Show("表之间已经存在关联，无法再增加新的关联" + RelationName + "\"！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					result = null;
				}
				else
				{
					O0Oo o0Oo = new O0Oo(RelationName, array, array2, null);
					o0Oo.oo0__.0Oo0o_.(RelationPath);
					O_O0OO.OOOo.oo_OOOO_0.().Relations.Add(o0Oo);
					Oo00.o00O0O_.O.(RelationName, Visible, true);
					result = new Relation(o0Oo);
				}
			}
			return result;
		}

		/// <summary>
		/// 增加多列关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCols">父表关联列数组</param>
		/// <param name="ChildCols">子表关联列数组</param>
		// Token: 0x06002A6A RID: 10858 RVA: 0x0012D988 File Offset: 0x0012BB88
		public Relation Add(string RelationName, DataCol[] ParentCols, DataCol[] ChildCols)
		{
			return this.Add(RelationName, ParentCols, ChildCols, true, RelationPathEnum.One);
		}

		/// <summary>
		/// 增加多列关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCols">父表关联列数组</param>
		/// <param name="ChildCols">子表关联列数组</param>
		/// <param name="Visible">是否显示关联表 </param>
		// Token: 0x06002A6B RID: 10859 RVA: 0x0012D995 File Offset: 0x0012BB95
		public Relation Add(string RelationName, DataCol[] ParentCols, DataCol[] ChildCols, bool Visible)
		{
			return this.Add(RelationName, ParentCols, ChildCols, Visible, RelationPathEnum.One);
		}

		/// <summary>
		/// 增加多列关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCols">父表关联列数组</param>
		/// <param name="ChildCols">子表关联列数组</param>
		/// <param name="RelationPath">关联表生成模式</param>
		// Token: 0x06002A6C RID: 10860 RVA: 0x0012D9A3 File Offset: 0x0012BBA3
		public Relation Add(string RelationName, DataCol[] ParentCols, DataCol[] ChildCols, RelationPathEnum RelationPath)
		{
			return this.Add(RelationName, ParentCols, ChildCols, true, RelationPath);
		}

		/// <summary>
		/// 增加关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCol">父表关联列</param>
		/// <param name="ChildCol">子表关联列</param>
		// Token: 0x06002A6D RID: 10861 RVA: 0x0012D9B1 File Offset: 0x0012BBB1
		public Relation Add(string RelationName, DataCol ParentCol, DataCol ChildCol)
		{
			return this.Add(RelationName, new DataCol[]
			{
				ParentCol
			}, new DataCol[]
			{
				ChildCol
			}, true, RelationPathEnum.One);
		}

		/// <summary>
		/// 增加关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCol">父表关联列</param>
		/// <param name="ChildCol">子表关联列</param>
		/// <param name="Visible">是否显示关联表 </param>
		// Token: 0x06002A6E RID: 10862 RVA: 0x0012D9D0 File Offset: 0x0012BBD0
		public Relation Add(string RelationName, DataCol ParentCol, DataCol ChildCol, bool Visible)
		{
			return this.Add(RelationName, new DataCol[]
			{
				ParentCol
			}, new DataCol[]
			{
				ChildCol
			}, Visible, RelationPathEnum.One);
		}

		/// <summary>
		/// 增加关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCol">父表关联列</param>
		/// <param name="ChildCol">子表关联列</param>
		/// <param name="RelationPath">关联表生成模式</param>
		// Token: 0x06002A6F RID: 10863 RVA: 0x0012D9F0 File Offset: 0x0012BBF0
		public Relation Add(string RelationName, DataCol ParentCol, DataCol ChildCol, RelationPathEnum RelationPath)
		{
			return this.Add(RelationName, new DataCol[]
			{
				ParentCol
			}, new DataCol[]
			{
				ChildCol
			}, true, RelationPath);
		}

		/// <summary>
		/// 增加关联
		/// </summary>
		/// <param name="RelationName">关联名</param>
		/// <param name="ParentCol">父表关联列</param>
		/// <param name="ChildCol">子表关联列</param>
		/// <param name="Visible">是否显示关联表 </param>
		/// <param name="RelationPath">关联表生成模式</param>
		// Token: 0x06002A70 RID: 10864 RVA: 0x0012DA10 File Offset: 0x0012BC10
		public Relation Add(string RelationName, DataCol ParentCol, DataCol ChildCol, bool Visible, RelationPathEnum RelationPath)
		{
			return this.Add(RelationName, new DataCol[]
			{
				ParentCol
			}, new DataCol[]
			{
				ChildCol
			}, Visible, RelationPath);
		}

		/// <summary>
		/// 删除指定名称的关联
		/// </summary>
		/// <param name="RelationName"></param>
		// Token: 0x06002A71 RID: 10865 RVA: 0x0012DA34 File Offset: 0x0012BC34
		public void Delete(string RelationName)
		{
			if (O_O0OO.OoO.0OO__0ooo.().Tables[ooO0__OO.O0.ooO0O.()].Rows.Find(RelationName) != null)
			{
				MessageBox.Show("固有关联只能通过菜单命令删除，不能通过代码删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (this.Contains(RelationName))
			{
				Oo00.OO.0O0o.(RelationName);
			}
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x0012DA85 File Offset: 0x0012BC85
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator<Relation> GetEnumerator()
		{
			return new o0o_Oo_o();
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x0012DA8C File Offset: 0x0012BC8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IEnumerator GetEnumerator1()
		{
			return new o0o_Oo_o();
		}
	}
}
