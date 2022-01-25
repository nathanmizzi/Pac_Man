using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int musicStatusCnt = FindObjectsOfType<MusicPlayer>().Length;


        if (musicStatusCnt > 1) { 
            Destroy(gameObject);
        }
        else
        {
            GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
        }

    }

}
