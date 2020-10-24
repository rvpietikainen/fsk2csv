using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace fsk2csv
{
    class Program
    {
        static void Main(string[] args)
        {
            string fskfilename = args[0];
            string outputfile = args[0] + ".csv";

            Console.WriteLine($"reading file {fskfilename}...");

            var filedata = File.ReadAllText(fskfilename);

            var model = JsonConvert.DeserializeObject<FskModel>(filedata);

            Console.WriteLine(model);

            File.WriteAllText(outputfile, "rev;service;url;username;password;notes;color;style;type;passwordlist\r\n");

            foreach (var key in model.data.Keys)
            {
                var entity = model.data[key];
                Console.WriteLine($"entity {key}: {entity.service}");

                File.AppendAllText(outputfile, $"\"{entity.rev}\";\"{entity.service}\";\"{entity.url}\";\"{entity.username}\";\"{entity.password}\";\"{entity.notes}\";\"{entity.color}\";\"{entity.style}\";\"{entity.type}\";\"\"\r\n");
            }
        }
    }
}
