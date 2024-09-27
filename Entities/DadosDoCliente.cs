using System;
using System.Collections.Generic;
using Entidades_E_Enumeracao.Entities.Enums;


namespace Entidades_E_Enumeracao.Entities
{
    internal class DadosDoCliente
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        public FormaDePagamento FormaDePagamento { get; set; }  

        public List<Cacambas>ListaDeCacambas { get; set; }=new List<Cacambas>();

        public DadosDoCliente() { }

        public DadosDoCliente(string name, string cpf, string endereco, string email, string celular, FormaDePagamento formaDePagamento)
        {
            Name = name;
            Cpf = cpf;
            Endereco = endereco;
            Email = email;
            Celular = celular;
            FormaDePagamento = formaDePagamento;
        }
        public void AddCacambasLista(Cacambas value)
        {
            ListaDeCacambas.Add(value);
        }
        public void RemoveCacambasLista(Cacambas value)
        {
            ListaDeCacambas.Remove(value);
        }

        public override string ToString()
        {
            return "CLIENTE:"
                +Name
                +", "
                +Cpf
                +", "
                +Endereco
                +", "
                +Email
                +", "
                +Celular
                +", "
                +FormaDePagamento;
        }
    }
}
