﻿using System;
using Weapsy.Core.Domain;

namespace Weapsy.Domain.Model.Apps.Commands
{
    public class AppDetails : ICommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Folder { get; set; }
    }
}
