﻿using System;
using Xamarin.Forms;
using XF.LocalDB.iOS;
using System.IO;
using XF.LocalDB.Data;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace XF.LocalDB.iOS
{
    public class SQLite_iOS : IDependencyServiceSQLite
    {
        public SQLite_iOS()
        {
        }
        public SQLite.SQLiteConnection GetConexao()
        {
            var arquivodb = "fiapdb.db3";
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string bibliotecaPessoal = Path.Combine(caminho, "..", "Library");
            var local = Path.Combine(bibliotecaPessoal, arquivodb);
            var conexao = new SQLite.SQLiteConnection(local);
            return conexao;
        }
    }
}