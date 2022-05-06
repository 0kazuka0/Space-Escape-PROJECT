using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    public GameObject bulletpref;
    public Vector3 bulletposi = new Vector3(0.02f, 0, 0);
    int bulletlayer;
    public float firetime = 0.5f;
    float delaytime = 0f;


    private void Start()
    {
        bulletlayer = gameObject.layer;
    }
    void Update()
    {


        delaytime -= Time.deltaTime;
        if (delaytime <= 0)
        {
            delaytime = firetime;

            Vector3 offset = transform.rotation * bulletposi;
            GameObject bulletgo = Instantiate(bulletpref, transform.position + bulletposi, transform.rotation);
            bulletgo.layer = bulletlayer;
        }

    }
}
