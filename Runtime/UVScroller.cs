using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class UVScroller : MonoBehaviour
    {
        [SerializeField] private float scrollSpeed = 0.01f;
        [SerializeField] private bool u = false, v = false;

        private MeshRenderer _rend;
        private static readonly int MainTex = Shader.PropertyToID("_MainTex");

        private void Awake()
        {
            _rend = GetComponent<MeshRenderer>();
        }

        private void Update()
        {
            float offset = Time.time * scrollSpeed % 1;
            if (u == true && v == true)
            {
                _rend.material.SetTextureOffset(MainTex, new Vector2(offset, offset));
            }
            else if (u == true)
            {
                _rend.material.SetTextureOffset(MainTex, new Vector2(offset, 0));
            }
            else if (v == true)
            {
                _rend.material.SetTextureOffset(MainTex, new Vector2(0, offset));
            }
        }
    }
}
