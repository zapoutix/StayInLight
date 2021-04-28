using StayInLight.Managers;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

namespace StayInLight.Controllers
{
    [RequireComponent(typeof(Animator))]
    public class LightController : MonoBehaviour
    {
        Light2D _light;
        Animator _animator;
        GameManager _gameManager;

        public bool IsLightOn => _light.enabled;

        private void Awake()
        {
            _light = transform.GetComponentInChildren<Light2D>();
            _animator = GetComponent<Animator>();
            _gameManager = GameObject.FindObjectOfType<GameManager>();

            SwitchLightOff();
        }


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SwitchLightOn()
        {
            _light.enabled = true;
            _animator.SetBool("SwitchOn", true);

            _gameManager.OnLightOn(this);

        }

        public void SwitchLightOff()
        {
            _light.enabled = false;
            _animator.SetBool("SwitchOn", false);
        }

        public void SwitchLight()
        {
            if (IsLightOn)
                SwitchLightOff();
            else
                SwitchLightOn();
        }
    }
}