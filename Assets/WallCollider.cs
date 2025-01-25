using UnityEngine;

public class WallCollider : MonoBehaviour
{
    [Header("Collision")]
    [SerializeField] LayerMask Wall;

    private SfxScript Sfx;
    private VfxScript Vfx;

    private void Awake()
    {
        Sfx = GetComponent<SfxScript>();
        Vfx = GetComponent<VfxScript>();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((Wall.value & (1 << hit.gameObject.layer)) > 0)
        {
            Sfx.PlayAudioCLip();
            Vfx.ParticleEffect();
        }
    }
}
