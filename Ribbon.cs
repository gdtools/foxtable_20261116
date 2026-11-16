using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200047E RID: 1150
	[OoO0___o("Ribbon")]
	internal class Ribbon
	{
		// Token: 0x06004E5E RID: 20062 RVA: 0x00237874 File Offset: 0x00235A74
		public Ribbon(DataTable A_0)
		{
			this.OoOOo.0OoO_oo_. = VisualStyleEnum.Office2007Blue;
			this.OoOOo.0OoO_oo_. = "Foxtable";
			this.OoOOo.0OoO_oo_. = true;
			this.o0O0.0_oo. = false;
			this.o._oOOO00_o_0O. = false;
			this.oO.0oO. = false;
			this.O0o.O00. = new ContextMenuCollection();
			this.oo00OO_0.0o000. = new RibbonTabCollection();
			this.oo00OO_0.0o000. = new RibbonTopTabCollection();
			this.oO_.ooOoo. = A_0;
			this.oo0o.oo_oOoOo0.();
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x002378E4 File Offset: 0x00235AE4
		internal void <<EMPTY_NAME>>()
		{
			DataRow[] array = this.DataTable.Select("[Type] = " + Conversions.ToString(0));
			if (array.Length == 0)
			{
				this.O0o.O00. = this.DataTable.NewRow();
				this.O0o.O00.["Key"] = ShareLibriay.GetRandString(8);
				this.O0o.O00.["Type"] = RibbonItemTypeEnum.Ribbon;
				this.DataTable.Rows.Add(this.O0o.O00.);
			}
			else
			{
				this.O0o.O00. = array[0];
				o_O_o_oOoo__.OOOO_OO._oo.(this, this.O0o.O00., false);
			}
			array = this.DataTable.Select("[Type] = " + Conversions.ToString(2));
			if (array.Length == 0)
			{
				this.Oo_.0o_o___O. = this.DataTable.NewRow();
				this.Oo_.0o_o___O.["Key"] = ShareLibriay.GetRandString(8);
				this.Oo_.0o_o___O.["Type"] = RibbonItemTypeEnum.QAT;
				this.DataTable.Rows.Add(this.Oo_.0o_o___O.);
			}
			else
			{
				this.Oo_.0o_o___O. = array[0];
			}
			this.O0o.O00. = new RibbonQat(this.Oo_.0o_o___O.);
			array = this.DataTable.Select("[Type] = " + Conversions.ToString(3));
			if (array.Length == 0)
			{
				this.o0.0_o_O_0. = this.DataTable.NewRow();
				this.o0.0_o_O_0.["Key"] = ShareLibriay.GetRandString(8);
				this.o0.0_o_O_0.["Type"] = RibbonItemTypeEnum.ConfigBar;
				this.DataTable.Rows.Add(this.o0.0_o_O_0.);
			}
			else
			{
				this.o0.0_o_O_0. = array[0];
			}
			this.O0o.O00. = new RibbonConfigToolBar(this.o0.0_o_O_0.);
			array = this.DataTable.Select("[Type] = " + Conversions.ToString(35));
			if (array.Length == 0)
			{
				this.o00.__. = this.DataTable.NewRow();
				this.o00.__.["Key"] = ShareLibriay.GetRandString(8);
				this.o00.__.["Type"] = RibbonItemTypeEnum.TopToolBar;
				this.DataTable.Rows.Add(this.o00.__.);
			}
			else
			{
				this.o00.__. = array[0];
			}
			this.oo00OO_0.0o000. = new RibbonTopToolBar(this.o00.__.);
			if (o_O_o_oOoo__.O_o_._o0. == null)
			{
				o_O_o_oOoo__.O_o_._o0. = new bool?(this.oo0o.oo_oOoOo0.());
			}
			array = this.DataTable.Select("[Type] = " + Conversions.ToString(36));
			if (array.Length == 0)
			{
				this.o_0_oO.0O_. = this.DataTable.NewRow();
				this.o_0_oO.0O_.["Key"] = ShareLibriay.GetRandString(8);
				this.o_0_oO.0O_.["Type"] = RibbonItemTypeEnum.BottomToolBar;
				this.DataTable.Rows.Add(this.o_0_oO.0O_.);
			}
			else
			{
				this.o_0_oO.0O_. = array[0];
			}
			this.O0o.O00. = new RibbonBottomToolBar(this.o_0_oO.0O_.);
			array = this.DataTable.Select("[Type] = " + Conversions.ToString(1));
			if (array.Length == 0)
			{
				this.OoOo_0O_oo_._0. = this.DataTable.NewRow();
				this.OoOo_0O_oo_._0.["Key"] = ShareLibriay.GetRandString(8);
				this.OoOo_0O_oo_._0.["Type"] = RibbonItemTypeEnum.ApplicationMenu;
				this.DataTable.Rows.Add(this.OoOo_0O_oo_._0.);
			}
			else
			{
				this.OoOo_0O_oo_._0. = array[0];
			}
			this.O0o.O00. = new RibbonApplicationMenu(this.OoOo_0O_oo_._0.);
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x00237C70 File Offset: 0x00235E70
		internal bool <<EMPTY_NAME>>()
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
				string text = SysInfo.dmstring;
				IL_10:
				num2 = 3;
				text = o_O_o_oOoo__.OOOO_OO._oo.(text);
				IL_1B:
				num2 = 4;
				string[] array = text.Split(new char[]
				{
					'|'
				});
				IL_31:
				num2 = 5;
				string typeName = array[0];
				IL_39:
				num2 = 6;
				string name = array[1];
				IL_41:
				num2 = 7;
				string name2 = array[2];
				IL_49:
				num2 = 8;
				Type type = Type.GetType(typeName, true);
				IL_55:
				num2 = 9;
				PropertyInfo property = type.GetProperty(name, BindingFlags.Static | BindingFlags.Public);
				IL_65:
				num2 = 10;
				object objectValue = RuntimeHelpers.GetObjectValue(property.GetValue(null, null));
				IL_78:
				num2 = 11;
				PropertyInfo property2 = type.GetProperty(name2, BindingFlags.Instance | BindingFlags.Public);
				IL_88:
				num2 = 12;
				object objectValue2 = RuntimeHelpers.GetObjectValue(property2.GetValue(RuntimeHelpers.GetObjectValue(objectValue), null));
				IL_A1:
				num2 = 13;
				result = (objectValue2 != null);
				IL_AA:
				goto IL_134;
				IL_AF:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_F5:
				goto IL_129;
				IL_F7:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_107:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_F7;
			}
			IL_129:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_134:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x00237DD8 File Offset: 0x00235FD8
		internal void <<EMPTY_NAME>>(object A_0)
		{
			string a_ = ooO0__OO.O_Oo00oO.Ooo.();
			string str = "{";
			string str2 = "}";
			a_ = Oo00.ooO.ooo.();
			if (A_0 == this.O0o.O00.)
			{
				this.Oo_.0o_o___O.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., false, '\v', false);
				this.Oo_.0o_o___O.["Code"] = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., true, '\v', false), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2;
			}
			if (A_0 == this.O0o.O00.)
			{
				this.OoOo_0O_oo_._0.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., false, '\v', false);
				this.OoOo_0O_oo_._0.["Code"] = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., true, '\v', false), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2;
			}
			if (A_0 == this.O0o.O00.)
			{
				this.o0.0_o_O_0.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., false, '\v', false);
				this.o0.0_o_O_0.["Code"] = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., true, '\v', false), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2;
			}
			if (A_0 == this.oo00OO_0.0o000.)
			{
				this.o00.__.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(this.oo00OO_0.0o000., false, '\v', false);
				this.o00.__.["Code"] = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this.oo00OO_0.0o000., true, '\v', false), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2;
			}
			if (A_0 == this.O0o.O00.)
			{
				this.o_0_oO.0O_.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., false, '\v', false);
				this.o_0_oO.0O_.["Code"] = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this.O0o.O00., true, '\v', false), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2;
			}
			if (A_0 == this)
			{
				this.O0o.O00.["Property"] = o_O_o_oOoo__.OOOO_OO._oo.(this, false, '\v', false);
				this.O0o.O00.["Code"] = str + O00.ooo000o_0.00o0.(o_O_o_oOoo__.OOOO_OO._oo.(this, true, '\v', false), ooO0__OO.O_Oo00oO.Ooo.(), a_) + str2;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06004E62 RID: 20066 RVA: 0x00238010 File Offset: 0x00236210
		internal DataTable DataTable
		{
			get
			{
				return this.oO_.ooOoo.;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x00238018 File Offset: 0x00236218
		// (set) Token: 0x06004E64 RID: 20068 RVA: 0x00238020 File Offset: 0x00236220
		[O_Oo00Oo000O0(1.0)]
		[Category("属性")]
		[DisplayName("标题")]
		public string Text
		{
			get
			{
				return this.OoOOo.0OoO_oo_.;
			}
			set
			{
				this.OoOOo.0OoO_oo_. = value;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x00238029 File Offset: 0x00236229
		// (set) Token: 0x06004E66 RID: 20070 RVA: 0x00238031 File Offset: 0x00236231
		[O_Oo00Oo000O0(3.0)]
		[Editor(typeof(ooo), typeof(UITypeEditor))]
		[Category("属性")]
		[DisplayName("图标")]
		[Description("一个32*32尺寸的图标，或者对应大小的图片。")]
		public string Image
		{
			get
			{
				return this.o0O0.0_oo.;
			}
			set
			{
				this.o0O0.0_oo. = value;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x0023803A File Offset: 0x0023623A
		// (set) Token: 0x06004E68 RID: 20072 RVA: 0x00238042 File Offset: 0x00236242
		[O_Oo00Oo000O0(3.1)]
		[DefaultValue(false)]
		[Category("属性")]
		[DisplayName("允许最小化")]
		public bool AllowMinimize
		{
			get
			{
				return this.o._oOOO00_o_0O.;
			}
			set
			{
				this.o._oOOO00_o_0O. = value;
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06004E69 RID: 20073 RVA: 0x0023804B File Offset: 0x0023624B
		// (set) Token: 0x06004E6A RID: 20074 RVA: 0x00238053 File Offset: 0x00236253
		[Category("属性")]
		[O_Oo00Oo000O0(3.11)]
		[DisplayName("默认最小化")]
		[DefaultValue(false)]
		public bool Minimized
		{
			get
			{
				return this.o0O0.0_oo.;
			}
			set
			{
				this.o0O0.0_oo. = value;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06004E6B RID: 20075 RVA: 0x0023805C File Offset: 0x0023625C
		// (set) Token: 0x06004E6C RID: 20076 RVA: 0x00238064 File Offset: 0x00236264
		[DisplayName("显示文件名")]
		[DefaultValue(true)]
		[O_Oo00Oo000O0(3.2)]
		[Category("属性")]
		[Description("是否在标题栏显示当前打开文件的名称。")]
		public bool ShowFileName
		{
			get
			{
				return this.OoOOo.0OoO_oo_.;
			}
			set
			{
				this.OoOOo.0OoO_oo_. = value;
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x0023806D File Offset: 0x0023626D
		// (set) Token: 0x06004E6E RID: 20078 RVA: 0x00238075 File Offset: 0x00236275
		[Category("属性")]
		[DefaultValue(false)]
		[DisplayName("隐藏功能区标题")]
		[O_Oo00Oo000O0(4.0)]
		public bool HideTabHederRow
		{
			get
			{
				return this.oO.0oO.;
			}
			set
			{
				this.oO.0oO. = value;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06004E6F RID: 20079 RVA: 0x0023807E File Offset: 0x0023627E
		// (set) Token: 0x06004E70 RID: 20080 RVA: 0x00238086 File Offset: 0x00236286
		[Description("指定负责菜单设计的用户")]
		[Category("属性")]
		[DisplayName("责任设计者")]
		[TypeConverter(typeof(oO0O_O))]
		[O_Oo00Oo000O0(5.0)]
		public string Developer
		{
			get
			{
				return this.oOO.O_00o.;
			}
			set
			{
				this.oOO.O_00o. = value;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06004E71 RID: 20081 RVA: 0x0023808F File Offset: 0x0023628F
		// (set) Token: 0x06004E72 RID: 20082 RVA: 0x00238097 File Offset: 0x00236297
		[O_Oo00Oo000O0(1.0)]
		[Description("单击某按钮后执行。")]
		[Category("全局事件")]
		[oO0oooo("1129")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		public EventString Click
		{
			get
			{
				return this.ooOOOoo__.O_.;
			}
			set
			{
				this.ooOOOoo__.O_. = value;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06004E73 RID: 20083 RVA: 0x002380A0 File Offset: 0x002362A0
		// (set) Token: 0x06004E74 RID: 20084 RVA: 0x002380A8 File Offset: 0x002362A8
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1129")]
		[Browsable(false)]
		[Category("全局事件")]
		[Description("双击某按钮后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		public EventString DoubleClick
		{
			get
			{
				return this.oOO.O_00o.;
			}
			set
			{
				this.oOO.O_00o. = value;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06004E75 RID: 20085 RVA: 0x002380B1 File Offset: 0x002362B1
		// (set) Token: 0x06004E76 RID: 20086 RVA: 0x002380B9 File Offset: 0x002362B9
		[Description("某编辑框取消修改后执行。")]
		[O_Oo00Oo000O0(3.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1129")]
		[Category("全局事件")]
		[O0O0oOO00_0OO(true)]
		public EventString ChangeCanceled
		{
			get
			{
				return this.OO.__OO0o.;
			}
			set
			{
				this.OO.__OO0o. = value;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06004E77 RID: 20087 RVA: 0x002380C2 File Offset: 0x002362C2
		// (set) Token: 0x06004E78 RID: 20088 RVA: 0x002380CA File Offset: 0x002362CA
		[oO0oooo("1129")]
		[Description("某编辑框提交修改后执行。")]
		[Category("全局事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.0)]
		public EventString ChangeCommitted
		{
			get
			{
				return this.O00O0.0O000__.;
			}
			set
			{
				this.O00O0.0O000__. = value;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06004E79 RID: 20089 RVA: 0x002380D3 File Offset: 0x002362D3
		// (set) Token: 0x06004E7A RID: 20090 RVA: 0x002380DB File Offset: 0x002362DB
		[Category("全局事件")]
		[Description("某编辑框内容改变后执行。")]
		[oO0oooo("1129")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		public EventString TextChanged
		{
			get
			{
				return this.O0o.OoOo_.;
			}
			set
			{
				this.O0o.OoOo_. = value;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06004E7B RID: 20091 RVA: 0x002380E4 File Offset: 0x002362E4
		// (set) Token: 0x06004E7C RID: 20092 RVA: 0x002380EC File Offset: 0x002362EC
		[oO0oooo("1129")]
		[Category("全局事件")]
		[Description("某编辑框获得输入焦点后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(6.0)]
		public EventString GotFocus
		{
			get
			{
				return this.O0O.___O0__.;
			}
			set
			{
				this.O0O.___O0__. = value;
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06004E7D RID: 20093 RVA: 0x002380F5 File Offset: 0x002362F5
		// (set) Token: 0x06004E7E RID: 20094 RVA: 0x002380FD File Offset: 0x002362FD
		[O0O0oOO00_0OO(true)]
		[Description("某编辑框失去输入焦点后执行。")]
		[oO0oooo("1129")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Category("全局事件")]
		[O_Oo00Oo000O0(7.0)]
		public EventString LostFocus
		{
			get
			{
				return this.o_0_._o.;
			}
			set
			{
				this.o_0_._o. = value;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06004E7F RID: 20095 RVA: 0x00238106 File Offset: 0x00236306
		// (set) Token: 0x06004E80 RID: 20096 RVA: 0x0023810E File Offset: 0x0023630E
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1129")]
		[Description("某检查框的选中状态改变后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(9.0)]
		[Category("全局事件")]
		public EventString CheckedChanged
		{
			get
			{
				return this.OO0_o0.0O0O.;
			}
			set
			{
				this.OO0_o0.0O0O. = value;
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06004E81 RID: 20097 RVA: 0x00238117 File Offset: 0x00236317
		// (set) Token: 0x06004E82 RID: 20098 RVA: 0x0023811F File Offset: 0x0023631F
		[oO0oooo("1129")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(10.0)]
		[Description("某状态按钮的状态改变后执行。")]
		[Category("全局事件")]
		[O0O0oOO00_0OO(true)]
		public EventString PressedChanged
		{
			get
			{
				return this.o_oOOo_o.O_O0.;
			}
			set
			{
				this.o_oOOo_o.O_O0. = value;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06004E83 RID: 20099 RVA: 0x00238128 File Offset: 0x00236328
		// (set) Token: 0x06004E84 RID: 20100 RVA: 0x00238130 File Offset: 0x00236330
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1129")]
		[O_Oo00Oo000O0(11.0)]
		[Category("全局事件")]
		[Description("在状态分组中，某一个状态按钮的状态改变后执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString PressedButtonChanged
		{
			get
			{
				return this.oooO.O.;
			}
			set
			{
				this.oooO.O. = value;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06004E85 RID: 20101 RVA: 0x00238139 File Offset: 0x00236339
		// (set) Token: 0x06004E86 RID: 20102 RVA: 0x00238141 File Offset: 0x00236341
		[Category("全局事件")]
		[oO0oooo("1129")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("在某组合框中选择不同项目后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(12.0)]
		public EventString SelectedIndexChanged
		{
			get
			{
				return this.O0O_O0oo.OOOO_.;
			}
			set
			{
				this.O0O_O0oo.OOOO_. = value;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06004E87 RID: 20103 RVA: 0x0023814A File Offset: 0x0023634A
		// (set) Token: 0x06004E88 RID: 20104 RVA: 0x00238152 File Offset: 0x00236352
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("打开下拉列表或菜单的时候执行。")]
		[oO0oooo("1129")]
		[Category("全局事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(13.0)]
		public EventString DropDown
		{
			get
			{
				return this.o0._OoO.;
			}
			set
			{
				this.o0._OoO. = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06004E89 RID: 20105 RVA: 0x0023815B File Offset: 0x0023635B
		// (set) Token: 0x06004E8A RID: 20106 RVA: 0x00238163 File Offset: 0x00236363
		[Category("全局事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("关闭下拉列表或菜单的时候执行。")]
		[oO0oooo("1129")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(14.0)]
		public EventString DropDownClosed
		{
			get
			{
				return this.O_00O.o0.;
			}
			set
			{
				this.O_00O.o0. = value;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x0023816C File Offset: 0x0023636C
		// (set) Token: 0x06004E8C RID: 20108 RVA: 0x00238174 File Offset: 0x00236374
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1129")]
		[Category("全局事件")]
		[Description("单击某分组的对话按钮后执行")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(15.0)]
		public EventString DialogLauncherClick
		{
			get
			{
				return this.oOO_._0_.;
			}
			set
			{
				this.oOO_._0_. = value;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x0023817D File Offset: 0x0023637D
		// (set) Token: 0x06004E8E RID: 20110 RVA: 0x00238185 File Offset: 0x00236385
		[oO0oooo("1129")]
		[Category("全局事件")]
		[Description("选择某功能区后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(16.0)]
		public EventString SelectTab
		{
			get
			{
				return this.O0o.O_00.;
			}
			set
			{
				this.O0o.O_00. = value;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x0023818E File Offset: 0x0023638E
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x00238196 File Offset: 0x00236396
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1129")]
		[Description("离开某功能区后执行。")]
		[Category("全局事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(17.0)]
		public EventString DeselectTab
		{
			get
			{
				return this.OOo_.00o.;
			}
			set
			{
				this.OOo_.00o. = value;
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x0023819F File Offset: 0x0023639F
		// (set) Token: 0x06004E92 RID: 20114 RVA: 0x002381A7 File Offset: 0x002363A7
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("系统空闲的时候执行。")]
		[oO0oooo("1130")]
		[Category("系统事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(0.0)]
		public EventString SystemIdle
		{
			get
			{
				return this.O00_O_o_O.00oo.;
			}
			set
			{
				this.O00_O_o_O.00oo. = value;
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06004E93 RID: 20115 RVA: 0x002381B0 File Offset: 0x002363B0
		// (set) Token: 0x06004E94 RID: 20116 RVA: 0x002381B8 File Offset: 0x002363B8
		[Description("选择不同主表后执行。")]
		[oO0oooo("1130")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(1.0)]
		[Category("系统事件")]
		[O0O0oOO00_0OO(true)]
		public EventString MainTableChanged
		{
			get
			{
				return this.oO_.OO_0_.;
			}
			set
			{
				this.oO_.OO_0_. = value;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06004E95 RID: 20117 RVA: 0x002381C1 File Offset: 0x002363C1
		// (set) Token: 0x06004E96 RID: 20118 RVA: 0x002381C9 File Offset: 0x002363C9
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("选择不同表后执行。")]
		[oO0oooo("1130")]
		[Category("系统事件")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(2.0)]
		public EventString CurrentTableChanged
		{
			get
			{
				return this.Ooo0o00.oo_o.;
			}
			set
			{
				this.Ooo0o00.oo_o. = value;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x002381D2 File Offset: 0x002363D2
		// (set) Token: 0x06004E98 RID: 20120 RVA: 0x002381DA File Offset: 0x002363DA
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[oO0oooo("1130")]
		[Category("系统事件")]
		[Description("选择不同行后执行。")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(4.0)]
		public EventString CurrentChanged
		{
			get
			{
				return this.O.00_0O0_OO0.;
			}
			set
			{
				this.O.00_0O0_OO0. = value;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06004E99 RID: 20121 RVA: 0x002381E3 File Offset: 0x002363E3
		// (set) Token: 0x06004E9A RID: 20122 RVA: 0x002381EB File Offset: 0x002363EB
		[oO0oooo("1130")]
		[Category("系统事件")]
		[Description("选择不同行位置后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(5.0)]
		public EventString PositionChanged
		{
			get
			{
				return this.oOo00.0o_O_O_.;
			}
			set
			{
				this.oOo00.0o_O_O_. = value;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06004E9B RID: 20123 RVA: 0x002381F4 File Offset: 0x002363F4
		// (set) Token: 0x06004E9C RID: 20124 RVA: 0x002381FC File Offset: 0x002363FC
		[oO0oooo("1130")]
		[Category("系统事件")]
		[Description("选择不同的单元格后执行，也就是表的RowSel、ColSel属性发生变化后执行。")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O_Oo00Oo000O0(5.1)]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSelChange
		{
			get
			{
				return this.O_._0_O.;
			}
			set
			{
				this.O_._0_O. = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06004E9D RID: 20125 RVA: 0x00238205 File Offset: 0x00236405
		// (set) Token: 0x06004E9E RID: 20126 RVA: 0x0023820D File Offset: 0x0023640D
		[oO0oooo("1130")]
		[Category("系统事件")]
		[O_Oo00Oo000O0(6.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("在表中选择不同区域后执行，也就是表的TopRow、LeftCol、BottomRow、RightCol等属性发生变化后执行。")]
		[O0O0oOO00_0OO(true)]
		public EventString AfterSelRangeChange
		{
			get
			{
				return this.OOOOo0._o.;
			}
			set
			{
				this.OOOOo0._o. = value;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06004E9F RID: 20127 RVA: 0x00238216 File Offset: 0x00236416
		// (set) Token: 0x06004EA0 RID: 20128 RVA: 0x0023821E File Offset: 0x0023641E
		[oO0oooo("1130")]
		[Description("生成菜单后执行，通常用来做一些初始化工作。")]
		[Category("系统事件")]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(7.0)]
		public EventString Load
		{
			get
			{
				return this.OO_0o.o_O0__0_.;
			}
			set
			{
				this.OO_0o.o_O0__0_. = value;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06004EA1 RID: 20129 RVA: 0x00238227 File Offset: 0x00236427
		// (set) Token: 0x06004EA2 RID: 20130 RVA: 0x0023822F File Offset: 0x0023642F
		[oO0oooo("1130")]
		[O0O0oOO00_0OO(true)]
		[O_Oo00Oo000O0(8.0)]
		[Editor(typeof(o_oo0_0_Oo0O_), typeof(UITypeEditor))]
		[Description("打开系统或者切换用户之后执行，可以在此针对用户进行权限方面的设置。")]
		[Category("系统事件")]
		public EventString LoadUserSetting
		{
			get
			{
				return this.o00O00.0O_o.;
			}
			set
			{
				this.o00O00.0O_o. = value;
			}
		}

		// Token: 0x04001FFF RID: 8191
		private VisualStyleEnum <<EMPTY_NAME>>;

		// Token: 0x04002000 RID: 8192
		private string <<EMPTY_NAME>>;

		// Token: 0x04002001 RID: 8193
		private string <<EMPTY_NAME>>;

		// Token: 0x04002002 RID: 8194
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002003 RID: 8195
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002004 RID: 8196
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002005 RID: 8197
		private bool <<EMPTY_NAME>>;

		// Token: 0x04002006 RID: 8198
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04002007 RID: 8199
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04002008 RID: 8200
		internal RibbonQat <<EMPTY_NAME>>;

		// Token: 0x04002009 RID: 8201
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x0400200A RID: 8202
		internal RibbonConfigToolBar <<EMPTY_NAME>>;

		// Token: 0x0400200B RID: 8203
		internal RibbonTopToolBar <<EMPTY_NAME>>;

		// Token: 0x0400200C RID: 8204
		internal DataRow <<EMPTY_NAME>>;

		// Token: 0x0400200D RID: 8205
		internal RibbonBottomToolBar <<EMPTY_NAME>>;

		// Token: 0x0400200E RID: 8206
		internal DataRow <<EMPTY_NAME>>;

		// Token: 0x0400200F RID: 8207
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04002010 RID: 8208
		internal RibbonApplicationMenu <<EMPTY_NAME>>;

		// Token: 0x04002011 RID: 8209
		internal ContextMenuCollection <<EMPTY_NAME>>;

		// Token: 0x04002012 RID: 8210
		internal RibbonTabCollection <<EMPTY_NAME>>;

		// Token: 0x04002013 RID: 8211
		internal RibbonTopTabCollection <<EMPTY_NAME>>;

		// Token: 0x04002014 RID: 8212
		private DataTable <<EMPTY_NAME>>;

		// Token: 0x04002015 RID: 8213
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002016 RID: 8214
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002017 RID: 8215
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002018 RID: 8216
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002019 RID: 8217
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400201A RID: 8218
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400201B RID: 8219
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400201C RID: 8220
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400201D RID: 8221
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400201E RID: 8222
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400201F RID: 8223
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002020 RID: 8224
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002021 RID: 8225
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002022 RID: 8226
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002023 RID: 8227
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002024 RID: 8228
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002025 RID: 8229
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002026 RID: 8230
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002027 RID: 8231
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002028 RID: 8232
		private EventString <<EMPTY_NAME>>;

		// Token: 0x04002029 RID: 8233
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400202A RID: 8234
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400202B RID: 8235
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400202C RID: 8236
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400202D RID: 8237
		private EventString <<EMPTY_NAME>>;

		// Token: 0x0400202E RID: 8238
		private string <<EMPTY_NAME>>;
	}
}
