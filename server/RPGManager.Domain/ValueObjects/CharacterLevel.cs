using System;

namespace RPGManager.Domain.ValueObjects
{
    public class CharacterLevel
    {
        public int Level { get; private set; }
        public long Experience { get; private set; }

        public CharacterLevel(int level, long experience)
        {
            Level = level;
            Experience = experience;
        }

        public void AddExperience()
        {
            //TODO: Criar metódo de crédito de experiência
            throw new NotImplementedException();
        }

        public void Levelup()
        {
            //TODO: Criar metódo de subir de nível
            throw new NotImplementedException();
        }

        public void RemoveExperience()
        {
            //TODO: Criar metódo de débito de experiência
            throw new NotImplementedException();
        }
        
    }
}