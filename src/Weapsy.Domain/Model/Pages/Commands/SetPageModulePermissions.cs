﻿using System;
using System.Collections.Generic;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Model.Pages.Commands
{
    public class SetPageModulePermissions : ICommand
    {
        public Guid SiteId { get; set; }
        public Guid Id { get; set; }
        public Guid PageModuleId { get; set; }
        public IList<PageModulePermission> PageModulePermissions { get; set; }
    }
}
