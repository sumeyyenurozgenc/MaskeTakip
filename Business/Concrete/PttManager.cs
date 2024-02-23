using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicatantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicatantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicatantService.CheckPerson(person))
                Console.WriteLine(person.FirstName + " için maske verildi");
            else
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
        }
    }
}
