using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreProject.Models
{
    public class UsersListViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public SelectList Companies { get; set; }
        public string Name { get; set; }
    }
}