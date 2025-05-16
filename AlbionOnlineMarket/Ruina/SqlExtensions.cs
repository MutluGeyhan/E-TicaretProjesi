using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ruina.Extensions
{
    public static class SqlCommandExtensions
    {
        public static SqlCommand AddParameter(this SqlCommand command, string parameterName, object value)
        {
            command.Parameters.AddWithValue(parameterName, value);
            return command;
        }
    }
}