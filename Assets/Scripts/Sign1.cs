using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sign1 : MonoBehaviour
{
    [SerializeField] Image imageGameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        imageGameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        imageGameOver.enabled = true;
    }
}
