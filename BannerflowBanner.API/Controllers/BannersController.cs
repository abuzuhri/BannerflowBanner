using BannerflowBanner.Data.Entity;
using BannerflowBanner.Service.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BannerflowBanner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        BannerService bannerService = new BannerService();

        [HttpGet]
        public IList<Banner> Get()
        {
            return bannerService.GetBanners();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Banner Get(long id)
        {
            return bannerService.GetBanners(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Banner banner)
        {
            bannerService.AddBanner(banner.ID, banner.Html);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Banner banner)
        {
            bannerService.UpdateBanner(banner);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            bannerService.DeleteBanner(id);
        }
    }
}
