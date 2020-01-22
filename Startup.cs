using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace microservices_project {
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
    }

    public void Configure(IApplicationBuilder app,
      IHostingEnvironment env, ILoggerFactory loggerFactory)
      {
        app.Run(async (context) =>
        {
          await context.Response.WriteAsync("Hello, world!");
          await context.Response.WriteAsync("Testing whether Wercker creates image on Docker hub");
        });
      }
  }
}
