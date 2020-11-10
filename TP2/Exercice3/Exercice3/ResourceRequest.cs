using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    class ResourceRequest
    {
        private int _duration;
        public SystemResource SystemResource { get; }

        public int Duration
        {
            get => _duration;
            set => _duration = value >= 0 ? value : _duration;
        }

        public string ResourceName => SystemResource.Name;

        public bool IsLocked => SystemResource.Locked;


        public ResourceRequest(SystemResource systemResource, int duration)
        {
            SystemResource = systemResource;
            _duration = duration * 1000;
        }

    }
}
