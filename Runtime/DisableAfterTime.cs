using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class DisableAfterTime : MonoBehaviour
    {
        [SerializeField] private float wait;
        
        private void OnEnable()
        {
            Invoke(nameof(DisableGameObject), wait);
        }

        private void DisableGameObject()
        {
            gameObject.SetActive(false);
        }
    }
}
