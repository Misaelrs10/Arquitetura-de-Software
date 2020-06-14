using MeuPrimeiroProjeto.Helpers;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuPrimeiroProjeto.Entities
{   
    [Table ("LOGIN")]

    public class Login
    {
        [Key]
        [Column("LGN_IDENTI")]

        public long Id { get; private set; }
        [Column ("LGN_LOGIN")]

        public String NickName { get; private set; }
        [Column("LGN_SENHA")]

        public string Pwd { get; private set; }

        protected Login() { }

        public Login (long id, string nickName, string pwd)
        {
            //VALIDACOES
            this.Validations(nickName: nickName, pwd:pwd);
            this.Id = id;
            this.NickName = nickName;
            this.Pwd = pwd;
        }

        

        private void Validations(string nickName, string pwd)
        {
            if (string.IsNullOrWhiteSpace(nickName)) throw new BusinessException(message: "Preencha o login.");
            if (string.IsNullOrWhiteSpace(pwd)) throw new BusinessException(message: "Preencha a senha.");
        }

    }
}
