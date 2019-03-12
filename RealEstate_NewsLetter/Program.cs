using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_NewsLetter
{
    class Program
    {

        static string qry = "";
        static string OrderNo = "";
        static string Email = "";
        static string NewsLetterUrl = "";
        static string Name = "";
        static string FirstImage = "";
        static string SecondImage = "";
        static int NewsLetterId = 0;
        static int UserId = 0;
        static bool IsNewsLetterSendOrNOt = true;
        static  string EMailAddress = "";
        static  string EmailPassword = "";
        static string dbname = "";
        static void Main(string[] args)
        {

            SqlConnection Shveta_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Shveta_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Shveta_conn";
            Execute_NewsLetter(Shveta_conn);

            SqlConnection Jay_Singh_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Jay_Singh_conn"].ConnectionString.ToString());
            EMailAddress = "sellwithjaynews@gmail.com";
            EmailPassword = "SellWithJay";
            dbname = "Jay_Singh_conn";
            Execute_NewsLetter(Jay_Singh_conn);

            SqlConnection Raja_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Raja_conn"].ConnectionString.ToString());
            EMailAddress = "dontreply081@gmail.com";
            EmailPassword = "!nd!@123";
            dbname = "Raja_conn";
            Execute_NewsLetter(Raja_conn);

            SqlConnection Bobby_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Bobby_conn"].ConnectionString.ToString());
            EMailAddress = "homefinderingta@gmail.com";
            EmailPassword = "Website@2019";
            dbname = "Bobby_conn";
            Execute_NewsLetter(Bobby_conn);

            SqlConnection Mitesh_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Mitesh_conn"].ConnectionString.ToString());
            EMailAddress = "miteshtrivedi777@gmail.com";
            EmailPassword = "CoMputer66";
            dbname = "Mitesh_conn";
            Execute_NewsLetter(Mitesh_conn);

            SqlConnection Gurmail_Kamboj_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Gurmail_Kamboj_conn"].ConnectionString.ToString());
            EMailAddress = "realtorgurmailkambojnews@gmail.com";
            EmailPassword = "Only4agents";
            dbname = "Gurmail_Kamboj_conn";
            Execute_NewsLetter(Gurmail_Kamboj_conn);

            SqlConnection Pankaj_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Pankaj_conn"].ConnectionString.ToString());
            EMailAddress = "dontreply081@gmail.com";
            EmailPassword = "!nd!@123";
            dbname = "Pankaj_conn";
            Execute_NewsLetter(Pankaj_conn);

            SqlConnection TeamSinghKaur_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TeamSinghKaur_conn"].ConnectionString.ToString());
            EMailAddress = "agentsidhunews@gmail.com";
            EmailPassword = "Kalagora";
            dbname = "TeamSinghKaur_conn";
            Execute_NewsLetter(TeamSinghKaur_conn);
            SqlConnection Shallu_Sharma_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Shallu_Sharma_conn"].ConnectionString.ToString());
            EMailAddress = "realtorshallunews@gmail.com";
            EmailPassword = "sharma1234";
            dbname = "Shallu_Sharma_conn";
            Execute_NewsLetter(Shallu_Sharma_conn);

            SqlConnection Sheikh_Kashif_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Sheikh_Kashif_conn"].ConnectionString.ToString());
            EMailAddress = "hotlineproperties@gmail.com";
            EmailPassword = "hotline-786";
            dbname = "Sheikh_Kashif_conn";
            Execute_NewsLetter(Sheikh_Kashif_conn);

            SqlConnection SatishSharma_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SatishSharma_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "SatishSharma_conn";
            Execute_NewsLetter(SatishSharma_conn);

            SqlConnection Vipan_Jassal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Vipan_Jassal_conn"].ConnectionString.ToString());
            EMailAddress = "homegreathome1@gmail.com";
            EmailPassword = "Vjassal20@";
            dbname = "Vipan_Jassal_conn";
            Execute_NewsLetter(Vipan_Jassal_conn);

            SqlConnection AjayShah_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AjayShah_conn"].ConnectionString.ToString());
            EMailAddress = "dontreply081@gmail.com";
            EmailPassword = "!nd!@123";
            dbname = "AjayShah_conn";
            Execute_NewsLetter(AjayShah_conn);

            SqlConnection Rajiv_Bakshi_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Rajiv_Bakshi_conn"].ConnectionString.ToString());
            EMailAddress = "buysellrentrealestatenews@gmail.com";
            EmailPassword = "01Seemraj";
            dbname = "Rajiv_Bakshi_conn";
            Execute_NewsLetter(Rajiv_Bakshi_conn);

            SqlConnection Gunjan_Virk_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Gunjan_Virk_conn"].ConnectionString.ToString());
            EMailAddress = "dontreply081@gmail.com";
            EmailPassword = "!nd!@123";
            dbname = "Gunjan_Virk_conn";
            Execute_NewsLetter(Vipan_Jassal_conn);

            SqlConnection Seeya_Shah_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Seeya_Shah_conn"].ConnectionString.ToString());
            dbname = "Seeya_Shah_conn"; EMailAddress = "seeyatherealtornews@gmail.com";
            EmailPassword = "Aceg13579";
            Execute_NewsLetter(Seeya_Shah_conn);

            SqlConnection Manjit_Kundhal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Manjit_Kundhal_conn"].ConnectionString.ToString());
            EMailAddress = "hotlineproperties@gmail.com";
            EmailPassword = "hotline-786";
            dbname = "Manjit_Kundhal_conn";
            Execute_NewsLetter(Manjit_Kundhal_conn);

            SqlConnection Dalip_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Dalip_conn"].ConnectionString.ToString());
            EMailAddress = "realtorfaranews@gmail.com";
            EmailPassword = "Homelife12";
            dbname = "Dalip_conn";
            Execute_NewsLetter(Dalip_conn);


























            SqlConnection RajGuru_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RajGuru_conn"].ConnectionString.ToString());
            EMailAddress = "agentsidhunews@gmail.com";
            EmailPassword = "Kalagora";
            dbname = "RajGuru_conn";
            Execute_NewsLetter(RajGuru_conn);


            SqlConnection Dev_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Dev_conn"].ConnectionString.ToString());
            EMailAddress = "realtordevshahnews@gmail.com";
            EmailPassword = "realtordevshah";
            dbname = "Dev_conn";
            Execute_NewsLetter(Dev_conn);

            SqlConnection Charanjit_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Charanjit_conn"].ConnectionString.ToString());
            EMailAddress = "realtorpanglianews@gmail.com";
            EmailPassword = "Website2018";
            dbname = "Charanjit_conn";
            Execute_NewsLetter(Charanjit_conn);

            SqlConnection Harvinder_Sohi_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Harvinder_Sohi_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Harvinder_Sohi_conn";
            Execute_NewsLetter(Harvinder_Sohi_conn);
            

            SqlConnection Nikita_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Nikita_conn"].ConnectionString.ToString());
            EMailAddress = "Nikigandhirealtornews@gmail.com";
            EmailPassword = "only4agents";
            dbname = "Nikita_conn";
            Execute_NewsLetter(Nikita_conn);

            SqlConnection Rashpal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Rashpal_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Rashpal_conn";
            Execute_NewsLetter(Rashpal_conn);

            SqlConnection Sudesh_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Sudesh_conn"].ConnectionString.ToString());
            dbname = "Sudesh_conn"; EMailAddress = "Realtorsudeshnews@gmail.com";
            EmailPassword = "website2018";
            Execute_NewsLetter(Sudesh_conn);

            SqlConnection Team_Sidhu_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Team_Sidhu_conn"].ConnectionString.ToString());
            EMailAddress = "agentsidhunews@gmail.com";
            EmailPassword = "Kalagora";
            dbname = "Team_Sidhu_conn";
            Execute_NewsLetter(Team_Sidhu_conn);

            SqlConnection Suchi_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Suchi_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Suchi_conn";
            Execute_NewsLetter(Suchi_conn);

            SqlConnection Fara_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Fara_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Fara_conn";
            Execute_NewsLetter(Fara_conn);


            SqlConnection Suresh_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Suresh_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Suresh_conn";
            Execute_NewsLetter(Suresh_conn);

            SqlConnection Rohit_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Rohit_conn"].ConnectionString.ToString());
            EMailAddress = "newsfromaggarwalrealty@gmail.com";
            EmailPassword = "Usethis12";
            dbname = "Rohit_conn";
            Execute_NewsLetter(Rohit_conn);

            SqlConnection Ranbir_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Ranbir_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Ranbir_conn";
            Execute_NewsLetter(Ranbir_conn);

            SqlConnection Varinder_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Varinder_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Varinder_conn";
            Execute_NewsLetter(Varinder_conn);

            SqlConnection Condo_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Condo_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Condo_conn";
            Execute_NewsLetter(Condo_conn);

            SqlConnection Parag_Tandon_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Parag_Tandon_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Parag_Tandon_conn";
            Execute_NewsLetter(Parag_Tandon_conn);

            SqlConnection Hetal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hetal_conn"].ConnectionString.ToString());
            EMailAddress = "hetalthakerrealtornews@gmail.com";
            EmailPassword = "News2018";
            dbname = "Hetal_conn";
            Execute_NewsLetter(Hetal_conn);


            SqlConnection Parm_Grewal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Parm_Grewal_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Parm_Grewal_conn";
            Execute_NewsLetter(Parm_Grewal_conn);

            SqlConnection Praba_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Praba_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Praba_conn";
            Execute_NewsLetter(Praba_conn);

            SqlConnection Sanjiv_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Sanjiv_conn"].ConnectionString.ToString());
            EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            dbname = "Sanjiv_conn";
            Execute_NewsLetter(Sanjiv_conn);

            SqlConnection Yadwinder_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Yadwinder_conn"].ConnectionString.ToString());
            dbname = "Yadwinder_conn"; EMailAddress = "only4agentss@gmail.com";
            EmailPassword = "only4agents@123";
            Execute_NewsLetter(Yadwinder_conn);

            SqlConnection Satish_Patil_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Satish_Patil_conn"].ConnectionString.ToString());
            dbname = "Satish_Patil_conn"; EMailAddress = "realtorsatishnews@gmail.com";
            EmailPassword = "HhneSD033";
            Execute_NewsLetter(Satish_Patil_conn);
        }

        public static void Execute_NewsLetter(SqlConnection conn)
        {
            qry = "";
            qry = "select top(100) *  from AdminClient where IsGreetingsEmailSend=0 or IsGreetingsEmailSend is null";
            var LocalCount = 0;
            try
            {
                DataTable dt = GetdataTable(qry, conn);
                //if(dt.Rows.Count<=0)
                //{
                //    qry = "";
                //    qry = "Update AdminClient set IsEmailSend=0";
                //    GetdataTable(qry, conn);
                //}
                int daysdifference = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["EmailId"] != System.DBNull.Value)
                    {

                        var Email = row["EmailId"].ToString();
                        var Name = row["Name"].ToString();
                        var AdminId = Convert.ToInt32(row["ID"]);


                        qry = "";
                        qry = "select *  from Greetings where IsActive=1";
                        DataTable NewsLetter_dt = GetdataTable(qry, conn);


                        //if (NewsLetter_dt.Rows.Count <= 0)
                        //{
                        //    qry = "";
                        //    qry = "select top(1) *  from NewsLetter";
                        //    NewsLetter_dt = GetdataTable(qry, conn);


                        //}

                        var todayDate = DateTime.Now;
                        if (NewsLetter_dt.Rows.Count > 0)
                        {
                            foreach (DataRow NewsLetter in NewsLetter_dt.Rows)
                            {
                                LocalCount++;
                                var NewsLetterPath = NewsLetter["Image"].ToString();

                                if (NewsLetter["second_image"].ToString() != null && NewsLetter["second_image"].ToString() != "")
                                {
                                    NewsLetterPath += "," + NewsLetter["second_image"].ToString();
                                }
                                var NewsLetterDate = NewsLetter["fwd_date"].ToString();

                                if (NewsLetterDate != "" && NewsLetterDate != null)
                                {
                                    //var SelectedUsers = NewsLetter["SelectedUsers"].ToString();
                                   
                                    var OrderNo = NewsLetter["OrderNo"].ToString();
                                    var diffi = todayDate - Convert.ToDateTime(NewsLetterDate);
                                   
                                    //this functionality set bqs gmail provide only 100 emails free in one day. 
                                    if (diffi.Days < 15 && diffi.Days >= 0)
                                    {
                                       
                                        SendNewsLetter(Email, NewsLetterPath);
                                        //Update in Users table for send conform emails.
                                        if (AdminId != 0)
                                        {
                                            qry = "";
                                            qry = "Update AdminClient set IsGreetingsEmailSend=1 where ID=" + AdminId + " ";
                                            ExecuteNonQuery(qry, conn);
                                        }
                                        //End

                                       
                                    }

                                }
                              

                            }
                        }

                    }

                }
                qry = "";
                qry = "select *  from Greetings where IsActive=1";
                DataTable NewsLetter_dtt = GetdataTable(qry, conn);
                var nowDate = DateTime.Now;
                if (NewsLetter_dtt.Rows.Count > 0)
                {
                    foreach (DataRow NewsLetter in NewsLetter_dtt.Rows)
                    {
                        var id = NewsLetter["GreetingsId"].ToString();
                        var NewsLetterDate = NewsLetter["fwd_date"].ToString();
                       var days = nowDate - Convert.ToDateTime(NewsLetterDate);
                        daysdifference = days.Days;
                        //if diffi.days equal to 14 than activate the next newsletter.
                        if (daysdifference == 14)
                        {
                            int OdrNo = 0;
                            if (OrderNo != "")
                            {
                                OdrNo = Convert.ToInt32(OrderNo);
                                OdrNo++;
                            }

                            //update the old orderNo.
                            //qry = "";
                            //qry = "Update NewsLetter set IsActive=null where IsActive=1";
                            //ExecuteNonQuery(qry, conn);

                            //Set the new orderNo.
                            qry = "";
                            qry = "Update Greetings set IsActive=0 where GreetingsId=" + id + "";
                            ExecuteNonQuery(qry, conn);

                            qry = "";
                            qry = "Update AdminClient set IsGreetingsEmailSend=0";
                            GetdataTable(qry, conn);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                WriteLog(ex.Message.ToString()+ "in Execute_NewsLetter function.");
                SqlConnection rajpal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["rajpal_conn"].ConnectionString.ToString());


                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                sql = "insert into errorlog ([DBname],[message],[EmailId]) values('" + dbname + "','" + ex.Message.ToString() + "in Execute_NewsLetter function. (greetings)" + "','" + Email + "')";
                try
                {
                    rajpal_conn.Open();
                    adapter.InsertCommand = new SqlCommand(sql, rajpal_conn);
                    adapter.InsertCommand.ExecuteNonQuery();

                }
                catch (Exception ex1)
                {
                    rajpal_conn.Close();
                }
            }


        }

        public static void ReadyToNextNewsLetter(SqlConnection con)
        {

            try
            {
                int OdrNo = 0;
                if (OrderNo != "")
                {
                    OdrNo = Convert.ToInt32(OrderNo);
                    OdrNo++;
                }
                //Set the new orderNo.
                qry = "";
                qry = "Update Greetings set IsActive=1 where OrderNo=" + OdrNo + "";
                ExecuteNonQuery(qry, con);
                WriteLog("Ready to Greetings successfully updated.");
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message.ToString()+ "in ReadyToNextNewsLetter function.");
                SqlConnection rajpal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["rajpal_conn"].ConnectionString.ToString());


                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                sql = "insert into errorlog ([DBname],[message],[EmailId]) values('" + dbname + "','" + ex.Message.ToString() + "in ReadyToNextNewsLetter function (greetings)." + "','" + Email + "')";
                try
                {
                    rajpal_conn.Open();
                    adapter.InsertCommand = new SqlCommand(sql, rajpal_conn);
                    adapter.InsertCommand.ExecuteNonQuery();

                }
                catch (Exception ex1)
                {
                    rajpal_conn.Close();
                }
            }


        }

        public static DataTable GetdataTable(string qry, SqlConnection con)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter NewsLetter_Adp = new SqlDataAdapter(qry, con);
            NewsLetter_Adp.Fill(dt);

            return dt;

        }

        public static string ExecuteNonQuery(string QStr, SqlConnection con)
        {
            string ErrorMessage = "";
            SqlCommand cmd = null;
            try
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                cmd = new SqlCommand(QStr, con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();

                ErrorMessage = "";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    ErrorMessage = "FK";
                }
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (con != null)
                {
                    con.Close();
                }

            }

            return ErrorMessage;
        }
        public static void WriteLog(string Message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("==============================================================================" + Environment.NewLine);
            sb.Append("Event occurred on : " + DateTime.Now + Environment.NewLine);
            sb.Append(Message + Environment.NewLine);
            sb.Append("==============================================================================" + Environment.NewLine);

            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\ErrorLog.txt";

            System.IO.File.AppendAllText(path.Replace("file:\\", ""), sb.ToString());
            //System.IO.File.WriteAllText(path.Replace("file:\\", ""), sb.ToString());
        }
        public static bool SendNewsLetter(string Email, string Path)
        {
            //Email = "Only4agentss@gmail.com";
            //Send mail
            bool status = false;
            MailMessage mail = new MailMessage();
            var FirstImg = "";
            var SecondImg = "";
            if (Path.IndexOf(',') > -1)
            {
                var splitedpath = Path.Split(',');
                FirstImg = splitedpath[0].ToString();
                SecondImg = splitedpath[1].ToString();
            }
            else
            {
                FirstImg = Path;
            }


            try
            {
                string FromEmailID = "";
                string FromEmailPassword = "";

                if (EMailAddress != "" && EmailPassword != "")
                {
                    FromEmailID = EMailAddress;
                    FromEmailPassword = EmailPassword;
                }
                else
                {
                    FromEmailID = ConfigurationManager.AppSettings["FromEmailID"];
                    FromEmailPassword = ConfigurationManager.AppSettings["FromEmailPassword"];
                }
               if(FromEmailID== "donotreply@teammurria.com")
                {
                    SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer1and1"]);
                }
                else
                {
                    SmtpClient smtpClient = new SmtpClient(ConfigurationManager.AppSettings["SmtpServer"]);
                }
                int _Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"].ToString());
                Boolean _UseDefaultCredentials = Convert.ToBoolean(ConfigurationManager.AppSettings["UseDefaultCredentials"].ToString());
                Boolean _EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"].ToString());
                mail.To.Add(new MailAddress(Email));
                mail.From = new MailAddress(FromEmailID);
                mail.Subject = "Greetings";
                string msgbody = "";
               
                if (dbname == "Parag_Tandon_conn"
                     || dbname == "Vipan_Jassal_conn"
                     || dbname == "AjayShah_conn"
                     || dbname == "Rajiv_Bakshi_conn"
                     || dbname == "Gunjan_Virk_conn"
                     || dbname == "Jay_Singh_conn"
                     || dbname == "Gurmail_Kamboj_conn"
                     || dbname == "Shallu_Sharma_conn"
                     || dbname == "Sheikh_Kashif_conn"
                     || dbname == "Seeya_Shah_conn"
                     || dbname == "Sudesh_conn" 
                     || dbname == "Manjit_Kundhal_conn"
                     || dbname == "Dalip_conn" 
                     || dbname == "Satish_Patil_conn"
                     || dbname == "Rajguru_conn" 
                     || dbname == "Mitesh_conn"
                       || dbname == "Bobby_conn"
                     || dbname == "Raja_conn"

                      || dbname == "Pankaj_conn"
                     || dbname == "TeamSinghKaur_conn"
                    || dbname == "Team_Sidhu_conn" || dbname == "Dev_conn" || dbname == "Harvinder_Sohi_conn" || dbname == "Charanjit_conn" || dbname == "Nikita_conn" || dbname== "Fara_conn" || dbname == "SatishSharma_conn" || dbname== "Rashpal_conn"|| dbname== "Suchi_conn" || dbname == "Suresh_conn" || dbname == "Rohit_conn" || dbname == "Varinder_conn"||dbname== "Ranbir_conn" || dbname == "Condo_conn" || dbname == "Sanjiv_conn" || dbname == "Praba_conn" || dbname == "Hetal_conn" || dbname == "Shveta_conn" )
                {
                    string url = dbname + "_LiveURL";
                    FirstImg = ConfigurationManager.AppSettings[url].ToString() + "uploadfiles/" + FirstImg;
                    SecondImg = ConfigurationManager.AppSettings[url].ToString() + "uploadfiles/" + SecondImg;
                }
                if (dbname == "Parag_Tandon_conn")
                {
                    using (StreamReader reader = new StreamReader(@"C:\sites\RealEstate_NewsLetter\RealEstate_NewsLetter\Templates\SixNewLetter_withUnsub.html"))
                    {
                        msgbody = reader.ReadToEnd();
                        msgbody = msgbody.Replace("{FirstImg}", FirstImg);
                        msgbody = msgbody.Replace("{SecondImg}", SecondImg);
                        msgbody = msgbody.Replace("{EmailId}", Email);
                    }
                }
                else
                {
                    using (StreamReader reader = new StreamReader(@"C:\sites\RealEstate_NewsLetter\RealEstate_NewsLetter\Templates\SixNewLetter.html"))
                    {
                        msgbody = reader.ReadToEnd();
                        msgbody = msgbody.Replace("{FirstImg}", FirstImg);
                        msgbody = msgbody.Replace("{SecondImg}", SecondImg);
                    }
                }
                

                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                System.Net.Mail.AlternateView plainView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(System.Text.RegularExpressions.Regex.Replace(msgbody, @"<(.|\n)*?>", string.Empty), null, "text/plain");
                System.Net.Mail.AlternateView htmlView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(msgbody, null, "text/html");

                mail.AlternateViews.Add(plainView);
                mail.AlternateViews.Add(htmlView);
                // mail.Body = msgbody;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = _Port;
                smtp.Credentials = new System.Net.NetworkCredential(FromEmailID, FromEmailPassword);// Enter senders User name and password
                smtp.EnableSsl = _EnableSsl;
                smtp.Send(mail);
                status = true;
                System.Threading.Thread.Sleep(7000);
            }
            catch (Exception ex)
            {

                status = false;
                SqlConnection rajpal_conn = new SqlConnection(ConfigurationManager.ConnectionStrings["rajpal_conn"].ConnectionString.ToString());


                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;

                sql = "insert into errorlog ([DBname],[message],[EmailId]) values('" + dbname + "','" + ex.Message.ToString() + "in send mail function. (greetings)" + "','" + Email + "')";
                try
                {
                    rajpal_conn.Open();
                    adapter.InsertCommand = new SqlCommand(sql, rajpal_conn);
                    adapter.InsertCommand.ExecuteNonQuery();

                }
                catch (Exception ex1)
                {
                    rajpal_conn.Close();
                }
            }

            return status;
        }
    }
}
