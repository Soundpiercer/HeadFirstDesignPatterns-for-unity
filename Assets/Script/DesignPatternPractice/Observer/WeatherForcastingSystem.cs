// [HEAD FIRST DESIGN PATTERNS - 02. OBSERVER PATTERN]
// 
// Weather Forecasting System
// Author : Soundpiercer
// soundpiercer@gmail.com
//
// 권장하는 보는 순서
// 1. Weather Forecasting System
// 2. Weather Data Manager
// 3. Weather Display
// 4. Interface

using UnityEngine;

namespace headfirst.observer
{
    public class WeatherForcastingSystem : MonoBehaviour
    {
        // 매니저를 들고 있는 게임오브젝트에 연결되어 있습니다.
        public WeatherDataManager weatherDataManager;

        private void Start()
        {
            // 구독 시작. 책에 적힌 방식. 
            //WeatherDisplay weatherDisplay = new WeatherDisplay(weatherData);

            // 구독 시작. 직관성 있게 개선한 방식.
            WeatherDisplay weatherDisplay = new WeatherDisplay();
            weatherDisplay.Subscribe(weatherDataManager);

            weatherDataManager.SetData(30, 65, 34);
            weatherDataManager.SetData(32, 70, 29);
            weatherDataManager.SetData(31, 90, 29);

            // 구독 해제.
            weatherDisplay.UnSubscribe(weatherDataManager);

            // Then Nothing Happens!
            weatherDataManager.SetData(41, 90, 29);
        }
    }
}