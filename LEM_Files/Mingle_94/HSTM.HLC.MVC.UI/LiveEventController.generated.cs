public readonly string includeOverlapingDates = "includeOverlapingDates";
public readonly string showAvailableEventsOnly = "showAvailableEventsOnly";

partial void GetFilteredFutureEventsForRegistrationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string nameSearchTerm, string startDate, string endDate, string buildingIds, string eventDefinedResourceFilter, string addressFilterString, string userAdminIds, bool includeOutsideEvents, System.Guid courseModuleLiveEventId, System.Guid courseInstanceId, System.Guid courseModuleId, System.Guid courseModuleInstanceId, int currentPage, int pageSize, bool includeOverlapingDates, bool showAvailableEventsOnly);

public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> GetFilteredFutureEventsForRegistration(string nameSearchTerm, string startDate, string endDate, string buildingIds, string eventDefinedResourceFilter, string addressFilterString, string userAdminIds, bool includeOutsideEvents, System.Guid courseModuleLiveEventId, System.Guid courseInstanceId, System.Guid courseModuleId, System.Guid courseModuleInstanceId, int currentPage, int pageSize, bool includeOverlapingDates, bool showAvailableEventsOnly)

ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "includeOverlapingDates", includeOverlapingDates);
ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "showAvailableEventsOnly", showAvailableEventsOnly);
GetFilteredFutureEventsForRegistrationOverride(callInfo, nameSearchTerm, startDate, endDate, buildingIds, eventDefinedResourceFilter, addressFilterString, userAdminIds, includeOutsideEvents, courseModuleLiveEventId, courseInstanceId, courseModuleId, courseModuleInstanceId, currentPage, pageSize, includeOverlapingDates, showAvailableEventsOnly);
