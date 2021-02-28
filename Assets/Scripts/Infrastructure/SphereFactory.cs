using Domain;

namespace Infrastructure
{
    public sealed class SphereFactory : ISphereFactory
    {
        public Sphere Create(SphereId sphereId)
        {
            return new Sphere(sphereId);
        }
    }
}