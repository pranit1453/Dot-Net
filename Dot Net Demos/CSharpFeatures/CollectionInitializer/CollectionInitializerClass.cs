using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CollectionInitializer
{
    public class CollectionInitializerClass
    {
        private int? id;
        private string? name;
        private string? description;

        public CollectionInitializerClass()
        {
            this.id = null;
            this.name = null;
            this.description = null;
        }

        public CollectionInitializerClass(int? id, string? name, string? description)
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
            set => name = value;
        }

        public string Description
        {
            get => description ?? "Description is not available.";
            set => description = value;

        }
    }
}
