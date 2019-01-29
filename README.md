# graph_components_umbraco_base_section
Base section for Umbraco Grid

Dependencies:
* Skybrud.Umbraco.GridData - https://github.com/skybrud/Skybrud.Umbraco.GridData (install via nuget)
* Vega.USiteBuilder - https://github.com/vegaitsourcing/uSiteBuilder (install via nuget)
* Gibe.LinkPicker - https://github.com/Gibe/Umbraco-Link-Picker (install like a backoffice extension or nuget)

Installation steps:
1. Install all dependencies
3. Copy all files to the folder 'BaseSection' to ~\App_Plugins\
5. Umbraco will create the data type on startup application

Example of usages:
Migration:
[DocumentTypeProperty(UmbracoPropertyType.Other, OtherType = typeof(BaseSectionBlockDataType), Name = "Content Blocks", Tab = "Content", Alias = "contentBlocks")]
public string ContentBlocks { get; set; }

Model:
public GridDataModel ContentBlocks { get; set; } 

View:
@Html.Partial("~/App_Plugins/BaseSection/Grid/Layout/GridLayout.cshtml", Model.ContentBlocks)