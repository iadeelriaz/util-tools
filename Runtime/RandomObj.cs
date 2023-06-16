using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class RandomObj : MonoBehaviour
    {
        public GameObject[] objs;
        private void Start()
        {
            var rand = Random.Range(0, objs.Length);
            foreach (var t in objs)
            {
                t.SetActive(false);
            }
            objs[rand].SetActive(true);
        }
    
    }
}
