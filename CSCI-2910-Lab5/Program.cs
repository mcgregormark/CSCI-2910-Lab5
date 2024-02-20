using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

/* Name - Mark McGregor
 * API in Use - D&D 5E API by 5e-bits
 * Assignment - Lab 5
 * Purpose - Creating a console app to interact with a pre-existing API
 * Created - 2/20/24
 * Last Updated -                                                   */

// API request call - This was created by the developers and encouraged to be copied by users.
// Source: https://5e-bits.github.io/docs/api
var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, "https://www.dnd5eapi.co/api");
request.Headers.Add("Accept", "application/json");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());