namespace RPGManager.Domain.ValueObjects
{
    public class HealthPoints
    {
        public int HP { get; private set; }

        public HealthPoints(int healthPoints)
        {
            HP = healthPoints;
        }

        public void Damage(int damage)
        {
            HP -= damage;
        }

        public void Heal(int heal)
        {
            HP += heal;
        }
    }
}