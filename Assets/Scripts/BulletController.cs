using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;

    public float lifetime = 2.0f;


    private void Awake()
    {
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);  
	}
}
