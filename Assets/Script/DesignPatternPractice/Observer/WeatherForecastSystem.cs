using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.observer
{
    public class WeatherForecastSystem : MonoBehaviour
    {
        public WeatherData weatherData;

        private void Start()
        {
            // 책에 적힌 방식. 
            //WeatherDisplay weatherDisplay = new WeatherDisplay(weatherData);

            // 직관성 있게 개선한 방식. 여기만 보면 모든 관리시스템 파악 가능.
            WeatherDisplay weatherDisplay = new WeatherDisplay();
            weatherDisplay.SetSubject(weatherData);

            weatherData.SetData(30, 65, 34);
            weatherData.SetData(32, 70, 29);
            weatherData.SetData(31, 90, 29);

            weatherData.RemoveObserver(weatherDisplay);

            // Nothing Happens!
            weatherData.SetData(41, 90, 29);
        }
    }
}