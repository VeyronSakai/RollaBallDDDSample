using System.Collections.Generic;
using Domain;

namespace Infrastructure
{
    public class SphereRepository : ISphereRepository
    {
        private Dictionary<SphereId, Sphere> Db { get; } = new Dictionary<SphereId, Sphere>();

        public Sphere Find(SphereId sphereId)
        {
            return Db.ContainsKey(sphereId) ? Db[sphereId] : null;
        }

        public void Save(Sphere sphere)
        {
            Db[sphere.SphereId] = sphere;
        }
    }
}