using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp.Domain.Core
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public Entity()
        {
            Id = new Guid();
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || a is null)
                return false;

            return a.Equals(b);

        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;
            if(ReferenceEquals(this, compareTo)) return true;
            if (compareTo is null) return false;

            return this.Id.Equals(compareTo.Id);
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode() + Id.GetHashCode();
        }
    }
}
