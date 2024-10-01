using UnityEngine;
using System.Collections;
// not monobehaviour as it wont be applied to an object in the scene
// static to make sure it doesn't create multiple instances
public static class Noise {

// create a grid of value from 0-1 from generating a noise map
	public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale) { // public static method that returns a 2D list of float variable (not whole numbers), as well as creating value for height and width
		float[,] noiseMap = new float[mapWidth,mapHeight]; // 2D float array = 2D float aray of width by height

		// makes sure the scale is never 0 so we don't get an error
		if (scale <= 0) {
            scale = 0.0001f;
        }


        for (int y = 0; y < mapHeight; y++)
        {
			for (int x = 0; x < mapWidth; x++) {
				float sampleX = x / scale; //figures out which point will be sampling out height and width value from (sample coordinates)
				float sampleY = y / scale; // scale error !!!!!!

				float perlinValue = Mathf.PerlinNoise (sampleX, sampleY); // this is the perlin function that will calculate the perlin values
				noiseMap [x, y] = perlinValue;
			}
		}

		return noiseMap;
	}

}


