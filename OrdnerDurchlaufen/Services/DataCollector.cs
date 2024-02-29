using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdnerDurchlaufen.Services
{
    public static class DataCollector
    {
        public static DirectoryInfo[] HarvestingDatas(string path, int measureNumber)
        {
            DirectoryInfo info;

            return new DirectoryInfo(path).GetDirectories(measureNumber.ToString(), SearchOption.AllDirectories);
        }
    }
}
