using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BoundsScript : MonoBehaviour
{
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(LivesScript.lifeValue == 1)
        {
            music.Stop();
            SceneManager.LoadScene("GameOver");
        }

        else
        {
            LivesScript.lifeValue -= 1;
            col.GetComponent<BallScript>().Respawn();
        }
    }
}
