using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroProjeto.Entities
{
    [Table("RESTAURANTE")]

    public class Restaurante
    {

        [Key]
        [Column("REST_IDENT")]

        public long Id { get; private set; }
        [Column("REST_IDENT")]

        public String restName { get; private set; }
        [Column("REST_NOME")]

        public String restEndereco { get; private set; }
        [Column("REST_ENDERECO")]

        public int restVotos { get; private set; }
        [Column("REST_VOTOS")]

        protected Restaurante () {}

        public Restaurante(int id, string restName, string restEndereco, int restVotos)
        {
            Id = id;
            this.restName = restName;
            this.restEndereco = restEndereco;
            this.restVotos = restVotos;
        }
    }
}
