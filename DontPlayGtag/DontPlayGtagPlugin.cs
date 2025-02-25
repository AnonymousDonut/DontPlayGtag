using BepInEx;
using UnityEngine;

namespace DontPlayGtag
{
    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class DontPlayGtagPlugin : BaseUnityPlugin
    {
        private const string MyGUID = "com.donut.gorillatag.dontplaygtag";
        private const string PluginName = "DontPlayGtag";
        private const string VersionString = "1.0.0";

        private void Start() => Application.Quit();
    }
}
