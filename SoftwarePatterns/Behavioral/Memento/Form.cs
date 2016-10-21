using System;
namespace SoftwarePatterns.Behavioral.Memento
{
    public class Form : ICloneable
    {
        public string Name { set; get; }
        public string LastName { get; set; }
        public string Resume { get; set; }
        public DateTime Created { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
