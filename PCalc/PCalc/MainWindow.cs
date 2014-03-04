using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		String s1,s2;
		decimal valor1,valor2;
		
		buttonSuma.Clicked+=delegate
		{
			try
			{
				s1 = entry1.Text;
				s2 = entry2.Text;
				valor1=decimal.Parse(s1);
				valor2=decimal.Parse(s2);
				labelResult.Text=("El valor de la suma es: "+((valor1+valor2).ToString()));
			}
			catch(FormatException)
			{
				labelResult.Text=("¡Las letras no se suman!!");
			}	
		};
		buttonResta.Clicked+=delegate
		{
			try
			{
				s1 = entry1.Text;
				s2 = entry2.Text;
				valor1=decimal.Parse(s1);
				valor2=decimal.Parse(s2);
				labelResult.Text=("El valor de la resta es: "+((valor1-valor2).ToString()));
			}
			catch(FormatException)
			{
				labelResult.Text=("¡Las letras no se restan!!");
			}
		};
		buttonMultip.Clicked+=delegate
		{
			try
			{
				s1 = entry1.Text;
				s2 = entry2.Text;
				valor1=decimal.Parse(s1);
				valor2=decimal.Parse(s2);
				labelResult.Text=("El valor de la multiplicación es: "+((valor1*valor2).ToString()));
			}
			catch(FormatException)
			{
				labelResult.Text=("Las letras no se multiplican!!");
			}
		};
		buttonDiv.Clicked+=delegate
		{
			try
			{
				s1 = entry1.Text;
				s2 = entry2.Text;
				valor1=decimal.Parse(s1);
				valor2=decimal.Parse(s2);
				labelResult.Text=("El valor de la división es: "+((valor1/valor2).ToString()));
			}
			catch(FormatException)
			{
				labelResult.Text=("¡Las letras no se dividen!!!");
			}
			catch(DivideByZeroException)
			{
				labelResult.Text=("¡Por cero no se divide!!!!!");
			}
		};
		buttonIgual.Clicked+=delegate
		{
			;
		};
		buttonReset.Clicked+= delegate 
		{
			entry1.Text = "";
			entry2.Text = "";
			labelResult.Text = "";
		};
		//Button[] buttons = new Button[]{buttonCero,button1,button2,button3,button4,button5,button6,button7,button8,button9};
		
//		buttonCero.Clicked+=delegate
//		{
//			buttonClicked(buttonCero);
//		};
//
//		button1.Clicked +=delegate
//		{
//			buttonClicked(button1);
//		};
//
//		button2.Clicked+=delegate
//		{
//			buttonClicked(button2);
//		};
//	
//		button3.Clicked+=delegate
//		{
//			buttonClicked(button3);;
//		};
//
//		button4.Clicked+=delegate
//		{
//			buttonClicked(button4);;
//		};
//
//		button5.Clicked+=delegate
//		{
//			buttonClicked(button5);
//		};
//
//		button6.Clicked+=delegate
//		{
//			buttonClicked(button6);
//		};
//
//		button7.Clicked+=delegate
//		{
//			buttonClicked(button7);;
//		};
//
//		button8.Clicked+=delegate
//		{
//			buttonClicked(button8);
//		};
//	
//		button9.Clicked+=delegate
//		{
//			buttonClicked(button9);
//		};
		foreach (Button item in new Button[]{buttonCero,button1,button2,button3,button4,button5,button6,button7,button8,button9})
		item.Clicked += delegate(object sender, EventArgs e) {
			Button button = (Button)sender;
			Entry entry = Focus as Entry;
			if (entry !=null)
				entry.Text=entry.Text + button.Label;
		};
	}
	
	private void buttonClicked(Button button)
	{
		Entry entry = Focus as Entry;
			if(entry !=null)
				entry.Text = entry.Text + button.Label;
	}	
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
