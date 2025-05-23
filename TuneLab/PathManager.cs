﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneLab;

internal static class PathManager
{
    public static string AppDataFolder => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
    public static string TuneLabFolder => Path.Combine(AppDataFolder, "TuneLab");
    public static string AutoSaveFolder => Path.Combine(TuneLabFolder, "AutoSave");
    public static string LogsFolder => Path.Combine(TuneLabFolder, "Logs");
    public static string ConfigsFolder => Path.Combine(TuneLabFolder, "Configs");
    public static string SettingsFilePath => Path.Combine(ConfigsFolder, "Settings.json");
    public static string ExtensionsFolder => Path.Combine(TuneLabFolder, "Extensions");
    public static string LockFilePath => Path.Combine(TuneLabFolder, "TuneLab.lock");
    public static string LogFilePath { get { mLogFilePath ??= Path.Combine(LogsFolder, "TuneLab_" + DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss") + ".log"); return mLogFilePath; } }
    public static string ExcutableFolder => AppDomain.CurrentDomain.BaseDirectory;
    public static string ResourcesFolder => Path.Combine(ExcutableFolder, "Resources");
    public static string TranslationsFolder => Path.Combine(ResourcesFolder, "Translations");

    public static void MakeSureExist(string folder)
    {
        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);
    }

    static string? mLogFilePath = null;
}
