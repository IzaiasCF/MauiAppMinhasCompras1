﻿using MauiAppMinhasCompras1.Helpers;
using System.Globalization;

namespace MauiAppMinhasCompras1
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;
        public static SQLiteDatabaseHelper DB 
        {
            get 
            {
                if (_db == null) 
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _db = new SQLiteDatabaseHelper(path);
                }
                return _db;
            }            
        }
        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());
        }
    }
}
