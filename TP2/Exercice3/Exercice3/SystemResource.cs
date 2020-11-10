using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    public class SystemResource
    {
        public string Name { get; }
        public bool Locked { get; private set; }

        public SystemResource(string name)
        {
            Name = name;
            Locked = false;
        }

        public SystemResource(ResourceType resourceType)
        {
            Name = resourceType switch
            {
                ResourceType.Ram => "RAM",
                ResourceType.Disk => "Disk",
                ResourceType.Printer => "Printer",
                _ => "Unknown resource",
            };
        }

        public void Acquire()
        {
            Locked = true;
        }

        public void Free()
        {
            Locked = false;
        }
    }
}
