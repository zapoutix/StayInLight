using UnityEngine;

namespace StayInLight.Controllers
{

    public class CameraController : MonoBehaviour
    {
        Animator _animator;

        // Start is called before the first frame update
        void Start()
        {

        }

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Shake()
        {
            _animator.Play("Shake");
        }
    }
}