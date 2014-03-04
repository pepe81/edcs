using System;
using Gtk;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
	}
	public int bombo()
	{
		int bola;
		Random num = new Random();
		num.Next(1,90);
		//if (num>0 || num<=90)
		//{
		//	bola = num;
		//}
		//return bola;
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
