using Avanade.SubTCSE.Projeto.Application.DTOs.Base;
using System;

namespace Avanade.SubTCSE.Projeto.Application.DTOs.Employee
{
    public class EmployeeDTO : BaseDTO
    {
        public string PrimeiroNome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime Aniversario { get; set; }

        public bool Ativo { get; set; }

        public decimal Salario { get; set; }

        public EmployeeRole.EmployeeRoleDTO Cargo { get; set; }
    }
}
