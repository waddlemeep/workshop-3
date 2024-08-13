using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float countdown_timer = 3.0f;
    public float spinSpeed;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        var angle = this.spinSpeed * Time.deltaTime;
        var axis = new Vector3(1.0f, 0.0f, 0.0f);
        transform.localRotation *= Quaternion.AngleAxis(angle, axis);  
        
        countdown_timer -= Time.deltaTime;
        if (countdown_timer > 0f){
            transform.position += new Vector3(0f, 0f, 1.0f) * Time.deltaTime;
        }
        else {
            transform.position += new Vector3(0f, 0f, -1.0f) * Time.deltaTime;
            if (countdown_timer < -3.0f){
                countdown_timer = 3.0f;
            }
        }
       

    }
}
