using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMiddleware.Infrastructure
{
    public class CheckforIE
    {
        //1. Önceki middleware'den gelen context'i almam gerekiyor
        private RequestDelegate requestDelegate;
        public CheckforIE(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        //2. Bu middleware context üzerinde ne yapacak?
        //  Eğer request, IE'den geliyorsa, bir bilgi eklemek istiyoruz.
        public async Task Invoke(HttpContext httpContext)
        {
            var item = httpContext.Request.Headers["User-Agent"].Any(value => value.ToLower().Contains("trident"));
            httpContext.Items["IE"] = item;


            //sonraki middleware'e gönder:
            await requestDelegate.Invoke(httpContext);
        } 
    }
}
