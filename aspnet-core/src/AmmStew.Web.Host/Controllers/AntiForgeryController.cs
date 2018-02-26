using Microsoft.AspNetCore.Antiforgery;
using AmmStew.Controllers;

namespace AmmStew.Web.Host.Controllers
{
    public class AntiForgeryController : AmmStewControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
