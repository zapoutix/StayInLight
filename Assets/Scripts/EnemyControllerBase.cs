using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace StayInLight
{
    public abstract class EnemyControllerBase : MonoBehaviour
    {
        public GameObject FirePrefab;
        protected abstract float BurningTimeInSec { get; }

        [HideInInspector]
        public bool IsBurning;

        public EnemyControllerBase()
        {
            IsBurning = false;
        }

        public void Burn()
        {
            var fireObject = Instantiate(FirePrefab, gameObject.transform.position + new Vector3(0, -0.1f, 0), Quaternion.identity, gameObject.transform);
            IsBurning = true;
            Destroy(gameObject, BurningTimeInSec);
        }
    }
}
