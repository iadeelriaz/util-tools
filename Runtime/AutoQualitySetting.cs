using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class AutoQualitySetting : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            AdjustSettings();
            TexturesQuality();
        }

        private static void AdjustSettings()
        {
            if (SystemInfo.systemMemorySize > 3200 && SystemInfo.graphicsMemorySize > 900)
            {
                QualitySettings.vSyncCount = 1;
                QualitySettings.skinWeights = SkinWeights.TwoBones;
            }
        }

        private static void TexturesQuality()
        {
            if (SystemInfo.systemMemorySize < 1500)
            {
                QualitySettings.masterTextureLimit = 2;
            }
            else if (SystemInfo.systemMemorySize > 1500 && SystemInfo.systemMemorySize < 2500)
            {
                QualitySettings.masterTextureLimit = 1;
            }
            else
            {
                QualitySettings.masterTextureLimit = 0;
            }
        }
    }
}