using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatActivate : MonoBehaviour
{
    public bool activateBats = false;
    public int batsKilled = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //FindObjectOfType<BatController>().follow = true;
            Activate();
        }


    }
    public void Activate()
    {
        activateBats = true;
    }
}
