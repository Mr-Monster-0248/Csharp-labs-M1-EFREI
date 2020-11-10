using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercice3
{
    public class AskResource
    {
        private readonly Queue<ResourceRequest> _queue = new Queue<ResourceRequest>();

        public void Run()
        {
            while (_queue.Count != 0)
            {
                ResourceRequest resourceRequest = _queue.Peek();

                while (resourceRequest.IsLocked)
                {
                    Console.WriteLine($"Awaiting for resource {resourceRequest.ResourceName} to be available...");
                    Thread.Sleep(1000);
                }

                resourceRequest.SystemResource.Acquire();
                UseResource(resourceRequest.SystemResource, resourceRequest.Duration);
            }
        }

        public void AddResource(SystemResource systemResource, int duration)
        {
            _queue.Enqueue(new ResourceRequest(systemResource, duration));
        }

        private void UseResource(SystemResource systemResource, int duration)
        {
            Console.WriteLine($"Using resource {systemResource.Name}");
            Thread.Sleep(duration);
            FreeResource(systemResource);
            _queue.Dequeue();
        }

        private void FreeResource(SystemResource systemResource)
        {
            Console.WriteLine($"Freeing resource {systemResource.Name}");
            systemResource.Free();
        }
    }
}
