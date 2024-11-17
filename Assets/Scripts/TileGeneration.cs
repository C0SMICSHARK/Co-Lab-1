using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour
{

    [SerializeField]
    NoiseMapGeneration noiseMapGeneration;

    [SerializeField]
    private MeshRenderer tileRenderer;

    [SerializeField]
    private MeshFilter meshFilter;

   [SerializeField]
   private MeshCollider meshCollider;

    [SerializeField]
    private float mapScale;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateTile();
    }

   void GenerateTile()
    {
        // Calculate tile depth and width based on the mesh Vertices
        Vector3[] meshVertices = this.meshFilter.mesh.vertices;
        int tileDepth = (int)Mathf.Sqrt(meshVertices.Length);
        int tileWidth = tileDepth;

        // Calculate the offsets based on the tile position
        float[,] heightMap = this.noiseMapGeneration.GenerateNoiseMap (tileDepth, tileWidth, this.mapScale);

       
        
    }
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
