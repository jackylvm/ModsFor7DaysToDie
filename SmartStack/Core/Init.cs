// ***********************************************************************************
// FileName: Init.cs
// Description:
// 
// Version: v1.0.0
// Creator: Jacky(jackylvm@foxmail.com)
// CreationTime: 2026-06-26 14:53:02
// ==============================================
// History update record:
// 
// ==============================================
// *************************************************************************************

using System;
using HarmonyLib;
using UnityEngine;

namespace SmartStack.Core
{
    public class SmartStackAPI : IModApi
    {
        public void InitMod(Mod modInstance)
        {
            Debug.Log("[SmartStack]> 模组正在初始化...");
            try
            {
                var harmony = new Harmony("com.jacky.smartstack");
                harmony.PatchAll();

                Debug.Log("[SmartStack]> Harmony补丁注入成功,准备就绪!");
            }
            catch (Exception e)
            {
                Debug.LogError($"[SmartStack]> 模块初始化失败: {e.Message}");
                Debug.LogError(e.StackTrace);
            }
        }
    }
}