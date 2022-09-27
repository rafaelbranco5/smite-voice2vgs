using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smite_voice2vgs.Entities
{
    internal class Command
    {
        [Name("Text")]
        public string? Text { get; set; }
        [Name("PC")]
        public string? PC { get; set; }
    }
}