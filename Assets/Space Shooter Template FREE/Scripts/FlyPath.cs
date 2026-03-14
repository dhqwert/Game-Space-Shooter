using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints; // Mảng chứa danh sách các điểm [cite: 873]

    private void Reset()
    {
        waypoints = GetComponentsInChildren<Waypoint>(); 
    }
}