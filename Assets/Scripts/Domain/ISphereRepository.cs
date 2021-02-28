namespace Domain
{
    public interface ISphereRepository
    {
        Sphere Find(SphereId sphereId);
        void Save(Sphere sphere);
    }
}