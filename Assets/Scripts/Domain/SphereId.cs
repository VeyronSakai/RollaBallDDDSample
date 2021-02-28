using System;

namespace Domain
{
    public class SphereId
    {
        public Guid Value { get; }

        public SphereId(Guid guid)
        {
            Value = guid;
        }
    }
}