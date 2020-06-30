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
        
        [Column("REST_NOME")]
        public string restName { get; private set; }
        
        [Column("REST_ENDERECO")]
        public string restEndereco { get; private set; }
        

        [Column("REST_VOTOS")]
        public long restVotos { get; private set; }
        


        [Column("REST_IMAGEM")]
        public string restImagem { get; private set; }
        

        protected Restaurante () {}

        public Restaurante(int id, string restname, string restendereco, long restvotos, string restimagem)
        {
            this.Id = id;
            this.restName = restname;
            this.restEndereco = restendereco;
            this.restVotos = restvotos;
            this.restImagem = restimagem;
        }
    }
}
