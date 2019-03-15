namespace headfirst.factory
{
    /// <summary>
    /// Pizza Store의 뉴욕 버전 서브클래스.
    /// </summary>
    public class NewYorkPizzaStore : PizzaStore
    {
        // 변수의 오버라이딩은 new 키워드를 사용합니다.
        protected new PizzaFactory pizzaFactory = new NewYorkPizzaFactory();
    }
}