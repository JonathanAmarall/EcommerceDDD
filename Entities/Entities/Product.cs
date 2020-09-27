using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Product: Notifies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool State { get; set; }
    }
}
