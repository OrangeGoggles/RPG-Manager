namespace RPGManager.Domain.Entities
{
    public class CharacterRace
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int GameSystemId { get; set; }

        public GameSystem GameSystem { get; set; }
    }
}