using MauiNavigation.Models;

namespace MauiNavigation.Pages;
public partial class DetallePage : ContentPage
{
	private readonly Producto _producto;
	public DetallePage(Producto producto)
	{
		InitializeComponent();
		_producto= producto;

		lblNombre.Text=_producto.Nombre;
		lblPrecio.Text = _producto.PrecioFormateado;		
		lblDescripcion.Text= _producto.Descripcion;
        lblCategoria.Text= _producto.Categoria;
        lblId.Text = $"ID: {_producto.Id}";
    }

	private async void OnAgregarClicked(object sender, EventArgs e) 
	{
		await DisplayAlert("Agregado",$"{_producto.Nombre} fue agregado al carrito.","Ok");
	}

	private async void OnVolverClicked(object sender, EventArgs e) 
	{
		await Navigation.PopAsync();
	}
}