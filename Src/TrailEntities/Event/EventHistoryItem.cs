﻿using TrailEntities.Time;

namespace TrailEntities.Event
{
    /// <summary>
    ///     Represents an event that has occurred in the simulations past.
    /// </summary>
    public sealed class EventHistoryItem
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:TrailEntities.Event.EventHistoryItem" /> class.
        /// </summary>
        public EventHistoryItem(EventItem eventItem)
        {
            // When the event happened.
            Timestamp = GameSimApp.Instance.Time.Date;

            // What the event name and category were.
            EventName = eventItem.Name;
            EventType = eventItem.Category;
        }

        /// <summary>
        ///     Defines what category of event this was.
        /// </summary>
        public EventCategory EventType { get; }

        /// <summary>
        ///     Holds the name of the event that was fired.
        /// </summary>
        public string EventName { get; }

        /// <summary>
        ///     Defines when the event actually took place.
        /// </summary>
        public Date Timestamp { get; }
    }
}