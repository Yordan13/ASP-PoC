using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RestSharp;
using System.Net;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// Descripción breve de API
/// </summary>
public class API
{
    private string url = "https://localhost:44375/api/";


    public API()
    {
    }

    public T[] getData<T>(string controllerName, string method, string[] parameters) {
        var requestUrl = this.url + controllerName;
        if (method.Length > 0) {
            requestUrl += "/" + method + "=";
            foreach (var item in parameters) {
                requestUrl += item + ",";
            }
            requestUrl = requestUrl.Remove(requestUrl.Length - 1);
        }
        var request = (HttpWebRequest)WebRequest.Create(requestUrl);
        request.Method = "GET";
        var response = request.GetResponse();
        var stream = new StreamReader(response.GetResponseStream());
        var text = stream.ReadToEnd();
        JsonSerializer ser = new JsonSerializer();
        var result = ser.Deserialize<T[]>(new JsonTextReader(new StringReader(text)));
        return result;
    }
}