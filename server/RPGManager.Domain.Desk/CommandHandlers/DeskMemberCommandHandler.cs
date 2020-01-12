using RPGManager.Domain.Commands;
using RPGManager.Domain.Desk.Commands;
using RPGManager.Domain.Entities;
using RPGManager.Domain.Repositories;

namespace RPGManager.Domain.Desk.CommandHandlers
{
    public class DeskMemberCommandHandler : ICommandHandler<AddNewDeskMemberCommand>
    {
        private readonly IDeskMemberRepository _deskMemberRepostory;
        public DeskMemberCommandHandler(IDeskMemberRepository deskMemberRepository)
        {
            _deskMemberRepostory = deskMemberRepository;
        }
        public void Handle(AddNewDeskMemberCommand command)
        {
            if(_deskMemberRepostory.Exists(command.NewMemberId,  command.DeskId)){
                throw new System.Exception("Usuario ja faz parte da mesa");
            }
            
            var newDeskSubscription = new DeskMember(command.NewMemberId, command.DeskId);

            _deskMemberRepostory.Register(newDeskSubscription);
            _deskMemberRepostory.Commit();
        }
    }
}