﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BesyProject.Models
{
    public class Empresa
    {
        public long EmpresaId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public long Telefone { get; set; }
        public long Cnpj { get; set; }
        public string Especialidade { get; set; }
        public int ServicoId { get; set; }
        public Servico Servico { get; set; }
       
    }
}