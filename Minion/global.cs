﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Tamir.SharpSsh;


namespace Minion
{
    public class global
    {
        /// <summary>
        /// Server side connectivity info
        /// </summary>
        public static string DIRECTORY { get { return ConfigurationManager.AppSettings["DIRECTORY"]; } }
        private static string host = "";
        private static string stype = "";
        private static string usr = "";
        private static string pass = "";
        private static string status = "";
        private static bool auth;

        public static bool auth_server
        {
            get { return auth; }
            set { auth = value; }
        }
        public static string ssh_type
        {
            get { return stype; }
            set { stype = value; }
        }
        public static string ssh_host
        {
            get { return host; }
            set { host = value; }
        }
        public static string ssh_usr
        {
            get { return usr; }
            set { usr = value; }
        }
        public static string ssh_pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public static string ssh_status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// analysis info
        /// </summary>
        private static string rtype = "";
        private static string date = "";
        private static string duration = "";
        private static string dir = "";
        private static string var_file_name = "";
        private static string val_file_name1 = "";
        private static string val_file_name2 = "";
        public static StringBuilder sb;

        public static string var_reg_file_name
        {
            get { return var_file_name; }
            set { var_file_name = value; }
        }
        public static string val_reg_file_name
        {
            get { return val_file_name1; }
            set { val_file_name1 = value; }
        }
        public static string val_var_file_name
        {
            get { return val_file_name2; }
            set { val_file_name2 = value; }
        }
        public static string run_type
        {
            get { return rtype; }
            set { rtype = value; }
        }
        public static string run_date
        {
            get {return date ;}
            set { date = value; }
        }
        public static string run_duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public static string run_dir
        {
            get { return dir; }
            set { dir = value; }
        }
        public static string run_output
        {
            get { return sb.ToString(); }
        }
    }

}
