using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    Vector3 m;
    // Start is called before the first frame update
    void Start()
    {
        m = new Vector3(0, 6, -4);
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
            m.y = 0.025f;
            transform.Translate(m);
        }
        m.Set(0, 0, 0);
    }
}
