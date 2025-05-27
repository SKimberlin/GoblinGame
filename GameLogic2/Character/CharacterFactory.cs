namespace GoblinMode.Character
{
    public abstract class CharacterFactory<T> where T : Character
    {
        public abstract T CreateCharacter();
    }
}
