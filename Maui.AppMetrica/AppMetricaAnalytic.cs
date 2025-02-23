namespace Maui.AppMetrica;

public class AppMetricaAnalytic : IAnalytic
{
    public void Event(string eventName) => AppMetricaMaui.Event(eventName);

    public void Event(string eventName, string jsonValue) => AppMetricaMaui.Event(eventName);
}
