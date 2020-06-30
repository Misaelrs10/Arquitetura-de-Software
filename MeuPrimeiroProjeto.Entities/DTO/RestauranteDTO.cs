using System;
using System.Collections.Generic;
using System.Text;

namespace MeuPrimeiroProjeto.Entities.DTO
{
    public class RestauranteDTO
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Endereco { get; set; }

        public long Votos { get; set; }

        public string Imagem { get; set; }

    }
}
