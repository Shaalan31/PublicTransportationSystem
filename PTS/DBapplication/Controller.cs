using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int EditInformation(string Username, string _Address, string _Email)
        {
            string StoredProcedureName = StoredProcedures.EditInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@address", _Address);
            Parameters.Add("@email", _Email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //1-Retrieves Salary & JobCode
        public DataTable getSalaryJCode(int SSN)
        {
            string StoredProcedureName = StoredProcedures.getSalaryJobCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EmpSSN", SSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //2-Updates Employee Information
        public int UpdateEmp(int Salary, int E_SSN, int S_SSN)
        {
            string StoredProcedureName = StoredProcedures.UpdateEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@EmpSSN", E_SSN);
            Parameters.Add("@SuperSSN", S_SSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //3-Delete Employee
        public int deleteEmployee(int SSN)
        {
            string StoredProcedureName = StoredProcedures.DeleteEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ESSN", SSN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //4-Delete Transportation Mean
        public int deleteTransportation(int ID)
        {
            string StoredProcedureName = StoredProcedures.DeleteTransportationMean;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //5-Get Company By Name
        public DataTable getCompanyName(string Username)
        {
            string StoredProcedureName = StoredProcedures.GetCompanyName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int GetCompanyNumber(int ID)
        {
            string StoredProcedureName = StoredProcedures.GetCompanyPhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompanyID", ID);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        //6-Get Department by Name
        public DataTable getDeptName()
        {
            string StoredProcedureName = StoredProcedures.GetDepartmentNames;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //7-Get Employee Names
        public DataTable getEmployeeNames()
        {
            string StoredProcedureName = StoredProcedures.GetEmployeeName;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //8-Get Supervisors Names
        public DataTable getSupervisorsNames()
        {
            string StoredProcedureName = StoredProcedures.GetSupervisorNames;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //9-Get Transportation Names
        public DataTable getTransportationNames()
        {
            string StoredProcedureName = StoredProcedures.GetTransportation;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //10- Insert Edge
        public int insertEdge(int Source, int Destination, string TransCode, int TransID, int Weight)
        {
            string StoredProcedureName = StoredProcedures.InsertEdge;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Source", Source);
            Parameters.Add("@Destination", Destination);
            Parameters.Add("@Transcode", TransCode);
            Parameters.Add("@TransID", TransID);
            Parameters.Add("@weight", Weight);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //11-Insert Employee
        public int insertEmployee(int SSN, String JobCode, int Salary, int Dnumber, int Super_SSN, DateTime StartDate, String FName, String LName, char Gender, string Email, DateTime BDate)
        {
            string StoredProcedureName = StoredProcedures.InsertEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@E_SSN", SSN);
            Parameters.Add("@FName", FName);
            Parameters.Add("@LName", LName);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@Email", Email);
            Parameters.Add("@Birth_Date", BDate);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Job_Code", JobCode);
            Parameters.Add("@Dnumber", Dnumber);
            Parameters.Add("@Super_SSN", Super_SSN);
            Parameters.Add("@StartDate", StartDate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //12-Insert Transportation Mean
        public int insertTransportation(string TransCode, int TransID, int Capacity, bool AC, float Fare)
        {
            string StoredProcedureName = StoredProcedures.InsertTransportation;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TransCode", TransCode);
            Parameters.Add("@TransID", TransID);
            Parameters.Add("@Capacity", Capacity);
            Parameters.Add("@AC", AC);
            Parameters.Add("@Fare", Fare);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //13-UpdateTransportationMean
        public int UpdateTransportation(string TransCode, int TransID, int Capacity, bool AC, float Fare)
        {
            string StoredProcedureName = StoredProcedures.UpdateTransportation;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TransCode", TransCode);
            Parameters.Add("@TransID", TransID);
            Parameters.Add("@Capacity", Capacity);
            Parameters.Add("@AC", AC);
            Parameters.Add("@Fare", Fare);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //Insert Company
        public int AddCompany(int CompanyID, string CompanyName, string Address, int Phone, string Email)
        {
            string StoredProcedureName = StoredProcedures.AddCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompanyID", CompanyID);
            Parameters.Add("@CompanyName", CompanyName);
            Parameters.Add("@Address", Address);
            Parameters.Add("@Phone", Phone);
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //14-Sends Request
        public int sendRequest(int CompCode, string TransCode, int TransID, int JobDone, string Msg = null)
        {
            string StoredProcedureName = StoredProcedures.SendRequest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompanyCode", CompCode);
            Parameters.Add("@TransCode", TransCode);
            Parameters.Add("@TransID", TransID);
            Parameters.Add("@JobDone", JobDone);
            Parameters.Add("@Message", Msg);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //15-Request Done
        public int requestDone(int RequestID)
        {
            string StoredProcedureName = StoredProcedures.RequestDone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RequestID", RequestID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //16-Pending Request
        public DataTable pendingRequest(int CompCode, int JobDone)
        {
            string StoredProcedureName = StoredProcedures.PendingRequest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompCode", CompCode);
            if(CompCode==0)
            {
                Parameters.Add("@CompCode", 0);
            }
            Parameters.Add("@JobDone", JobDone);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CheckCompanyID(int SSN)
        {
            string StoredProcedureName = StoredProcedures.CheckCompanyID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CheckCompanyName(string Name)
        {
            string StoredProcedureName = StoredProcedures.CheckCompanyName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name",Name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable ReviewingRquest(int JobDone)
        {
            string StoredProcedureName = StoredProcedures.ReviewingRquest;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@JobDone", JobDone);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //17-Stores the Order 
        public int StoreOrder(string Username, int Source, int Destination, int Rate, string Suggestion, DateTime CurDate, DateTime CurTime, int AmountDue)
        {
            string StoredProcedureName = StoredProcedures.StoreOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Source", Source);
            Parameters.Add("@Destination", Destination);
            Parameters.Add("@Rate", Rate);
            Parameters.Add("@Suggestion", Suggestion);
            Parameters.Add("@CurDate", CurDate);
            Parameters.Add("@CurTime", CurTime);
            Parameters.Add("@Amount_Due", AmountDue);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //18-Retrieve all Districts
        public DataTable allDistricts(int ID)
        {
            string StoredProcedureName = StoredProcedures.AllDistrict;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            if (ID == 0)
            {
                return dbMan.ExecuteReader(StoredProcedureName, null);
            }
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //19-User Change Password
        public int uChangePassword(string Username, string OldPassword, string NewPassword)
        {
            string StoredProcedureName = StoredProcedures.UserChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@OldPassword", OldPassword);
            Parameters.Add("@newPassword", NewPassword);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //20-View History "Modified One"
        public DataTable viewHistory(string Username)
        {
            string StoredProcedureName = StoredProcedures.ViewsHistoryBetter;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //21-View all Statistics
        public DataTable viewAllStatistics(string Username)
        {
            string StoredProcedureName = StoredProcedures.AllStatistics;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //22-Count the Ratings
        public DataTable countRating(int Number)
        {
            string StoredProcedureName = StoredProcedures.CountRating;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Num", Number);
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //23-Average salaries
        public DataTable AverageSalaries()
        {
            string StoredProcedureName = StoredProcedures.AvgSalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //24-View the most visited place
        public DataTable viewMostVisited()
        {
            string StoredProcedureName = StoredProcedures.MostVistedPlacex;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //25-Insert a User 
        public int insertUser(string Username, string Password, string Address, int Priviledge, int SSN, string FName, string LName, char Gender, string Email, DateTime BDate, int IsDependent)
        {
            string StoredProcedureName = StoredProcedures.InsertUser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Address", Address);
            Parameters.Add("@Priv", Priviledge);
            Parameters.Add("@SSN", SSN);
            Parameters.Add("@Fname", FName);
            Parameters.Add("@Lname", LName);
            Parameters.Add("@Gender", Gender);
            Parameters.Add("@BDate", BDate);
            Parameters.Add("@Email", Email);
            Parameters.Add("@IsDependent", IsDependent);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //26-Login
        public DataTable Login(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.Login;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //34-CountEmployees Starts from a certain date
        public int CountDate(DateTime date)
        {
            string StoredProcedureName = StoredProcedures.EmploymentDate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DateOfEmployment", date);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        //27-Company Login
        public DataTable CompanyLoginIn(string CompanyName, string Password)
        {
            string StoredProcedureName = StoredProcedures.CompanyLoginIn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompanyName", CompanyName);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        //28-Delete Company
        public int DeleteCompany(int CompanyID)
        {
            string StoredProcedureName = StoredProcedures.DeleteCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompanyID", CompanyID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        //38-GetCompanysDetails
        public DataTable getCompanyDetails(int ID)
        {
            string StoredProcedureName = StoredProcedures.GetCompanyDetails;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompanyID", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //29-Update Company
        public int UpdateCompany(int CompanyID, int Phone, string Address, string CompanyEmail)
        {
            string StoredProcedureName = StoredProcedures.UpdateCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CompanyID", CompanyID);
            Parameters.Add("@Email", CompanyEmail);
            Parameters.Add("@Address", Address);
            Parameters.Add("@Phone", Phone);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //30-Shortest Path Algorithm
        public DataTable ShortestPath(int Source, int Destination)
        {
            string StoredProcedureName = StoredProcedures.usp_Dijkstra;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@StartNode", Source);
            Parameters.Add("@EndNode", Destination);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        //31- Check if this SSN is in the Table
        public DataTable CheckSSNEmp(int SSN)
        {
            string StoredProcedureName = StoredProcedures.CheckSSNEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable EmailAvaliable(string Email)
        {
            string StoredProcedureName = StoredProcedures.EmailAvaliable;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable JobCodeAvailable(string Job_Code)
        {
            string StoredProcedureName = StoredProcedures.JobCodeAvailable;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Job_Code", Job_Code);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable UniqueTransID(int TransID)
        {
            string StoredProcedureName = StoredProcedures.UniqueTransID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TransID", TransID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable UserNameAvaliable(string Username)
        {
            string StoredProcedureName = StoredProcedures.UserNameAvaliable;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //32- Check if the job code is avaliable 
        public DataTable CheckJobCode(string JobCode)
        {
            string StoredProcedureName = StoredProcedures.CheckJobCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Code", JobCode);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //33- Check both job code and SSN
        public DataTable CheckSSNJobCodeEmp(int SSN, string JobCode)
        {
            string StoredProcedureName = StoredProcedures.CheckJobCodeWithSSN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Code", JobCode);
            Parameters.Add("@SSN", SSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        //34- Check if this old password is correct
        public DataTable CheckOldPassword(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.CheckOldPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        //Converting string to array of ints
        public static IEnumerable<int> StringToIntList(string str)
        {
            if (String.IsNullOrEmpty(str))
                yield break;

            foreach (var s in str.Split(','))
            {
                int num;
                if (int.TryParse(s, out num))
                    yield return num;
            }
        }


        //Trying to come out with the table 
        public DataTable Route(string metroID, string DistrictID)
        {
            DataTable DT = new DataTable();
            IEnumerable<int> s = StringToIntList(DistrictID);
            var District = s.ToArray();

            IEnumerable<int> w = StringToIntList(metroID);
            var metro = w.ToArray();

            DT.Columns.Add("From", typeof(string));
            DT.Columns.Add("To", typeof(string));
            DT.Columns.Add("MetroID", typeof(int));
            int from = District[0];
            int to;
            int TransID = metro[0];
            int j;
            int i = 0;
            //int k = 1;
            //int k = 1;

            //int k = 1;
            while (i < metro.Length)
            {
                j = i + 1;
                if (j == District.Length)
                {
                    to = District[j];
                    DT.Rows.Add(allDistricts(from), allDistricts(to), TransID);
                    i = j;
                    return DT;
                }
                if (j == metro.Length)
                {
                    to = District[j];
                    DT.Rows.Add(allDistricts(from).Rows[0][1], allDistricts(to).Rows[0][1], TransID);
                    i++;
                    return DT;
                }
                
                while (j<metro.Length && metro[j] == metro[i])
                {
                   
                    if (j == metro.Length)
                    {
                        to = District[j];
                        DT.Rows.Add(allDistricts(from).Rows[0][1], allDistricts(to).Rows[0][1], TransID);
                        i++;
                        return DT;
                    }
                    j++;
                }

                //if (j != metro.Length)
                //{
                    to = District[j];
                    DT.Rows.Add(allDistricts(from).Rows[0][1], allDistricts(to).Rows[0][1], TransID);
                    from = to;
                if(j< metro.Length)
                    TransID = metro[j];
                 i = j;
                //}
                //i = j;
            }
        



            return DT;
        }
        //38-Job Done
        public int JobDone(int RequestID)
        {
            string StoredProcedureName = StoredProcedures.JobDone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@JobID", RequestID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //30-Get Supervisor for certain Employee
        public DataTable getSuperVisorSSN(int ESSN)
        {
            string StoredProcedureName = StoredProcedures.GetSupervisorNameForEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ESSN", ESSN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        //31-Get Salary of Certain Emp.
        public int GetSalary(int ESSN)
        {
            string StoredProcedureName = StoredProcedures.getSalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ESSN", ESSN);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }


        //35-CountOrders between a date
        public int CountOrders(DateTime date1, DateTime date2)
        {
            string StoredProcedureName = StoredProcedures.TotalOrders;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FirstDate", date1);
            Parameters.Add("@SecondDate", date2);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }


        //36-CountsTotalOrders
        public int CountTotalOrders()
        {
            string StoredProcedureName = StoredProcedures.CountTotalOrders;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }


        //37-GetOrdersinfo between two dates
        public DataTable SalaryStatistics()
        {
            string StoredProcedureName = StoredProcedures.AvgSalary;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        //32-Get Info for all Emp.
        public DataTable GetAllEmployees()
        {
            string StoredProcedureName = StoredProcedures.GetEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //33=CountEmployees
        public int CountAllEmployees(String Gender = null)
        {
            string StoredProcedureName = StoredProcedures.CountEmployees;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            if (Gender != null)
            {
                Parameters.Add("@Gender", Gender[0]);
                return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
            }
            else
                return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        //checks the username/password and returns the privlidges associated with this user
        //Returns 0 in case of error
        public int CheckPassword_Basic(string username, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT Priv from Login where Username = '" + username + "' and Password='" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }
        public int CheckCompanyPassword_Basic(string CompanyName, string Password)
        {
            string query = "Select 1 From Maintenance Where CompanyName='" + CompanyName + "' AND Password = '" + Password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }

        public int FindEmployeeDno(string username)
        {
            string query = "SELECT Dnumber from Employee,Login where Username='" + username + "' and L_SSN=E_SSN; ";
            object p = dbMan.ExecuteScalar(query);
            if (p == null)
            {
                return -1;
            }
            else
            {
                return (int)p;
            }
        }
        public int InsertHumanBasics(int SSN, string FirstName, string LastName, string Gender, string Email, DateTime BirthDate)
        {
            string query = "Insert INTO Human_basics (SSN,FName,LName,Gender,Email,Birth_Date) VALUES (" +
                "" + SSN + "," +
                "'" + FirstName + "'," +
                "'" + LastName + "'," +
                "'" + Gender + "'," +
                "'" + Email + "'," +
                "'" + BirthDate.ToString("yyyy-MM-dd") + "')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertLogin(int SSN, string Username, int Password, int Privilege)
        {
            string query = "Insert INTO Login (L_SSN,Username,Password,Priv) VALUES (" +
                "" + SSN + "," +
                "'" + Username + "'," +
                "" + Password + "," +
                "" + Privilege + "" + ")";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
