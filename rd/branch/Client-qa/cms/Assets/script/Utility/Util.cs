﻿using UnityEngine;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

public class Util
{
    /// <summary>
    /// 应用程序内容路径
    /// </summary>
    public static string AppContentPath()
    {
        return Application.streamingAssetsPath;
    }

#if UNITY_EDITOR
    /// <summary>
    /// 打包assetbundle时的路径，StreamingAssets下面可以打包到apk中
    /// </summary>
    public static string BuildPath
    {
        get
        {
            return Application.streamingAssetsPath;
        }
    }
#endif

    /// <summary>
    /// 取得数据存放目录，用来将从apk中解压出来的数据存到sd卡上
    /// </summary>
    public static string ResPath
    {
        get
        {
            if (Const.DebugMode)
                return Application.streamingAssetsPath;
            else
                return Application.persistentDataPath;
        }
    }

    public static string StaticDataPath
    {
        get { return Path.Combine(ResPath, "staticData"); }
    }

    public static string AssetBundlePath
    {
        get
        {
            return Path.Combine(ResPath, Const.AssetDirname);
        }
    }

    /// <summary>
    /// 添加组件
    /// </summary>
    public static T Add<T>(GameObject go) where T : Component
    {
        if (go != null)
        {
            T[] ts = go.GetComponents<T>();
            for (int i = 0; i < ts.Length; i++)
            {
                if (ts[i] != null) Object.Destroy(ts[i]);
            }
            return go.gameObject.AddComponent<T>();
        }
        return null;
    }

    /// <summary>
    /// 从bytes解压zip文件
    /// </summary>
    public static void UnZipFromBytes(byte[] bytes, string destDir)
    {
        if (bytes.Length == 0)
            return;

        MemoryStream stream = new MemoryStream(bytes);
        using (ZipInputStream s = new ZipInputStream(stream))
        {
            ZipEntry theEntry;
            while ((theEntry = s.GetNextEntry()) != null)
            {
                string directoryName = Path.GetDirectoryName(theEntry.Name);
                string fileName = Path.GetFileName(theEntry.Name);

                // create directory
                if (directoryName.Length > 0)
                    Directory.CreateDirectory(Path.Combine(destDir, directoryName));

                if (fileName != string.Empty)
                {
                    using (FileStream streamWriter = File.Create(Path.Combine(destDir, theEntry.Name)))
                    {
                        int size = 2048;
                        byte[] data = new byte[2048];
                        while (true)
                        {
                            size = s.Read(data, 0, data.Length);
                            if (size > 0)
                                streamWriter.Write(data, 0, size);
                            else
                                break;
                        }
                    }
                }
            }
        }
    }

    /// <summary>
    /// 清理内存
    /// </summary>
    public static void ClearMemory()
    {
        System.GC.Collect();
        Resources.UnloadUnusedAssets();
    }
}
