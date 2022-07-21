using Listas.Models;

namespace Listas;

public partial class CarrouselView : ContentPage
{
	public CarrouselView()
	{
		InitializeComponent();

        List<Persona> lista = new List<Persona>();
        lista.Add(new Persona("Jose", System.DateTime.Now, Colors.AliceBlue, "dotnet_bot"));
        lista.Add(new Persona("Elena", System.DateTime.Now, Colors.AliceBlue, "iconomujer"));
        lista.Add(new Persona("Carlos", System.DateTime.Now, Colors.AliceBlue, "dotnet_bot"));
        lista.Add(new Persona("Eva", System.DateTime.Now, Colors.AliceBlue, "iconomujer"));
        lista.Add(new Persona("Sandro", System.DateTime.Now, Colors.AliceBlue, "dotnet_bot"));
        lista.Add(new Persona("Lucia", System.DateTime.Now, Colors.AliceBlue, "iconomujer"));
        lista.Add(new Persona("JUan", System.DateTime.Now, Colors.AliceBlue, "dotnet_bot"));
        lista.Add(new Persona("Sandra", System.DateTime.Now, Colors.AliceBlue, "iconomujer"));

        cvPersona.ItemsSource = lista;

    }
}