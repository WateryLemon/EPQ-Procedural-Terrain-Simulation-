using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour
{
	public enum DrawMode { NoiseMap, ColorMap};
	public DrawMode drawMode; // create a new toggleable variable for the draw mode to swap betwean the color and height map without overwriting the code

	[HideInInspector] public int mapWidth;
	[HideInInspector] public int mapHeight;
	public float noiseScale;

	public int octaves;
	public float persistance;
	public int lacunarity;

	public int seed;
	[HideInInspector] public Vector2 offset;

	public bool autoUpdate;

	public TerrainTypes[] Biomes; //adds the biome, color and heightmap it represents in the editor

    public void GenerateMap()
	{
		float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, noiseScale, octaves, persistance, lacunarity, seed, offset);

		Color[] colorMap = new Color[mapHeight * mapHeight]; // creates a new map called color map

		for (int y=0; y<mapHeight; y++)	// this loops through the noise to find the height value
        {
			for (int x=0; x<mapWidth; x++)
            {
				float height = noiseMap[x, y];	// once the height value has been found it associates to the biome
				for (int i=0; i < Biomes.Length; i++)
                {
					if (height <= Biomes [i].height)
                    {
						colorMap[y * mapWidth + x] = Biomes [i].color; //saves the colour for that point
						break;
                    }
                }
            }
        }
		MapDisplay display = FindObjectOfType<MapDisplay>(); //toggles the draw mode
		if (drawMode == DrawMode.NoiseMap)
		{
			display.DrawTexture(TextureGenerator.TextureFromHeightMap(noiseMap)); //draws the differnt types of maps
		}
		else if (drawMode == DrawMode.ColorMap)
		{
			display.DrawTexture(TextureGenerator.TextureFromColorMap(colorMap, mapWidth, mapHeight));
		}
	}
}

[System.Serializable]
public struct TerrainTypes	// assign 0-1 values to colors
{
	public float height;	// float for heihgt value
	public Color color;		// float for color value
	public string name;		// Type of terrain
}