﻿using AutoMapper;
using System.Linq;
using VacationsBLL.DTOs;
using VacationsBLL.Interfaces;
using VacationsBLL.Services;
using VacationsDAL.Entities;
using VacationsDAL.Interfaces;

namespace VacationsBLL
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employees;

        private IJobTitleRepository _jobTitles;

        private IMapService _mapService;

        public EmployeeService(IEmployeeRepository employees, IJobTitleRepository jobTitles, IMapService mapService)
        {
            _employees = employees;

            _jobTitles = jobTitles;

            _mapService = mapService;
        }

        public void Create(EmployeeDTO employee)
        {
            _employees.Add(_mapService.Map<EmployeeDTO, Employee>(employee));
        }

        public EmployeeDTO GetUserById(string id)
        {
            return _mapService.Map<Employee,EmployeeDTO>(_employees.GetById(id)); 
        }

        public string GetJobTitleIdByName(string jobTitleName)
        {
            return _jobTitles.GetAll().FirstOrDefault(x => x.JobTitleName.Equals(jobTitleName)).JobTitleID;
        }

        public void SaveChanges()
        {
            _employees.Save();
        }

        public void Dispose()
        {
            _jobTitles.Dispose();
            _employees.Dispose();
        }
    }
}
