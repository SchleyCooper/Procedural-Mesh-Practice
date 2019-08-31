using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ProceduralQuad : MonoBehaviour
{
    private Vector3[] vertices;
    private int[] triangles;

    private Mesh mesh;

    private MeshFilter filter;
    private MeshRenderer renderer;

    private void Awake()
    {
        filter = GetComponent<MeshFilter>();
        renderer = GetComponent<MeshRenderer>();

        mesh = filter.mesh;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetMeshData();
        GenerateMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetMeshData()
    {
        vertices = new Vector3[] { new Vector3(0, 0, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0), new Vector3(1, 0, 1) };
        triangles = new int[] { 0, 1, 2, 2, 1, 3 };
    }

    void GenerateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
