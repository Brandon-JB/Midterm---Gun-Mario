using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowUnfortunate : MonoBehaviour
{
    public GameObject howUnfortunate;
    public GameObject Die;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            howUnfortunate.SetActive(true);
            Die.SetActive(true);
        }
    }
}
