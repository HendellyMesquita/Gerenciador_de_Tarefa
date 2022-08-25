using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;
using LinqToDB.Mapping;
using ColumnAttribute = LinqToDB.Mapping.ColumnAttribute;
using DataTypeAttribute = System.ComponentModel.DataAnnotations.DataTypeAttribute;
using TableAttribute = LinqToDB.Mapping.TableAttribute;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    [Table(Name = "GT_BN_Anotacoes")]
    public class Anotacao
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Column(Name = "Titulo"), NotNull]
        public string Titulo { get; set; }

        public string? Conteudo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string? DataCriacao { get; set; }

        public FonteDeNota? Fonte { get; set; }


    }
}
