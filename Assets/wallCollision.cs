using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallCollision : MonoBehaviour
{
    public Material[] wallMat;
    Renderer rend;
    public Text display;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        display.text = "Roll the Ball";

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Ball")
        {
            rend.sharedMaterial = wallMat[1];
            display.text = "u Hit the Wall";
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            rend.sharedMaterial = wallMat[0];
            display.text = "Keep Rolling the ball";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
