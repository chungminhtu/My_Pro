﻿using System.ComponentModel.DataAnnotations;

namespace MMHDemo.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}