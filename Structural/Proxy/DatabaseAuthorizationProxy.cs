using System;

namespace Jarai.Patterns.Structural.Proxy
{
    public class DatabaseAuthorizationProxy : Database
    {
        private readonly Database _database;
        private bool _isAuthorized = false;

        public DatabaseAuthorizationProxy(Database database)
        {
            _database = database;
        }


        public override string GetData()
        {
            if (!_isAuthorized)
                throw new InvalidOperationException("Keine Berechtigung");

            return _database.GetData();
        }

        public void Login(string benutzer)
        {
            if (benutzer == "Admin")
                _isAuthorized = true;
        }
    }
}