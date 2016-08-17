using System;

namespace CustomProperty.Dynamic
{
    [Serializable]
    public class Property
    {
        public delegate dynamic Accessor();
        public delegate void Mutator(dynamic value);

        public Accessor Get { get; set; }
        public Mutator Set { get; set; }

        public Property(Accessor get, Mutator set)
        {
            Get = get;
            Set = set;
        }
    }
}

