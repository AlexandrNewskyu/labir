using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject cam1;
    public HP hp;
    // Start is called before the first frame update
    void Start()
    {
        cam1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(hp.health <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
