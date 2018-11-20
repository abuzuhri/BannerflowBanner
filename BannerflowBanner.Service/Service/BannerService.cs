using BannerflowBanner.Data.Context;
using BannerflowBanner.Data.Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace BannerflowBanner.Service.Service
{
    public class BannerService 
    {
        private bool IsValidHtml(string html)
        {
            //Install-Package HtmlAgilityPack -Version 1.8.10
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            if (doc.ParseErrors.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool AddBanner(long Id,string html)
        {
            if (IsValidHtml(html))
            {
                try
                {
                    using (var context = new BannerflowContext())
                    {
                        Banner banner = new Banner();
                        banner.ID = Id;
                        banner.Html = html;
                        context.Banners.Add(banner);
                        context.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Invalid Html ...");
            }

        }
        public bool UpdateBanner(Banner banner)
        {
            if (IsValidHtml(banner.Html))
            {
                try
                {
                    using (var context = new BannerflowContext())
                    {
                        var dbBbanner = context.Banners.Where(a => a.ID == banner.ID).FirstOrDefault();
                        if (dbBbanner != null)
                        {
                            dbBbanner.Html = banner.Html;
                            context.Banners.Update(banner);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Banner not found");
                        }

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Invalid Html ...");
            }


        }
        public Banner GetBanners(long Id)
        {
            using (var context = new BannerflowContext())
            {
                var dbBbanner = context.Banners.Where(a => a.ID == Id).FirstOrDefault();
                if (dbBbanner != null)
                {
                    return dbBbanner;
                }
                else
                {
                    throw new Exception("Banner not found");
                }
            }
        }
        public IList<Banner> GetBanners()
        {
            using (var context = new BannerflowContext())
            {
                return context.Banners.ToList();
            }
        }
        public bool DeleteBanner(long Id)
        {
            try
            {
                using (var context = new BannerflowContext())
                {
                    var banner = context.Banners.Where(a => a.ID == Id).FirstOrDefault();
                    context.Banners.Remove(banner);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
