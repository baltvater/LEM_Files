/// <summary>
/// Boolean indicating whether events with overlapping dates would be returned.
/// If true, events overlapping the filter dates would be returned. If false, only events within the filter boundries would be returned.
/// </summary>
public bool IncludeOverlapingDates { get; set; }

/// <summary>
/// Boolean indicating if only events that are available
/// for student registration should be shown
/// </summary>
public bool ShowAvailableEventsOnly { get; set; }
