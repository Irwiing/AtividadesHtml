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
    public class PerifericoData : IPerifericoData
    {
        private ConnectionDB _conn;
        public bool Delete(int id)
        {
            bool status = false;
            string sql = $"delete from periferico where id = {id} ";

            using (_conn = new ConnectionDB())
            {
                status = _conn.ExecQuery(sql);
            }
            return status;
        }

        public bool Insert(Periferico periferico)
        {
            bool status = false;
            string sql = $"INSERT INTO periferico (descricao, tipo, marca, valor) VALUES ('{periferico.Descricao}','{periferico.Tipo}','{periferico.Marca}','{periferico.Valor}')";

            using (_conn = new ConnectionDB())
            {
                status = _conn.ExecQuery(sql);
            }
            return status;
        }

        public List<Periferico> Select()
        {
            string sql = $"SELECT id, descricao, tipo, marca, valor FROM periferico";

            using (_conn = new ConnectionDB())
            {
                var returnData = _conn.ExecQueryReturn(sql);
                return TransformSQLReaderToList(returnData);
            }
        }

        public Periferico Select(int id)
        {
            string sql = $"SELECT id, descricao, tipo, marca, valor FROM periferico";

            using (_conn = new ConnectionDB())
            {
                var returnData = _conn.ExecQueryReturn(sql);
                return TransformSQLReaderToList(returnData)[0];
            }
        }

        public bool Update(Periferico periferico)
        {
            bool status = false;
            string sql = $"UPDATE periferico SET descricao = '{periferico.Descricao}', " +
                $"tipo = '{periferico.Tipo}', " +
                $"marca = '{periferico.Marca}', " +
                $"valor = {periferico.Valor} WHERE id = {periferico.Id}";

            using (_conn = new ConnectionDB())
            {
                status = _conn.ExecQuery(sql);
            }
            return status;
        }
    
        private List<Periferico> TransformSQLReaderToList(SqlDataReader returnData)
        {
            var list = new List<Periferico>();

            while (returnData.Read())
            {
                var item = new Periferico()
                {
                    Id = int.Parse(returnData["id"].ToString()),
                    Descricao = returnData["descricao"].ToString(),
                    Marca = returnData["marca"].ToString(),
                    Tipo = returnData["tipo"].ToString(),
                    Valor = decimal.Parse(returnData["valor"].ToString())
                };

                list.Add(item);
            }
            return list;
        }
    }
}
