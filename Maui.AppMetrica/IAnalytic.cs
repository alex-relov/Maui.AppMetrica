namespace Maui.AppMetrica;

public interface IAnalytic
{
    void Event(string eventName);
    void Event(string eventName, string jsonValue);
}
