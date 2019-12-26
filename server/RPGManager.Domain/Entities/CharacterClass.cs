namespace RPGManager.Domain.Entities
{
    public class CharacterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GameSystemId { get; set; }

        public GameSystem GameSystem { get; set; }
    }
}