using UnityEngine;

namespace AdeelRiaz.Tools
{
    public class IKControl : MonoBehaviour
    {

        public bool enableIK;

        public IKPoint rightHand, leftHand, rightFoot, leftFoot;

        private Animator _animator;

        // Start is called before the first frame update
        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void OnAnimatorIK(int layerIndex)
        {
            if (_animator == null || !enableIK) return;

            if (rightHand.target != null)
            {
                _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHand.weightPos);
                _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHand.weightRot);
                _animator.SetIKPosition(AvatarIKGoal.RightHand, rightHand.target.position);
                _animator.SetIKRotation(AvatarIKGoal.RightHand, rightHand.target.rotation);
            }

            if (leftHand.target != null)
            {
                _animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHand.weightPos);
                _animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, leftHand.weightRot);
                _animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHand.target.position);
                _animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHand.target.rotation);

            }

            if (rightFoot.target != null)
            {
                _animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, rightFoot.weightPos);
                _animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, rightFoot.weightRot);
                _animator.SetIKPosition(AvatarIKGoal.RightFoot, rightFoot.target.position);
                _animator.SetIKRotation(AvatarIKGoal.RightFoot, rightFoot.target.rotation);

            }

            if (leftFoot.target != null)
            {
                _animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, leftFoot.weightPos);
                _animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, leftFoot.weightRot);
                _animator.SetIKPosition(AvatarIKGoal.LeftFoot, leftFoot.target.position);
                _animator.SetIKRotation(AvatarIKGoal.LeftFoot, leftFoot.target.rotation);

            }
        }

        public void SetIkState(bool state)
        {
            enableIK = state;
        }

        [System.Serializable]
        public struct IKPoint
        {
            [Range(0, 1)] public float weightPos, weightRot;
            public Transform target;
        }
    }
}
