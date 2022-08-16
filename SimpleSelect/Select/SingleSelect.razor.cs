namespace Components.Select;
public partial class SingleSelect<TModel> where TModel : Entity
{
    [Parameter] public List<TModel> Datasource { get; set; }
    [Parameter] public string DefaultSelectLabel { get; set; }


    protected override void OnInitialized()
    {
        if (Datasource is null)
            Datasource = new List<TModel>();

        if (string.IsNullOrEmpty(DefaultSelectLabel))
            DefaultSelectLabel = "Select";

        base.OnInitialized();
    }

    bool isOpen;
    private void OnClickSelect()
    {
        isOpen = !isOpen;
    }
}
