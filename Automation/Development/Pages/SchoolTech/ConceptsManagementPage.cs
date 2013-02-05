﻿using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using System.Text;
using Automation.Development.Browsers;
using Automation.TestScripts;

namespace Automation.Development.Pages.SchoolTech
{
    /// <summary>
    /// Concept management page class
    /// TODO: Add UI Controls and corresponding Helper methods
    /// </summary>
    public class ConceptsManagementPage : SchoolTechNavigationMenu
    {
        #region Concepts management page controls
        /// TODO: Add UI Elements
        #endregion

        /// <summary>
        /// SchoolTech Object Repository
        /// </summary>
        ObjectRepository objectRepository = null;

        /// <summary>
        /// school tech Object repository path
        /// </summary>
        string objectRepositoryFilePath = string.Empty;

        /// <summary>
        /// Concepts management page constructor
        /// </summary>
        /// <param name="browser"></param>
        public ConceptsManagementPage(Browser browser)
            : base(browser)
        {
            /// Initiate User management page object repository
            try
            {
                /// TODO: see if this work
                /// objectRepositoryFilePath = PrepareObjectRepositoryFilePath(EnumHelper.OfType(Role.SchoolTech), Enum.GetName(typeof(Page), Page.LoginPage));
                objectRepositoryFilePath = PrepareObjectRepositoryFilePath(EnumHelper.OfType(Role.SchoolTech), EnumHelper.OfType(Page.ConceptManagementPage));
                objectRepository = new ObjectRepository(objectRepositoryFilePath);
                this.LocateControls();
            }
            catch (Exception e)
            {
                throw new Exception("Error locating" + e.Message);
            }
        }

        #region Helper Methods
        /// <summary>
        /// Method to locate Concept management page controls
        /// </summary>
        private void LocateControls()
        {
            /// TODO: Locate all controls
        }
        #endregion
    }
}
