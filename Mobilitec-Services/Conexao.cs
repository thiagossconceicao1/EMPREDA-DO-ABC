﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Mobilitec_Services
{
    class Conexao
    {
        private static string connString = "Server=localhost;Port=3306;Database=dbAquiseulixo;Uid=AquiSeuLixo;Pwd=123456";

        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(connString);

            conn.Open();

            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }


    }
}
