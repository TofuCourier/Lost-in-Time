<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveltransport : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { //loading level with build index
            SceneManager.LoadScene(1);

            //Loading level with scene name
            //SceneManager.LoadScene("SceneName");
            
            //Restart Level
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leveltransport : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { //loading level with build index
            SceneManager.LoadScene(1);

            //Loading level with scene name
            //SceneManager.LoadScene("SceneName");
            
            //Restart Level
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
>>>>>>> CHLOE
