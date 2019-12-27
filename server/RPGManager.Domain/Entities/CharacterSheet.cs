using System;
using RPGManager.Domain.ValueObjects;

namespace RPGManager.Domain.Entities
{
    public class CharacterSheet
    {
        //Identity
        public Guid Id { get; set; }
        
        //Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public HealthPoints HealthPoints { get; set; }
        public CharacterLevel Level { get; set; }
        
        public Guid UserId { get; set; }
        public int CharRaceId { get; set; }
        public int CharacterClassId { get; set; }
        public int CampaignId { get; set; }
        
        //Relationship
        public Campaign Campaign { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public User User { get; set; }
    }
}