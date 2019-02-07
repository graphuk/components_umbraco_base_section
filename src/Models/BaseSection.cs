using System.Collections.Generic;
using Graph.Components.ContentBlocks;

namespace Graph.Components.BaseSection
{
	public class BaseSection : GridSettingsLoader.IGridConfigLoader
	{
		private static readonly Dictionary<string, string> ApplyTo = new Dictionary<string, string>
		{
			{"row", nameof(BaseSection)}
		};

		private static string GetKey(string key) => $"{key}{nameof(BaseSection)}";

		public GridSettingsLoader.Config[] Config =
		{
			new GridSettingsLoader.Config
			{
				Label = "Title",
				Description = "",
				Key = GetKey("title"),
				View = "textstring",
				ApplyTo = ApplyTo
			},
			new GridSettingsLoader.Config
			{
				Label = "Summary",
				Description = "",
				Key = GetKey("summary"),
				View = "textarea",
				ApplyTo = ApplyTo
			},
			new GridSettingsLoader.Config
			{
				Label = "CTA Button Link",
				Description = "",
				Key = GetKey("ctaButton"),
				View = "/App_Plugins/GibeLinkPicker/picker.html",
				Modifier = "json",
				ApplyTo = ApplyTo
			},
			new GridSettingsLoader.Config
			{
				Label = "Theme",
				Description = "",
				Key = GetKey("theme"),
				View = "radiobuttonlist",
				ApplyTo = ApplyTo,
				Prevalues = new []
				{
					new GridSettingsLoader.Prevalue
					{
						Label = "Primary",
						Value = "primary"
					},
					new GridSettingsLoader.Prevalue
					{
						Label = "Secondary",
						Value = "secondary"
					}
				}
			}
		};

		public GridSettingsLoader.Layout[] Layout =
		{
			new GridSettingsLoader.Layout
			{
				Label = "Base Section",
				Name = nameof(BaseSection),
				Areas = new []
				{
					new GridSettingsLoader.Area
					{
						Grid = 12,
						Editors = new List<string>(),
						AllowAll = true,
						MaxItems = 0
					}
				}
			}
		};
	}
}
