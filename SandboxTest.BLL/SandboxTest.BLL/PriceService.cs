using SandboxTest.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SandboxTest.BLL
{
    public class PriceService : IPriceService
    {
        IPriceRepository _repo;
        public PriceService(IPriceRepository repo)
        {
            _repo = repo;
        }
        public decimal Total(decimal additionalAmount)
        {
            var currentTotal = _repo.GetPrice().Sum(x => x.Amount);
            var newTotal = currentTotal + additionalAmount;
            var increasedPercentage = (newTotal - currentTotal) / currentTotal * 100;

            if(increasedPercentage >= 10)
            {
                _repo.Save();
            }
            return currentTotal + additionalAmount;
        }
    }
}
