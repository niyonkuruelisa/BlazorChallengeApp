using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorChallengeApp.Shared
{
    public class Cinema
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
