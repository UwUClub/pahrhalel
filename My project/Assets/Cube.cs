using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HyperCasual.Runner {
    public class Cube : MonoBehaviour
    {

        public float speed = 10f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }

        public void ChangePos(float value)
        {
            if (value > 0) {
                transform.position = new Vector3(9, transform.position.y, transform.position.z);
            } else {
                transform.position = new Vector3(12, transform.position.y, transform.position.z);
            }
        }

        public void ResetCube()
        {
            transform.position = new Vector3(10, transform.position.y, 0);
        }
    }
}