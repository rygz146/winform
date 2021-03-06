﻿using System.Diagnostics;
using System.Reflection;

namespace IPlugin
{
    public class ProgramInfo
    {
        /// <summary>
        /// 获取文件版本
        /// </summary>
        /// <returns>版本号</returns>
        public string GetFileVersion()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            FileVersionInfo ver = FileVersionInfo.GetVersionInfo(asm.Location);
            return ver.FileVersion.Replace(".", "");
        }

        /// <summary>
        /// 获取产品版本
        /// </summary>
        /// <returns>版本号</returns>
        public string GetProductVersion()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            FileVersionInfo ver = FileVersionInfo.GetVersionInfo(asm.Location);
            return ver.ProductVersion;
        }
    }
}
