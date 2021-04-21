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
    public interface IBillServices
    {
        Task<IEnumerable<Bill>> GetAll();
        Task<Bill> Find(int id);
        Task<bool> Add(Bill bill);
        Task<bool> Update(Bill bill);
        Task<bool> Delete(int id);
    }

    public class BillServices : IBillServices
    {
        private readonly HttpClient http;

        public BillServices(HttpClient http)
        {
            this.http = http;
        }

        public async Task<bool> Add(Bill bill)
        {
            var json = JsonConvert.SerializeObject(bill);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await http.PostAsync("bills/postBill", content);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            await http.DeleteAsync($"bills/deleteBill/{id}");
            return true;
        }

        public async Task<Bill> Find(int id)
        {
            return await http.GetFromJsonAsync<Bill>($"bills/getBill/{id}");
        }

        public async Task<IEnumerable<Bill>> GetAll()
        {
            return await http.GetFromJsonAsync<ICollection<Bill>>("bills/getBills");
        }

        public async Task<bool> Update(Bill bill)
        {
            var json = JsonConvert.SerializeObject(bill);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await http.PutAsync($"bills/putBill/{bill.Id}", content);
            return true;
        }
    }
}
