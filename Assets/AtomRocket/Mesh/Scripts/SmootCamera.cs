using System.Threading;
using UnityEngine;

public class SmootCamera : MonoBehaviour
{

	public Transform target; //get information about position rotation and scale
	public float smoothSpeed = 0.125f;
	public Vector3 offset; //hiermee kan je de x, y, z aanpassen

	void FixedUpdate()
    {
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(target.position, desiredPosition, smoothSpeed * Time.deltaTime); //linear interpolatioin
		transform.position = smoothedPosition;

		transform.LookAt(target);
    }
}
