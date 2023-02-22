using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            Gun gun = other.gameObject.GetComponent<Gun>();
            if (gun!=null)
            {
                gun.RefillAmmo();
            }

        }
    }
}
