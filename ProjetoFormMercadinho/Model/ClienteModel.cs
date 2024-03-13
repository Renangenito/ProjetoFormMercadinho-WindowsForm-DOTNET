using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFormMercadinho.Model
{
    internal class ClienteModel : EnderecoModel
    {
        
            public string Cpf { get; set; }
            public string Rg { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Celular { get; set; }
            public DateTime DataInclusao { get; set; }
            public DateTime DataAlteracao { get; set; }
            public bool Ativo { get; set; }

        
    }
}
