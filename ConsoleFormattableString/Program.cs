using System;
using System.Runtime.CompilerServices;

namespace ConsoleFormattableString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

            CreateFormattableString(1, 10, 2023);
		}

		static void CreateFormattableString(int employeeId, int month, int year)
		{
			string query = $@"SELECT a.task_id [TaskId]
                                    FROM utl_task a 
                                    INNER JOIN utl_employee b ON a.employee_id=b.employee_id
                                    INNER JOIN utl_dailyUtilization c ON a.task_id = c.task_id WHERE 1=1",
			queryData = $@"SELECT a.task_id [TaskId]
                                        ,a.employee_id [EmployeeId]
                                        ,b.windows_id [EmployeeName]
                                        ,a.consentration_id [ConsentrationId]
                                        ,c.consentration_name [ConsentrationName]
                                        ,a.project_id [ProjectId]
                                        ,d.project_name [ProjectName]
                                        ,a.system_id [SystemId]
                                        ,f.system_name [SystemName]
                                        ,a.task_name [TaskName]
                                        ,a.task_description [TaskDescription]
                                        ,a.repository [Repository]
                                        ,a.flag_BAU [FlagBau]
                                        ,a.role_id [RoleId]
                                        ,e.role_name [RoleName]
                                        ,a.apps_id [AppsId]
                                        ,g.system_name [AppsName]
                                        ,h.dailyUtilization_id [DailyUtilizationId]
                                        ,h.[date] [Date]
                                        ,h.point [Point]
                                        ,h.remarks [Remarks]
                                        ,h.branch_name [BranchName]
                                        ,h.working_hours [WorkingHours]
                                        ,h.create_date [CreateDate]
                                        ,h.update_date [UpdateDate]
										FROM utl_task a 
                                        LEFT JOIN utl_employee b ON a.employee_id=b.employee_id
                                        LEFT JOIN utl_consentration c ON a.consentration_id=c.consentration_id
                                        LEFT JOIN utl_project d ON a.project_id=d.project_id
                                        LEFT JOIN utl_role e ON a.role_id=e.role_id
                                        LEFT JOIN utl_system f ON a.system_id=f.system_id
                                        LEFT JOIN utl_system g ON a.apps_id=g.system_id
                                        INNER JOIN utl_dailyUtilization h ON a.task_id = h.task_id";

			if (employeeId > 0)
			{
				string filter = $@" AND b.employee_id = {employeeId}";
				query += filter;
				queryData += filter;
            }

			if (month > 0 && year > 0)
            {
				query += $@" AND month(c.create_date) = {month} AND year(c.create_date) = {year}";
				queryData += $@" AND month(h.create_date) = {month} AND year(h.create_date) = {year}";
			}

            var formattableQuery = FormattableStringFactory.Create(query);
            var formattableQueryData = FormattableStringFactory.Create(queryData);

            Console.WriteLine(formattableQuery);
            Console.WriteLine(formattableQueryData);
		}
	}
}