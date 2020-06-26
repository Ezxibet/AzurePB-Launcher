using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

static class Module_Segurança
{
    public static string TextoMD5(string Senha)
    {
        MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
        byte[] bytHash;
        string hash = string.Empty;
        bytHash = provider.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Senha));
        provider.Clear();
        hash = BitConverter.ToString(bytHash).Replace("-", string.Empty);
        return hash.ToLower();
    }
    public static void Login(string usuario, string senha)
    {
        bool acesso;
        var Conectar = new MySqlConnection();
        Conectar.ConnectionString = "server=localhost; User ID=root; password=; database=";
        Conectar.Open();
        MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        var SqlQuary = "SELECT * From tab_accounts WHERE Usuario='" + usuario + "' AND Senha= '" + senha + "';";
        MySqlCommand Command = new MySqlCommand();
        Command.Connection = Conectar;
        Command.CommandText = SqlQuary;
        MyAdapter.SelectCommand = Command;
        MySqlDataReader Mydata;
        Mydata = Command.ExecuteReader;
        if (Mydata.HasRows == 0)
            acesso = false;
        else
            acesso = true;
        Conectar.Close();
        return acesso;
    }
}
