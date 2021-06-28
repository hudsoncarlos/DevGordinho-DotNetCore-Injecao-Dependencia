﻿
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PostGetModel.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }

        public string Twitter { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "A observação deve ter entre 5 e 50 caracteres")]
        [Required(ErrorMessage = "Preencha a observaão")]
        public string Observacao { get; set; }

        [Range(18,50,ErrorMessage = "A idade da pessoa deve ser entre 18 e 50 anos")]
        [Required(ErrorMessage = "Informe a idade")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O e-mail informado não é válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage = "O login deve possuir somente letras e deve ter de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O login deve ser preenchido")]
        [Remote("LoginUnico","Pessoa",ErrorMessage = "Este nome de login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha deve ser informada")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha",ErrorMessage = "As senha não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}