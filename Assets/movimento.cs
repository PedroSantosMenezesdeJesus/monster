using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    Vector3 m;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        m = new Vector3(3, 7, -110);
=======
        m = new Vector3(0, 6, -4);
>>>>>>> 6978ee4ede507a02b7ee53d5aea822cd2c63bcf2
        transform.position = m;
        m.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            m.z = 0.25f;
            transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.A))
        {
            m.z = -0.25f;
            transform.Translate(m);
        }
        if (Input.GetKey(KeyCode.Space))
        {
<<<<<<< HEAD
            m.y = 0.050f;
=======
            m.y = 0.025f;
>>>>>>> 6978ee4ede507a02b7ee53d5aea822cd2c63bcf2
            transform.Translate(m);
        }
        m.Set(0, 0, 0);
    }
}
