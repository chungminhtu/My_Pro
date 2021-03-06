﻿using System.Collections.Generic;
using Abp.Localization;
using MMHDemo.Install.Dto;

namespace MMHDemo.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
