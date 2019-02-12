using UmbracoGridConfigLoader.Attributes;
using UmbracoGridConfigLoader.Models;

namespace Graph.Components.BaseSection
{
	public class BaseSection : IGridConfigLoader
	{
		[GridConfigProperty(Label = "Title", View = PreValuesEditors.TextString)]
		public IGridConfig Title { get; set; }

		[GridConfigProperty(Label = "Summary", View = PreValuesEditors.Textarea)]
		public IGridConfig Summary { get; set; }

		[GridConfigProperty(Label = "CTA Button Link", View = "/App_Plugins/GibeLinkPicker/picker.html", Modifier = "json")]
		public IGridConfig CtaButton { get; set; }

		[GridConfigProperty(Label = "Theme", View = PreValuesEditors.Radiobuttonlist, Prevalues = new[] {"Primary", "Secondary"})]
		public IGridConfig Theme { get; set; }

		[GridLayoutProperty(Label = "Base Section", AllowedEditors = new [] { "richtextBlock", "accordionBlock", "tilesBlock" })]
		public IGridLayout Layout { get; set; }

	}
}
