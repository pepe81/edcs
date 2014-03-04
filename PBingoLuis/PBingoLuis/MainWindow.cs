
using Gtk;
using System;
using System.Diagnostics;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{	
	private List<int> numeros = new List<int>();
	private Table table,table2;
	private List<Button> buttons = new List<Button>();
	private Random random = new Random();
	private static readonly Gdk.Color COLOR_GREEN = new Gdk.Color(0,255,0);
	private int numeroTotalBolas = 90;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
		uint fila = ((uint)numeroTotalBolas-1)/10+1;
		
		table = new Table(fila,10,true);//(fila,columna)
		vbox1.Add(table);
		table.Visible = true;
		
		addButtons();
		
		table2 = new Table(fila,10,true);//(fila,columna)
		vbox1.Add(table2);
		table2.Visible = true;
		
		
		
		for (int numero = 1;numero <= numeroTotalBolas;numero++)
			numeros.Add(numero);
		
		showNumeros();
		
		goForwardAction.Activated+=delegate
		{
			int indexAleatorio = random.Next(numeros.Count);
			int numeroExtraido = numeros[indexAleatorio];
			
			entryNumero.Text = numeroExtraido.ToString();
			
			buttons[numeroExtraido-1].ModifyBg(StateType.Normal,COLOR_GREEN);
			
			addButtonsSalidos();
			
			numeros.Remove(numeroExtraido);
			
			showNumeros();
		};
	}
	private void addButtons()
	{
		for (int index = 0; index < numeroTotalBolas;index++)
		{
			Button button = new Button();
			button.Label = string.Format("{0}",index+1);
			button.Visible = true;
			
			buttons.Add(button);
			
			uint fila = (uint)index / 10;
			uint columna = (uint)index % 10;
			
			table.Attach(button,columna,columna+1,fila,fila+1);
		}
	}
	private void addButtonsSalidos()
	{
		Button button = new Button();
		button.Label = entryNumero.Text;
		button.Visible = true;
		
		int cont = table2.Children.Length;
		
		buttons.Add(button);
		
		uint fila = (uint)cont / 10;
		uint columna = (uint)cont % 10;
		
		table2.Attach(button,columna,columna+1,fila,fila+1);
	}
	private void showNumeros()
	{
//		for(int index =0;index<numeros.Count;index ++)
//			Console.Write (numeros[index]+" ");
//		Console.WriteLine ();
		foreach(int numero in numeros)
			Console.Write (numero+" ");
		Console.WriteLine ();
	}
	private void espeak(int numeroExtraido)
	{
		string numeroCantado = numeroExtraido.ToString();
		if(numeroCantado.Length>1)
		{
			string digitos=numeroCantado;
			foreach (char digito in digitos)
				numeroCantado = numeroCantado+" "+digito;
		}
		Process.Start("espeak","-v es\""+numeroExtraido+"\"");
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
