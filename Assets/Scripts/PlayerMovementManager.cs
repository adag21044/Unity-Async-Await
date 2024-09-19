using System.Threading.Tasks;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    public static PlayerMovementManager Instance { get; private set; }

    public float moveSpeed = 5f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public async Task MoveAsync(Vector3 direction)
    {
        // Hareketi başlatmadan önce kısa bir bekleme yapıyoruz (örneğin 1 saniye)
        await Task.Delay(1000);

        _rigidbody.velocity = direction * moveSpeed;

        // Hareket sırasında bir işlem (örneğin bekleme) yapabiliriz
        await Task.Delay(1000);

        // Hareketi durdurmak için velocity'yi sıfırlıyoruz
        _rigidbody.velocity = Vector3.zero;
    }
}
