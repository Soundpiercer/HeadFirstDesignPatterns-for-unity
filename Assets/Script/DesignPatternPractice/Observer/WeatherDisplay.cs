using UnityEngine;

namespace headfirst.observer
{
    public class WeatherDisplay : IObserver
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        // 구독 시작. 책에 적힌 방식. 생성과 동시에 옵저버 등록.
        /*
        public WeatherDisplay(Subject s)
        {
            s.RegisterObserver(this);
        }
        */

        // 구독 시작. 직관성 있게 개선한 방식.
        public void Subscribe(IObservableSubject s)
        {
            s.RegisterObserver(this);
        }

        // 구독 해제.
        public void UnSubscribe(IObservableSubject s)
        {
            s.RemoveObserver(this);
        }

        // WeatherDataManager의 변경사항을 알립니다.
        public void ReceiveDataUpdate(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Debug.Log("현재 날씨 상황 전달드립니다. " + "온도 : " + _temperature + " 습도 : " + _humidity + " 기압 : " + _pressure);
        }
    }
}