
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ManageRefreshTokens
    {
        public static List<RefreshTokenEntity> ListRefreshTokens()
        {
            return RefreshTokensProvider.List(p => true);
        }


        public static bool NewRefreshToken(RefreshTokenEntity notification)
        {
            return RefreshTokensProvider.Add(notification);
        }

        public static bool DeleteRefreshToken(RefreshTokenEntity notification)
        {
            return RefreshTokensProvider.Remove(notification);
        }

        public static bool ModifyRefreshToken(RefreshTokenEntity notification)
        {

            return RefreshTokensProvider.Modify(notification);
        }
    }
}
