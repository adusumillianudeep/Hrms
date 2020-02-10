using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class CountryService
    {
        private readonly CountryRepository _countryRepository;

        public CountryService()
        {
            _countryRepository = new CountryRepository();
        }

        public List<CountryModel> GetCountries()
        {
            try
            {
                return _countryRepository.GetCountries()
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CountryModel GetCountry(long countryId)
        {
            try
            {
                return _countryRepository.GetCountries()
                    .FirstOrDefault(x => x.Id == countryId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
