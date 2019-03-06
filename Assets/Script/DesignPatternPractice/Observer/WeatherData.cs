using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.observer
{
    public class WeatherData : MonoBehaviour, ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;

        public void SetData(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            OnDataChanged();
        }

        private void OnDataChanged()
        {
            NotifyObservers();
        }

        /// <summary>
        /// Subject 인터페이스 구현
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.ReceiveDataUpdate(temperature, humidity, pressure);
            }
        }

        /// <summary>
        /// Subject 인터페이스 구현
        /// </summary>
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// Subject 인터페이스 구현
        /// </summary>
        public void RemoveObserver(IObserver o)
        {
            IObserver target = observers.Find(obs => obs.Equals(o));
            if (target != null)
                observers.Remove(target);
        }
    }
}