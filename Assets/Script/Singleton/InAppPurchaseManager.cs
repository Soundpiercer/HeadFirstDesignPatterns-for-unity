// [HEAD FIRST DESIGN PATTERNS - 05. SINGLETON PATTERN]
// 
// In App Purchase Manager
// Author : Soundpiercer
// soundpiercer@gmail.com
//
// 권장하는 보는 순서
// 1. Singleton Example Class의 Singleton 로직
// 2. In App Purchase Manager의 Singleton 로직
// 3. PurchaseButton.cs
// 4. In App Purchase Manager의 구매 프로세스
// 5. 실제 게임을 플레이해서 버튼을 눌렀을 때, 콘솔에 메시지가 찍히는 순서
// 
// 
// ※ Tip :
// 현업에서 싱글턴은 DataManager, In App Purchase Manager, Network Manager 등 게임의 코어적인 부분을 관리하는 매니저 오브젝트들에 매우 빈번하게 사용됩니다.
// 또한 이 코드에 쓰인 코루틴 역시 빈번하게 쓰이니 꼭 참고해 주세요.
// 
// 너무 자잘한 기능에까지 싱글턴을 적용하는 것은 좋지 않습니다 (정확히 말하면, 한 게임 안에 Manager가 너무 많을 필요가 없습니다)

using UnityEngine;

namespace headfirst.singleton
{
    /// <summary>
    /// 일반적인 Singleton class.
    /// 인스턴스의 갯수를 1개로 제한합니다.
    /// </summary>
    public class SingletonExampleClass
    {
        #region Singleton
        private static SingletonExampleClass instance;
        public static SingletonExampleClass Instance
        {
            // Lazy 호출 : 인스턴스가 처음으로 언급되면 그 때 가서 인스턴스를 생성합니다.
            get // <--- '언급' 을 의미
            {
                if (instance == null)
                    return new SingletonExampleClass();
                else
                    return instance;
            }
        }
        #endregion
    }

    /// <summary>
    /// MonoBehaviour의 경우 인스턴스가 하나더라도 복수의 게임오브젝트에서 메서드가 호출될 수 있으므로
    /// 게임오브젝트 역시 한 개로 제한하여야 합니다.
    /// </summary>
    public class InAppPurchaseManager : MonoBehaviour
    {
        #region Singleton
        public static InAppPurchaseManager Instance;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else if (Instance != this)
                Destroy(gameObject);

            // 인앱 결제를 담당하는 중요한 기능이므로, 매니저를 들고 있는 GameObject는 게임 씬이 바뀌더라도 늘 살아 있어야 합니다.
            DontDestroyOnLoad(gameObject);
        }
        #endregion

        /// <summary>
        /// 구매 중인가?
        /// </summary>
        public bool _isBuying;

        /// <summary>
        /// 실제 구매 프로세스.
        /// </summary>
        public void PurchaseProcess()
        {
            _isBuying = true;
            Debug.Log("[In App Purchase Manager] >>>>> 구매 시작");

            // 외부 플러그인 등에 의해 실제 구매가 이루어진다고 가정합니다.
            Invoke("ExternalPluginMethod", 2.0f);
        }

        private void ExternalPluginMethod()
        {
            Debug.Log("[In App Purchase Manager] >>>>> 구매 완료");
            _isBuying = false;
        }
    }
}