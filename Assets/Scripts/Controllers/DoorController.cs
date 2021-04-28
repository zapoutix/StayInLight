using UnityEngine;

namespace StayInLight.Controllers
{
    public class DoorController : MonoBehaviour
    {
        [HideInInspector]
        public bool IsOpen;
        Animator _animator;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void Awake()
        {
            IsOpen = false;
            _animator = GetComponent<Animator>();
        }

        public void OnPlayerTrigger()
        {
            if (IsOpen)
                //Next level
                ;
        }

        public void Open()
        {
            IsOpen = true;
            _animator.SetBool("Open", true);
        }
    }

}