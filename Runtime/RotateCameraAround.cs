using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class RotateCameraAround : MonoBehaviour
    {
        [SerializeField] private Transform objectLookAt;
        [SerializeField] private float speed = 10f;
        
        private void Start()
        {
            if (!objectLookAt)
            {
                objectLookAt = transform;
            }
        }
        private void Update()
        {
            transform.LookAt(objectLookAt);
            transform.RotateAround(objectLookAt.position, new Vector3(0f, 1f, 0f), speed * Time.deltaTime);
        }
    }
}
