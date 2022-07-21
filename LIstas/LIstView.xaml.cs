using Listas.Models;

namespace Listas;

public partial class ListView : ContentPage
{
    public ListView()
    {
        InitializeComponent();
    }

    private void lv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Persona per = (Persona)e.SelectedItem;
    }

    private void familia_Clicked(object sender, EventArgs e)
    {
        List<Persona> personas = new List<Persona>();

        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Pedro", DateTime.Now, Colors.Red));
        personas.Add(new Persona("Rosa", DateTime.Now, Colors.Pink));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));
        personas.Add(new Persona("Marco", DateTime.Now, Colors.Black));

        lv.ItemsSource = personas;
    }
}