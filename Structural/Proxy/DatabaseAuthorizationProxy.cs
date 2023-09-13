using System;

namespace Jarai.Patterns.Structural.Proxy
{
    public class DatabaseAuthorizationProxy : DatabaseServer
    {
        private readonly DatabaseServer _databaseServer;
        private bool _isAuthorized = false;

        public DatabaseAuthorizationProxy(DatabaseServer databaseServer)
        {
            _databaseServer = databaseServer;
        }


        public override string GetData()
        {
            if (!_isAuthorized)
                throw new InvalidOperationException("Keine Berechtigung");

            return _databaseServer.GetData();
        }

        public void Login(string benutzer)
        {
            if (benutzer == "Admin")
                _isAuthorized = true;
        }
    }
}