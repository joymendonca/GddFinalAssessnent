using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_dynamic : MonoBehaviour
{
    public Material[] RandomMaterials;
    int RandomMat;
    void Start()
    {
        RandomMat = Random.Range(0, 4);
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = RandomMaterials[RandomMat];

    }
}
