﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulMV.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Estoque()
        {
        }

        public Estoque(int codigo, string nome)
        {
            Id = codigo;
            Nome = nome;
        }
    }
}
