using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;

namespace Northwind.Client
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    }



    public class GitManager
    {

        private GitApi gitapi { get; }

        private bool InteractiveMode { get; set; }

        public event MessageEventHandler Message;
        public delegate void MessageEventHandler(string message);

        protected virtual void OnMessage(string message)
        {
            var handler = Message;
            if (handler != null) handler(message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl">Example: "http://tfs2010at.ifint.biz/tfs/TFS2008Collection/carse"</param>
        public GitManager(string baseUrl)
        {
            gitapi = new GitApi(baseUrl);
        }

        private class GitApi
        {
            public readonly string BaseUrl;

            public GitApi(string baseUrl)
            {
                BaseUrl = baseUrl;
            }

            public T Execute<T>(RestRequest request) where T : new()
            {
                var client = new RestClient
                {
                    BaseUrl = new Uri(BaseUrl),
                    Authenticator = new NtlmAuthenticator(CredentialCache.DefaultNetworkCredentials)
                };
                var response = client.Execute<T>(request);

                if (response.ErrorException != null)
                {
                    const string message = "Error retrieving response.  Check inner details for more info.";
                    var ex = new ApplicationException(message, response.ErrorException);
                    throw ex;
                }
                return response.Data;
            }

        }

        public class GitEntities
        {

            public class Repos
            {

                public class Rootobject
                {
                    public List<Value> value { get; set; }
                    public int count { get; set; }
                }

                public class Value
                {
                    public string id { get; set; }
                    public string name { get; set; }
                }

                public class Project
                {
                    public string id { get; set; }
                    public string name { get; set; }
                }
            }

            public class Commits
            {

                public class Rootobject
                {
                    public List<Value> value { get; set; }
                    public int count { get; set; }
                }

                public class Value
                {
                    public string id { get; set; }
                    public string name { get; set; }
                }

                public class Project
                {
                    public string id { get; set; }
                    public string name { get; set; }
                }
            }
        }

        public List<GitEntities.Repos.Value> GetRepos()
        {
            // Get repos
            List<GitEntities.Repos.Value> resp = null;

            try
            {
                var repoReq = new RestRequest { Resource = "_apis/git/repositories" };
                var repoResp = gitapi.Execute<GitEntities.Repos.Rootobject>(repoReq);
                if (repoResp?.value != null)
                {
                    resp = repoResp.value;
                }
            }
            catch (Exception ex)
            {
                OnMessage($"GitManager : Error : When trying to get repos: from {gitapi.BaseUrl}. We got this error: {ex.Message}. Exception details: {ex}");
                if (InteractiveMode) throw; // Test clients etc.
            }
            return resp;
        }

        public List<GitEntities.Commits.Value> GetCommits(string repoId, DateTime dtFrom, DateTime dtTo)
        {
            // Get commits
            List<GitEntities.Commits.Value> resp = null;

            try
            {
                var commitsReq = new RestRequest
                {
                    Resource = "_apis/git/repositories/{repoId}/commits?fromDate={dateFrom}&toDate={dateTo}&api-version=1.0"
                };
                commitsReq.AddParameter("repoId", repoId, ParameterType.UrlSegment);
                commitsReq.AddParameter("dateFrom", dtFrom, ParameterType.UrlSegment); // DateTime.Now.AddDays(-14)
                commitsReq.AddParameter("dateTo", dtTo, ParameterType.UrlSegment); // DateTime.Now.AddMinutes(1)

                var commitsResp = gitapi.Execute<GitEntities.Commits.Rootobject>(commitsReq);

                if (commitsResp?.value != null)
                {
                    resp = commitsResp.value;
                }

            }
            catch (Exception ex)
            {
                OnMessage($"GitManager : Error : When trying to get commits: from {gitapi.BaseUrl}, repo id {repoId}. We got this error: {ex.Message}. Exception details: {ex}");
                if (InteractiveMode) throw; // Test clients etc.
            }
            return resp;
        }
    }
}
