using StayInLight.Controllers;
using UnityEngine;

namespace StayInLight
{
    public class LightTrigger : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
                transform.parent.GetComponent<LightController>().SwitchLight();
        }
    }
}