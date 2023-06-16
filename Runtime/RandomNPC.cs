using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class RandomNpc : MonoBehaviour
    {

        public enum SkinType
        {
            Mesh,
            Mat
        }

        public SkinType skinType;
        public GameObject[] npcSkin;
        public Material[] npcSkinsMat;
        public Renderer rend;

        #region Unity Methods

        private void Start()
        {
            if (skinType == SkinType.Mesh)
            {
                var rand = Random.Range(0, npcSkin.Length);

                foreach (var npc in npcSkin)
                {
                    npc.SetActive(false);
                }

                npcSkin[rand].SetActive(true);
            }
            else
            {
                var rand = Random.Range(0, npcSkinsMat.Length);
                rend.material = npcSkinsMat[rand];
            }
        }

        #endregion
    }
}
