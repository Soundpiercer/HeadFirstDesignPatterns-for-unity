namespace headfirst.factory
{
    

    /// <summary>
    /// 기본 피자 공장입니다.
    /// </summary>
    public class PizzaFactory
    {
        // static으로 만들면 팩토리를 인스턴스화하지 않아도 되나, 상속하여 쓸 수 없게 됩니다.
        public virtual Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Combination:
                    return new CombinationPizza();
                case PizzaType.Bulgogi:
                    return new BulgogiPizza();
                case PizzaType.Potato:
                    return new PotatoPizza();
                default:
                    return new DefaultPizza();
            }
        }
    }

    /// <summary>
    /// 뉴욕에서 쓰는 피자 공장입니다.
    /// </summary>
    public class NewYorkPizzaFactory : PizzaFactory
    {
        // static으로 만들면 팩토리를 인스턴스화하지 않아도 되나, 상속하여 쓸 수 없게 됩니다.
        public override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Combination:
                    return new CombinationPizza();
                case PizzaType.Bulgogi:
                    return new BulgogiPizza();
                case PizzaType.Potato:
                    return new NewYorkPotatoPizza();
                default:
                    return new DefaultPizza();
            }
        }
    }
}
