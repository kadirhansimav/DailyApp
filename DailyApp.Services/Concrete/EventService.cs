using DailyApp.DataAccess;
using DailyApp.Entities;
using DailyApp.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyApp.Services.Concrete
{
    public class EventService : IEventService
    {
        EventDal _eventDal = new EventDal(); 
        public void Add(Event _event)
        {
            _eventDal.Add(_event);

        }

        public void Delete(Event _event)
        {
            _eventDal.Delete(_event);
        }

        public Event Get(int id)
        {
            return _eventDal.Get(id);
        }

        public List<Event> GetAll()
        {
            return _eventDal.GetAll();
        }

        public List<Event> SearchWithName(string key)
        {
            return _eventDal.SearchWithName(key);
        }

        public void Update(Event _event)
        {
            _eventDal.Update(_event);
        }
    }
}
