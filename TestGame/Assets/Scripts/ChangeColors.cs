using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private MeshRenderer _mesh;

    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            _mesh.material.color = Color.green;
    }
}
