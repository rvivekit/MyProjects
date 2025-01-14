﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SJDealStore
{
    public class Constants
    {
        public string RFIDString = ConfigurationManager.ConnectionStrings["TrackerConnectionString"].ConnectionString;
        public string StoreID = "404";
        public string pr_UpdateDecommissionedItems = "pr_UpdateDecommissionedItems";
        public string pr_SelectProducts_OnRFID = "pr_SelectProducts_OnRFID";
        public string pr_GetProductDetailsForUPC = "pr_GetProductDetailsForUPC";
        public string pr_InsertProducts_OnSingleAssociation = "pr_InsertProducts_OnSingleAssociation";
        public string SalesIsDamaged = ConfigurationManager.AppSettings["SalesIsDamaged"].ToString();
        public string DeviceID = ConfigurationManager.AppSettings["DeviceID"].ToString();
        public string InsertMasterFile = "[Jarvis].[dbo].[SJDeals_InsertMasterFile]";
        public string InsertMasterFileDetails = "[Jarvis].[dbo].[SJDeals_InsertFileDetails]";
        public string SelectImportMaster = "SELECT [Sno],[FileName],[DateCreated],[Notes]  FROM [Jarvis].[dbo].[SJDeals_FileImportMaster]";
        public string SearchString = "[Jarvis].[dbo].[SJDeals_SearchString]";

        public string IncrementReceived =
            " UPDATE  [Jarvis].[dbo].[SJDeals_FileImportDetails] SET received = received+1 WHERE Sno={0}";

        public string IncrementDamaged = 
            " UPDATE  [Jarvis].[dbo].[SJDeals_FileImportDetails] SET damaged = damaged+1 WHERE Sno={0}";

        public string SjDealsSaveSettings = "[Jarvis].[dbo].[SJDeals_SaveSettings]";

        public string GetSettings = "SELECT * FROM [Jarvis].[dbo].[SJDeals_Settings] where [SJDealMasterSno] = {0}";

        public string TagLogger = "[Jarvis].[dbo].[SJDeals_TagLogger]";


        public string DecrementReceived =
          " UPDATE  [Jarvis].[dbo].[SJDeals_FileImportDetails] SET received = received-1 WHERE Sno={0}";

        public string DecrementDamaged =
            " UPDATE  [Jarvis].[dbo].[SJDeals_FileImportDetails] SET damaged = damaged-1 WHERE Sno={0}";
       

        public string SJDeals_GetDamagedReport = "[Jarvis].[dbo].[SJDeals_GetDamagedReport]";

        public string SJDeals_GetReceivedReport = "[Jarvis].[dbo].[SJDeals_GetReceivedReport]";

        public string SJDeals_DeleteReport = "[Jarvis].[dbo].[SJDeals_DeleteReport]";
        public string SJDeals_SquareLogger = "[Jarvis].[dbo].[SJDeals_SquareLogger]";

        public string SJDeals_CreateManifest = "[Jarvis].[dbo].[SJDeals_CreateManifest]";
        public string GetAllManifest = "select * from [Jarvis].[dbo].[SJDeals_ManifestMaster]";
        public string GetManifestMaster = "select * from [Jarvis].[dbo].[SJDeals_ManifestMaster] where sno={0}";

        public string GetManifestDetails = "select * from [Jarvis].[dbo].[SJDeals_ManifestDetail] where MasterID={0}";

        public string InsertItemInManifest = "[Jarvis].[dbo].[SJDeals_InsertItemInManifest]";

        public string IncManifestQty =
            "UPDATE [Jarvis].[dbo].[SJDeals_ManifestDetail] SET quantity =quantity +1  WHERE sno={0}";
        public string DecManifestQty =
            "UPDATE [Jarvis].[dbo].[SJDeals_ManifestDetail] SET quantity =quantity -1  WHERE sno={0}";

        public string DeleteManifestItem = "DELETE FROM [Jarvis].[dbo].[SJDeals_ManifestDetail]   WHERE sno={0}";

        public string AddNewItems = "[Jarvis].[dbo].[SJDeals_AddItems]";
        public string AddItemsWithReceiving = "[Jarvis].[dbo].[SJDeals_AddItemsWithReceiving]";

        public string GetItemsToBeImportedToSquare = "[Jarvis].[dbo].[SJDeals_GetItemsToBeImportedToSquare]";

        public string ShopKeepImport = "[Jarvis].[dbo].[SJDeals_ShopKeepImport]";
        public string ShopKeepDataDelete = "DELETE FROM [Jarvis].[dbo].[ShopKeep]";

         public string GetShopKeepItems = "[Jarvis].[dbo].[SJDeals_GetShopKeepItems]";
         public string EditItemsWithReceiving = "[Jarvis].[dbo].[SJDeals_EditItemsWithReceiving]";

    }
}