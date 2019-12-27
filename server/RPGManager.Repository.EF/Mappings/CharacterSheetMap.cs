using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPGManager.Domain.Entities;

namespace RPGManager.Repository.EF.Mappings
{
    public class CharacterSheetMap : IEntityTypeConfiguration<CharacterSheet>
    {
        public void Configure(EntityTypeBuilder<CharacterSheet> builder)
        {
            builder
                .Property(charSheet => charSheet.HealthPoints.HP)
                .HasColumnName("");
        }
    }
}