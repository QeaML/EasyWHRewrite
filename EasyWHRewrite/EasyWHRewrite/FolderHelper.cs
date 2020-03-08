using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWHRewrite
{
    class FolderHelper
    {
        public readonly string BasePath;
        public FolderHelper(string BasePath) 
        {
            this.BasePath = BasePath;
        }
        public FolderHelper()
        {
            BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EasyWH");
        }

        public string GetPath(string Folder)
        {
            return Path.Combine(BasePath, Folder);
        }
        public string GetPath(string Folder, string File)
        {
            return Path.Combine(GetPath(Folder), File);
        }

        public void CreateFolder(string Folder)
        {
            Directory.CreateDirectory(GetPath(Folder));
        }

        public bool CheckFolder(string Folder)
        {
            return Directory.Exists(GetPath(Folder));
        }

        public void CreateFolderFromPath(string Path_)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Path_));
        }

        public void WriteFileInFolder(string Folder, string Filename, string Content)
        {
            string P = GetPath(Folder, Filename);
            if (!Directory.Exists(Path.GetDirectoryName(P)))
            {
                CreateFolderFromPath(P);
            }
            File.WriteAllText(P, Content);
        }

        public bool CheckFileInFolder(string Folder, string Filename)
        {
            return File.Exists(GetPath(Folder, Filename));
        }
    }
}
