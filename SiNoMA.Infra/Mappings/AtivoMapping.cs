﻿using SiNoMA_MVC.Models;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    public class AtivoMapping : EntityTypeConfiguration<Ativo>
    {
        public AtivoMapping()
        {
            //Inforam qual será o nome da tabela.
            ToTable("Ativo");

            //Informa qual será a chave primária.
            HasKey(x => x.ID);

            //Informa as características para a propriedade ter no máximo 60 caracteres e é obrigatória.            
            Property(x => x.Nome).HasMaxLength(60).IsRequired();

            //Informa as características para a propriedade ter no máximo 60 caracteres e é obrigatória.            
            Property(x => x.Descrisao).HasMaxLength(60).IsRequired();
        }
    }
}
