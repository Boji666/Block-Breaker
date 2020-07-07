using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int breakableBlocks; // serialized for debugging purposes

    // cached reference
    SceneLoader sceneLoader;

    public void Start()
    {
        breakableBlocks = 0;
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void CountBreakableBlocks()
    {
        breakableBlocks += 1;
    }

    public void BlockDestroyed()
    {
        breakableBlocks -= 1;
        if ( breakableBlocks <= 0 )
        {
            sceneLoader.LoadNextScene();
        }
    }

}
