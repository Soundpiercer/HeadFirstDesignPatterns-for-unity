using System.Collections.Generic;
using UnityEngine;

namespace headfirst.observer
{
    public class WeatherDataManager : MonoBehaviour, IObservableSubject
    {
        private List<IObserver> _observerList = new List<IObserver>();

        private float _temperature;
        private float _humidity;
        private float _pressure;

        /// <summary>
        /// IObservableSubject 인터페이스를 구현
        /// 옵저버 속성이 붙은 오브젝트를 리스트에 등록해 둡니다.
        /// </summary>
        public void RegisterObserver(IObserver o)
        {
            _observerList.Add(o);
        }

        /// <summary>
        /// IObservableSubject 인터페이스를 구현
        /// 옵저버 속성이 붙은 오브젝트가 리스트에 있으면, 리스트에서 뺍니다.
        /// </summary>
        public void RemoveObserver(IObserver o)
        {
            IObserver target = _observerList.Find(obs => obs.Equals(o)); // 람다 식. 오른쪽과 같은 의미입니다. IObserver target; foreach (IObserver obs in observerList) { if (obs.Equals(o)) target = obs; }
            if (target != null)
                _observerList.Remove(target);
        }

        public void SetData(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            NotifyObservers();
        }

        /// <summary>
        /// IObservableSubject 인터페이스를 구현
        /// 데이터가 변경되면 리스트에 있는 옵저버들에게 데이터를 던집니다.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver o in _observerList)
            {
                o.ReceiveDataUpdate(_temperature, _humidity, _pressure);
            }
        }
    }
}