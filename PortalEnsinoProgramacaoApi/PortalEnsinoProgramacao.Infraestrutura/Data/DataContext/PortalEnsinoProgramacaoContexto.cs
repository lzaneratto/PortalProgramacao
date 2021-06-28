using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Infraestrutura.Data.DataContext
{
    public class PortalEnsinoProgramacaoContexto : IDisposable
    {
        private IConfiguration _configuration { get; set; }

        public MySqlConnection Connection { get; }

        private MySqlConnection _connection { get; set; }

        private bool _disposed { get; set; }


        public PortalEnsinoProgramacaoContexto(IConfiguration configuration)
        {
            _configuration = configuration;
            Initializer();
            _connection.Open();
            Connection = _connection;
        }


        private void Initializer()
        {
            string sqlConnectionStringName = _configuration["MySqlConnectionString"];
            _connection = new MySqlConnection(_configuration[sqlConnectionStringName]);            
        }


        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this); 
        }

        private void dispose(bool v)
        {
            if(!_disposed)
            {
                _disposed = true;
            }
        }

        ~PortalEnsinoProgramacaoContexto() { }
    }
}
