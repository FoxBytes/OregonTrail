﻿namespace TrailCommon
{
    /// <summary>
    ///     Base travel event that will be used in the creation of other variations of the event such as a medical event,
    ///     physical event, derelict, tombstone, thief, etc.
    /// </summary>
    public interface IRandomEvent
    {
        string Name { get; }
        uint RollCount { get; }
        RandomEvent Action { get; }
        float RollChance { get; }
    }
}