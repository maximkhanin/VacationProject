﻿using System;
using System.Web.Mvc;

namespace VacationsBLL.Interfaces
{
    public interface IPageListsService
    {
        SelectListItem[] SelectEditRoles(string editValue);
        SelectListItem[] SelectEditJobTitles(string editValue);
        SelectListItem[] SelectEditStatuses(string editValue);
        SelectListItem[] EmployeesList(string editValue);
        SelectListItem[] SelectRoles();
        SelectListItem[] SelectJobTitles();
        SelectListItem[] SelectStatuses();
        SelectListItem[] SelectVacationTypes();
        SelectListItem[] EmployeesList();
    }
}
