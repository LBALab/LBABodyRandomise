using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LBABodyRandomise
{
    class LookupLBABody
    {
        private IDictionary<string, string> dict = new Dictionary<string, string>();
        private IList<int> offsets = new List<int>();

        public LookupLBABody(Nullable<bool> LBA1)
        {
            if (true == LBA1)
                populateDict("lba.xml");
            if(false == LBA1)
                populateDict("lba2.xml");
        }

        private void parseBodyFile(string p)
        {
            XmlDocument doc = new XmlDocument();
            
            p = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath + "\\" + p;
            doc.Load(p);

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/hqr/offsets/offset");

            int offset;
            string text;
            foreach (XmlNode node in nodes)
            {
                int.TryParse(node.Attributes["offset"].Value, out offset);
                text = node.InnerText;
                addToDict(offset, text.Trim());
                addOffset(offset);
            }
        }

        private void addToDict(int offset, string name)
        {
            dict.Add(offset + "", name);
        }

        void populateDict(string name)
        {
            parseBodyFile(name);
        }
        private void addOffset(int o)
        {
            offsets.Add(o);
        }

        /*private void clearOffsets()
        {
            offsets.Clear();
        }*/

        public int getOffsetSize()
        {
            return offsets.Count;
        }

        public string getName(string offset)
        {
            dict.TryGetValue(offset, out string str);
            return str;
        }

        public string getOffset(int index)
        {
            return offsets.ElementAt(index) + "";
        }


    }
}
