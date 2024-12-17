using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletp : MonoBehaviour
{
    public float duration;
    public float damaje;
    void Start()
    {
        Destroy(gameObject,duration);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemai"))
        {            
            Statsenemai enemy = other.GetComponent<Statsenemai>();
            enemy.Recibidamage(damaje);
            Destroy(gameObject);
        }
    }
}
