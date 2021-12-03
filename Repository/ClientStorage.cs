using mypracticework.Domain;
using System.Collections.Generic;

namespace mypracticework.Repository
{
    public class ClientStorage
    {
        private Dictionary<int, Client> Clients { get; } = new Dictionary<int, Client>();

        public void Create(Client client)
        {
            Clients.Add(client.ClientId, client);
        }

        public Client Read(int clientId)
        {
            return Clients[clientId];
        }

        public Client Update(int clientId, Client newClient)
        {
            Clients[clientId] = newClient;
            return Clients[clientId];
        }

        public bool Delete(int clientId)
        {
            return Clients.Remove(clientId);
        }
    }
}