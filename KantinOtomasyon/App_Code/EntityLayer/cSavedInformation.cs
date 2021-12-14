using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Reflection;

[Serializable]
public class cSavedInformation : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int FrenchiseId { get; set; }
    public int StudentId { get; set; }
    public int? StudentNumber { get; set; }
    public int? AcademicYearId { get; set; }
    public int? PriceId { get; set; }
    public string SavedUser { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string ParentName { get; set; }
    public string SchoolName { get; set; }
    public DateTime YearOfBirth { get; set; }
    public string MotherName { get; set; }
    public string FatherName { get; set; }
    public double SavedPrice { get; set; }
    public string AcademicYearName { get; set; }
    public string EducationPlanName { get; set; }

    public string HomePhone { get; set; }
    public string BusinessPhone { get; set; }
    public string EmergencyPhone { get; set; }
    public string EmergencyPhone2 { get; set; }
    public string HomeAddress { get; set; }

    public int? ClassId { get; set; }
    public string ClassName { get; set; }

    public int EducationPlanId { get; set; }
    public int PriceType { get; set; }
    public string PriceTypeText { get; set; }

    public string InsertName { get; set; }

    public int SavedChannelId { get; set; }
    public string StudentPhone { get; set; }

    public double PesinOdeme { get; set; }
    public double ToplamOdeme { get; set; }

    public int ClassPollingId { get; set; }
    public int StudentSavedId { get; set; }
    public int? CameType { get; set; }
    public DateTime? LessonDate { get; set; }
    public int? ClassPollingStatus { get; set; }


    #endregion

    #region Methods

    public static List<cSavedInformation> GetSavedInformationByAll()
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByAll();

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationByFrenchiseId(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByFrenchiseId(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationActiveByFrenchiseId(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationActiveByFrenchiseId(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.StudentPhone = row.Field<string>("StudentPhone");
                item.HomePhone = row.Field<string>("HomePhone");
                item.BusinessPhone = row.Field<string>("BusinessPhone");
                item.HomeAddress = row.Field<string>("HomeAddress");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationPassiveByFrenchiseId(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationPassiveByFrenchiseId(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.StudentPhone = row.Field<string>("StudentPhone");
                item.HomePhone = row.Field<string>("HomePhone");
                item.BusinessPhone = row.Field<string>("BusinessPhone");
                item.HomeAddress = row.Field<string>("HomeAddress");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationByStundentClass(int pBranchId, int pClassId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByStundentClass(pBranchId, pClassId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.ClassId = row.Field<int?>("ClassId");
                item.ClassName = row.Field<string>("ClassName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationBySearchStundentClass(int pBranchId, int pClassId, string pValue)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationBySearchStundentClass(pBranchId, pClassId, pValue);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.ClassId = row.Field<int?>("ClassId");
                item.ClassName = row.Field<string>("ClassName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationByNotClassStudentList(int pBranchId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByNotClassStudentList(pBranchId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.EducationPlanId = row.Field<int>("EducationPlanId");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationBySearchNotClassStudentList(int pBranchId, string pValue)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationBySearchNotClassStudentList(pBranchId, pValue);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.EducationPlanId = row.Field<int>("EducationPlanId");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationByEducationPlanId(int pBranchId, int pEducationPlanId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByEducationPlanId(pBranchId, pEducationPlanId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.ClassId = row.Field<int?>("ClassId");
                item.ClassName = row.Field<string>("ClassName");

                item.StudentPhone = row.Field<string>("StudentPhone");
                item.HomePhone = row.Field<string>("HomePhone");
                item.BusinessPhone = row.Field<string>("BusinessPhone");
                item.EmergencyPhone = row.Field<string>("EmergencyPhone");
                item.EmergencyPhone2 = row.Field<string>("EmergencyPhone2");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationByAcademicYearId(int pBranchId, int pAcademicYearId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByAcademicYearId(pBranchId, pAcademicYearId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.PriceTypeText = row.Field<string>("PriceTypeText");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                //item.ClassId = row.Field<int?>("ClassId");
                //item.ClassName = row.Field<string>("ClassName");
                item.PriceType = row.Field<int>("PriceType");
                item.SavedChannelId = row.Field<int>("SavedChannelId");

                item.StudentPhone = row.Field<string>("StudentPhone");
                item.HomePhone = row.Field<string>("HomePhone");
                item.BusinessPhone = row.Field<string>("BusinessPhone");
                item.EmergencyPhone = row.Field<string>("EmergencyPhone");
                item.EmergencyPhone2 = row.Field<string>("EmergencyPhone2");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationBySearchEducationPlanId(int pBranchId, int pEducationPlanId, string pValue)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationBySearchEducationPlanId(pBranchId, pEducationPlanId, pValue);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.ClassId = row.Field<int?>("ClassId");
                item.ClassName = row.Field<string>("ClassName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationBySearchClass(int pBranchId, int pClassId, string pValue)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationBySearchClass(pBranchId, pClassId, pValue);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.ClassId = row.Field<int?>("ClassId");
                item.ClassName = row.Field<string>("ClassName");
                item.StudentNumber = row.Field<int>("StudentNumber");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationByClass(int pBranchId, int pClassId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByClass(pBranchId, pClassId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.ClassId = row.Field<int?>("ClassId");
                item.ClassName = row.Field<string>("ClassName");
                item.StudentNumber = row.Field<int>("StudentNumber");

                item.StudentPhone = row.Field<string>("StudentPhone");
                item.HomePhone = row.Field<string>("HomePhone");
                item.BusinessPhone = row.Field<string>("BusinessPhone");
                item.EmergencyPhone = row.Field<string>("EmergencyPhone");
                item.EmergencyPhone2 = row.Field<string>("EmergencyPhone2");
                item.HomeAddress = row.Field<string>("HomeAddress");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationByFrenchiseIdAndStudentId(int pFrenchiseId, int pStudentId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationByFrenchiseIdAndStudentId(pFrenchiseId, pStudentId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationReportByFrenchiseId(int pFrenchiseId, int pReportType)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationReportByFrenchiseId(pFrenchiseId, pReportType);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationCanceledByFrenchiseId(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationCanceledByFrenchiseId(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
                item.HomePhone = row.Field<string>("HomePhone");
                item.BusinessPhone = row.Field<string>("BusinessPhone");
                item.StudentPhone = row.Field<string>("StudentPhone");
                item.HomeAddress = row.Field<string>("HomeAddress");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationSearchByFrenchiseId(int pFrenchiseId, string pValue)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationSearchByFrenchiseId(pFrenchiseId, pValue);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationById(int pId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.InsertName = row.Field<string>("InsertName");
                item.EducationPlanId = row.Field<int>("EducationPlanId");
                item.SavedChannelId = row.Field<int>("SavedChannelId");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationSmsStudentsListByListId(int pListId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationSmsStudentsListByListId(pListId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationReportBySearch(int pFrenchiseId, DateTime pStartDate, DateTime pEndDate, string pSavedUser)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationReportBySearch(pFrenchiseId, pStartDate, pEndDate, pSavedUser);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = row.Field<int>("StudentNumber");
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                item.StudentPhone = row.Field<string>("StudentPhone");
                item.HomePhone = row.Field<string>("HomePhone");
                item.BusinessPhone = row.Field<string>("BusinessPhone");
                item.EmergencyPhone = row.Field<string>("EmergencyPhone");
                item.EmergencyPhone2 = row.Field<string>("EmergencyPhone2");
                item.PesinOdeme = row.Field<double>("PesinOdeme");
                item.ToplamOdeme = row.Field<double>("ToplamOdeme");
                item.SavedPrice = row.Field<double>("SavedPrice");
                item.AcademicYearName = row.Field<string>("AcademicYearName");
                item.EducationPlanName = row.Field<string>("EducationPlanName");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetLessonProgramsByClassLessonHourIdAndLessonDate(int pClassLessonHourId, DateTime pLessonDate)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetLessonProgramsByClassLessonHourIdAndLessonDate(pClassLessonHourId, pLessonDate);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ClassId = row.Field<int>("ClassId");
                item.StudentSavedId = row.Field<int>("StudentSavedId");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.ClassPollingId = row.Field<int>("ClassPollingId");
                item.CameType = row.Field<int?>("CameType");
                item.LessonDate = row.Field<DateTime?>("LessonDate");
                //item.InsertBy = row.Field<int?>("InsertBy");
                //item.InsertDate = row.Field<DateTime?>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.ClassPollingStatus = row.Field<int?>("ClassPollingStatus");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cSavedInformation> GetSavedInformationBySpecialLessonId(int pFrenchiseId, int pLessonProgramId)
    {
        DataTable dt = new DataTable();
        List<cSavedInformation> List = new List<cSavedInformation>();

        dt = DAL.GetSavedInformationBySpecialLessonId(pFrenchiseId, pLessonProgramId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedInformation item = new cSavedInformation();
            {
                item.Id = row.Field<int>("Id");
                item.FrenchiseId = row.Field<int>("FrenchiseId");
                item.StudentId = row.Field<int>("StudentId");
                item.StudentNumber = new int?(row.Field<int>("StudentNumber"));
                item.AcademicYearId = row.Field<int?>("AcademicYearId");
                item.PriceId = row.Field<int?>("PriceId");
                item.SavedUser = row.Field<string>("SavedUser");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.ParentName = row.Field<string>("ParentName");
                //item.SchoolName = row.Field<string>("SchoolName");
                item.YearOfBirth = row.Field<DateTime>("YearOfBirth");
                item.MotherName = row.Field<string>("MotherName");
                item.FatherName = row.Field<string>("FatherName");
                //item.SavedPrice = row.Field<double>("SavedPrice");
                //item.AcademicYearName = row.Field<string>("AcademicYearName");
                //item.EducationPlanName = row.Field<string>("EducationPlanName");
                //item.ClassId = row.Field<int?>("ClassId");
                //item.ClassName = row.Field<string>("ClassName");
            }
            List.Add(item);
        }
        return List;
    }

    public static DataTable InsertSavedInformation(int pFrenchiseId, int pStudentId, int pAcademicYearId, int pEducationPlanId, int pPriceId, string pSavedUser, int pSavedChannelId, int pInsertBy)
    {
        return DAL.InsertSavedInformation(pFrenchiseId, pStudentId, pAcademicYearId, pEducationPlanId, pPriceId, pSavedUser, pSavedChannelId, pInsertBy);
    }

    public static void UpdateSavedInformationFast(int pId, int pAcademicYearId, string pSavedUser, int pUpdateBy)
    {
        DAL.UpdateSavedInformationFast(pId, pAcademicYearId, pSavedUser, pUpdateBy);
    }

    public static void ConfirmRegistrationSavedInformation(int pId)
    {
        DAL.ConfirmRegistrationSavedInformation(pId);
    }

    public static void CancelRegistrationSavedInformation(int pId)
    {
        DAL.CancelRegistrationSavedInformation(pId);
    }

    //public static void UpdateSavedInformation(int pId, int pFrenchiseId, int pStudentId, int pStudentNumber, int pAcademicYearId, int pPriceId, string pSavedUser, int pUpdateBy)
    //{
    //    DAL.UpdateSavedInformation(pId, pFrenchiseId, pStudentId, pStudentNumber, pAcademicYearId, pPriceId, pSavedUser, pUpdateBy);
    //}

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetSavedInformationByAll()
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByAll,
           MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod()));
    }
    public DataTable GetSavedInformationByFrenchiseId(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByFrenchiseId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }
    public DataTable GetSavedInformationActiveByFrenchiseId(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationActiveByFrenchiseId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }
    public DataTable GetSavedInformationPassiveByFrenchiseId(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationPassiveByFrenchiseId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }
    public DataTable GetSavedInformationByStundentClass(int pBranchId, int pClassId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByStundentClass,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pClassId));
    }
    public DataTable GetSavedInformationBySearchStundentClass(int pBranchId, int pClassId, string pValue)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationBySearchStundentClass,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pClassId, pValue));
    }
    public DataTable GetSavedInformationByNotClassStudentList(int pBranchId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByNotClassStudentList,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId));
    }
    public DataTable GetSavedInformationBySearchNotClassStudentList(int pBranchId, string pValue)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationBySearchNotClassStudentList,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pValue));
    }
    public DataTable GetSavedInformationByEducationPlanId(int pBranchId, int pEducationPlanId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByEducationPlanId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pEducationPlanId));
    }
    public DataTable GetSavedInformationByAcademicYearId(int pBranchId, int pAcademicYearId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByAcademicYearId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pAcademicYearId));
    }
    public DataTable GetSavedInformationBySearchEducationPlanId(int pBranchId, int pEducationPlanId, string pValue)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationBySearchEducationPlanId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pEducationPlanId, pValue));
    }
    public DataTable GetSavedInformationByClass(int pBranchId, int pClassId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByClass,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pClassId));
    }
    public DataTable GetSavedInformationBySearchClass(int pBranchId, int pClassId, string pValue)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationBySearchClass,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBranchId, pClassId, pValue));
    }
    public DataTable GetSavedInformationByFrenchiseIdAndStudentId(int pFrenchiseId, int pStudentId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationByFrenchiseIdAndStudentId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pStudentId));
    }
    public DataTable GetSavedInformationReportByFrenchiseId(int pFrenchiseId, int pReportType)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationReportByFrenchiseId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pReportType));
    }
    public DataTable GetSavedInformationCanceledByFrenchiseId(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationCanceledByFrenchiseId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }
    public DataTable GetSavedInformationSearchByFrenchiseId(int pFrenchiseId, string pValue)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationSearchByFrenchiseId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pValue));
    }
    public DataTable GetSavedInformationById(int pId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationById,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pId));
    }
    public DataTable GetSavedInformationBySpecialLessonId(int pFrenchiseId, int pLessonProgramId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationBySpecialLessonId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pLessonProgramId));
    }

    public DataTable InsertSavedInformation(int pFrenchiseId, int pStudentId, int pAcademicYearId, int pEducationPlanId, int pPriceId, string pSavedUser, int pSavedChannelId, int pInsertBy)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.InsertSavedInformation,
             MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pStudentId, pAcademicYearId, pEducationPlanId, pPriceId, pSavedUser, pSavedChannelId, pInsertBy));
    }

    public void UpdateSavedInformationFast(int pId, int pAcademicYearId, string pSavedUser, int pUpdateBy)
    {
        MsSqlHelper.ExecuteNonQuery(conString(), SpNameCollection.UpdateSavedInformationFast,
             MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pId, pAcademicYearId, pSavedUser, pUpdateBy));
    }

    public DataTable GetSavedInformationSmsStudentsListByListId(int pListId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationSmsStudentsListByListId,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pListId));
    }

    public DataTable GetSavedInformationReportBySearch(int pFrenchiseId, DateTime pStartDate, DateTime pEndDate, string pSavedUser)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetSavedInformationReportBySearch,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pStartDate, pEndDate, pSavedUser));
    }

    public DataTable GetLessonProgramsByClassLessonHourIdAndLessonDate(int pClassLessonHourId, DateTime pLessonDate)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conString(), SpNameCollection.GetLessonProgramsByClassLessonHourIdAndLessonDate,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pClassLessonHourId, pLessonDate));
    }

    public void CancelRegistrationSavedInformation(int pId)
    {
        MsSqlHelper.ExecuteNonQuery(conString(), SpNameCollection.CancelRegistrationSavedInformation,
             MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pId));
    }

    public void ConfirmRegistrationSavedInformation(int pId)
    {
        MsSqlHelper.ExecuteNonQuery(conString(), SpNameCollection.ConfirmRegistrationSavedInformation,
             MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pId));
    }
    public void Get_List_SavedInformation_Active_By_FrenchiseId(int pFrenchiseId)
    {
        MsSqlHelper.ExecuteNonQuery(conString(), SpNameCollection.ConfirmRegistrationSavedInformation,
             MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }

    //public void UpdateSavedInformation(int pId, int pFrenchiseId, int pStudentId, int pStudentNumber, int pAcademicYearId, int pPriceId, string pSavedUser, int pUpdateBy)
    //{
    //    MsSqlHelper.ExecuteNonQuery(conString(), SpNameCollection.UpdateSavedInformation,
    //        MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pId, pFrenchiseId, pStudentId, pStudentNumber, pAcademicYearId, pPriceId, pSavedUser, pUpdateBy));
    //}
}