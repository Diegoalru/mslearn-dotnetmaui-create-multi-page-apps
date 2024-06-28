namespace Astronomy.Pages;

[QueryProperty(nameof(AstroName), "AstroName")]
public partial class AstronomicalBodyPage : ContentPage
{
    private string _astroName;
    public string AstroName
    {
        get => _astroName;
        set
        {
            _astroName = value;
            UpdateAstroBodyUi(_astroName);
        }
    }

    public AstronomicalBodyPage()
    {
        InitializeComponent();
    }

    private void UpdateAstroBodyUi(string astroName)
    {
        var body = FindAstroData(astroName);

        Title = body.Name;

        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }

    private static AstronomicalBody FindAstroData(string astronomicalBodyName)
    {
        return astronomicalBodyName switch
        {
            "Comet" => SolarSystemData.HalleysComet,
            "Earth" => SolarSystemData.Earth,
            "Moon" => SolarSystemData.Moon,
            "Sun" => SolarSystemData.Sun,
            _ => throw new ArgumentException("Invalid astronomical body name.")
        };
    }
}