﻿///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'Stencils'
// Generated by LLBLGen v1.0.2810.26788 Final on: Wednesday, October 11, 2010, 12:24:56 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using KTone.DAL.KTDBBaseLib;
using System.Xml;
using System.Collections.Generic;

namespace KTone.DAL.KTDAGlobaApplLib
{
    /// <summary>
    /// Purpose: Data Access class for the table 'Stencils'.
    /// </summary>
    public class Stencils : DBInteractionBase
    {
        #region Class Member Declarations
        private Boolean _isCustom, _assetVisibility;
        private DateTime _createdDate, _lastUpdated;
        private Int32 _stencilID, _noOfZones, _result, _dataOwnerId, _locationId;
        private String _name, _description, _configuration, _stencilData, _zoneName;


        

        #endregion


        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public Stencils()
        {
            // Nothing for now.
        }
        /// <summary>
        /// Purpose: Insert method. This method will insert one new row into the database.
        /// </summary>
        /// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>Name</LI>
        ///		 <LI>Description. May be SqlString.Null</LI>
        ///		 <LI>NoOfZones. May be SqlInt32.Null</LI>
        ///		 <LI>Configuration. May be SqlString.Null</LI>
        ///		 <LI>Category</LI>
        ///		 <LI>CreatedDate</LI>
        ///		 <LI>LastUpdated</LI>
        ///      <LI>AssetVisibility</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>StencilID</LI>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override bool Insert()
        {
            _log.Trace("Entering Insert - Table:Stencils ; Name:{0}," +
            "Description :{1}, NoOfZones:{2},Configuration:{3},IsCustom:{4}," +
            "CreatedDate:{5},LastUpdated:{6},AssetVisibility :{7}", _name, _description, _noOfZones, _configuration, _isCustom, _createdDate, _lastUpdated, _assetVisibility);

            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[pr_Stencils_Insert]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _name));
                cmdToExecute.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar, 100, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _description));
                cmdToExecute.Parameters.Add(new SqlParameter("@NoOfZones", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, _noOfZones));
                int length = 0;
                if (_configuration != string.Empty)
                {
                    length = _configuration.Length;
                }
                cmdToExecute.Parameters.Add(new SqlParameter("@IsCustom", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _isCustom));
                cmdToExecute.Parameters.Add(new SqlParameter("@Configuration", SqlDbType.Text, length, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _configuration));
                cmdToExecute.Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _createdDate));
                cmdToExecute.Parameters.Add(new SqlParameter("@LastUpdated", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _lastUpdated));
                cmdToExecute.Parameters.Add(new SqlParameter("@AssetVisibility", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _assetVisibility));
                cmdToExecute.Parameters.Add(new SqlParameter("@StencilID", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _stencilID));
                cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

                if (_mainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    _mainConnection.Open();
                }
                else
                {
                    if (_mainConnectionProvider.IsTransactionPending)
                    {
                        cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                cmdToExecute.ExecuteNonQuery();

                if (cmdToExecute.Parameters["@StencilID"].Value.ToString() != "")
                {
                    _stencilID = (Int32)cmdToExecute.Parameters["@StencilID"].Value;
                }
                else
                {
                    _stencilID = 0;
                }

                _errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

                if (_errorCode != 0)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_Stencils_Insert' reported the ErrorCode: " + _errorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                _log.Error("Insert:{0}", ex.Message);
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Stencils::Insert::Error occured.", ex);
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
                //
                _log.Trace("Exiting Insert");
            }
        }

        /// <summary>
        /// Purpose: Update method. This method will Update one existing row in the database.
        /// </summary>
        /// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>StencilID</LI>
        ///		 <LI>Name</LI>
        ///		 <LI>Description. May be SqlString.Null</LI>
        ///		 <LI>NoOfZones. May be SqlInt32.Null</LI>
        ///		 <LI>Configuration. May be SqlString.Null</LI>
        ///		 <LI>Category</LI>
        ///		 <LI>CreatedDate</LI>
        ///		 <LI>LastUpdated</LI>
        ///  <LI>AssetVisibility</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override bool Update()
        {
            _log.Trace("Entering UpdateStencil - Table:Location ; " +
            " LocationID:{0},ZoneName:{1}", _locationId, _zoneName);

            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[pr_LocationStencil_Update]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@LocationId", SqlDbType.Int, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _locationId));
                cmdToExecute.Parameters.Add(new SqlParameter("@StencilData", SqlDbType.VarChar, 2000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _stencilData));
                cmdToExecute.Parameters.Add(new SqlParameter("@ZoneName", SqlDbType.VarChar, 1000, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _zoneName));
                cmdToExecute.Parameters.Add(new SqlParameter("@DataOwnerId", SqlDbType.Int, 4, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _dataOwnerId));
                cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

                if (_mainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    _mainConnection.Open();
                }
                else
                {
                    if (_mainConnectionProvider.IsTransactionPending)
                    {
                        cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                cmdToExecute.ExecuteNonQuery();

                _errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;


                if (_errorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_LocationStencil_Update' reported the ErrorCode: " + _errorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                _log.Error("Insert:{0}", ex.Message);
                // some error occured. Bubble it to caller and encapsulate Exception object               

                throw new Exception("Location::Update::Error occured.", ex);

            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
                UpdateNotifyCacheUpdateTable();
                _log.Trace("Exiting UpdateStencil");
            }
        }

        /// <summary>
        /// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
        /// </summary>
        /// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>StencilID</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override bool Delete()
        {
            _log.Trace("Entering Delete - Table:Stencils ; StencilID:{0}", _stencilID);

            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[pr_Stencils_Delete]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@StencilID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _stencilID));
                cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

                if (_mainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    _mainConnection.Open();
                }
                else
                {
                    if (_mainConnectionProvider.IsTransactionPending)
                    {
                        cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                cmdToExecute.ExecuteNonQuery();
                _errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

                if (_errorCode != 0)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_Stencils_Delete' reported the ErrorCode: " + _errorCode);
                }

                return true;
            }
            catch (Exception ex)
            {
                _log.Error("Delete:{0}", ex.Message);
                // some error occured. Bubble it to caller and encapsulate Exception object
                //throw new Exception("AssetMaster::Delete::Error occured.", ex);
                throw ex;
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();

                _log.Trace("Exiting Delete");
            }
        }

        /// <summary>
        /// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
        /// </summary>
        /// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties needed for this method: 
        /// <UL>
        ///		 <LI>StencilID</LI>
        /// </UL>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        ///		 <LI>StencilID</LI>
        ///		 <LI>Name</LI>
        ///		 <LI>Description</LI>
        ///		 <LI>NoOfZones</LI>
        ///		 <LI>Configuration</LI>
        ///		 <LI>IsCustom</LI>
        ///		 <LI>Category</LI>
        ///		 <LI>CreatedDate</LI>
        ///		 <LI>LastUpdated</LI>
        ///  <LI>AssetVisibility</LI>
        /// </UL>
        /// Will fill all properties corresponding with a field in the table with the value of the row selected.
        /// </remarks>
        public override DataTable SelectOne()
        {
            _log.Trace("Entering SelectOne - Stencils");

            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[pr_Stencils_SelectOne]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("Stencils");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@StencilID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _stencilID));
                cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

                if (_mainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    _mainConnection.Open();
                }
                else
                {
                    if (_mainConnectionProvider.IsTransactionPending)
                    {
                        cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                adapter.Fill(toReturn);
                _errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

                if (_errorCode != 0)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_Stencils_SelectOne' reported the ErrorCode: " + _errorCode);
                }

                if (toReturn.Rows.Count > 0)
                {
                    _stencilID = (Int32)toReturn.Rows[0]["StencilID"];
                    _name = (string)toReturn.Rows[0]["Name"];
                    _description = toReturn.Rows[0]["Description"] == System.DBNull.Value ? String.Empty : (string)toReturn.Rows[0]["Description"];
                    _noOfZones = toReturn.Rows[0]["NoOfZones"] == System.DBNull.Value ? Int32.MinValue : (Int32)toReturn.Rows[0]["NoOfZones"];
                    _isCustom = (bool)toReturn.Rows[0]["IsCustom"];
                    _configuration = toReturn.Rows[0]["Configuration"] == System.DBNull.Value ? String.Empty : (string)toReturn.Rows[0]["Configuration"];
                    _createdDate = (DateTime)toReturn.Rows[0]["CreatedDate"];
                    _lastUpdated = (DateTime)toReturn.Rows[0]["LastUpdated"];
                    _assetVisibility = (bool)toReturn.Rows[0]["AssetVisibility"];
                }
                return toReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Stencils::SelectOne::Error occured.", ex);
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
                adapter.Dispose();

                _log.Trace("Exiting SelectOne - Delete");
            }
        }

        /// <summary>
        /// Purpose: SelectAll method. This method will Select all rows from the table.
        /// </summary>
        /// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
        /// <remarks>
        /// Properties set after a succesful call of this method: 
        /// <UL>
        ///		 <LI>ErrorCode</LI>
        /// </UL>
        /// </remarks>
        public override DataTable SelectAll()
        {
            _log.Trace("Entering SelectAll - Stencils");

            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[pr_Stencils_SelectAll]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("Stencils");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                cmdToExecute.Parameters.Add(new SqlParameter("@ErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _errorCode));

                if (_mainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    _mainConnection.Open();
                }
                else
                {
                    if (_mainConnectionProvider.IsTransactionPending)
                    {
                        cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                adapter.Fill(toReturn);
                _errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;

                if (_errorCode != 0)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'pr_Stencils_SelectAll' reported the ErrorCode: " + _errorCode);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("Stencils::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
                adapter.Dispose();
                _log.Trace("Exiting SelectAll - AssetMaster");
            }
        }


        #region Class Property Declarations

        // added new Properties
        public Int32 Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }

        public Int32 DataOwnerId
        {
            get
            {
                return _dataOwnerId;
            }
            set
            {
                _dataOwnerId = value;
            }
        }
        public Int32 LocationId
        {
            get
            {
                return _locationId;

            }
            set
            {
                _locationId = value;
            }
        }
        public String StencilData
        {
            get
            {
                return _stencilData;
            }

            set
            {
                _stencilData = value;
            }
        }

        public String ZoneName
        {
            get
            {
                return _zoneName;
            }
            set
            {
                _zoneName = value;
            }

        }


        //


        public Int32 StencilID
        {
            get
            {
                return _stencilID;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("StencilID", "StencilID can't be NULL");
                }
                _stencilID = value;
            }
        }




        public String Name
        {
            get
            {
                return _name;
            }
            set
            {

                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Name", "Name can't be NULL");
                }
                _name = value;
            }
        }


        public String Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }


        public Int32 NoOfZones
        {
            get
            {
                return _noOfZones;
            }
            set
            {
                _noOfZones = value;
            }
        }


        public String Configuration
        {
            get
            {
                return _configuration;
            }
            set
            {
                _configuration = value;
            }
        }

        public Boolean AssetVisibility
        {
            get
            {
                return _assetVisibility;
            }
            set
            {
                _assetVisibility = value;
            }
        }

        public Boolean IsCustom
        {
            get
            {
                return _isCustom;
            }
            set
            {
                _isCustom = value;
            }
        }

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
            }
        }


        public DateTime LastUpdated
        {
            get
            {
                return _lastUpdated;
            }
            set
            {
                if (value == (new DateTime()))
                {
                    throw new ArgumentOutOfRangeException("LastUpdated", "LastUpdated can't be NULL");
                }
                _lastUpdated = value;
            }
        }

        #endregion
    }
}