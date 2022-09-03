using System;
using BlazorECSiteSample.Shared.Entities;
using Microsoft.Graph.Models;

namespace BlazorECSiteSample.Server.Extensions;

public static class UserExtension
{
    public static ShopUser ToShopUser(this User user)
    {
        return new ShopUser
        {
            Id = user.Id,
            DisplayName = user.DisplayName,
            MobilePhone = user.MobilePhone
        };
    }
}