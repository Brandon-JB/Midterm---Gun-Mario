using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StupendousGunThingTheme : MonoBehaviour
{
    public AudioSource mainTheme;

    // Start is called before the first frame update
    void Start()
    {
            mainTheme.Play();

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Stop()
    {
        mainTheme.Stop();
    }

}
