/************************************************************
    文件: ScriptsInfoRecoder.cs
	作者: JiahaoWu
    邮箱: jiahaodev@163.com
    日期: 2019/10/13 12:01
	功能: 记录脚本信息
*************************************************************/

using System;
using System.IO;
using UnityEngine;

public class ScriptsInfoRecoder : UnityEditor.AssetModificationProcessor
{
    private static string userName = "JiahaoWu";

    private static void OnWillCreateAsset(string path)
    {
        path = path.Replace(".meta", "");
        if (path.EndsWith(".cs"))
        {
            string str = File.ReadAllText(path);
            string timeStr = string.Concat(DateTime.Now.Year, "/", DateTime.Now.Month, "/", DateTime.Now.Day, " ", DateTime.Now.Hour, ":", DateTime.Now.Minute, ":", DateTime.Now.Second);
            str = str.Replace("#CreateAuthor#", userName) //Environment.UserName
                .Replace("#CreateTime#", timeStr);


            File.WriteAllText(path, str);
        }
    }
}