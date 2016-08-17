using System;

namespace CustomProperty
{
    [Serializable]
    public class Property
    {
        public delegate object Accessor();
        public delegate void Mutator(object value);

        public Accessor Get { get; set; }
        public Mutator Set { get; set; }

        public Property(Accessor get, Mutator set)
        {
            Get = get;
            Set = set;
        }
    }
}

