using UnityEngine;
public class Touch : Sense
{
    void OnTriggerEnter(Collider other)
    {
        aspect aspect = other.GetComponent<aspect>();
        if (aspect != null)
        {
            //Check the aspect
            if (aspect.aspectType != aspectName)
            {
                print("Enemy Touch Detected");
            }
        }
    }
}