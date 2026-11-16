using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using C1.Win.C1Chart;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using Microsoft.VisualBasic.CompilerServices;

namespace Foxtable
{
	// Token: 0x02000407 RID: 1031
	[ProvideProperty("NewPage", typeof(Control))]
	[ProvideProperty("MaxRows", typeof(Control))]
	[ProvideProperty("Printable", typeof(Control))]
	[ProvideProperty("PrintBorder", typeof(Control))]
	[ProvideProperty("PrintRowNumber", typeof(Control))]
	[ProvideProperty("MinRows", typeof(Control))]
	internal class OoOO0ooo : Component, IExtenderProvider
	{
		// Token: 0x0600436F RID: 17263 RVA: 0x001EF7CC File Offset: 0x001ED9CC
		public OoOO0ooo()
		{
			this.PrintableValues = new Hashtable();
			this.MinRowsValues = new Hashtable();
			this.MaxRowsValues = new Hashtable();
			this.PrintRowNumberValues = new Hashtable();
			this.NewPageValues = new Hashtable();
			this.O0O.o____o00. = new Hashtable();
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x001EF824 File Offset: 0x001EDA24
		internal bool CanExtend(object extendee)
		{
			return extendee is System.Windows.Forms.Label || extendee is C1TextBox || extendee is C1FlexGrid || (extendee is CheckBox || extendee is RadioButton || extendee is O_oo) || (extendee is CustomPictureBox || extendee is C1Chart || extendee is LineControl) || (extendee is OOo00o_0o0_ || extendee is PictureViewer);
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x001EF89C File Offset: 0x001EDA9C
		internal bool GetPrintable(Control ctl)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.PrintableValues[ctl]);
			return objectValue != null && Conversions.ToBoolean(objectValue);
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x001EF8CC File Offset: 0x001EDACC
		internal bool <<EMPTY_NAME>>(Control A_0)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.O0O.o____o00.[A_0]);
			return objectValue != null && Conversions.ToBoolean(objectValue);
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x001EF8FC File Offset: 0x001EDAFC
		internal bool GetNewPage(Control ctl)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.NewPageValues[ctl]);
			return objectValue != null && Conversions.ToBoolean(objectValue);
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x001EF92A File Offset: 0x001EDB2A
		internal void SetPrintable(Control ctl, bool Value)
		{
			this.PrintableValues[ctl] = Value;
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x001EF93E File Offset: 0x001EDB3E
		internal void <<EMPTY_NAME>>(Control A_0, bool A_1)
		{
			this.O0O.o____o00.[A_0] = A_1;
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x001EF952 File Offset: 0x001EDB52
		internal void SetNewPage(Control ctl, bool Value)
		{
			this.NewPageValues[ctl] = Value;
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x001EF968 File Offset: 0x001EDB68
		internal int GetMinRows(Control ctl)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.MinRowsValues[ctl]);
			int result;
			if (objectValue == null)
			{
				result = 0;
			}
			else
			{
				result = Conversions.ToInteger(objectValue);
			}
			return result;
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x001EF998 File Offset: 0x001EDB98
		internal int GetMaxRows(Control ctl)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.MaxRowsValues[ctl]);
			int result;
			if (objectValue == null)
			{
				result = 0;
			}
			else
			{
				result = Conversions.ToInteger(objectValue);
			}
			return result;
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x001EF9C6 File Offset: 0x001EDBC6
		internal void SetMinRows(Control ctl, int Value)
		{
			this.MinRowsValues[ctl] = Value;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x001EF9DA File Offset: 0x001EDBDA
		internal void SetMaxRows(Control ctl, int Value)
		{
			this.MaxRowsValues[ctl] = Value;
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x001EF9F0 File Offset: 0x001EDBF0
		internal bool GetPrintRowNumber(Control ctl)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(this.PrintRowNumberValues[ctl]);
			return objectValue != null && Conversions.ToBoolean(objectValue);
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x001EFA1E File Offset: 0x001EDC1E
		internal void SetPrintRowNumber(Control ctl, bool Value)
		{
			this.PrintRowNumberValues[ctl] = Value;
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x001EFA34 File Offset: 0x001EDC34
		internal void Clear()
		{
			this.PrintableValues.Clear();
			this.NewPageValues.Clear();
			this.MinRowsValues.Clear();
			this.MaxRowsValues.Clear();
			this.PrintRowNumberValues.Clear();
			this.O0O.o____o00..Clear();
			base.Dispose();
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x001EFA8C File Offset: 0x001EDC8C
		internal void Remove(Control ctl)
		{
			if (this.PrintableValues.ContainsKey(ctl))
			{
				this.PrintableValues.Remove(ctl);
			}
			if (this.NewPageValues.ContainsKey(ctl))
			{
				this.NewPageValues.Remove(ctl);
			}
			if (this.MinRowsValues.ContainsKey(ctl))
			{
				this.MinRowsValues.Remove(ctl);
			}
			if (this.MaxRowsValues.ContainsKey(ctl))
			{
				this.MaxRowsValues.Remove(ctl);
			}
			if (this.PrintRowNumberValues.ContainsKey(ctl))
			{
				this.PrintRowNumberValues.Remove(ctl);
			}
			if (this.O0O.o____o00..ContainsKey(ctl))
			{
				this.O0O.o____o00..Remove(ctl);
			}
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x001EFB38 File Offset: 0x001EDD38
		internal void Refresh()
		{
			List<Control> list = new List<Control>();
			try
			{
				foreach (object obj in this.PrintableValues.Keys)
				{
					Control control = (Control)obj;
					if (control.FindForm() == null)
					{
						list.Add(control);
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
			try
			{
				foreach (Control ctl in list)
				{
					this.Remove(ctl);
				}
			}
			finally
			{
				List<Control>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x04001BBD RID: 7101
		private Hashtable PrintableValues;

		// Token: 0x04001BBE RID: 7102
		private Hashtable MinRowsValues;

		// Token: 0x04001BBF RID: 7103
		private Hashtable MaxRowsValues;

		// Token: 0x04001BC0 RID: 7104
		private Hashtable PrintRowNumberValues;

		// Token: 0x04001BC1 RID: 7105
		private Hashtable NewPageValues;

		// Token: 0x04001BC2 RID: 7106
		private Hashtable <<EMPTY_NAME>>;
	}
}
