using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.singleton
{
    public class PurchaseButton : MonoBehaviour
    {
        public void Buy()
        {
            StartCoroutine(BuyEnumerator());
        }

        /// <summary>
        /// 보통 인앱 결제 등 부가 기능은 외부 플러그인에 의해 실행되는 경우가 많아, 코루틴을 활용하는 쪽이 좋습니다. 
        /// </summary>
        /// <returns>The enumerator.</returns>
        private IEnumerator BuyEnumerator()
        {
            Debug.LogWarning("구매가 완료될 때까지 버튼을 숨깁니다...");
            gameObject.GetComponent<RectTransform>().localScale = Vector3.zero;

            InAppPurchaseManager.Instance.PurchaseProcess();
            yield return new WaitUntil(() => InAppPurchaseManager.Instance._isBuying == false); // 람다 식. 오른쪽의 조건이 맞을 때까지 기다립니다.

            Debug.LogWarning("구매 완료, 버튼을 다시 표시합니다.");
            gameObject.GetComponent<RectTransform>().localScale = Vector3.one;
        }
    }
}