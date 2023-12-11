------------------------------------------------------------------------------------------
This is a template for F# programmers to develop their own F# AGSEditor plugins.

File descriptions:

AGSPanel.fs		->	This is the place where you design your layout. The content here is
					directly shown in a panel in AGSEditor when you select
					the appropriate element in the tree.

Panel.fs		->	This is a (not necessary) helper class to combine the ContenDocument
					and your visualized panel

Plugin.fs		->	This is the place where all the function called by AGSEditor lies.

PluginLoader.fs	->	This is the main entry point in the plugin. AGSEditor searches for
					an object with the attribute <RequiredAGSVersion> and calls the
					constructor. You have to add your library to the internal structure.

------------------------------------------------------------------------------------------
How to start?

1.	A good place is to learn F#
2.	Change the namespace in all files from 'AGS.Plugin.Template' to something else
	e.g. 'AGS.Plugin.<myplugin>'
3.	In plugin.fs change the ids from the 'templated' one to something that
	reflects your plugin.
4.	Change the default icon (you have to set it to 'Embedded Resource')
5.	For debugging: Change the path to your AGSEditor.exe used as the plugin host.
6.	Change the past compile options to copy necessary files to you AGSEditor folder
	used for debugging
	(Build -> Events) (Project -> Properties -> launchSettings.json)

------------------------------------------------------------------------------------------
Be ware that unlike C# in F# the declaration of a function have to be before the usage.
So the order of the files and functions are important.
