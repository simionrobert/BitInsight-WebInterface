﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatcherDataLayer.Models;

namespace Watcher.Models.Search
{
    public class TorrentDetailModel
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String Date { get; set; }
        public String Type;
        public String Categories;
        public String MagnetLink;
        public String Size;
        public int NrFiles;
        public int PeerNumber;
        public IEnumerable<FileDetailModel> Files { get; set; }
        public List<String> IPs { get; set; }

        public class FileDetailModel
        {
            public String Name;
            public String Size;
        }
    }
}
