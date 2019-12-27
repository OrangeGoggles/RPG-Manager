using System;
using RPGManager.Domain.Commands;

namespace RPGManager.Domain.Combat.Commands
{
    public class HealGameCharacterCommand : ICommand
    {
        public Guid CharacterSheetId { get; set; }
    }
}