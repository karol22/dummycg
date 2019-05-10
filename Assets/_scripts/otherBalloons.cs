using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherBalloons : MonoBehaviour
{
    float ini;
    // Start is called before the first frame update
    void Start()
    {
        ini = Random.Range(0f, 3.14f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime*Mathf.Sin(ini));
        transform.position += transform.forward * Time.deltaTime * 1.5f;   
        ini = ini + 0.01f;
    }
}
