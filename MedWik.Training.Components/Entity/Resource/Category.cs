using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedWik.Training.Components.Entity.Resource
{
    public class Category
    {
        public Concepts ConceptsCollection { get; set; }
        public KeyWords KeyWordsCollection { get; set; }
    }
}