using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SecondWeb.Models
{
    public class Procs
    {
        public static string Getconnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
            }
        }
        public static void ContactDetail(string FullName,string Email,string Subjects,string Messages)
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("ContactDetail", con);
            cmd.Parameters.AddWithValue("@FullName", FullName);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Subjects", Subjects);
            cmd.Parameters.AddWithValue("@Messages", Messages);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally { con.Close(); }
        }
        public static int CheckUser (string email,string pwd)
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("CheckUser", con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.CommandType = CommandType.StoredProcedure;
            int id = 0;
            try
            {
                con.Open();
                var res = cmd.ExecuteScalar();
                if (res != null)
                {
                    id = Convert.ToInt32(res);
                }
            }
            catch (Exception) { }
            finally { con.Close(); }
            return id;
        }
        public static DataTable OurPortfolioProc()
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("OurPortfolioProc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static DataTable MyHome()
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("MyHome", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static DataTable MyProduct()
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("MyProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static DataTable TheTeams()
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("TheTeams", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static DataTable Enquiries()
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("Enquiries", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static DataTable GetEnquiry(string FullName = null)
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("GetEnquiry", con);
            cmd.Parameters.AddWithValue("@Name", FullName);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static DataTable MyServices()
        {
            SqlConnection con = new SqlConnection(Getconnection);
            SqlCommand cmd = new SqlCommand("MyServices", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
    }
}