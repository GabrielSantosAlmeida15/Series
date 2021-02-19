﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Series
{
    class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, Genero  genero, string  titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }

        public string RetornaTitulo()
        {
            return Titulo;
        }

        public int RetornaId()
        {
            return Id;
        }

        public override string ToString()
        {
            return "Genero" + Genero + Environment.NewLine +
                    "Titulo" + Titulo + Environment.NewLine +
                    "Descrição" + Descricao + Environment.NewLine +
                    "Ano" + Ano + Environment.NewLine;
                


        }
    }
}
