using System;

namespace Portsonic.Cppt.BizObjs.Core
{
    public class Client
    {
        #region variable declarations

        private String _platformUsername;
        private String _platformOs;

        #endregion

        #region public properties

        public String PlatformUsername
        {
            get { return _platformUsername; }
            set { _platformUsername = value; }
        }
        public String PlatformOs
        {
            get { return _platformOs; }
            set { _platformOs = value; }
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

        #endregion
    }
}