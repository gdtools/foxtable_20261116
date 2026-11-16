using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Neodynamic.WinControls.BarcodeProfessional;

namespace Foxtable.WinForm
{
	// Token: 0x02000514 RID: 1300
	[ComVisible(true)]
	public class BarCode : Control, OoO_
	{
		// Token: 0x06005547 RID: 21831 RVA: 0x0025953B File Offset: 0x0025773B
		internal BarCode(OOo00o_0o0_ A_0) : base(A_0, ControlTypeEnum.BarCode)
		{
			this.oo._00. = A_0;
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06005548 RID: 21832 RVA: 0x0025954D File Offset: 0x0025774D
		public Image Image
		{
			get
			{
				return Image.FromStream(new MemoryStream(this.oo._00..GetBarcodeImage(ImageFormat.Emf)));
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x00259569 File Offset: 0x00257769
		// (set) Token: 0x0600554A RID: 21834 RVA: 0x00259576 File Offset: 0x00257776
		public double QuietZoneWidth
		{
			get
			{
				return this.oo._00..QuietZoneWidth;
			}
			set
			{
				this.oo._00..QuietZoneWidth = value;
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x0600554B RID: 21835 RVA: 0x00259584 File Offset: 0x00257784
		// (set) Token: 0x0600554C RID: 21836 RVA: 0x00259678 File Offset: 0x00257878
		public override string BindingField
		{
			get
			{
				if (this.oo._00..DataBindings.Count > 0)
				{
					try
					{
						foreach (object obj in this.oo._00..DataBindings)
						{
							Binding binding = (Binding)obj;
							if (Operators.CompareString(binding.PropertyName, "Code", true) == 0)
							{
								if (binding.DataSource is O_0)
								{
									return ((O_0)binding.DataSource).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField;
								}
								if (binding.DataSource == OO_00oOO.Vars.VariableTable)
								{
									return "全局变量." + binding.BindingMemberInfo.BindingField;
								}
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
				return null;
			}
			set
			{
				try
				{
					foreach (object obj in this.oo._00..DataBindings)
					{
						Binding binding = (Binding)obj;
						if (Operators.CompareString(binding.PropertyName, "Code", true) == 0)
						{
							this.oo._00..DataBindings.Remove(binding);
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
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (base.Form.Pane.FindForm() == null)
					{
						base.Form.o_0.o0..Add(this, value);
						return;
					}
					if (value.StartsWith("全局变量."))
					{
						string text = value.Substring(value.IndexOf('.') + 1);
						if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
						{
							this.oo._00..DataBindings.Add("Code", OO_00oOO.Vars.VariableTable, text).DataSourceUpdateMode = DataSourceUpdateMode.Never;
							return;
						}
					}
					else
					{
						Binding binding2 = Oo00.OO.0O0o.("Code", value);
						binding2.DataSourceUpdateMode = DataSourceUpdateMode.Never;
						if (binding2 != null)
						{
							this.oo._00..DataBindings.Add(binding2);
						}
					}
				}
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x002597B4 File Offset: 0x002579B4
		// (set) Token: 0x0600554E RID: 21838 RVA: 0x002598A8 File Offset: 0x00257AA8
		public string BindingText
		{
			get
			{
				if (this.oo._00..DataBindings.Count > 0)
				{
					try
					{
						foreach (object obj in this.oo._00..DataBindings)
						{
							Binding binding = (Binding)obj;
							if (Operators.CompareString(binding.PropertyName, "Text", true) == 0)
							{
								if (binding.DataSource is O_0)
								{
									return ((O_0)binding.DataSource).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField;
								}
								if (binding.DataSource == OO_00oOO.Vars.VariableTable)
								{
									return "全局变量." + binding.BindingMemberInfo.BindingField;
								}
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
				return null;
			}
			set
			{
				try
				{
					foreach (object obj in this.oo._00..DataBindings)
					{
						Binding binding = (Binding)obj;
						if (Operators.CompareString(binding.PropertyName, "Text", true) == 0)
						{
							this.oo._00..DataBindings.Remove(binding);
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
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (value.StartsWith("全局变量."))
					{
						string text = value.Substring(value.IndexOf('.') + 1);
						if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
						{
							this.oo._00..DataBindings.Add("Text", OO_00oOO.Vars.VariableTable, text);
							return;
						}
					}
					else
					{
						Binding binding2 = Oo00.OO.0O0o.("Text", value);
						if (binding2 != null)
						{
							this.oo._00..DataBindings.Add(binding2);
						}
					}
				}
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600554F RID: 21839 RVA: 0x002599AC File Offset: 0x00257BAC
		// (set) Token: 0x06005550 RID: 21840 RVA: 0x00259AA0 File Offset: 0x00257CA0
		public string BindingHumanReadableText
		{
			get
			{
				if (this.oo._00..DataBindings.Count > 0)
				{
					try
					{
						foreach (object obj in this.oo._00..DataBindings)
						{
							Binding binding = (Binding)obj;
							if (Operators.CompareString(binding.PropertyName, "HumanReadableText", true) == 0)
							{
								if (binding.DataSource is O_0)
								{
									return ((O_0)binding.DataSource).Oo._Oo0OO.() + "." + binding.BindingMemberInfo.BindingField;
								}
								if (binding.DataSource == OO_00oOO.Vars.VariableTable)
								{
									return "全局变量." + binding.BindingMemberInfo.BindingField;
								}
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
				return null;
			}
			set
			{
				try
				{
					foreach (object obj in this.oo._00..DataBindings)
					{
						Binding binding = (Binding)obj;
						if (Operators.CompareString(binding.PropertyName, "HumanReadableText", true) == 0)
						{
							this.oo._00..DataBindings.Remove(binding);
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
				if (Operators.CompareString(value, "", true) > 0)
				{
					if (value.StartsWith("全局变量."))
					{
						string text = value.Substring(value.IndexOf('.') + 1);
						if (OO_00oOO.Vars.VariableTable.Columns.Contains(text))
						{
							this.oo._00..DataBindings.Add("HumanReadableText", OO_00oOO.Vars.VariableTable, text);
							return;
						}
					}
					else
					{
						Binding binding2 = Oo00.OO.0O0o.("HumanReadableText", value);
						if (binding2 != null)
						{
							this.oo._00..DataBindings.Add(binding2);
						}
					}
				}
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x00259BA4 File Offset: 0x00257DA4
		// (set) Token: 0x06005552 RID: 21842 RVA: 0x00259BB1 File Offset: 0x00257DB1
		public virtual string Code
		{
			get
			{
				return this.oo._00..Code;
			}
			set
			{
				this.oo._00..Code = value;
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06005553 RID: 21843 RVA: 0x00259BBF File Offset: 0x00257DBF
		// (set) Token: 0x06005554 RID: 21844 RVA: 0x00259BCC File Offset: 0x00257DCC
		public Symbology Symbology
		{
			get
			{
				return this.oo._00..Symbology;
			}
			set
			{
				this.oo._00..Symbology = value;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06005555 RID: 21845 RVA: 0x00259BDA File Offset: 0x00257DDA
		// (set) Token: 0x06005556 RID: 21846 RVA: 0x00259BE7 File Offset: 0x00257DE7
		public double BarWidth
		{
			get
			{
				return this.oo._00..BarWidth;
			}
			set
			{
				this.oo._00..BarWidth = value;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06005557 RID: 21847 RVA: 0x00259BF5 File Offset: 0x00257DF5
		// (set) Token: 0x06005558 RID: 21848 RVA: 0x00259C02 File Offset: 0x00257E02
		public double BarHeight
		{
			get
			{
				return this.oo._00..BarHeight;
			}
			set
			{
				this.oo._00..BarHeight = value;
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06005559 RID: 21849 RVA: 0x00259C10 File Offset: 0x00257E10
		// (set) Token: 0x0600555A RID: 21850 RVA: 0x00259C1D File Offset: 0x00257E1D
		public double BarRatio
		{
			get
			{
				return this.oo._00..BarRatio;
			}
			set
			{
				this.oo._00..BarRatio = value;
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x0600555B RID: 21851 RVA: 0x00259C2B File Offset: 0x00257E2B
		// (set) Token: 0x0600555C RID: 21852 RVA: 0x00259C38 File Offset: 0x00257E38
		public Rotate Rotate
		{
			get
			{
				return this.oo._00..Rotate;
			}
			set
			{
				this.oo._00..Rotate = value;
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x00259C46 File Offset: 0x00257E46
		// (set) Token: 0x0600555E RID: 21854 RVA: 0x00259C53 File Offset: 0x00257E53
		public bool AddCheckSum
		{
			get
			{
				return this.oo._00..AddChecksum;
			}
			set
			{
				this.oo._00..AddChecksum = value;
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x00259C61 File Offset: 0x00257E61
		// (set) Token: 0x06005560 RID: 21856 RVA: 0x00259C6E File Offset: 0x00257E6E
		public BearerBarStyle BearBarStyle
		{
			get
			{
				return this.oo._00..BearerBarStyle;
			}
			set
			{
				this.oo._00..BearerBarStyle = value;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06005561 RID: 21857 RVA: 0x00259C7C File Offset: 0x00257E7C
		// (set) Token: 0x06005562 RID: 21858 RVA: 0x00259C89 File Offset: 0x00257E89
		public double BearerBarWidth
		{
			get
			{
				return this.oo._00..BearerBarWidth;
			}
			set
			{
				this.oo._00..BearerBarWidth = value;
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06005563 RID: 21859 RVA: 0x00259C97 File Offset: 0x00257E97
		// (set) Token: 0x06005564 RID: 21860 RVA: 0x00259CA4 File Offset: 0x00257EA4
		public bool DisplayCode
		{
			get
			{
				return this.oo._00..DisplayCode;
			}
			set
			{
				this.oo._00..DisplayCode = value;
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x00259CB2 File Offset: 0x00257EB2
		// (set) Token: 0x06005566 RID: 21862 RVA: 0x00259CBF File Offset: 0x00257EBF
		public bool DisplayChecksum
		{
			get
			{
				return this.oo._00..DisplayChecksum;
			}
			set
			{
				this.oo._00..DisplayChecksum = value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x00259CCD File Offset: 0x00257ECD
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x00259CDA File Offset: 0x00257EDA
		public virtual string HumanReadableText
		{
			get
			{
				return this.oo._00..HumanReadableText;
			}
			set
			{
				this.oo._00..HumanReadableText = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x00259CE8 File Offset: 0x00257EE8
		// (set) Token: 0x0600556A RID: 21866 RVA: 0x00259CF5 File Offset: 0x00257EF5
		public bool DisplayStartStopChar
		{
			get
			{
				return this.oo._00..DisplayStartStopChar;
			}
			set
			{
				this.oo._00..DisplayStartStopChar = value;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x00259D03 File Offset: 0x00257F03
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x00259D10 File Offset: 0x00257F10
		public Alignment CodeAlignment
		{
			get
			{
				return this.oo._00..CodeAlignment;
			}
			set
			{
				this.oo._00..CodeAlignment = value;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x0600556D RID: 21869 RVA: 0x00259D1E File Offset: 0x00257F1E
		// (set) Token: 0x0600556E RID: 21870 RVA: 0x00259D2B File Offset: 0x00257F2B
		public virtual string Text
		{
			get
			{
				return this.oo._00..Text;
			}
			set
			{
				this.oo._00..Text = value;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x0600556F RID: 21871 RVA: 0x00259D39 File Offset: 0x00257F39
		// (set) Token: 0x06005570 RID: 21872 RVA: 0x00259D46 File Offset: 0x00257F46
		public Alignment TextAlignment
		{
			get
			{
				return this.oo._00..TextAlignment;
			}
			set
			{
				this.oo._00..TextAlignment = value;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x00259D54 File Offset: 0x00257F54
		// (set) Token: 0x06005572 RID: 21874 RVA: 0x00259D61 File Offset: 0x00257F61
		public double TopMargin
		{
			get
			{
				return this.oo._00..TopMargin;
			}
			set
			{
				this.oo._00..TopMargin = value;
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06005573 RID: 21875 RVA: 0x00259D6F File Offset: 0x00257F6F
		// (set) Token: 0x06005574 RID: 21876 RVA: 0x00259D7C File Offset: 0x00257F7C
		public double BottomMargin
		{
			get
			{
				return this.oo._00..BottomMargin;
			}
			set
			{
				this.oo._00..BottomMargin = value;
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x00259D8A File Offset: 0x00257F8A
		// (set) Token: 0x06005576 RID: 21878 RVA: 0x00259D97 File Offset: 0x00257F97
		public Font TextFont
		{
			get
			{
				return this.oo._00..TextFont;
			}
			set
			{
				this.oo._00..TextFont = (Font)value.Clone();
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x00259DAF File Offset: 0x00257FAF
		// (set) Token: 0x06005578 RID: 21880 RVA: 0x00259DBC File Offset: 0x00257FBC
		public Color TextForeColor
		{
			get
			{
				return this.oo._00..TextForeColor;
			}
			set
			{
				this.oo._00..TextForeColor = value;
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x00259DCA File Offset: 0x00257FCA
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x00259DD7 File Offset: 0x00257FD7
		public AztecCodeFormat AztecCodeFormat
		{
			get
			{
				return this.oo._00..AztecCodeFormat;
			}
			set
			{
				this.oo._00..AztecCodeFormat = value;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x00259DE5 File Offset: 0x00257FE5
		// (set) Token: 0x0600557C RID: 21884 RVA: 0x00259DF2 File Offset: 0x00257FF2
		public double AztecCodeModuleSize
		{
			get
			{
				return this.oo._00..AztecCodeModuleSize;
			}
			set
			{
				this.oo._00..AztecCodeModuleSize = value;
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x00259E00 File Offset: 0x00258000
		// (set) Token: 0x0600557E RID: 21886 RVA: 0x00259E0D File Offset: 0x0025800D
		public int AztecCodeErrorCorrection
		{
			get
			{
				return this.oo._00..AztecCodeErrorCorrection;
			}
			set
			{
				this.oo._00..AztecCodeErrorCorrection = value;
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x0600557F RID: 21887 RVA: 0x00259E1B File Offset: 0x0025801B
		// (set) Token: 0x06005580 RID: 21888 RVA: 0x00259E28 File Offset: 0x00258028
		public int AztecCodeRune
		{
			get
			{
				return this.oo._00..AztecCodeRune;
			}
			set
			{
				this.oo._00..AztecCodeRune = value;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06005581 RID: 21889 RVA: 0x00259E36 File Offset: 0x00258036
		// (set) Token: 0x06005582 RID: 21890 RVA: 0x00259E43 File Offset: 0x00258043
		public CodabarStartStopChar CodabarStartChar
		{
			get
			{
				return this.oo._00..CodabarStartChar;
			}
			set
			{
				this.oo._00..CodabarStartChar = value;
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06005583 RID: 21891 RVA: 0x00259E51 File Offset: 0x00258051
		// (set) Token: 0x06005584 RID: 21892 RVA: 0x00259E5E File Offset: 0x0025805E
		public CodabarStartStopChar CodabarStopChar
		{
			get
			{
				return this.oo._00..CodabarStopChar;
			}
			set
			{
				this.oo._00..CodabarStopChar = value;
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06005585 RID: 21893 RVA: 0x00259E6C File Offset: 0x0025806C
		// (set) Token: 0x06005586 RID: 21894 RVA: 0x00259E79 File Offset: 0x00258079
		public Code128 Code128CharSet
		{
			get
			{
				return this.oo._00..Code128CharSet;
			}
			set
			{
				this.oo._00..Code128CharSet = value;
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x00259E87 File Offset: 0x00258087
		// (set) Token: 0x06005588 RID: 21896 RVA: 0x00259E94 File Offset: 0x00258094
		public Code16k Code16kMode
		{
			get
			{
				return this.oo._00..Code16kMode;
			}
			set
			{
				this.oo._00..Code16kMode = value;
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06005589 RID: 21897 RVA: 0x00259EA2 File Offset: 0x002580A2
		// (set) Token: 0x0600558A RID: 21898 RVA: 0x00259EAF File Offset: 0x002580AF
		public DataMatrixEncoding DataMatrixEncoding
		{
			get
			{
				return this.oo._00..DataMatrixEncoding;
			}
			set
			{
				this.oo._00..DataMatrixEncoding = value;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x0600558B RID: 21899 RVA: 0x00259EBD File Offset: 0x002580BD
		// (set) Token: 0x0600558C RID: 21900 RVA: 0x00259ECA File Offset: 0x002580CA
		public DataMatrixFormat DataMatrixFormat
		{
			get
			{
				return this.oo._00..DataMatrixFormat;
			}
			set
			{
				this.oo._00..DataMatrixFormat = value;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x00259ED8 File Offset: 0x002580D8
		// (set) Token: 0x0600558E RID: 21902 RVA: 0x00259EE5 File Offset: 0x002580E5
		public double DataMatrixModuleSize
		{
			get
			{
				return this.oo._00..DataMatrixModuleSize;
			}
			set
			{
				this.oo._00..DataMatrixModuleSize = value;
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x0600558F RID: 21903 RVA: 0x00259EF3 File Offset: 0x002580F3
		// (set) Token: 0x06005590 RID: 21904 RVA: 0x00259F00 File Offset: 0x00258100
		public bool DataMatrixProcessTilde
		{
			get
			{
				return this.oo._00..DataMatrixProcessTilde;
			}
			set
			{
				this.oo._00..DataMatrixProcessTilde = value;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x00259F0E File Offset: 0x0025810E
		// (set) Token: 0x06005592 RID: 21906 RVA: 0x00259F1B File Offset: 0x0025811B
		public Supplement EanUpcSupplement
		{
			get
			{
				return this.oo._00..EanUpcSupplement;
			}
			set
			{
				this.oo._00..EanUpcSupplement = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x00259F29 File Offset: 0x00258129
		// (set) Token: 0x06005594 RID: 21908 RVA: 0x00259F36 File Offset: 0x00258136
		public string EanUpcSupplementCode
		{
			get
			{
				return this.oo._00..EanUpcSupplementCode;
			}
			set
			{
				this.oo._00..EanUpcSupplementCode = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06005595 RID: 21909 RVA: 0x00259F44 File Offset: 0x00258144
		// (set) Token: 0x06005596 RID: 21910 RVA: 0x00259F51 File Offset: 0x00258151
		public double EanUpcSupplementSeparation
		{
			get
			{
				return this.oo._00..EanUpcSupplementSeparation;
			}
			set
			{
				this.oo._00..EanUpcSupplementSeparation = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06005597 RID: 21911 RVA: 0x00259F5F File Offset: 0x0025815F
		// (set) Token: 0x06005598 RID: 21912 RVA: 0x00259F6C File Offset: 0x0025816C
		public double EanUpcSupplementTopMargin
		{
			get
			{
				return this.oo._00..EanUpcSupplementTopMargin;
			}
			set
			{
				this.oo._00..EanUpcSupplementTopMargin = value;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x00259F7A File Offset: 0x0025817A
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x00259F87 File Offset: 0x00258187
		public bool GuardBar
		{
			get
			{
				return this.oo._00..GuardBar;
			}
			set
			{
				this.oo._00..GuardBar = value;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x00259F95 File Offset: 0x00258195
		// (set) Token: 0x0600559C RID: 21916 RVA: 0x00259FA2 File Offset: 0x002581A2
		public double GuardBarHeight
		{
			get
			{
				return this.oo._00..GuardBarHeight;
			}
			set
			{
				this.oo._00..GuardBarHeight = value;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x0600559D RID: 21917 RVA: 0x00259FB0 File Offset: 0x002581B0
		// (set) Token: 0x0600559E RID: 21918 RVA: 0x00259FBD File Offset: 0x002581BD
		public UpcE UpcESystem
		{
			get
			{
				return this.oo._00..UpcESystem;
			}
			set
			{
				this.oo._00..UpcESystem = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x0600559F RID: 21919 RVA: 0x00259FCB File Offset: 0x002581CB
		// (set) Token: 0x060055A0 RID: 21920 RVA: 0x00259FD8 File Offset: 0x002581D8
		public int SegmentsPerRow
		{
			get
			{
				return this.oo._00..SegmentsPerRow;
			}
			set
			{
				this.oo._00..SegmentsPerRow = value;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x00259FE6 File Offset: 0x002581E6
		// (set) Token: 0x060055A2 RID: 21922 RVA: 0x00259FF3 File Offset: 0x002581F3
		public bool HibcFormatHumanReadableText
		{
			get
			{
				return this.oo._00..HibcFormatHumanReadableText;
			}
			set
			{
				this.oo._00..HibcFormatHumanReadableText = value;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x0025A001 File Offset: 0x00258201
		// (set) Token: 0x060055A4 RID: 21924 RVA: 0x0025A00E File Offset: 0x0025820E
		public Isbt128DataStructure Isbt128DataStructure
		{
			get
			{
				return this.oo._00..Isbt128DataStructure;
			}
			set
			{
				this.oo._00..Isbt128DataStructure = value;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x060055A5 RID: 21925 RVA: 0x0025A01C File Offset: 0x0025821C
		// (set) Token: 0x060055A6 RID: 21926 RVA: 0x0025A029 File Offset: 0x00258229
		public MaxiCodeModes MaxiCodeMode
		{
			get
			{
				return this.oo._00..MaxiCodeMode;
			}
			set
			{
				this.oo._00..MaxiCodeMode = value;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x060055A7 RID: 21927 RVA: 0x0025A037 File Offset: 0x00258237
		// (set) Token: 0x060055A8 RID: 21928 RVA: 0x0025A044 File Offset: 0x00258244
		public bool MaxiCodeProcessTilde
		{
			get
			{
				return this.oo._00..MaxiCodeProcessTilde;
			}
			set
			{
				this.oo._00..MaxiCodeProcessTilde = value;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x060055A9 RID: 21929 RVA: 0x0025A052 File Offset: 0x00258252
		// (set) Token: 0x060055AA RID: 21930 RVA: 0x0025A05F File Offset: 0x0025825F
		public int MaxiCodeSymbolCount
		{
			get
			{
				return this.oo._00..MaxiCodeSymbolCount;
			}
			set
			{
				this.oo._00..MaxiCodeSymbolCount = value;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x060055AB RID: 21931 RVA: 0x0025A06D File Offset: 0x0025826D
		// (set) Token: 0x060055AC RID: 21932 RVA: 0x0025A07A File Offset: 0x0025827A
		public int MaxiCodeSymbolIndex
		{
			get
			{
				return this.oo._00..MaxiCodeSymbolIndex;
			}
			set
			{
				this.oo._00..MaxiCodeSymbolIndex = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x060055AD RID: 21933 RVA: 0x0025A088 File Offset: 0x00258288
		// (set) Token: 0x060055AE RID: 21934 RVA: 0x0025A095 File Offset: 0x00258295
		public MsiChecksum ms
		{
			get
			{
				return this.oo._00..MsiChecksum;
			}
			set
			{
				this.oo._00..MsiChecksum = value;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x060055AF RID: 21935 RVA: 0x0025A0A3 File Offset: 0x002582A3
		// (set) Token: 0x060055B0 RID: 21936 RVA: 0x0025A0B0 File Offset: 0x002582B0
		public MicroPdf417Version MicroPdf417Version
		{
			get
			{
				return this.oo._00..MicroPdf417Version;
			}
			set
			{
				this.oo._00..MicroPdf417Version = value;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x060055B1 RID: 21937 RVA: 0x0025A0BE File Offset: 0x002582BE
		// (set) Token: 0x060055B2 RID: 21938 RVA: 0x0025A0CB File Offset: 0x002582CB
		public double Pdf417AspectRatio
		{
			get
			{
				return this.oo._00..Pdf417AspectRatio;
			}
			set
			{
				this.oo._00..Pdf417AspectRatio = value;
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x060055B3 RID: 21939 RVA: 0x0025A0D9 File Offset: 0x002582D9
		// (set) Token: 0x060055B4 RID: 21940 RVA: 0x0025A0E6 File Offset: 0x002582E6
		public int Pdf417Columns
		{
			get
			{
				return this.oo._00..Pdf417Columns;
			}
			set
			{
				this.oo._00..Pdf417Columns = value;
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x060055B5 RID: 21941 RVA: 0x0025A0F4 File Offset: 0x002582F4
		// (set) Token: 0x060055B6 RID: 21942 RVA: 0x0025A101 File Offset: 0x00258301
		public Pdf417CompactionType Pdf417CompactionType
		{
			get
			{
				return this.oo._00..Pdf417CompactionType;
			}
			set
			{
				this.oo._00..Pdf417CompactionType = value;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x060055B7 RID: 21943 RVA: 0x0025A10F File Offset: 0x0025830F
		// (set) Token: 0x060055B8 RID: 21944 RVA: 0x0025A11C File Offset: 0x0025831C
		public Pdf417ErrorCorrection Pdf417ErrorCorrectionLevel
		{
			get
			{
				return this.oo._00..Pdf417ErrorCorrectionLevel;
			}
			set
			{
				this.oo._00..Pdf417ErrorCorrectionLevel = value;
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x060055B9 RID: 21945 RVA: 0x0025A12A File Offset: 0x0025832A
		// (set) Token: 0x060055BA RID: 21946 RVA: 0x0025A137 File Offset: 0x00258337
		public string Pdf417FileId
		{
			get
			{
				return this.oo._00..Pdf417FileId;
			}
			set
			{
				this.oo._00..Pdf417FileId = value;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x060055BB RID: 21947 RVA: 0x0025A145 File Offset: 0x00258345
		// (set) Token: 0x060055BC RID: 21948 RVA: 0x0025A152 File Offset: 0x00258352
		public int Pdf417Rows
		{
			get
			{
				return this.oo._00..Pdf417Rows;
			}
			set
			{
				this.oo._00..Pdf417Rows = value;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x060055BD RID: 21949 RVA: 0x0025A160 File Offset: 0x00258360
		// (set) Token: 0x060055BE RID: 21950 RVA: 0x0025A16D File Offset: 0x0025836D
		public int Pdf417SegmentCount
		{
			get
			{
				return this.oo._00..Pdf417SegmentCount;
			}
			set
			{
				this.oo._00..Pdf417SegmentCount = value;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x060055BF RID: 21951 RVA: 0x0025A17B File Offset: 0x0025837B
		// (set) Token: 0x060055C0 RID: 21952 RVA: 0x0025A188 File Offset: 0x00258388
		public int Pdf417SegmentIndex
		{
			get
			{
				return this.oo._00..Pdf417SegmentIndex;
			}
			set
			{
				this.oo._00..Pdf417SegmentIndex = value;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x060055C1 RID: 21953 RVA: 0x0025A196 File Offset: 0x00258396
		// (set) Token: 0x060055C2 RID: 21954 RVA: 0x0025A1A3 File Offset: 0x002583A3
		public bool Pdf417Truncated
		{
			get
			{
				return this.oo._00..Pdf417Truncated;
			}
			set
			{
				this.oo._00..Pdf417Truncated = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x060055C3 RID: 21955 RVA: 0x0025A1B1 File Offset: 0x002583B1
		// (set) Token: 0x060055C4 RID: 21956 RVA: 0x0025A1BE File Offset: 0x002583BE
		public double PharmacodeBarsSpacing
		{
			get
			{
				return this.oo._00..PharmacodeBarsSpacing;
			}
			set
			{
				this.oo._00..PharmacodeBarsSpacing = value;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x060055C5 RID: 21957 RVA: 0x0025A1CC File Offset: 0x002583CC
		// (set) Token: 0x060055C6 RID: 21958 RVA: 0x0025A1D9 File Offset: 0x002583D9
		public double PharmacodeThickBarWidth
		{
			get
			{
				return this.oo._00..PharmacodeThickBarWidth;
			}
			set
			{
				this.oo._00..PharmacodeThickBarWidth = value;
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x060055C7 RID: 21959 RVA: 0x0025A1E7 File Offset: 0x002583E7
		// (set) Token: 0x060055C8 RID: 21960 RVA: 0x0025A1F4 File Offset: 0x002583F4
		public double PharmacodeThinBarWidth
		{
			get
			{
				return this.oo._00..PharmacodeThinBarWidth;
			}
			set
			{
				this.oo._00..PharmacodeThinBarWidth = value;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x060055C9 RID: 21961 RVA: 0x0025A202 File Offset: 0x00258402
		// (set) Token: 0x060055CA RID: 21962 RVA: 0x0025A20F File Offset: 0x0025840F
		public double PlanetHeightShortBar
		{
			get
			{
				return this.oo._00..PlanetHeightShortBar;
			}
			set
			{
				this.oo._00..PlanetHeightShortBar = value;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x060055CB RID: 21963 RVA: 0x0025A21D File Offset: 0x0025841D
		// (set) Token: 0x060055CC RID: 21964 RVA: 0x0025A22A File Offset: 0x0025842A
		public double PlanetHeightTallBar
		{
			get
			{
				return this.oo._00..PlanetHeightTallBar;
			}
			set
			{
				this.oo._00..PlanetHeightTallBar = value;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x060055CD RID: 21965 RVA: 0x0025A238 File Offset: 0x00258438
		// (set) Token: 0x060055CE RID: 21966 RVA: 0x0025A245 File Offset: 0x00258445
		public bool Postal4StateAddStartStopChar
		{
			get
			{
				return this.oo._00..Postal4StateAddStartStopChar;
			}
			set
			{
				this.oo._00..Postal4StateAddStartStopChar = value;
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x0025A253 File Offset: 0x00258453
		// (set) Token: 0x060055D0 RID: 21968 RVA: 0x0025A260 File Offset: 0x00258460
		public double Postal4StateBarsSpacing
		{
			get
			{
				return this.oo._00..Postal4StateBarsSpacing;
			}
			set
			{
				this.oo._00..Postal4StateBarsSpacing = value;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x0025A26E File Offset: 0x0025846E
		// (set) Token: 0x060055D2 RID: 21970 RVA: 0x0025A27B File Offset: 0x0025847B
		public double Postal4StateTrackerBarHeight
		{
			get
			{
				return this.oo._00..Postal4StateTrackerBarHeight;
			}
			set
			{
				this.oo._00..Postal4StateTrackerBarHeight = value;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x060055D3 RID: 21971 RVA: 0x0025A289 File Offset: 0x00258489
		// (set) Token: 0x060055D4 RID: 21972 RVA: 0x0025A296 File Offset: 0x00258496
		public double Postal4StateTrackerBarWidth
		{
			get
			{
				return this.oo._00..Postal4StateTrackerBarWidth;
			}
			set
			{
				this.oo._00..Postal4StateTrackerBarWidth = value;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x060055D5 RID: 21973 RVA: 0x0025A2A4 File Offset: 0x002584A4
		// (set) Token: 0x060055D6 RID: 21974 RVA: 0x0025A2B1 File Offset: 0x002584B1
		public double PostnetHeightShortBar
		{
			get
			{
				return this.oo._00..PostnetHeightShortBar;
			}
			set
			{
				this.oo._00..PostnetHeightShortBar = value;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x060055D7 RID: 21975 RVA: 0x0025A2BF File Offset: 0x002584BF
		// (set) Token: 0x060055D8 RID: 21976 RVA: 0x0025A2CC File Offset: 0x002584CC
		public double PostnetHeightTallBar
		{
			get
			{
				return this.oo._00..PostnetHeightTallBar;
			}
			set
			{
				this.oo._00..PostnetHeightTallBar = value;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x0025A2DA File Offset: 0x002584DA
		// (set) Token: 0x060055DA RID: 21978 RVA: 0x0025A2E7 File Offset: 0x002584E7
		public MicroQRCodeVersion MicroQRCodeVersion
		{
			get
			{
				return this.oo._00..MicroQRCodeVersion;
			}
			set
			{
				this.oo._00..MicroQRCodeVersion = value;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x060055DB RID: 21979 RVA: 0x0025A2F5 File Offset: 0x002584F5
		// (set) Token: 0x060055DC RID: 21980 RVA: 0x0025A302 File Offset: 0x00258502
		public QRCodeEncoding QRCodeEncoding
		{
			get
			{
				return this.oo._00..QRCodeEncoding;
			}
			set
			{
				this.oo._00..QRCodeEncoding = value;
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x060055DD RID: 21981 RVA: 0x0025A310 File Offset: 0x00258510
		// (set) Token: 0x060055DE RID: 21982 RVA: 0x0025A31D File Offset: 0x0025851D
		public QRCodeVersion QRCodeVersion
		{
			get
			{
				return this.oo._00..QRCodeVersion;
			}
			set
			{
				this.oo._00..QRCodeVersion = value;
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x0025A32B File Offset: 0x0025852B
		// (set) Token: 0x060055E0 RID: 21984 RVA: 0x0025A338 File Offset: 0x00258538
		public QRCodeErrorCorrectionLevel QRCodeErrorCorrectionLevel
		{
			get
			{
				return this.oo._00..QRCodeErrorCorrectionLevel;
			}
			set
			{
				this.oo._00..QRCodeErrorCorrectionLevel = value;
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060055E1 RID: 21985 RVA: 0x0025A346 File Offset: 0x00258546
		// (set) Token: 0x060055E2 RID: 21986 RVA: 0x0025A353 File Offset: 0x00258553
		public string QRCodeByteEncodingName
		{
			get
			{
				return this.oo._00..QRCodeByteEncodingName;
			}
			set
			{
				this.oo._00..QRCodeByteEncodingName = value;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060055E3 RID: 21987 RVA: 0x0025A361 File Offset: 0x00258561
		// (set) Token: 0x060055E4 RID: 21988 RVA: 0x0025A36E File Offset: 0x0025856E
		public double QRCodeModuleSize
		{
			get
			{
				return this.oo._00..QRCodeModuleSize;
			}
			set
			{
				this.oo._00..QRCodeModuleSize = value;
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060055E5 RID: 21989 RVA: 0x0025A37C File Offset: 0x0025857C
		// (set) Token: 0x060055E6 RID: 21990 RVA: 0x0025A389 File Offset: 0x00258589
		public TelepenEncoding TelepenEncoding
		{
			get
			{
				return this.oo._00..TelepenEncoding;
			}
			set
			{
				this.oo._00..TelepenEncoding = value;
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060055E7 RID: 21991 RVA: 0x0025A397 File Offset: 0x00258597
		// (set) Token: 0x060055E8 RID: 21992 RVA: 0x0025A3A4 File Offset: 0x002585A4
		public FIM UspsFimPattern
		{
			get
			{
				return this.oo._00..UspsFimPattern;
			}
			set
			{
				this.oo._00..UspsFimPattern = value;
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x060055E9 RID: 21993 RVA: 0x0025A3B2 File Offset: 0x002585B2
		// (set) Token: 0x060055EA RID: 21994 RVA: 0x0025A3BF File Offset: 0x002585BF
		public int UspsHorizontalBarsCount
		{
			get
			{
				return this.oo._00..UspsHorizontalBarsCount;
			}
			set
			{
				this.oo._00..UspsHorizontalBarsCount = value;
			}
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x0025A3CD File Offset: 0x002585CD
		public void SaveImage(string FileName)
		{
			this.SaveImage(FileName, 300f);
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x0025A3DC File Offset: 0x002585DC
		public void SaveImage(string FileName, float dpi)
		{
			string parentPath = OO_00oOO.FileSys.GetParentPath(FileName);
			if (!OO_00oOO.FileSys.DirectoryExists(parentPath))
			{
				OO_00oOO.FileSys.CreateDirectory(parentPath);
			}
			this.oo._00..Save(FileName, O_O0OO.OoO_00._.(FileName), dpi);
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x0025A420 File Offset: 0x00258620
		public Image GetImage()
		{
			return this.oo._00..GetBarcodeImage(300f);
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x0025A432 File Offset: 0x00258632
		public Image GetImage(int dpi)
		{
			return this.oo._00..GetBarcodeImage((float)dpi);
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x0025A441 File Offset: 0x00258641
		public void CopyImage()
		{
			Clipboard.SetImage(this.oo._00..GetBarcodeImage(300f));
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x0025A458 File Offset: 0x00258658
		public void CopyImage(int dpi)
		{
			Clipboard.SetImage(this.oo._00..GetBarcodeImage((float)dpi));
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x0025A46C File Offset: 0x0025866C
		public void DrawOnCanvas(Graphics graphic)
		{
			this.oo._00..DrawOnCanvas(graphic);
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x0025A47A File Offset: 0x0025867A
		public void DrawOnCanvas(Graphics graphic, float x, float y)
		{
			this.oo._00..DrawOnCanvas(graphic, new PointF(x, y));
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x0025A48F File Offset: 0x0025868F
		public void DrawOnCanvas(Graphics graphic, float x, float y, float Scale)
		{
			this.oo._00..DrawOnCanvas(graphic, new PointF(x, y), Scale);
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x0025A4A6 File Offset: 0x002586A6
		public void SetindField(string Field)
		{
			this.BindingField = Field;
		}

		// Token: 0x040022BE RID: 8894
		private OOo00o_0o0_ <<EMPTY_NAME>>;
	}
}
