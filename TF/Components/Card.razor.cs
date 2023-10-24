using Microsoft.AspNetCore.Components;

namespace TF.Components
{
    public partial class Card
    {
        [Parameter]
        [EditorRequired]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Title { get; set; }
    }
}
