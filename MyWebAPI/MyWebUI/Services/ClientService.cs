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
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAll();
        Task<Client> Find(int id);
        Task<bool> Add(Client client);
        Task<bool> Update(Client client);
        Task<bool> Delete(int id);
    }

    public class ClientService : IClientService
    {
        private readonly HttpClient http;

        public ClientService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<bool> Add(Client client)
        {
            var json = JsonConvert.SerializeObject(client);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await http.PostAsync("clients/postClient", content);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            await http.DeleteAsync($"clients/deleteClient/{id}");
            return true;
        }

        public async Task<Client> Find(int id)
        {
            return await http.GetFromJsonAsync<Client>($"clients/getClient/{id}");
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await http.GetFromJsonAsync<ICollection<Client>>("clients/getClients");
        }

        public async Task<bool> Update(Client client)
        {
            var json = JsonConvert.SerializeObject(client);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await http.PutAsync($"clients/putClient/{client.Id}", content);
            return true;
        }
    }
}
