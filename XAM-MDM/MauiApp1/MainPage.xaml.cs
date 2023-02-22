namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public const string MyMDMConfigKey = "MyMDMConfigKey";

    private readonly ManagedConfigurationProvider managedConfigurationProvider;

    public MainPage()
	{
		InitializeComponent();

		this.managedConfigurationProvider = new ManagedConfigurationProvider();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lblConfig.Text = managedConfigurationProvider.GetStringValue(MyMDMConfigKey);
    }

    private void OnBtnRefreshClicked(object sender, EventArgs e)
	{
        lblConfig.Text = managedConfigurationProvider.GetStringValue(MyMDMConfigKey);
    }
}

