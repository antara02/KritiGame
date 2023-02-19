using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthSccript : MonoBehaviour
{
    Vector2 temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp=transform.localScale;
        temp.x+=0.5f*Time.deltaTime;
        temp.y+=0.5f*Time.deltaTime;
        transform.localScale=temp;
    }
}
