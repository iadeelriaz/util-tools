using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class TranslateObject : MonoBehaviour
    {
        public float speed;
        private void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
