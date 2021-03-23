using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Data
{
    class CarrinhoData : ICarrinhoData
    {
       /* private ConnectionDB _conn;
        public bool Delete(int id)
        {
            bool status = false;
            string sql = $"delete from carrinho where id = {id} ";

            using (_conn = new ConnectionDB())
            {
                status = _conn.ExecQuery(sql);
            }
            return status;
        }

        public bool Insert(Carrinho carrinho)
        {
            throw new NotImplementedException();
        }

        public List<Carrinho> Select()
        {
            string sql = $"SELECT id, descricao, tipo, marca, valor FROM carrinho";

            using (_conn = new ConnectionDB())
            {
                var returnData = _conn.ExecQueryReturn(sql);
                return TransformSQLReaderToList(returnData);
            }
        }

        public Carrinho Select(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Carrinho carrinho)
        {
            throw new NotImplementedException();
        }

        private List<Carrinho> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var list = new List<Carrinho>();

            while (returnData.Read())
            {
                var item = new Carrinho()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Descricao = returnData["descricao"].ToString(),
                };

                list.Add(item);
            }
            return list;
        }*/
    }
}
