﻿namespace Passbook.Generator.Tags;

/// <summary>
/// The date and time the event starts. Use this key for any type of event ticket.
/// </summary>
public class EventStartDate : SemanticTagBaseValue
{
    /// <param name="value">ISO 8601 date as string</param>
    public EventStartDate(string value) : base("eventStartDate", value)
    {
        // NO OP
    }
}
