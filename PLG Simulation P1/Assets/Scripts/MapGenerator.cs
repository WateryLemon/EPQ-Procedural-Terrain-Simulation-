using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

	// values defining the map (lacanarity and persistence later)
	public int mapWidth;
	public int mapHeight;
	public float noiseScale;

	public bool autoUpdate;

	public void GenerateMap() {
		float[,] noiseMap = Noise.GenerateNoiseMap (mapWidth, mapHeight, noiseScale); //fetches the 2D noise map from the Noise script


		MapDisplay display = FindObjectOfType<MapDisplay> (); //calls the mapdisplay with the noise map
		display.DrawNoiseMap (noiseMap);
	}
	
}
