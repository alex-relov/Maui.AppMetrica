using Net.iOS.AppMetrica.Binding;

namespace Maui.AppMetrica;

public class AppMetricaMaui
{
    public static void Init(string apiKey)
    {
        AppMetricaBinding.Init(apiKey);
    }

    public static void Event(string eventName)
    {
        AppMetricaBinding.Event(eventName);
    }

    public static void Event(string eventName, string jsonValue)
    {
        AppMetricaBinding.Event(eventName);
    }
}
