using StayInLight.Controllers;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace StayInLight.Managers
{
    public class EnemyManager : MonoBehaviour
    {
        IEnumerable<EnemyControllerBase> _enemies;

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
            _enemies = GameObject.FindObjectsOfType<EnemyControllerBase>();
        }

        public void SwitchOnLight(LightController light)
        {
            foreach (var enemy in _enemies.Where(o => !o.IsBurning))
            {
                var r = Physics2D.Linecast(light.transform.position, enemy.transform.position);
                if (r.collider.gameObject == enemy.gameObject)
                {
                    //Check distance
                    enemy.Burn();
                }
            }
        }
    }
}