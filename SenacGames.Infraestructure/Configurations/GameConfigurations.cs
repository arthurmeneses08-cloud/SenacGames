using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenacGames.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infraestructure.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Game>
    {
        /// <summary>
        /// lâmbida
        /// </summary>
        /// <param name="builder" builder="game=g.Id"></param>
        public void Configure(EntityTypeBuilder<Game> builder )
        {
            builder.HasKey( g => g.Id );

            builder.Property(g = g => g.Title)
                .IsRequired()//Define que o campo é obrigatório
                .HasMaxLength(200);// Define um tamanho máximo para o campo

            builder.Property(g = g => g.Description)
                .HasMaxLength(2000);//Define um tamanho máximo para o campo

            builder.Property(g =>  g.CoverImageUrl)
                .HasMaxLength (500);// Define um tamanho máximo para o campo

            builder.HasOne(g => g.Category) // Um game tem uma categoria
                .WithMany(c => c.Games) //Uma categoria tem muitos jogos
                .HasForeignKey(g => g.Category) //A FK é CategoryId
                .OnDelete(DeleteBehavior.Restrict);  
        }
    }
}
