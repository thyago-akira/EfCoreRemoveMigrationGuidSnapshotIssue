using System;

namespace EfCoreRemoveMigrationSnapshot
{
    public class EntityWithGuid
    {
        public long Id { get; }

        public Guid RequiredGuid { get; }

        public Guid? OptionalGuid { get; }

        public string Name { get; }
    }
}
