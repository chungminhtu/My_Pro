using Abp.Domain.Entities.Auditing;
using AutoMapper;
using MMHDemo.IPersonAppServiceInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace MMHDemo.personInfo
{
    [Table("PbPersons")]
    public class Person : FullAuditedEntity
    {
        [Required]
        [MaxLength(MMHDemo.PersonConsts.PersonConsts.MaxNameLength)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(MMHDemo.PersonConsts.PersonConsts.MaxSurnameLength)]
        public virtual string Surname { get; set; }

        [MaxLength(MMHDemo.PersonConsts.PersonConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }
    }

}
