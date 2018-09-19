namespace AnonymousDownsite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var key = int.Parse(Console.ReadLine());

            var affectedWebsites = new List<string>();
            var totalLoss = 0.00M;
            var securityToken = BigInteger.Pow(key, n);

            for (int i = 0; i < n; i++)
            {
                var siteData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var siteName = siteData[0];
                var siteVisits = decimal.Parse(siteData[1]);
                var pricePerVisit = decimal.Parse(siteData[2]);

                var siteLoss = siteVisits * pricePerVisit;
                

                affectedWebsites.Add(siteName);
                totalLoss += siteLoss;                
            }

            Console.WriteLine(string.Join(Environment.NewLine, affectedWebsites));
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
