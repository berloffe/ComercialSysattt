using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        List<ItemPedido> Itens { get; set; }

        public Pedido() { }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }

        public Pedido (Usuario usuario, Cliente cliente, DateTime data, string status, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }

        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime data, string status, double desconto, List<ItemPedido> itens)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
            Itens = itens;
        }
        

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            cmd.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            cmd.Parameters.AddWithValue("spstatus_id", Status);
            cmd.Parameters.AddWithValue("spdesconto_id",Desconto);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static List<Pedido> ObterPorId(int   Clienteid)
        {
            Pedido pedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where cliente_id = {Clienteid}";
            var dr = cmd.ExecuteReader();
            while(dr.Read()) 
            {
                pedido = new(dr.GetInt32(0),
                         Usuario.ObterPorId(dr.GetInt32(1)),
                         Cliente.ObterPorId(dr.GetInt32(2)),
                         dr.GetDateTime(3),
                         dr.GetString(4),
                         dr.GetDouble(5),
                         ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    );
            }
            return pedido;
        }

        public static List<Pedido> ObterPorCliente(int ClienteId)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where cliente_id = {ClienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(dr.GetInt32(0)
                    , Usuario.ObterPorId(dr.GetInt32(1))
                    , Cliente.ObterPorId(dr.GetInt32(2))
                    , dr.GetDateTime(3)
                    , dr.GetString(4)
                    , dr.GetDouble(5)
                    , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    ));
            }
            return pedidos;
        }

        public static List<Pedido> ObterLista(string status = "")
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            if (status == "")
            {
                cmd.CommandText = $"select from pedidos";
            }
            else 
            { 
                cmd.CommandText = $"select * from pedidos where status = {status}";
            }
            cmd.CommandText = $"select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(dr.GetInt32(0)
                    , Usuario.ObterPorId(dr.GetInt32(1))
                    , Cliente.ObterPorId(dr.GetInt32(2))
                    , dr.GetDateTime(3)
                    , dr.GetString(4)
                    , dr.GetDouble(5)
                    , ItemPedido.ObterListaPorPedido(dr.GetInt32(0))
                    ));
            }
            return pedidos;
        }
        public bool Alterar()
        {
            var com = Banco.Abrir();
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = "sp_pedido_update";
            com.Parameters.AddWithValue("spid", Id);
            com.Parameters.AddWithValue("spusuario_id", Usuario.Id);
            com.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            com.Parameters.AddWithValue("spstatus", Status);
            com.Parameters.AddWithValue("spdesconto", Desconto);
            return com.ExecuteNonQuery()>0?true:false;
        }
        public bool Alterar(string status)
        {
            var com = Banco.Abrir();
            com.CommandText = $"update pedidos set status =`{status} where id = {Id}";
            return com.ExecuteNonQuery() > 0 ? true : false;
        }

        public double CalcularPedido(int id)
        {

            return 0.0;
        }

    }
}
