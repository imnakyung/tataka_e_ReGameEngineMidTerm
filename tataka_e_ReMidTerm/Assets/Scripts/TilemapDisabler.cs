using UnityEngine;
using UnityEngine.Tilemaps;
public class TilemapDisabler : MonoBehaviour
{
    public void Awake()
    {
        GetComponent<TilemapRenderer>().enabled = false;
    }

}
