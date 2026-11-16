using System;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class DotfuscatorAttribute : Attribute
{
	// Token: 0x06000001 RID: 1 RVA: 0x000021F4 File Offset: 0x000003F4
	public DotfuscatorAttribute(string a, int c, bool b)
	{
		this.a = a;
		this.c = c;
		this.b = b;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x0000221C File Offset: 0x0000041C
	public string A
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002230 File Offset: 0x00000430
	public bool B
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002244 File Offset: 0x00000444
	public int C
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x04000001 RID: 1
	private string a;

	// Token: 0x04000002 RID: 2
	private bool b;

	// Token: 0x04000003 RID: 3
	private int c;
}
