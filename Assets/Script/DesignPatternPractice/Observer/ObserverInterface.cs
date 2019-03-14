namespace headfirst.observer
{
    public interface IObservableSubject
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }

    public interface IObserver
    {
        void ReceiveDataUpdate(float temp, float humidity, float pressure);
    }
}