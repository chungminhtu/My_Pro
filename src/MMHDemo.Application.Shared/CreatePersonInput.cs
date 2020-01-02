using AutoMapper;
using MMHDemo.CreatePersonInfo;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MMHDemo.IPersonAppServiceInfo
{
    public class CreatePersonInput
    {
        private object _personRepository;

        [Required]
        [MaxLength(MMHDemo.PersonConsts.PersonConsts.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MMHDemo.PersonConsts.PersonConsts.MaxSurnameLength)]
        public string Surname { get; set; }

        [EmailAddress]
        [MaxLength(MMHDemo.PersonConsts.PersonConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        async Task CreatePerson(CreatePersonInput input)
        {
            var person = ObjectMapper.Map<Stripe.Person>(input);
            //await _personRepository.InsertAsync(person);
        }

    }
}