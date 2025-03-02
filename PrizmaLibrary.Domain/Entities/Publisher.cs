using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmaLibrary.Domain.Entities
{
    public class Publisher
    {
        public Publisher() { }
        public Publisher(
            string name,
            string description,
            string address,
            string city,
            string phone,
            string email,
            string website)
        {
            Name = name;
            Description = description;
            Address = address;
            City = city;
            Phone = phone;
            Email = email;
            Website = website;
        }

        //DI olmasının sebebi daha sonra class newlenirken alacağı parametreleri kolayca görmek içindir.

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
    }
}
