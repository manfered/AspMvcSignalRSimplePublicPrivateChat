using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcSignalRSimplePublicChat.Models
{
    public class MyCustomUserClass
    {
        private static int ClientIndex = 0;

        public static int FindUserId(string userName)
        {
            ++ClientIndex;
            return ClientIndex;
        }
    }
}