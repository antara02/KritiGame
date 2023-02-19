using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ItemCollector : MonoBehaviour
{
    private int sun=0,water=0,fertiliser=0;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Sun"))
        {
            FindObjectOfType<AudioManager>().Play("Collecting");
            Destroy(collision.gameObject);
            sun++;
        }
        if (collision.gameObject.CompareTag("Water"))
        {
            FindObjectOfType<AudioManager>().Play("Collecting");
            Destroy(collision.gameObject);
           water++;
        }
        if (collision.gameObject.CompareTag("Fertiliser"))
        {
            FindObjectOfType<AudioManager>().Play("Collecting");
            Destroy(collision.gameObject);
            fertiliser++;
        }
        if (collision.gameObject.CompareTag("AcidRain"))
        {
            FindObjectOfType<AudioManager>().Play("Harm");
            Destroy(collision.gameObject);
            //fertiliser++;
        }
        if (collision.gameObject.CompareTag("EndPoint"))
        {
            FindObjectOfType<AudioManager>().Play("Win");
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            //fertiliser++;
        }
    }
}
