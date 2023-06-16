using System.Collections.Generic;
using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class CheckpointHandler : MonoBehaviour
    {
        [SerializeField] private string tagToCompare = "Player";
        [SerializeField] private string checkpointPrefix = "Checkpoint: ";
        [SerializeField] private List<Checkpoint> checkpoints;
        private int _currentCheckPoint;

        public string CompareTag => tagToCompare;

        private void OnEnable()
        {
            for (var i = 1; i < checkpoints.Count; i++)
            {
                checkpoints[i].gameObject.SetActive(false);
            }

            _currentCheckPoint = 0;
            checkpoints[_currentCheckPoint].gameObject.SetActive(true);
        }

        public void ProcessNextCheckpoint()
        {
            _currentCheckPoint++;
            if (_currentCheckPoint < checkpoints.Count)
            {    
                checkpoints[_currentCheckPoint].gameObject.SetActive(true);
            }
        }

        private void Reset()
        {
            checkpoints = new List<Checkpoint>();
            foreach (Transform cp in transform)
            {
                if (cp.TryGetComponent(out Checkpoint checkpoint))
                {
                    cp.name = string.Concat(checkpointPrefix, cp.GetSiblingIndex() + 1);
                    checkpoints.Add(checkpoint);
                }
            }
        }


        [ContextMenu("Load Checkpoints")]
        public void LoadCheckpoints()
        {
            checkpoints = new List<Checkpoint>();
            foreach (Transform cp in transform)
            {
                if (cp.TryGetComponent(out Checkpoint checkpoint))
                {
                    cp.name = string.Concat(checkpointPrefix, cp.GetSiblingIndex() + 1);
                    checkpoints.Add(checkpoint);
                }
            }
        }
    }
}
