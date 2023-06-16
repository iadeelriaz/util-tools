using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class RandomMatColor : MonoBehaviour
    {
        [SerializeField] private Texture2D[] bodyColors;
        private Material _mat;

        // Start is called before the first frame update
        private void Start()
        {
            var rand = Random.Range(0, bodyColors.Length);
            _mat = GetComponent<Renderer>().material;
            _mat.mainTexture = bodyColors[rand];
        }
    }
}
