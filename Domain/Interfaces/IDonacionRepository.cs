﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IDonacionRepository : IModel<Donacion>
    {
        Donacion GetDonacionById(int id);
    }
}
