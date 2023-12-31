using UnityEngine;

public class EnvironmentConfig
{
    public static Vector3 gravity {
        get { 
            return Physics.gravity;
        }
        set {
            Physics.gravity = value;
        }
    }
    public static float temperature = 300; //kelvin
    public static float linearDrag = 3;
    public static bool Paused = false;
    public static bool ShowGizmoz = false;
}
