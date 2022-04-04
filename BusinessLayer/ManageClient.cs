
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ManageClient
    {
        public static List<ClientEntity> ListClients()
        {
            return ClientProvider.List(p => true);
            //  return null;
        }


        public static bool NewClient(ClientEntity client)
        {
            return ClientProvider.Add(client);
        }

        public static bool DeleteClient(ClientEntity client)
        {
            return ClientProvider.Remove(client);
        }

        public static bool ModifyClient(ClientEntity client)
        {

            return ClientProvider.Modify(client);
        }
    }
}
