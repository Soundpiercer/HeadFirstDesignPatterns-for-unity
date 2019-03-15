namespace headfirst.decorator
{
    public class MachineGodBuff : Character
    {
        Character _character;

        public MachineGodBuff(Character character)
        {
            _character = character;
            _name = character._name + " (기계신의 가호)";
        }

        public override float GetPower()
        {
            return _character.GetPower() * 1.25f;
        }
    }
}