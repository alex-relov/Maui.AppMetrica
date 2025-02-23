# Maui.AppMetrica

## Install

[nuget package](https://www.nuget.org/packages/Net.Maui.AppMetrica/)

## Configuration

```
builder
    .UseMauiApp<App>()
	.AddAppMetrica("token here")
```

## using

```
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
```

