using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Architecture.CommonEntities;

namespace Medusa.Biodata.Common.BusinessEntities
{
    public class BaseBusinessEntity: CommonEntity
    {
    }

    public class ListBaseBusinessEntity<T> : ListCommonEntity<T>
        where T: BaseBusinessEntity, new()
    {
    }
}
