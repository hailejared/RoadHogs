using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RoadHogs.My.Resources
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[HideModuleName]
	internal static class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return RoadHogs.My.Resources.Resources.resourceCulture;
			}
			set
			{
				RoadHogs.My.Resources.Resources.resourceCulture = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(RoadHogs.My.Resources.Resources.resourceMan, null))
				{
					RoadHogs.My.Resources.Resources.resourceMan = new System.Resources.ResourceManager("RoadHogs.Resources", typeof(RoadHogs.My.Resources.Resources).Assembly);
				}
				return RoadHogs.My.Resources.Resources.resourceMan;
			}
		}
	}
}