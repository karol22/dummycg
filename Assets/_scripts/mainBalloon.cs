using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainBalloon : MonoBehaviour
{
    float mov = 0.015f;
    float velocity = 0.6f;
    float velocityUp = 0.0f;
    float sign = 1.0f;
    float wait = 0.0f;
    float deltaUp = 0.015f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(wait <10.0f){
            wait = wait + 0.09f;
        } else {
            
            transform.Translate(0, 0, Time.deltaTime*velocity);
            transform.Translate(Time.deltaTime*velocity, 0, 0);

            transform.Translate(Vector3.up * Time.deltaTime*velocityUp*velocityUp*sign/3);
            //mov = mov+0.01f;
            if(velocity < 7.2f){
                velocity = velocity + 0.02f;
            }
            if(velocityUp > 4.8f){
                sign = -1.0f;
                velocityUp = 0.12f;
                deltaUp = 0.002f;
            }
            if(sign > 0.0f){
                velocityUp = velocityUp + deltaUp;
            }
        }
    }
}
