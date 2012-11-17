﻿using Caliburn.Micro;
using Client.Common.Models.Subsonic;
using Subsonic8.MenuItem;

namespace Subsonic8.Index
{
    public interface IIndexViewModel
    {
        IndexItem Parameter { get; set; }

        BindableCollection<MenuItemViewModel> MenuItems { get; set; }
    }
}