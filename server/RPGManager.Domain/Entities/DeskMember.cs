using System;

namespace RPGManager.Domain.Entities
{
    public class DeskMember
    {
        public DeskMember(Guid memberId, Guid deskId)
        {
            Id = Guid.NewGuid();
            MemberId = memberId;
            DeskId = deskId;
        }
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid DeskId { get; set; }
        public User Member { get; set; }
        public Desk Desk { get; set; }
    }
}