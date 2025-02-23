namespace Maui.AppMetrica;

public static class Extensions
{
    /// <summary>
    /// Initialize AppMetrica and register services
    /// </summary>
    /// <param name="appBuilder"></param>
    /// <param name="apiKey">SDK api key</param>
    /// <returns></returns>
    public static MauiAppBuilder AddAppMetrica(this MauiAppBuilder appBuilder, string apiKey)
    {
        AppMetricaMaui.Init(apiKey);
        appBuilder.Services.AddTransient<IAnalytic, AppMetricaAnalytic>();
        return appBuilder;
    }
}
