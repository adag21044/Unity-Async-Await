using System.Threading.Tasks;
using UnityEngine;

public class MoveForwardCommand : ICommand
{
    public async Task Execute()
    {
        await PlayerMovementManager.Instance.MoveAsync(Vector3.forward);
    }
}