using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    private MeshRenderer _mesh;
    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            _mesh.material.color = Color.green;
    }
}
