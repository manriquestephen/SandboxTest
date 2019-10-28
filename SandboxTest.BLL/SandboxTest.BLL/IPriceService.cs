using System;
using System.Collections.Generic;
using System.Text;

namespace SandboxTest.BLL
{
    public interface IPriceService
    {
        decimal Total(decimal additionalAmount);
    }
}
