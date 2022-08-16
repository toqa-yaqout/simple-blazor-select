namespace Components.Select;
public partial class SingleSelect<TEntity> where TEntity : Entity
{
    [Parameter] public List<TEntity> Datasource { get; set; }
    [Parameter] public string DefaultSelectLabel { get; set; }
    [Parameter] public TEntity Value { get; set; }
    [Parameter] public EventCallback<TEntity> ValueChanged { get; set; }

    bool isOpen;

    protected override void OnInitialized()
    {
        if (Datasource is null)
            Datasource = new List<TEntity>();

        if (string.IsNullOrEmpty(DefaultSelectLabel))
            DefaultSelectLabel = "Select";

        base.OnInitialized();
    }

    private void OnClickSelect()
    {
        isOpen = !isOpen;
    }

    private async void OnSelectItem(TEntity entity)
    {
        Value = entity;
        await ValueChanged.InvokeAsync(entity);
    }
}
