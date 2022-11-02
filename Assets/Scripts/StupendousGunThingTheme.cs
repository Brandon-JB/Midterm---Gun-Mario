using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StupendousGunThingTheme : MonoBehaviour
{
    public AudioSource mainTheme;
    static StupendousGunThingTheme Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
