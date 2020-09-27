using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class EntityBase : Notifies
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
