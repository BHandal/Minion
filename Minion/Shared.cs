using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Deployment.Application;

namespace Minion
{
    public static class Shared
    {

        #region Assembly Attribute Accessors

        public static Version AssemblyVersion
        {
            get
            {
                try
                {
                    return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                }
                catch
                {
                    return Assembly.GetExecutingAssembly().GetName().Version;
                }
            }
        }
        public static string AssemblyProduct
        {
            get
            {
                object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((System.Reflection.AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        public static string AssemblyCompany
        {
            get
            {
                object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((System.Reflection.AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

    }
}
