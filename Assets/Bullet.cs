using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f;
    public float lifespan = 1.5f;
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        //transform.Translate(transform.forward.x * speed, transform.forward.y * speed, transform.forward.z * speed);
        transform.Translate(transform.forward * speed * Time.deltaTime);

        if (counter >= lifespan) 
        {
            Destroy(gameObject);
        }
    }
}
