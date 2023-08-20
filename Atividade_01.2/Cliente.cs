using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_01._2
{
    class Cliente
    {
        private string nome;
        private int codigo;
        private bool eClienteEspecial;
        private double limiteCredito;

        public Cliente(string nome, int codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.limiteCredito = 0;
            this.eClienteEspecial = false;
        }

        public bool atualizarLimite(double novoLimite)
        {
            if(eClienteEspecial)
            {
                this.limiteCredito = novoLimite;
                return true;
            }
            return false;
        }

        public void atualizarCategoria(bool valor)
        {
            if (!valor)
            {
                this.limiteCredito = 0;
            }
            this.eClienteEspecial = valor;
        }

        public string getNome()
        {
            return nome;
        }
        public int getCodigo()
        {
            return codigo;
        }
    }
}
