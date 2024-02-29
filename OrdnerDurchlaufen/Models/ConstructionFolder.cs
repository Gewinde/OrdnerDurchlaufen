using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdnerDurchlaufen.Models
{
    internal class ConstructionFolder
    {
        public string FolderName { get; set; }
        public ObservableCollection<ConstructionFile> ConstructionFiles { get; set; } = new ObservableCollection<ConstructionFile>();
    }
}
