namespace Domain
{
    public interface ISphereFactory
    {
        Sphere Create(SphereId sphereId);
    }
}