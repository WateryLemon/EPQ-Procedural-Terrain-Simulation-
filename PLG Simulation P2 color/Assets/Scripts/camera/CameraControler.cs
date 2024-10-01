using UnityEngine;

public class CameraControler : MonoBehaviour {

	public float CameraSpeed = 20f;
	public float panBoarderThickness = 10f;
	public Vector2 panLimit;
	
	void Update () {

		Vector3 pos = transform.position;

		if (Input.GetKey(KeyCode.UpArrow))
        {
			pos.z += CameraSpeed * Time.deltaTime;
        }
		if (Input.GetKey(KeyCode.DownArrow))
		{
			pos.z -= CameraSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			pos.x += CameraSpeed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			pos.x -= CameraSpeed * Time.deltaTime;
		}

		if (pos.x == panLimit.x)
        {
			pos.x = 0;
        }
		if (pos.x == -panLimit.x)
		{
			pos.x = 0;
		}
		if (pos.z == panLimit.y)
		{
			pos.z = 0;
		}
		if (pos.z == -panLimit.x)
		{
			pos.z = 0;
		}

		pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
		pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

		transform.position = pos;


	}
}
