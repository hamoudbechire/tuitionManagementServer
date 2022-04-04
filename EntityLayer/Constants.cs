using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public static class Constants
    {
        public static string CartTableName = "cart";
        public const string GmailPassword = "ppipkpkrqhmrdcmq";
        public const string NotificationCommentToUser = "NotificationCommentToUser";
        public const string NotificationToDelivery = "NotificationToDelivery";
        public const string NotificationOrderStatutToUser = "NotificationOrderStatutToUser";
        public const string YouHaveANewOrder = "YouHaveANewOrder";
        public const string OrderIsCancelled = "OrderIsCancelled";
        public const string OrderIsRefused = "OrderIsRefused";
        public const string OrderIsIndelivery = "OrderIsIndelivery";
        public const string OrderIsDelivred = "OrderIsDelivred";
        public const string OrderIsPaid = "OrderIsPaid";
        public const string OrderIsPaidSeller = "OrderIsPaidSeller";
        public const string OrderIsCustomerWithdrawal = "OrderIsCustomerWithdrawal";
        public static string DefaultCultureCode { get; set; }
        //public const string FireBaseUrlWebRequest = "https://fcm.googleapis.com/fcm/send";
        public const string ContentType = "application/json";
        //public const string FireBaseMarketPlaceSellerServerKey = "AAAAr8_VqQY:APA91bH4b7hCFSmeEmPspnFKPehpZqHPLEc1qp5YD9yc_RXf9jrV8U-ixCHT6oQ_1iMyF4xo3zSJ5QTHFEjj_-b3hFMLgUEqQNF8uVjhwIqvwu1qxvYUZjsHMzqwHdWJF4UMyWw5x3mK";
        //public const string FireBaseMarketPlaceCustomerServerKey = "AAAA8KBjegg:APA91bFMIttujOg_2Z1mtXUO0WuLHo5XLJ085eodL34MfGa4TTqSnsps3_10zik8oumict4E1VDdu11Q-h0QebX1gIJyXywUvECEOvXRdHOPIu2ecfLpeex21mfJs08OGOpkr9mEODMR";
        //public const string FireBaseMarketPlaceDeliveryServerKey = "AAAAKWhhLwA:APA91bGWDqQRaB8X6C6Y7tTxFiWuvqIfX7b0XrDr1Tla7e3LXM9TRVknFZiktmiWSqLLvK936rlmBywapj56BXKE8yvdbA3vNDYYeFcFASYD_vDxju42nBNtc7NY7IstyPTJZf6ZILOe";
        public static string CustomerAppClientId = "school-management";
        public static string SellerAppClientId = "school-management";
        public static string CustomerDeliveryClientId = "school-management-customerDelivery";
        public static string ExternalDeliveryAppClientId = "school-management-externalDelivery";
    }
}
