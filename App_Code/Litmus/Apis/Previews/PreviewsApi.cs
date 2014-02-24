using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using RestSharp;
using Litmus.Apis.Previews.Models;

namespace Litmus.Apis.Previews
{
    /// <summary>
    /// Summary description for PreviewsApi
    /// </summary>
    public class PreviewsApi
    {
        private readonly RestClient restClient = new RestClient("https://previews-api.litmus.com");

        public PreviewsApi(string username, string password)
        {
            restClient.Authenticator = new HttpBasicAuthenticator(username, password);
        }

        public TestingApplication GetTestResult(int id)
        {
            var request = new RestRequest("/api/v1/Result/{id}", Method.GET);
            request.AddParameter("id", id);

            var response2 = restClient.Execute<TestingApplication>(request);

            return response2.Data;
        }

        public async Task<TestingApplication> GetTestResultAsync(int id)
        {
            var request = new RestRequest("/api/v1/Result/{id}", Method.GET);
            request.AddParameter("id", id);

            var response2 = await restClient.ExecuteTaskAsync<TestingApplication>(request);

            return response2.Data;
        }

        public List<string> GetSpamSeedAddresses()
        {
            var request = new RestRequest("/api/v1/SpamSeedAddresses", Method.GET);

            var response2 = restClient.Execute<List<string>>(request);

            return response2.Data;
        }

        public async Task<List<string>> GetSpamSeedAddressesAsync()
        {
            var request = new RestRequest("/api/v1/SpamSeedAddresses", Method.GET);

            var response2 = await restClient.ExecuteTaskAsync<List<string>>(request);

            return response2.Data;
        }


        #region Email Tests

        public EmailTest CreateEmailTest(EmailTest test)
        {
            var request = new RestRequest("/api/v1/EmailTests", Method.POST);
            request.AddParameter("emailTest", test);

            var response2 = restClient.Execute<EmailTest>(request);

            return response2.Data;
        }

        public async Task<EmailTest> CreateEmailTestAsync(EmailTest test)
        {
            var request = new RestRequest("/api/v1/EmailTests", Method.POST);
            request.AddParameter("emailTest", test);

            var response2 = await restClient.ExecuteTaskAsync<EmailTest>(request);

            return response2.Data;
        }

        public List<TestingApplication> GetEmaiTestingApplications()
        {
            var request = new RestRequest("GET /api/v1/EmailTests/TestingApplications", Method.GET);

            var response2 = restClient.Execute<List<TestingApplication>>(request);

            return response2.Data;
        }

        public async Task<List<TestingApplication>> GetEmaiTestingApplicationsAsync()
        {
            var request = new RestRequest("GET /api/v1/EmailTests/TestingApplications", Method.GET);

            var response2 = await restClient.ExecuteTaskAsync<List<TestingApplication>>(request);

            return response2.Data;
        }

        public EmailTest GetEmailTest(int emailTestId)
        {
            var request = new RestRequest("/api/v1/EmailTests/{id}", Method.GET);
            request.AddParameter("id", emailTestId);

            var response2 = restClient.Execute<EmailTest>(request);

            return response2.Data;
        }

        public async Task<EmailTest> GetEmailTestAsync(int emailTestId)
        {
            var request = new RestRequest("/api/v1/EmailTests/{id}", Method.GET);
            request.AddParameter("id", emailTestId);

            var response2 = await restClient.ExecuteTaskAsync<EmailTest>(request);

            return response2.Data;
        }

        #endregion

        #region Page Tests
        
        public PageTest CreatePageTest(PageTest test)
        {
            var request = new RestRequest("/api/v1/PageTests", Method.POST);
            request.AddParameter("pageTest", test);

            var response2 = restClient.Execute<PageTest>(request);

            return response2.Data;
        }

        public async Task<PageTest> CreatePageTestAsync(PageTest test)
        {
            var request = new RestRequest("/api/v1/PageTests", Method.POST);
            request.AddParameter("pageTest", test);

            var response2 = await restClient.ExecuteTaskAsync<PageTest>(request);

            return response2.Data;
        }

        public List<TestingApplication> GetPageTestingApplications()
        {
             var request = new RestRequest("GET /api/v1/PageTests/TestingApplications", Method.GET);

            var response2 = restClient.Execute<List<TestingApplication>>(request);

            return response2.Data;
        }

        public async Task<List<TestingApplication>> GetPageTestingApplicationsAsync()
        {
            var request = new RestRequest("GET /api/v1/PageTests/TestingApplications", Method.GET);

            var response2 = await restClient.ExecuteTaskAsync<List<TestingApplication>>(request);

            return response2.Data;
        }

        public PageTest GetPageTest(int pageTestId)
        {
            var request = new RestRequest("/api/v1/PageTests/{id}", Method.GET);
            request.AddParameter("id", pageTestId);

            var response2 = restClient.Execute<PageTest>(request);

            return response2.Data;
        }

        public async Task<PageTest> GetPageTestAsync(int pageTestId)
        {
            var request = new RestRequest("/api/v1/PageTests/{id}", Method.GET);
            request.AddParameter("id", pageTestId);

            var response2 = await restClient.ExecuteTaskAsync<PageTest>(request);

            return response2.Data;
        }

        #endregion

        #region Links Test

        public LinksTest CreateLinksTest(LinksTest test)
        {
            var request = new RestRequest("/api/v1/LinkTests", Method.POST);
            request.AddParameter("html", test);

            var response2 = restClient.Execute<LinksTest>(request);

            return response2.Data;
        }

        public async Task<LinksTest> CreateLinksTestAsync(LinksTest test)
        {
            var request = new RestRequest("/api/v1/LinkTests", Method.POST);
            request.AddParameter("html", test);

            var response2 = await restClient.ExecuteTaskAsync<LinksTest>(request);

            return response2.Data;
        }

        public LinksTest GetLinksTest(int linkTestId)
        {
            var request = new RestRequest("/api/v1/LinkTests/{id}", Method.GET);
            request.AddParameter("id", linkTestId);

            var response2 = restClient.Execute<LinksTest>(request);

            return response2.Data;
        }

        public async Task<LinksTest> GetLinksTestAsync(int linkTestId)
        {
            var request = new RestRequest("/api/v1/LinkTests/{id}", Method.GET);
            request.AddParameter("id", linkTestId);

            var response2 = await restClient.ExecuteTaskAsync<LinksTest>(request);

            return response2.Data;
        }

        #endregion

        #region Code Analysis

        public CodeAnalysisTest CreateCodeAnalysisTest(string html)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);
            request.AddParameter("html", html);

            var response2 = restClient.Execute<CodeAnalysisTest>(request);

            return response2.Data;
        }

        public async Task<CodeAnalysisTest> CreateCodeAnalysisTestAsync(string html)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);
            request.AddParameter("html", html);

            var response2 = await restClient.ExecuteTaskAsync<CodeAnalysisTest>(request);

            return response2.Data;
        }

        public CodeAnalysisTest CreateCodeAnalysisTestByTestingApplication(string html, List<TestingApplication> testingApplications)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);

            var test = new CodeAnalysisTestByTestingApplications
            {
                Html = html,
                TestingApplications = testingApplications.Select(n => n.ApplicationName).ToList()
            };

            request.AddParameter("codeAnalysisTest", test);

            var response2 = restClient.Execute<CodeAnalysisTest>(request);

            return response2.Data;
        }

        public async Task<CodeAnalysisTest> CreateCodeAnalysisTestByTestingApplicationAsync(string html, List<TestingApplication> testingApplications)
        {
            var request = new RestRequest("/api/v1/CodeAnalysis", Method.POST);

            var test = new CodeAnalysisTestByTestingApplications
            {
                Html = html,
                TestingApplications = testingApplications.Select(n => n.ApplicationName).ToList()
            };

            request.AddParameter("codeAnalysisTest", test);

            var response2 = await restClient.ExecuteTaskAsync<CodeAnalysisTest>(request);

            return response2.Data;
        }


        #endregion

    }
}