using BlazorECSiteSample.Client.Shared.Errors;
using BlazorECSiteSample.Shared.Entities;
using Blazored.LocalStorage;

namespace BlazorECSiteSample.Client.States;

public class CartStates : ICartState
{
    private readonly ILocalStorageService _localStorageService;
    
    public event Action<int> OnQuantityChanged; 

    public CartStates(ILocalStorageService localStorageService)
        => _localStorageService = localStorageService;
    
    public async ValueTask UpdateAsync()
    {
        var carts = await _localStorageService.GetItemAsync<List<CartStorage>>("cart");
        var count = carts?.Sum(x => x.Quantity) ?? 0;
        
        OnQuantityChanged.Invoke(count);
    }
}