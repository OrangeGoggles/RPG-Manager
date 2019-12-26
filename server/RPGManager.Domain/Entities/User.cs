using System;
using System.Collections.ObjectModel;

namespace RPGManager.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public Collection<DeskMember> DeskMembers { get; set; }
    }
}