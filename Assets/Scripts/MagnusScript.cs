using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusScript : MonoBehaviour {

    public Texture2D map;
    public static float[,] ganmap;
    Color[] getempixels;

	// Use this for initialization
	void Awake () {
        getempixels = map.GetPixels();
        for (int x = 0; x < map.width; x++)
        {
            for (int y = 0; y < map.height; y++)
            {
                ganmap[x,y] = getempixels[x + y * x].r;
            }
        }

    }
	
	// Update is called once per frame
	void Update () {

	}
}
