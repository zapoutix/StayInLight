using UnityEngine;

namespace StayInLight.Controllers
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        public float Speed = 5;
        private Rigidbody2D _rigidBody;
        private Vector2 _movement;
        private SpriteRenderer _spriteRenderer;
        bool _spriteFliped = false;

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");

            if (_movement.x > 0.5)
                _spriteFliped = false;
            if (_movement.x < -0.5)
                _spriteFliped = true;
            _spriteRenderer.flipX = _spriteFliped;
        }

        private void FixedUpdate()
        {
            _rigidBody.MovePosition(_rigidBody.position + _movement * Speed * Time.fixedDeltaTime);
        }
    }
}