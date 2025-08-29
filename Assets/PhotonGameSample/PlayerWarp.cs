using UnityEngine;

public class PlayerWorp : MonoBehaviour
{
    [Header("���[�v�����Ƃ��ɏo������ʒu")]
    [SerializeField] private GameObject warpPosition = null;

    private void Start()
    {
        warpPosition =GameObject.Find("WarpBoxPosition");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Warp")
        {
            Debug.Log("������");
            this.gameObject.transform.position = warpPosition.transform.position;
        }
    }
}
