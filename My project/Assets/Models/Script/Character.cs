public class Personaggio
{
    private int maxHealth;
    private int health;


    public int MaxHealth
    {
        get { return maxHealth; }
        set
        {
            if (value < 0)
            {
                maxHealth = 0;
            }
            else
            {
                maxHealth = value;
            }
            // Assicurati che Health non superi il nuovo MaxHealth
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
    }
    public int Health
    {
        get { return health; }
        set
        {
            if (value < 0)
            {
                health = 0;
            }
            else if (value > maxHealth)
            {
                health = maxHealth;
            }
            else
            {
                health = value;
            }
        }
    }

    private int damage;
    public int Damage
    {
        get { return damage; }
        set
        {
            if (value < 0)
            {
                damage = 0;
            }
            else
            {
                damage = value;
            }
        }

    }
}