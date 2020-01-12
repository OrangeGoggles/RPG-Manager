using System;
using RPGManager.Domain.Commands;

namespace RPGManager.Domain.Desk.Commands
{
    public class AddNewDeskMemberCommand : ICommand
    {
        public Guid NewMemberId { get; set; }
        public Guid DeskId { get;  set; }
    }
}