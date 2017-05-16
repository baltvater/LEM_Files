/// <param name="includeOverlapingDates"></param>
/// <param name="showAvailableEventsOnly"></param>

Guid courseModuleId, Guid courseModuleInstanceId, bool includeOverlapingDates, bool showAvailableEventsOnly, UrlHelper urlHelper, int currentPage, int pageSize);

Guid courseModuleId, Guid courseModuleInstanceId, bool includeOverlapingDates, bool showAvailableEventsOnly, UrlHelper urlHelper, int currentPage, int pageSize)

includeOutsideEvents, includeOverlapingDates, showAvailableEventsOnly);


/******** EXISTING CODE********/
    else
            {
                eventsToReturn.AddRange(localOrgEvents);
            }
/******** EXISTING CODE********/


/******** NEW CODE********/
    if (showAvailableEventsOnly)
            {
                var currentLiveEventLearningActivity = mLiveEventRepository.GetByCourseModuleId(courseModuleId, ServerType.LMSDatabase);
var eventIds = await mUserEventActivityService.GetRegisteredEventIdsForUserStudent(mUserSession.UserStudentID);
var registeredEventIdList = eventIds as IList<Guid> ?? eventIds.ToList();

                for (var i = eventsToReturn.Count - 1; i >= 0; i--)
                {
                    var e = eventsToReturn[i];
var eventRegistrations = await mUserEventActivityService.GetUserEventActivityByEventIdAsync(e.EventId);
var isEventAvailableToStudent = await IsEventAvailableToStudentForEnrollmentAsync(e, currentLiveEventLearningActivity, eventRegistrations);

                    if (registeredEventIdList.Contains(e.EventId) || !isEventAvailableToStudent)
                    {
                        eventsToReturn.Remove(e);
                    }
                }
            }
/******** NEW CODE********/


/******** EXISTING CODE********/
            var sortedEvents =
                eventsToReturn.OrderBy(e => e.EventStartDatetime)
                    .ThenBy(e => e.EventName)
                    .ThenBy(e => e.EventEndDatetime).ToList();
/******** EXISTING CODE********/


bool includeOverlapingDates,
bool showAvailableEventsOnly,

IncludeOverlapingDates = includeOverlapingDates,
ShowAvailableEventsOnly = showAvailableEventsOnly
