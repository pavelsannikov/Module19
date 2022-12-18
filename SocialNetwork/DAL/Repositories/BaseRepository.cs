﻿using Dapper;
using System.Data;
using System.Data.SQLite;

namespace SocialNetwork.DAL.Repositories
{
    public class BaseRepository
    {
        protected T QueryFirstOrDefault<T>(string sql, object parameters = null)
        {

            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        protected List<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.Query<T>(sql, parameters).ToList();
            }
        }

        protected int Execute(string sql, object parameters = null)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                return connection.Execute(sql, parameters);
            }
        }

        private IDbConnection CreateConnection()
        {
            /*
             
            С относительным путём не работает ни сама программа, ни тесты.
             
             */
            //return new SQLiteConnection("Data Source = DAL/DB/social_network.db; Version = 3");

            return new SQLiteConnection("Data Source = C:/Users/pavel/source/repos/SocialNetwork/SocialNetwork/DAL/DB/social_network.db");

        }
    }
}
