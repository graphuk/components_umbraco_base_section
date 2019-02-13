# graph_components_umbraco_base_section
Base section for Umbraco Grid

Dependencies:
* UmbracoGridConfigLoader - https://github.com/graphuk/umbraco_grid_config_loader/ (install via nuget)
* Skybrud.Umbraco.GridData - https://github.com/skybrud/Skybrud.Umbraco.GridData (install via nuget)
* UCreate - https://github.com/nicbell/ucreate (install via nuget)
* Gibe.LinkPicker - https://github.com/Gibe/Umbraco-Link-Picker (install like a backoffice extension or nuget)
* [Content Blocks](https://github.com/graphuk/components_umbraco_content_blocks) (install it via Stamp)

Installation steps:
1. Install all dependencies
2. Copy all files to the folder 'BaseSection' to ~\App_Plugins\
3. Umbraco will update the [Content Blocks](https://github.com/graphuk/components_umbraco_content_blocks) data type on startup application
4. Please ensure that you install [Content Blocks](https://github.com/graphuk/components_umbraco_content_blocks) Data type
You need to add a place where BaseSection can be added.
