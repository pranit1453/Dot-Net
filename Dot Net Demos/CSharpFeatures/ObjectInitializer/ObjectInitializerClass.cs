using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.ObjectInitializer
{
    public class ObjectInitializerClass
    {
        private int? id;
        private string? name;
        private string? description;

        public ObjectInitializerClass()
        {
            this.id = null;
            this.name= null;
            this.description = null;
        }

        public ObjectInitializerClass(int? id, string? name, string? description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public int Id
        {
            get => id ?? -1;
            set => id = value;
        }

        public string Name
        {
            get => name ?? "Name is not available.";
            set=> name = value;
        }

        public string Description
        {
            get => description ?? "Description is not available.";
            set=> description = value;
           
        }
    }
}
