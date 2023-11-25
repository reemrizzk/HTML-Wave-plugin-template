# HTML-Wave-plugin-template
A template for creating plugins for the app HTML Wave

HTML Wave is written in C# using the windows forms framework.
## You can write and release your own plugin for HTML Wave easily.
- Download the code, open it using Microsoft Visual studio
- Change the namespace to the name of your plugin
- open the file Class1.cs
- Write your main plugin code inside the DoWork method.
 -DoWork is the main method that gets called from the app
 -use the "pm" instance of the ManagerInterface class to call functions from the main form. these are the functions that you can call:

```c#
pm.InsertHTMLAtSelection(string htmlText); // Inserts HTML code at current selection in textarea of current tab
pm.AddToHtmlHead(string htmlText); // Adds code to <head> section in textarea of current tab
pm.AddToHtmlStyleTag(string htmlText); // Adds code inside <style> tag in textarea of current tab
pm.AddToHtmlHeadIfDoesntExist(string htmlText); // Adds code to <head> section in textarea of current tab, if the code doesn't already exist there
pm.SetBuiltinThemeUpdate(bool isUpdate); // Toggle whether  built in textarea styles should be executed
pm.SetBuiltinAutocomplete(bool isAutocomplete); // Toggle whether Autocomplete menu is enabled
pm.GetApplicationDirectory(); // Returns the path to the application's directory
pm.GetCurrentTabIndex(); // Gets the index of the current tab
pm.GetCurrentTextarea(); // Returns the Scintilla textarea control from the current tab
pm.GetAllTextareas();  // Returns a List<Scintilla> of all Scintilla textarea controls
pm.CreateNewTab(string fileName, bool isFileOpened, string fileType);  // Creates a new tab
pm.CopyIfOutsideProjectFolder(string fileUrl, string folderToCopyTo);  // Copies a file to a folder in project directory if the file is not already in the project's directory
pm.GetCurrentProjectNameIfExists(); // Gets the project name of the file in the current tab, if its from a project
pm.GetCurrentFileName(); // Gets the file path of the file in the current tab, if exists
pm.SetCurrentFileName(string newFileName);  // Changes the file path of the file in the current tab
pm.GetCurrentFileType(); // Gets the type of the file in the current tab
pm.SetCurrentFiletype(string newFileType); // Changes the type of the file in the current tab
pm.OpenNewFile(); // Opens the OpenFileDialog to open a file
pm.SaveCurrentFile(); // Saves the current file
pm.CallTabIndexChangedEvent(); // Calls the TabIndexChanged event
pm.GetTheme();  // Gets the current theme of the application (Light/Dark)
pm.AddItemToToolStrip(ToolStripItem tsi); //  Adds a new item to the toolbar
pm.AddItemToStatusStrip(ToolStripStatusLabel tssl);  // Adds a new item to the status bar on the bottom of the application
pm.AddItemToMenuStrip(ToolStripMenuItem tsi, string menuName); //  Adds a new menu item to the menu specified (File/Edit/View/Insert/Tools/Help) or submenu (New/Format/Form) or toolstrip dropdown (NewToolStrip/FormatToolStrip/FormToolStrip/AttachToolStrip)
pm.GetPreviewBrowserInstance(); // Returns the preview WebBrowser control
pm.GetVisualEditor(); // Returns the design WebBrowser control
pm.isVisualeditor(); // Returns whether the app is currently displaying the visual editor
pm.GetColorFromDialog(); // Opens color dialog and returns the color in hex format
pm.AddTheme(ComponentFactory.Krypton.Toolkit.KryptonPalette palette,
            string themeName, string themeType, string styleType,
            string scintillaTheme, int iconsList, Color commonColor, Color commonColor2,
            ToolStripRenderMode rendermode1, ToolStripRenderMode rendermode2,
            string formHeader
            ) // Adds a new custom theme
```
