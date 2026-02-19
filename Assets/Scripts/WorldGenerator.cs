using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    public int width = 10;
    public int height = 1;
    public int depth = 10;

    void Start()
    {
        GenerateWorld();
    }

    void GenerateWorld()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < depth; z++)
            {
                Instantiate(blockPrefab, new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }
}