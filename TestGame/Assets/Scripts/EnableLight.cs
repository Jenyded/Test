using UnityEngine;

public class EnableLight : MonoBehaviour
{
    public Light _mainLight;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            _mainLight.enabled = !_mainLight.enabled;   
    }
}
