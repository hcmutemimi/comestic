using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comestic.Ulitity
{
    public static class SD
    {
        public const string DefaultImage = "default.png";
        public const string ManagerUser = "Manager";
        public const string EmployeeUser = "Employee";
        public const string CustomerUser = "Customer";
        public const string ssShopingCartCount = "ssCartCount";

        public const string StatusSubmitted = "Submitted";
        public const string StatusInProcess = "Being Prepared";
        public const string StatusReady = "Ready for pick up";
        public const string StatusCompleted = "Completed";
        public const string StatusCancelled = "Cancelled";


        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusRejected = "Rejected";




        public static string ConvertToRawHtml(string source)
        {

            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;
            for(int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }

            }
            return new string(array, 0, arrayIndex);
        }


    }
}
