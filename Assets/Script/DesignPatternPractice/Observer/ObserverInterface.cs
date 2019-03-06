using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void NotifyObservers();
    }

    public interface IObserver
    {
        void ReceiveDataUpdate(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        void Display();
    }
}
