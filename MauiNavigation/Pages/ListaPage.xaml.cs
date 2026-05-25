using MauiNavigation.Models;

namespace MauiNavigation.Pages;

public partial class ListaPage : ContentPage
{
	private readonly List<Producto> _productos = new()
	{
		new Producto { Id = 1, Nombre = "Laptop", Categoria = "Electrónica", Precio = 999.99m, Descripcion = "Una laptop potente para todas tus necesidades." },
		new Producto { Id = 2, Nombre = "Smartphone", Categoria = "Electrónica", Precio = 499.99m, Descripcion = "Un smartphone moderno con todas las funciones." },
		new Producto { Id = 3, Nombre = "Cámara", Categoria = "Fotografía", Precio = 299.99m, Descripcion = "Captura momentos especiales con esta cámara de alta calidad." },
		new Producto { Id = 4, Nombre = "Auriculares", Categoria = "Audio", Precio = 199.99m, Descripcion = "Disfruta de tu música con estos auriculares de alta fidelidad." },
		new Producto { Id = 5, Nombre = "Reloj Inteligente", Categoria = "Wearables", Precio = 149.99m, Descripcion = "Mantente conectado y monitorea tu salud con este reloj inteligente." }
	};
	public ListaPage()
	{
		InitializeComponent();
		listaProductos.ItemsSource = _productos;
	}

	private async void OnProductoSeleccionado(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.FirstOrDefault() is not Producto seleccionado)
			return;

		listaProductos.SelectedItem = null;

		await Shell.Current.GoToAsync(nameof(DetallePage), new Dictionary<string, object>
		{
			["Producto"] = seleccionado
		});
	}
}