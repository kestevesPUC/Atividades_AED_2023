using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _17_08
{
    class Aluno
    {
        private string nome;
        private int idade;
        private double peso;
        private bool formando;
        private char sexo;

        

        public Aluno(string nome, int idade, double peso, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.sexo = sexo;
            this.formando = false;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public double getPeso()
        {
            return this.peso;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public char getSexo()
        {
            return this.sexo;
        }
        public void setFormando(bool formando)
        {
            this.formando = formando;
        }

        public bool getFormando()
        {
            return this.formando;
        }
    }
}
