﻿using System;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Model.Languages.Commands
{
    public class HideLanguage : ICommand
    {
        public Guid SiteId { get; set; }
        public Guid Id { get; set; }
    }
}
