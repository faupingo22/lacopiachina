using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class Statsenemai : MonoBehaviour
{
    public float videl;
    public Image barrita;
    public float hptotall;
    public GameObject efectoparticular;

    public void Start()
    {
        hptotall = videl;
    }

    public void Recibidamage(float damaje)
    {
        Instantiate(efectoparticular, transform.position, Quaternion.identity);
        videl -= damaje;
        ActualizaBarrita();
        if (videl <= 0)
        {
            Postmortem();
        }
    }
    public void ActualizaBarrita()
    {
        barrita.fillAmount = videl / hptotall;
    }
   private void Postmortem()
   {
      Destroy(gameObject);
   }
}
