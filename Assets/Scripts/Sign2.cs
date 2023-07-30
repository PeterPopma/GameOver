using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sign2 : MonoBehaviour
{
    [SerializeField] Image imageGameOver;
    float timeLeftBeforeGameOver = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        imageGameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeftBeforeGameOver>0)
        {
            timeLeftBeforeGameOver -= Time.deltaTime;
            if (timeLeftBeforeGameOver < 0)
            {
                imageGameOver.enabled = true;
            }
        }
    }

    void OnTriggerEnter()
    {
        object[] obj = GameObject.FindObjectsOfType(typeof(GameObject));
        foreach (object go in obj)
        {
            if (((GameObject)go).GetComponent<MeshRenderer>() != null)
            {
                if(((GameObject)go).name.Equals("Ground"))
                {
                    Destroy((GameObject)go);
                }
                else
                {
                    ((GameObject)go).AddComponent<Rigidbody>();
                    ((GameObject)go).GetComponent<Rigidbody>().AddForce(Random.onUnitSphere * 100);
                    ((GameObject)go).GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere * 100);
                }
            }
        }

        if (timeLeftBeforeGameOver == 0)
        {
            timeLeftBeforeGameOver = 2;
        }
    }
}
