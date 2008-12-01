using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Medusa.Biodata.FrontEnd.Assembler
{
    interface IAssembler<TDto, TDomain>
    {
        TDto CreateDTO(TDomain domain);
        
        TDomain CreateDomainObject(TDto dto);

        IList<TDto> CreateDTOGenericList(IList<TDomain> list);

        IList CreateDTOArrayList(IList<TDomain> list);

    }
}
