using UnityEngine;

namespace PopUps
{
    [RequireComponent(typeof(Animator))]
    public class AnimationsPopUpController : MonoBehaviour
    {
        [SerializeField]
        private Animator _popUpAnimator;

        private void Start()
        {
            if (_popUpAnimator == null)
            {
                _popUpAnimator = GetComponent<Animator>();
            }
        }

        public void PopUpAppear()
        {
            _popUpAnimator.SetTrigger("Appear");
        }

        public void PopUpDisAppear()
        {
            _popUpAnimator.SetTrigger("DisAppear");
        }

    }
}
