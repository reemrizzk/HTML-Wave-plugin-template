using PluginLibrary;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginTemplate
    // Rename the namespace to your plugins name
{

    public class Class1 : IPlugin
    {
        public ManagerInterface pm; // This is the interface for the class that holds all accessible plugin methods
        public void DoWork(ManagerInterface pm)
        {
            this.pm = pm;
             pm.CustomThemeUpdateReady().CheckedChanged += new System.EventHandler(this.OnCustomThemeUpdateReady);
            // Add the line below if you want to disable default textarea styling:
            // pm.SetBuiltinThemeUpdate(false);
            





            // Your plugin code goes here







            // Example: adding a menu item to the app's menu:
          /*
            ToolStripMenuItem menuItem = new ToolStripMenuItem();
            menuItem.Size = new System.Drawing.Size(195, 22);
            menuItem.Text = "Added menu item"; // The menu item's text to be displayed
            menuItem.Click += new System.EventHandler(this.menuItem_Click); // Add a click event handler to the menuItem
            pm.AddItemToMenuStrip(menuItem, "tools"); // Add the created menu item to the menu "Tools"
           */
        }

        // Handle the menuitem click
        private void menuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void OnCustomThemeUpdateReady(object sender, EventArgs e)
        {
            if (pm.CustomThemeUpdateReady().Checked) { 
                List<Scintilla> allTextAreas = pm.GetAllTextareas();
                foreach (Scintilla textarea in allTextAreas)
                {
                   // Custom textarea styling code goes here

                }
            }
        }

    }
}