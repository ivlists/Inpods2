﻿using System;
using Automation.Development.Browsers;
using OpenQA.Selenium;
using System.Diagnostics;
using Automation.TestScripts;

namespace Automation.Development.Pages.Common
{
    /// <summary>
    /// Class for Menu item in site navigation header
    /// </summary>
    public class SiteNavigationMenu : HomeBase
    {
        #region Site Navigation elements

        private IWebElement homeTabControl;

        /// <summary>
        /// Gets Home Tab
        /// </summary>
        public IWebElement HomeTabControl
        {
            get { return homeTabControl; }
            private set { homeTabControl = value; }
        }

        private IWebElement adminTabControl;

        /// <summary>
        /// Gets Admin Tab
        /// </summary>
        public IWebElement AdminTabControl
        {
            get { return adminTabControl; }
            private set { adminTabControl = value; }
        }

        private IWebElement lessonTabControl; 

        /// <summary>
        /// Gets Lessons tab
        /// </summary>
        public IWebElement LessonTabControl
        {
            get { return lessonTabControl; }
            private set { lessonTabControl = value; }
        }

        private IWebElement assignmentTabControl;

        /// <summary>
        /// Gets Assignment tab
        /// </summary>
        public IWebElement AssignmentTabControl
        {
            get { return assignmentTabControl; }
            private set { assignmentTabControl = value; }
        }

        private IWebElement reportTabControl;

        /// <summary>
        /// Gets Reports tab
        /// </summary>
        public IWebElement ReportTabControl
        {
            get { return reportTabControl; }
            private set { reportTabControl = value; }
        }

        private IWebElement userOptionControl;

        /// <summary>
        /// Gets Users options
        /// </summary>
        public IWebElement UserOptionControl
        {
            get { return userOptionControl; }
            private set { userOptionControl = value; }
        }

        private IWebElement profileLinkControl;

        /// <summary>
        /// Gets Profile link
        /// </summary>
        public IWebElement ProfileLinkControl
        {
            get { return profileLinkControl; }
            private set { profileLinkControl = value; }
        }

        private IWebElement setPasswordQuestionLinkControl;
        
        /// <summary>
        /// Gets set passord questions link
        /// </summary>
        public IWebElement SetPasswordQuestionLinkControl
        {
            get { return setPasswordQuestionLinkControl; }
            private set { setPasswordQuestionLinkControl = value; }
        }

        private IWebElement changePasswordLinkControl;

        /// <summary>
        /// Gets change password link
        /// </summary>
        public IWebElement ChangePasswordLinkControl
        {
            get { return changePasswordLinkControl; }
            private set { changePasswordLinkControl = value; }
        }

        private IWebElement conatctSupportLinkControl;

        /// <summary>
        /// Gets contact supports link
        /// </summary>
        public IWebElement ConatctSupportLinkControl
        {
            get { return conatctSupportLinkControl; }
            private set { conatctSupportLinkControl = value; }
        }

        private IWebElement logOffLinkControl;

        /// <summary>
        /// Gets logoff link 
        /// </summary>
        public IWebElement LogOffLinkControl
        {
            get { return logOffLinkControl; }
            private set { logOffLinkControl = value; }
        }
        #endregion


        ObjectRepository objectRepository = null;
        string objectRepositoryFilePath = string.Empty;

        public SiteNavigationMenu(Browser browser): base(browser)
        {
            objectRepositoryFilePath = PrepareObjectRepositoryFilePath(EnumHelper.OfType(Page.SiteNav), EnumHelper.OfType(Role.Common));
            objectRepository = new ObjectRepository(objectRepositoryFilePath);
        }

        #region User control initialization functions
        /// <summary>
        /// To locate Schooltech Menu controls
        /// </summary>
        public void LocateSchoolTechMenuControls()
        {

            try
            {
                /// Home Tab
                bool ishomeTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Home"]);

                if (!ishomeTabControl)
                {
                    throw new Exception("Home Tab");
                }

                HomeTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Home"]);

                /// Admin Tab
                bool isadminTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Admin"]);

                if (!isadminTabControl)
                {
                    throw new Exception("Admin Tab");
                }

                AdminTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Admin"]);

                /// lessons Tab
                bool islessonTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Lessons"]);

                if (!islessonTabControl)
                {
                    throw new Exception("Lessons Tab");
                }

                LessonTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Lessons"]);

                /// Assignment Tab
                bool isassignmentTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Assignments"]);

                if (!isassignmentTabControl)
                {
                    throw new Exception("Assignments Tab");
                }

                AssignmentTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Assignments"]);

                /// Reports Tab
                bool isreportTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Reports"]);

                if (!isreportTabControl)
                {
                    throw new Exception("Reports Tab");
                }

                ReportTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Reports"]);

                // User Options tab
                bool isUserOptionControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["UserOption"]);

                if (!isUserOptionControl)
                {
                    throw new Exception("UserOption Tab");
                }

                UserOptionControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["UserOption"]);
            }
            catch (Exception exception)
            {
                new Exception("Navigation menu controls not found for Schooltech -" + exception.Message);
            }
        }

        /// <summary>
        /// To locate Teacher Menu controls
        /// TODO: Change the controls according to Teacher UI elements 
        /// </summary>
        public void LocateTeacherMenuControls()
        {

            /// Home Tab
            bool isHomeTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Home"]);

            if (!isHomeTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            HomeTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Home"]);

            /// Admin Tab
            bool isadminTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Admin"]);

            if (!isadminTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            AdminTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Admin"]);

            /// lessons Tab
            bool islessonTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Lessons"]);

            if (!islessonTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            LessonTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Lessons"]);

            /// Assignment Tab
            bool isassignmentTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Assignments"]);

            if (!isassignmentTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            AssignmentTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Assignments"]);

            /// Reports Tab
            bool isreportTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Reports"]);

            if (!isreportTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            ReportTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Reports"]);

            this.LocateUserOptionControls();
        }

        /// <summary>
        /// To locate Student Menu controls
        /// TODO: Change the controls according to studentUI elements
        /// </summary>
        public void LocateStudentMenuControls()
        {
            /// Home Tab
            bool isHomeTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Home"]);

            if (!isHomeTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            HomeTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Home"]);

            /// Admin Tab
            bool isadminTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Admin"]);

            if (!isadminTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            AdminTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Admin"]);

            /// lessons Tab
            bool islessonTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Lessons"]);

            if (!islessonTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            LessonTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Lessons"]);

            /// Assignment Tab
            bool isassignmentTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Assignments"]);

            if (!isassignmentTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            AssignmentTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Assignments"]);

            /// Reports Tab
            bool isreportTabControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Reports"]);

            if (!isreportTabControl)
            {
                throw new Exception("Home Tab not found");
            }

            ReportTabControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Reports"]);

            this.LocateUserOptionControls();
        }

        /// And menu controls for every other roles goes here
        #endregion 

        #region Public functions
        public UserProfilePage GoToUserProfile()
        {
            /// Click User Options tab
            bool isUserOptionControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["UserOption"]);

            if (!isUserOptionControl)
            {
                throw new Exception("UserOption Tab");
            }

            this.UserOptionControl.Click();

            this.LocateUserOptionControls();


            ProfileLinkControl.Click();

            /// return profiles page
            return new UserProfilePage(this.Browser);
        }
        #endregion 

        #region Helper methods
        private void LocateUserOptionControls()
        {
            try
            {
               
                /// User Profile Link
                bool isprofileLinkControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["Profile"]);

                if (!isprofileLinkControl)
                {
                    throw new Exception("Profile Link");
                }

                ProfileLinkControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["Profile"]);

                ///// Set password question link
                //bool isSetPasswordQuestionLinkControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["SetPasswordQestionLink"]);

                //if (!isSetPasswordQuestionLinkControl)
                //{
                //    throw new Exception("SetPasswordQestionLink");
                //}

                //SetPasswordQuestionLinkControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["SetPasswordQestionLink"]);

                ///// Change password link 
                //bool isChangePasswordLinkControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["ChangePasswordLink"]);

                //if (!isChangePasswordLinkControl)
                //{
                //    throw new Exception("ChangePasswordLink");
                //}

                //ChangePasswordLinkControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["ChangePasswordLink"]);

                ///// Contact suppport link
                //bool isConatctSupportLinkControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["ContactSupportLink"]);

                //if (!isConatctSupportLinkControl)
                //{
                //    throw new Exception("ContactSupportLink");
                //}

                //ConatctSupportLinkControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["ContactSupportLink"]);

                ///// Log off link
                //bool isLogOffLinkControl = this.WaitForElement("XPATH", (string)objectRepository.ObjectRepositoryTable["LogoffLink"]);

                //if (!isLogOffLinkControl)
                //{
                //    throw new Exception("LogoffLink");
                //}

                //LogOffLinkControl = this.FindControlByXPath((string)objectRepository.ObjectRepositoryTable["LogoffLink"]);
            }
            catch (Exception)
            { }
        }
        #endregion
    }
}