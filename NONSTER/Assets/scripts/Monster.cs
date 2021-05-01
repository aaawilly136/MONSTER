using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float Speed = 3.5f;
    [Header("攻擊力"), Range(0, 500)]
    public float Attack = 100;
    [Header("血量"), Range(0, 5000)]
    public float Hp = 350;
    [Header("掉落道具"), Tooltip("遊戲物件")]
    public GameObject item;
    [Header("道具掉落機率"), Range(0, 1)]
    public int ItemDrop = 1;
    [Header("道具掉落音效"), Tooltip("掉落道具時撥放聲音")]
    public AudioClip ItemDropSound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
}
