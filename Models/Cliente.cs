using System.ComponentModel.DataAnnotations;

namespace MeuCadastroClientesMvc.Models
{
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }
    }
}

