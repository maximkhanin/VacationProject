﻿using System;
using System.Collections.Generic;
using VacationsBLL.DTOs;

namespace VacationsBLL.Interfaces
{
    public interface IProfileDataService : IDisposable
    {
        UserProfileDTO GetUserData(string userEmail);
        VacationBalanceDTO GetUserVacationBalance(string userEmail);
        List<VacationDTO> GetUserVacationsData(string userEmail);
        L MapEntity<T, L>(T entity);
    }
}