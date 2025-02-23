using Maui.AppMetrica;

namespace AppMetricaSample;

public partial class MainPage : ContentPage
{
	private readonly IAnalytic analytic;
	public MainPage(IAnalytic analytic)
	{
		this.analytic = analytic;
		InitializeComponent();
	}

	private void SendEvent(object sender, EventArgs e)
	{
		analytic.Event("Event from maui!");
	}

	private void CrashApp(object sender, EventArgs e)
	{
		throw new ArgumentException("Crash from maui app");
	}
}

