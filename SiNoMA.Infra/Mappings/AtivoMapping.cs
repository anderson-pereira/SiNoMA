﻿using SiNoMA.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    public class AtivoMapping : EntityTypeConfiguration<Ativo>
    {
        public AtivoMapping()
        {
            // define o nome da tabela
            ToTable("Ativo");

            // define o nome da coluna da tabela
            // define que a coluna seja autoincremente
            Property(x => x.ID)
                .HasColumnName("ATIV_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // define a chave primária
            HasKey(x => x.ID);

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Nome)
                .HasColumnName("ATIV_Nome")
                .HasMaxLength(60)
                .IsRequired();

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Descricao)
                .HasColumnName("ATIV_Descricao")
                .HasMaxLength(60)
                .IsRequired();

            // define um relacionamento deste tipo de entidade, neste caso é o Usuario
            HasRequired(x => x.Usuario) // um Ativo deve ter um Usuario associado a ele
                .WithMany(a => a.Ativos) // um Usuario pode ter muitos Ativos
                .Map(m => m.MapKey("USUA_ID")); // especifica o nome da coluna de chave estrangeira na tabela Ativo
        }
    }
}
