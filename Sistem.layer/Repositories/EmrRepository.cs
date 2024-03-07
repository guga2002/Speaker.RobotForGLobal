using Speaker.leison.Sistem.layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Speaker.leison.Sistem.layer.Repositories
{
    public class EmrRepository:IEmrRepository
    {
        public  Task Start()
        {
            throw new NotImplementedException(" implementacia chirdeba");
        }

        #region GetInfoAboutAlrams
        public async Task<HashSet<int>> GetPortsWhereAlarmsIsOn()
        {
            List<int> lst = new List<int>();
            string link = $"http://192.168.20.250/goform/formEMR30?type=8&cmd=1&language=0&slotNo=255&alarmSlotNo=NaN&ran=0.36219193628209";

            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync(link);

                if (res.IsSuccessStatusCode)
                {
                    var re = await res.Content.ReadAsStringAsync();

                    await Task.Run(() =>
                    {
                        var splitResult = re.Split(new string[] { "<*1*>", "<html>", "<html/>", "</html>" }, StringSplitOptions.RemoveEmptyEntries);
                        HashSet<int> addedItems = new HashSet<int>();
                        foreach (var item in splitResult.OrderByDescending(io => io.Contains("Main GbE Card (C451E)")))
                        {
                            if (item.Contains("Card 7 GbE"))
                            {
                                if (!string.IsNullOrEmpty(item))
                                {
                                    var axali = item.Split(new string[] { "Card (C451E): Card 7" }, StringSplitOptions.None);
                                    if (axali.Length >= 2)
                                    {
                                        string pattern = @"Port (\d+)";
                                        Match match = Regex.Match(axali[1], pattern);
                                        if (match.Success)
                                        {
                                            string portNumber = match.Groups[1].Value;
                                            Console.WriteLine("Port number: " + portNumber);
                                            int port;
                                            if (int.TryParse(portNumber, out port))
                                            {
                                                Console.WriteLine("ver gadaikastaa");
                                            }
                                            else
                                            {
                                                Console.WriteLine(port);
                                                if (!addedItems.Any(io => io == port))
                                                {
                                                    addedItems.Add(port);//es is portebia sadac gvaqvs shecdomebi
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("portis nomeri ver vnaxet");
                                        }

                                    }

                                }

                            }

                        }
                        return addedItems;
                    });
                }
            }
            return new HashSet<int>();
        }
        #endregion

    }
}
