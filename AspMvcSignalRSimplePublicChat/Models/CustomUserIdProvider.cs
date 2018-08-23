using AspMvcSignalRSimplePublicChat.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CustomUserIdProvider : IUserIdProvider
{
    public string GetUserId(IRequest request)
    {
        // your logic to fetch a user identifier goes here.

        // for example:

        var userId = MyCustomUserClass.FindUserId(request.User.Identity.Name);
        return userId.ToString();
    }
}