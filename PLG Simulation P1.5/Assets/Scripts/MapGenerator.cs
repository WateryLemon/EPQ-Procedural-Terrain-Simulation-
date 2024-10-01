using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour
{

	// values defining the map (now including octaves, persistance, lacunarity)
	public int mapWidth;
	public int mapHeight;
	public float noiseScale;

	public int octaves;
	public float persistance;
	public int lacunarity;

	public int seed;

	public Vector2 offset;

	public bool autoUpdate;

	public void GenerateMap()
	{
		//added the new values to this function so that they can be fetched from the Noise script)
		float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, noiseScale, octaves, persistance, lacunarity, seed, offset); 

		MapDisplay display = FindObjectOfType<MapDisplay>();
		display.DrawNoiseMap(noiseMap);
	}

}