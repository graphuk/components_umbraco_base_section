using Umbraco.Core.Models;
using Vega.USiteBuilder;

namespace Graph.Components.BaseSectionBlock
{
	[DataType(Name = "Base Section Blocks", PropertyEditorAlias = "Umbraco.Grid", UniqueId = "e4492a18-fcb3-47bf-bc75-8650d6a0cf89", DataTypeDatabaseType = DataTypeDatabaseType.Ntext)]
	public class BaseSectionBlockDataType : DataTypeBase
	{
		public override DataTypePrevalue[] Prevalues => new DataTypePrevalue[]
		{
			new DataTypePrevalue("items", GridBaseSectionItems),
			new DataTypePrevalue("rte", GridBaseSectionRte),
		};

		private const string GridBaseSectionItems = @"{
			  ""styles"": [],
			  ""config"": [
			    {
			      ""label"": ""Title"",
			      ""description"": """",
			      ""key"": ""title"",
			      ""view"": ""requiredfield""
			    },
			    {
			      ""label"": ""Summary"",
			      ""description"": """",
			      ""key"": ""summary"",
			      ""view"": ""textarea""
			    },
			    {
			      ""label"": ""CTA Button Link"",
			      ""description"": """",
			      ""key"": ""ctaButton"",
			      ""view"": ""linkpicker"",
			      ""modifier"": ""json""
			    }
			  ],
			  ""columns"": 12,
			  ""templates"": [
			    {
			      ""name"": ""Content Blocks Section"",
			      ""sections"": [
			        {
			          ""grid"": 12,
			          ""allowAll"": true
			        }
			      ]
			    }
			  ],
			  ""layouts"": [
			    {
			      ""label"": ""Base Section (One Column)"",
			      ""name"": ""Base Section (One Column)"",
			      ""areas"": [
			        {
			          ""grid"": 12,
			          ""editors"": [
			            ""headline""
			          ],
			          ""allowAll"": true,
			          ""maxItems"": 0
			        }
			      ]
			    },
			    {
			      ""name"": ""Base Section (Two Column)"",
			      ""areas"": [
			        {
			          ""grid"": 6,
			          ""allowAll"": true,
			          ""maxItems"": 0
			        },
			        {
			          ""grid"": 6,
			          ""allowAll"": true,
			          ""maxItems"": 0
			        }
			      ],
			      ""label"": ""Base Section (Two Column)""
			    }
			  ]
			}";

		private const string GridBaseSectionRte = @"{
			  ""toolbar"": [
			    ""code"",
			    ""styleselect"",
			    ""bold"",
			    ""italic"",
			    ""alignleft"",
			    ""aligncenter"",
			    ""alignright"",
			    ""bullist"",
			    ""numlist"",
			    ""outdent"",
			    ""indent"",
			    ""link"",
			    ""umbmediapicker"",
			    ""umbmacro"",
			    ""umbembeddialog""
			  ],
			  ""stylesheets"": [],
			  ""dimensions"": {
			    ""height"": 500
			  },
			  ""maxImageSize"": 500
			}";
	}
}