using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text MyscoreText,sun_count,water_count,fertiliser_count;
    private int ScoreNum;
    private int sun,water,fertiliser;

    Vector2 temp;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum=0;
        sun=0;
        water=0;
        fertiliser=0;
        MyscoreText.text="Score : "+ScoreNum;
        sun_count.text="Present: "+sun;
        water_count.text="Present: "+water;
        fertiliser_count.text="Present: "+fertiliser;
    }

     private void OnTriggerEnter2D(Collider2D coll) {
        
        if(coll.tag=="Sun")
        {
            sun++;

            if (sun<=7)
            {
             ScoreNum+=10;   
             temp.x+=0.005f*10;
             temp.y+=0.005f*10;
             transform.localScale=temp;
            }
            else
            {
                ScoreNum-=5;
                temp.x-=0.005f*10;
                temp.y-=0.005f*10;
                transform.localScale=temp;
            }
            MyscoreText.text="Score : " +ScoreNum;
            sun_count.text="Present: " +sun;
            water_count.text="Present: " +water;
            fertiliser_count.text="Present: " +fertiliser;
        }
        if(coll.tag=="Water")
        {
            water++;
            if (water<=5)
            {
             ScoreNum+=15;   
             temp.x+=0.006f*15;
             temp.y+=0.006f*15;
             transform.localScale=temp;
            }
            else
            {
                ScoreNum-=7;
                temp.x-=0.009f*15;
                temp.y-=0.009f*15;
                transform.localScale=temp;
                
            }
            MyscoreText.text="Score : " +ScoreNum;
            sun_count.text="Present: " +sun;
            water_count.text="Present: " +water;
            fertiliser_count.text="Present: " +fertiliser;
        }
        if(coll.tag=="Fertiliser")
        {
            fertiliser++;
            if (fertiliser<=3)
            {
             ScoreNum+=20; 
             temp.x+=0.007f*20;
             temp.y+=0.007f*20;
             transform.localScale=temp;  
            }
            else
            {
                ScoreNum-=10;
                temp.x-=0.008f*20;
                temp.y-=0.008f*20;
                transform.localScale=temp;
            }
            MyscoreText.text="Score : " +ScoreNum;
            sun_count.text="Present: " +sun;
            water_count.text="Present: " +water;
            fertiliser_count.text="Present: " +fertiliser;
        }
        if(coll.tag=="AcidRain")
        {
                ScoreNum-=5;
                temp.x-=0.02f*15;
                temp.y-=0.02f*15;
                transform.localScale=temp;
                MyscoreText.text="Score : " +ScoreNum;
                
         }
    }
    // Update is called once per frame
    void Update()
    {
        temp=transform.localScale;

        //temp.x+=0.01f*ScoreNum;
        //temp.y+=0.01f*ScoreNum;
        //transform.localScale=temp;
    }
}
