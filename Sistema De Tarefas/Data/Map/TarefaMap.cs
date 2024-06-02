using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema_De_Tarefas.Models;


namespace SitemaDeTarefas.Data.Map
{

    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Status).IsRequired();
        }
    }





}


