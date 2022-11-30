namespace BlazorECSiteSample.Client.States;

public interface ICartState
{
    ValueTask UpdateAsync();
    
    event Action<int> OnQuantityChanged;
}