using System;
using System.Globalization;

namespace Secao05
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get;  private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome;  }
            set { 
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /* public double Preco
        {
            get { return Preco; }
        }

        public int Quantidade { get { return Quantidade; } } 
        
        -=-=-==-=-=-==-=-=-==-=-

        /* public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return Preco;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        } */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;

        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
