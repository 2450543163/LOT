using Iot.App.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Iot.App.Services
{
    public class BaseProvider
    {
        protected string _baseUrl="http://www.baidu.com";

        protected HttpClient GetClient()
        {
            return GetClient(_baseUrl);
        }
        protected virtual HttpClient GetClient(string baseUrl)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            return client;
        }

        //HttpClient类的GetAsync() 方法执行GET请求到URL，返回结果包含JSON响应的字符串。
        //这个结果存储在响应的Content 属性：如果请求成功（我们使用IsSuccessStatusCode 属性检查这种情况），
        //我们使用Content 属性公开的ReadAsAsync<T>方法自动转换为JSON到T对象的集合

        //注意：默认情况下，HttpClient 类没有提供一个ReadAsAsync<T>方法，能够自动对JSON响应为C#对象进行反序列化。
        //为了获得该扩展方法，我们需要添加Microsoft.AspNet.WebApi.Client NuGet包到Xamarin.Forms中
        protected async Task<T> Get<T>(string url)
        {
            using (HttpClient client = GetClient())
            {
                try
                {
                    var response = await client.GetAsync(url);
                    if (!response.IsSuccessStatusCode)
                    {
                        var error = await response.Content.ReadAsAsync<TrackSeriesApiError>();
                        var message = error != null ? error.Message : "";
                        throw new TrackSeriesApiException(message, response.StatusCode);
                    }
                    //return await response.Content.ReadAsAsync<T>();
                    string resultStr = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(resultStr);
                }
                catch (HttpRequestException ex)
                {
                    throw new TrackSeriesApiException("", false, ex);
                }
                catch (UnsupportedMediaTypeException ex)
                {
                    throw new TrackSeriesApiException("", false, ex);
                }
                catch (Exception ex)
                {
                    return default(T);
                }
            }
        }
    }
}
