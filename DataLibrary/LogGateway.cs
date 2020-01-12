using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Xml;

namespace DataLibrary
{
    public struct LogUnit
    {
        public int id;
        public string message;

    }
    public class LogGateway
    {
        private static XmlDocument xmlDoc;
        private static int freeID = 0;
        const int INVALID_ID = -1;
        private static string file = null;



        public static void LoadDocument(string filePath)
        {
            file = filePath;
            xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(file);
            }
            catch (Exception)
            {
                xmlDoc = null;
                return;
            }

            XmlNode root = xmlDoc.DocumentElement;
            XmlNode freeIDNode = root.SelectSingleNode("freeID");

            freeID = Convert.ToInt32(freeIDNode.InnerText);
        }

        private static void SaveDocument()
        {
            XmlNode root = xmlDoc.DocumentElement;
            XmlNode freeIDNode = root.SelectSingleNode("freeID");
            freeIDNode.InnerText = freeID.ToString();

            xmlDoc.Save(file);
        }

        private static bool CheckDocument()
        {
            if (xmlDoc == null)
                return false;

            if (!File.Exists(file))
                return false;

            return true;
        }
        public static Collection<LogUnit> SelectAll()
        {
            Collection<LogUnit> Logs = new Collection<LogUnit>();

            if (!CheckDocument())
            {
                return Logs;
            }

            XmlNode root = xmlDoc.DocumentElement;
            XmlNodeList list = root.SelectNodes("Log");

            foreach (XmlNode logNode in list)
            {
                LogUnit log = new LogUnit();
                Fill(logNode, ref log);

                Logs.Add(log);
            }

            return Logs;
        }
        public static bool Insert(ref LogUnit Log)
        {
            if (!CheckDocument())
            {
                return false;
            }

            XmlElement root = xmlDoc.DocumentElement;
            XmlElement log = xmlDoc.CreateElement("Log");

            XmlElement id = xmlDoc.CreateElement("id");
            id.InnerText = freeID.ToString();
            Log.id = freeID;
            freeID = freeID + 1;
            log.AppendChild(id);

            XmlElement name = xmlDoc.CreateElement("name");
            name.InnerText = Log.message;
            log.AppendChild(name);



            root.AppendChild(log);

            SaveDocument();

            return true;
        }
        public static void Fill(XmlNode logNode, ref LogUnit log)
        {
            foreach (XmlNode child in logNode.ChildNodes)
            {
                if (child.Name == "id")
                {
                    log.id = int.Parse(child.InnerText);
                }
                if (child.Name == "name")
                {
                    log.message = child.InnerText;
                }
               
            }
        }


    }
}
