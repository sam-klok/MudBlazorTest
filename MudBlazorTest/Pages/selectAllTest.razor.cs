namespace MudBlazorTest.Pages
{
    public partial class SelectAllTest
    {
        private string value { get; set; } = "Nothing selected";
        private IEnumerable<string> options { get; set; } = new HashSet<string>() { "Lion" };

        private string[] felines =
        {
            "Jaguar", "Leopard", "Lion", "Lynx", "Panther", "Puma", "Tiger"
        };

        private string GetMultiSelectionText(List<string> selectedValues)
        {
            return $"{selectedValues.Count} feline{(selectedValues.Count > 1 ? "s have" : " has")} been selected";
        }
    }
}
