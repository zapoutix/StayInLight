using StayInLight.Controllers;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace StayInLight.Managers
{
    public class GameManager : MonoBehaviour
    {
        IEnumerable<SwitchController> _switches;
        DoorController _door;
        CameraController _camera;
        EnemyManager _enemyManager;
        // Start is called before the first frame update
        void Start()
        {

        }

        private void Awake()
        {
            _switches = GameObject.FindObjectsOfType<SwitchController>();
            _door = GameObject.FindObjectOfType<DoorController>();
            _camera = GameObject.FindObjectOfType<CameraController>();
            _enemyManager = GameObject.FindObjectOfType<EnemyManager>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnToggleSwitch(SwitchController sw)
        {
            if (_door.IsOpen)
                return;

            if (_switches.Any(o => !o.Switched))
                return;

            _door.Open();
            _camera.Shake();
        }

        public void OnLightOn(LightController light)
        {
            _enemyManager.SwitchOnLight(light);
        }
    }
}