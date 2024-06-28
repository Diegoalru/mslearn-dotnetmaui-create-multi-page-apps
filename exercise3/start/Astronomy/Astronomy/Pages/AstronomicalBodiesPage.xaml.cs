namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();

		btnComet.Clicked += async (_, _) => await Shell.Current.GoToAsync("AstronomicalBodyDetails?AstroName=Comet");
		btnEarth.Clicked += async (_, _) => await Shell.Current.GoToAsync("AstronomicalBodyDetails?AstroName=Earth");
		btnMoon.Clicked += async (_, _) => await Shell.Current.GoToAsync("AstronomicalBodyDetails?AstroName=Moon");
		btnSun.Clicked += async (_, _) => await Shell.Current.GoToAsync("AstronomicalBodyDetails?AstroName=Sun");
    }
}