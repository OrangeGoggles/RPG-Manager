using System;
using System.Collections.ObjectModel;

namespace RPGManager.Domain.Entities
{
    public class Desk
    {
        public Guid Id { get; set; }
        public Collection<Campaign> Campaigns { get; set; }
        
        public Collection<DeskMember> DeskMembers { get; set; }
    }
}