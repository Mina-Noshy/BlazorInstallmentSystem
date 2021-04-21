using MyWebModels.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MyWebUI.Services
{
    public interface IInstallmentServices
    {
        Task<IEnumerable<Installment>> GetAll();
        Task<IEnumerable<Installment>> GetAllReceived();
        Task<IEnumerable<Installment>> GetAllUnreceived();
        Task<IEnumerable<Installment>> GetAllToday();
        Task<IEnumerable<Installment>> GetReceivedToday();
        Task<IEnumerable<Installment>> GetUnreceivedToday();
        Task<IEnumerable<Installment>> GetByDay(DateTime dateTime);
        Task<Installment> Find(int id);
        Task<bool> Update(Installment installment);
    }

    public class InstallmentServices : IInstallmentServices
    {
        private readonly HttpClient http;

        public InstallmentServices(HttpClient http)
        {
            this.http = http;
        }


        public async Task<Installment> Find(int id)
        {
            return await http.GetFromJsonAsync<Installment>($"installments/getInstallment/{id}");
        }


        public async Task<IEnumerable<Installment>> GetAll()
        {
            return await http.GetFromJsonAsync<ICollection<Installment>>($"installments/getAll");
        }

        public async Task<IEnumerable<Installment>> GetAllReceived()
        {
            return await http.GetFromJsonAsync<ICollection<Installment>>($"installments/getAllReceived");
        }

        public async Task<IEnumerable<Installment>> GetAllToday()
        {
            return await http.GetFromJsonAsync<ICollection<Installment>>($"installments/getAllToday");
        }

        public async Task<IEnumerable<Installment>> GetAllUnreceived()
        {
            return await http.GetFromJsonAsync<ICollection<Installment>>($"installments/getAllUnreceived");
        }

        public async Task<IEnumerable<Installment>> GetByDay(DateTime dateTime)
        {
            return await http.GetFromJsonAsync<ICollection<Installment>>($"installments/getByDay/{dateTime.ToString("MM-dd-yyyy")}");
        }

        public async Task<IEnumerable<Installment>> GetReceivedToday()
        {
            return await http.GetFromJsonAsync<ICollection<Installment>>($"installments/getReceivedToday");
        }

        public async Task<IEnumerable<Installment>> GetUnreceivedToday()
        {
            return await http.GetFromJsonAsync<ICollection<Installment>>($"installments/getUnreceivedToday");
        }

        public async Task<bool> Update(Installment installment)
        {
            var json = JsonConvert.SerializeObject(installment);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await http.PutAsync($"installments/putInstallment/{installment.Id}", content);
            return true;
        }

    }
}
