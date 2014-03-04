using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		labelSaludo.LabelProp = "Texto de saludo";
		entryNombre.Text = "Pon tu nombre, por favor";
		
		Focus = entryNombre;
		labelSaludo.UseMarkup = true;
			
		buttonAceptar.Clicked += delegate {
			labelSaludo.LabelProp="Hola <b>"+ entryNombre.Text+"</b>";
		};
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
