using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000298 RID: 664
	[ComVisible(true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class GroupCollection : IEnumerable<GroupOn>
	{
		// Token: 0x06002166 RID: 8550 RVA: 0x000EA1B0 File Offset: 0x000E83B0
		public GroupCollection()
		{
			this.o_0ooO.Oo. = new List<GroupOn>();
			this.o_0ooO.Oo. = new List<ExpressionGroup>();
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x000EA1CE File Offset: 0x000E83CE
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Add(GroupOn Item)
		{
			this.o_0ooO.Oo..Add(Item);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x000EA1DC File Offset: 0x000E83DC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddDef(params object[] args)
		{
			List<object> list = new List<object>();
			checked
			{
				for (int i = 0; i < args.Length; i++)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(args[i]);
					if (objectValue != null)
					{
						if (objectValue is string)
						{
							list.Add(Conversions.ToString(objectValue).Trim());
						}
						else
						{
							list.Add(RuntimeHelpers.GetObjectValue(objectValue));
						}
					}
				}
				switch (list.Count)
				{
				case 1:
				{
					string name = Conversions.ToString(list[0]);
					this.AddDef(name);
					return;
				}
				case 2:
				{
					string name2 = Conversions.ToString(list[0]);
					object objectValue2 = RuntimeHelpers.GetObjectValue(list[1]);
					if (objectValue2 is int || objectValue2 is DateGroupEnum)
					{
						DateGroupEnum dateGroup = (DateGroupEnum)Conversions.ToInteger(objectValue2);
						this.AddDef(name2, dateGroup);
						return;
					}
					string newName = Conversions.ToString(objectValue2);
					this.AddDef(name2, newName);
					return;
				}
				case 3:
				{
					string name3 = Conversions.ToString(list[0]);
					object objectValue3 = RuntimeHelpers.GetObjectValue(list[1]);
					object objectValue4 = RuntimeHelpers.GetObjectValue(list[2]);
					if (objectValue3 is int || objectValue3 is DateGroupEnum)
					{
						DateGroupEnum dateGroup2 = (DateGroupEnum)Conversions.ToInteger(objectValue3);
						string newName2 = Conversions.ToString(objectValue4);
						this.AddDef(name3, dateGroup2, newName2);
						return;
					}
					string newName3 = Conversions.ToString(objectValue3);
					string newCaption = Conversions.ToString(objectValue4);
					this.AddDef(name3, newName3, newCaption);
					return;
				}
				case 4:
				{
					string name4 = Conversions.ToString(list[0]);
					DateGroupEnum dateGroup3 = (DateGroupEnum)Conversions.ToInteger(list[1]);
					string newName4 = Conversions.ToString(list[2]);
					string newCaption2 = Conversions.ToString(list[3]);
					this.AddDef(name4, dateGroup3, newName4, newCaption2);
					return;
				}
				default:
					return;
				}
			}
		}

		/// <summary>
		/// 增加分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		// Token: 0x06002169 RID: 8553 RVA: 0x000EA381 File Offset: 0x000E8581
		public void AddDef(string Name)
		{
			this.o_0ooO.Oo..Add(new GroupOn(Name));
		}

		/// <summary>
		/// 增加分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="NewName">给分组列指定一个新的名称，这个名称在统计表中显示</param>
		// Token: 0x0600216A RID: 8554 RVA: 0x000EA394 File Offset: 0x000E8594
		public void AddDef(string Name, string NewName)
		{
			this.o_0ooO.Oo..Add(new GroupOn(Name, NewName));
		}

		/// <summary>
		/// 增加分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="NewName">给分组列指定一个新的名称，这个名称在统计表中显示</param>&gt;
		/// <param name="NewCaption">给分组列指定标题</param>
		// Token: 0x0600216B RID: 8555 RVA: 0x000EA3A8 File Offset: 0x000E85A8
		public void AddDef(string Name, string NewName, string NewCaption)
		{
			this.o_0ooO.Oo..Add(new GroupOn(Name, NewName, NewCaption));
		}

		/// <summary>
		/// 增加日期型分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="DateGroup">日期列的分组方式</param>
		// Token: 0x0600216C RID: 8556 RVA: 0x000EA3BD File Offset: 0x000E85BD
		public void AddDef(string Name, DateGroupEnum DateGroup)
		{
			this.o_0ooO.Oo..Add(new GroupOn(Name, DateGroup));
		}

		/// <summary>
		/// 增加日期型分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="DateGroup">日期列的分组方式</param>
		/// <param name="NewName">给分组列指定一个新的名称，这个名称在统计表中显示</param>
		// Token: 0x0600216D RID: 8557 RVA: 0x000EA3D1 File Offset: 0x000E85D1
		public void AddDef(string Name, DateGroupEnum DateGroup, string NewName)
		{
			this.o_0ooO.Oo..Add(new GroupOn(Name, DateGroup, NewName));
		}

		/// <summary>
		/// 增加日期型分组列
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="DateGroup">日期列的分组方式</param>
		/// <param name="NewName">给分组列指定一个新的名称，这个名称在统计表中显示</param>
		/// <param name="NewCaption">给分组列指定标题</param>
		// Token: 0x0600216E RID: 8558 RVA: 0x000EA3E6 File Offset: 0x000E85E6
		public void AddDef(string Name, DateGroupEnum DateGroup, string NewName, string NewCaption)
		{
			this.o_0ooO.Oo..Add(new GroupOn(Name, DateGroup, NewName, NewCaption));
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x000EA400 File Offset: 0x000E8600
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddExp(params object[] args)
		{
			string[] array = new string[args.Length - 1 + 1];
			int num = args.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Conversions.ToString(args[i]).Trim();
			}
			if (args.Length == 2)
			{
				this.AddExp(array[0], array[1]);
				return;
			}
			if (args.Length == 3)
			{
				this.AddExp(array[0], array[1], array[2]);
			}
		}

		/// <summary>
		/// 增加表达式分组列，仅对SQLGroupTableBuilder和SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="Expression">表达式</param>
		// Token: 0x06002170 RID: 8560 RVA: 0x000EA464 File Offset: 0x000E8664
		public void AddExp(string Name, string Expression)
		{
			this.Exprs.Add(new ExpressionGroup(Name, Expression, ""));
		}

		/// <summary>
		/// 增加表达式分组列，仅对SQLGroupTableBuilder和SQLCrossTableBuilder有效
		/// </summary>
		/// <param name="Name">分组列名</param>
		/// <param name="Expression">表达式</param>
		/// <param name="Caption">给分组列指定标题</param>
		// Token: 0x06002171 RID: 8561 RVA: 0x000EA47D File Offset: 0x000E867D
		public void AddExp(string Name, string Expression, string Caption)
		{
			this.Exprs.Add(new ExpressionGroup(Name, Expression, Caption));
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000EA492 File Offset: 0x000E8692
		public IEnumerator<GroupOn> GetEnumerator()
		{
			return (IEnumerator<GroupOn>)this.o_0ooO.Oo..GetEnumerator();
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000EA4A9 File Offset: 0x000E86A9
		IEnumerator IEnumerable.<<EMPTY_NAME>>()
		{
			return this.GetEnumerator();
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x000EA4B1 File Offset: 0x000E86B1
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<ExpressionGroup> Exprs
		{
			get
			{
				return this.o_0ooO.Oo.;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000EA4B9 File Offset: 0x000E86B9
		public int Count
		{
			get
			{
				return this.o_0ooO.Oo..Count;
			}
		}

		// Token: 0x17000711 RID: 1809
		public GroupOn this[int A_0]
		{
			get
			{
				return this.o_0ooO.Oo.[A_0];
			}
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000EA4D4 File Offset: 0x000E86D4
		public void RemoveAt(int index)
		{
			this.o_0ooO.Oo..RemoveAt(index);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000EA4E2 File Offset: 0x000E86E2
		public void AddRange(IEnumerable<GroupOn> items)
		{
			this.o_0ooO.Oo..AddRange(items);
		}

		// Token: 0x04000DF7 RID: 3575
		private List<GroupOn> <<EMPTY_NAME>>;

		// Token: 0x04000DF8 RID: 3576
		private List<ExpressionGroup> <<EMPTY_NAME>>;
	}
}
