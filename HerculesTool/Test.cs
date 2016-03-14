using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Telerik.WinControls.UI;

namespace HerculesTool
{
    public partial class Test : Form
    {
        private ImageList myImageList;

        public Test()
        {
            InitializeComponent();
            
            
            listView1.Dock = DockStyle.Fill;
            listView1.View = View.Tile;

            // Initialize the tile size.
            listView1.TileSize = new Size(175, 50);

            // Initialize the item icons.
            myImageList = new ImageList();
            
            myImageList.ImageSize = new Size(32, 32);
            listView1.LargeImageList = myImageList;

            // Add column headers so the subitems will appear.
            listView1.Columns.AddRange(new ColumnHeader[]
                {new ColumnHeader(), new ColumnHeader(), new ColumnHeader()});
            
            // Create items and add them to listView1.
            ListViewItem item0 = new ListViewItem(new string[]
                {"Programming Windows",
            "Petzold, Charles",
            "1998"}, 0);

            item0.UseItemStyleForSubItems = true;


            ListViewItem item1 = new ListViewItem(new string[]
                {"Code: The Hidden Language of Computer Hardware and Software",
            "Petzold, Charles",
            "2000"}, 0);
            ListViewItem item2 = new ListViewItem(new string[]
                {"Programming Windows with C#",
            "Petzold, Charles",
            "2001"}, 0);
            ListViewItem item3 = new ListViewItem(new string[]
                {"Coding Techniques for Microsoft Visual Basic .NET",
            "Connell, John",
            "2001"}, 0);
            ListViewItem item4 = new ListViewItem(new string[]
                {"C# for Java Developers",
            "Jones, Allen & Freeman, Adam",
            "2002"}, 0);
            ListViewItem item5 = new ListViewItem(new string[]
                {"Microsoft .NET XML Web Services Step by Step",
            "Jones, Allen & Freeman, Adam",
            "2002"}, 0);

            listView1.Items.AddRange(
                new ListViewItem[] { item0, item1, item2, item3, item4, item5 });

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Test_Load(object sender, EventArgs e)
        {
            /*
            TextEditor textEditor = new TextEditor();
            textEditor.ShowLineNumbers = true;
            textEditor.FontFamily = new System.Windows.Media.FontFamily("Consolas");
            textEditor.FontSize = 12.75f;

            String url = String.Format(@"{0}\Plugins\", Environment.CurrentDirectory);

            if (File.Exists(url + "Script.xshd"))
            {
                Console.WriteLine("exists");
                Stream xshd_stream = File.OpenRead(url + "Script.xshd");
                XmlTextReader xshd_reader = new XmlTextReader(xshd_stream);
                // Apply the new syntax highlighting definition.
                textEditor.SyntaxHighlighting = HighlightingLoader.Load(xshd_reader, HighlightingManager.Instance);
                xshd_reader.Close();
                xshd_stream.Close();
            }


            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;
            host.Child = textEditor;
            this.Controls.Add(host);
            */
        }
    }
}
