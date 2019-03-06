using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.decorator
{
    public class StarbucksCoffee : MonoBehaviour
    {
        private void Start()
        {
            // 스스로 답을 찾아보자. 모카가 얹어진 이후 왜 추가 설명이 붙지 않는가?

            // 에스프레소 음료 등장이요
            Drink espresso = new Espresso();
            Debug.Log(espresso.GetDescription());
            Debug.Log(espresso.Cost());

            // 모카토핑을 얹겠음
            espresso = new MochaTopping(espresso);
            Debug.Log(espresso.GetDescription());
            Debug.Log(espresso.Cost());



            // 하우스블렌드 등장이요
            Drink houseblend = new HouseBlend();
            Debug.Log(houseblend.GetDescription());
            Debug.Log(houseblend.Cost());

            // 모카토핑을 얹겠음
            houseblend = new MochaTopping(houseblend);
            Debug.Log(houseblend.GetDescription());
            Debug.Log(houseblend.Cost());
        }
    }
}