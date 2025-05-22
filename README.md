## 🌍 About
Procedural Terrain Simulation is a Unity/C# project that demonstrates procedural generation techniques for creating 2D terrain maps. Developed as an Extended Project Qualification (EPQ), this project aims to teach and showcase how real-world terrain features can be simulated algorithmically, with a focus on clarity, modularity, and educational value.

- **Procedural Generation**: Uses Perlin noise and fractal noise to generate realistic terrain heightmaps.
- **Biomes & Color Mapping**: Assigns different colors to terrain types (biomes) based on height values.
- **Interactive Controls**: Includes camera movement and real-time map regeneration via the Unity Editor.
- **Modular Structure**: Clean separation between noise generation, texture creation, and map display for easy extension and experimentation.

This project is ideal for learning about procedural content generation, Unity scripting, and the basics of computer graphics in a game engine context.



## ![Static Badge](https://img.shields.io/badge/release-v2.0)





## 📝 How to Build
To build and run this project:

```Bash
# Ensure you have Unity (version 5.3.0f4 or later) installed.
# Download from: https://unity.com/releases

# Clone the repository
git clone https://github.com/WateryLemon/EPQ-Procedural-Terrain-Simulation-.git

# Open Unity Hub
# Click 'Add', then select the project folder (e.g., 'PLG Simulation P2 color')

# Open the project in Unity Editor

# Open the main scene:
# Assets/Scenes/Scene.unity

# Press Play to run the simulation

# To edit scripts, open the project in Visual Studio Code: code .
```

## 📚 Project Structure & Components

This Unity project is organized for clarity and modularity. Here’s a breakdown of the main components:

🌄 Noise Generation
- Noise: Generates 2D noise maps using Perlin noise, supporting multiple octaves, persistence, lacunarity, and random seed/offsets for varied terrain.

🗺️ Map Generation & Display
- MapGenerator: Orchestrates the creation of noise maps, biome color mapping, and passes data to the display.
- MapDisplay: Renders the generated texture onto a Unity plane using a Renderer component.

🎨 Texture Generation
- TextureGenerator: Converts color arrays and heightmaps into Unity Texture2D objects for visualization.

🏞️ Biomes & Color Mapping
- TerrainTypes struct: Associates height thresholds with specific colors and biome names, allowing for customizable terrain types (e.g., water, sand, grass, mountain).

🎮 Camera Controls
- CameraControler: Allows the user to pan and move the camera around the terrain using arrow keys, with configurable speed and boundaries.

🛠️ Editor Tools
- MapGeneratorEditor: Custom Unity Editor inspector for the map generator, enabling real-time updates and a "Generate" button for quick iteration.

**Example Project Structure**:
```
PLG Simulation P2 color/
├── Assets/
│   ├── Scripts/
│   │   ├── Noise.cs
│   │   ├── MapGenerator.cs
│   │   ├── MapDisplay.cs
│   │   ├── TextureGenerator.cs
│   │   └── camera/CameraControler.cs
│   └── Editor/
│       └── MapGeneratorEditor.cs
├── ProjectSettings/
├── Library/
└── ...
```



<a name="contacts"></a>
## 📬 Contacts

For questions, feedback, or collaboration inquiries, please reach out:

- **Name:** Jules Tournier

[![Email](https://img.shields.io/badge/jules@tournier.us-white.svg?logo=gmail&logoColor=red)](mailto:jules@tournier.us)
[![GitHub](https://img.shields.io/badge/WateryLemon-white.svg?logo=github&logoColor=000000)](https://github.com/WateryLemon)
[![LinkedIn](https://img.shields.io/badge/Jules_Tournier-white.svg?logo=data:image/svg%2bxml;base64,PHN2ZyB2aWV3Qm94PSIwIDAgMjQgMjQiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PHBhdGggZD0iTTIwLjQ0NyAyMC40NTJoLTMuNTU0di01LjU2OWMwLTEuMzI4LS4wMjctMy4wMzctMS44NTItMy4wMzctMS44NTMgMC0yLjEzNiAxLjQ0NS0yLjEzNiAyLjkzOXY1LjY2N0g5LjM1MVY5aDMuNDE0djEuNTYxaC4wNDZjLjQ3Ny0uOSAxLjYzNy0xLjg1IDMuMzctMS44NSAzLjYwMSAwIDQuMjY3IDIuMzcgNC4yNjcgNS40NTV2Ni4yODZ6TTUuMzM3IDcuNDMzYTIuMDYyIDIuMDYyIDAgMCAxLTIuMDYzLTIuMDY1IDIuMDY0IDIuMDY0IDAgMSAxIDIuMDYzIDIuMDY1em0xLjc4MiAxMy4wMTlIMy41NTVWOWgzLjU2NHYxMS40NTJ6TTIyLjIyNSAwSDEuNzcxQy43OTIgMCAwIC43NzQgMCAxLjcyOXYyMC41NDJDMCAyMy4yMjcuNzkyIDI0IDEuNzcxIDI0aDIwLjQ1MUMyMy4yIDI0IDI0IDIzLjIyNyAyNCAyMi4yNzFWMS43MjlDMjQgLjc3NCAyMy4yIDAgMjIuMjIyIDBoLjAwM3oiIGZpbGw9IiMwQTY2QzIiLz48cGF0aCBzdHlsZT0iZmlsbDojZmZmO3N0cm9rZS13aWR0aDouMDIwOTI0MSIgZD0iTTQuOTE3IDcuMzc3YTIuMDUyIDIuMDUyIDAgMCAxLS4yNC0zLjk0OWMxLjEyNS0uMzg0IDIuMzM5LjI3NCAyLjY1IDEuNDM3LjA2OC4yNS4wNjguNzY3LjAwMSAxLjAxYTIuMDg5IDIuMDg5IDAgMCAxLTEuNjIgMS41MSAyLjMzNCAyLjMzNCAwIDAgMS0uNzktLjAwOHoiLz48cGF0aCBzdHlsZT0iZmlsbDojZmZmO3N0cm9rZS13aWR0aDouMDIwOTI0MSIgZD0iTTQuOTE3IDcuMzc3YTIuMDU2IDIuMDU2IDAgMCAxLTEuNTItMi42NyAyLjA0NyAyLjA0NyAwIDAgMSAzLjQxOS0uNzU2Yy4yNC4yNTQuNDIuNTczLjUxMi45MDguMDY1LjI0LjA2NS43OCAwIDEuMDItLjA1MS4xODYtLjE5Ny41MDQtLjMuNjUyLS4wOS4xMzItLjMxLjM2Mi0uNDQzLjQ2NC0uNDYzLjM1Ny0xLjEuNTAzLTEuNjY4LjM4MlpNMy41NTcgMTQuNzJWOS4wMDhoMy41NTd2MTEuNDI0SDMuNTU3Wk05LjM1MyAxNC43MlY5LjAwOGgzLjQxMXYuNzg1YzAgLjYxNC4wMDUuNzg0LjAyNi43ODMuMDE0IDAgLjA3LS4wNzMuMTI0LS4xNjIuNTI0LS44NjUgMS41MDgtMS40NzggMi42NS0xLjY1LjI3NS0uMDQyIDEtLjA0NyAxLjMzMi0uMDA5Ljc5LjA5IDEuNDUxLjMxNiAxLjk0LjY2NC4yMi4xNTcuNTU3LjQ5My43MTQuNzEzLjQyLjU5Mi42OSAxLjQxMi44MDggMi40NjQuMDc0LjY2My4wODQgMS4yMTUuMDg1IDQuNTc4djMuMjU4aC0zLjUzNnYtMi45ODZjMC0yLjk3LS4wMS0zLjQ3NC0uMDc0LTMuOTA4LS4wOS0uNjA2LS4zMTQtMS4wODItLjYzNC0xLjM0Mi0uMzk1LS4zMjItMS4wMjktLjQzNy0xLjcwMy0uMzA5LS44NTguMTYzLTEuMzU1Ljc1LTEuNTIzIDEuNzk3LS4wNzYuNDcxLS4wODQuODQ1LS4wODQgMy44MzR2Mi45MTRIOS4zNTN6Ii8+PC9zdmc+)](https://www.linkedin.com/in/jules-tournier-5a7b47229/)

Feel free to open an issue or pull request if you have suggestions or find any bugs!

[Back to top](#top)
