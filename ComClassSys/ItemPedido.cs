using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class ItemPedido
    {


        //    id int (4) AI PK
        //pedido_id int(11)
        //produto_id int(11)
        //valor_unit decimal (10,2)
        //quantidade decimal (10,2)
        //desconto decimal (10,2)

        // PROPRIEDADES
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        // CONSTRUTORES

        public ItemPedido() { }

        public ItemPedido(int id, Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }



        // MÉTODOS DE MANTER
        //Inserir Item
        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sp_pedido_id", Pedido.Id);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade_id", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto_id", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

        // Consultar Itemn de pedido (Obter por id ped e id prod)
        public static ItemPedido ObterItem(int idPedido, int idProduto = 0)
        {
            ItemPedido itemPedido = new();

            return itemPedido;

        }

        public static List<ItemPedido> ObterListaPorPedido(int idPedido)
        {
            List<ItemPedido> itens = new();

            return itens;
        }

        // Alterar item
        public bool Alterar(int id)
        {


            return true;
        }

        // Excluir
        public void Remover(int id)
        {
            var cmd = Banco.Abrir;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }
    }
}
