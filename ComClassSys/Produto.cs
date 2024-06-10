using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodBarras { get; set; }
        public string Descricao { get; set; }
        public double ValoUnit { get; set; }
        public string UnidadeVenda { get; set; }
        public int Categoria { get; set; }
        public double CategoriaId { get; set; }
        public double EstoqueMinimo { get; set; }
        public double ClasseDesconto { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCad { get; set; }

        public Produto()
        {
            Id = 0;
        }
        public Produto(int id, string codBarras, string descricao, double valoUnit, string unidadeVenda, int categoria, double categoriaId, double estoqueMinimo, double classeDesconto, string imagem, DateTime dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValoUnit = valoUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
            DataCad = dataCad;
        }
        public Produto(string codBarras, string descricao, double valoUnit, string unidadeVenda, int categoria, double categoriaId, double estoqueMinimo, double classeDesconto, string imagem)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValoUnit = valoUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            CategoriaId = categoriaId;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            Imagem = imagem;
        }
        public Produto(string codBarras, string descricao, double valoUnit, string unidadeVenda, int categoria, double estoqueMinimo, double classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValoUnit = valoUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            ClasseDesconto = classeDesconto;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValoUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("sp_categoria_id", Categoria);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesconto);
        }
    }
}