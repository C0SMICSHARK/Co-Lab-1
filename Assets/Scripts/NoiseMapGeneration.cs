using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class NoiseMapGeneration : MonoBehaviour
{
    
    public float[,] GenerateNoiseMap(int mapDepth, int mapWidth, float scale)
    {
        //with the mapDeath and mapWidth coordinates
                float[,] noiseMap = new float[mapDepth, mapWidth];

        for (int zIndex =0; zIndex < mapDepth; zIndex++)
        {
            for (int xIndex =0; xIndex < mapWidth; xIndex++)
            {
                // calculate sample indices based on the coordinates and the scale.
                float sampleX = xIndex / scale;
                float sampleZ = zIndex / scale;

                // generate noise value using perlin noise.
                float noise = Mathf.PerlinNoise(sampleX, sampleZ);

                noiseMap[zIndex, xIndex] = noise;
            }
        }
    
        return noiseMap;
    
    
    
    }
    
    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }









}
