using System;
using System.Collections.ObjectModel;

namespace RPGManager.Domain.Entities
{
    public class Campaign
    {
        public Guid Id { get; set; }
        public Collection<CharacterSheet> Characters { get; set; }
        public GameSystem GameSystem { get; set; }
    }
}