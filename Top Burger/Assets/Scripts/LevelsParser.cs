using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System;

///<summary>
///<para>Scene:All/NameOfScene/NameOfScene1,NameOfScene2,NameOfScene3...</para>
///<para>Object:N/A</para>
///<para>Description: Sample Description </para>
///</summary>

public class LevelsParser : MonoBehaviour {

    public struct LevelStruct
    {
        public int levelNumber;
        public int levelGoal;
        public int levelUnlockedItem;
        public string levelUnlockedTitleWorld1;
        public string levelUnlockedMessageWorld1;
        public string levelUnlockedTitleWorld2;
        public string levelUnlockedMessageWorld2;
        public string levelUnlockedTitleWorld3;
        public string levelUnlockedMessageWorld3;
    }
    public static List<LevelStruct> ListOfLevels = new List<LevelStruct>();
    // Use this for initialization
    void Start()
    {
        ParseXML();

    }

    void ParseXML()
    {
        TextAsset aset = (TextAsset)Resources.Load("Levels/Levels");
        XmlDocument xml = new XmlDocument();
        xml.LoadXml(aset.ToString());


        XmlNodeList appNodes = xml.SelectNodes("/xml/level");

        int number = appNodes.Count;

        foreach (XmlNode node in appNodes)
        {
            LevelStruct SingleLevel = new LevelStruct
            {
                levelNumber = int.Parse(node.Attributes.GetNamedItem("number").Value)

            };
            SingleLevel.levelGoal = int.Parse(node.SelectSingleNode("goal").InnerText);
            SingleLevel.levelUnlockedItem = int.Parse(node.SelectSingleNode("unlockedItem").InnerText);
            SingleLevel.levelUnlockedTitleWorld1 = node.SelectSingleNode("unlockedTitleWorld1").InnerText;
            SingleLevel.levelUnlockedMessageWorld1 = node.SelectSingleNode("unlockedMessageWorld1").InnerText;
            SingleLevel.levelUnlockedTitleWorld2 = node.SelectSingleNode("unlockedTitleWorld2").InnerText;
            SingleLevel.levelUnlockedMessageWorld2 = node.SelectSingleNode("unlockedMessageWorld2").InnerText;
            SingleLevel.levelUnlockedTitleWorld3 = node.SelectSingleNode("unlockedTitleWorld3").InnerText;
            SingleLevel.levelUnlockedMessageWorld3 = node.SelectSingleNode("unlockedMessageWorld3").InnerText;
            ListOfLevels.Add(SingleLevel);
        }
    }
    //private void Start()
    //{
    //    this.ParseXML();
    //}

    //// Token: 0x06000255 RID: 597 RVA: 0x0000ED6C File Offset: 0x0000D16C
    //private void ParseXML()
    //{
    //    TextAsset textAsset = (TextAsset)Resources.Load("Levels/Levels");
    //    XmlDocument xmlDocument = new XmlDocument();
    //    xmlDocument.LoadXml(textAsset.ToString());
    //    XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/xml/level");
    //    int count = xmlNodeList.Count;
    //    IEnumerator enumerator = xmlNodeList.GetEnumerator();
    //    try
    //    {
    //        while (enumerator.MoveNext())
    //        {
    //            object obj = enumerator.Current;
    //            XmlNode xmlNode = (XmlNode)obj;
    //            LevelsParser.LevelStruct item = new LevelsParser.LevelStruct
    //            {
    //                levelNumber = int.Parse(xmlNode.Attributes.GetNamedItem("number").Value)
    //            };
    //            item.levelGoal = int.Parse(xmlNode.SelectSingleNode("goal").InnerText);
    //            item.levelUnlockedItem = int.Parse(xmlNode.SelectSingleNode("unlockedItem").InnerText);
    //            item.levelUnlockedTitleWorld1 = xmlNode.SelectSingleNode("unlockedTitleWorld1").InnerText;
    //            item.levelUnlockedMessageWorld1 = xmlNode.SelectSingleNode("unlockedMessageWorld1").InnerText;
    //            item.levelUnlockedTitleWorld2 = xmlNode.SelectSingleNode("unlockedTitleWorld2").InnerText;
    //            item.levelUnlockedMessageWorld2 = xmlNode.SelectSingleNode("unlockedMessageWorld2").InnerText;
    //            item.levelUnlockedTitleWorld3 = xmlNode.SelectSingleNode("unlockedTitleWorld3").InnerText;
    //            item.levelUnlockedMessageWorld3 = xmlNode.SelectSingleNode("unlockedMessageWorld3").InnerText;
    //            LevelsParser.ListOfLevels.Add(item);
    //        }
    //    }
    //    finally
    //    {
    //        IDisposable disposable;
    //        if ((disposable = (enumerator as IDisposable)) != null)
    //        {
    //            disposable.Dispose();
    //        }
    //    }
    //}

    //// Token: 0x0400018F RID: 399
    //public static List<LevelsParser.LevelStruct> ListOfLevels = new List<LevelsParser.LevelStruct>();

    //// Token: 0x02000035 RID: 53
    //public struct LevelStruct
    //{
    //    // Token: 0x04000190 RID: 400
    //    public int levelNumber;

    //    // Token: 0x04000191 RID: 401
    //    public int levelGoal;

    //    // Token: 0x04000192 RID: 402
    //    public int levelUnlockedItem;

    //    // Token: 0x04000193 RID: 403
    //    public string levelUnlockedTitleWorld1;

    //    // Token: 0x04000194 RID: 404
    //    public string levelUnlockedMessageWorld1;

    //    // Token: 0x04000195 RID: 405
    //    public string levelUnlockedTitleWorld2;

    //    // Token: 0x04000196 RID: 406
    //    public string levelUnlockedMessageWorld2;

    //    // Token: 0x04000197 RID: 407
    //    public string levelUnlockedTitleWorld3;

    //    // Token: 0x04000198 RID: 408
    //    public string levelUnlockedMessageWorld3;
    //}

}
