using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace EasyWHRewrite
{
    public class PresetManager
    {
        private readonly FolderHelper Helper;
        private const string PresetTemplate =
@"<preset>
    <url>{0}</url>
    <nick>{1}</nick>
    <avatar>{2}</avatar>
</preset>";
        private const string PresetTemplateNoAvatar =
@"<preset>
    <url>{0}</url>
    <nick>{1}</nick>
</preset>";
        private const string ExamplePreset =
@"<preset>
    <url>https://discordapp.com/your/webhook</url>
    <nick>Example</nick>
    <avatar>https://yourhost.com/avatar.png</avatar>
    <unusable/>
</preset>";

        public PresetManager()
        {
            Helper = new FolderHelper();
            WritePresetFile("Example", ExamplePreset);
        }

        private string GetPresetPath(string ID)
        {
            return Helper.GetPath("Presets", ID+".xml");
        }

        private string MakePresetXML(string URL, string Nick, string Avatar)
        {
            return string.Format(
                PresetTemplate,
                URL,
                Nick,
                Avatar
            );
        }

        private string MakePresetXMLNoAvatar(string URL, string Nick)
        {
            return string.Format(
                PresetTemplateNoAvatar,
                URL,
                Nick
            );
        }

        private void WritePresetFile(string ID, string XML)
        {
            if(!Helper.CheckFolder("Presets"))
            {
                Helper.CreateFolder("Presets");
            }
            File.WriteAllText(GetPresetPath(ID), XML);
        }

        public List<string> GetPresetList()
        {
            List<string> Presets = new List<string>();
            foreach (string P in Directory.EnumerateFiles(Helper.GetPath("Presets")))
            {
                string[] T = P.Split(Path.DirectorySeparatorChar);
                Presets.Add(T[T.Length - 1].Split('.')[0]);
            }
            return Presets;
        }

        public Preset GetPreset(string ID)
        {
            string P = GetPresetPath(ID);
            if (File.Exists(P))
            {
                XmlDocument D = new XmlDocument();
                D.Load(P);
                return new Preset(ID, D);
            }
            else
            {
                return null;
            }
        }

        public void SavePreset(string ID, string URL, string Nick, string Avatar)
        {
            WritePresetFile(ID, MakePresetXML(URL, Nick, Avatar));
        }
        public void SavePreset(string ID, string URL, string Nick)
        {
            WritePresetFile(ID, MakePresetXMLNoAvatar(URL, Nick));
        }

        public void DeletePreset(string ID)
        {
            File.Delete(GetPresetPath(ID));
        }

        public bool PresetExists(string ID)
        {
            return File.Exists(GetPresetPath(ID));
        }
    }
}
