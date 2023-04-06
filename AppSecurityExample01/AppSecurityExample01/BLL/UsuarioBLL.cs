using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppSecurityExample01.BLL
{
    public class UsuarioBLL
    {
        public bool Login(string login, string senha)
        {
            using (SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Exemplo;Data Source=.;"))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE Login = @login AND Senha = @senha", conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                conn.Open();

                int result = (int)cmd.ExecuteScalar();

                return result > 0;
            }
        }
    }
}