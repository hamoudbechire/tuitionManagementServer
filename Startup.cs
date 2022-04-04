using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(SchoolManagementApi.Startup))]

namespace SchoolManagementApi
{
    public partial class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //    // Pour plus d'informations sur la configuration de votre application, visitez https://go.microsoft.com/fwlink/?LinkID=316888
        //}
    }
}
