using BepInEx;
using System;
using UnityEngine;

namespace DontPlayGtag
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        private void Start() => Application.Quit();
    }
}
