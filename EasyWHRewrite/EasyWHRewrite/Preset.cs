using System.Xml;

namespace EasyWHRewrite
{
    public class Preset
    {
        public string ID;
        public string URL;
        public string Nick;
        public string Avatar;
        public bool Usable;

        public Preset(string ID, XmlDocument Doc)
        {
            this.ID = ID;
            URL = Doc.SelectSingleNode("/preset/url").InnerText;
            Nick = Doc.SelectSingleNode("/preset/nick").InnerText;
            XmlNode AvatarTmp = Doc.SelectSingleNode("/preset/avatar");
            Avatar = AvatarTmp?.InnerText;
            Usable = Doc.SelectSingleNode("/preset/unusable") == null;
        }

        public void MakeUnusable()
        {
            Usable = false;
        }
    }
}
