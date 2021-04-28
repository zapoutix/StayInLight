using StayInLight.Managers;
using UnityEngine;

namespace StayInLight.Controllers
{
    public class SwitchController : MonoBehaviour
    {
        public bool Switched { get; set; }
        SpriteRenderer _spriteRenderer;
        GameManager _gameManager;
        // Start is called before the first frame update
        void Start()
        {

        }

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _gameManager = GameObject.FindObjectOfType<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            SwitchOn();
        }


        public void SwitchOn()
        {
            _spriteRenderer.flipX = true;
            Switched = true;
            _gameManager.OnToggleSwitch(this);
        }
    }
}