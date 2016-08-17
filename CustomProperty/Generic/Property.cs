using System;

namespace CustomProperty.Generic
{
    public class Property<T>
    {
        public delegate T Accessor();
        public delegate void Mutator(T value);

        public Accessor Get { get; set; }
        public Mutator Set { get; set; }

        public Property(Accessor get, Mutator set)
        {
            Get = get;
            Set = set;
        }
    }
}

