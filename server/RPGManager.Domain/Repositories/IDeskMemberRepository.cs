using System;
using RPGManager.Domain.Entities;

namespace RPGManager.Domain.Repositories
{
    public interface IDeskMemberRepository : IRepository
    {
        bool Exists(Guid userMemberId, Guid deskUserId);
        void Register(DeskMember newDeskSubscription);
    }
}