using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class SpNameCollection
{
    #region Users

    public static string LoginUsers = "Login_Users";
    public static string GetListByUsers = "Get_List_By_Users";
    public static string GetUsersById = "Get_Users_By_Id";
    public static string UpdateUsers = "Update_Users";
    public static string InsertUsers = "Insert_Users";

    #endregion

    #region SavedInformatin

    public static string GetSavedInformationByAll = "Get_List_SavedInformation_By_All";
    public static string GetSavedInformationByFrenchiseId = "Get_List_SavedInformation_By_FrenchiseId";
    public static string GetSavedInformationActiveByFrenchiseId = "Get_List_SavedInformation_Active_By_FrenchiseId";
    public static string GetSavedInformationPassiveByFrenchiseId = "Get_List_SavedInformation_Passive_By_FrenchiseId";
    public static string GetSavedInformationByStundentClass = "Get_List_SavedInformation_By_StundentClass";
    public static string GetSavedInformationBySearchStundentClass = "Get_List_SavedInformation_By_Search_StundentClass";
    public static string GetSavedInformationByNotClassStudentList = "Get_List_SavedInformation_By_NotClassStudentList";
    public static string GetSavedInformationBySearchNotClassStudentList = "Get_List_SavedInformation_By_Search_NotClassStudentList";
    public static string GetSavedInformationByClass = "Get_List_SavedInformation_By_Class";
    public static string GetSavedInformationByEducationPlanId = "Get_List_SavedInformation_By_EducationPlanId";
    public static string GetSavedInformationByAcademicYearId = "Get_List_SavedInformation_By_AcademicYearId";
    public static string GetSavedInformationBySearchEducationPlanId = "Get_List_SavedInformation_By_Search_EducationPlanId";
    public static string GetSavedInformationBySearchClass = "Get_List_SavedInformation_By_Search_Class";
    public static string GetSavedInformationByFrenchiseIdAndStudentId = "Get_List_SavedInformation_By_FrenchiseId_And_StudentId";
    public static string GetSavedInformationReportByFrenchiseId = "Get_List_SavedInformation_Report_By_FrenchiseId";
    public static string GetSavedInformationCanceledByFrenchiseId = "Get_List_SavedInformation_Canceled_By_FrenchiseId";
    public static string GetSavedInformationSearchByFrenchiseId = "Get_List_SavedInformation_Search_By_FrenchiseId";
    public static string GetSavedInformationById = "Get_Item_SavedInformation_By_Id";
    public static string GetSavedInformationBySpecialLessonId = "Get_List_SavedInformation_By_SpecialLessonId";
    public static string GetSavedInformationSmsStudentsListByListId = "Get_List_SavedInformation_SmsStudentsList_By_ListId";
    public static string GetSavedInformationReportBySearch = "Get_List_SavedInformation_Report_By_Search";
    public static string GetLessonProgramsByClassLessonHourIdAndLessonDate = "Get_List_LessonPrograms_By_ClassLessonHourId_And_LessonDate";
    public static string InsertSavedInformation = "Insert_SavedInformation";
    public static string UpdateSavedInformationFast = "Update_SavedInformation_Fast";
    public static string CancelRegistrationSavedInformation = "CancelRegistration_SavedInformation";
    public static string ConfirmRegistrationSavedInformation = "ConfirmRegistration_SavedInformation";
    public static string UpdateSavedInformation = "Update_SavedInformation";

    #endregion

    #region Products

    public static string GetProductsByAll = "Get_List_Products_By_All";
    public static string GetProductsById = "Get_Item_Products_By_Id";
    public static string GetProductsByBarcode = "Get_Item_Products_By_Barcode";
    public static string GetProductsByStockCount = "Get_List_Products_By_StockCount";
    public static string UpdateProducts = "Update_Products";
    public static string InsertProducts = "Insert_Products";
    public static string InsertStockMovements = "Insert_Stock_Movements";

    #endregion
    //GetStockByAll
    #region Stock
    public static string GetStockByAll = "Get_Stock_By_All";
    public static string GetListProductsByStockCount= "Get_List_Products_By_StockCount";
    #endregion

    #region UserTypes
    public static string GetUserTypesByAll = "Get_User_Types_By_All";
    #endregion

    #region StudentCard

    public static string GetSavedUserByCardNumber = "Get_Item_SavedUser_By_CardNumber";
    public static string GetSavedUserCreditByCardNumber = "Get_Item_SavedUser_Credit_By_CardNumber";
    public static string InsertSavedUsers = "Insert_SavedUsers";

    #endregion

    #region ProductSales

    public static string GetProductSalesByStock = "Get_Product_Sales_By_Stock";
    public static string InsertProductSales = "Insert_Product_Sales";

    #endregion

    #region SavedUsersCredit

    public static string GetSavedUsersCredit = "Get_Saved_Users_Credit";
    public static string InsertAmount = "Insert_Amount";

    #endregion
}