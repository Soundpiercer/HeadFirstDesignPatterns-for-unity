using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.observer
{
    public class WeatherDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;

        // 책에 적힌 방식. 생성과 동시에 옵저버 등록.
        /*
        public WeatherDisplay(Subject s)
        {
            s.RegisterObserver(this);
        }
        */

        // 직관성 있게 개선한 방식.
        public void SetSubject(ISubject s)
        {
            s.RegisterObserver(this);
        }

        public void ReceiveDataUpdate(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            Debug.Log("현재 날씨 상황 전달드립니다. " + "온도 : " + temperature + " 습도 : " + humidity + " 기압 : " + pressure);
        }
    }
}