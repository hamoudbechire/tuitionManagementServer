using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public enum NotificationTypes
    {
        @All,
        @Statut,
        @ProductReviews,
        @Order,
        @ExternalDelivery
    }

    public enum CartSatus
    {
        @Created,
        @Submitted,

    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderSatus
    {
        @submitted,
        @accepted,
        @refused,
        @delivred,
        @paid,
        @cancelled,
        @indelivery,
        @paidSeller,
        @customerWithdrawal,
    }
    public enum ApplicationTypes
    {
        JavaScript = 0,
        NativeConfidential = 1
    }

    public enum FeeType
    {
        @Commission,
        @Delivery
    }
    public enum FeeTypeValue
    {
        @Percent,
        @Value
    }
    public enum AccountActionType
    {
        @restPassword,
        @enableAcccount
    }

    public enum CodeStatus
    {
        Sent,
        ToBeSent,
        AlreadyUsed
    }
    public enum DatabaseConnectionMode
    {
        LocalDb,
        SqlServer
    }

    public enum Note
    {
        @VeryUsless = -2,
        @Usless = -1,
        @Medium = 0,
        @Useful = 1,
        @VeryUseful = 2
    }

    public enum Rating
    {
        @VeryBad = 1,
        @Bad = 2,
        @Good = 3,
        @VeryGood = 4,
        @Excellent = 5,
    }

    public enum MediaType
    {
        @File,
        @Video,
        @Document,
        @Image
    }
    public enum TypesOfNotifications
    {
        @ProductReviews,
        @Order,
        @Statut,
        @ExternalDelivery
    }
    public enum UserType
    {
        @Customer,
        @Seller,
        @DeliveryMan,
        @Admin,
        @ExternalDelivery,
        @CustomerDelivery,
    }

    public enum UserLoginType
    {
        @MarketPlace,
        @Facebook,
        @Email,
        @Apple,
        @DeliveryMan,
        @Admin,
        @CustomerDelivery,
        @ExternalDelivery,

    }
}
