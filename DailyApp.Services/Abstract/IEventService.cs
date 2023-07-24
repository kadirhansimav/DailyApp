﻿using DailyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyApp.Services.Abstract
{
    public interface IEventService
    {
        List<Event> GetAll();
        Event Get(int id);
        void Add(Event _event);
        void Update(Event _event);
        void Delete(Event _event);
        List<Event> SearchWithName(string key);
    }
}
