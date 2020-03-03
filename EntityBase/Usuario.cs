using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EntityBase
{
    public class Usuario : Base<Usuario>, IUsuario
    {
        public Usuario(DateTime _dataInclusao, DateTime _dataAlteracao, string _login, string _senha) : base(_dataInclusao, _dataAlteracao)
        {
            Senha = _senha;
            Login = _senha;
        }

        public string Login { get; private set; }
        public string Senha { get; private set; }
        public string HashSenha
        {
            get
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    return GetMd5Hash(md5Hash, Senha);
                }
            }
        }

        private string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            StringBuilder sBuilder = new StringBuilder();
            
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
