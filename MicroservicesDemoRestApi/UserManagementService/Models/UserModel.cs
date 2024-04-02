using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace EC_User_Service.Models
{
    public class UserModel
    {
        [Required]
        public string? Name { get; set; }
    }
}
