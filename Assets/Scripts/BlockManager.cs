using UnityEngine;
using System.Collections.Generic;

public class BlockManager : MonoBehaviour
{
    public GameObject blockPrefab;
    private List<GameObject> blocks = new List<GameObject>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlaceBlock();
        }
        if (Input.GetMouseButtonDown(1))
        {
            RemoveBlock();
        }
    }

    void PlaceBlock()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            GameObject block = Instantiate(blockPrefab, hit.point + Vector3.up * 0.5f, Quaternion.identity);
            blocks.Add(block);
        }
    }

    void RemoveBlock()
    {
        // Logic to remove block
        if (blocks.Count > 0)
        {
            Destroy(blocks[blocks.Count - 1]);
            blocks.RemoveAt(blocks.Count - 1);
        }
    }
}