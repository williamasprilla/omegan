using Ardalis.Specification;
using Omegan.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Contracts.Specifications
{
    public class CountrySpecification: Specification<Country>
    {
        public CountrySpecification(int countryId)
        {
            Query.Where(c => c.Id == countryId);
        }


        public CountrySpecification()
        {

        }

    }
}
