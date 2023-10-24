using Microsoft.AspNetCore.Components;

namespace TF.Components
{
    public partial class Button
    {
        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public string LeftIconClass { get; set; }

        [Parameter]
        public string RightIconClass { get; set; }

        [Parameter]
        public string Type { get; set; } = "button";

        [Parameter]
        public EventCallback OnClick { get; set; }
    }
}
