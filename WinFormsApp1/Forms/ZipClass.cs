using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace WinFormsApp1.Forms
{
    public class ZipClass
    {
        public static void zip(string[] files,string zp, string name)
        {
            string zipPath = zp+@"\"+name+".zip";

            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                foreach(string file in files)
                {
                    archive.CreateEntryFromFile(file, Path.GetFileName(file));
                }
                
            }
        }
        public static void addTo(string[] files, string zp)
        {
            string zipPath = zp;

            using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
            {
                foreach (string file in files)
                {
                    archive.CreateEntryFromFile(file, Path.GetFileName(file));
                }

            }
        }
        public static void ExtractTo(string zf,string ep)
        {
            string zipFile = zf;
            string extractPath = ep;

            using (ZipArchive archive = ZipFile.Open(zipFile, ZipArchiveMode.Update))
            {
                archive.ExtractToDirectory(extractPath+@"\"+Path.GetFileNameWithoutExtension(zipFile));
            }
        }
    }
}
