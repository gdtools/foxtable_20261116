using System;
using System.ComponentModel;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x0200047A RID: 1146
	internal class RibbonBase
	{
		// Token: 0x06004E44 RID: 20036 RVA: 0x0023750D File Offset: 0x0023570D
		public RibbonBase(DataRow A_0)
		{
			this.o0o__0.OO0O. = A_0;
			if (!A_0.IsNull("Name"))
			{
				this.Name = Conversions.ToString(A_0["Name"]);
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06004E45 RID: 20037 RVA: 0x0023753F File Offset: 0x0023573F
		[Browsable(false)]
		internal DataRow DataRow
		{
			get
			{
				return this.o0o__0.OO0O.;
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06004E46 RID: 20038 RVA: 0x00237547 File Offset: 0x00235747
		[Browsable(false)]
		internal RibbonItemTypeEnum RibbonItemType
		{
			get
			{
				return (RibbonItemTypeEnum)Conversions.ToInteger(this.DataRow["Type"]);
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x0023755E File Offset: 0x0023575E
		// (set) Token: 0x06004E48 RID: 20040 RVA: 0x00237566 File Offset: 0x00235766
		[OooO0(true)]
		[DisplayName("名称")]
		[Category("属性")]
		[O_Oo00Oo000O0(1.0)]
		public string Name
		{
			get
			{
				return this.o0o__0.OO0O.;
			}
			set
			{
				this.o0o__0.OO0O. = value;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06004E49 RID: 20041 RVA: 0x0023756F File Offset: 0x0023576F
		[Category("属性")]
		[OooO0(true)]
		[DisplayName("类型")]
		[O_Oo00Oo000O0(1.0)]
		public string Type
		{
			get
			{
				return RibbonBase.o0o__0.OO0O.((RibbonItemTypeEnum)Conversions.ToInteger(this.o0o__0.OO0O.["Type"]));
			}
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x0023758C File Offset: 0x0023578C
		internal static string <<EMPTY_NAME>>(RibbonItemTypeEnum A_0)
		{
			string result;
			switch (A_0)
			{
			case RibbonItemTypeEnum.ApplicationMenu:
				result = "程序菜单";
				break;
			case RibbonItemTypeEnum.QAT:
				result = "快速访问栏";
				break;
			case RibbonItemTypeEnum.ConfigBar:
				result = "配置栏";
				break;
			case RibbonItemTypeEnum.PaperList:
				result = "纸张列表";
				break;
			case RibbonItemTypeEnum.Tab:
				result = "功能区";
				break;
			case RibbonItemTypeEnum.WindowList:
				result = "窗口列表";
				break;
			case RibbonItemTypeEnum.Group:
				result = "功能组";
				break;
			case RibbonItemTypeEnum.ToggleGroup:
				result = "状态分组栏";
				break;
			case RibbonItemTypeEnum.ToolBar:
				result = "工具栏";
				break;
			case RibbonItemTypeEnum.Button:
				result = "标准按钮";
				break;
			case RibbonItemTypeEnum.CheckBox:
				result = "检查框";
				break;
			case RibbonItemTypeEnum.ColorPicker:
				result = "颜色选取按钮";
				break;
			case RibbonItemTypeEnum.ComboBox:
				result = "组合框";
				break;
			case RibbonItemTypeEnum.TextBox:
				result = "文本框";
				break;
			case RibbonItemTypeEnum.FontComboBox:
				result = "字体选择框";
				break;
			case RibbonItemTypeEnum.Label:
				result = "标签";
				break;
			case RibbonItemTypeEnum.MenuButton:
				result = "菜单按钮";
				break;
			case RibbonItemTypeEnum.Separator:
				result = "分割条";
				break;
			case RibbonItemTypeEnum.SplitButton:
				result = "组合按钮";
				break;
			case RibbonItemTypeEnum.ToggleButton:
				result = "状态按钮";
				break;
			case RibbonItemTypeEnum.TableViewList:
				result = "视图列表";
				break;
			case RibbonItemTypeEnum.GroupTableList:
				result = "分组统计历史列表";
				break;
			case RibbonItemTypeEnum.CrossTableList:
				result = "交叉统计历史列表";
				break;
			case RibbonItemTypeEnum.SubtotalModeList:
				result = "汇总模式历史列表";
				break;
			case RibbonItemTypeEnum.ExcelReportList:
				result = "Excel报表列表";
				break;
			case RibbonItemTypeEnum.CodeReportList:
				result = "专业报表列表";
				break;
			case RibbonItemTypeEnum.DatePicker:
				result = "日期输入框";
				break;
			case RibbonItemTypeEnum.NumericBox:
				result = "数值输入框";
				break;
			case RibbonItemTypeEnum.ProgressBar:
				result = "进度条";
				break;
			case RibbonItemTypeEnum.WordReportList:
				result = "Word文章列表";
				break;
			case RibbonItemTypeEnum.Gallery:
				result = "Gallery";
				break;
			case RibbonItemTypeEnum.GalleryItem:
				result = "GalleryItem";
				break;
			case RibbonItemTypeEnum.TimePicker:
				result = "时间输入框";
				break;
			case RibbonItemTypeEnum.TrackBar:
				result = "滑动条";
				break;
			case RibbonItemTypeEnum.TopToolBar:
				result = "上工具栏";
				break;
			case RibbonItemTypeEnum.BottomToolBar:
				result = "下工具栏";
				break;
			case RibbonItemTypeEnum.TopTab:
				result = "功能区组";
				break;
			default:
				switch (A_0)
				{
				case RibbonItemTypeEnum.ContextMenu:
					result = "快捷菜单";
					break;
				case RibbonItemTypeEnum.ContextCommand:
					result = "标准项目";
					break;
				case RibbonItemTypeEnum.ContextCommandMenu:
					result = "子菜单";
					break;
				default:
					result = "";
					break;
				}
				break;
			}
			return result;
		}

		// Token: 0x04001FF9 RID: 8185
		private DataRow <<EMPTY_NAME>>;

		// Token: 0x04001FFA RID: 8186
		private string <<EMPTY_NAME>>;
	}
}
