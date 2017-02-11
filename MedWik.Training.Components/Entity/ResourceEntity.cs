using MedWik.Training.Components.Entity.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedWik.Training.Components.Entity
{
    public class ResourceEntity
    {
        public EntityProperty Property { get; set; }
        public Category EntityCategory { get; set; }
    }
}