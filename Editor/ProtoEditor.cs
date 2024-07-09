using UnityEditor;
using System.Diagnostics;

namespace ET
{
    public static class ProtoEditor
    {
        [MenuItem("ET/Proto/Proto2CS")]
        public static void Run()
        {
            Process process = ProcessHelper.DotNet("./Packages/cn.etetet.proto/DotNet~/Exe/ET.Proto2CS.dll", "./", true);

            UnityEngine.Debug.Log(process.StandardOutput.ReadToEnd());
        }
        
        public static void Init()
        {
            Run();
        }
    }
}