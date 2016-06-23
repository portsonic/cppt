using System;

namespace Portsonic.Cppt.BizObjs.Core
{
    public class Client
    {
        #region variable declarations

        private String _platformUsername;
        private PlatformOS _platformOs;
        private PlatformDirectory _platformDirectory;
        private PlatformSettings _platformSettings;

        #endregion

        #region public properties

        public String PlatformUsername
        {
            get { return _platformUsername; }
            set { _platformUsername = value; }
        }
        public PlatformOS PlatformOs
        {
            get { return _platformOs; }
            set { _platformOs = value; }
        }
        public PlatformDirectory PlatformDirectory
        {
            get { return _platformDirectory; }
            set { _platformDirectory = value; }
        }
        public PlatformSettings PlatformSettings
        {
            get { return _platformSettings; }
            set { _platformSettings = value; }
        }

        #endregion

        #region constructor

        public Client()
        {
            try
            {
                //Nothing to do
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region custom methods

        public void LoadPlatformOS()
        {
            try
            {
                //Load up the PLatformOS object

                //TODO - code to obtain Linux (uname -r for the kernel or lsb_release -a for more to parse on)

                //TODO - code to obtain Chrome OS (cross-check syntaxes)

                //TODO - code to obtain Windows (Focus on Bash shell integration under Windows 10 until 
                //                               Windows 10 has been completely cutover to underlying CoreOS)

                //TODO - code to obtain Mac OS (cross-check syntaxes)
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadPlatformDirectory()
        {
            try
            {
                //Load up the PLatformDirectory object

                //TODO - code for Linux (OpenLDAP support)

                //TODO - code for Chrome OS (OpenLDAP support)

                //TODO - code for Windows (Focus on Bash shell integration under Windows 10 until 
                //                         Windows 10 has been completely cutover to underlying CoreOS
                //                         Active Directory ports via Bash on initial runs, see about legacy
                //                         hooks and viability of on premise enterprise with cloud
                //                         since OpenLDAP could also work here with the standard
                //                         UI custom to Microsoft System Administrators)

                //TODO - code to obtain Mac OS (OpenLDAP support)
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadPlatformSettings()
        {
            try
            {
                //Load up the PLatformSettings object

                //TODO - code to obtain Linux (flat file)

                //TODO - code to obtain Chrome OS (flat file)

                //TODO - code to obtain Windows (is app.config really relevant or Bash out to flat file)

                //TODO - code to obtain Mac OS (flat file)
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}