using UnityEngine;

public class PlayerWorp : MonoBehaviour
{
    [Header("ワープしたときに出現する位置")]
    [SerializeField] private GameObject warpPosition = null;

    private void Start()
    {
        warpPosition =GameObject.Find("WarpBoxPosition");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Warp")
        {
            Debug.Log("ｆｆｆ");
            this.gameObject.transform.position = warpPosition.transform.position;
        }
    }
}
