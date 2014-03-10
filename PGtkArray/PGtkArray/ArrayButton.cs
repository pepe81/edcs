using Gtk;
using System;

namespace PGtkArray
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ArrayButton : Gtk.Bin
	{
		private int rows = 1;
		private int colums = 1;
		
		private Table table;
		
		public ArrayButton ()
		{
			this.Build ();
			table = new Table((uint)rows,(uint)colums, true);
			Add(table);
			
			refresh();
		}
		private void refresh ()
		{
			Button button = new Button();
			button.Visible = true;
			button.Label="33";
			table.Attach(button,0,1,0,1);
		}
		
	}
}

