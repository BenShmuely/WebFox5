using System.Net;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebFox.Controllers
{
    public class SecureCookieTest1: ControllerBase
    {
        [HttpGet("{response}")]
        [HttpGet("{request}")]

        // HttpCookie myCookie = new HttpCookie("Sensitive cookie");

        public void Unsafe(HttpWebResponse response, HttpWebRequest request)
        {
            var password = "p-12345678";// + RandomNumberGenerator.GetInt32(200000000, 2000000000);
            var cookie = new Cookie("password",password);
            cookie.Path = "/";
            cookie.Domain = "";
            cookie.Comment = "Cookie Description";
            CookieOptions options = new CookieOptions();
            response.Cookies.Add(cookie);
        }
    }
}