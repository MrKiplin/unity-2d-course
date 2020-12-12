using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComoponent;


    // Start is called before the first frame update
    void Start()
    {
        textComoponent.text = ("Hello World");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
