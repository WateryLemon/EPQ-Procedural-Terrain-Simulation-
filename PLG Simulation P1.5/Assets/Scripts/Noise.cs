using UnityEngine;
using System.Collections;

public static class Noise {

	// defines new octave, persistance, lacunarity and seed values
	public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale, int octaves, float persistance, float lacunarity, int seed, Vector2 offset) {
		float[,] noiseMap = new float[mapWidth,mapHeight];

		// creates a pseudorandom number which is = to the seed
		System.Random prng = new System.Random(seed);
		Vector2[] octaveOffsets = new Vector2[octaves]; //each octave is sampled from a different location from an array
		for (int i = 0; i < octaves; i++)
        {
			float offsetX = prng.Next(-100, 100) + offset.x;
			float offsetY = prng.Next(-100, 100) + offset.y;
			octaveOffsets[i] = new Vector2(offsetX, offsetY);
		}

		if (scale <= 0) {
			scale = 0.0001f;
		}

		// This normalises the noise map (by keep its values in the range of 0-1 by keeping track of the values)
		float maxNoiseHeight = float.MinValue;
		float minNoiseHeight = float.MaxValue;

		for (int y = 0; y < mapHeight; y++) {
			for (int x = 0; x < mapWidth; x++) {

				//Frequency and amplitude variables
				float amplitude = 1;
				float frequency = 1;
				float noiseHeight = 0;	// keeps track of the current hight value

				// Loops through the octaves
				for (int i = 0; i < octaves; i++)
				{
					float sampleX = x / scale * frequency + octaveOffsets[i].x;	//the higher the frequency = furether aprt the sample points.
					float sampleY = y / scale * frequency + octaveOffsets[i].y;  //This means that hight values will change quicker

					float perlinValue = Mathf.PerlinNoise(sampleX, sampleY) * 2 - 1;	// This allows us to get better noise values as they can no be -1 - 1 instead of 0 - 1
					noiseHeight += perlinValue * amplitude; //instead of noise map = perlinvalue, i will increase the noise hight by the perlin value of each ovtave

					amplitude *= persistance; //amplitude increases each octave
					frequency *= lacunarity;	// frequency increase each octave
				}
				//if current noise height > then current max noise, the we will update the max noise height to be = to current noise height (same with Noise height < min noise height)
				if (noiseHeight > maxNoiseHeight)
                {
					maxNoiseHeight = noiseHeight;
                } else if (noiseHeight < minNoiseHeight)
                {
					minNoiseHeight = noiseHeight;
                }
				
				// applies noise height to noise map
				noiseMap[x, y] = noiseHeight;

			}
		}
		// Once the range of noise is calculated, we loop through all the values
		// InverseLerp will give us a value between 0 and 1 ("Loops through inverselerp function which is a ... for example in the context of our code, it would...)
		for (int y = 0; y < mapHeight; y++) {
			for (int x = 0; x < mapWidth; x++) {
				noiseMap[x, y] = Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, noiseMap[x, y]);
			} 
		}

		return noiseMap;
	}

}