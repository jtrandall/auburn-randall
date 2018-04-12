using System;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Optimization;

namespace AuburnRandall.Web.Models
{
    // Custom CSS Rewrite URL Transform class. The built-in one has problems with virtual directories as well as with embedded images (Data URI). 
    // See comments in code below for links to the issues
    public class VirtualPathCssRewriteUrlTransform : IItemTransform
    {
        private static string RebaseUrlToAbsolute(string baseUrl, string url)
        {
            // Fix issue where bunlder tries to resolve embedded data URI images
            // See http://aspnetoptimization.codeplex.com/workitem/88
            if (string.IsNullOrWhiteSpace(url) || string.IsNullOrWhiteSpace(baseUrl) || url.StartsWith("/", StringComparison.OrdinalIgnoreCase)
              || url.StartsWith("data:") || url.StartsWith("http://") || url.StartsWith("https://"))
            {
                return url;
            }

            if (!baseUrl.EndsWith("/", StringComparison.OrdinalIgnoreCase))
            {
                baseUrl += "/";
            }

            return VirtualPathUtility.ToAbsolute(baseUrl + url);
        }


        private static string ConvertUrlsToAbsolute(string baseUrl, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return content;
            }

            var regex = new Regex("url\\(['\"]?(?<url>[^)]+?)['\"]?\\)");
            return regex.Replace(content, match => "url(" + RebaseUrlToAbsolute(baseUrl, match.Groups["url"].Value) + ")");
        }


        public string Process(string includedVirtualPath, string input)
        {
            if (includedVirtualPath == null)
            {
                throw new ArgumentNullException("includedVirtualPath");
            }

            // Handle virtual directories
            // Standard CssRewriteUrlTransform does not handle virtual directories properly, so we need custom code to handle this.
            // See http://stackoverflow.com/a/17702773 and http://aspnetoptimization.codeplex.com/workitem/83
            includedVirtualPath = "~" + VirtualPathUtility.ToAbsolute(includedVirtualPath);

            string directory = VirtualPathUtility.GetDirectory(includedVirtualPath.Substring(1));
            return ConvertUrlsToAbsolute(directory, input);
        }
    }
}