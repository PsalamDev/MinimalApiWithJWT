using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MinimalApi.Models;
using System.ComponentModel.DataAnnotations;

namespace MinimalApi.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
              new() { Username = "Abdool_admin", EmailAddress = "Abdool.admin@gmail.com", Password = "MyPass_w@rd", GivenName =
                  "Abdool", Surname = "Salam", Role = "Administrator"  },
              new() { Username = "You_standard", EmailAddress = "You.standard@gmail.com", Password ="MyPass_w@rd", GivenName =
                  "You",Surname ="Ayomide", Role = "Standard" },
        };
    }
}
