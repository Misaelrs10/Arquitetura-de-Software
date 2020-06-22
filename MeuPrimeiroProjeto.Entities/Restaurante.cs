using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroProjeto.Entities
{   
    [Table ("RESTAURANTE")]

    public class Restaurante
    {
        [Key]
        [Column ("REST_IDENT")]

        public long Id { get; private set; }
        [Column ("REST_IDENT")]

        public String Name { get; private set; }
        [Column ("REST_NOME")]


        public String Endereco { get; private set; }
        [Column ("REST_ENDERECO")]

        public String Votos { get; private set; }
        [Column("REST_VOTOS")]

    }
}
