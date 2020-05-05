using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(30, 60, 90) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();

        }
    }

}

