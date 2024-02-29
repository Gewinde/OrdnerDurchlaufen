using OrdnerDurchlaufen.Services;
using OrdnerDurchlaufen.Models;
using System.Collections.ObjectModel;
using System.IO;

namespace OrdnerDurchlaufen.ViewModels
{
    internal class DataViewViewModel
    {
        private int _number = 22583;
        private string _path = @"F:\TestOrdner\DatenAbrufOrdner";

        public DataViewViewModel()
        {
            SampleBunchOfDatas(DataCollector.HarvestingDatas(_path, _number));
        }

        public ObservableCollection<ConstructionFolder> ConstructionFolders { get; set; } = new ObservableCollection<ConstructionFolder>();

        private void SampleBunchOfDatas(DirectoryInfo[] directory)
        {
            foreach(DirectoryInfo dir in directory)
            {
                ConstructionFolder currentdir = new ConstructionFolder();
                currentdir.FolderName = dir.Name;

                foreach(FileInfo file in dir.GetFiles())
                {
                    ConstructionFile currentfile = new ConstructionFile();
                    currentfile.FileName = file.Name;
                    currentfile.FileObject = file;
                    
                    currentdir.ConstructionFiles.Add(currentfile);
                }
                ConstructionFolders.Add(currentdir);
            }
        }
    }
}
