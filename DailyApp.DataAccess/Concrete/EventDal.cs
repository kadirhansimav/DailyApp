using DailyApp.DataAccess.Abstract;
using DailyApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyApp.DataAccess
{
    public class EventDal : IEventDal
    {   
        public void Add(Event _event)
        {
            using(DailyContext context = new DailyContext())
            {
                context.Events.Add(_event);
                context.SaveChanges();
            }

        }

        public void Delete(Event _event)
        {
            using (DailyContext context = new DailyContext())
            {

                var result = context.Events.SingleOrDefault(p=>p.Id == _event.Id);
                if(result != null)
                {
                    result.IsDeleted = true;
                    context.SaveChanges();
                }
            }
        }

        public Event Get(int id)
        {
            using (DailyContext context = new DailyContext())
            {
                return context.Events.SingleOrDefault(p=>p.Id == id);
            }
        }

        public List<Event> GetAll()
        {
            using (DailyContext context = new DailyContext())
            {
                var result = context.Events.Where(p=>p.IsDeleted == false).ToList();
                if (result!= null)
                {
                  return result;
                }
                return null;
                
            }
        }

        public List<Event> SearchWithName(string key)
        {
            using (DailyContext context = new DailyContext())
            {

                return context.Events.Where(p => p.Title.Contains(key) && p.IsDeleted==false).ToList();

            }
        }

        public void Update(Event _event)
        {
            using (DailyContext context = new DailyContext())
            {

                var result = context.Events.SingleOrDefault(p => p.Id == _event.Id);
                if (result != null)
                {
                    result.Title = _event.Title;
                    result.Description = _event.Description;
                    result.IsDeleted = _event.IsDeleted;
                    result.UpdatedDate = DateTime.Now;
                    result.CreatedDate = _event.CreatedDate;
                    result.IsDone = _event.IsDone;
                    context.SaveChanges() ;
                }
            }
        }
    }
}
