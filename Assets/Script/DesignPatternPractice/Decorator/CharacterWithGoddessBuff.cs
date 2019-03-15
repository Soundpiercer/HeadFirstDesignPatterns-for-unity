namespace headfirst.decorator
{
    public class GoddessBuff : Character
    {
        Character _character;

        public GoddessBuff(Character character)
        {
            _character = character;
            _name = character._name + " (여신의 가호)";
        }

        public override float GetPower()
        {
            return _character.GetPower() * 1.2f;
        }
    }
}