namespace Domain
{
    /// <summary>
    /// ValueObject
    /// </summary>
    public class SphereAcceleration
    {
        public float Value { get; private set; }

        public SphereAcceleration(float value)
        {
            Value = value;
        }
    }
}