using System;
using System.Collections.Generic;

namespace SandboxTest.DAL
{
    public interface IPriceRepository
    {
        List<PriceEntity> GetPrice();

        void Save();
    }


}
