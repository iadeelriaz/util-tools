using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class Checkpoint : MonoBehaviour
    {
        private CheckpointHandler _checkpointHandler;

        private void Start()
        {
            _checkpointHandler = GetComponentInParent<CheckpointHandler>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(_checkpointHandler.CompareTag))
            {
                Triggered();
            }
        }
        private void Triggered()
        {
            gameObject.SetActive(false);
            _checkpointHandler.ProcessNextCheckpoint();
        }
    }
}
