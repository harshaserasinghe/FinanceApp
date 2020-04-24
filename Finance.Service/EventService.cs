using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Finance.Service
{
    public class EventService
    {

        public FinanceDbContext finanaceDbContext { get; }
        public Mapper mapper { get; }

        public EventService()
        {
            finanaceDbContext = new FinanceDbContext();
            mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public EventDto GetEvnt(int evntId, int userId)
        {
            var evnt = finanaceDbContext.Events
                .Include(t => t.Contact)
                .Include(t => t.RecurringEvent)
                .FirstOrDefault(t => t.EventId == evntId && t.UserId == userId);

            if (evnt == null)
            {
                return new EventDto();
            }

            var evntDto = mapper.Map<EventDto>(evnt);
            return evntDto;
        }




        public List<EventDto> GetEvntsByDate(int userId, EvntType evntType, DateTime fromDate, DateTime toDate)
        {
            var evntQuery = finanaceDbContext.Events
                .Include(t => t.Contact)
                .Include(t => t.RecurringEvent)
                .AsQueryable();

            if (EvntType.All != evntType)
            {
                evntQuery = evntQuery.Where(t => t.EvntType == evntType).AsQueryable();
            }

            evntQuery = evntQuery.Where(t => t.IsActive &&
                t.UserId == userId &&
                DbFunctions.TruncateTime(t.EvntStartDate) >= DbFunctions.TruncateTime(fromDate) &&
                DbFunctions.TruncateTime(t.EvntEndDate) <= DbFunctions.TruncateTime(toDate)).AsQueryable();

            var evnts = evntQuery.OrderBy(t => t.EvntStartDate).ToList();

            if (evnts == null)
            {
                return new List<EventDto>();
            }

            var evntDtos = mapper.Map<List<EventDto>>(evnts);
            return evntDtos;
        }

        public void AddEvnt(CreateEventDto createEventDto)
        {
            var evnt = mapper.Map<Event>(createEventDto);

            if (createEventDto.IsRecurring)
            {
                var recEvnt = mapper.Map<RecurringEvent>(createEventDto);
                finanaceDbContext.RecurringEvents.Add(recEvnt);
                evnt.RecurringEvent = recEvnt;
            }

            finanaceDbContext.Events.Add(evnt);
            finanaceDbContext.SaveChanges();
        }


        public void UpdateEvnt(UpdateEventDto updateEvntDto)
        {
            var evnt = finanaceDbContext.Events.Find(updateEvntDto.EventId);
            mapper.Map(updateEvntDto, evnt);

            if (updateEvntDto.IsRecurring)
            {
                var recEvnt = finanaceDbContext.RecurringEvents.Find(updateEvntDto.EvntRecId);
                mapper.Map(updateEvntDto, recEvnt);
                finanaceDbContext.Entry(recEvnt).State = EntityState.Modified;
            }

            finanaceDbContext.Entry(evnt).State = EntityState.Modified;
            finanaceDbContext.SaveChanges();
        }

        public void DeleteEvnt(int evntId)
        {
            var evnt = finanaceDbContext.Events.Find(evntId);
            finanaceDbContext.Events.Remove(evnt);
            finanaceDbContext.SaveChanges();
        }

        public List<RecurringEventDto> GetRecurringEvents()
        {
            var recurringEvents = finanaceDbContext.RecurringEvents
                .Where(re => re.IsActive).Select(re => new RecurringEventDto
                {
                    EvntRecId = re.EventRecId,
                    Frequency = re.Frequency,
                    Event = re.Events.OrderByDescending(t => t.EvntStartDate).FirstOrDefault()
                })
                .ToList();

            return recurringEvents;
        }

        public void HandleRecurringEvents(List<RecurringEventDto> recurringEventDTOs)
        {
            DateTime currentDate = new DateTime(2020, 04, 01);
            var monthStartDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            var monthEndDate = monthStartDate.AddMonths(1).AddDays(-1);
            var yearStartDate = new DateTime(currentDate.Year, 1, 1);
            var yearEndDate = monthStartDate.AddYears(1).AddMonths(-1);

            foreach (var recurringEvent in recurringEventDTOs)
            {
                if (recurringEvent.Frequency == Frequency.Daliy &&
                    !HasDaliy(recurringEvent, currentDate))
                {
                    AddEvent(recurringEvent);
                }
                else if (recurringEvent.Frequency == Frequency.Monthly &&
                    recurringEvent.Event.EvntStartDate.Day == currentDate.Day &&
                    !HasMonthly(recurringEvent, monthStartDate, monthEndDate))
                {
                    AddEvent(recurringEvent);
                }
                else if (recurringEvent.Frequency == Frequency.Yearly &&
                    recurringEvent.Event.EvntStartDate.Month == currentDate.Month &&
                    recurringEvent.Event.EvntStartDate.Day == currentDate.Day &&
                    !HasMonthly(recurringEvent, yearStartDate, yearEndDate))
                {
                    AddEvent(recurringEvent);
                }
            }
        }


        private void AddEvent(RecurringEventDto recurringEvent)
        {
            var evnt = new Event();
            evnt.Name = recurringEvent.Event.Name;
            evnt.Description = recurringEvent.Event.Description;
            evnt.EvntType = recurringEvent.Event.EvntType;
            evnt.EvntStartDate = DateTime.Now;
            evnt.EvntEndDate = DateTime.Now;
            evnt.EvntStartTime = DateTime.Now;
            evnt.EvntEndTime = DateTime.Now;
            evnt.IsRecurring = true;
            evnt.ContactId = recurringEvent.Event.ContactId;
            evnt.EventRecId = recurringEvent.Event.EventRecId;
            finanaceDbContext.Events.Add(evnt);
            finanaceDbContext.SaveChanges();
        }


        private bool HasDaliy(RecurringEventDto recurringEvent, DateTime currentDate)
        {
            return finanaceDbContext.Events
                .Any(t => t.EventRecId == recurringEvent.EvntRecId &&
                DbFunctions.TruncateTime(t.EvntStartDate) == DbFunctions.TruncateTime(currentDate));
        }

        private bool HasMonthly(RecurringEventDto recurringEvent, DateTime monthStartDate, DateTime monthEndDate)
        {
            return finanaceDbContext.Events
                .Any(t => t.EventRecId == recurringEvent.EvntRecId &&
                DbFunctions.TruncateTime(t.EvntStartDate) >= DbFunctions.TruncateTime(monthStartDate) &&
                DbFunctions.TruncateTime(t.EvntStartDate) <= DbFunctions.TruncateTime(monthEndDate));
        }
    }
}
