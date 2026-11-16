using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	/// <summary>
	/// WeUI框架
	/// </summary>
	// Token: 0x02000239 RID: 569
	[oO0oooo("A0146")]
	public class wui
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x000BEB80 File Offset: 0x000BCD80
		public wui()
		{
			this.O.oO_oO. = "utf-8";
			this.o0_._00. = new Dictionary<string, wElement>();
			this.O.oO_oO. = new Dictionary<string, wElement>();
			this.O.0_00o0_o. = "/weui";
			this.o0_._00. = new List<string>();
			this.O.oO_oO. = new List<string>();
			this.O.0_00o0_o. = new List<string>();
			this.o0.0O_o0_oOoo. = new List<string>();
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x000BEBEB File Offset: 0x000BCDEB
		[EditorBrowsable(EditorBrowsableState.Never)]
		public List<string> Scripts
		{
			get
			{
				return this.O.0_00o0_o.;
			}
		}

		/// <summary>
		/// 字符型，用于设置网页标题
		/// </summary>
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x000BEBF3 File Offset: 0x000BCDF3
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x000BEBFB File Offset: 0x000BCDFB
		public string Title
		{
			get
			{
				return this.o0_._00.;
			}
			set
			{
				this.o0_._00. = value;
			}
		}

		/// <summary>
		/// 字符型，用于指定WeUI库文件的路径，默认为"/weui"。
		/// </summary>
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000BEC04 File Offset: 0x000BCE04
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x000BEC0C File Offset: 0x000BCE0C
		public string WeUIPath
		{
			get
			{
				return this.O.0_00o0_o.;
			}
			set
			{
				this.O.0_00o0_o. = value;
			}
		}

		/// <summary>
		/// 指定网页编码，默认为"utf-8"
		/// </summary>
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x000BEC15 File Offset: 0x000BCE15
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x000BEC1D File Offset: 0x000BCE1D
		public string Charset
		{
			get
			{
				return this.O.oO_oO.;
			}
			set
			{
				this.O.oO_oO. = value;
			}
		}

		/// <summary>
		/// 增加表单
		/// </summary>
		/// <param name="pid">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="id">表单ID</param>
		/// <param name="Action">接收表单数据的网页</param>
		// Token: 0x06001B12 RID: 6930 RVA: 0x000BEC28 File Offset: 0x000BCE28
		[oO0oooo("A007")]
		public wForm AddForm(string pid, string id, string Action)
		{
			if (Operators.CompareString(pid, "", true) > 0)
			{
				pid = pid.ToLower().Trim();
			}
			id = id.ToLower().Trim();
			wForm wForm = new wForm(pid, id, Action);
			this.o0_._00..Add(id, wForm);
			return wForm;
		}

		/// <summary>
		/// 增加表单
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="id">表单ID</param>
		/// <param name="Action">接收表单数据的网页</param>
		/// <param name="Method">可选参数，指定表单提交方式，默认为"post"</param>
		// Token: 0x06001B13 RID: 6931 RVA: 0x000BEC78 File Offset: 0x000BCE78
		[oO0oooo("A007")]
		public wForm AddForm(string ParentID, string id, string Action, string Method)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			id = id.ToLower().Trim();
			wForm wForm = new wForm(ParentID, id, Action, Method);
			this.o0_._00..Add(id, wForm);
			return wForm;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x000BECC8 File Offset: 0x000BCEC8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public wGroupTitle AddSubTitle(string pid, string ID, string Text)
		{
			if (Operators.CompareString(pid, "", true) > 0)
			{
				pid = pid.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wGroupTitle wGroupTitle = new wGroupTitle(pid, ID, Text);
			this.o0_._00..Add(ID, wGroupTitle);
			return wGroupTitle;
		}

		/// <summary>
		/// 增加单选列表组
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">分组ID</param>
		/// <param name="Text">可选参数，用于指定分组标题</param>
		// Token: 0x06001B15 RID: 6933 RVA: 0x000BED18 File Offset: 0x000BCF18
		[oO0oooo("A0052")]
		public wRadioGroup AddRadioGroup(string ParentID, string ID, string Text = "")
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wRadioGroup wRadioGroup = new wRadioGroup(ParentID, ID, Text);
			this.o0_._00..Add(ID, wRadioGroup);
			return wRadioGroup;
		}

		/// <summary>
		/// 增加复选列表项组
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">分组ID</param>
		/// <param name="Text">可选参数，用于指定分组标题</param>
		// Token: 0x06001B16 RID: 6934 RVA: 0x000BED68 File Offset: 0x000BCF68
		[oO0oooo("A0053")]
		public wCheckGroup AddCheckGroup(string ParentID, string ID, string Text = "")
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wCheckGroup wCheckGroup = new wCheckGroup(ParentID, ID, Text);
			this.o0_._00..Add(ID, wCheckGroup);
			return wCheckGroup;
		}

		/// <summary>
		/// 增加输入框分组
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">分组ID</param>
		/// <param name="Text">可选参数，用于指定分组标题</param>
		// Token: 0x06001B17 RID: 6935 RVA: 0x000BEDB8 File Offset: 0x000BCFB8
		[oO0oooo("A0045")]
		public wInputGroup AddInputGroup(string ParentID, string ID, string Text = "")
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wInputGroup wInputGroup = new wInputGroup(ParentID, ID, Text);
			this.o0_._00..Add(ID, wInputGroup);
			return wInputGroup;
		}

		/// <summary>
		/// 增加按钮分组
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">分组ID</param>
		/// <param name="Vertical">可选参数，逻辑型，按钮是否垂直排列，默认为True</param>
		// Token: 0x06001B18 RID: 6936 RVA: 0x000BEE08 File Offset: 0x000BD008
		[oO0oooo("A0008")]
		public wButtonGroup AddButtonGroup(string ParentID, string ID, bool Vertical = false)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wButtonGroup wButtonGroup = new wButtonGroup(ParentID, ID, Vertical);
			this.o0_._00..Add(ID, wButtonGroup);
			return wButtonGroup;
		}

		/// <summary>
		/// 增加网格
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">网格ID</param>
		// Token: 0x06001B19 RID: 6937 RVA: 0x000BEE58 File Offset: 0x000BD058
		[oO0oooo("A0077")]
		public wGrid AddGrid(string ParentID, string ID)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wGrid wGrid = new wGrid(ParentID, ID);
			this.o0_._00..Add(ID, wGrid);
			return wGrid;
		}

		/// <summary>
		/// 增加PageTitle
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">PageTitle的ID</param>
		/// <param name="Title">标题</param>
		/// <param name="SubTitle">副标题</param>
		// Token: 0x06001B1A RID: 6938 RVA: 0x000BEEA4 File Offset: 0x000BD0A4
		[oO0oooo("A0075")]
		public wPageTitle AddPageTitle(string ParentID, string ID, string Title, string SubTitle = "")
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wPageTitle wPageTitle = new wPageTitle(ParentID, ID, Title, SubTitle);
			this.o0_._00..Add(ID, wPageTitle);
			return wPageTitle;
		}

		/// <summary>
		/// 增加PageFooter
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">PageFooter的ID</param>
		/// <param name="FootText">PageFooter的文本内容</param>
		/// <param name="Position">可选参数，设置为1，PageFooter会固定在页面底部，设置为0不会固定，默认为1</param>
		// Token: 0x06001B1B RID: 6939 RVA: 0x000BEEF4 File Offset: 0x000BD0F4
		[oO0oooo("A0086")]
		public wPageFooter AddPageFooter(string ParentID, string ID, string FootText, int Position = 1)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wPageFooter wPageFooter = new wPageFooter(ParentID, ID, FootText, Position);
			this.o0_._00..Add(ID, wPageFooter);
			return wPageFooter;
		}

		/// <summary>
		/// 增加列表项组
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">分组ID</param>
		/// <param name="Text">可选参数，用于指定分组标题</param>
		// Token: 0x06001B1C RID: 6940 RVA: 0x000BEF44 File Offset: 0x000BD144
		[oO0oooo("A0076")]
		public wListGroup AddListGroup(string ParentID, string ID, string Text)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wListGroup wListGroup = new wListGroup(ParentID, ID, Text);
			this.o0_._00..Add(ID, wListGroup);
			return wListGroup;
		}

		/// <summary>
		/// 增加Panel分组
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">分组ID</param>
		/// <param name="Text">可选参数，用于指定分组标题</param>
		// Token: 0x06001B1D RID: 6941 RVA: 0x000BEF94 File Offset: 0x000BD194
		[oO0oooo("A0078")]
		public wPanelGroup AddPanelGroup(string ParentID, string ID, string Text)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wPanelGroup wPanelGroup = new wPanelGroup(ParentID, ID, Text);
			this.o0_._00..Add(ID, wPanelGroup);
			return wPanelGroup;
		}

		/// <summary>
		/// 增加Article，用于显示大段的文字，支持分段、多层标题、引用和内嵌图片
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">组件ID</param>
		// Token: 0x06001B1E RID: 6942 RVA: 0x000BEFE4 File Offset: 0x000BD1E4
		[oO0oooo("A0079")]
		public wArticle AddArticle(string ParentID, string ID)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wArticle wArticle = new wArticle(ParentID, ID, this.o0_._00.);
			this.o0_._00..Add(ID, wArticle);
			return wArticle;
		}

		/// <summary>
		/// 增加增加MSgPage，用于告知用户操作结果以及一些必要的细节
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">MsgPage的ID</param>
		/// <param name="Title">内容标题</param>
		/// <param name="Description">内容详情</param>
		// Token: 0x06001B1F RID: 6943 RVA: 0x000BF038 File Offset: 0x000BD238
		[oO0oooo("A0058")]
		public wMsgPage AddMsgPage(string ParentID, string ID, string Title, string Description)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wMsgPage wMsgPage = new wMsgPage(ParentID, ID, Title, Description);
			this.o0_._00..Add(ID, wMsgPage);
			return wMsgPage;
		}

		/// <summary>
		/// 添加AddToast，临时显示某些信息，并且会在数秒后自动消失
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">Toast的ID</param>
		/// <param name="Text">Toast文本内容</param>
		/// <param name="Type">Toast类型，默认为0，如果设置为1，图标将显示为一个表示正在运行的动画</param>
		// Token: 0x06001B20 RID: 6944 RVA: 0x000BF088 File Offset: 0x000BD288
		[oO0oooo("A0082")]
		public wToast AddToast(string ParentID, string ID, string Text, int Type)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wToast wToast = new wToast(ParentID, ID, Text, Type);
			this.o0_._00..Add(ID, wToast);
			return wToast;
		}

		/// <summary>
		/// 增加Dialog
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">对话框ID</param>
		/// <param name="title">对话框标题</param>
		/// <param name="content">对话框内容</param>
		// Token: 0x06001B21 RID: 6945 RVA: 0x000BF0D8 File Offset: 0x000BD2D8
		[oO0oooo("A0080")]
		public wDialog AddDialog(string ParentID, string ID, string title, string content)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wDialog wDialog = new wDialog(ParentID, ID, title, content);
			this.o0_._00..Add(ID, wDialog);
			return wDialog;
		}

		/// <summary>
		/// 增加菜单
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">菜单ID</param>
		// Token: 0x06001B22 RID: 6946 RVA: 0x000BF128 File Offset: 0x000BD328
		[oO0oooo("A0084")]
		public wActionSheet AddActionSheet(string ParentID, string ID)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wActionSheet wActionSheet = new wActionSheet(ParentID, ID);
			this.o0_._00..Add(ID, wActionSheet);
			return wActionSheet;
		}

		/// <summary>
		/// 增加页面
		/// </summary>
		/// <param name="ParentID">父容器ID，如果是顶层对象，设为""即可</param>
		/// <param name="ID">页面ID</param>
		/// <param name="Visible">可选参数，逻辑型，用于设置页面默认是否显示。默认为True</param>
		// Token: 0x06001B23 RID: 6947 RVA: 0x000BF174 File Offset: 0x000BD374
		[oO0oooo("A0109")]
		public wPage AddPage(string ParentID, string ID, bool Visible = true)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wPage wPage = new wPage(ParentID, ID, Visible);
			this.o0_._00..Add(ID, wPage);
			return wPage;
		}

		/// <summary>
		/// 增加TabBar
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">TabBar的ID</param>
		/// <param name="Position">按钮位置，0显示在底端，1显示在顶端</param>
		// Token: 0x06001B24 RID: 6948 RVA: 0x000BF1C4 File Offset: 0x000BD3C4
		[oO0oooo("A0081")]
		public wTabbar AddTabBar(string ParentID, string ID, int Position)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wTabbar wTabbar = new wTabbar(ParentID, ID, Position);
			this.o0_._00..Add(ID, wTabbar);
			return wTabbar;
		}

		/// <summary>
		/// 增加增加Toptoips
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">TopTips的ID</param>
		/// <param name="Text">TopTips文本内容</param>
		// Token: 0x06001B25 RID: 6949 RVA: 0x000BF214 File Offset: 0x000BD414
		[oO0oooo("A0083")]
		public wToptips AddToptips(string ParentID, string ID, string Text)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wToptips wToptips = new wToptips(ParentID, ID, Text);
			this.o0_._00..Add(ID, wToptips);
			return wToptips;
		}

		/// <summary>
		/// 增加表格
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">表格ID</param>
		// Token: 0x06001B26 RID: 6950 RVA: 0x000BF264 File Offset: 0x000BD464
		[oO0oooo("A0063")]
		public wTable AddTable(string ParentID, string ID)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wTable wTable = new wTable(ParentID, ID);
			this.o0_._00..Add(ID, wTable);
			return wTable;
		}

		/// <summary>
		/// 增加Preview
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">Preview的ID</param>
		/// <param name="HeadText">标题文本</param>
		/// <param name="HeadValue">标题的值</param>
		// Token: 0x06001B27 RID: 6951 RVA: 0x000BF2B0 File Offset: 0x000BD4B0
		[oO0oooo("A0085")]
		public wPreview AddPreview(string ParentID, string ID, string HeadText, string HeadValue)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wPreview wPreview = new wPreview(ParentID, ID, HeadText, HeadValue);
			this.o0_._00..Add(ID, wPreview);
			return wPreview;
		}

		/// <summary>
		/// 增加Gallery,用于实现图片的展示或幻灯片播放
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">Gallery的ID。</param>
		/// <param name="Visible">逻辑型，可选参数，Gallery初始是否可见，默认为True</param>
		/// <param name="AutoHide">可选参数，默认为False，当需要和其他组件配合使用时，可将此属性设置为True，这样点击图片中央位置，会自动隐藏Gallery</param>
		// Token: 0x06001B28 RID: 6952 RVA: 0x000BF300 File Offset: 0x000BD500
		[oO0oooo("A0087")]
		public wGallery AddGallery(string ParentID, string ID, bool Visible = true, bool AutoHide = false)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wGallery wGallery = new wGallery(ParentID, ID, Visible, AutoHide);
			this.o0_._00..Add(ID, wGallery);
			return wGallery;
		}

		/// <summary>
		/// 增加一个Progress(进度条)
		/// </summary>
		/// <param name="ParentID">父容器的ID,如果是顶层对象，设置为""即可</param>
		/// <param name="ID">Progress的ID</param>
		/// <param name="Visible">逻辑型，可选参数，Progress初始是否可见，默认为True</param>
		/// <param name="Value">整数型，可选参数，设置Progress初始值，范围为0-100</param>
		// Token: 0x06001B29 RID: 6953 RVA: 0x000BF350 File Offset: 0x000BD550
		[oO0oooo("A0098")]
		public wProgress AddProgress(string ParentID, string ID, bool Visible = true, int Value = 0)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			ID = ID.ToLower().Trim();
			wProgress wProgress = new wProgress(ParentID, ID, Visible, Value);
			this.o0_._00..Add(ID, wProgress);
			return wProgress;
		}

		/// <summary>
		/// 添加Cookie
		/// </summary>
		/// <param name="name">Cookie名称</param>
		/// <param name="value">Cookie值</param>
		/// <param name="expires">可选参数，整数型，用于设置Cookie的有效时间，单位是分钟，如果不设置，关闭浏览器后Cookie将失效</param>
		// Token: 0x06001B2A RID: 6954 RVA: 0x000BF3A0 File Offset: 0x000BD5A0
		[oO0oooo("A0042")]
		public void AppendCookie(string name, string value, int expires = -1)
		{
			if (Operators.CompareString(value, "", true) == 0)
			{
				this.DeleteCookie(name);
				return;
			}
			value = OO_00oOO.o_.0_OoOo0_0.(value);
			if (value.IndexOf("'") >= 0)
			{
				value = value.Replace("'", "%27");
			}
			name = OO_00oOO.o_.0_OoOo0_0.(name);
			string item;
			if (expires == -1)
			{
				item = string.Concat(new string[]
				{
					"document.cookie='",
					name,
					"=",
					value,
					";path =/';"
				});
			}
			else
			{
				long value2 = (long)expires * 60L * 1000L;
				item = string.Concat(new string[]
				{
					"document.cookie='",
					name,
					"=",
					value,
					";path=/;expires=' + new Date(Date.now() + ",
					Conversions.ToString(value2),
					").toGMTString();"
				});
			}
			this.o0.0O_o0_oOoo..Add(item);
		}

		/// <summary>
		/// 删除cookie
		/// </summary>
		/// <param name="Name">要删除的cookie的名称</param>
		// Token: 0x06001B2B RID: 6955 RVA: 0x000BF482 File Offset: 0x000BD682
		[oO0oooo("A0042")]
		public void DeleteCookie(string Name)
		{
			Name = OO_00oOO.o_.0_OoOo0_0.(Name);
			this.o0.0O_o0_oOoo..Add("document.cookie='" + Name + "= ;path=/;expires=' + new Date().toGMTString();");
		}

		/// <summary>
		/// 清除所有cookie
		/// </summary>
		// Token: 0x06001B2C RID: 6956 RVA: 0x000BF4A7 File Offset: 0x000BD6A7
		[oO0oooo("A0042")]
		public void ClearCookie()
		{
			this.o0.0O_o0_oOoo..Add("clearCookie()");
		}

		/// <summary>
		/// 添加原生的HTML代码
		/// </summary>
		/// <param name="HTML">字符型，HTML代码</param>
		/// <param name="Head">字符型，设置为True，代码添加在网页的Head区，否则添加在网页的Body区，默认为False</param>
		// Token: 0x06001B2D RID: 6957 RVA: 0x000BF4B9 File Offset: 0x000BD6B9
		[oO0oooo("A0061")]
		public void AppendHTML(string HTML, bool Head = false)
		{
			if (Head)
			{
				this.o0_._00..Add(HTML);
				return;
			}
			this.O.oO_oO..Add(HTML);
		}

		/// <summary>
		/// 在当前位置插入HTML代码
		/// </summary>
		/// <param name="HTML"> 要插入的HTML代码</param>
		// Token: 0x06001B2E RID: 6958 RVA: 0x000BF4D8 File Offset: 0x000BD6D8
		[oO0oooo("A0097")]
		public void InsertHTML(string HTML)
		{
			string text = OoOo0O.OO_o.0o_O.(6);
			while (this.o0_._00..ContainsKey(text))
			{
				text = OoOo0O.OO_o.0o_O.(6);
			}
			wRawHtml value = new wRawHtml("", text, HTML);
			this.o0_._00..Add(text, value);
		}

		/// <summary>
		/// 在当前位置插入HTML代码
		/// </summary>
		/// <param name="ParentID">父容器ID，如果是顶层对象，可以不设置</param>
		/// <param name="HTML"> 要插入的HTML代码</param>
		// Token: 0x06001B2F RID: 6959 RVA: 0x000BF520 File Offset: 0x000BD720
		[oO0oooo("A0097")]
		public void InsertHTML(string ParentID, string HTML)
		{
			if (Operators.CompareString(ParentID, "", true) > 0)
			{
				ParentID = ParentID.ToLower().Trim();
			}
			string text = OoOo0O.OO_o.0o_O.(6);
			while (this.o0_._00..ContainsKey(text))
			{
				text = OoOo0O.OO_o.0o_O.(6);
			}
			wRawHtml value = new wRawHtml(ParentID, text, HTML);
			this.o0_._00..Add(text, value);
		}

		/// <summary>
		/// 生成网页
		/// </summary>
		// Token: 0x06001B30 RID: 6960 RVA: 0x000BF580 File Offset: 0x000BD780
		public string Build()
		{
			this.O.oO_oO..Clear();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<!DOCTYPE html>");
			stringBuilder.AppendLine("<html lang='zh-cmn-Hans'>");
			stringBuilder.AppendLine("<head>");
			stringBuilder.AppendLine("<meta charset='" + this.Charset + "'>");
			stringBuilder.AppendLine("<meta name='viewport' content='width=device-width,initial-scale=1,user-scalable=0'>");
			stringBuilder.AppendLine("<link rel='stylesheet' href='" + this.WeUIPath + "/weui.min.css'/>");
			stringBuilder.AppendLine("<link rel='stylesheet' href='" + this.WeUIPath + "/weui.me.css'/>");
			stringBuilder.AppendLine("<link rel='icon' href='data: ;base64,='>");
			stringBuilder.AppendLine("<title>" + this.o0_._00. + "</title>");
			stringBuilder.AppendLine("<script src='" + this.WeUIPath + "/weui.me.js'></script>");
			if (this.o0.0O_o0_oOoo..Count > 0)
			{
				stringBuilder.AppendLine("<script>");
				try
				{
					foreach (string value in this.o0.0O_o0_oOoo.)
					{
						stringBuilder.AppendLine(value);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				stringBuilder.AppendLine("</script>");
			}
			try
			{
				foreach (string value2 in this.o0_._00.)
				{
					stringBuilder.AppendLine(value2);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			stringBuilder.AppendLine("</head>");
			stringBuilder.AppendLine("<body ontouchstart='' onload='onload()'>");
			try
			{
				foreach (string key in this.o0_._00..Keys)
				{
					if (Operators.CompareString(this.o0_._00.[key].PID, "", true) == 0)
					{
						((o_oOOOoo_O_O)this.o0_._00.[key]).OOO.__O_oO_.(stringBuilder, this);
					}
				}
			}
			finally
			{
				Dictionary<string, wElement>.KeyCollection.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
			try
			{
				foreach (string key2 in this.O.oO_oO..Keys)
				{
					if (Operators.CompareString(this.O.oO_oO.[key2].PID, "", true) == 0)
					{
						((o_oOOOoo_O_O)this.O.oO_oO.[key2]).OOO.__O_oO_.(stringBuilder, this);
					}
				}
			}
			finally
			{
				Dictionary<string, wElement>.KeyCollection.Enumerator enumerator4;
				((IDisposable)enumerator4).Dispose();
			}
			try
			{
				foreach (string value3 in this.O.oO_oO.)
				{
					stringBuilder.AppendLine(value3);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator5;
				((IDisposable)enumerator5).Dispose();
			}
			if (this.O.0_00o0_o..Count > 0)
			{
				stringBuilder.AppendLine("<script>");
				try
				{
					foreach (string value4 in this.Scripts)
					{
						stringBuilder.AppendLine(value4);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				stringBuilder.AppendLine("</script>");
			}
			stringBuilder.AppendLine("</body>");
			stringBuilder.AppendLine("</html>");
			return stringBuilder.ToString();
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000BF8F8 File Offset: 0x000BDAF8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BuildHtml(o_oOOOoo_O_O ele)
		{
			StringBuilder stringBuilder = new StringBuilder();
			ele.OOO.__O_oO_.(stringBuilder, this);
			return stringBuilder.ToString();
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000BF91C File Offset: 0x000BDB1C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BuildHtml(string ID)
		{
			try
			{
				foreach (string text in this.o0_._00..Keys)
				{
					if (Operators.CompareString(text, ID, true) == 0 && this.o0_._00.[text] is o_oOOOoo_O_O)
					{
						return this.BuildHtml((o_oOOOoo_O_O)this.o0_._00.[text]);
					}
				}
			}
			finally
			{
				Dictionary<string, wElement>.KeyCollection.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return "";
		}

		/// <summary>
		/// 生成HTML代码，并保存为一个文件
		/// </summary>
		/// <param name="FileName">文件名，含路径</param>
		// Token: 0x06001B33 RID: 6963 RVA: 0x000BF9AC File Offset: 0x000BDBAC
		public void Save(string FileName)
		{
			string text = this.Build();
			OO_00oOO.FileSys.WriteAllText(FileName, text, false, Encoding.GetEncoding(this.Charset));
		}

		/// <summary>
		/// 将Image转换为base64字符串
		/// </summary>
		/// <param name="img">要转换的image</param>
		// Token: 0x06001B34 RID: 6964 RVA: 0x000BF9D8 File Offset: 0x000BDBD8
		[oO0oooo("A0137")]
		public static string ImageToBase64(Image img)
		{
			MemoryStream memoryStream = new MemoryStream();
			img.Save(memoryStream, ImageFormat.Png);
			return "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x04000B6B RID: 2923
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B6C RID: 2924
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B6D RID: 2925
		internal Dictionary<string, wElement> <<EMPTY_NAME>>;

		// Token: 0x04000B6E RID: 2926
		internal Dictionary<string, wElement> <<EMPTY_NAME>>;

		// Token: 0x04000B6F RID: 2927
		private string <<EMPTY_NAME>>;

		// Token: 0x04000B70 RID: 2928
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000B71 RID: 2929
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000B72 RID: 2930
		private List<string> <<EMPTY_NAME>>;

		// Token: 0x04000B73 RID: 2931
		private List<string> <<EMPTY_NAME>>;
	}
}
