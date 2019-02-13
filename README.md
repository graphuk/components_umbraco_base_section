# graph_components_umbraco_base_section
Base section for Umbraco Grid

Nuget:
* Install-Package UmbracoGridConfigLoader
* Install-Package Skybrud.Umbraco.GridData
* Install-Package UCreate
* Install-Package UmbracoLinkPicker

Dependencies:
* [Content Blocks](https://github.com/graphuk/components_umbraco_content_blocks) (install it via Stamp)

Installation steps:
1. Install Nuget packages and dependencies
2. Copy all files to the folder 'BaseSection' to ~\App_Plugins\
3. Umbraco will update the [Content Blocks](https://github.com/graphuk/components_umbraco_content_blocks) data type on startup application
4. Please ensure that you install [Content Blocks](https://github.com/graphuk/components_umbraco_content_blocks) Data type
You need to add a place where BaseSection can be added.
