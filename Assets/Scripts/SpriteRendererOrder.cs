using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StayInLight
{
    public class SpriteRendererOrder : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        private void Awake()
        {
            SetPosition();
        }

        // Update is called once per frame
        void Update()
        {
            SetPosition();
        }

        void SetPosition()
        {
            GetComponent<SpriteRenderer>().sortingOrder = 100 - (int)(transform.position.y * 10);
        }
    }
}