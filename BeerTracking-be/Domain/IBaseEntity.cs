using System;
using System.Collections.Generic;
using System.Text;

namespace MongoCrud.Domain
{
    public interface IBaseEntity
    {
        Guid Id { get; }
    }
}
