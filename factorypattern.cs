public interface ICharacter
{
    void Attack();
    void Defend();
}

public class Warrior : ICharacter
{
    public void Attack()
    {
        // Saldırı işlemleri burada yer alabilir.
    }

    public void Defend()
    {
        // Savunma işlemleri burada yer alabilir.
    }
}

public class Mage : ICharacter
{
    public void Attack()
    {
        // Büyü saldırısı işlemleri burada yer alabilir.
    }

    public void Defend()
    {
        // Büyü savunması işlemleri burada yer alabilir.
    }
}

public class CharacterFactory
{
    public ICharacter CreateCharacter(CharacterType type)
    {
        switch (type)
        {
            case CharacterType.Warrior:
                return new Warrior();
            case CharacterType.Mage:
                return new Mage();
            default:
                return null;
        }
    }
}


// yusufortacdeveloper
