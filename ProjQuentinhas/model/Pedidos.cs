using System.Collections.Generic;
using System.Globalization;

namespace ProjQuentinhas.model
{
    class Pedidos
    {
        List<Produto> produtos = new List<Produto>();
        public int Qtd_produtos { get; set; }
        public double Taxa_entrega { get; set; }


        public Pedidos()
        {

        }

        public Pedidos(double taxa_entrega)
        {
            Taxa_entrega = taxa_entrega;
        }

        public void addProduto(Produto p)
        {
            produtos.Add(p);
            Qtd_produtos++;
        }

        public void removeProduto(int p)
        {
            produtos.RemoveAt(p-1);
            Qtd_produtos--;
        }

        public double total()
        {
            double total = 0.0;
            foreach (Produto p in produtos)
            {
                total += p.Valor;
            }

            return Qtd_produtos > 4 ? total - (total * 0.0215) : total;
        }

        public string imprimeProdutos()
        {
            string s = "";
            int cont = 1;
            foreach (Produto p in produtos)
            {
                s += $"{cont}. " + p.ToString() + "\r\n";
                cont++;
            }

            s += "Taxa de entrega: R$ " 
                + Taxa_entrega.ToString("F2", CultureInfo.InvariantCulture)
                + "\r\n total: R$ "
                + total().ToString("F2", CultureInfo.InvariantCulture);
                

            return s;
        }


    }
}
