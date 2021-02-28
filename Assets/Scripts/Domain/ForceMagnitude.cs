using System;

namespace Domain
{
    /// <summary>
    /// ValueObject
    /// </summary>
    public class ForceMagnitude
    {
        public float Value { get; }

        public ForceMagnitude(float value)
        {
            if (value < 0f)
            {
                throw new AggregateException($"{typeof(ForceMagnitude)} cannot be minus");
            }
        
            Value = value;
        }
    }
}
